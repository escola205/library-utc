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
    public partial class ucQLNguoiDung : UserControl
    {
        public ucQLNguoiDung()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            loadContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            loadContent.Controls.Add(uc);
        }
        private void btnViewNguoiDung_Click(object sender, EventArgs e)
        {
            ucNguoiDung ucNguoiDung = new ucNguoiDung();
            LoadUserControl(ucNguoiDung);
        }

        private void btnViewLoadNhomNguoiDung_Click(object sender, EventArgs e)
        {
            ucNhomNguoiDung ucNhomNguoiDung = new ucNhomNguoiDung();    
            LoadUserControl(ucNhomNguoiDung);
        }

        private void ucQLNguoiDung_Load(object sender, EventArgs e)
        {
            ucNguoiDung ucNguoiDung = new ucNguoiDung();
            LoadUserControl(ucNguoiDung);
        }
    }
}
