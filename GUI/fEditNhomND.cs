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
    public partial class fEditNhomND : Form
    {
        private static int id;
        public fEditNhomND(int _id)
        {
            InitializeComponent();
            id = _id;
            CreateColumns(); // BƯỚC 1: Gọi hàm tạo cột
            Bind();
        }

        // HÀM TẠO CỘT
        private void CreateColumns()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "isChoosen";
            checkColumn.HeaderText = "";
            checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkColumn.Width = 50;
            dataGridView.Columns.Add(checkColumn);

            dataGridView.Columns.Add("id", "ID");
            dataGridView.Columns["id"].Visible = false;

            dataGridView.Columns.Add("MaChucNang", "Mã chức năng");

            dataGridView.Columns.Add("TenChucNang", "Tên chức năng");

            dataGridView.Columns.Add("TenManHinh", "Tên màn hình");
        }

        private void Bind()
        {
            dataGridView.Rows.Clear();

            var nnd = BUSNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            labelMa.Text += nnd.MaNhomNguoiDung;
            txtTen.Text = nnd.TenNhomNguoiDung;

            var dscn = BUSChucNang.Instance.GetAllChucNang();

            foreach (var cn in dscn)
            {
                bool isSelected = nnd.CHUCNANGs.Contains(cn);

                dataGridView.Rows.Add(
                    isSelected,    
                    cn.id,
                    cn.MaChucNang,
                    cn.TenChucNang,
                    cn.TenManHinh
                );
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            if (ten == "")
            {
                MessageBox.Show("Tên nhóm người dùng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<String> dsCn = new List<String>();
            bool hasIsDGPre = false;
            bool hasIsDGPost = false;
            var nnd = BUSNhomNguoiDung.Instance.GetNhomNguoiDungById(id);
            foreach (var cn in nnd.CHUCNANGs)
            {
                if (cn.TenChucNang == "DG") { hasIsDGPre = true; break; }
            }

            foreach (DataGridViewRow row in this.dataGridView.Rows)
            {
                if (row.IsNewRow) continue; 

                object cellValue = row.Cells["isChoosen"].Value;
                bool isChecked = false;

                if (cellValue != null && cellValue is bool)
                {
                    isChecked = (bool)cellValue;
                }

                if (isChecked)
                {
                    dsCn.Add(row.Cells["MaChucNang"].Value.ToString());
                    if (row.Cells["TenChucNang"].Value.ToString() == "DG") hasIsDGPost = true;
                }
            }
            if (hasIsDGPre != hasIsDGPost)
            {
                if (nnd.NGUOIDUNGs.Count > 0)
                {
                    MessageBox.Show("Nhóm người dùng này đã có người dùng, không thể thêm/xóa chức năng độc giả!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string res = BUSNhomNguoiDung.Instance.DelChucNangForNhom(id, dsCn);

            res = BUSNhomNguoiDung.Instance.AddChucNangForNhom(id, dsCn);
            if (res == "") MessageBox.Show("Cập nhật nhóm người dùng thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(res, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}