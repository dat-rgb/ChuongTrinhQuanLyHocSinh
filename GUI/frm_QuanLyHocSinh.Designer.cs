namespace GUI
{
    partial class frm_QuanLyHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyHocSinh));
            this.dgv_DanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.gpb_DSHocSinh = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_TrangThaiChon = new System.Windows.Forms.ComboBox();
            this.cbb_Khoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.gpb_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.btn_refesh = new System.Windows.Forms.Button();
            this.cbb_NamHoc = new System.Windows.Forms.ComboBox();
            this.lbl_NamHoc = new System.Windows.Forms.Label();
            this.btn_DiemHS = new System.Windows.Forms.Button();
            this.btn_KhoiPhucHSDaXoa = new System.Windows.Forms.Button();
            this.date_NamNhapHoc = new System.Windows.Forms.DateTimePicker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Avatar = new System.Windows.Forms.Label();
            this.cbb_LopHoc = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_HuongDan = new System.Windows.Forms.Label();
            this.lbl_NamNhapHoc = new System.Windows.Forms.Label();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl__SoDienThoai = new System.Windows.Forms.Label();
            this.txt_QueQuan = new System.Windows.Forms.TextBox();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_SoCCCD = new System.Windows.Forms.TextBox();
            this.txt_MaHS = new System.Windows.Forms.TextBox();
            this.lbl_QueQuan = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_SOCCCD = new System.Windows.Forms.Label();
            this.lbl_MaHS = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHocSinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpb_DSHocSinh.SuspendLayout();
            this.gpb_ThongTinHocSinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachHocSinh
            // 
            this.dgv_DanhSachHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHocSinh.Location = new System.Drawing.Point(6, 43);
            this.dgv_DanhSachHocSinh.Name = "dgv_DanhSachHocSinh";
            this.dgv_DanhSachHocSinh.ReadOnly = true;
            this.dgv_DanhSachHocSinh.RowHeadersWidth = 51;
            this.dgv_DanhSachHocSinh.RowTemplate.Height = 24;
            this.dgv_DanhSachHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachHocSinh.Size = new System.Drawing.Size(1486, 417);
            this.dgv_DanhSachHocSinh.TabIndex = 0;
            this.dgv_DanhSachHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachHocSinh_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.gpb_DSHocSinh);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.gpb_ThongTinHocSinh);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 797);
            this.panel1.TabIndex = 2;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Red;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(1393, 759);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(119, 27);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // gpb_DSHocSinh
            // 
            this.gpb_DSHocSinh.BackColor = System.Drawing.Color.White;
            this.gpb_DSHocSinh.Controls.Add(this.label2);
            this.gpb_DSHocSinh.Controls.Add(this.cbb_TrangThaiChon);
            this.gpb_DSHocSinh.Controls.Add(this.cbb_Khoi);
            this.gpb_DSHocSinh.Controls.Add(this.label1);
            this.gpb_DSHocSinh.Controls.Add(this.dgv_DanhSachHocSinh);
            this.gpb_DSHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_DSHocSinh.ForeColor = System.Drawing.Color.Black;
            this.gpb_DSHocSinh.Location = new System.Drawing.Point(14, 287);
            this.gpb_DSHocSinh.Name = "gpb_DSHocSinh";
            this.gpb_DSHocSinh.Size = new System.Drawing.Size(1498, 466);
            this.gpb_DSHocSinh.TabIndex = 0;
            this.gpb_DSHocSinh.TabStop = false;
            this.gpb_DSHocSinh.Text = "DANH SÁCH HỌC SINH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1054, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Trạng thái:";
            // 
            // cbb_TrangThaiChon
            // 
            this.cbb_TrangThaiChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThaiChon.FormattingEnabled = true;
            this.cbb_TrangThaiChon.Items.AddRange(new object[] {
            "1",
            "Tốt nghiệp",
            "Xóa"});
            this.cbb_TrangThaiChon.Location = new System.Drawing.Point(1153, 10);
            this.cbb_TrangThaiChon.Name = "cbb_TrangThaiChon";
            this.cbb_TrangThaiChon.Size = new System.Drawing.Size(329, 26);
            this.cbb_TrangThaiChon.TabIndex = 65;
            this.cbb_TrangThaiChon.SelectedIndexChanged += new System.EventHandler(this.cbb_TrangThaiChon_SelectedIndexChanged);
            // 
            // cbb_Khoi
            // 
            this.cbb_Khoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Khoi.FormattingEnabled = true;
            this.cbb_Khoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbb_Khoi.Location = new System.Drawing.Point(877, 10);
            this.cbb_Khoi.Name = "cbb_Khoi";
            this.cbb_Khoi.Size = new System.Drawing.Size(160, 26);
            this.cbb_Khoi.TabIndex = 5;
            this.cbb_Khoi.SelectedIndexChanged += new System.EventHandler(this.cbb_Khoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(818, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Khối:";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(1393, 117);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 71);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = global::GUI.Properties.Resources.edit_48;
            this.btn_Sua.Location = new System.Drawing.Point(1268, 117);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 71);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(1393, 193);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 71);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // gpb_ThongTinHocSinh
            // 
            this.gpb_ThongTinHocSinh.BackColor = System.Drawing.Color.Gainsboro;
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_TrangThai);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_TrangThai);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_refesh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_NamHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_NamHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_DiemHS);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_KhoiPhucHSDaXoa);
            this.gpb_ThongTinHocSinh.Controls.Add(this.date_NamNhapHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_Clear);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_Avatar);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_LopHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_Email);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_HuongDan);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_NamNhapHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_Lop);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_SoDienThoai);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_Email);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl__SoDienThoai);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_QueQuan);
            this.gpb_ThongTinHocSinh.Controls.Add(this.date_NgaySinh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_GioiTinh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_HoTen);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_SoCCCD);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_MaHS);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_QueQuan);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_NgaySinh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_GioiTinh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_HoTen);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_SOCCCD);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_MaHS);
            this.gpb_ThongTinHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ThongTinHocSinh.ForeColor = System.Drawing.Color.Red;
            this.gpb_ThongTinHocSinh.Location = new System.Drawing.Point(14, 14);
            this.gpb_ThongTinHocSinh.Name = "gpb_ThongTinHocSinh";
            this.gpb_ThongTinHocSinh.Size = new System.Drawing.Size(1248, 267);
            this.gpb_ThongTinHocSinh.TabIndex = 0;
            this.gpb_ThongTinHocSinh.TabStop = false;
            this.gpb_ThongTinHocSinh.Text = "THÔNG TIN HỌC SINH";
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Items.AddRange(new object[] {
            "1",
            "Tốt nghiệp",
            "Xóa"});
            this.cbb_TrangThai.Location = new System.Drawing.Point(860, 185);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(329, 28);
            this.cbb_TrangThai.TabIndex = 63;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrangThai.ForeColor = System.Drawing.Color.Black;
            this.lbl_TrangThai.Location = new System.Drawing.Point(701, 189);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(100, 20);
            this.lbl_TrangThai.TabIndex = 64;
            this.lbl_TrangThai.Text = "Trạng thái:";
            // 
            // btn_refesh
            // 
            this.btn_refesh.BackColor = System.Drawing.Color.DimGray;
            this.btn_refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refesh.ForeColor = System.Drawing.Color.Transparent;
            this.btn_refesh.Location = new System.Drawing.Point(1113, 228);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(129, 33);
            this.btn_refesh.TabIndex = 62;
            this.btn_refesh.Text = "Refesh";
            this.btn_refesh.UseVisualStyleBackColor = false;
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // cbb_NamHoc
            // 
            this.cbb_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NamHoc.FormattingEnabled = true;
            this.cbb_NamHoc.Location = new System.Drawing.Point(860, 85);
            this.cbb_NamHoc.Name = "cbb_NamHoc";
            this.cbb_NamHoc.Size = new System.Drawing.Size(329, 28);
            this.cbb_NamHoc.TabIndex = 9;
            this.cbb_NamHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_NamHoc_SelectedIndexChanged);
            // 
            // lbl_NamHoc
            // 
            this.lbl_NamHoc.AutoSize = true;
            this.lbl_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamHoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_NamHoc.Location = new System.Drawing.Point(701, 89);
            this.lbl_NamHoc.Name = "lbl_NamHoc";
            this.lbl_NamHoc.Size = new System.Drawing.Size(89, 20);
            this.lbl_NamHoc.TabIndex = 61;
            this.lbl_NamHoc.Text = "Năm học:";
            // 
            // btn_DiemHS
            // 
            this.btn_DiemHS.BackColor = System.Drawing.Color.DimGray;
            this.btn_DiemHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DiemHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DiemHS.ForeColor = System.Drawing.Color.Transparent;
            this.btn_DiemHS.Location = new System.Drawing.Point(843, 228);
            this.btn_DiemHS.Name = "btn_DiemHS";
            this.btn_DiemHS.Size = new System.Drawing.Size(129, 33);
            this.btn_DiemHS.TabIndex = 15;
            this.btn_DiemHS.Text = "Điểm HS";
            this.btn_DiemHS.UseVisualStyleBackColor = false;
            this.btn_DiemHS.Click += new System.EventHandler(this.btn_DiemHS_Click);
            // 
            // btn_KhoiPhucHSDaXoa
            // 
            this.btn_KhoiPhucHSDaXoa.BackColor = System.Drawing.Color.DimGray;
            this.btn_KhoiPhucHSDaXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_KhoiPhucHSDaXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhucHSDaXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_KhoiPhucHSDaXoa.Location = new System.Drawing.Point(710, 228);
            this.btn_KhoiPhucHSDaXoa.Name = "btn_KhoiPhucHSDaXoa";
            this.btn_KhoiPhucHSDaXoa.Size = new System.Drawing.Size(129, 33);
            this.btn_KhoiPhucHSDaXoa.TabIndex = 12;
            this.btn_KhoiPhucHSDaXoa.Text = "Khôi phục";
            this.btn_KhoiPhucHSDaXoa.UseVisualStyleBackColor = false;
            this.btn_KhoiPhucHSDaXoa.Click += new System.EventHandler(this.btn_KhoiPhucHSDaXoa_Click);
            // 
            // date_NamNhapHoc
            // 
            this.date_NamNhapHoc.CustomFormat = "dd/MM/yyyy";
            this.date_NamNhapHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NamNhapHoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NamNhapHoc.Location = new System.Drawing.Point(860, 153);
            this.date_NamNhapHoc.Name = "date_NamNhapHoc";
            this.date_NamNhapHoc.Size = new System.Drawing.Size(160, 27);
            this.date_NamNhapHoc.TabIndex = 11;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DimGray;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Clear.Location = new System.Drawing.Point(978, 228);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 33);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Avatar
            // 
            this.lbl_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Avatar.Image")));
            this.lbl_Avatar.Location = new System.Drawing.Point(6, 35);
            this.lbl_Avatar.Name = "lbl_Avatar";
            this.lbl_Avatar.Size = new System.Drawing.Size(127, 148);
            this.lbl_Avatar.TabIndex = 0;
            // 
            // cbb_LopHoc
            // 
            this.cbb_LopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LopHoc.FormattingEnabled = true;
            this.cbb_LopHoc.Location = new System.Drawing.Point(860, 119);
            this.cbb_LopHoc.Name = "cbb_LopHoc";
            this.cbb_LopHoc.Size = new System.Drawing.Size(329, 28);
            this.cbb_LopHoc.TabIndex = 10;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(860, 52);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.ShortcutsEnabled = false;
            this.txt_Email.Size = new System.Drawing.Size(329, 27);
            this.txt_Email.TabIndex = 8;
            // 
            // lbl_HuongDan
            // 
            this.lbl_HuongDan.AutoSize = true;
            this.lbl_HuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HuongDan.ForeColor = System.Drawing.Color.Black;
            this.lbl_HuongDan.Location = new System.Drawing.Point(1026, 158);
            this.lbl_HuongDan.Name = "lbl_HuongDan";
            this.lbl_HuongDan.Size = new System.Drawing.Size(163, 16);
            this.lbl_HuongDan.TabIndex = 0;
            this.lbl_HuongDan.Text = "Nhập thông tin để tìm kiếm";
            // 
            // lbl_NamNhapHoc
            // 
            this.lbl_NamNhapHoc.AutoSize = true;
            this.lbl_NamNhapHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamNhapHoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_NamNhapHoc.Location = new System.Drawing.Point(701, 156);
            this.lbl_NamNhapHoc.Name = "lbl_NamNhapHoc";
            this.lbl_NamNhapHoc.Size = new System.Drawing.Size(138, 20);
            this.lbl_NamNhapHoc.TabIndex = 16;
            this.lbl_NamNhapHoc.Text = "Năm Nhập học:";
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lop.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lop.Location = new System.Drawing.Point(701, 123);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(46, 20);
            this.lbl_Lop.TabIndex = 15;
            this.lbl_Lop.Text = "Lớp:";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(860, 19);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(329, 27);
            this.txt_SoDienThoai.TabIndex = 7;
            this.txt_SoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email.Location = new System.Drawing.Point(701, 55);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(62, 20);
            this.lbl_Email.TabIndex = 14;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl__SoDienThoai
            // 
            this.lbl__SoDienThoai.AutoSize = true;
            this.lbl__SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__SoDienThoai.ForeColor = System.Drawing.Color.Black;
            this.lbl__SoDienThoai.Location = new System.Drawing.Point(701, 22);
            this.lbl__SoDienThoai.Name = "lbl__SoDienThoai";
            this.lbl__SoDienThoai.Size = new System.Drawing.Size(128, 20);
            this.lbl__SoDienThoai.TabIndex = 13;
            this.lbl__SoDienThoai.Text = "Số Điện thoại:";
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_QueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QueQuan.Location = new System.Drawing.Point(302, 186);
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(312, 27);
            this.txt_QueQuan.TabIndex = 6;
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgaySinh.Location = new System.Drawing.Point(302, 153);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(160, 27);
            this.date_NgaySinh.TabIndex = 5;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_GioiTinh.Location = new System.Drawing.Point(302, 119);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(160, 28);
            this.cbb_GioiTinh.TabIndex = 4;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(302, 86);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(312, 27);
            this.txt_HoTen.TabIndex = 3;
            // 
            // txt_SoCCCD
            // 
            this.txt_SoCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoCCCD.Location = new System.Drawing.Point(302, 52);
            this.txt_SoCCCD.Name = "txt_SoCCCD";
            this.txt_SoCCCD.Size = new System.Drawing.Size(312, 27);
            this.txt_SoCCCD.TabIndex = 2;
            this.txt_SoCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo);
            // 
            // txt_MaHS
            // 
            this.txt_MaHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHS.Location = new System.Drawing.Point(302, 19);
            this.txt_MaHS.Name = "txt_MaHS";
            this.txt_MaHS.Size = new System.Drawing.Size(312, 27);
            this.txt_MaHS.TabIndex = 1;
            // 
            // lbl_QueQuan
            // 
            this.lbl_QueQuan.AutoSize = true;
            this.lbl_QueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QueQuan.ForeColor = System.Drawing.Color.Black;
            this.lbl_QueQuan.Location = new System.Drawing.Point(166, 189);
            this.lbl_QueQuan.Name = "lbl_QueQuan";
            this.lbl_QueQuan.Size = new System.Drawing.Size(95, 20);
            this.lbl_QueQuan.TabIndex = 6;
            this.lbl_QueQuan.Text = "Quê quán:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(166, 156);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(98, 20);
            this.lbl_NgaySinh.TabIndex = 5;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lbl_GioiTinh.Location = new System.Drawing.Point(166, 123);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(86, 20);
            this.lbl_GioiTinh.TabIndex = 4;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.ForeColor = System.Drawing.Color.Black;
            this.lbl_HoTen.Location = new System.Drawing.Point(166, 89);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(96, 20);
            this.lbl_HoTen.TabIndex = 3;
            this.lbl_HoTen.Text = "Họ và tên:";
            // 
            // lbl_SOCCCD
            // 
            this.lbl_SOCCCD.AutoSize = true;
            this.lbl_SOCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SOCCCD.ForeColor = System.Drawing.Color.Black;
            this.lbl_SOCCCD.Location = new System.Drawing.Point(166, 55);
            this.lbl_SOCCCD.Name = "lbl_SOCCCD";
            this.lbl_SOCCCD.Size = new System.Drawing.Size(96, 20);
            this.lbl_SOCCCD.TabIndex = 2;
            this.lbl_SOCCCD.Text = "Số CCCD:";
            // 
            // lbl_MaHS
            // 
            this.lbl_MaHS.AutoSize = true;
            this.lbl_MaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHS.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaHS.Location = new System.Drawing.Point(166, 22);
            this.lbl_MaHS.Name = "lbl_MaHS";
            this.lbl_MaHS.Size = new System.Drawing.Size(121, 20);
            this.lbl_MaHS.TabIndex = 1;
            this.lbl_MaHS.Text = "Mã Học sinh:";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(1268, 194);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 71);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frm_QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 790);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLyHocSinh";
            this.Text = "frm_QuanLyHocSinh";
            this.Load += new System.EventHandler(this.frm_QuanLyHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHocSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gpb_DSHocSinh.ResumeLayout(false);
            this.gpb_DSHocSinh.PerformLayout();
            this.gpb_ThongTinHocSinh.ResumeLayout(false);
            this.gpb_ThongTinHocSinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_DanhSachHocSinh;
        private System.Windows.Forms.GroupBox gpb_ThongTinHocSinh;
        private System.Windows.Forms.Button btn_DiemHS;
        private System.Windows.Forms.Button btn_KhoiPhucHSDaXoa;
        private System.Windows.Forms.DateTimePicker date_NamNhapHoc;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Avatar;
        private System.Windows.Forms.ComboBox cbb_LopHoc;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_HuongDan;
        private System.Windows.Forms.Label lbl_NamNhapHoc;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl__SoDienThoai;
        private System.Windows.Forms.TextBox txt_QueQuan;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_SoCCCD;
        private System.Windows.Forms.TextBox txt_MaHS;
        private System.Windows.Forms.Label lbl_QueQuan;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_SOCCCD;
        private System.Windows.Forms.Label lbl_MaHS;
        private System.Windows.Forms.ComboBox cbb_NamHoc;
        private System.Windows.Forms.Label lbl_NamHoc;
        private System.Windows.Forms.GroupBox gpb_DSHocSinh;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_refesh;
        private System.Windows.Forms.ComboBox cbb_Khoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_TrangThaiChon;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private System.Windows.Forms.Label lbl_TrangThai;
    }
}