using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Usercontrols
{
    public partial class ucSach : UserControl
    {
        public ucSach()
        {
            InitializeComponent();
            CreateColumns();
            Binding(BUSSach.Instance.GetAllSach());
            cbLocTinhTrang.Items.Add("Còn");
            cbLocTinhTrang.Items.Add("Hết");
            cbLocTinhTrang.Items.Add("Chưa ẩn");
            cbLocTinhTrang.Items.Add("Đã ẩn");

        }
        private List<SACH> SachList;

        private void CreateColumns()
        {
            dataGridViewSach.AutoGenerateColumns = false;
            dataGridViewSach.Columns.Clear();

            // Checkbox column
            var checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "isChosen";
            checkCol.HeaderText = "";
            checkCol.Width = 30;
            checkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkCol.TrueValue = true;
            checkCol.FalseValue = false;
            dataGridViewSach.Columns.Add(checkCol);

            // Các cột khác
            dataGridViewSach.Columns.Add("id", "ID");
            dataGridViewSach.Columns.Add("MaSach", "Mã Sách");
            dataGridViewSach.Columns.Add("MaTuaSach", "Mã Tựa");
            dataGridViewSach.Columns.Add("TenTuaSach", "Tên Tựa");
            dataGridViewSach.Columns.Add("NamXB", "Năm XB");
            dataGridViewSach.Columns.Add("NhaXB", "Nhà XB");
            dataGridViewSach.Columns.Add("SoLuong", "Số lượng");
            dataGridViewSach.Columns.Add("SoLuongConLai", "Còn lại");
            dataGridViewSach.Columns.Add("DaAn", "Đã Ẩn");

            // Ẩn cột
            dataGridViewSach.Columns["id"].Visible = false;
            dataGridViewSach.Columns["MaSach"].Visible = false;
        }



        public void Binding(List<SACH> SachList)
        {
            dataGridViewSach.Rows.Clear();
            foreach (SACH sach in SachList)
            {
                dataGridViewSach.Rows.Add(false, sach.id, sach.MaSach, sach.TUASACH.MaTuaSach, sach.TUASACH.TenTuaSach, sach.NamXB, sach.NhaXB, sach.SoLuong, sach.SoLuongConLai, sach.DaAn);
            }

        }
        private void ucSach_Load(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
        }


        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddSachMoi();
            f.ShowDialog();
            Binding(BUSSach.Instance.GetAllSach());
        }

        private void butAddOld_Click(object sender, EventArgs e)
        {
            var f = new fAddSachDaCo();
            f.ShowDialog();
            Binding(BUSSach.Instance.GetAllSach());
        }



        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();

            foreach (DataGridViewRow row in dataGridViewSach.Rows)
            {
                bool isChecked =
                    row.Cells["isChosen"].Value != null &&
                    row.Cells["isChosen"].Value is bool &&
                    (bool)row.Cells["isChosen"].Value;

                if (isChecked)
                {
                    idDel.Add((int)row.Cells["id"].Value);
                }
            }

            if (idDel.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sách nào!", "Thông báo");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn ẩn {idDel.Count} sách?",
                                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int cnt = 0;

            foreach (int id in idDel)
            {
            Retry:
                SACH sach = BUSSach.Instance.GetSach(id);
                if (sach.DaAn == 1) continue;

                string error = BUSSach.Instance.UpdAnSach(id, 1);
                if (error != "")
                {
                    if (MessageBox.Show(error, "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }

                cnt++;
            }

            MessageBox.Show($"Đã ẩn thành công {cnt} sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding(BUSSach.Instance.GetAllSach());
        }


        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
            txtTimKiemSach.Text = "";

        }


        private void butMaSach_Click(object sender, EventArgs e)
        {
            string pat = txtTimKiemSach.Text;
            SachList = BUSSach.Instance.GetAllSach();
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in SachList)
            {
                if (sach.MaSach.Contains(pat) || sach.TUASACH.TenTuaSach.Contains(pat) || sach.TUASACH.MaTuaSach.Contains(pat))
                    Res.Add(sach);
            }
            Binding(Res);

        }

        private void butTenSach_Click(object sender, EventArgs e)
        {
            int idx = cbLocTinhTrang.SelectedIndex;
            SachList = BUSSach.Instance.GetAllSach();
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in SachList)
            {
                if (sach.SoLuongConLai > 0 && cbLocTinhTrang.Text == "Còn")
                    Res.Add(sach);
                if (sach.SoLuongConLai == 0 && cbLocTinhTrang.Text == "Hết")
                    Res.Add(sach);
                if (sach.DaAn == 1 && cbLocTinhTrang.Text == "Đã ẩn")
                    Res.Add(sach);
                if (sach.DaAn == 0 && cbLocTinhTrang.Text == "Chưa ẩn")
                    Res.Add(sach);
            }
            Binding(Res);
        }

        private void butHien_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();

            foreach (DataGridViewRow row in dataGridViewSach.Rows)
            {
                bool isChecked =
                    row.Cells["isChosen"].Value != null &&
                    row.Cells["isChosen"].Value is bool &&
                    (bool)row.Cells["isChosen"].Value;

                if (isChecked)
                {
                    idDel.Add((int)row.Cells["id"].Value);
                }
            }

            if (idDel.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sách nào!", "Thông báo");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn hiện {idDel.Count} sách?",
                                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int cnt = 0;

            foreach (int id in idDel)
            {
            Retry:
                SACH sach = BUSSach.Instance.GetSach(id);
                if (sach.DaAn == 0) continue;

                string error = BUSSach.Instance.UpdAnSach(id, 0);
                if (error != "")
                {
                    if (MessageBox.Show(error, "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }

                cnt++;
            }

            MessageBox.Show($"Đã hiện thành công {cnt} sách", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            Binding(BUSSach.Instance.GetAllSach());
        }

    }
}
