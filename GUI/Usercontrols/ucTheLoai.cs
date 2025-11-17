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
    public partial class ucTheLoai : UserControl
    {
        public ucTheLoai()
        {
            InitializeComponent();
            Binding();

        }
        List<THELOAI> TheLoaiList;
        public void Binding()
        {
            TheLoaiList = BUSTheLoai.Instance.GetAllTheLoai();
            dataGridViewTheLoai.DataSource = TheLoaiList;

            // Ẩn cột không cần thiết
            if (dataGridViewTheLoai.Columns["id"] != null)
                dataGridViewTheLoai.Columns["id"].Visible = false;

            if (dataGridViewTheLoai.Columns["TUASACHes"] != null)
                dataGridViewTheLoai.Columns["TUASACHes"].Visible = false;

            if (dataGridViewTheLoai.Columns["CT_BCLUOTMUONTHEOTHELOAI"] != null)
                dataGridViewTheLoai.Columns["CT_BCLUOTMUONTHEOTHELOAI"].Visible = false;

            // Đổi tên cột
            dataGridViewTheLoai.Columns["MaTheLoai"].HeaderText = "Mã thể loại";
            dataGridViewTheLoai.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
        }


        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }

        private void TheLoaiGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1) return;
            var f = new fEditTheLoai(Convert.ToInt32(dataGridViewTheLoai.Rows[idx].Cells["id"].Value));
            f.ShowDialog();
            Binding();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            var tentl = txtThthTheLoai.Text;
            if (tentl == "") return;
            var tllist = BUSTheLoai.Instance.GetAllTheLoai();
            foreach (var theLoai in tllist)
            {
                if (theLoai.TenTheLoai == tentl)
                {
                    if (MessageBox.Show("Thể loại này đã có. Bạn có chắc muốn thêm?", "Thêm thể loại",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) break;
                    else return;
                }
            }
            BUSTheLoai.Instance.AddTheLoai(tentl);
            MessageBox.Show("Thêm thể loại thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Binding();
        }
    }
}
