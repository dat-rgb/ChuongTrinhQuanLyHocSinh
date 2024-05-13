namespace GUI
{
    partial class frm_QuanLyDiemHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyDiemHocSinh));
            this.panel_QuanLyDiemHocSinh = new System.Windows.Forms.Panel();
            this.dgv_QuanLyDanhSachDiemHS = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.gpb_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.cbb_LopHoc = new System.Windows.Forms.ComboBox();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.btn_XemDiemTB = new System.Windows.Forms.Button();
            this.txt_DiemThi = new System.Windows.Forms.TextBox();
            this.txt_DiemKT2 = new System.Windows.Forms.TextBox();
            this.txt_DiemKT1 = new System.Windows.Forms.TextBox();
            this.txt_DiemTX = new System.Windows.Forms.TextBox();
            this.cbb_NamHoc = new System.Windows.Forms.ComboBox();
            this.lbl_NamHoc = new System.Windows.Forms.Label();
            this.cbb_HocKy = new System.Windows.Forms.ComboBox();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_HocKy = new System.Windows.Forms.Label();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.txt_DiemTB = new System.Windows.Forms.TextBox();
            this.lbl_DiemTBMon = new System.Windows.Forms.Label();
            this.lbl_DiemThi = new System.Windows.Forms.Label();
            this.lbl_DiemKT2 = new System.Windows.Forms.Label();
            this.lbl_DiemKT1 = new System.Windows.Forms.Label();
            this.tbt_DiemTX = new System.Windows.Forms.Label();
            this.txt_MaHS = new System.Windows.Forms.TextBox();
            this.lbl_MonHoc = new System.Windows.Forms.Label();
            this.lbl_MaHS = new System.Windows.Forms.Label();
            this.panel_QuanLyDiemHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyDanhSachDiemHS)).BeginInit();
            this.gpb_ThongTinHocSinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_QuanLyDiemHocSinh
            // 
            this.panel_QuanLyDiemHocSinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_QuanLyDiemHocSinh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_QuanLyDiemHocSinh.Controls.Add(this.dgv_QuanLyDanhSachDiemHS);
            this.panel_QuanLyDiemHocSinh.Controls.Add(this.btn_TimKiem);
            this.panel_QuanLyDiemHocSinh.Controls.Add(this.btn_Sua);
            this.panel_QuanLyDiemHocSinh.Controls.Add(this.btn_Xoa);
            this.panel_QuanLyDiemHocSinh.Controls.Add(this.btn_Them);
            this.panel_QuanLyDiemHocSinh.Controls.Add(this.gpb_ThongTinHocSinh);
            this.panel_QuanLyDiemHocSinh.Location = new System.Drawing.Point(-3, -4);
            this.panel_QuanLyDiemHocSinh.Name = "panel_QuanLyDiemHocSinh";
            this.panel_QuanLyDiemHocSinh.Size = new System.Drawing.Size(1524, 798);
            this.panel_QuanLyDiemHocSinh.TabIndex = 5;
            // 
            // dgv_QuanLyDanhSachDiemHS
            // 
            this.dgv_QuanLyDanhSachDiemHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuanLyDanhSachDiemHS.Location = new System.Drawing.Point(15, 288);
            this.dgv_QuanLyDanhSachDiemHS.Name = "dgv_QuanLyDanhSachDiemHS";
            this.dgv_QuanLyDanhSachDiemHS.ReadOnly = true;
            this.dgv_QuanLyDanhSachDiemHS.RowHeadersWidth = 51;
            this.dgv_QuanLyDanhSachDiemHS.RowTemplate.Height = 24;
            this.dgv_QuanLyDanhSachDiemHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QuanLyDanhSachDiemHS.Size = new System.Drawing.Size(1498, 494);
            this.dgv_QuanLyDanhSachDiemHS.TabIndex = 0;
            this.dgv_QuanLyDanhSachDiemHS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuanLyDanhSachDiemHS_CellClick);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search_48;
            this.btn_TimKiem.Location = new System.Drawing.Point(1065, 110);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 71);
            this.btn_TimKiem.TabIndex = 20;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(940, 110);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 71);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(1065, 187);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 71);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(940, 187);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 71);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // gpb_ThongTinHocSinh
            // 
            this.gpb_ThongTinHocSinh.BackColor = System.Drawing.Color.Gainsboro;
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_LopHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_Lop);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_XemDiemTB);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_DiemThi);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_DiemKT2);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_DiemKT1);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_DiemTX);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_NamHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_NamHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_HocKy);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_KhoiPhuc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_Clear);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_HocKy);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_Refesh);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_MonHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_DiemTB);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_DiemTBMon);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_DiemThi);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_DiemKT2);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_DiemKT1);
            this.gpb_ThongTinHocSinh.Controls.Add(this.tbt_DiemTX);
            this.gpb_ThongTinHocSinh.Controls.Add(this.txt_MaHS);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_MonHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.lbl_MaHS);
            this.gpb_ThongTinHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ThongTinHocSinh.ForeColor = System.Drawing.Color.Red;
            this.gpb_ThongTinHocSinh.Location = new System.Drawing.Point(15, 16);
            this.gpb_ThongTinHocSinh.Name = "gpb_ThongTinHocSinh";
            this.gpb_ThongTinHocSinh.Size = new System.Drawing.Size(918, 242);
            this.gpb_ThongTinHocSinh.TabIndex = 17;
            this.gpb_ThongTinHocSinh.TabStop = false;
            this.gpb_ThongTinHocSinh.Text = "Thông tin Điểm Học sinh";
            // 
            // cbb_LopHoc
            // 
            this.cbb_LopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LopHoc.FormattingEnabled = true;
            this.cbb_LopHoc.Location = new System.Drawing.Point(150, 158);
            this.cbb_LopHoc.Name = "cbb_LopHoc";
            this.cbb_LopHoc.Size = new System.Drawing.Size(366, 28);
            this.cbb_LopHoc.TabIndex = 68;
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lop.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lop.Location = new System.Drawing.Point(16, 155);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(46, 20);
            this.lbl_Lop.TabIndex = 67;
            this.lbl_Lop.Text = "Lớp:";
            // 
            // btn_XemDiemTB
            // 
            this.btn_XemDiemTB.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_XemDiemTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_XemDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDiemTB.ForeColor = System.Drawing.Color.Black;
            this.btn_XemDiemTB.Location = new System.Drawing.Point(660, 203);
            this.btn_XemDiemTB.Name = "btn_XemDiemTB";
            this.btn_XemDiemTB.Size = new System.Drawing.Size(200, 33);
            this.btn_XemDiemTB.TabIndex = 66;
            this.btn_XemDiemTB.Text = "Điểm TB\r\n";
            this.btn_XemDiemTB.UseVisualStyleBackColor = false;
            this.btn_XemDiemTB.Click += new System.EventHandler(this.btn_XemDiemTB_Click);
            // 
            // txt_DiemThi
            // 
            this.txt_DiemThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiemThi.ForeColor = System.Drawing.Color.Red;
            this.txt_DiemThi.Location = new System.Drawing.Point(660, 127);
            this.txt_DiemThi.Name = "txt_DiemThi";
            this.txt_DiemThi.Size = new System.Drawing.Size(200, 27);
            this.txt_DiemThi.TabIndex = 65;
            this.txt_DiemThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DiemKT2
            // 
            this.txt_DiemKT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiemKT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiemKT2.ForeColor = System.Drawing.Color.Red;
            this.txt_DiemKT2.Location = new System.Drawing.Point(660, 95);
            this.txt_DiemKT2.Name = "txt_DiemKT2";
            this.txt_DiemKT2.Size = new System.Drawing.Size(200, 27);
            this.txt_DiemKT2.TabIndex = 64;
            this.txt_DiemKT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DiemKT1
            // 
            this.txt_DiemKT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiemKT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiemKT1.ForeColor = System.Drawing.Color.Red;
            this.txt_DiemKT1.Location = new System.Drawing.Point(660, 63);
            this.txt_DiemKT1.Name = "txt_DiemKT1";
            this.txt_DiemKT1.Size = new System.Drawing.Size(200, 27);
            this.txt_DiemKT1.TabIndex = 63;
            this.txt_DiemKT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DiemTX
            // 
            this.txt_DiemTX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiemTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiemTX.ForeColor = System.Drawing.Color.Red;
            this.txt_DiemTX.Location = new System.Drawing.Point(660, 31);
            this.txt_DiemTX.Name = "txt_DiemTX";
            this.txt_DiemTX.Size = new System.Drawing.Size(200, 27);
            this.txt_DiemTX.TabIndex = 62;
            this.txt_DiemTX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbb_NamHoc
            // 
            this.cbb_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NamHoc.FormattingEnabled = true;
            this.cbb_NamHoc.Location = new System.Drawing.Point(150, 92);
            this.cbb_NamHoc.Name = "cbb_NamHoc";
            this.cbb_NamHoc.Size = new System.Drawing.Size(366, 28);
            this.cbb_NamHoc.TabIndex = 60;
            // 
            // lbl_NamHoc
            // 
            this.lbl_NamHoc.AutoSize = true;
            this.lbl_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NamHoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_NamHoc.Location = new System.Drawing.Point(16, 95);
            this.lbl_NamHoc.Name = "lbl_NamHoc";
            this.lbl_NamHoc.Size = new System.Drawing.Size(89, 20);
            this.lbl_NamHoc.TabIndex = 59;
            this.lbl_NamHoc.Text = "Năm học:";
            // 
            // cbb_HocKy
            // 
            this.cbb_HocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_HocKy.FormattingEnabled = true;
            this.cbb_HocKy.Location = new System.Drawing.Point(150, 124);
            this.cbb_HocKy.Name = "cbb_HocKy";
            this.cbb_HocKy.Size = new System.Drawing.Size(366, 28);
            this.cbb_HocKy.TabIndex = 58;
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.DarkGray;
            this.btn_KhoiPhuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.Black;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(363, 203);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(93, 33);
            this.btn_KhoiPhuc.TabIndex = 41;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(561, 203);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 33);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // lbl_HocKy
            // 
            this.lbl_HocKy.AutoSize = true;
            this.lbl_HocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HocKy.ForeColor = System.Drawing.Color.Black;
            this.lbl_HocKy.Location = new System.Drawing.Point(16, 127);
            this.lbl_HocKy.Name = "lbl_HocKy";
            this.lbl_HocKy.Size = new System.Drawing.Size(76, 20);
            this.lbl_HocKy.TabIndex = 57;
            this.lbl_HocKy.Text = "Học Kỳ:";
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refesh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refesh.Location = new System.Drawing.Point(462, 203);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(93, 33);
            this.btn_Refesh.TabIndex = 39;
            this.btn_Refesh.Text = "Refesh";
            this.btn_Refesh.UseVisualStyleBackColor = false;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(150, 60);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(366, 28);
            this.cbb_MonHoc.TabIndex = 56;
            // 
            // txt_DiemTB
            // 
            this.txt_DiemTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiemTB.ForeColor = System.Drawing.Color.Red;
            this.txt_DiemTB.Location = new System.Drawing.Point(660, 159);
            this.txt_DiemTB.Name = "txt_DiemTB";
            this.txt_DiemTB.Size = new System.Drawing.Size(200, 27);
            this.txt_DiemTB.TabIndex = 49;
            this.txt_DiemTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_DiemTBMon
            // 
            this.lbl_DiemTBMon.AutoSize = true;
            this.lbl_DiemTBMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiemTBMon.ForeColor = System.Drawing.Color.Black;
            this.lbl_DiemTBMon.Location = new System.Drawing.Point(546, 162);
            this.lbl_DiemTBMon.Name = "lbl_DiemTBMon";
            this.lbl_DiemTBMon.Size = new System.Drawing.Size(80, 20);
            this.lbl_DiemTBMon.TabIndex = 44;
            this.lbl_DiemTBMon.Text = "TB môn:";
            // 
            // lbl_DiemThi
            // 
            this.lbl_DiemThi.AutoSize = true;
            this.lbl_DiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiemThi.ForeColor = System.Drawing.Color.Black;
            this.lbl_DiemThi.Location = new System.Drawing.Point(539, 130);
            this.lbl_DiemThi.Name = "lbl_DiemThi";
            this.lbl_DiemThi.Size = new System.Drawing.Size(90, 20);
            this.lbl_DiemThi.TabIndex = 43;
            this.lbl_DiemThi.Text = "Điểm Thi:";
            // 
            // lbl_DiemKT2
            // 
            this.lbl_DiemKT2.AutoSize = true;
            this.lbl_DiemKT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiemKT2.ForeColor = System.Drawing.Color.Black;
            this.lbl_DiemKT2.Location = new System.Drawing.Point(539, 98);
            this.lbl_DiemKT2.Name = "lbl_DiemKT2";
            this.lbl_DiemKT2.Size = new System.Drawing.Size(103, 20);
            this.lbl_DiemKT2.TabIndex = 42;
            this.lbl_DiemKT2.Text = "Điểm KT 2:";
            // 
            // lbl_DiemKT1
            // 
            this.lbl_DiemKT1.AutoSize = true;
            this.lbl_DiemKT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiemKT1.ForeColor = System.Drawing.Color.Black;
            this.lbl_DiemKT1.Location = new System.Drawing.Point(539, 66);
            this.lbl_DiemKT1.Name = "lbl_DiemKT1";
            this.lbl_DiemKT1.Size = new System.Drawing.Size(103, 20);
            this.lbl_DiemKT1.TabIndex = 14;
            this.lbl_DiemKT1.Text = "Điểm KT 1:";
            // 
            // tbt_DiemTX
            // 
            this.tbt_DiemTX.AutoSize = true;
            this.tbt_DiemTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbt_DiemTX.ForeColor = System.Drawing.Color.Black;
            this.tbt_DiemTX.Location = new System.Drawing.Point(539, 34);
            this.tbt_DiemTX.Name = "tbt_DiemTX";
            this.tbt_DiemTX.Size = new System.Drawing.Size(87, 20);
            this.tbt_DiemTX.TabIndex = 13;
            this.tbt_DiemTX.Text = "Điểm TX:";
            // 
            // txt_MaHS
            // 
            this.txt_MaHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHS.Location = new System.Drawing.Point(150, 29);
            this.txt_MaHS.Name = "txt_MaHS";
            this.txt_MaHS.Size = new System.Drawing.Size(366, 27);
            this.txt_MaHS.TabIndex = 7;
            // 
            // lbl_MonHoc
            // 
            this.lbl_MonHoc.AutoSize = true;
            this.lbl_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MonHoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_MonHoc.Location = new System.Drawing.Point(16, 63);
            this.lbl_MonHoc.Name = "lbl_MonHoc";
            this.lbl_MonHoc.Size = new System.Drawing.Size(86, 20);
            this.lbl_MonHoc.TabIndex = 6;
            this.lbl_MonHoc.Text = "Môn học:";
            // 
            // lbl_MaHS
            // 
            this.lbl_MaHS.AutoSize = true;
            this.lbl_MaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHS.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaHS.Location = new System.Drawing.Point(16, 31);
            this.lbl_MaHS.Name = "lbl_MaHS";
            this.lbl_MaHS.Size = new System.Drawing.Size(121, 20);
            this.lbl_MaHS.TabIndex = 1;
            this.lbl_MaHS.Text = "Mã Học sinh:";
            // 
            // frm_QuanLyDiemHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 790);
            this.Controls.Add(this.panel_QuanLyDiemHocSinh);
            this.Name = "frm_QuanLyDiemHocSinh";
            this.Text = "Quản lý điểm học sinh";
            this.Load += new System.EventHandler(this.frm_QuanLyDiemHocSinh_Load);
            this.panel_QuanLyDiemHocSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyDanhSachDiemHS)).EndInit();
            this.gpb_ThongTinHocSinh.ResumeLayout(false);
            this.gpb_ThongTinHocSinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_QuanLyDiemHocSinh;
        private System.Windows.Forms.GroupBox gpb_ThongTinHocSinh;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_DiemKT1;
        private System.Windows.Forms.Label tbt_DiemTX;
        private System.Windows.Forms.TextBox txt_MaHS;
        private System.Windows.Forms.Label lbl_MaHS;
        private System.Windows.Forms.TextBox txt_DiemTB;
        private System.Windows.Forms.Label lbl_DiemTBMon;
        private System.Windows.Forms.Label lbl_DiemThi;
        private System.Windows.Forms.Label lbl_DiemKT2;
        private System.Windows.Forms.Label lbl_MonHoc;
        private System.Windows.Forms.DataGridView dgv_QuanLyDanhSachDiemHS;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.ComboBox cbb_HocKy;
        private System.Windows.Forms.Label lbl_HocKy;
        private System.Windows.Forms.ComboBox cbb_NamHoc;
        private System.Windows.Forms.Label lbl_NamHoc;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_DiemThi;
        private System.Windows.Forms.TextBox txt_DiemKT2;
        private System.Windows.Forms.TextBox txt_DiemKT1;
        private System.Windows.Forms.TextBox txt_DiemTX;
        private System.Windows.Forms.Button btn_XemDiemTB;
        private System.Windows.Forms.ComboBox cbb_LopHoc;
        private System.Windows.Forms.Label lbl_Lop;
    }
}