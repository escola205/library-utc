using BUS;
using DTO;
using GUI.Usercontrols;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Manager : Form
    {
        private NGUOIDUNG user;

        public Manager(int userId)
        {
            InitializeComponent();
            this.Load += Manager_Load;

            user = BUSNguoiDung.Instance.GetNguoiDungById(userId);

            if (user != null)
            {
                this.Text = "Quản lý thư viện - " + user.TenDangNhap;
            }
        }

        public Manager()
        {
            InitializeComponent();
            this.Load += Manager_Load;
        }

        
  
        private void LoadUserControl(UserControl uc)
        {
            container_body.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            container_body.Controls.Add(uc);
        }

       
        private void DisableAllButtons()
        {
            btnDocgia.Enabled = false;
            btnSach.Enabled = false;
            btnPhieuMuonTra.Enabled = false;
            btnPhieuThu.Enabled = false;
            btnBaoCao.Enabled = false;
            btnNguoiDung.Enabled = false;
            btnCaiDat.Enabled = false;
        }

        private void ApplyRolePermissions()
        {
            DisableAllButtons();

            if (user == null || user.NHOMNGUOIDUNG == null) return;

            foreach (var cn in user.NHOMNGUOIDUNG.CHUCNANGs)
            {
                switch (cn.TenChucNang)
                {
                    case "QLDG":
                        btnDocgia.Enabled = true;
                        break;

                    case "QLS":
                        btnSach.Enabled = true;
                        break;

                    case "QLPM":
                        btnPhieuMuonTra.Enabled = true;
                        break;

                    case "QLPT":
                        btnPhieuThu.Enabled = true;
                        break;

                    case "BCTK":
                        btnBaoCao.Enabled = true;
                        break;

                    case "QLND":
                        btnNguoiDung.Enabled = true;
                        break;

                    case "TDQD":
                        btnCaiDat.Enabled = true;
                        break;

                    default:
                        break;
                }
            }
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                LoadUserControl(new infTaiKhoan(user.id));
            }

            ApplyRolePermissions();
        }


        private void btnTaiKhoanNguoiDung_Click(object sender, EventArgs e)
        {
            LoadUserControl(new infTaiKhoan(this.user.id));
        }

        private void btnDocgia_Click(object sender, EventArgs e)
        {
            if (btnDocgia.Enabled)
                LoadUserControl(new ucQuanLyDocGia());
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            if (btnSach.Enabled)
                LoadUserControl(new ucQuanLySach());
        }

        private void btnPhieuMuonTra_Click(object sender, EventArgs e)
        {
            if (btnPhieuMuonTra.Enabled)
                LoadUserControl(new ucQLPhieuMuon());
        }

        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            if (btnPhieuThu.Enabled)
                LoadUserControl(new ucQLPhieuThu());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (btnBaoCao.Enabled)
                LoadUserControl(new ucQLBaoCaoThongKe());
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            if (btnNguoiDung.Enabled)
                LoadUserControl(new ucQLNguoiDung());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            if (btnCaiDat.Enabled)
                LoadUserControl(new ucThayDoiQuyDinh());
        }
    }
}
