using DTO;
using BUS;
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
    public partial class ucTuaSachcs : UserControl
    {
        public ucTuaSachcs()
        {
            InitializeComponent();
            cbLocTheLoai.DataSource = BUSTheLoai.Instance.GetAllTheLoai();
            cbLocTheLoai.DisplayMember = "TenTheLoai";
            cbLocTheLoai.ValueMember = "id";
        }
        public void Binding(List<TUASACH> TuaSachList)
        {
            dataGridViewTuaSach.Rows.Clear();

            foreach (TUASACH tuasach in TuaSachList)
            {
                string tacgia = "";

                // Gộp tên tác giả
                foreach (TACGIA tg in tuasach.TACGIAs)
                {
                    tacgia += tg.TenTacGia + ", ";
                }
                if (tacgia != "") tacgia = tacgia.Remove(tacgia.Length - 2, 2);

                // THÊM DỮ LIỆU - cột đầu tiên là CheckBox => giá trị bool
                dataGridViewTuaSach.Rows.Add(
                    false,                       // ⬅ checkbox mặc định không tick
                    tuasach.id,
                    tuasach.MaTuaSach,
                    tuasach.TenTuaSach,
                    tuasach.THELOAI.TenTheLoai,
                    tacgia,
                    tuasach.DaAn
                );
            }
        }

        private void ucTuaSach_Load(object sender, EventArgs e)
        {
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddTuaSach();
            f.ShowDialog();
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }
        private void Sorting(int idx)
        {
            //this.TuaSachGrid.Sort(this.TuaSachGrid.Columns[idx], ListSortDirection.Ascending);
        }

        private void TuaSachGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;

            if (e.ColumnIndex == 2)
            {
                var f = new fEditTuaSach((Convert.ToInt32(dataGridViewTuaSach.Rows[idx].Cells["id"].Value)));
                f.ShowDialog();
                Binding(BUSTuaSach.Instance.GetAllTuaSach());
                return;
            }

            if (e.ColumnIndex == 0) return; 

            var fInfor = new fInfoTuaSach(Convert.ToInt32(dataGridViewTuaSach.Rows[idx].Cells["id"].Value));
            fInfor.ShowDialog();
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
            return;
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            ToggleAnHien(1);
        }
        private void butHien_Click(object sender, EventArgs e)
        {
            ToggleAnHien(0);
        }

        private void ToggleAnHien(int trangThai)   // 1 = Ẩn, 0 = Hiện
        {
            List<int> selectedIds = new List<int>();

            foreach (DataGridViewRow row in dataGridViewTuaSach.Rows)
            {
                if (row.IsNewRow) continue;

                bool isChecked = row.Cells["chkSelect"].Value != null &&
                                 row.Cells["chkSelect"].Value is bool &&
                                 (bool)row.Cells["chkSelect"].Value;

                if (isChecked)
                {
                    selectedIds.Add((int)row.Cells["id"].Value);
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn tựa sách nào!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string msg = (trangThai == 1) ? "ẩn" : "hiện";

            if (MessageBox.Show($"Bạn có chắc muốn {msg} {selectedIds.Count} tựa sách?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int cnt = 0;

            foreach (int id in selectedIds)
            {
            Retry:
                string error = BUSTuaSach.Instance.UpdAnTuaSach(id, trangThai);

                if (error != "")
                {
                    if (MessageBox.Show($"Lỗi: {error} (ID: {id}) — thử lại?",
                                         "Lỗi", MessageBoxButtons.RetryCancel,
                                         MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                }
                else cnt++;
            }

            MessageBox.Show($"Đã {msg} thành công {cnt} tựa sách!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }




        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSTuaSach.Instance.GetAllTuaSach());
        }

   
        private void butFind_Click(object sender, EventArgs e)
        {
            List<TUASACH> Res = new List<TUASACH>();
            string pat = txtTimKiemTuaSach.Text.ToLower();
            foreach (TUASACH ts in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (ts.TenTuaSach.ToLower().Contains(pat) || ts.MaTuaSach.ToLower().Contains(pat))
                    Res.Add(ts);
                else
                {
                    foreach (TACGIA tg in ts.TACGIAs)
                        if (tg.TenTacGia.ToLower().Contains(pat))
                        {
                            Res.Add(ts);
                            break;
                        }
                }
            }
            Binding(Res);

        }

        private void butFil_Click(object sender, EventArgs e)
        {
            List<TUASACH> Res = new List<TUASACH>();
            THELOAI tl = BUSTheLoai.Instance.GetTheLoai((int)cbLocTheLoai.SelectedValue);
            foreach (TUASACH ts in BUSTuaSach.Instance.GetAllTuaSach())
            {
                if (ts.THELOAI.id == tl.id)
                    Res.Add(ts);
            }
            Binding(Res);
        }

        
    }
}
