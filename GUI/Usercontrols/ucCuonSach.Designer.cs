namespace GUI.Usercontrols
{
    partial class ucCuonSach
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
            this.btnNhapSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLocTinhTangCuonSach = new System.Windows.Forms.ComboBox();
            this.txtTimKiemCuonSach = new System.Windows.Forms.TextBox();
            this.btnLocTinhTrangCuonSach = new System.Windows.Forms.Button();
            this.btnTimKiemCuonSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewCuonSach = new System.Windows.Forms.DataGridView();
            this.btnLoadDocGia = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuonSach)).BeginInit();
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
            this.panel4.Controls.Add(this.btnLoadDocGia);
            this.panel4.Controls.Add(this.btnNhapSach);
            this.panel4.Controls.Add(this.btnThemSach);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 109);
            this.panel4.TabIndex = 8;
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSach.Location = new System.Drawing.Point(169, 39);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(152, 33);
            this.btnNhapSach.TabIndex = 1;
            this.btnNhapSach.Text = "Hiện cuốn sách";
            this.btnNhapSach.UseVisualStyleBackColor = true;
            this.btnNhapSach.Click += new System.EventHandler(this.butHien_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.Location = new System.Drawing.Point(13, 39);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(150, 33);
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = "Ẩn cuốn sách ";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.butDel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLocTinhTangCuonSach);
            this.panel3.Controls.Add(this.txtTimKiemCuonSach);
            this.panel3.Controls.Add(this.btnLocTinhTrangCuonSach);
            this.panel3.Controls.Add(this.btnTimKiemCuonSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(447, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 109);
            this.panel3.TabIndex = 7;
            // 
            // cbLocTinhTangCuonSach
            // 
            this.cbLocTinhTangCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocTinhTangCuonSach.FormattingEnabled = true;
            this.cbLocTinhTangCuonSach.Location = new System.Drawing.Point(27, 64);
            this.cbLocTinhTangCuonSach.Name = "cbLocTinhTangCuonSach";
            this.cbLocTinhTangCuonSach.Size = new System.Drawing.Size(147, 26);
            this.cbLocTinhTangCuonSach.TabIndex = 6;
            // 
            // txtTimKiemCuonSach
            // 
            this.txtTimKiemCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemCuonSach.Location = new System.Drawing.Point(27, 19);
            this.txtTimKiemCuonSach.Name = "txtTimKiemCuonSach";
            this.txtTimKiemCuonSach.Size = new System.Drawing.Size(147, 24);
            this.txtTimKiemCuonSach.TabIndex = 5;
            // 
            // btnLocTinhTrangCuonSach
            // 
            this.btnLocTinhTrangCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTinhTrangCuonSach.Location = new System.Drawing.Point(207, 63);
            this.btnLocTinhTrangCuonSach.Name = "btnLocTinhTrangCuonSach";
            this.btnLocTinhTrangCuonSach.Size = new System.Drawing.Size(103, 26);
            this.btnLocTinhTrangCuonSach.TabIndex = 4;
            this.btnLocTinhTrangCuonSach.Text = "Lọc tình trạng";
            this.btnLocTinhTrangCuonSach.UseVisualStyleBackColor = true;
            this.btnLocTinhTrangCuonSach.Click += new System.EventHandler(this.butTinhTrang_Click);
            // 
            // btnTimKiemCuonSach
            // 
            this.btnTimKiemCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemCuonSach.Location = new System.Drawing.Point(207, 19);
            this.btnTimKiemCuonSach.Name = "btnTimKiemCuonSach";
            this.btnTimKiemCuonSach.Size = new System.Drawing.Size(103, 25);
            this.btnTimKiemCuonSach.TabIndex = 3;
            this.btnTimKiemCuonSach.Text = "Tìm kiếm";
            this.btnTimKiemCuonSach.UseVisualStyleBackColor = true;
            this.btnTimKiemCuonSach.Click += new System.EventHandler(this.butMaSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewCuonSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 335);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewCuonSach
            // 
            this.dataGridViewCuonSach.AllowUserToAddRows = false;
            this.dataGridViewCuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCuonSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCuonSach.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCuonSach.Name = "dataGridViewCuonSach";
            this.dataGridViewCuonSach.RowHeadersVisible = false;
            this.dataGridViewCuonSach.Size = new System.Drawing.Size(779, 335);
            this.dataGridViewCuonSach.TabIndex = 0;
            // 
            // btnLoadDocGia
            // 
            this.btnLoadDocGia.Image = global::GUI.Properties.Resources.phieumuontra;
            this.btnLoadDocGia.Location = new System.Drawing.Point(339, 43);
            this.btnLoadDocGia.Name = "btnLoadDocGia";
            this.btnLoadDocGia.Size = new System.Drawing.Size(31, 24);
            this.btnLoadDocGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoadDocGia.TabIndex = 4;
            this.btnLoadDocGia.TabStop = false;
            this.btnLoadDocGia.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // ucCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucCuonSach";
            this.Size = new System.Drawing.Size(779, 444);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLocTinhTangCuonSach;
        private System.Windows.Forms.TextBox txtTimKiemCuonSach;
        private System.Windows.Forms.Button btnLocTinhTrangCuonSach;
        private System.Windows.Forms.Button btnTimKiemCuonSach;
        private System.Windows.Forms.Button btnNhapSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewCuonSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnLoadDocGia;
    }
}
