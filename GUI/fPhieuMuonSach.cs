using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class fPhieuMuonSach : Form
    {
        public fPhieuMuonSach()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            // Bind cuon sach
            List<CUONSACH> CuonSachList = BUSCuonSach.Instance.GetAllCuonSachAvai();
            comboCuonSach.DataSource = CuonSachList;
            comboCuonSach.DisplayMember = "MaCuonSach";
            comboCuonSach.ValueMember = "MaCuonSach"; // giá trị string

            // Bind doc gia
            var docGiaList = BUSDocGia.Instance.GetDocGiaConHan();
            comboDocGia.DataSource = docGiaList;
            comboDocGia.DisplayMember = "MaDocGia";
            comboDocGia.ValueMember = "id";

            if (CuonSachList.Count == 0) return;

            dateNgayMuon.Value = DateTime.Now.Date;

            // Lấy SelectedItem trực tiếp
            CUONSACH cuonsach = comboCuonSach.SelectedItem as CUONSACH;

            if (cuonsach != null)
            {
                labelTen.Text = "Tên: " + cuonsach.SACH.TUASACH.TenTuaSach;
                labelTheLoai.Text = "Thể loại: " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
            }

            if (docGiaList.Count != 0)
            {
                DOCGIA docgia = comboDocGia.SelectedItem as DOCGIA;

                if (docgia != null)
                {
                    labelHoTen.Text = "Họ tên: " + docgia.TenDocGia;
                    labelTongNo.Text = "Tổng nợ hiện tại: " + docgia.TongNoHienTai.ToString();
                }

                THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
                NgayMuon = dateNgayMuon.Value.Date;
                labelHanTra.Text = NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();
            }
        }

        private DateTime NgayTra;
        private DateTime NgayMuon;

        private void dateNgayMuon_ValueChanged(object sender, EventArgs e)
        {
            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();
            NgayMuon = dateNgayMuon.Value.Date;
            labelHanTra.Text = NgayMuon.AddDays((int)thamso.SoNgayMuonToiDa).ToShortDateString();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            CUONSACH cuonsach = comboCuonSach.SelectedItem as CUONSACH;
            DOCGIA docgia = comboDocGia.SelectedItem as DOCGIA;

            if (cuonsach == null)
            {
                MessageBox.Show("Cuốn sách được chọn không hợp lệ", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (docgia == null)
            {
                MessageBox.Show("Độc giả được chọn không hợp lệ", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NgayMuon = dateNgayMuon.Value.Date;

            if (NgayMuon > DateTime.Now)
            {
                MessageBox.Show("Ngày mượn không hợp lệ", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string error = BUSPhieuMuonTra.Instance.AddPhieuMuonTra(
                cuonsach.MaCuonSach,
                docgia.MaDocGia,
                NgayMuon
            );

            if (error != "")
            {
                MessageBox.Show(error, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thêm phiếu mượn thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void comboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DOCGIA docgia = comboDocGia.SelectedItem as DOCGIA;

            if (docgia != null)
            {
                labelHoTen.Text = "Họ tên: " + docgia.TenDocGia;
                labelTongNo.Text = "Tổng nợ hiện tại: " + docgia.TongNoHienTai.ToString();
            }
        }

        private void comboCuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            CUONSACH cuonsach = comboCuonSach.SelectedItem as CUONSACH;

            if (cuonsach != null)
            {
                labelTen.Text = "Tên: " + cuonsach.SACH.TUASACH.TenTuaSach;
                labelTheLoai.Text = "Thể loại: " + cuonsach.SACH.TUASACH.THELOAI.TenTheLoai;
            }
        }
    }
}
