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
    public partial class fAddSachDaCo : Form
    {
        List<SACH> SachNhap;
        int TongTien;
        public fAddSachDaCo()
        {
            InitializeComponent();
            CreateColumns(); 
            List<SACH> SachList = BUSSach.Instance.GetAllSach();
            foreach (SACH sach in SachList)
            {
                sach.MaSach = sach.TUASACH.TenTuaSach + "(" + sach.MaSach + ")";
            }
            comSachNhap.DataSource = SachList;
            comSachNhap.DisplayMember = "MaSach";
            comSachNhap.ValueMember = "id";
            TongTien = 0;
        }


        private void CreateColumns()
        {
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("id", "ID");
            dataGridView.Columns.Add("MaSach", "Mã Sách");
            dataGridView.Columns.Add("TenTuaSach", "Tên Tựa");
            dataGridView.Columns.Add("DonGia", "Đơn giá");
            dataGridView.Columns.Add("SoLuong", "Số lượng");
            dataGridView.Columns.Add("ThanhTien", "Thành tiền");

            dataGridView.Columns["id"].Visible = false;
        }


        private void butAdd_Click_1(object sender, EventArgs e)
        {
            int SoLuongNhap;
            if (txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Chưa điền số lượng nhập");
                return;
            }
            try
            {
                SoLuongNhap = Convert.ToInt32(txtSoLuongNhap.Text);
            }
            catch
            {
                MessageBox.Show("Sai format", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SoLuongNhap <= 0)
            {
                MessageBox.Show("Số lượng nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SACH sach = BUSSach.Instance.GetSach(Convert.ToInt32(comSachNhap.SelectedValue));
            if (sach.NamXB > dateTimePicker1.Value.Year)
            {
                MessageBox.Show("Năm xuất bản của sách lớn hơn ngày nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ThanhTien = SoLuongNhap * (int)sach.DonGia;
            TongTien += ThanhTien;
            labelThanhTien.Text = "Tổng tiền: " + TongTien.ToString();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["id"].Value) == sach.id)
                {
                    row.Cells["SoLuong"].Value = Convert.ToInt32(row.Cells["SoLuong"].Value) + SoLuongNhap;
                    row.Cells["ThanhTien"].Value = Convert.ToInt32(row.Cells["ThanhTien"].Value) + ThanhTien;
                    return;
                }
            }
            dataGridView.Rows.Add(sach.id, sach.MaSach, sach.TUASACH.TenTuaSach, sach.DonGia, SoLuongNhap, ThanhTien);
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            DateTime NgayNhap = dateTimePicker1.Value.Date;
            if (NgayNhap.Date > DateTime.Now)
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
                return;
            }
            int pn = BUSPhieuNhap.Instance.AddPhieuNhap(NgayNhap);
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                SACH sach = BUSSach.Instance.GetSach(id);
                if (sach.NamXB > NgayNhap.Year)
                {
                    MessageBox.Show("Sách " + sach.MaSach + " có năm xuất bản lớn hơn ngày nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                int DonGia = Convert.ToInt32(row.Cells["donGia"].Value);
                int SoLuongNhap = Convert.ToInt32(row.Cells["SoLuong"].Value);
                BUSCT_PhieuNhap.Instance.AddCtPhieuNhap(pn, id, DonGia, SoLuongNhap);
            }
            MessageBox.Show("Thêm phiếu nhập thành công");
            this.Close();
        }

        private void SachGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TongTien = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {

                TongTien += Convert.ToInt32(row.Cells["ThanhTien"].Value);
            }
            labelThanhTien.Text = "Tổng tiền: " + TongTien;
        }
    }
}
