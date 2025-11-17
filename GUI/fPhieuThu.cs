using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fPhieuThu : Form
    {
        public fPhieuThu()
        {
            InitializeComponent();
            init();
        }

        private DOCGIA DocGia;
        private int TienThu;

        private void init()
        {
            TienThu = 0;
            dateNgayLap.Value = DateTime.Now.Date;

            // --- SỬA Ở ĐÂY: ĐÚNG THỨ TỰ ---
            comboDocGia.DisplayMember = "MaDocGia";
            comboDocGia.ValueMember = "ID";
            comboDocGia.DataSource = BUSDocGia.Instance.GetAllDocGia();
            // --------------------------------

            LoadDocGia();
        }

        private void LoadDocGia()
        {
            if (comboDocGia.SelectedValue == null)
                return;

            int id;
            if (!int.TryParse(comboDocGia.SelectedValue.ToString(), out id))
                return;

            DocGia = BUSDocGia.Instance.GetDocGia(id);

            labelTongNoHienTai.Text = DocGia.TongNoHienTai.ToString();
        }

        private void comboDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDocGia();
            TienThu = 0;
            labelTongNoMoi.Text = "";
            txtSotienthu.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtSotienthu.Text == "")
            {
                MessageBox.Show("Chưa nhập số tiền thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TienThu = Convert.ToInt32(txtSotienthu.Text);

            if (dateNgayLap.Value > DateTime.Now.Date || dateNgayLap.Value.Date < DocGia.NgayLapThe)
            {
                MessageBox.Show("Ngày lập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string err = BUSPhieuThu.Instance.AddPhieuThu(DocGia.ID, TienThu, dateNgayLap.Value.Date);

            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }

            MessageBox.Show("Thêm phiếu thu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtSotienthu_TextChanged(object sender, EventArgs e)
        {
            if (txtSotienthu.Text == "")
            {
                labelTongNoMoi.Text = "";
                return;
            }

            try
            {
                TienThu = Convert.ToInt32(txtSotienthu.Text);
            }
            catch
            {
                txtSotienthu.Text = "";
                MessageBox.Show("Số tiền thu sai format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            THAMSO thamso = BUSThamSo.Instance.GetAllThamSo();

            if (thamso.AD_QDKTTienThu == 1 && TienThu > DocGia.TongNoHienTai)
            {
                txtSotienthu.Text = "";
                MessageBox.Show("Số tiền thu vượt quá quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelTongNoMoi.Text = labelTongNoHienTai.Text;
                return;
            }

            labelTongNoMoi.Text = (DocGia.TongNoHienTai - TienThu).ToString();
        }
    }
}
