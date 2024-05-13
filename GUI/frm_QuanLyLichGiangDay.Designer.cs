namespace GUI
{
    partial class frm_QuanLyLichGiangDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyLichGiangDay));
            this.panel_LichGiangDay = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.gpb_DSLichGiangDay = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_TrangThai_ChonLoc = new System.Windows.Forms.ComboBox();
            this.dgv_DSLichGiangDay = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_TaoLich = new System.Windows.Forms.Button();
            this.gpb_LichGiangDay = new System.Windows.Forms.GroupBox();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_MaLich = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_refesh = new System.Windows.Forms.Button();
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.nud_TietKetThu = new System.Windows.Forms.NumericUpDown();
            this.nud_TietBatDau = new System.Windows.Forms.NumericUpDown();
            this.date_NgayBatBau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Thu = new System.Windows.Forms.ComboBox();
            this.date_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_GiaoVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Buoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_Lop = new System.Windows.Forms.ComboBox();
            this.cbb_Mon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_LichGiangDay.SuspendLayout();
            this.gpb_DSLichGiangDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLichGiangDay)).BeginInit();
            this.gpb_LichGiangDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TietKetThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TietBatDau)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_LichGiangDay
            // 
            this.panel_LichGiangDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_LichGiangDay.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_LichGiangDay.Controls.Add(this.btn_Thoat);
            this.panel_LichGiangDay.Controls.Add(this.gpb_DSLichGiangDay);
            this.panel_LichGiangDay.Controls.Add(this.btn_TimKiem);
            this.panel_LichGiangDay.Controls.Add(this.btn_Sua);
            this.panel_LichGiangDay.Controls.Add(this.btn_Xoa);
            this.panel_LichGiangDay.Controls.Add(this.btn_TaoLich);
            this.panel_LichGiangDay.Controls.Add(this.gpb_LichGiangDay);
            this.panel_LichGiangDay.Location = new System.Drawing.Point(-2, -37);
            this.panel_LichGiangDay.Name = "panel_LichGiangDay";
            this.panel_LichGiangDay.Size = new System.Drawing.Size(1249, 865);
            this.panel_LichGiangDay.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Red;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(1110, 793);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(119, 27);
            this.btn_Thoat.TabIndex = 68;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // gpb_DSLichGiangDay
            // 
            this.gpb_DSLichGiangDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpb_DSLichGiangDay.BackColor = System.Drawing.Color.White;
            this.gpb_DSLichGiangDay.Controls.Add(this.label11);
            this.gpb_DSLichGiangDay.Controls.Add(this.cbb_TrangThai_ChonLoc);
            this.gpb_DSLichGiangDay.Controls.Add(this.dgv_DSLichGiangDay);
            this.gpb_DSLichGiangDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_DSLichGiangDay.Location = new System.Drawing.Point(19, 304);
            this.gpb_DSLichGiangDay.Name = "gpb_DSLichGiangDay";
            this.gpb_DSLichGiangDay.Size = new System.Drawing.Size(1210, 483);
            this.gpb_DSLichGiangDay.TabIndex = 0;
            this.gpb_DSLichGiangDay.TabStop = false;
            this.gpb_DSLichGiangDay.Text = "Danh sách lịch giảng dạy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(938, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Lọc:";
            // 
            // cbb_TrangThai_ChonLoc
            // 
            this.cbb_TrangThai_ChonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThai_ChonLoc.FormattingEnabled = true;
            this.cbb_TrangThai_ChonLoc.Items.AddRange(new object[] {
            "1",
            "Đã hoàn thành"});
            this.cbb_TrangThai_ChonLoc.Location = new System.Drawing.Point(981, 13);
            this.cbb_TrangThai_ChonLoc.Name = "cbb_TrangThai_ChonLoc";
            this.cbb_TrangThai_ChonLoc.Size = new System.Drawing.Size(223, 26);
            this.cbb_TrangThai_ChonLoc.TabIndex = 18;
            this.cbb_TrangThai_ChonLoc.SelectedIndexChanged += new System.EventHandler(this.cbb_TrangThai_ChonLoc_SelectedIndexChanged);
            // 
            // dgv_DSLichGiangDay
            // 
            this.dgv_DSLichGiangDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DSLichGiangDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSLichGiangDay.Location = new System.Drawing.Point(6, 45);
            this.dgv_DSLichGiangDay.Name = "dgv_DSLichGiangDay";
            this.dgv_DSLichGiangDay.ReadOnly = true;
            this.dgv_DSLichGiangDay.RowHeadersWidth = 51;
            this.dgv_DSLichGiangDay.RowTemplate.Height = 24;
            this.dgv_DSLichGiangDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSLichGiangDay.Size = new System.Drawing.Size(1198, 433);
            this.dgv_DSLichGiangDay.TabIndex = 16;
            this.dgv_DSLichGiangDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSLichGiangDay_CellClick);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(1109, 142);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(126, 69);
            this.btn_TimKiem.TabIndex = 12;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(977, 218);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(126, 69);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(1109, 218);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 69);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_TaoLich
            // 
            this.btn_TaoLich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TaoLich.BackColor = System.Drawing.Color.White;
            this.btn_TaoLich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TaoLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoLich.ForeColor = System.Drawing.Color.Black;
            this.btn_TaoLich.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaoLich.Image")));
            this.btn_TaoLich.Location = new System.Drawing.Point(977, 142);
            this.btn_TaoLich.Name = "btn_TaoLich";
            this.btn_TaoLich.Size = new System.Drawing.Size(126, 69);
            this.btn_TaoLich.TabIndex = 11;
            this.btn_TaoLich.UseVisualStyleBackColor = false;
            this.btn_TaoLich.Click += new System.EventHandler(this.btn_TaoLich_Click);
            // 
            // gpb_LichGiangDay
            // 
            this.gpb_LichGiangDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpb_LichGiangDay.BackColor = System.Drawing.Color.Gainsboro;
            this.gpb_LichGiangDay.Controls.Add(this.cbb_TrangThai);
            this.gpb_LichGiangDay.Controls.Add(this.txt_MaLich);
            this.gpb_LichGiangDay.Controls.Add(this.label6);
            this.gpb_LichGiangDay.Controls.Add(this.btn_refesh);
            this.gpb_LichGiangDay.Controls.Add(this.btn_HoanThanh);
            this.gpb_LichGiangDay.Controls.Add(this.btn_Clear);
            this.gpb_LichGiangDay.Controls.Add(this.nud_TietKetThu);
            this.gpb_LichGiangDay.Controls.Add(this.nud_TietBatDau);
            this.gpb_LichGiangDay.Controls.Add(this.date_NgayBatBau);
            this.gpb_LichGiangDay.Controls.Add(this.label1);
            this.gpb_LichGiangDay.Controls.Add(this.label5);
            this.gpb_LichGiangDay.Controls.Add(this.cbb_Thu);
            this.gpb_LichGiangDay.Controls.Add(this.date_NgayKetThuc);
            this.gpb_LichGiangDay.Controls.Add(this.label4);
            this.gpb_LichGiangDay.Controls.Add(this.label12);
            this.gpb_LichGiangDay.Controls.Add(this.label8);
            this.gpb_LichGiangDay.Controls.Add(this.cbb_GiaoVien);
            this.gpb_LichGiangDay.Controls.Add(this.label3);
            this.gpb_LichGiangDay.Controls.Add(this.cbb_Buoi);
            this.gpb_LichGiangDay.Controls.Add(this.label2);
            this.gpb_LichGiangDay.Controls.Add(this.cbb_Lop);
            this.gpb_LichGiangDay.Controls.Add(this.cbb_Mon);
            this.gpb_LichGiangDay.Controls.Add(this.label7);
            this.gpb_LichGiangDay.Controls.Add(this.label9);
            this.gpb_LichGiangDay.Controls.Add(this.label10);
            this.gpb_LichGiangDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_LichGiangDay.ForeColor = System.Drawing.Color.Red;
            this.gpb_LichGiangDay.Location = new System.Drawing.Point(19, 49);
            this.gpb_LichGiangDay.Name = "gpb_LichGiangDay";
            this.gpb_LichGiangDay.Size = new System.Drawing.Size(946, 238);
            this.gpb_LichGiangDay.TabIndex = 0;
            this.gpb_LichGiangDay.TabStop = false;
            this.gpb_LichGiangDay.Text = "Lịch giảng dạy";
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Items.AddRange(new object[] {
            "1",
            "Đã hoàn thành"});
            this.cbb_TrangThai.Location = new System.Drawing.Point(601, 128);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(311, 28);
            this.cbb_TrangThai.TabIndex = 69;
            // 
            // txt_MaLich
            // 
            this.txt_MaLich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLich.Location = new System.Drawing.Point(142, 26);
            this.txt_MaLich.Name = "txt_MaLich";
            this.txt_MaLich.Size = new System.Drawing.Size(224, 27);
            this.txt_MaLich.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(30, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Mã lịch:";
            // 
            // btn_refesh
            // 
            this.btn_refesh.BackColor = System.Drawing.Color.DimGray;
            this.btn_refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refesh.ForeColor = System.Drawing.Color.Transparent;
            this.btn_refesh.Location = new System.Drawing.Point(811, 199);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(129, 33);
            this.btn_refesh.TabIndex = 66;
            this.btn_refesh.Text = "Refesh";
            this.btn_refesh.UseVisualStyleBackColor = false;
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.Color.DimGray;
            this.btn_HoanThanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanThanh.ForeColor = System.Drawing.Color.Transparent;
            this.btn_HoanThanh.Location = new System.Drawing.Point(541, 199);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(129, 33);
            this.btn_HoanThanh.TabIndex = 63;
            this.btn_HoanThanh.Text = "Hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DimGray;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Clear.Location = new System.Drawing.Point(676, 199);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 33);
            this.btn_Clear.TabIndex = 64;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // nud_TietKetThu
            // 
            this.nud_TietKetThu.Location = new System.Drawing.Point(710, 96);
            this.nud_TietKetThu.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_TietKetThu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_TietKetThu.Name = "nud_TietKetThu";
            this.nud_TietKetThu.Size = new System.Drawing.Size(56, 27);
            this.nud_TietKetThu.TabIndex = 7;
            this.nud_TietKetThu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_TietBatDau
            // 
            this.nud_TietBatDau.Location = new System.Drawing.Point(601, 96);
            this.nud_TietBatDau.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_TietBatDau.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_TietBatDau.Name = "nud_TietBatDau";
            this.nud_TietBatDau.Size = new System.Drawing.Size(52, 27);
            this.nud_TietBatDau.TabIndex = 6;
            this.nud_TietBatDau.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // date_NgayBatBau
            // 
            this.date_NgayBatBau.CustomFormat = "dd/MM/yyyy";
            this.date_NgayBatBau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayBatBau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayBatBau.Location = new System.Drawing.Point(603, 61);
            this.date_NgayBatBau.Name = "date_NgayBatBau";
            this.date_NgayBatBau.Size = new System.Drawing.Size(129, 27);
            this.date_NgayBatBau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(738, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(659, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "đến:";
            // 
            // cbb_Thu
            // 
            this.cbb_Thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Thu.FormattingEnabled = true;
            this.cbb_Thu.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ nhật",
            ""});
            this.cbb_Thu.Location = new System.Drawing.Point(142, 161);
            this.cbb_Thu.Name = "cbb_Thu";
            this.cbb_Thu.Size = new System.Drawing.Size(224, 28);
            this.cbb_Thu.TabIndex = 1;
            // 
            // date_NgayKetThuc
            // 
            this.date_NgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.date_NgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayKetThuc.Location = new System.Drawing.Point(783, 60);
            this.date_NgayKetThuc.Name = "date_NgayKetThuc";
            this.date_NgayKetThuc.Size = new System.Drawing.Size(129, 27);
            this.date_NgayKetThuc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(490, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ tiết:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Thứ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(490, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Từ ngày:";
            // 
            // cbb_GiaoVien
            // 
            this.cbb_GiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GiaoVien.FormattingEnabled = true;
            this.cbb_GiaoVien.Location = new System.Drawing.Point(141, 93);
            this.cbb_GiaoVien.Name = "cbb_GiaoVien";
            this.cbb_GiaoVien.Size = new System.Drawing.Size(330, 28);
            this.cbb_GiaoVien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giáo viên:";
            // 
            // cbb_Buoi
            // 
            this.cbb_Buoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Buoi.FormattingEnabled = true;
            this.cbb_Buoi.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbb_Buoi.Location = new System.Drawing.Point(601, 26);
            this.cbb_Buoi.Name = "cbb_Buoi";
            this.cbb_Buoi.Size = new System.Drawing.Size(311, 28);
            this.cbb_Buoi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(490, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buổi:";
            // 
            // cbb_Lop
            // 
            this.cbb_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Lop.FormattingEnabled = true;
            this.cbb_Lop.Location = new System.Drawing.Point(141, 127);
            this.cbb_Lop.Name = "cbb_Lop";
            this.cbb_Lop.Size = new System.Drawing.Size(223, 28);
            this.cbb_Lop.TabIndex = 8;
            // 
            // cbb_Mon
            // 
            this.cbb_Mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Mon.FormattingEnabled = true;
            this.cbb_Mon.Location = new System.Drawing.Point(141, 59);
            this.cbb_Mon.Name = "cbb_Mon";
            this.cbb_Mon.Size = new System.Drawing.Size(330, 28);
            this.cbb_Mon.TabIndex = 4;
            this.cbb_Mon.SelectedIndexChanged += new System.EventHandler(this.cbb_Mon_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(490, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lớp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(30, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Môn:";
            // 
            // frm_QuanLyLichGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 790);
            this.Controls.Add(this.panel_LichGiangDay);
            this.Name = "frm_QuanLyLichGiangDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch giảng dạy";
            this.Load += new System.EventHandler(this.frm_QuanLyLichGiangDay_Load);
            this.panel_LichGiangDay.ResumeLayout(false);
            this.gpb_DSLichGiangDay.ResumeLayout(false);
            this.gpb_DSLichGiangDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSLichGiangDay)).EndInit();
            this.gpb_LichGiangDay.ResumeLayout(false);
            this.gpb_LichGiangDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TietKetThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TietBatDau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_LichGiangDay;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_TaoLich;
        private System.Windows.Forms.DataGridView dgv_DSLichGiangDay;
        private System.Windows.Forms.GroupBox gpb_LichGiangDay;
        private System.Windows.Forms.DateTimePicker date_NgayBatBau;
        private System.Windows.Forms.ComboBox cbb_Lop;
        private System.Windows.Forms.ComboBox cbb_Mon;
        private System.Windows.Forms.ComboBox cbb_Thu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbb_Buoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_NgayKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_GiaoVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_TietKetThu;
        private System.Windows.Forms.NumericUpDown nud_TietBatDau;
        private System.Windows.Forms.GroupBox gpb_DSLichGiangDay;
        private System.Windows.Forms.Button btn_refesh;
        private System.Windows.Forms.Button btn_HoanThanh;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_MaLich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_TrangThai_ChonLoc;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private System.Windows.Forms.Label label11;
    }
}