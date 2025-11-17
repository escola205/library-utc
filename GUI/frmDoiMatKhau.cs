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
    public partial class frmDoiMatKhau : Form
    {
        private NGUOIDUNG usr;
        public frmDoiMatKhau(int _id)
        {
            InitializeComponent();
            usr = BUSNguoiDung.Instance.GetNguoiDungById(_id);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (txtMatKhauHienTai.Text == "" || txtMatKhauNhapLai.Text == "" || txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhauHienTai.Text != usr.MatKhau)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhauMoi.Text != txtMatKhauNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BUSNguoiDung.Instance.UpdMK(usr.id, txtMatKhauMoi.Text);
            MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
