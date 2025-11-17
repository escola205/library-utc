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
    public partial class ucQLBaoCaoThongKe : UserControl
    {
        public ucQLBaoCaoThongKe()
        {
            InitializeComponent();
            this.Load += ucQLBaoCaoThongKe_Load;
        }

        private void ucQLBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            ucMuonTheoTheLoai ucMuonTheoTheLoai = new ucMuonTheoTheLoai();
            LoadUserControl(ucMuonTheoTheLoai);
        }

        private void LoadUserControl(UserControl uc)
        {
            loadContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            loadContent.Controls.Add(uc);
        }

        private void btnViewMuon_Click(object sender, EventArgs e)
        {
            ucMuonTheoTheLoai ucMuonTheoTheLoai = new ucMuonTheoTheLoai();
            LoadUserControl(ucMuonTheoTheLoai);
        }

        private void btnViewLoadSachTra_Click(object sender, EventArgs e)
        {
            ucSachTraTre ucSachTraTre = new ucSachTraTre(); 
            LoadUserControl(ucSachTraTre);
        }
    }
}
