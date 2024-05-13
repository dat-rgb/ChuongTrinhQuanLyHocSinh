namespace GUI
{
    partial class frm_HocSinh
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_QueQuan = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaHS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.btn_XemDiem = new System.Windows.Forms.Button();
            this.btn_ThoiKhoaBieu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DoiMatKhau = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(228, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 605);
            this.panel3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_CCCD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.date_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_Lop);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_SoDienThoai);
            this.groupBox1.Controls.Add(this.txt_QueQuan);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.txt_MaHS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(39, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN HỌC SINH";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CCCD.Location = new System.Drawing.Point(125, 58);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(320, 28);
            this.txt_CCCD.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "CCCD:";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = global::GUI.Properties.Resources.pen_edit_32;
            this.btn_Sua.Location = new System.Drawing.Point(390, 331);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(87, 53);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.date_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinh.Location = new System.Drawing.Point(125, 136);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(320, 27);
            this.date_NgaySinh.TabIndex = 19;
            // 
            // txt_Lop
            // 
            this.txt_Lop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Lop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lop.Location = new System.Drawing.Point(125, 291);
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.ReadOnly = true;
            this.txt_Lop.Size = new System.Drawing.Size(320, 28);
            this.txt_Lop.TabIndex = 18;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(125, 252);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(320, 28);
            this.txt_Email.TabIndex = 17;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(125, 213);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(320, 28);
            this.txt_SoDienThoai.TabIndex = 16;
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_QueQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_QueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QueQuan.Location = new System.Drawing.Point(125, 174);
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(320, 28);
            this.txt_QueQuan.TabIndex = 15;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(125, 97);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(320, 28);
            this.txt_HoTen.TabIndex = 13;
            // 
            // txt_MaHS
            // 
            this.txt_MaHS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MaHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHS.Location = new System.Drawing.Point(125, 26);
            this.txt_MaHS.Name = "txt_MaHS";
            this.txt_MaHS.ReadOnly = true;
            this.txt_MaHS.Size = new System.Drawing.Size(320, 28);
            this.txt_MaHS.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số DT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quê quán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã HS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ và tên:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btn_DoiMatKhau);
            this.panel2.Controls.Add(this.btn_DangXuat);
            this.panel2.Controls.Add(this.btn_TraCuu);
            this.panel2.Controls.Add(this.btn_XemDiem);
            this.panel2.Controls.Add(this.btn_ThoiKhoaBieu);
            this.panel2.Location = new System.Drawing.Point(1, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 605);
            this.panel2.TabIndex = 10;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.Red;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 563);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(226, 42);
            this.btn_DangXuat.TabIndex = 10;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_TraCuu.BackColor = System.Drawing.Color.Transparent;
            this.btn_TraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraCuu.Image = global::GUI.Properties.Resources.search_48;
            this.btn_TraCuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_TraCuu.Location = new System.Drawing.Point(11, 189);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(197, 85);
            this.btn_TraCuu.TabIndex = 9;
            this.btn_TraCuu.Text = "Tra cứu";
            this.btn_TraCuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TraCuu.UseVisualStyleBackColor = false;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // btn_XemDiem
            // 
            this.btn_XemDiem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_XemDiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_XemDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDiem.Image = global::GUI.Properties.Resources.viewpoint_48;
            this.btn_XemDiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_XemDiem.Location = new System.Drawing.Point(11, 98);
            this.btn_XemDiem.Name = "btn_XemDiem";
            this.btn_XemDiem.Size = new System.Drawing.Size(197, 85);
            this.btn_XemDiem.TabIndex = 8;
            this.btn_XemDiem.Text = "Xem Điểm";
            this.btn_XemDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_XemDiem.UseVisualStyleBackColor = false;
            this.btn_XemDiem.Click += new System.EventHandler(this.btn_XemDiem_Click);
            // 
            // btn_ThoiKhoaBieu
            // 
            this.btn_ThoiKhoaBieu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ThoiKhoaBieu.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThoiKhoaBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThoiKhoaBieu.Image = global::GUI.Properties.Resources.Lich_48;
            this.btn_ThoiKhoaBieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ThoiKhoaBieu.Location = new System.Drawing.Point(11, 5);
            this.btn_ThoiKhoaBieu.Name = "btn_ThoiKhoaBieu";
            this.btn_ThoiKhoaBieu.Size = new System.Drawing.Size(197, 85);
            this.btn_ThoiKhoaBieu.TabIndex = 7;
            this.btn_ThoiKhoaBieu.Text = "Thời Khóa biểu";
            this.btn_ThoiKhoaBieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ThoiKhoaBieu.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 41);
            this.panel1.TabIndex = 9;
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(0, 515);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(226, 42);
            this.btn_DoiMatKhau.TabIndex = 22;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.UseVisualStyleBackColor = true;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // frm_HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 648);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_HocSinh";
            this.Text = "frm_HocSinh";
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_QueQuan;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MaHS;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.Button btn_XemDiem;
        private System.Windows.Forms.Button btn_ThoiKhoaBieu;
        private System.Windows.Forms.Button btn_TraCuu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_DoiMatKhau;
    }
}