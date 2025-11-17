namespace GUI.Usercontrols
{
    partial class ucQLNguoiDung
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
            this.btnViewLoadNhomNguoiDung = new System.Windows.Forms.Button();
            this.btnViewNguoiDung = new System.Windows.Forms.Button();
            this.loadContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnViewLoadNhomNguoiDung);
            this.panel1.Controls.Add(this.btnViewNguoiDung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnViewLoadNhomNguoiDung
            // 
            this.btnViewLoadNhomNguoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewLoadNhomNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnViewLoadNhomNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLoadNhomNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLoadNhomNguoiDung.Location = new System.Drawing.Point(116, 0);
            this.btnViewLoadNhomNguoiDung.Name = "btnViewLoadNhomNguoiDung";
            this.btnViewLoadNhomNguoiDung.Size = new System.Drawing.Size(140, 45);
            this.btnViewLoadNhomNguoiDung.TabIndex = 1;
            this.btnViewLoadNhomNguoiDung.Text = "Nhóm người dùng";
            this.btnViewLoadNhomNguoiDung.UseVisualStyleBackColor = true;
            this.btnViewLoadNhomNguoiDung.Click += new System.EventHandler(this.btnViewLoadNhomNguoiDung_Click);
            // 
            // btnViewNguoiDung
            // 
            this.btnViewNguoiDung.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnViewNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.btnViewNguoiDung.Name = "btnViewNguoiDung";
            this.btnViewNguoiDung.Size = new System.Drawing.Size(116, 45);
            this.btnViewNguoiDung.TabIndex = 0;
            this.btnViewNguoiDung.Text = "Người dùng";
            this.btnViewNguoiDung.UseVisualStyleBackColor = true;
            this.btnViewNguoiDung.Click += new System.EventHandler(this.btnViewNguoiDung_Click);
            // 
            // loadContent
            // 
            this.loadContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadContent.Location = new System.Drawing.Point(0, 45);
            this.loadContent.Name = "loadContent";
            this.loadContent.Size = new System.Drawing.Size(652, 364);
            this.loadContent.TabIndex = 1;
            // 
            // ucQLNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadContent);
            this.Controls.Add(this.panel1);
            this.Name = "ucQLNguoiDung";
            this.Size = new System.Drawing.Size(652, 409);
            this.Load += new System.EventHandler(this.ucQLNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewNguoiDung;
        private System.Windows.Forms.Button btnViewLoadNhomNguoiDung;
        private System.Windows.Forms.Panel loadContent;
    }
}
