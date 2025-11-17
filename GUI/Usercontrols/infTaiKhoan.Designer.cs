namespace GUI.Usercontrols
{
    partial class infTaiKhoan
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
            this.blVaiTroNguoiDung = new System.Windows.Forms.Label();
            this.avatarNguoiDung = new System.Windows.Forms.PictureBox();
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.groupBoxChiTietNguoiDung = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMaNguoiDung = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarNguoiDung)).BeginInit();
            this.groupBoxChiTietNguoiDung.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.blVaiTroNguoiDung);
            this.panel1.Controls.Add(this.avatarNguoiDung);
            this.panel1.Controls.Add(this.lbTenNguoiDung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 134);
            this.panel1.TabIndex = 0;
            // 
            // blVaiTroNguoiDung
            // 
            this.blVaiTroNguoiDung.AutoSize = true;
            this.blVaiTroNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blVaiTroNguoiDung.Location = new System.Drawing.Point(143, 34);
            this.blVaiTroNguoiDung.Name = "blVaiTroNguoiDung";
            this.blVaiTroNguoiDung.Size = new System.Drawing.Size(50, 18);
            this.blVaiTroNguoiDung.TabIndex = 2;
            this.blVaiTroNguoiDung.Text = "Vai trò";
            // 
            // avatarNguoiDung
            // 
            this.avatarNguoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.avatarNguoiDung.Image = global::GUI.Properties.Resources.user;
            this.avatarNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.avatarNguoiDung.Name = "avatarNguoiDung";
            this.avatarNguoiDung.Size = new System.Drawing.Size(135, 134);
            this.avatarNguoiDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarNguoiDung.TabIndex = 1;
            this.avatarNguoiDung.TabStop = false;
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNguoiDung.Location = new System.Drawing.Point(141, 79);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(197, 25);
            this.lbTenNguoiDung.TabIndex = 0;
            this.lbTenNguoiDung.Text = "Họ và tên người dùng";
            // 
            // groupBoxChiTietNguoiDung
            // 
            this.groupBoxChiTietNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxChiTietNguoiDung.Controls.Add(this.panel2);
            this.groupBoxChiTietNguoiDung.Controls.Add(this.label4);
            this.groupBoxChiTietNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChiTietNguoiDung.Location = new System.Drawing.Point(0, 134);
            this.groupBoxChiTietNguoiDung.Name = "groupBoxChiTietNguoiDung";
            this.groupBoxChiTietNguoiDung.Size = new System.Drawing.Size(363, 325);
            this.groupBoxChiTietNguoiDung.TabIndex = 1;
            this.groupBoxChiTietNguoiDung.TabStop = false;
            this.groupBoxChiTietNguoiDung.Text = "Chi tiết người dùng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDoiMatKhau);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 302);
            this.panel2.TabIndex = 5;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDoiMatKhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(16, 264);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(92, 26);
            this.btnDoiMatKhau.TabIndex = 6;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbTenDangNhap);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(357, 44);
            this.panel7.TabIndex = 3;
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(3, 13);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(121, 18);
            this.lbTenDangNhap.TabIndex = 9;
            this.lbTenDangNhap.Text = "Tên đăng nhập:   ";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbChucVu);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 44);
            this.panel6.TabIndex = 2;
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(3, 12);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(78, 18);
            this.lbChucVu.TabIndex = 9;
            this.lbChucVu.Text = "Chức vụ:   ";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbNgaySinh);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 44);
            this.panel5.TabIndex = 1;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(3, 13);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(89, 18);
            this.lbNgaySinh.TabIndex = 8;
            this.lbNgaySinh.Text = "Ngày sinh:   ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbMaNguoiDung);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 44);
            this.panel4.TabIndex = 0;
            // 
            // lbMaNguoiDung
            // 
            this.lbMaNguoiDung.AutoSize = true;
            this.lbMaNguoiDung.Location = new System.Drawing.Point(3, 13);
            this.lbMaNguoiDung.Name = "lbMaNguoiDung";
            this.lbMaNguoiDung.Size = new System.Drawing.Size(121, 18);
            this.lbMaNguoiDung.TabIndex = 7;
            this.lbMaNguoiDung.Text = "Mã người dùng:   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 4;
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChucNang.Controls.Add(this.panel3);
            this.groupBoxChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChucNang.Location = new System.Drawing.Point(380, 134);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(305, 325);
            this.groupBoxChucNang.TabIndex = 2;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức năng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 302);
            this.panel3.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(299, 302);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // infTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxChiTietNguoiDung);
            this.Controls.Add(this.panel1);
            this.Name = "infTaiKhoan";
            this.Size = new System.Drawing.Size(685, 459);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarNguoiDung)).EndInit();
            this.groupBoxChiTietNguoiDung.ResumeLayout(false);
            this.groupBoxChiTietNguoiDung.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxChiTietNguoiDung;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.PictureBox avatarNguoiDung;
        private System.Windows.Forms.Label lbTenNguoiDung;
        private System.Windows.Forms.Label blVaiTroNguoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbMaNguoiDung;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.ListView listView1;
    }
}
