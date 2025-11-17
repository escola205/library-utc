namespace GUI
{
    partial class fHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.btnTraCuuSach = new System.Windows.Forms.Button();
            this.btnTaiKhoanNguoiDung = new System.Windows.Forms.Button();
            this.loadContent = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnQuanLy);
            this.panel2.Controls.Add(this.btnTraCuuSach);
            this.panel2.Controls.Add(this.btnTaiKhoanNguoiDung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuanLy.Location = new System.Drawing.Point(326, 0);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(116, 50);
            this.btnQuanLy.TabIndex = 11;
            this.btnQuanLy.Text = "Quản lý";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // btnTraCuuSach
            // 
            this.btnTraCuuSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTraCuuSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTraCuuSach.FlatAppearance.BorderSize = 0;
            this.btnTraCuuSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuuSach.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTraCuuSach.Location = new System.Drawing.Point(156, 0);
            this.btnTraCuuSach.Name = "btnTraCuuSach";
            this.btnTraCuuSach.Size = new System.Drawing.Size(170, 50);
            this.btnTraCuuSach.TabIndex = 10;
            this.btnTraCuuSach.Text = "Tra cứu sách";
            this.btnTraCuuSach.UseVisualStyleBackColor = false;
            this.btnTraCuuSach.Click += new System.EventHandler(this.btnTraCuuSach_Click);
            // 
            // btnTaiKhoanNguoiDung
            // 
            this.btnTaiKhoanNguoiDung.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaiKhoanNguoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTaiKhoanNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoanNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoanNguoiDung.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoanNguoiDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTaiKhoanNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.btnTaiKhoanNguoiDung.Name = "btnTaiKhoanNguoiDung";
            this.btnTaiKhoanNguoiDung.Size = new System.Drawing.Size(156, 50);
            this.btnTaiKhoanNguoiDung.TabIndex = 9;
            this.btnTaiKhoanNguoiDung.Text = "Thông tin tài khoản";
            this.btnTaiKhoanNguoiDung.UseVisualStyleBackColor = false;
            this.btnTaiKhoanNguoiDung.Click += new System.EventHandler(this.btnTaiKhoanNguoiDung_Click);
            // 
            // loadContent
            // 
            this.loadContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadContent.Location = new System.Drawing.Point(0, 50);
            this.loadContent.Name = "loadContent";
            this.loadContent.Size = new System.Drawing.Size(800, 618);
            this.loadContent.TabIndex = 2;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.loadContent);
            this.Controls.Add(this.panel2);
            this.Name = "fHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.fHome_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel loadContent;
        private System.Windows.Forms.Button btnTaiKhoanNguoiDung;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button btnTraCuuSach;
    }
}