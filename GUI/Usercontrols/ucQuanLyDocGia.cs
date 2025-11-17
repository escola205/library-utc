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
    public partial class ucQuanLyDocGia : UserControl
    {
        public ucQuanLyDocGia()
        {
            InitializeComponent();
            this.Load += ucQuanLyDocGia_Load;   

        }

        private void LoadUserControl(UserControl uc)
        {
            loadContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            loadContent.Controls.Add(uc);
        }

        private void btnViewDocGia_Click(object sender, EventArgs e)
        {
            ucDocGia ucDocGia = new ucDocGia(); 
            LoadUserControl(ucDocGia);
        }

        private void btnViewLoadDocGia_Click(object sender, EventArgs e)
        {
            ucLoaiDocGia ucLoaiDocGia = new ucLoaiDocGia(); 
            LoadUserControl(ucLoaiDocGia);
        }

        private void ucQuanLyDocGia_Load(object sender, EventArgs e)
        {
           ucDocGia ucDocGia = new ucDocGia();
           LoadUserControl(ucDocGia);
        }
    }
}
