namespace GUI.Usercontrols
{
    partial class ucMuonTheoTheLoai
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
            this.labelTongLuotMuon = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtTaoNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.btnXoaBaoCao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.labelTongLuotMuon);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 109);
            this.panel1.TabIndex = 0;
            // 
            // labelTongLuotMuon
            // 
            this.labelTongLuotMuon.AutoSize = true;
            this.labelTongLuotMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongLuotMuon.Location = new System.Drawing.Point(484, 48);
            this.labelTongLuotMuon.Name = "labelTongLuotMuon";
            this.labelTongLuotMuon.Size = new System.Drawing.Size(16, 18);
            this.labelTongLuotMuon.TabIndex = 10;
            this.labelTongLuotMuon.Text = "  ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtTaoNgay);
            this.panel4.Controls.Add(this.btnTaoBaoCao);
            this.panel4.Controls.Add(this.btnXoaBaoCao);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 109);
            this.panel4.TabIndex = 8;
            // 
            // dtTaoNgay
            // 
            this.dtTaoNgay.CustomFormat = "MM/yyyy";
            this.dtTaoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTaoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTaoNgay.Location = new System.Drawing.Point(15, 43);
            this.dtTaoNgay.Name = "dtTaoNgay";
            this.dtTaoNgay.Size = new System.Drawing.Size(122, 24);
            this.dtTaoNgay.TabIndex = 7;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(162, 39);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(116, 33);
            this.btnTaoBaoCao.TabIndex = 6;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // btnXoaBaoCao
            // 
            this.btnXoaBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBaoCao.Location = new System.Drawing.Point(302, 39);
            this.btnXoaBaoCao.Name = "btnXoaBaoCao";
            this.btnXoaBaoCao.Size = new System.Drawing.Size(107, 33);
            this.btnXoaBaoCao.TabIndex = 0;
            this.btnXoaBaoCao.Text = "Xóa báo cáo";
            this.btnXoaBaoCao.UseVisualStyleBackColor = true;
            this.btnXoaBaoCao.Click += new System.EventHandler(this.butHien_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 335);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(779, 335);
            this.dataGridView.TabIndex = 0;
            // 
            // ucMuonTheoTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucMuonTheoTheLoai";
            this.Size = new System.Drawing.Size(779, 444);
            this.Load += new System.EventHandler(this.ucMuonTheoTheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaBaoCao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.DateTimePicker dtTaoNgay;
        private System.Windows.Forms.Label labelTongLuotMuon;
    }
}
