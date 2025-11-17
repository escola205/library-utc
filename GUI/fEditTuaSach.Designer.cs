namespace GUI
{
    partial class fEditTuaSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMaTuaSach = new System.Windows.Forms.Label();
            this.btnThemTacGia = new System.Windows.Forms.Button();
            this.comboBoxTacGia = new System.Windows.Forms.ComboBox();
            this.datagridTacGia = new System.Windows.Forms.DataGridView();
            this.TenTacGiaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.comTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTenTuaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenTuaSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelMaTuaSach);
            this.panel1.Controls.Add(this.btnThemTacGia);
            this.panel1.Controls.Add(this.comboBoxTacGia);
            this.panel1.Controls.Add(this.datagridTacGia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTheLoai);
            this.panel1.Controls.Add(this.btnThemSua);
            this.panel1.Controls.Add(this.comTheLoai);
            this.panel1.Controls.Add(this.txtTenTuaSach);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTenTuaSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 422);
            this.panel1.TabIndex = 0;
            // 
            // labelMaTuaSach
            // 
            this.labelMaTuaSach.AutoSize = true;
            this.labelMaTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaTuaSach.Location = new System.Drawing.Point(66, 35);
            this.labelMaTuaSach.Name = "labelMaTuaSach";
            this.labelMaTuaSach.Size = new System.Drawing.Size(97, 17);
            this.labelMaTuaSach.TabIndex = 32;
            this.labelMaTuaSach.Text = "Mã tựa sách:  ";
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTacGia.Location = new System.Drawing.Point(174, 323);
            this.btnThemTacGia.Name = "btnThemTacGia";
            this.btnThemTacGia.Size = new System.Drawing.Size(108, 24);
            this.btnThemTacGia.TabIndex = 30;
            this.btnThemTacGia.Text = "Thêm tác giả";
            this.btnThemTacGia.UseVisualStyleBackColor = true;
            this.btnThemTacGia.Click += new System.EventHandler(this.butAddTacGia_Click);
            // 
            // comboBoxTacGia
            // 
            this.comboBoxTacGia.FormattingEnabled = true;
            this.comboBoxTacGia.Location = new System.Drawing.Point(20, 323);
            this.comboBoxTacGia.Name = "comboBoxTacGia";
            this.comboBoxTacGia.Size = new System.Drawing.Size(123, 21);
            this.comboBoxTacGia.TabIndex = 28;
            // 
            // datagridTacGia
            // 
            this.datagridTacGia.AllowUserToAddRows = false;
            this.datagridTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTacGia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagridTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTacGiaCol,
            this.id});
            this.datagridTacGia.Location = new System.Drawing.Point(20, 206);
            this.datagridTacGia.Name = "datagridTacGia";
            this.datagridTacGia.RowHeadersVisible = false;
            this.datagridTacGia.Size = new System.Drawing.Size(262, 108);
            this.datagridTacGia.TabIndex = 27;
            this.datagridTacGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datagridTacGia_KeyDown);
            // 
            // TenTacGiaCol
            // 
            this.TenTacGiaCol.DataPropertyName = "TenTacGia";
            this.TenTacGiaCol.HeaderText = "Tên tác giả";
            this.TenTacGiaCol.Name = "TenTacGiaCol";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Đanh sách tác giả ";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.Location = new System.Drawing.Point(17, 131);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(59, 17);
            this.lbTheLoai.TabIndex = 25;
            this.lbTheLoai.Text = "Thể loại";
            // 
            // btnThemSua
            // 
            this.btnThemSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSua.Location = new System.Drawing.Point(103, 375);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(105, 34);
            this.btnThemSua.TabIndex = 24;
            this.btnThemSua.Text = "Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.butOK_Click);
            // 
            // comTheLoai
            // 
            this.comTheLoai.FormattingEnabled = true;
            this.comTheLoai.Location = new System.Drawing.Point(20, 151);
            this.comTheLoai.Name = "comTheLoai";
            this.comTheLoai.Size = new System.Drawing.Size(262, 21);
            this.comTheLoai.TabIndex = 14;
            // 
            // txtTenTuaSach
            // 
            this.txtTenTuaSach.Location = new System.Drawing.Point(20, 92);
            this.txtTenTuaSach.Name = "txtTenTuaSach";
            this.txtTenTuaSach.Size = new System.Drawing.Size(262, 20);
            this.txtTenTuaSach.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // lbTenTuaSach
            // 
            this.lbTenTuaSach.AutoSize = true;
            this.lbTenTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTuaSach.Location = new System.Drawing.Point(17, 72);
            this.lbTenTuaSach.Name = "lbTenTuaSach";
            this.lbTenTuaSach.Size = new System.Drawing.Size(91, 17);
            this.lbTenTuaSach.TabIndex = 1;
            this.lbTenTuaSach.Text = "Tên tựa sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA THÔNG TIN TỰA SÁCH";
            // 
            // fEditTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 463);
            this.Controls.Add(this.panel1);
            this.Name = "fEditTuaSach";
            this.Text = "Sửa thông tin tựa sách";
            this.Load += new System.EventHandler(this.fEditTuaSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTenTuaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTuaSach;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.DataGridView datagridTacGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.ComboBox comTheLoai;
        private System.Windows.Forms.ComboBox comboBoxTacGia;
        private System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.Label labelMaTuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGiaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}