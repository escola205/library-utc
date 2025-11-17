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
    public partial class fEditLoaiDocGia : Form
    {
        private LOAIDOCGIA ldg;
        public fEditLoaiDocGia(int id)
        {
            InitializeComponent();
            ldg = BUSLoaiDocGia.Instance.GetLoaiDocGiaById(id);
            labelMaLoaiDocGia.Text += ldg.MaLoaiDocGia;
            txtTenDocGia.Text = ldg.TenLoaiDocGia;
        }

        private void fEditLoaiDG_Load(object sender, EventArgs e)
        {
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtTenDocGia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên loại độc giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string err = BUSLoaiDocGia.Instance.UpdLoaiDocGia(ldg.id, txtTenDocGia.Text);
            if (err == "") MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
