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
    public partial class fAddSachMoi : Form
    {
        public fAddSachMoi()
        {
            InitializeComponent();
            List<TUASACH> TuaSachList = BUSTuaSach.Instance.GetAllTuaSach();
            foreach (TUASACH ts in TuaSachList)
            {
                ts.TenTuaSach = ts.TenTuaSach + " (" + ts.MaTuaSach + ")";
            }

            comTuaSach.DataSource = TuaSachList;
            comTuaSach.DisplayMember = "TenTuaSach";
            comTuaSach.ValueMember = "id";
            dataNgayNhap.Value = DateTime.Now;
        }
        private int DonGia = 0;
        private int SoLuongNhap = 0;
        private void butOK_Click(object sender, EventArgs e)
        {
            if (dataNgayNhap.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Ngày nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comTuaSach.SelectedValue == null || txtNamXuatBan.Text == "" || txtNhaSanXuat.Text == "" || txtDonGia.Text == "" || txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Nam;
            try
            {
                Nam = Convert.ToInt32(txtNamXuatBan.Text);
            }
            catch
            {
                txtNamXuatBan.Text = null;
                MessageBox.Show("Năm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string NXB = txtNhaSanXuat.Text.ToString();
            DateTime NgayNhap = dataNgayNhap.Value.Date;
            if (Nam > NgayNhap.Year)
            {
                MessageBox.Show("Ngày nhập trước năm xuất bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ThanhTien = this.SoLuongNhap * this.DonGia;
            int id = (int)comTuaSach.SelectedValue;
            labelThanhTien.Text = "Thành tiền: " + ThanhTien.ToString();
            Tuple<string, int> kq = BUSSach.Instance.AddSach(id, this.SoLuongNhap, this.DonGia, Nam, NXB);
            int idSach = kq.Item2;
            string err = kq.Item1;
            if (err != "")
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int MaPhieuNhap = BUSPhieuNhap.Instance.AddPhieuNhap(NgayNhap);
            if (MaPhieuNhap == -1)
            {
                MessageBox.Show("Ngày nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BUSSach.Instance.DelSach(idSach);
                return;
            }
            err = BUSCT_PhieuNhap.Instance.AddCtPhieuNhap(MaPhieuNhap, idSach, DonGia, SoLuongNhap);
            if (err != "")
            {
                BUSSach.Instance.DelSach(idSach);

                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm sách mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongNhap.Text == null || txtSoLuongNhap.Text == "") return;

            try
            {
                this.SoLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);

            }
            catch
            {
                MessageBox.Show("Không đúng format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongNhap.Text = null;
                return;
            }
            if (txtDonGia.Text == null || txtSoLuongNhap.Text == null) return;
            //soLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);

            int ThanhTien = DonGia * SoLuongNhap;
            labelThanhTien.Text = "Thành tiền: " + ThanhTien.ToString();

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == null || txtDonGia.Text == "") return;
            try
            {
                this.DonGia = Convert.ToInt32(txtDonGia.Text);
            }
            catch
            {
                MessageBox.Show("Không đúng format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Text = null;
                return;

            }
            int ThanhTien = DonGia * SoLuongNhap;
            labelThanhTien.Text = "Thành tiền: " + ThanhTien.ToString();

        }
    }
}
