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
    public partial class fAddNhomND : Form
    {
        public fAddNhomND()
        {
            InitializeComponent();
            CreateColumns();
            Bind();
        }

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

            dataGridView.Columns.Add("MaChucNang", "Mã chức năng");

            dataGridView.Columns.Add("TenChucNang", "Tên chức năng");

            dataGridView.Columns.Add("TenManHinh", "Tên màn hình");
        }

        private void Bind()
        {
            dataGridView.Rows.Clear(); 
            var dscn = BUSChucNang.Instance.GetAllChucNang();

            foreach (var cn in dscn)
            {
                dataGridView.Rows.Add(false, cn.MaChucNang, cn.TenChucNang, cn.TenManHinh);
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
            int id = BUSNhomNguoiDung.Instance.AddNhomNguoiDung(ten);
            if (id == -1)
            {
                return;
            }
            List<String> dsCn = new List<String>();
            foreach (DataGridViewRow row in this.dataGridView.Rows)
            {
                //Console.WriteLine(row.Cells["isChoosen"].Value);
                if (row.Cells["isChoosen"].Value.ToString() == "1")
                {
                    //Console.WriteLine(row.Cells["MaChucNang"].Value.ToString());
                    dsCn.Add(row.Cells["MaChucNang"].Value.ToString());
                }
            }
            string res = BUSNhomNguoiDung.Instance.AddChucNangForNhom(id, dsCn);
            if (res == "") MessageBox.Show("Thêm nhóm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(res, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
