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
    public partial class ucQuanLySach : UserControl
    {
        public ucQuanLySach()
        {
            InitializeComponent();
            this.Load += ucQuanLySach_Load;
        }

        private void LoadUserControl(UserControl uc)
        {
            loadContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            loadContent.Controls.Add(uc);
        }

        private void btnViewTuaSach_Click(object sender, EventArgs e)
        {
            ucTuaSachcs ucTuaSachcs = new ucTuaSachcs();
            LoadUserControl(ucTuaSachcs);
        }

        private void btnViewSach_Click(object sender, EventArgs e)
        {
            ucSach ucSachs = new ucSach();
            LoadUserControl(ucSachs);
        }

        private void btnViewCuonSach_Click(object sender, EventArgs e)
        {
            ucCuonSach ucCuonSachs = new ucCuonSach();
            LoadUserControl(ucCuonSachs);
        }

        private void btnViewTacGia_Click(object sender, EventArgs e)
        {
            ucTacGia ucTacGias = new ucTacGia();
            LoadUserControl(ucTacGias);
        }

        private void btnViewTheLoai_Click(object sender, EventArgs e)
        {
            ucTheLoai ucTheLoais = new ucTheLoai();
            LoadUserControl(ucTheLoais);
        }

        private void btnViewPhieuNhapSach_Click(object sender, EventArgs e)
        {
            ucPhieuNhapSach ucPhieuNhapSachs = new ucPhieuNhapSach();
            LoadUserControl(ucPhieuNhapSachs);
        }

        private void ucQuanLySach_Load(object sender, EventArgs e)
        {
            ucTuaSachcs tuaSachc = new ucTuaSachcs();
            LoadUserControl(tuaSachc);
        }
    }
}
