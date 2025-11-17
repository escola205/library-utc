using BUS;
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
    public partial class fInfoPhieuNhap : Form
    {
        private static int id;
        public fInfoPhieuNhap(int _id)
        {
            InitializeComponent();
            id = _id;
            Bind();
        }

        private void Bind()
        {
            var phieu = BUSPhieuNhap.Instance.GetPhieuNhap(id);
            var dsct = phieu.CT_PHIEUNHAP.ToList();

            // Set thông tin phiếu
            labelNgayNhap.Text = phieu.NgayNhap.ToShortDateString();
            labelSoPhieuNhap.Text = phieu.SoPhieuNhap.ToString();
            labelTongTien.Text = phieu.TongTien.ToString();

            // Gán DataSource
            dataGridView.AutoGenerateColumns = false; // tự thiết kế tên cột
            dataGridView.Columns.Clear(); // xoá cột cũ

            // Tạo các cột đẹp
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MaSach",
                HeaderText = "Mã sách",
                Width = 80
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TenTuaSach",
                HeaderText = "Tên tựa sách",
                Width = 180
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DonGia",
                HeaderText = "Đơn giá",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "SoLuongNhap",
                HeaderText = "Số lượng nhập",
                Width = 120
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ThanhTien",
                HeaderText = "Thành tiền",
                Width = 120
            });

            // Gán data
            dataGridView.DataSource = dsct.Select(ct => new
            {
                MaSach = ct.SACH.MaSach,
                TenTuaSach = ct.SACH.TUASACH.TenTuaSach,
                DonGia = ct.SACH.DonGia,
                SoLuongNhap = ct.SoLuongNhap,
                ThanhTien = ct.ThanhTien
            }).ToList();
        }


    }
}
