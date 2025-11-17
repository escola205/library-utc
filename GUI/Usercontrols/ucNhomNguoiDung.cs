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

namespace GUI.Usercontrols
{
    public partial class ucNhomNguoiDung : UserControl
    {
        public ucNhomNguoiDung()
        {
            InitializeComponent();
            CreateColumns();
            Bind();
        }
        private void Bind()
        {
            dataGridViewPhieuMuon.Rows.Clear();

            var NhomNguoiDungList = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();

            foreach (var nhomND in NhomNguoiDungList)
            {
             
                dataGridViewPhieuMuon.Rows.Add(
                    false, 
                    nhomND.MaNhomNguoiDung,
                    nhomND.TenNhomNguoiDung,
                    nhomND.id 
                );
            }

        }

        private void CreateColumns()
        {
            dataGridViewPhieuMuon.Columns.Clear();
            dataGridViewPhieuMuon.AutoGenerateColumns = false; 

            dataGridViewPhieuMuon.Columns.Add("MaNhomNguoiDung", "Mã nhóm người dùng");

            dataGridViewPhieuMuon.Columns.Add("TenNhomNguoiDung", "Tên nhóm người dùng");

            dataGridViewPhieuMuon.Columns.Add("id", "ID");
            dataGridViewPhieuMuon.Columns["id"].Visible = false;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "isChosen";
            checkColumn.HeaderText = "";
            checkColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            checkColumn.Width = 50;
            dataGridViewPhieuMuon.Columns.Insert(0, checkColumn);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            var f = new fAddNhomND();
            f.ShowDialog();
            Bind();
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = e.RowIndex;
            if (stt == -1) return; 
            if (e.ColumnIndex == 0) return;

            var fInfor = new fInfoNhomND(Convert.ToInt32(dataGridViewPhieuMuon.Rows[stt].Cells["id"].Value));
            fInfor.ShowDialog();
            Bind();
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Bind();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            List<int> idDel = new List<int>();

            foreach (DataGridViewRow row in dataGridViewPhieuMuon.Rows)
            {
                if (row.IsNewRow) continue;

               
                object cellValue = row.Cells["isChosen"].Value;
                bool isChecked = false;

                if (cellValue != null && cellValue is bool)
                {
                    isChecked = (bool)cellValue;
                }
             

                if (isChecked) 
                {
                    
                    if (row.Cells["id"].Value != null)
                    {
                        idDel.Add(Convert.ToInt32(row.Cells["id"].Value));
                    }
                }
            }

            if (idDel.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhóm người dùng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cnt = 0;
            if (MessageBox.Show("Bạn có chắc muốn xoá " + idDel.Count + " nhóm người dùng?", "Xóa nhóm người dùng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            foreach (int id in idDel)
            {
            Retry:
                string error = BUSNhomNguoiDung.Instance.DelNhomNguoiDung(id);
                if (error != "")
                {
                    if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error) == DialogResult.Retry)
                        goto Retry;
                    else continue;
                }
                else cnt++;
            }

            MessageBox.Show("Đã xoá thành công " + cnt + " nhóm người dùng", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bind();
        }
        
    }
}