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
    public partial class fInfoNhomND : Form
    {
        private static int id;
        public fInfoNhomND(int _id)
        {
            InitializeComponent();
            id = _id;
            CreateColumns(); // Gọi hàm tạo cột
            Bind();
        }
        private void CreateColumns()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "id", HeaderText = "ID", DataPropertyName = "id", Visible = false });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "MaChucNang", HeaderText = "Mã chức năng", DataPropertyName = "MaChucNang" });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "TenChucNang", HeaderText = "Tên chức năng", DataPropertyName = "TenChucNang" });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "TenManHinh", HeaderText = "Tên màn hình", DataPropertyName = "TenManHinh" });
        }

        private void Bind()
        {
            var nnd = BUSNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            this.dataGridView.DataSource = nnd.CHUCNANGs.ToList();
            this.labelMa.Text = "" + nnd.MaNhomNguoiDung.ToString();
            this.labelTen.Text = "" + nnd.TenNhomNguoiDung;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var f = new fEditNhomND(id);
            f.ShowDialog();
            Bind();
        }
    }
}
