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
    public partial class fEditTheLoai : Form
    {
        THELOAI theloai;
        public fEditTheLoai(int id)
        {
            InitializeComponent();
            theloai = BUSTheLoai.Instance.GetTheLoai(id);
            labeTheLoai.Text += theloai.MaTheLoai;
            txtTenTheLoai.Text = theloai.TenTheLoai;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text == "")
            {
                MessageBox.Show("Tên thể loại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool Error = BUSTheLoai.Instance.UpdTheLoai(theloai.id, txtTenTheLoai.Text);
            if (Error)
            {
                MessageBox.Show("Sửa thông tin thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
