using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Usercontrols
{
    public partial class ucHomeTCS : UserControl
    {
        public ucHomeTCS()
        {
            InitializeComponent();

            CreateColumns();

            Binding(BUSSach.Instance.GetAllSach());
            comLocTheLoai.DataSource = BUSTheLoai.Instance.GetAllTheLoai();
            comLocTheLoai.ValueMember = "id";
            comLocTheLoai.DisplayMember = "TenTheLoai";
            List<string> TinhTrangList = new List<string> { "Còn", "Hết" };
            cbLocTinhTrang.DataSource = TinhTrangList;
        }

        private void CreateColumns()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("MaSach", "Mã Sách");
            dataGridView.Columns.Add("TenTuaSach", "Tên Tựa Sách");
            dataGridView.Columns.Add("TenTheLoai", "Thể Loại");
            dataGridView.Columns.Add("NamXB", "Năm XB");
            dataGridView.Columns.Add("NhaXB", "Nhà XB");
            dataGridView.Columns.Add("TacGia", "Tác Giả");
            dataGridView.Columns.Add("TinhTrang", "Tình Trạng");
        }

        private void Binding(List<SACH> SachList)
        {
            dataGridView.Rows.Clear();
            foreach (SACH sach in SachList)
                if (sach.DaAn == 0)
                {
                    string tacgia = "";
                    foreach (TACGIA tg in sach.TUASACH.TACGIAs)
                        tacgia += tg.TenTacGia + ", ";
                    if (tacgia != "")
                        tacgia = tacgia.Remove(tacgia.Length - 2, 2);

                    string Con = (sach.SoLuongConLai > 0) ? "Còn" : "Hết";

                    dataGridView.Rows.Add(sach.MaSach, sach.TUASACH.TenTuaSach, sach.TUASACH.THELOAI.TenTheLoai, sach.NamXB, sach.NhaXB, tacgia, Con);
                }
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            Binding(BUSSach.Instance.GetAllSach());
            txtTimKiemSach.Text = "";
        }


        private void btnTimKiemTuaSach_Click(object sender, EventArgs e)
        {
            List<SACH> Res = new List<SACH>();
            string pat = txtTimKiemSach.Text.ToLower();

            foreach (SACH sach in BUSSach.Instance.GetAllSach())
            {
                if (sach.TUASACH.TenTuaSach.ToLower().Contains(pat) ||
                    sach.MaSach.ToLower().Contains(pat) ||
                    sach.NhaXB.ToLower().Contains(pat) ||
                    sach.NamXB.ToString().Contains(pat))
                    Res.Add(sach);
                else
                    foreach (TACGIA tg in sach.TUASACH.TACGIAs)
                        if (tg.TenTacGia.ToLower().Contains(pat))
                            Res.Add(sach);
            }
            Binding(Res);
        }

        private void btnLocTinhTrang_Click(object sender, EventArgs e)
        {
            int tt = cbLocTinhTrang.SelectedIndex;
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in BUSSach.Instance.GetAllSach())
                if (sach.DaAn == 0)
                {
                    if (sach.SoLuongConLai > 0 && tt == 0)
                    {
                        Res.Add(sach);
                    }
                    if (sach.SoLuongConLai <= 0 && tt == 1)
                        Res.Add(sach);
                }
            Binding(Res);
        }

        private void btnLocTheLoai_Click(object sender, EventArgs e)
        {
            List<SACH> Res = new List<SACH>();
            foreach (SACH sach in BUSSach.Instance.GetAllSach())
            {
                if (comLocTheLoai.SelectedValue != null && sach.TUASACH.THELOAI.id == (int)comLocTheLoai.SelectedValue)
                    Res.Add(sach);
            }
            Binding(Res);
        }
    }
}