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

namespace GUI
{
    public partial class fEditPhieuMuon : Form
    {
        public fEditPhieuMuon()
        {
            InitializeComponent();
        }

        private PHIEUMUONTRA PhieuMuon;
        public fEditPhieuMuon(int idPhieuMuon)
        {
            InitializeComponent();
            PhieuMuon = BUSPhieuMuonTra.Instance.GetPhieuMuonTra(idPhieuMuon);
            init();
        }

        private void init()
        {
            labelMaCuonSach.Text += " " + PhieuMuon.CUONSACH.MaCuonSach;
            labelTen.Text += PhieuMuon.CUONSACH.SACH.TUASACH.TenTuaSach;
            labelSoPhieu.Text += PhieuMuon.SoPhieuMuonTra;
            labelNgayMuon.Text = ((DateTime)PhieuMuon.NgayMuon).ToShortDateString();
            labelHanTra.Text = ((DateTime)PhieuMuon.HanTra).ToShortDateString();
            labelHoTen.Text += " " + PhieuMuon.DOCGIA.TenDocGia;
            labelMaDocGia.Text += ": " + PhieuMuon.DOCGIA.MaDocGia;
            labelTheLoai.Text += PhieuMuon.CUONSACH.SACH.TUASACH.THELOAI.TenTheLoai;
            labelTongNo.Text += PhieuMuon.DOCGIA.TongNoHienTai.ToString();
            if (PhieuMuon.NgayTra != null)
            {
                dateNgayTra.Visible = false;
                dateNgayTra.Visible = true;
                dateNgayTra.Text = ((DateTime)PhieuMuon.NgayTra).ToShortDateString();
                btnLuu.Visible = false;
                checkNgayTra.CheckState = CheckState.Checked;
                checkNgayTra.Enabled = false;
            }
            if (PhieuMuon.NgayTra != null) dateNgayTra.Value = (DateTime)PhieuMuon.NgayTra;
            else
                dateNgayTra.Value = DateTime.Now.Date;
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            labelDonPhat.Text += thamso.DonGiaPhat.ToString();
            int TienPhat = 0;
            if (dateNgayTra.Value > PhieuMuon.HanTra)
                TienPhat = (int)((DateTime)dateNgayTra.Value - (DateTime)PhieuMuon.HanTra).TotalDays;
            labelNgayTre.Text = "Số ngày trả trễ: " + TienPhat.ToString();
            labelTienPhat.Text = "Tiền phạt: " + (thamso.DonGiaPhat * TienPhat).ToString();
            labelTongNoMoi.Text = "Tổng nợ mới: " + ((int)PhieuMuon.DOCGIA.TongNoHienTai + thamso.DonGiaPhat * TienPhat).ToString();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
