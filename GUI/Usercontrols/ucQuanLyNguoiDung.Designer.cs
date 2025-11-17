namespace GUI.Usercontrols
{
    partial class ucQuanLyNguoiDung
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
            this.btnViewNhom = new System.Windows.Forms.Button();
            this.btnViewNguoi = new System.Windows.Forms.Button();
            this.loadContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnViewNhom);
            this.panel1.Controls.Add(this.btnViewNguoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnViewNhom
            // 
            this.btnViewNhom.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewNhom.FlatAppearance.BorderSize = 0;
            this.btnViewNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNhom.Location = new System.Drawing.Point(116, 0);
            this.btnViewNhom.Name = "btnViewNhom";
            this.btnViewNhom.Size = new System.Drawing.Size(116, 45);
            this.btnViewNhom.TabIndex = 1;
            this.btnViewNhom.Text = "Nhóm";
            this.btnViewNhom.UseVisualStyleBackColor = true;
            // 
            // btnViewNguoi
            // 
            this.btnViewNguoi.CausesValidation = false;
            this.btnViewNguoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewNguoi.FlatAppearance.BorderSize = 0;
            this.btnViewNguoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNguoi.Location = new System.Drawing.Point(0, 0);
            this.btnViewNguoi.Name = "btnViewNguoi";
            this.btnViewNguoi.Size = new System.Drawing.Size(116, 45);
            this.btnViewNguoi.TabIndex = 0;
            this.btnViewNguoi.Text = "Người";
            this.btnViewNguoi.UseVisualStyleBackColor = true;
            // 
            // loadContent
            // 
            this.loadContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadContent.Location = new System.Drawing.Point(0, 45);
            this.loadContent.Name = "loadContent";
            this.loadContent.Size = new System.Drawing.Size(652, 364);
            this.loadContent.TabIndex = 1;
            // 
            // ucQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadContent);
            this.Controls.Add(this.panel1);
            this.Name = "ucQuanLyNguoiDung";
            this.Size = new System.Drawing.Size(652, 409);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewNguoi;
        private System.Windows.Forms.Button btnViewNhom;
        private System.Windows.Forms.Panel loadContent;
    }
}
