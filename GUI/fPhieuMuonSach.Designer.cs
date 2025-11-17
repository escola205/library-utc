namespace GUI
{
    partial class fPhieuMuonSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboDocGia = new System.Windows.Forms.ComboBox();
            this.comboCuonSach = new System.Windows.Forms.ComboBox();
            this.dateNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.labelHanTra = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.labelTongNoMoi = new System.Windows.Forms.Label();
            this.labelTienPhat = new System.Windows.Forms.Label();
            this.labelDonPhat = new System.Windows.Forms.Label();
            this.labelNgayTre = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTongNo = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelMaDocGia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelMaCuonSach = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU MƯỢN TRẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin cuốn sách";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboDocGia);
            this.panel1.Controls.Add(this.comboCuonSach);
            this.panel1.Controls.Add(this.dateNgayMuon);
            this.panel1.Controls.Add(this.labelHanTra);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.labelTongNoMoi);
            this.panel1.Controls.Add(this.labelTienPhat);
            this.panel1.Controls.Add(this.labelDonPhat);
            this.panel1.Controls.Add(this.labelNgayTre);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labelTongNo);
            this.panel1.Controls.Add(this.labelHoTen);
            this.panel1.Controls.Add(this.labelMaDocGia);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelTheLoai);
            this.panel1.Controls.Add(this.labelTen);
            this.panel1.Controls.Add(this.labelMaCuonSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 426);
            this.panel1.TabIndex = 2;
            // 
            // comboDocGia
            // 
            this.comboDocGia.FormattingEnabled = true;
            this.comboDocGia.Location = new System.Drawing.Point(362, 127);
            this.comboDocGia.Name = "comboDocGia";
            this.comboDocGia.Size = new System.Drawing.Size(144, 21);
            this.comboDocGia.TabIndex = 25;
            this.comboDocGia.SelectedIndexChanged += new System.EventHandler(this.comboDocGia_SelectedIndexChanged);
            // 
            // comboCuonSach
            // 
            this.comboCuonSach.FormattingEnabled = true;
            this.comboCuonSach.Location = new System.Drawing.Point(77, 127);
            this.comboCuonSach.Name = "comboCuonSach";
            this.comboCuonSach.Size = new System.Drawing.Size(144, 21);
            this.comboCuonSach.TabIndex = 24;
            this.comboCuonSach.SelectedIndexChanged += new System.EventHandler(this.comboCuonSach_SelectedIndexChanged);
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayMuon.Location = new System.Drawing.Point(79, 284);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(95, 20);
            this.dateNgayMuon.TabIndex = 23;
            this.dateNgayMuon.ValueChanged += new System.EventHandler(this.dateNgayMuon_ValueChanged);
            // 
            // labelHanTra
            // 
            this.labelHanTra.AutoSize = true;
            this.labelHanTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHanTra.Location = new System.Drawing.Point(189, 284);
            this.labelHanTra.Name = "labelHanTra";
            this.labelHanTra.Size = new System.Drawing.Size(72, 18);
            this.labelHanTra.TabIndex = 22;
            this.labelHanTra.Text = "dd/mm/yy";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(235, 383);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 27);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.butSave_Click);
            // 
            // labelTongNoMoi
            // 
            this.labelTongNoMoi.AutoSize = true;
            this.labelTongNoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongNoMoi.Location = new System.Drawing.Point(359, 348);
            this.labelTongNoMoi.Name = "labelTongNoMoi";
            this.labelTongNoMoi.Size = new System.Drawing.Size(104, 18);
            this.labelTongNoMoi.TabIndex = 17;
            this.labelTongNoMoi.Text = "Tổng nợ mới:  ";
            // 
            // labelTienPhat
            // 
            this.labelTienPhat.AutoSize = true;
            this.labelTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienPhat.Location = new System.Drawing.Point(359, 319);
            this.labelTienPhat.Name = "labelTienPhat";
            this.labelTienPhat.Size = new System.Drawing.Size(80, 18);
            this.labelTienPhat.TabIndex = 16;
            this.labelTienPhat.Text = "Tiền phạt:  ";
            // 
            // labelDonPhat
            // 
            this.labelDonPhat.AutoSize = true;
            this.labelDonPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonPhat.Location = new System.Drawing.Point(359, 284);
            this.labelDonPhat.Name = "labelDonPhat";
            this.labelDonPhat.Size = new System.Drawing.Size(103, 18);
            this.labelDonPhat.TabIndex = 15;
            this.labelDonPhat.Text = "Đơn giá phạt:  ";
            // 
            // labelNgayTre
            // 
            this.labelNgayTre.AutoSize = true;
            this.labelNgayTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayTre.Location = new System.Drawing.Point(359, 250);
            this.labelNgayTre.Name = "labelNgayTre";
            this.labelNgayTre.Size = new System.Drawing.Size(116, 18);
            this.labelNgayTre.TabIndex = 14;
            this.labelNgayTre.Text = "Số ngày trả trễ:  ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(189, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Hạn trả ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ngày mượn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(202, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Chi tiết mượn trả ";
            // 
            // labelTongNo
            // 
            this.labelTongNo.AutoSize = true;
            this.labelTongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongNo.Location = new System.Drawing.Point(359, 185);
            this.labelTongNo.Name = "labelTongNo";
            this.labelTongNo.Size = new System.Drawing.Size(121, 18);
            this.labelTongNo.TabIndex = 8;
            this.labelTongNo.Text = "Tổng nợ hiện tại: ";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(359, 155);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(64, 18);
            this.labelHoTen.TabIndex = 7;
            this.labelHoTen.Text = "Họ tên:  ";
            // 
            // labelMaDocGia
            // 
            this.labelMaDocGia.AutoSize = true;
            this.labelMaDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaDocGia.Location = new System.Drawing.Point(359, 106);
            this.labelMaDocGia.Name = "labelMaDocGia";
            this.labelMaDocGia.Size = new System.Drawing.Size(93, 18);
            this.labelMaDocGia.TabIndex = 6;
            this.labelMaDocGia.Text = "Mã độc giả:  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thông tin độc giả";
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheLoai.Location = new System.Drawing.Point(74, 185);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(68, 18);
            this.labelTheLoai.TabIndex = 4;
            this.labelTheLoai.Text = "Thể loại: ";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(74, 155);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(49, 18);
            this.labelTen.TabIndex = 3;
            this.labelTen.Text = "Tên:   ";
            // 
            // labelMaCuonSach
            // 
            this.labelMaCuonSach.AutoSize = true;
            this.labelMaCuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaCuonSach.Location = new System.Drawing.Point(74, 106);
            this.labelMaCuonSach.Name = "labelMaCuonSach";
            this.labelMaCuonSach.Size = new System.Drawing.Size(118, 18);
            this.labelMaCuonSach.TabIndex = 2;
            this.labelMaCuonSach.Text = "Mã cuốn sách:   ";
            // 
            // fPhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fPhieuMuonSach";
            this.Text = "Sửa phiếu mượn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label labelTongNoMoi;
        private System.Windows.Forms.Label labelTienPhat;
        private System.Windows.Forms.Label labelDonPhat;
        private System.Windows.Forms.Label labelNgayTre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTongNo;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelMaDocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTheLoai;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelMaCuonSach;
        private System.Windows.Forms.Label labelHanTra;
        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.ComboBox comboDocGia;
        private System.Windows.Forms.ComboBox comboCuonSach;
    }
}