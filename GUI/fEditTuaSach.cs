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

namespace GUI
{
    public partial class fEditTuaSach : Form
    {
        TUASACH tuasach;
        List<TACGIA> TacGiaList;
        public fEditTuaSach(int id)
        {
            InitializeComponent();
            tuasach = BUSTuaSach.Instance.GetTuaSach(id);
            txtTenTuaSach.Text = tuasach.TenTuaSach;
            labelMaTuaSach.Text += " " + tuasach.MaTuaSach;
            List<THELOAI> theloai = BUSTheLoai.Instance.GetAllTheLoai();
            comTheLoai.DataSource = theloai;
            comTheLoai.DisplayMember = "TenTheLoai";
            comTheLoai.ValueMember = "id";
            int idx = 0;
            foreach (THELOAI tl in theloai)
            {
                if (tl.TenTheLoai == tuasach.THELOAI.TenTheLoai)
                    comTheLoai.SelectedIndex = idx;
                idx++;
            }
            foreach (TACGIA tg in tuasach.TACGIAs)
            {
                datagridTacGia.Rows.Add(tg.TenTacGia, tg.id);
            }
            Binding();
        }
        private void Binding()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            comboBoxTacGia.DataSource = TacGiaList;
            comboBoxTacGia.DisplayMember = "TenTacGia";
            comboBoxTacGia.ValueMember = "id";
        }


        private void butOK_Click(object sender, EventArgs e)
        {

            List<TACGIA> TgList = new List<TACGIA>();
            string TenTuaSach = txtTenTuaSach.Text;
            if (TenTuaSach == "")
            {
                MessageBox.Show("Tên tựa sách không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int TheLoai = Convert.ToInt32(comTheLoai.SelectedValue);
            THELOAI tl = BUSTheLoai.Instance.GetTheLoai(TheLoai);
            foreach (DataGridViewRow row in datagridTacGia.Rows)
            {
                if (TgList.Contains(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value))))
                    continue;
                TgList.Add(BUSTacGia.Instance.GetTacGia(Convert.ToInt32(row.Cells["id"].Value)));
            }
            string err = BUSTuaSach.Instance.UpdTuaSach(tuasach.id, TenTuaSach, tl, TgList);
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Chỉnh sửa tựa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void butAddTacGia_Click(object sender, EventArgs e)
        {
            bool check = false;
            int id = Convert.ToInt32(comboBoxTacGia.SelectedValue);
            string newTg = comboBoxTacGia.Text;
            foreach (TACGIA tg in TacGiaList)
                if (tg.TenTacGia == newTg)
                    check = true;
            if (check == false)
            {
                var ask = MessageBox.Show("Tác giả chưa có, bạn có muốn thêm mới?", "Thêm tác giả",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    id = BUSTacGia.Instance.AddTacGia(newTg);
                    Binding();
                }
                else return;
            }

            datagridTacGia.Rows.Add(newTg, id);
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {

        }

        private void datagridTacGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (datagridTacGia.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này khỏi danh sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in datagridTacGia.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                datagridTacGia.Rows.Remove(row);
                            }
                        }
                    }
                    e.Handled = true;
                }
            }
        }

        private void fEditTuaSach_Load(object sender, EventArgs e)
        {
            datagridTacGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            datagridTacGia.RowHeadersVisible = false;
            datagridTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.datagridTacGia.KeyDown += new KeyEventHandler(this.datagridTacGia_KeyDown);
        }
    }
}
