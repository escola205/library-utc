namespace GUI.Usercontrols
{
    partial class ucQuanLyDocGia
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
            this.btnViewLoadDocGia = new System.Windows.Forms.Button();
            this.btnViewDocGia = new System.Windows.Forms.Button();
            this.loadContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnViewLoadDocGia);
            this.panel1.Controls.Add(this.btnViewDocGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnViewLoadDocGia
            // 
            this.btnViewLoadDocGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewLoadDocGia.FlatAppearance.BorderSize = 0;
            this.btnViewLoadDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLoadDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLoadDocGia.Location = new System.Drawing.Point(116, 0);
            this.btnViewLoadDocGia.Name = "btnViewLoadDocGia";
            this.btnViewLoadDocGia.Size = new System.Drawing.Size(116, 45);
            this.btnViewLoadDocGia.TabIndex = 1;
            this.btnViewLoadDocGia.Text = "Loại độc giả";
            this.btnViewLoadDocGia.UseVisualStyleBackColor = true;
            this.btnViewLoadDocGia.Click += new System.EventHandler(this.btnViewLoadDocGia_Click);
            // 
            // btnViewDocGia
            // 
            this.btnViewDocGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewDocGia.FlatAppearance.BorderSize = 0;
            this.btnViewDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDocGia.Location = new System.Drawing.Point(0, 0);
            this.btnViewDocGia.Name = "btnViewDocGia";
            this.btnViewDocGia.Size = new System.Drawing.Size(116, 45);
            this.btnViewDocGia.TabIndex = 0;
            this.btnViewDocGia.Text = "Độc giả";
            this.btnViewDocGia.UseVisualStyleBackColor = true;
            this.btnViewDocGia.Click += new System.EventHandler(this.btnViewDocGia_Click);
            // 
            // loadContent
            // 
            this.loadContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadContent.Location = new System.Drawing.Point(0, 45);
            this.loadContent.Name = "loadContent";
            this.loadContent.Size = new System.Drawing.Size(652, 364);
            this.loadContent.TabIndex = 1;
            // 
            // ucQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadContent);
            this.Controls.Add(this.panel1);
            this.Name = "ucQuanLyDocGia";
            this.Size = new System.Drawing.Size(652, 409);
            this.Load += new System.EventHandler(this.ucQuanLyDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewDocGia;
        private System.Windows.Forms.Button btnViewLoadDocGia;
        private System.Windows.Forms.Panel loadContent;
    }
}
