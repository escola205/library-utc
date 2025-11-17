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

namespace GUI.Usercontrols
{
    public partial class ucPhieuNhapSach : UserControl
    {
        public ucPhieuNhapSach()
        {
            InitializeComponent();
            Binding(BUSPhieuNhap.Instance.GetAllPhieuNhap());
        }

        private void HideColumns()
        {
            dataGridViewPhieuNhapSach.Columns["CT_PHIEUNHAP"].Visible = false;
        }


        public void Binding(List<PHIEUNHAPSACH> phieuNhapList)
        {
            dataGridViewPhieuNhapSach.DataSource = phieuNhapList;
            HideColumns();
        }

        private void dataGridViewPhieuNhapSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt < 0) return;

            int idPhieu = (int)dataGridViewPhieuNhapSach.Rows[stt].Cells["SoPhieuNhap"].Value;
            var f = new fInfoPhieuNhap(idPhieu);
            f.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string pat = txtTimKiem.Text.Trim().ToLower();
            List<PHIEUNHAPSACH> result = new List<PHIEUNHAPSACH>();

            foreach (var pn in BUSPhieuNhap.Instance.GetAllPhieuNhap())
            {
                if (pn.SoPhieuNhap.ToString().Contains(pat))
                    result.Add(pn);
            }

            Binding(result);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            // lấy ngày từ DateTimePicker
            DateTime selectedDate = dateLoc.Value;

            int Ngay = selectedDate.Day;
            int Thang = selectedDate.Month;
            int Nam = selectedDate.Year;

            // gọi hàm tìm kiếm
            Binding(BUSPhieuNhap.Instance.FindPhieuNhap(Ngay, Thang, Nam));
        }
    }
}
