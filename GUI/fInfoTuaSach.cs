using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class fInfoTuaSach : Form
    {
        TUASACH tuasach;
        private int id;

        public fInfoTuaSach(int _id)
        {
            InitializeComponent();
            id = _id;

            // BƯỚC 1: Gọi hàm tạo cột
            CreateColumns();

            init();

            // BƯỚC 2: Gán DataSource sau khi đã tạo cột
            List<SACH> SachList = tuasach.SACHes.ToList();
            dataGridView.DataSource = SachList;
        }

        // HÀM TẠO CỘT MỚI DỰA TRÊN THUỘC TÍNH LỚP SACH
        private void CreateColumns()
        {
            // Tắt tính năng tự động tạo cột
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            // Lưu ý: DataPropertyName KHỚP với thuộc tính trong lớp DTO.SACH

            // 1. Cột ID (Ẩn)
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "id", HeaderText = "ID", DataPropertyName = "id", Visible = false });

            // 2. Mã Sách
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "MaSach", HeaderText = "Mã Sách", DataPropertyName = "MaSach" });

            // 3. Số Lượng (Tổng)
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "SoLuong", HeaderText = "Số Lượng", DataPropertyName = "SoLuong" });

            // 4. Số Lượng Còn Lại
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "SoLuongConLai", HeaderText = "Còn Lại", DataPropertyName = "SoLuongConLai" });

            // 5. Đơn Giá
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "DonGia", HeaderText = "Đơn Giá", DataPropertyName = "DonGia" });

            // 6. Năm Xuất Bản
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "NamXB", HeaderText = "Năm XB", DataPropertyName = "NamXB" });

            // 7. Nhà Xuất Bản
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "NhaXB", HeaderText = "Nhà XB", DataPropertyName = "NhaXB" });
        }

        private void init()
        {
            // Cập nhật thông tin tựa sách
            tuasach = BUSTuaSach.Instance.GetTuaSach(id);

            labelMaTuaSach.Text = tuasach.MaTuaSach;
            labelTenTuaSach.Text = tuasach.TenTuaSach;
            labelTheLoai.Text = tuasach.THELOAI.TenTheLoai.ToString();

            // Xử lý danh sách tác giả
            string tacgia = "";
            foreach (TACGIA tg in tuasach.TACGIAs)
            {
                if (tg == null) continue;
                tacgia += tg.TenTacGia + ", ";
            }
            if (tacgia != "") tacgia = tacgia.Remove(tacgia.Length - 2, 2);

            labelDanhSachTacGia.Text = tacgia;
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            var f = new fEditTuaSach(tuasach.id);
            f.ShowDialog();
            init();

            List<SACH> SachList = tuasach.SACHes.ToList();
            dataGridView.DataSource = SachList;
        }
    }
}