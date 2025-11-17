using System.Windows.Forms;

namespace GUI.Usercontrols
{
    partial class ucTuaSachcs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAnTuaSach = new System.Windows.Forms.Button();
            this.btnHienTuaSach = new System.Windows.Forms.Button();
            this.btnThemTuaSach = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLocTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTimKiemTuaSach = new System.Windows.Forms.TextBox();
            this.btnLocTheLoaiTuaSach = new System.Windows.Forms.Button();
            this.btnTimKiemTuaSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTuaSach = new System.Windows.Forms.DataGridView();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadDocGia = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 109);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAnTuaSach);
            this.panel4.Controls.Add(this.btnHienTuaSach);
            this.panel4.Controls.Add(this.btnLoadDocGia);
            this.panel4.Controls.Add(this.btnThemTuaSach);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 109);
            this.panel4.TabIndex = 8;
            // 
            // btnAnTuaSach
            // 
            this.btnAnTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnTuaSach.Location = new System.Drawing.Point(222, 39);
            this.btnAnTuaSach.Name = "btnAnTuaSach";
            this.btnAnTuaSach.Size = new System.Drawing.Size(68, 33);
            this.btnAnTuaSach.TabIndex = 7;
            this.btnAnTuaSach.Text = "Ẩn";
            this.btnAnTuaSach.UseVisualStyleBackColor = true;
            this.btnAnTuaSach.Click += new System.EventHandler(this.butDel_Click);
            // 
            // btnHienTuaSach
            // 
            this.btnHienTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienTuaSach.Location = new System.Drawing.Point(152, 39);
            this.btnHienTuaSach.Name = "btnHienTuaSach";
            this.btnHienTuaSach.Size = new System.Drawing.Size(64, 33);
            this.btnHienTuaSach.TabIndex = 6;
            this.btnHienTuaSach.Text = "Hiện";
            this.btnHienTuaSach.UseVisualStyleBackColor = true;
            this.btnHienTuaSach.Click += new System.EventHandler(this.butHien_Click);
            // 
            // btnThemTuaSach
            // 
            this.btnThemTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTuaSach.Location = new System.Drawing.Point(13, 39);
            this.btnThemTuaSach.Name = "btnThemTuaSach";
            this.btnThemTuaSach.Size = new System.Drawing.Size(116, 33);
            this.btnThemTuaSach.TabIndex = 0;
            this.btnThemTuaSach.Text = "Thêm tựa sách";
            this.btnThemTuaSach.UseVisualStyleBackColor = true;
            this.btnThemTuaSach.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLocTheLoai);
            this.panel3.Controls.Add(this.txtTimKiemTuaSach);
            this.panel3.Controls.Add(this.btnLocTheLoaiTuaSach);
            this.panel3.Controls.Add(this.btnTimKiemTuaSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(386, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 109);
            this.panel3.TabIndex = 7;
            // 
            // cbLocTheLoai
            // 
            this.cbLocTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocTheLoai.FormattingEnabled = true;
            this.cbLocTheLoai.Location = new System.Drawing.Point(86, 65);
            this.cbLocTheLoai.Name = "cbLocTheLoai";
            this.cbLocTheLoai.Size = new System.Drawing.Size(147, 26);
            this.cbLocTheLoai.TabIndex = 6;
            // 
            // txtTimKiemTuaSach
            // 
            this.txtTimKiemTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTuaSach.Location = new System.Drawing.Point(86, 19);
            this.txtTimKiemTuaSach.Name = "txtTimKiemTuaSach";
            this.txtTimKiemTuaSach.Size = new System.Drawing.Size(147, 24);
            this.txtTimKiemTuaSach.TabIndex = 5;
            // 
            // btnLocTheLoaiTuaSach
            // 
            this.btnLocTheLoaiTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTheLoaiTuaSach.Location = new System.Drawing.Point(257, 61);
            this.btnLocTheLoaiTuaSach.Name = "btnLocTheLoaiTuaSach";
            this.btnLocTheLoaiTuaSach.Size = new System.Drawing.Size(103, 33);
            this.btnLocTheLoaiTuaSach.TabIndex = 4;
            this.btnLocTheLoaiTuaSach.Text = "Lọc thể loại";
            this.btnLocTheLoaiTuaSach.UseVisualStyleBackColor = true;
            this.btnLocTheLoaiTuaSach.Click += new System.EventHandler(this.butFil_Click);
            // 
            // btnTimKiemTuaSach
            // 
            this.btnTimKiemTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTuaSach.Location = new System.Drawing.Point(257, 15);
            this.btnTimKiemTuaSach.Name = "btnTimKiemTuaSach";
            this.btnTimKiemTuaSach.Size = new System.Drawing.Size(103, 33);
            this.btnTimKiemTuaSach.TabIndex = 3;
            this.btnTimKiemTuaSach.Text = "Tìm kiếm";
            this.btnTimKiemTuaSach.UseVisualStyleBackColor = true;
            this.btnTimKiemTuaSach.Click += new System.EventHandler(this.butFind_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewTuaSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 335);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewTuaSach
            // 
            this.dataGridViewTuaSach.AllowUserToAddRows = false;
            this.dataGridViewTuaSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTuaSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTuaSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTuaSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect,
            this.id,
            this.MaTuaSach,
            this.TenTuaSach,
            this.TenTheLoai,
            this.TacGia,
            this.DaAn});
            this.dataGridViewTuaSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTuaSach.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTuaSach.Name = "dataGridViewTuaSach";
            this.dataGridViewTuaSach.RowHeadersVisible = false;
            this.dataGridViewTuaSach.Size = new System.Drawing.Size(779, 335);
            this.dataGridViewTuaSach.TabIndex = 0;
            this.dataGridViewTuaSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TuaSachGrid_CellClick);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chkSelect.HeaderText = "";
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // MaTuaSach
            // 
            this.MaTuaSach.DataPropertyName = "MaTuaSach";
            this.MaTuaSach.HeaderText = "Mã Tựa Sách";
            this.MaTuaSach.Name = "MaTuaSach";
            this.MaTuaSach.Visible = false;
            // 
            // TenTuaSach
            // 
            this.TenTuaSach.DataPropertyName = "TenTuaSach";
            this.TenTuaSach.FillWeight = 150F;
            this.TenTuaSach.HeaderText = "Tên Tựa Sách";
            this.TenTuaSach.Name = "TenTuaSach";
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Thể Loại";
            this.TenTheLoai.Name = "TenTheLoai";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            // 
            // DaAn
            // 
            this.DaAn.DataPropertyName = "DaAn";
            this.DaAn.HeaderText = "Đã Ẩn";
            this.DaAn.Name = "DaAn";
            // 
            // STT
            // 
            this.STT.Name = "STT";
            // 
            // btnLoadDocGia
            // 
            this.btnLoadDocGia.Image = global::GUI.Properties.Resources.phieumuontra;
            this.btnLoadDocGia.Location = new System.Drawing.Point(323, 43);
            this.btnLoadDocGia.Name = "btnLoadDocGia";
            this.btnLoadDocGia.Size = new System.Drawing.Size(31, 24);
            this.btnLoadDocGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoadDocGia.TabIndex = 5;
            this.btnLoadDocGia.TabStop = false;
            this.btnLoadDocGia.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // ucTuaSachcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucTuaSachcs";
            this.Size = new System.Drawing.Size(779, 444);
            this.Load += new System.EventHandler(this.ucTuaSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLocTheLoai;
        private System.Windows.Forms.TextBox txtTimKiemTuaSach;
        private System.Windows.Forms.Button btnLocTheLoaiTuaSach;
        private System.Windows.Forms.Button btnTimKiemTuaSach;
        private System.Windows.Forms.Button btnThemTuaSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewTuaSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnLoadDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGiaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.Button btnHienTuaSach;
        private System.Windows.Forms.Button btnAnTuaSach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;

    }
}
