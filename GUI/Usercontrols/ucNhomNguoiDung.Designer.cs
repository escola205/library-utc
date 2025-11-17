namespace GUI.Usercontrols
{
    partial class ucNhomNguoiDung
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
            this.btnXoaNguoiDung = new System.Windows.Forms.Button();
            this.btnThemNguoiDung = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewPhieuMuon = new System.Windows.Forms.DataGridView();
            this.btnLoadDocGia = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel4);
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
            this.panel4.Controls.Add(this.btnLoadDocGia);
            this.panel4.Controls.Add(this.btnXoaNguoiDung);
            this.panel4.Controls.Add(this.btnThemNguoiDung);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 109);
            this.panel4.TabIndex = 8;
            // 
            // btnXoaNguoiDung
            // 
            this.btnXoaNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNguoiDung.Location = new System.Drawing.Point(172, 39);
            this.btnXoaNguoiDung.Name = "btnXoaNguoiDung";
            this.btnXoaNguoiDung.Size = new System.Drawing.Size(142, 33);
            this.btnXoaNguoiDung.TabIndex = 1;
            this.btnXoaNguoiDung.Text = "Xóa nhóm";
            this.btnXoaNguoiDung.UseVisualStyleBackColor = true;
            this.btnXoaNguoiDung.Click += new System.EventHandler(this.butDel_Click);
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNguoiDung.Location = new System.Drawing.Point(13, 39);
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.Size = new System.Drawing.Size(142, 33);
            this.btnThemNguoiDung.TabIndex = 0;
            this.btnThemNguoiDung.Text = "Thêm nhóm";
            this.btnThemNguoiDung.UseVisualStyleBackColor = true;
            this.btnThemNguoiDung.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewPhieuMuon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 335);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewPhieuMuon
            // 
            this.dataGridViewPhieuMuon.AllowUserToAddRows = false;
            this.dataGridViewPhieuMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPhieuMuon.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPhieuMuon.Name = "dataGridViewPhieuMuon";
            this.dataGridViewPhieuMuon.RowHeadersVisible = false;
            this.dataGridViewPhieuMuon.Size = new System.Drawing.Size(779, 335);
            this.dataGridViewPhieuMuon.TabIndex = 0;
            this.dataGridViewPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // btnLoadDocGia
            // 
            this.btnLoadDocGia.Image = global::GUI.Properties.Resources.phieumuontra;
            this.btnLoadDocGia.Location = new System.Drawing.Point(354, 43);
            this.btnLoadDocGia.Name = "btnLoadDocGia";
            this.btnLoadDocGia.Size = new System.Drawing.Size(31, 24);
            this.btnLoadDocGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoadDocGia.TabIndex = 6;
            this.btnLoadDocGia.TabStop = false;
            this.btnLoadDocGia.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // ucNhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucNhomNguoiDung";
            this.Size = new System.Drawing.Size(779, 444);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemNguoiDung;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPhieuMuon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoaNguoiDung;
        private System.Windows.Forms.PictureBox btnLoadDocGia;
    }
}
