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
    public partial class ucTacGia : UserControl
    {
        List<TACGIA> TacGiaList;
        public ucTacGia()
        {
            InitializeComponent();
            Binding();
        }
        public void Binding()
        {
            TacGiaList = BUSTacGia.Instance.GetAllTacGia();
            dataGridViewTacGia.DataSource = TacGiaList;

            if (dataGridViewTacGia.Columns["id"] != null)
                dataGridViewTacGia.Columns["id"].Visible = false;

            if (dataGridViewTacGia.Columns["TUASACHes"] != null)
                dataGridViewTacGia.Columns["TUASACHes"].Visible = false;

            dataGridViewTacGia.Columns["MaTacGia"].HeaderText = "Mã tác giả";
            dataGridViewTacGia.Columns["TenTacGia"].HeaderText = "Tên tác giả";
        }


        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }

        private void TacGiaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1) return;
            var f = new fEditTacGia(Convert.ToInt32(dataGridViewTacGia.Rows[idx].Cells["id"].Value));
            f.ShowDialog();
            Binding();

        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            var tentg = txtThemTacGia.Text;
            if (tentg == "") return;
            var tglist = BUSTacGia.Instance.GetAllTacGia();
            foreach (var tg in tglist)
            {
                if (tg.TenTacGia == tentg)
                    if (MessageBox.Show("Tên tác giả này đã có, bạn có chắc muốn thêm?",
                        "Thêm tác giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) break;
                    else return;
            }
            int id = BUSTacGia.Instance.AddTacGia(tentg);
            if (id == -1) MessageBox.Show("Có lỗi xảy ra. Không thể thêm tác giả. Vui lòng kiểm tra lại!", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Thêm tác giả mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding();
        }
    }
}
