namespace GUI.Usercontrols
{
    partial class ucHomeTCS
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLocTinhTrang = new System.Windows.Forms.Button();
            this.comLocTheLoai = new System.Windows.Forms.ComboBox();
            this.cbLocTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.btnLocTheLoai = new System.Windows.Forms.Button();
            this.btnTimKiemTuaSach = new System.Windows.Forms.Button();
            this.btnLoadDocGia = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 444);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 120);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(779, 324);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 120);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLoadDocGia);
            this.panel3.Controls.Add(this.btnLocTinhTrang);
            this.panel3.Controls.Add(this.comLocTheLoai);
            this.panel3.Controls.Add(this.cbLocTinhTrang);
            this.panel3.Controls.Add(this.txtTimKiemSach);
            this.panel3.Controls.Add(this.btnLocTheLoai);
            this.panel3.Controls.Add(this.btnTimKiemTuaSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 119);
            this.panel3.TabIndex = 7;
            // 
            // btnLocTinhTrang
            // 
            this.btnLocTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTinhTrang.Location = new System.Drawing.Point(426, 81);
            this.btnLocTinhTrang.Name = "btnLocTinhTrang";
            this.btnLocTinhTrang.Size = new System.Drawing.Size(129, 26);
            this.btnLocTinhTrang.TabIndex = 8;
            this.btnLocTinhTrang.Text = "Lọc tình trạng";
            this.btnLocTinhTrang.UseVisualStyleBackColor = true;
            this.btnLocTinhTrang.Click += new System.EventHandler(this.btnLocTinhTrang_Click);
            // 
            // comLocTheLoai
            // 
            this.comLocTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comLocTheLoai.FormattingEnabled = true;
            this.comLocTheLoai.Location = new System.Drawing.Point(251, 50);
            this.comLocTheLoai.Name = "comLocTheLoai";
            this.comLocTheLoai.Size = new System.Drawing.Size(147, 26);
            this.comLocTheLoai.TabIndex = 7;
            // 
            // cbLocTinhTrang
            // 
            this.cbLocTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocTinhTrang.FormattingEnabled = true;
            this.cbLocTinhTrang.Location = new System.Drawing.Point(251, 82);
            this.cbLocTinhTrang.Name = "cbLocTinhTrang";
            this.cbLocTinhTrang.Size = new System.Drawing.Size(147, 26);
            this.cbLocTinhTrang.TabIndex = 6;
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemSach.Location = new System.Drawing.Point(251, 19);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(147, 24);
            this.txtTimKiemSach.TabIndex = 5;
            // 
            // btnLocTheLoai
            // 
            this.btnLocTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocTheLoai.Location = new System.Drawing.Point(426, 49);
            this.btnLocTheLoai.Name = "btnLocTheLoai";
            this.btnLocTheLoai.Size = new System.Drawing.Size(129, 26);
            this.btnLocTheLoai.TabIndex = 4;
            this.btnLocTheLoai.Text = "Lọc thể loại";
            this.btnLocTheLoai.UseVisualStyleBackColor = true;
            this.btnLocTheLoai.Click += new System.EventHandler(this.btnLocTheLoai_Click);
            // 
            // btnTimKiemTuaSach
            // 
            this.btnTimKiemTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTuaSach.Location = new System.Drawing.Point(426, 18);
            this.btnTimKiemTuaSach.Name = "btnTimKiemTuaSach";
            this.btnTimKiemTuaSach.Size = new System.Drawing.Size(129, 25);
            this.btnTimKiemTuaSach.TabIndex = 3;
            this.btnTimKiemTuaSach.Text = "Tìm kiếm";
            this.btnTimKiemTuaSach.UseVisualStyleBackColor = true;
            this.btnTimKiemTuaSach.Click += new System.EventHandler(this.btnTimKiemTuaSach_Click);
            // 
            // btnLoadDocGia
            // 
            this.btnLoadDocGia.Image = global::GUI.Properties.Resources.phieumuontra;
            this.btnLoadDocGia.Location = new System.Drawing.Point(105, 49);
            this.btnLoadDocGia.Name = "btnLoadDocGia";
            this.btnLoadDocGia.Size = new System.Drawing.Size(31, 24);
            this.btnLoadDocGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoadDocGia.TabIndex = 9;
            this.btnLoadDocGia.TabStop = false;
            this.btnLoadDocGia.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // ucHomeTCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ucHomeTCS";
            this.Size = new System.Drawing.Size(779, 444);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLocTinhTrang;
        private System.Windows.Forms.ComboBox comLocTheLoai;
        private System.Windows.Forms.ComboBox cbLocTinhTrang;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.Button btnLocTheLoai;
        private System.Windows.Forms.Button btnTimKiemTuaSach;
        private System.Windows.Forms.PictureBox btnLoadDocGia;
    }
}
