namespace GUI.Usercontrols
{
    partial class ucQLBaoCaoThongKe
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
            this.btnViewLoadSachTra = new System.Windows.Forms.Button();
            this.btnViewMuon = new System.Windows.Forms.Button();
            this.loadContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnViewLoadSachTra);
            this.panel1.Controls.Add(this.btnViewMuon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnViewLoadSachTra
            // 
            this.btnViewLoadSachTra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewLoadSachTra.FlatAppearance.BorderSize = 0;
            this.btnViewLoadSachTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLoadSachTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLoadSachTra.Location = new System.Drawing.Point(152, 0);
            this.btnViewLoadSachTra.Name = "btnViewLoadSachTra";
            this.btnViewLoadSachTra.Size = new System.Drawing.Size(116, 45);
            this.btnViewLoadSachTra.TabIndex = 1;
            this.btnViewLoadSachTra.Text = "Sách trả trễ";
            this.btnViewLoadSachTra.UseVisualStyleBackColor = true;
            this.btnViewLoadSachTra.Click += new System.EventHandler(this.btnViewLoadSachTra_Click);
            // 
            // btnViewMuon
            // 
            this.btnViewMuon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewMuon.FlatAppearance.BorderSize = 0;
            this.btnViewMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMuon.Location = new System.Drawing.Point(0, 0);
            this.btnViewMuon.Name = "btnViewMuon";
            this.btnViewMuon.Size = new System.Drawing.Size(152, 45);
            this.btnViewMuon.TabIndex = 0;
            this.btnViewMuon.Text = "Mượn theo thể loại";
            this.btnViewMuon.UseVisualStyleBackColor = true;
            this.btnViewMuon.Click += new System.EventHandler(this.btnViewMuon_Click);
            // 
            // loadContent
            // 
            this.loadContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadContent.Location = new System.Drawing.Point(0, 45);
            this.loadContent.Name = "loadContent";
            this.loadContent.Size = new System.Drawing.Size(652, 364);
            this.loadContent.TabIndex = 1;
            // 
            // ucQLBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadContent);
            this.Controls.Add(this.panel1);
            this.Name = "ucQLBaoCaoThongKe";
            this.Size = new System.Drawing.Size(652, 409);
            this.Load += new System.EventHandler(this.ucQLBaoCaoThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewMuon;
        private System.Windows.Forms.Button btnViewLoadSachTra;
        private System.Windows.Forms.Panel loadContent;
    }
}
