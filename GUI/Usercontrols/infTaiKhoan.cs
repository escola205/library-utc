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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Usercontrols
{
    public partial class infTaiKhoan : UserControl
    {

        private NGUOIDUNG user;


        public infTaiKhoan(int id)
        {
            InitializeComponent();
            user = BUSNguoiDung.Instance.GetNguoiDungById(id);
            init();
        }
        private void init()
        {

            blVaiTroNguoiDung.Text = user.TenNguoiDung;
            lbTenNguoiDung.Text = user.NHOMNGUOIDUNG.TenNhomNguoiDung;
            if (user.ChucVu != null)
                lbChucVu.Text += " " + user.ChucVu;
            if (user.NgaySinh != null)
                lbNgaySinh.Text += " " + ((DateTime)user.NgaySinh).ToShortDateString();
            lbMaNguoiDung.Text += user.MaNguoiDung;
            lbTenDangNhap.Text += user.TenDangNhap;
            listView1.Clear();
            listView1.View = View.List;
            foreach (CHUCNANG cn in user.NHOMNGUOIDUNG.CHUCNANGs)
                listView1.Items.Add(cn.TenManHinh);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var f = new frmDoiMatKhau(user.id);
            f.Show();
        }
    }
}
