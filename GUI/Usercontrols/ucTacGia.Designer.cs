namespace GUI.Usercontrols
{
    partial class ucTacGia
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
            this.btnLoad = new System.Windows.Forms.PictureBox();
            this.txtThemTacGia = new System.Windows.Forms.TextBox();
            this.btnThemTacGia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTacGia = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 90);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLoad);
            this.panel4.Controls.Add(this.txtThemTacGia);
            this.panel4.Controls.Add(this.btnThemTacGia);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 90);
            this.panel4.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::GUI.Properties.Resources.phieumuontra;
            this.btnLoad.Location = new System.Drawing.Point(329, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(31, 24);
            this.btnLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoad.TabIndex = 5;
            this.btnLoad.TabStop = false;
            // 
            // txtThemTacGia
            // 
            this.txtThemTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThemTacGia.Location = new System.Drawing.Point(13, 38);
            this.txtThemTacGia.Name = "txtThemTacGia";
            this.txtThemTacGia.Size = new System.Drawing.Size(146, 24);
            this.txtThemTacGia.TabIndex = 1;
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTacGia.Location = new System.Drawing.Point(181, 34);
            this.btnThemTacGia.Name = "btnThemTacGia";
            this.btnThemTacGia.Size = new System.Drawing.Size(116, 33);
            this.btnThemTacGia.TabIndex = 0;
            this.btnThemTacGia.Text = "Thêm tác giả";
            this.btnThemTacGia.UseVisualStyleBackColor = true;
            this.btnThemTacGia.Click += new System.EventHandler(this.btnThemTacGia_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewTacGia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 354);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewTacGia
            // 
            this.dataGridViewTacGia.AllowUserToAddRows = false;
            this.dataGridViewTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTacGia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTacGia.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTacGia.Name = "dataGridViewTacGia";
            this.dataGridViewTacGia.Size = new System.Drawing.Size(779, 354);
            this.dataGridViewTacGia.TabIndex = 0;
            this.dataGridViewTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TacGiaGrid_CellClick);
            this.dataGridViewTacGia.RowHeadersVisible = false;
            // 
            // ucTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucTacGia";
            this.Size = new System.Drawing.Size(779, 444);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewTacGia;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.TextBox txtThemTacGia;
        private System.Windows.Forms.PictureBox btnLoad;
    }
}
