using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Usercontrols
{
    public partial class ucDocGia : UserControl
    {
        public ucDocGia()
        {
            InitializeComponent();
            Binding(BUSDocGia.Instance.GetAllDocGia()); 
        }

        private void Binding(List<DOCGIA> DocGiaList)
        {
            dataGridViewDocGia.Rows.Clear();
            dataGridViewDocGia.Refresh();

            foreach (DOCGIA docgia in DocGiaList)
            {
                int SachMuon = BUSDocGia.Instance.GetSoSachDangMuon(docgia.ID);

                dataGridViewDocGia.Rows.Add(
                    docgia.ID,
                    false,                          
                    docgia.MaDocGia,
                    docgia.TenDocGia,
                    docgia.LOAIDOCGIA.TenLoaiDocGia,
                    SachMuon,
                    docgia.NgayHetHan.ToShortDateString(),
                    docgia.TongNoHienTai
                );
            }
        }
        
        private void ucDocGia_Load(object sender, EventArgs e)
        {
            try
            {
                Binding(BUSDocGia.Instance.GetAllDocGia());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message + ". Vui lòng kiểm tra lại kết nối Database.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx == -1) return;

            var idValue = dataGridViewDocGia.Rows[idx].Cells["id"].Value;
            if (idValue == null) return;
            
            var fInfor = new fInforDocGia(Convert.ToInt32(idValue));
            fInfor.ShowDialog();
            Binding(BUSDocGia.Instance.GetAllDocGia());
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            string pat = txtTimKiemDocGia.Text.ToLower();
            List<DOCGIA> Res = new List<DOCGIA>();
            foreach (DOCGIA dg in BUSDocGia.Instance.GetAllDocGia())
            {
                if (dg.MaDocGia.ToLower().Contains(pat) || dg.TenDocGia.ToLower().Contains(pat))
                {
                    Res.Add(dg);
                }
            }
            Binding(Res);
        }

        private void btnLoadDocGia_Click(object sender, EventArgs e)
        {
            Binding(BUSDocGia.Instance.GetAllDocGia());
            txtTimKiemDocGia.Text = "";
        }

        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            var f = new fAddDocGia();
            f.ShowDialog();
            Binding(BUSDocGia.Instance.GetAllDocGia());
        }
    }
}