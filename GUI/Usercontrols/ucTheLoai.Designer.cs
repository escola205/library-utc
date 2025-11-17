namespace GUI.Usercontrols
{
    partial class ucTheLoai
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
            this.txtThthTheLoai = new System.Windows.Forms.TextBox();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTheLoai = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).BeginInit();
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
            this.panel4.Controls.Add(this.txtThthTheLoai);
            this.panel4.Controls.Add(this.btnThemTheLoai);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 90);
            this.panel4.TabIndex = 8;
            // 
            // txtThthTheLoai
            // 
            this.txtThthTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThthTheLoai.Location = new System.Drawing.Point(27, 38);
            this.txtThthTheLoai.Name = "txtThthTheLoai";
            this.txtThthTheLoai.Size = new System.Drawing.Size(146, 24);
            this.txtThthTheLoai.TabIndex = 1;
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTheLoai.Location = new System.Drawing.Point(197, 38);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(133, 33);
            this.btnThemTheLoai.TabIndex = 0;
            this.btnThemTheLoai.Text = "Thêm thể loại";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewTheLoai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 354);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewTheLoai
            // 
            this.dataGridViewTheLoai.AllowUserToAddRows = false;
            this.dataGridViewTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTheLoai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTheLoai.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTheLoai.Name = "dataGridViewTheLoai";
            this.dataGridViewTheLoai.RowHeadersVisible = false;
            this.dataGridViewTheLoai.Size = new System.Drawing.Size(779, 354);
            this.dataGridViewTheLoai.TabIndex = 0;
            this.dataGridViewTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TheLoaiGrid_CellClick);
            // 
            // ucTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucTheLoai";
            this.Size = new System.Drawing.Size(779, 444);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewTheLoai;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.TextBox txtThthTheLoai;
    }
}
