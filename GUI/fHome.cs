using BUS;
using DTO;
using GUI.Usercontrols;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHome : Form
    {
        private NGUOIDUNG user;

        public fHome(int id)
        {
            InitializeComponent();

            user = BUSNguoiDung.Instance.GetNguoiDungById(id);

            this.Load += fHome_Load;
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            // Mặc định hiển thị thông tin tài khoản
            LoadUserControl(new ucHomeTTTK(user.id));
            btnTaiKhoanNguoiDung.Focus(); 
        }

        private void LoadUserControl(UserControl uc)
        {
            loadContent.Controls.Clear();   
            uc.Dock = DockStyle.Fill;        
            loadContent.Controls.Add(uc);   
        }

        private void btnTaiKhoanNguoiDung_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucHomeTTTK(user.id));
        }

        // Nút "Tra cứu sách"
        private void btnTraCuuSach_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucHomeTCS());
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bạn không có quyền truy cập chức năng này!", 
                "Lỗi Quyền Truy Cập", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning 
            );
        }
    }
}
