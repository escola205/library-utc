using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Usercontrols
{
    public partial class ucHomeTTTK : UserControl
    {
        private static DOCGIA dg;
        private static NGUOIDUNG user;

        public ucHomeTTTK(int idNguoiDung)
        {
            InitializeComponent();

            CreateColumns();

            dg = BUSDocGia.Instance.FindDocGiaByIdND(idNguoiDung);
            user = BUSNguoiDung.Instance.GetNguoiDungById(idNguoiDung);
            Binding();
        }

        private void CreateColumns()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("SoPhieuMuonTra", "Số Phiếu Mượn");
            dataGridView.Columns.Add("MaCuonSach", "Mã Cuốn Sách");
            dataGridView.Columns.Add("TenTuaSach", "Tên Tựa Sách");
            dataGridView.Columns.Add("NgayMuon", "Ngày Mượn");
            dataGridView.Columns.Add("HanTra", "Hạn Trả");
            dataGridView.Columns.Add("NgayTra", "Ngày Trả"); 
            dataGridView.Columns.Add("SoTienPhat", "Tiền Phạt (VNĐ)"); 
        }

        private void Binding()
        {
            dataGridView.Rows.Clear();

            labelMDG.Text = dg.MaDocGia;
            labelLoaiDocGia.Text = dg.LOAIDOCGIA.TenLoaiDocGia;
            labelDiaChi.Text = dg.DiaChi;
            labelEmail.Text = dg.Email;
            labelHoTen.Text = dg.TenDocGia;
            labelNgayHetHan.Text = dg.NgayHetHan.ToShortDateString();
            labelNgayLapThe.Text = dg.NgayLapThe.ToShortDateString();
            labelNgaySinh.Text = dg.NgaySinh.ToShortDateString();
            lbTenDangNhap.Text = "Tên đăng nhập: " + user.TenDangNhap;
            labelTongNoHienTai.Text = dg.TongNoHienTai.ToString();

            var phieumuonList = BUSPhieuMuonTra.Instance.FindPhieuMuonByDocGia(dg.ID);

            if (phieumuonList.Any())
                foreach (var pm in phieumuonList)
                {
                    string ngayTra = (pm.NgayTra != null ? pm.NgayTra.Value.ToShortDateString() : "Chưa trả");
                    string soTienPhat = (pm.SoTienPhat != null ? pm.SoTienPhat.Value.ToString() : "");

                    dataGridView.Rows.Add(pm.SoPhieuMuonTra, pm.CUONSACH.MaCuonSach,
                        pm.CUONSACH.SACH.TUASACH.TenTuaSach, pm.NgayMuon.ToShortDateString(), pm.HanTra.ToShortDateString(),
                        ngayTra, soTienPhat);
                }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // Giả định bạn có form frmDoiMatKhau
            var f = new frmDoiMatKhau(user.id);
            f.ShowDialog();
        }
    }
}