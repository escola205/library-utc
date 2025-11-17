using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Usercontrols
{
    public partial class ucQLPhieuThu : UserControl
    {
        public ucQLPhieuThu()
        {
            InitializeComponent();
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }

      

        public void Binding(List<PHIEUTHU> PhieuThuList)
        {
            dataGridViewPhieuThu.Rows.Clear();
            foreach (PHIEUTHU pt in PhieuThuList)
            {
                dataGridViewPhieuThu.Rows.Add(
                    pt.SoPhieuThu,
                    pt.DOCGIA.MaDocGia,
                    pt.SoTienThu,
                    ((DateTime)pt.NgayLap).ToShortDateString()
                );
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuThu();
            f.ShowDialog();
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
            dtLocNgay.Checked = false;
            txtTimKiem.Text = "";
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtTimKiem.Text.ToLower();
            List<PHIEUTHU> Res = new List<PHIEUTHU>();

            foreach (PHIEUTHU pt in BUSPhieuThu.Instance.GetAllPhieuThu())
            {
                if (pt.DOCGIA.MaDocGia.ToLower().Contains(pat)
                    || pt.SoPhieuThu.ToString().Contains(pat)
                    || pt.NgayLap.ToShortDateString().Contains(pat))
                {
                    Res.Add(pt);
                }
            }

            Binding(Res);
        }

        private void butFindNgay_Click(object sender, EventArgs e)
        {
            if (!dtLocNgay.Checked)
            {
                // Nếu không check, hiển thị tất cả
                Binding(BUSPhieuThu.Instance.GetAllPhieuThu());
                return;
            }

            List<PHIEUTHU> allPhieuThu = BUSPhieuThu.Instance.GetAllPhieuThu();
            List<PHIEUTHU> filtered = new List<PHIEUTHU>();

            DateTime filterDate = dtLocNgay.Value;

            foreach (var pt in allPhieuThu)
            {
                DateTime ngayLap = (DateTime)pt.NgayLap;
                // Lọc theo full ngày, hoặc chỉ theo tháng/năm nếu muốn có thể chỉnh thêm
                if (ngayLap.Date == filterDate.Date)
                {
                    filtered.Add(pt);
                }
            }

            Binding(filtered);
        }
    }
}
