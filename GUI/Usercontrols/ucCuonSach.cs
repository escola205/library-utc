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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI.Usercontrols
{
    public partial class ucCuonSach : UserControl
    {
        public ucCuonSach()
        {
            InitializeComponent();
            CreateColumns();
            comboList = new List<string> { "Đã được mượn", "Còn", "Bị ẩn" };
            cbLocTinhTangCuonSach.DataSource = comboList;
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }

        private void CreateColumns()
        {
            dataGridViewCuonSach.Columns.Clear();

            dataGridViewCuonSach.Columns.Add("isChosen", "✓");
            dataGridViewCuonSach.Columns.Add("MaCuonSach", "Mã cuốn");
            dataGridViewCuonSach.Columns.Add("MaSach", "Mã sách");
            dataGridViewCuonSach.Columns.Add("TenTuaSach", "Tên tựa");
            dataGridViewCuonSach.Columns.Add("TinhTrang", "Tình trạng");

            // Nếu muốn checkbox:
            var chk = new DataGridViewCheckBoxColumn();
            chk.Name = "isChosen";
            chk.HeaderText = "";
            chk.Width = 30;
            chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCuonSach.Columns.Remove("isChosen");
            dataGridViewCuonSach.Columns.Insert(0, chk);
        }


        List<int> tt;
        List<string> comboList;
        public void Binding(List<CUONSACH> CuonSachList)
        {
            dataGridViewCuonSach.Rows.Clear();
            foreach (CUONSACH cs in CuonSachList)
            {
                string TinhTrang = comboList[(int)cs.TinhTrang];
                dataGridViewCuonSach.Rows.Add(0, cs.MaCuonSach, cs.SACH.MaSach, cs.SACH.TUASACH.TenTuaSach + " (" + cs.SACH.TUASACH.MaTuaSach + " )", TinhTrang);
            }

        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<string> idDel = new List<string>();

            foreach (DataGridViewRow row in dataGridViewCuonSach.Rows)
            {
                bool isChecked = row.Cells["isChosen"].Value != null &&
                                 row.Cells["isChosen"].Value is bool &&
                                 (bool)row.Cells["isChosen"].Value;

                string tinhTrang = row.Cells["TinhTrang"].Value?.ToString();

                if (isChecked && tinhTrang != "Đã được mượn")
                {
                    idDel.Add(row.Cells["MaCuonSach"].Value.ToString());
                }
            }

            if (idDel.Count == 0)
            {
                MessageBox.Show("Không có cuốn sách nào hợp lệ để ẩn!");
                return;
            }

            if (MessageBox.Show(
                $"Bạn có chắc muốn ẩn {idDel.Count} cuốn sách?",
                "Ẩn cuốn sách",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
                return;

            int cnt = 0;

            foreach (string id in idDel)
            {
                CUONSACH cs = BUSCuonSach.Instance.GetCuonSach(id);
                if (cs.DaAn == 1) continue;

                Retry:
                string error = BUSCuonSach.Instance.UpdAnCuonSach(id, 1);
                if (error != "")
                {
                    if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                        == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                cnt++;
            }

            MessageBox.Show($"Đã ẩn thành công {cnt} cuốn sách!");

            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }

        private void Sorting(int idx)
        {
            // this.CuonSachGrid.Sort(this.CuonSachGrid.Columns[idx], ListSortDirection.Descending);
        }
        private void CuonSachGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                Sorting(e.ColumnIndex);
                return;
            }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSCuonSach.Instance.GetAllCuonSach());
            txtTimKiemCuonSach.Text = "";
        }

        private void butMaSach_Click(object sender, EventArgs e)
        {
            string pat = txtTimKiemCuonSach.Text.ToLower();
            var Res = new List<CUONSACH>();
            foreach (CUONSACH cs in BUSCuonSach.Instance.GetAllCuonSach())
            {
                if (cs.MaCuonSach.ToLower().Contains(pat) || cs.SACH.MaSach.ToLower().Contains(pat) || cs.SACH.TUASACH.MaTuaSach.ToLower().Contains(pat) || cs.SACH.TUASACH.TenTuaSach.ToLower().Contains(pat))
                    Res.Add(cs);
            }
            Binding(Res);
        }

        private void butTinhTrang_Click(object sender, EventArgs e)
        {
            int idx = cbLocTinhTangCuonSach.SelectedIndex;

            var Res = new List<CUONSACH>();
            foreach (CUONSACH cs in BUSCuonSach.Instance.GetAllCuonSach())
            {
                if (cs.TinhTrang == idx) Res.Add(cs);
            }
            Binding(Res);
        }

        private void butHien_Click(object sender, EventArgs e)
        {
            List<string> idList = new List<string>();

            foreach (DataGridViewRow row in dataGridViewCuonSach.Rows)
            {
                bool isChecked = row.Cells["isChosen"].Value != null &&
                                 row.Cells["isChosen"].Value is bool &&
                                 (bool)row.Cells["isChosen"].Value;

                if (isChecked)
                {
                    idList.Add(row.Cells["MaCuonSach"].Value.ToString());
                }
            }

            if (idList.Count == 0)
            {
                MessageBox.Show("Không có cuốn sách nào được chọn để hiện!");
                return;
            }

            if (MessageBox.Show(
                $"Bạn có chắc muốn hiện {idList.Count} cuốn sách?",
                "Hiện cuốn sách",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
                return;

            int cnt = 0;

            foreach (string id in idList)
            {
                CUONSACH cs = BUSCuonSach.Instance.GetCuonSach(id);
                if (cs.DaAn == 0) continue;

                Retry:
                string error = BUSCuonSach.Instance.UpdAnCuonSach(id, 0);
                if (error != "")
                {
                    if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                        == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                cnt++;
            }

            MessageBox.Show($"Đã hiện thành công {cnt} cuốn sách!");

            Binding(BUSCuonSach.Instance.GetAllCuonSach());
        }

    }
}
