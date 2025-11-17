using System.Drawing;
using System.Windows.Forms;

namespace GUI.Usercontrols
{
    partial class ucDocGia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTimKiemDocGia = new System.Windows.Forms.Button();
            this.txtTimKiemDocGia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDocGia = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSachDangMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnLoadDocGia = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 77);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLoadDocGia);
            this.panel4.Controls.Add(this.btnThemDocGia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 77);
            this.panel4.TabIndex = 5;
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemDocGia.FlatAppearance.BorderSize = 0;
            this.btnThemDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDocGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemDocGia.Location = new System.Drawing.Point(17, 25);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(185, 33);
            this.btnThemDocGia.TabIndex = 0;
            this.btnThemDocGia.Text = "Thêm độc giả";
            this.btnThemDocGia.UseVisualStyleBackColor = false;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTimKiemDocGia);
            this.panel3.Controls.Add(this.txtTimKiemDocGia);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(285, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 77);
            this.panel3.TabIndex = 4;
            // 
            // btnTimKiemDocGia
            // 
            this.btnTimKiemDocGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimKiemDocGia.FlatAppearance.BorderSize = 0;
            this.btnTimKiemDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDocGia.Location = new System.Drawing.Point(260, 29);
            this.btnTimKiemDocGia.Name = "btnTimKiemDocGia";
            this.btnTimKiemDocGia.Size = new System.Drawing.Size(78, 33);
            this.btnTimKiemDocGia.TabIndex = 2;
            this.btnTimKiemDocGia.Text = "Tìm kiếm";
            this.btnTimKiemDocGia.UseVisualStyleBackColor = false;
            this.btnTimKiemDocGia.Click += new System.EventHandler(this.butFind_Click);
            // 
            // txtTimKiemDocGia
            // 
            this.txtTimKiemDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemDocGia.Location = new System.Drawing.Point(18, 34);
            this.txtTimKiemDocGia.Name = "txtTimKiemDocGia";
            this.txtTimKiemDocGia.Size = new System.Drawing.Size(236, 24);
            this.txtTimKiemDocGia.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDocGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 303);
            this.panel1.TabIndex = 2;
            // 
            // dataGridViewDocGia
            // 
            this.dataGridViewDocGia.AllowUserToAddRows = false;
            this.dataGridViewDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDocGia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isChosen,
            this.MaDocGia,
            this.TenDocGia,
            this.LoaiDocGia,
            this.SoSachDangMuon,
            this.NgayHetHan,
            this.TongNo});
            this.dataGridViewDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDocGia.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDocGia.Name = "dataGridViewDocGia";
            this.dataGridViewDocGia.RowHeadersVisible = false;
            this.dataGridViewDocGia.Size = new System.Drawing.Size(649, 303);
            this.dataGridViewDocGia.TabIndex = 1;
            this.dataGridViewDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDocGia_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // isChosen
            // 
            this.isChosen.DataPropertyName = "isChosen";
            this.isChosen.HeaderText = "";
            this.isChosen.Name = "isChosen";
            this.isChosen.Visible = false;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã ĐG";
            this.MaDocGia.Name = "MaDocGia";
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên Độc Giả";
            this.TenDocGia.Name = "TenDocGia";
            // 
            // LoaiDocGia
            // 
            this.LoaiDocGia.DataPropertyName = "TenLoaiDocGia";
            this.LoaiDocGia.HeaderText = "Loại ĐG";
            this.LoaiDocGia.Name = "LoaiDocGia";
            // 
            // SoSachDangMuon
            // 
            this.SoSachDangMuon.DataPropertyName = "SoSachDangMuon";
            this.SoSachDangMuon.HeaderText = "Sách Mượn";
            this.SoSachDangMuon.Name = "SoSachDangMuon";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày Hết Hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // TongNo
            // 
            this.TongNo.DataPropertyName = "TongNoHienTai";
            this.TongNo.HeaderText = "Tổng Nợ";
            this.TongNo.Name = "TongNo";
            // 
            // btnLoadDocGia
            // 
            this.btnLoadDocGia.Image = global::GUI.Properties.Resources.phieumuontra;
            this.btnLoadDocGia.Location = new System.Drawing.Point(221, 29);
            this.btnLoadDocGia.Name = "btnLoadDocGia";
            this.btnLoadDocGia.Size = new System.Drawing.Size(31, 24);
            this.btnLoadDocGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoadDocGia.TabIndex = 3;
            this.btnLoadDocGia.TabStop = false;
            this.btnLoadDocGia.Click += new System.EventHandler(this.btnLoadDocGia_Click);
            // 
            // ucDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ucDocGia";
            this.Size = new System.Drawing.Size(649, 380);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnLoadDocGia;
        private System.Windows.Forms.Button btnTimKiemDocGia;
        private System.Windows.Forms.TextBox txtTimKiemDocGia;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDocGia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isChosen; 
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSachDangMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongNo;

    }
}
