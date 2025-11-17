using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class fAddTuaSach : Form
    {
        private List<TACGIA> TacGiaList;

        public fAddTuaSach()
        {
            InitializeComponent();
        }

        private void fAddTuaSach_Load(object sender, EventArgs e)
        {
            // Load thể loại
            comTheLoai.DataSource = BUSTheLoai.Instance.GetAllTheLoai();
            comTheLoai.ValueMember = "id";
            comTheLoai.DisplayMember = "TenTheLoai";

            BindingTacGia();

            // Setup DataGridView
            dataTenTuaSacTuaSach.Columns.Clear();

            DataGridViewTextBoxColumn colTen = new DataGridViewTextBoxColumn();
            colTen.Name = "TenTacGia";
            colTen.HeaderText = "Tên tác giả";
            colTen.DataPropertyName = "TenTacGia";

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "TacGiaId";
            colId.HeaderText = "ID";
            colId.DataPropertyName = "id";
            colId.Visible = false;

            dataTenTuaSacTuaSach.Columns.Add(colTen);
            dataTenTuaSacTuaSach.Columns.Add(colId);

            dataTenTuaSacTuaSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTenTuaSacTuaSach.RowHeadersVisible = false;
            dataTenTuaSacTuaSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataTenTuaSacTuaSach.KeyDown += dataTenTuaSacTuaSach_KeyDown;
        }

        // Load danh sách tác giả lên combobox
        private void BindingTacGia()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            comboBoxTacGia.DataSource = TacGiaList;
            comboBoxTacGia.DisplayMember = "TenTacGia";
            comboBoxTacGia.ValueMember = "id";
        }

        private void butAddTacGia_Click(object sender, EventArgs e)
        {
            string tenTacGia = comboBoxTacGia.Text.Trim();
            if (string.IsNullOrEmpty(tenTacGia))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTacGia = -1;
            TACGIA existing = TacGiaList.FirstOrDefault(t => t.TenTacGia.Equals(tenTacGia, StringComparison.OrdinalIgnoreCase));

            if (existing != null)
            {
                idTacGia = existing.id;
            }
            else
            {
                var ask = MessageBox.Show(
                    $"Tác giả '{tenTacGia}' chưa có, bạn có muốn thêm mới?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    idTacGia = BUSTacGia.Instance.AddTacGia(tenTacGia);
                    BindingTacGia();

                    if (idTacGia <= 0)
                    {
                        MessageBox.Show("Không thể thêm tác giả mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else return;
            }

            // Kiểm tra trùng
            foreach (DataGridViewRow row in dataTenTuaSacTuaSach.Rows)
            {
                if (row.Cells["TacGiaId"].Value != null &&
                    Convert.ToInt32(row.Cells["TacGiaId"].Value) == idTacGia)
                {
                    MessageBox.Show("Tác giả này đã có trong danh sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Thêm vào Grid
            dataTenTuaSacTuaSach.Rows.Add(tenTacGia, idTacGia);
        }

        private void dataTenTuaSacTuaSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataTenTuaSacTuaSach.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataTenTuaSacTuaSach.SelectedRows)
                    {
                        if (row.IsNewRow)
                            continue;

                        var confirm = MessageBox.Show(
                            "Xóa tác giả này?",
                            "Xác nhận",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (confirm == DialogResult.Yes)
                        {
                            dataTenTuaSacTuaSach.Rows.Remove(row);
                        }
                    }

                    e.Handled = true; 
                }
            }
        }


        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtTenTuaSach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tựa sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comTheLoai.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataTenTuaSacTuaSach.Rows.Count <= 1 && dataTenTuaSacTuaSach.Rows[0].IsNewRow)
            {
                MessageBox.Show("Chưa thêm tác giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<TACGIA> TgList = new List<TACGIA>();
            string tenTuaSach = txtTenTuaSach.Text;
            int theLoaiId = Convert.ToInt32(comTheLoai.SelectedValue);

            THELOAI theLoai = BUSTheLoai.Instance.GetTheLoai(theLoaiId);

            foreach (DataGridViewRow row in dataTenTuaSacTuaSach.Rows)
            {
                if (row.IsNewRow) continue;

                int tacGiaId = Convert.ToInt32(row.Cells["TacGiaId"].Value);

                TACGIA tg = BUSTacGia.Instance.GetTacGia(tacGiaId);
                if (tg != null && !TgList.Any(t => t.id == tg.id))
                    TgList.Add(tg);
            }

            string err = BUSTuaSach.Instance.AddTuaSach(tenTuaSach, theLoai, TgList);

            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thêm tựa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
