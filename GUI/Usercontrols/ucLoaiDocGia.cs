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
    public partial class ucLoaiDocGia : UserControl
    {
        public ucLoaiDocGia()
        {
            InitializeComponent();
        }
        private List<LOAIDOCGIA> LoaiDocGiaList;
        private void Binding()
        {
            LoaiDocGiaList = BUSLoaiDocGia.Instance.GetAllLoaiDocGia();
            dataGridViewLoaiDocGiaDocGia.DataSource = LoaiDocGiaList;

            if (dataGridViewLoaiDocGiaDocGia.Columns["MaLoaiDocGia"] != null)
                dataGridViewLoaiDocGiaDocGia.Columns["MaLoaiDocGia"].Visible = false;

            if (dataGridViewLoaiDocGiaDocGia.Columns["DOCGIAs"] != null)
                dataGridViewLoaiDocGiaDocGia.Columns["DOCGIAs"].Visible = false;


        }

        private void ucLoaiDocGia_Load(object sender, EventArgs e)
        {
            Binding();

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string ten =txt.Text;
            if (ten == "") return;
            string mss = BUSLoaiDocGia.Instance.AddLoaiDocGia(ten);
            if (mss == "")
            {

                MessageBox.Show("Thêm loại độc giả thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(mss);
            }
            Binding();
        }



        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding();
        }

        private void LoaiDocGiaGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            var f = new fEditLoaiDocGia(Convert.ToInt32(dataGridViewLoaiDocGiaDocGia.Rows[idx].Cells["colID"].Value));
            f.ShowDialog();
            Binding();
        }
    }
}
