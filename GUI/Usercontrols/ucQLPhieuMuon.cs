using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Usercontrols
{
    public partial class ucQLPhieuMuon : UserControl
    {
        public ucQLPhieuMuon()
        {
            InitializeComponent();
            CreateColumns();
            LoadComboTinhTrang();
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuon());
        }

   
        private void CreateColumns()
        {
            if (dataGridViewPhieuMuon.Columns.Count > 0)
                return;

            dataGridViewPhieuMuon.Columns.Add("SoPhieuMuonTra", "Số phiếu");
            dataGridViewPhieuMuon.Columns.Add("MaCuonSach", "Mã cuốn sách");
            dataGridViewPhieuMuon.Columns.Add("TenTuaSach", "Tên tựa sách");
            dataGridViewPhieuMuon.Columns.Add("MaDocGia", "Mã độc giả");
            dataGridViewPhieuMuon.Columns.Add("NgayMuon", "Ngày mượn");
            dataGridViewPhieuMuon.Columns.Add("HanTra", "Hạn trả");
            dataGridViewPhieuMuon.Columns.Add("NgayTra", "Ngày trả");
            dataGridViewPhieuMuon.Columns.Add("SoTienPhat", "Tiền phạt");

        }

       
        private void LoadComboTinhTrang()
        {
            List<string> comboList = new List<string> { "Chưa trả", "Đã trả" };
            comboTinhTrang.DataSource = comboList;
        }

   
        private void Binding(List<PHIEUMUONTRA> PhieuMuonList)
        {
            dataGridViewPhieuMuon.Rows.Clear();

            Image img = Properties.Resources.edit_icon;
            img = new Bitmap(img, new Size(20, 20));

            foreach (PHIEUMUONTRA pmt in PhieuMuonList)
            {
                string NgayTra = (pmt.NgayTra != null)
                    ? ((DateTime)pmt.NgayTra).ToShortDateString()
                    : "Chưa trả";

                dataGridViewPhieuMuon.Rows.Add(
                    pmt.SoPhieuMuonTra,
                    pmt.CUONSACH.MaCuonSach,
                    pmt.CUONSACH.SACH.TUASACH.TenTuaSach,
                    pmt.DOCGIA.MaDocGia,
                    ((DateTime)pmt.NgayMuon).ToShortDateString(),
                    ((DateTime)pmt.HanTra).ToShortDateString(),
                    NgayTra,
                    pmt.SoTienPhat
                );
            }
        }


        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fPhieuMuonSach();
            f.ShowDialog();
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuon());
        }

     
        private void dataGridViewPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Chỉ xử lý khi click vào cột Edit
            if (dataGridViewPhieuMuon.Columns[e.ColumnIndex].Name == "Edit")
            {
                int soPhieu = Convert.ToInt32(
                    dataGridViewPhieuMuon.Rows[e.RowIndex].Cells["SoPhieuMuonTra"].Value
                );

                var f = new fEditPhieuMuon(soPhieu);
                f.ShowDialog();

                Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuon());
            }
        }

    
        private void butRefresh_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            Binding(BUSPhieuMuonTra.Instance.GetAllPhieuMuon());
        }

 
        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtTimKiem.Text.ToLower();
            List<PHIEUMUONTRA> Res = new List<PHIEUMUONTRA>();

            foreach (PHIEUMUONTRA pmt in BUSPhieuMuonTra.Instance.GetAllPhieuMuon())
            {
                if (pmt.CUONSACH.MaCuonSach.ToLower().Contains(pat) ||
                    pmt.DOCGIA.MaDocGia.ToLower().Contains(pat) ||
                    pmt.SoPhieuMuonTra.ToString().Contains(pat))
                {
                    Res.Add(pmt);
                }
            }

            Binding(Res);
        }

      
        private void butFil_Click(object sender, EventArgs e)
        {
            string pat = comboTinhTrang.SelectedValue.ToString();

            List<PHIEUMUONTRA> Res = new List<PHIEUMUONTRA>();

            foreach (PHIEUMUONTRA pmt in BUSPhieuMuonTra.Instance.GetAllPhieuMuon())
            {
                if (pat == "Đã trả" && pmt.NgayTra != null)
                    Res.Add(pmt);

                if (pat == "Chưa trả" && pmt.NgayTra == null)
                    Res.Add(pmt);
            }

            Binding(Res);
        }
    }
}
