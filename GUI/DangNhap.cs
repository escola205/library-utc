using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void resetTextboxs()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            BUSLogin bLogin = new BUSLogin();
            int id = bLogin.checkValidLogin(username, password);
            if (id != -1)
            {
                MessageBox.Show("Đăng nhập thành công!\nChào mừng " + username + "!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var user = BUSNguoiDung.Instance.GetNguoiDungById(id);
                bool isDG = false;
                foreach (var cn in user.NHOMNGUOIDUNG.CHUCNANGs)
                {
                    if (cn.TenChucNang == "DG") { isDG = true; break; }
                }
                this.Hide();
                if (isDG)
                {
                    var f = new fHome(id);
                    f.ShowDialog();
                }
                else
                {
                    var f = new Manager(id);
                    f.ShowDialog();
                }
                this.resetTextboxs();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                this.resetTextboxs();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
