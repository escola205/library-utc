using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI.Usercontrols
{
    public partial class ucMuonTheoTheLoai : UserControl
    {
        public ucMuonTheoTheLoai()
        {
            InitializeComponent();
            InitColumns();   
        }

        private void InitColumns()
        {
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("MaTL", "Mã thể loại");
                dataGridView.Columns.Add("TenTL", "Tên thể loại");
                dataGridView.Columns.Add("SLM", "Số lượt mượn");
                dataGridView.Columns.Add("TiLe", "Tỉ lệ");
            }
        }

        private void ucMuonTheoTheLoai_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {
            int month = dtTaoNgay.Value.Month;
            int year = dtTaoNgay.Value.Year;

            var bc = BUSBCTheoTheLoai.Instance.GetBC(month, year);
            if (bc == null) return;

            labelTongLuotMuon.Text = "Tổng số lượt mượn: " + bc.TongSoLuotMuon;
            dataGridView.Rows.Clear();
            foreach (var c in bc.CT_BCLUOTMUONTHEOTHELOAI)
            {
                dataGridView.Rows.Add(c.THELOAI.MaTheLoai, c.THELOAI.TenTheLoai, c.SoLuotMuon, c.TiLe);
            }
        }


        private void butAdd_Click(object sender, EventArgs e)
        {
            int month = dtTaoNgay.Value.Month;
            int year = dtTaoNgay.Value.Year;

            var bc = BUSBCTheoTheLoai.Instance.GetBC(month, year);
            if (bc == null)
            {
                string err = BUSBCTheoTheLoai.Instance.AddBC(month, year);
                if (err != "")
                {
                    MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bc = BUSBCTheoTheLoai.Instance.GetBC(month, year);
            }
            labelTongLuotMuon.Text = "Tổng số lượt mượn: " + bc.TongSoLuotMuon.ToString();
            var ctbc = bc.CT_BCLUOTMUONTHEOTHELOAI;
            dataGridView.Rows.Clear();
            foreach (var c in ctbc)
            {
                dataGridView.Rows.Add(c.THELOAI.MaTheLoai, c.THELOAI.TenTheLoai, c.SoLuotMuon, c.TiLe);
            }
        }

        private void butHien_Click(object sender, EventArgs e)
        {
            int month = dtTaoNgay.Value.Month;
            int year = dtTaoNgay.Value.Year;

            var bc = BUSBCTheoTheLoai.Instance.GetBC(month, year);
            if (bc == null)
            {
                MessageBox.Show("Chưa có báo cáo trong tháng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var res = MessageBox.Show("Bạn có chắc muốn xóa báo cáo của tháng" + month.ToString() + "/" + year.ToString() + "?",
                "Xóa báo cáo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;
            BUSBCTheoTheLoai.Instance.DelBC(bc.MaBaoCao);
            MessageBox.Show("Đã xóa báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView.Rows.Clear();
        }
    }
}
