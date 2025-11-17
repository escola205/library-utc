namespace GUI.Usercontrols
{
    partial class ucSach
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
            this.btnHienSach = new System.Windows.Forms.Button();
            this.btnAnSach = new System.Windows.Forms.Button();
            this.btnNhapSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLocTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.btnLocTinhTrang = new System.Windows.Forms.Button();
            this.btnTimKiemTuaSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
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
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.btnHienSach);
            this.panel4.Controls.Add(this.btnAnSach);
            this.panel4.Controls.Add(this.btnNhapSach);
            this.panel4.Controls.Add(this.btnThemSach);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 109);
            this.panel4.TabIndex = 8;
            // 
            // btnHienSach
            // 
            this.btnHienSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienSach.Location = new System.Drawing.Point(297, 39);
            this.btnHienSach.Name = "btnHienSach";
            this.btnHienSach.Size = new System.Drawing.Size(72, 33);
            this.btnHienSach.TabIndex = 3;
            this.btnHienSach.Text = "Hiện";
            this.btnHienSach.UseVisualStyleBackColor = true;
            this.btnHienSach.Click += new System.EventHandler(this.butHien_Click);
            // 
            // btnAnSach
            // 
            this.btnAnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnSach.Location = new System.Drawing.Point(214, 39);
            this.btnAnSach.Name = "btnAnSach";
            this.btnAnSach.Size = new System.Drawing.Size(77, 33);
            this.btnAnSach.TabIndex = 2;
            this.btnAnSach.Text = "Ẩn";
            this.btnAnSach.UseVisualStyleBackColor = true;
            this.btnAnSach.Click += new System.EventHandler(this.butDel_Click);
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSach.Location = new System.Drawing.Point(118, 39);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(90, 33);
            this.btnNhapSach.TabIndex = 1;
            this.btnNhapSach.Text = "Nhập sách";
            this.btnNhapSach.UseVisualStyleBackColor = true;
            this.btnNhapSach.Click += new System.EventHandler(this.butAddOld_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.Location = new System.Drawing.Point(13, 39);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(99, 33);
            this.btnThemSach.TabIndex = 0;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLocTinhTrang);
            this.panel3.Controls.Add(this.txtTimKiemSach);
            this.panel3.Controls.Add(this.btnLocTinhTrang);
            this.panel3.Controls.Add(this.btnTimKiemTuaSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(455, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 109);
            this.panel3.TabIndex = 7;
            // 
            // cbLocTinhTrang
            // 
            this.cbLocTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocTinhTrang.FormattingEnabled = true;
            this.cbLocTinhTrang.Location = new System.Drawing.Point(27, 64);
            this.cbLocTinhTrang.Name = "cbLocTinhTrang";
            this.cbLocTinhTrang.Size = new System.Drawing.Size(147, 26);
            this.cbLocTinhTrang.TabIndex = 6;
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSach.Location = new System.Drawing.Point(27, 19);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(147, 24);
            this.txtTimKiemSach.TabIndex = 5;
            // 
            // btnLocTinhTrang
            // 
            this.btnLocTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTinhTrang.Location = new System.Drawing.Point(207, 63);
            this.btnLocTinhTrang.Name = "btnLocTinhTrang";
            this.btnLocTinhTrang.Size = new System.Drawing.Size(103, 26);
            this.btnLocTinhTrang.TabIndex = 4;
            this.btnLocTinhTrang.Text = "Lọc tình trạng";
            this.btnLocTinhTrang.UseVisualStyleBackColor = true;
            this.btnLocTinhTrang.Click += new System.EventHandler(this.butTenSach_Click);
            // 
            // btnTimKiemTuaSach
            // 
            this.btnTimKiemTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTuaSach.Location = new System.Drawing.Point(207, 19);
            this.btnTimKiemTuaSach.Name = "btnTimKiemTuaSach";
            this.btnTimKiemTuaSach.Size = new System.Drawing.Size(103, 25);
            this.btnTimKiemTuaSach.TabIndex = 3;
            this.btnTimKiemTuaSach.Text = "Tìm kiếm";
            this.btnTimKiemTuaSach.UseVisualStyleBackColor = true;
            this.btnTimKiemTuaSach.Click += new System.EventHandler(this.butMaSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewSach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 335);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSach.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.Size = new System.Drawing.Size(779, 335);
            this.dataGridViewSach.TabIndex = 0;
            this.dataGridViewSach.RowHeadersVisible = false;
            this.dataGridViewSach.AllowUserToAddRows = false;
            // 
            // ucSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucSach";
            this.Size = new System.Drawing.Size(779, 444);
            this.Load += new System.EventHandler(this.ucSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLocTinhTrang;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Button btnLocTinhTrang;
        private System.Windows.Forms.Button btnTimKiemTuaSach;
        private System.Windows.Forms.Button btnAnSach;
        private System.Windows.Forms.Button btnNhapSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHienSach;
    }
}
