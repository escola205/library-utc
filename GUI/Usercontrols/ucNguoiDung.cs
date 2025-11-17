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
    public partial class ucNguoiDung : UserControl
    {
        public ucNguoiDung()
        {
            InitializeComponent();
            CreateColumns();
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }

        // Đặt hàm này trong lớp ucNguoiDung

        private void CreateColumns()
        {
            dataGridViewPhieuMuon.Columns.Clear();

            dataGridViewPhieuMuon.Columns.Add("id", "ID");
            dataGridViewPhieuMuon.Columns["id"].Visible = false; 

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "isChosen";
            checkColumn.HeaderText = "";
            checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkColumn.Width = 50;
            dataGridViewPhieuMuon.Columns.Add(checkColumn);

            dataGridViewPhieuMuon.Columns.Add("MaNguoiDung", "Mã người dùng");

            dataGridViewPhieuMuon.Columns.Add("TenNguoiDung", "Tên người dùng");

            dataGridViewPhieuMuon.Columns.Add("ChucVu", "Chức vụ");

            dataGridViewPhieuMuon.Columns.Add("TenDangNhap", "Tên đăng nhập");

            dataGridViewPhieuMuon.Columns.Add("TenNhomNguoiDung", "Nhóm người dùng");


            dataGridViewPhieuMuon.AutoGenerateColumns = false;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddNguoiDung();
            f.ShowDialog();
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }

        private void Bind(List<NGUOIDUNG> NguoiDungList)
        {
            dataGridViewPhieuMuon.Rows.Clear();
            Image img = Properties.Resources.edit_icon;
            img = (Image)(new Bitmap(img, new Size(20, 20)));

            foreach (NGUOIDUNG nd in NguoiDungList)
               
                dataGridViewPhieuMuon.Rows.Add(
                    nd.id,
                    false, 
                    nd.MaNguoiDung,
                    nd.TenNguoiDung,
                    nd.ChucVu,
                    nd.TenDangNhap,
                    nd.NHOMNGUOIDUNG.TenNhomNguoiDung
                );
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt == -1) return;
            if (e.ColumnIndex == 1) return;
            if (e.ColumnIndex == 7)
            {
                var fedit = new fEditNguoiDung(BUSNguoiDung.Instance.GetNguoiDung(dataGridViewPhieuMuon.Rows[stt].Cells["MaNguoiDung"].Value.ToString()).id);
                fedit.ShowDialog();
                Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
                return;
            }
            var f = new fInfoNguoiDung(BUSNguoiDung.Instance.GetNguoiDung(dataGridViewPhieuMuon.Rows[stt].Cells["MaNguoiDung"].Value.ToString()).id);
            f.Show();
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
            txtTimKiem.Text = "";
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtTimKiem.Text.ToLower();
            List<NGUOIDUNG> Res = new List<NGUOIDUNG>();
            foreach (NGUOIDUNG nd in BUSNguoiDung.Instance.GetAllNguoiDung())
            {
                if (nd.TenNguoiDung.ToLower().Contains(pat)
                    || nd.MaNguoiDung.ToLower().Contains(pat)
                    || nd.TenDangNhap.ToLower().Contains(pat))
                    Res.Add(nd);
                else if (nd.ChucVu != null && nd.ChucVu.ToLower().Contains(pat))
                    Res.Add(nd);

            }
            Bind(Res);
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<string> idDel = new List<string>();

            foreach (DataGridViewRow row in dataGridViewPhieuMuon.Rows)
            {
                if (row.Cells["isChosen"].Value is bool isChecked && isChecked)
                {
                    idDel.Add(row.Cells["MaNguoiDung"].Value.ToString());
                }
            }

            if (idDel.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn người dùng để xoá!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xoá {idDel.Count} người dùng?",
                "Xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int cnt = 0;

            foreach (string id in idDel)
            {
            Retry:
                string error = BUSNguoiDung.Instance.DelNguoidung(id);

                if (!string.IsNullOrEmpty(error))
                {
                    if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                        == DialogResult.Retry)
                        goto Retry;
                    else
                        continue;
                }
                else cnt++;
            }

            if (cnt == 0)
            {
                MessageBox.Show("Xóa thất bại! Không có người dùng nào được xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Đã xoá thành công {cnt} người dùng",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Bind(BUSNguoiDung.Instance.GetAllNguoiDung());
        }
    }
}
