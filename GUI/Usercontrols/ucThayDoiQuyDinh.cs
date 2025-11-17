using BUS;
using System;
using System.Windows.Forms;

namespace GUI.Usercontrols
{
    public partial class ucThayDoiQuyDinh : UserControl
    {
        public ucThayDoiQuyDinh()
        {
            InitializeComponent();
            Bind();
        }

        private void Bind()
        {
            var ts = BUSThamSo.Instance.GetAllThamSo();

            numTuoiMin.Value = (int)ts.TuoiToiThieu;
            numTuoiMax.Value = (int)ts.TuoiToiDa;
            numNgayMuon.Value = (int)ts.SoNgayMuonToiDa;
            numKcNam.Value = (int)ts.KhoangCachXuatBan;
            numSoSach.Value = (int)ts.SoSachMuonToiDa;
            numThoiHan.Value = (int)ts.ThoiHanThe;

            txtDonGia.Text = ts.DonGiaPhat.ToString();

            if (ts.AD_QDKTTienThu == 1) checkQDThu.Checked = true;
            else checkQDThu.Checked = false;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Đơn giá phạt không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bind();
                return;
            }

            
            string err = "";
            bool hasError = false;

            int tuoiMin = (int)numTuoiMin.Value;
            int tuoiMax = (int)numTuoiMax.Value;
            int soNgayMuon = (int)numNgayMuon.Value;
            int kc = (int)numKcNam.Value;
            int soSach = (int)numSoSach.Value;
            int thoiHan = (int)numThoiHan.Value;
            int donGia = Convert.ToInt32(txtDonGia.Text);

            err = BUSThamSo.Instance.UpdTuoiToiThieu(tuoiMin);
            if (err != "") hasError = true;

            if (!hasError)
            {
                err = BUSThamSo.Instance.UpTuoiToiDa(tuoiMax);
                if (err != "") hasError = true;
            }

            if (!hasError)
            {
                err = BUSThamSo.Instance.UpdSoNgayMuon(soNgayMuon);
                if (err != "") hasError = true;
            }

            if (!hasError)
            {
                err = BUSThamSo.Instance.UpdKCXB(kc);
                if (err != "") hasError = true;
            }

            if (!hasError)
            {
                err = BUSThamSo.Instance.UpdSoSachToiDa(soSach);
                if (err != "") hasError = true;
            }

            if (!hasError)
            {
                err = BUSThamSo.Instance.UpdThoiHanThe(thoiHan);
                if (err != "") hasError = true;
            }

            if (!hasError)
            {
                err = BUSThamSo.Instance.UpdDonGiaPhat(donGia);
                if (err != "") hasError = true;
            }

            if (!hasError)
            {
                if (checkQDThu.Checked) BUSThamSo.Instance.UpdADQDTienPhat(1);
                else BUSThamSo.Instance.UpdADQDTienPhat(0);
            }

            if (hasError)
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đã lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Bind();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "") return;

            try
            {
                var dongia = Convert.ToInt32(txtDonGia.Text);

                if (dongia <= 0)
                {
                    MessageBox.Show("Vui lòng chỉ nhập số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonGia.Text = ""; 
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Text = ""; 
            }
        }
    }
}