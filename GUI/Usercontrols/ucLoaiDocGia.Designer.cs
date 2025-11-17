namespace GUI.Usercontrols
{
    partial class ucLoaiDocGia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadDocGia = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewLoaiDocGiaDocGia = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiDocGiaDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 71);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoadDocGia);
            this.panel2.Controls.Add(this.txt);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 71);
            this.panel2.TabIndex = 0;
            // 
            // btnLoadDocGia
            // 
            this.btnLoadDocGia.Image = global::GUI.Properties.Resources.phieumuontra;
            this.btnLoadDocGia.Location = new System.Drawing.Point(386, 24);
            this.btnLoadDocGia.Name = "btnLoadDocGia";
            this.btnLoadDocGia.Size = new System.Drawing.Size(31, 24);
            this.btnLoadDocGia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoadDocGia.TabIndex = 4;
            this.btnLoadDocGia.TabStop = false;
            this.btnLoadDocGia.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(18, 24);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(182, 24);
            this.txt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(217, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm loại độc giả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewLoaiDocGiaDocGia);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 312);
            this.panel3.TabIndex = 1;
            // 
            // dataGridViewLoaiDocGiaDocGia
            // 
            this.dataGridViewLoaiDocGiaDocGia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLoaiDocGiaDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiDocGiaDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLoaiDocGiaDocGia.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLoaiDocGiaDocGia.Name = "dataGridViewLoaiDocGiaDocGia";
            this.dataGridViewLoaiDocGiaDocGia.RowHeadersVisible = false;
            this.dataGridViewLoaiDocGiaDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colID,
                this.colTenLoai
            });

            this.dataGridViewLoaiDocGiaDocGia.Size = new System.Drawing.Size(704, 312);
            this.dataGridViewLoaiDocGiaDocGia.TabIndex = 0;
            this.dataGridViewLoaiDocGiaDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoaiDocGiaGrid_CellClick);

            // colID
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.DataPropertyName = "id";
            this.colID.Width = 70;
            this.colID.ReadOnly = true;

            // colTenLoai
            this.colTenLoai.HeaderText = "Tên loại độc giả";
            this.colTenLoai.Name = "colTenLoai";
            this.colTenLoai.DataPropertyName = "TenLoaiDocGia";
            this.colTenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLoai.ReadOnly = true;


            // 
            // ucLoaiDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ucLoaiDocGia";
            this.Size = new System.Drawing.Size(704, 383);
            this.Load += new System.EventHandler(this.ucLoaiDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDocGia)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiDocGiaDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewLoaiDocGiaDocGia;
        private System.Windows.Forms.PictureBox btnLoadDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;

    }
}
