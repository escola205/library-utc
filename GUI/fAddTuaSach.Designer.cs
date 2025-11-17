using System.Windows.Forms;

namespace GUI
{
    partial class fAddTuaSach
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemTacGia = new System.Windows.Forms.Button();
            this.comboBoxTacGia = new System.Windows.Forms.ComboBox();
            this.dataTenTuaSacTuaSach = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.btnThemTuaSach = new System.Windows.Forms.Button();
            this.comTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTenTuaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTenTuaSach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTenTuaSacTuaSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnThemTacGia);
            this.panel1.Controls.Add(this.comboBoxTacGia);
            this.panel1.Controls.Add(this.dataTenTuaSacTuaSach);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTheLoai);
            this.panel1.Controls.Add(this.btnThemTuaSach);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "*Chọn và nhấn Delete để xóa tác giả";
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTacGia.Location = new System.Drawing.Point(174, 307);
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
            this.comboBoxTacGia.Location = new System.Drawing.Point(20, 310);
            this.comboBoxTacGia.Name = "comboBoxTacGia";
            this.comboBoxTacGia.Size = new System.Drawing.Size(123, 21);
            this.comboBoxTacGia.TabIndex = 28;
            // 
            // dataTenTuaSacTuaSach
            // 
            this.dataTenTuaSacTuaSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTenTuaSacTuaSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataTenTuaSacTuaSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTenTuaSacTuaSach.ColumnHeadersVisible = false;
            this.dataTenTuaSacTuaSach.Location = new System.Drawing.Point(20, 172);
            this.dataTenTuaSacTuaSach.Name = "dataTenTuaSacTuaSach";
            this.dataTenTuaSacTuaSach.RowHeadersVisible = false;
            this.dataTenTuaSacTuaSach.Size = new System.Drawing.Size(262, 108);
            this.dataTenTuaSacTuaSach.TabIndex = 27;
            this.dataTenTuaSacTuaSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataTenTuaSacTuaSach_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Đanh sách tác giả ";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.Location = new System.Drawing.Point(17, 92);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(59, 17);
            this.lbTheLoai.TabIndex = 25;
            this.lbTheLoai.Text = "Thể loại";
            // 
            // btnThemTuaSach
            // 
            this.btnThemTuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTuaSach.Location = new System.Drawing.Point(103, 375);
            this.btnThemTuaSach.Name = "btnThemTuaSach";
            this.btnThemTuaSach.Size = new System.Drawing.Size(105, 34);
            this.btnThemTuaSach.TabIndex = 24;
            this.btnThemTuaSach.Text = "Thêm";
            this.btnThemTuaSach.UseVisualStyleBackColor = true;
            this.btnThemTuaSach.Click += new System.EventHandler(this.butOK_Click);
            // 
            // comTheLoai
            // 
            this.comTheLoai.FormattingEnabled = true;
            this.comTheLoai.Location = new System.Drawing.Point(20, 112);
            this.comTheLoai.Name = "comTheLoai";
            this.comTheLoai.Size = new System.Drawing.Size(262, 21);
            this.comTheLoai.TabIndex = 14;
            // 
            // txtTenTuaSach
            // 
            this.txtTenTuaSach.Location = new System.Drawing.Point(20, 64);
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
            this.lbTenTuaSach.Location = new System.Drawing.Point(17, 46);
            this.lbTenTuaSach.Name = "lbTenTuaSach";
            this.lbTenTuaSach.Size = new System.Drawing.Size(91, 17);
            this.lbTenTuaSach.TabIndex = 1;
            this.lbTenTuaSach.Text = "Tên tựa sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM TỰA SÁCH";
            // 
            // fAddTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 463);
            this.Controls.Add(this.panel1);
            this.Name = "fAddTuaSach";
            this.Text = "Thêm tựa sách";
            this.Load += new System.EventHandler(this.fAddTuaSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTenTuaSacTuaSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTenTuaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTuaSach;
        private System.Windows.Forms.Button btnThemTuaSach;
        private System.Windows.Forms.DataGridView dataTenTuaSacTuaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.ComboBox comTheLoai;
        private System.Windows.Forms.ComboBox comboBoxTacGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGiaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}