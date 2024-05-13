namespace GUI
{
    partial class frm_QuanLyGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyGiaoVien));
            this.dgv_DanhSachGiaoVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.gpb_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.date_NgayVao = new System.Windows.Forms.DateTimePicker();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_ChucVu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_KhoiPhucGVDaXoa = new System.Windows.Forms.Button();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_TrinhDo = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_QueQuan = new System.Windows.Forms.TextBox();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_SoCCCD = new System.Windows.Forms.TextBox();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MaGV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachGiaoVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpb_ThongTinHocSinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachGiaoVien
            // 
            this.dgv_DanhSachGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachGiaoVien.Location = new System.Drawing.Point(13, 279);
            this.dgv_DanhSachGiaoVien.Name = "dgv_DanhSachGiaoVien";
            this.dgv_DanhSachGiaoVien.ReadOnly = true;
            this.dgv_DanhSachGiaoVien.RowHeadersWidth = 51;
            this.dgv_DanhSachGiaoVien.RowTemplate.Height = 24;
            this.dgv_DanhSachGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachGiaoVien.Size = new System.Drawing.Size(1498, 491);
            this.dgv_DanhSachGiaoVien.TabIndex = 0;
            this.dgv_DanhSachGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachGiaoVien_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.dgv_DanhSachGiaoVien);
            this.panel1.Controls.Add(this.gpb_ThongTinHocSinh);
            this.panel1.Location = new System.Drawing.Point(-1, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 786);
            this.panel1.TabIndex = 4;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(1392, 112);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 71);
            this.btn_TimKiem.TabIndex = 19;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(1267, 112);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 71);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(1392, 188);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 71);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(1267, 189);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 71);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gpb_ThongTinHocSinh
            // 
            this.gpb_ThongTinHocSinh.BackColor = System.Drawing.Color.Gainsboro;
            this.gpb_ThongTinHocSinh.Controls.Add(this.label12);
            this.gpb_ThongTinHocSinh.Controls.Add(this.date_NgayVao);
            this.gpb_ThongTinHocSinh.Controls.Add(this.date_NgaySinh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_ChucVu);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label6);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_KhoiPhucGVDaXoa);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_Refesh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_Clear);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label7);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_TrinhDo);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_Email);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label8);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label9);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_SoDienThoai);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label10);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label11);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_QueQuan);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_GioiTinh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_HoTen);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_SoCCCD);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_MaGV);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label5);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label4);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label3);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label2);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label1);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_MaGV);
            this.gpb_ThongTinHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ThongTinHocSinh.ForeColor = System.Drawing.Color.Red;
            this.gpb_ThongTinHocSinh.Location = new System.Drawing.Point(14, 14);
            this.gpb_ThongTinHocSinh.Name = "gpb_ThongTinHocSinh";
            this.gpb_ThongTinHocSinh.Size = new System.Drawing.Size(1247, 245);
            this.gpb_ThongTinHocSinh.TabIndex = 1;
            this.gpb_ThongTinHocSinh.TabStop = false;
            this.gpb_ThongTinHocSinh.Text = "THÔNG TIN GIÁO VIÊN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(979, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Nhập thông tin để tìm kiếm";
            // 
            // date_NgayVao
            // 
            this.date_NgayVao.CustomFormat = "dd/MM/yyyy";
            this.date_NgayVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayVao.Location = new System.Drawing.Point(795, 166);
            this.date_NgayVao.Name = "date_NgayVao";
            this.date_NgayVao.Size = new System.Drawing.Size(178, 27);
            this.date_NgayVao.TabIndex = 45;
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinh.Location = new System.Drawing.Point(304, 166);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(178, 27);
            this.date_NgaySinh.TabIndex = 44;
            // 
            // cbb_ChucVu
            // 
            this.cbb_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ChucVu.FormattingEnabled = true;
            this.cbb_ChucVu.Location = new System.Drawing.Point(795, 130);
            this.cbb_ChucVu.Name = "cbb_ChucVu";
            this.cbb_ChucVu.Size = new System.Drawing.Size(347, 28);
            this.cbb_ChucVu.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(645, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Chức vụ:";
            // 
            // btn_KhoiPhucGVDaXoa
            // 
            this.btn_KhoiPhucGVDaXoa.BackColor = System.Drawing.Color.DarkGray;
            this.btn_KhoiPhucGVDaXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_KhoiPhucGVDaXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhucGVDaXoa.ForeColor = System.Drawing.Color.Black;
            this.btn_KhoiPhucGVDaXoa.Location = new System.Drawing.Point(950, 202);
            this.btn_KhoiPhucGVDaXoa.Name = "btn_KhoiPhucGVDaXoa";
            this.btn_KhoiPhucGVDaXoa.Size = new System.Drawing.Size(93, 33);
            this.btn_KhoiPhucGVDaXoa.TabIndex = 41;
            this.btn_KhoiPhucGVDaXoa.Text = "Khôi phục";
            this.btn_KhoiPhucGVDaXoa.UseVisualStyleBackColor = false;
            this.btn_KhoiPhucGVDaXoa.Click += new System.EventHandler(this.btn_KhoiPhucGVDaXoa_Click);
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refesh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refesh.Location = new System.Drawing.Point(1049, 202);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(93, 33);
            this.btn_Refesh.TabIndex = 39;
            this.btn_Refesh.Text = "Refesh";
            this.btn_Refesh.UseVisualStyleBackColor = false;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(1148, 202);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 33);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 136);
            this.label7.TabIndex = 38;
            // 
            // cbb_TrinhDo
            // 
            this.cbb_TrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrinhDo.FormattingEnabled = true;
            this.cbb_TrinhDo.Location = new System.Drawing.Point(795, 94);
            this.cbb_TrinhDo.Name = "cbb_TrinhDo";
            this.cbb_TrinhDo.Size = new System.Drawing.Size(347, 28);
            this.cbb_TrinhDo.TabIndex = 19;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(795, 58);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(347, 27);
            this.txt_Email.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(645, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ngày vào :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(645, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Trình độ:";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(795, 24);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(347, 27);
            this.txt_SoDienThoai.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(645, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(645, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Số Điện thoại:";
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_QueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QueQuan.Location = new System.Drawing.Point(304, 199);
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(312, 27);
            this.txt_QueQuan.TabIndex = 12;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_GioiTinh.Location = new System.Drawing.Point(304, 130);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(121, 28);
            this.cbb_GioiTinh.TabIndex = 10;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(304, 95);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(312, 27);
            this.txt_HoTen.TabIndex = 9;
            // 
            // txt_SoCCCD
            // 
            this.txt_SoCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoCCCD.Location = new System.Drawing.Point(304, 58);
            this.txt_SoCCCD.Name = "txt_SoCCCD";
            this.txt_SoCCCD.Size = new System.Drawing.Size(312, 27);
            this.txt_SoCCCD.TabIndex = 8;
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGV.Location = new System.Drawing.Point(304, 24);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(312, 27);
            this.txt_MaGV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(168, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quê quán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(168, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(168, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(168, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(168, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số CCCD:";
            // 
            // lbl_MaGV
            // 
            this.lbl_MaGV.AutoSize = true;
            this.lbl_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaGV.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaGV.Location = new System.Drawing.Point(168, 27);
            this.lbl_MaGV.Name = "lbl_MaGV";
            this.lbl_MaGV.Size = new System.Drawing.Size(119, 20);
            this.lbl_MaGV.TabIndex = 1;
            this.lbl_MaGV.Text = "Mã Giáo viên";
            // 
            // frm_QuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 790);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLyGiaoVien";
            this.Text = "frm_QuanLyGiaoVien";
            this.Load += new System.EventHandler(this.frm_QuanLyGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachGiaoVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gpb_ThongTinHocSinh.ResumeLayout(false);
            this.gpb_ThongTinHocSinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_DanhSachGiaoVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpb_ThongTinHocSinh;
        private System.Windows.Forms.Button btn_KhoiPhucGVDaXoa;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_TrinhDo;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_QueQuan;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_SoCCCD;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MaGV;
        private System.Windows.Forms.ComboBox cbb_ChucVu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_NgayVao;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label12;
    }
}