namespace GUI
{
    partial class frm_School
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_School));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DSKyThi = new System.Windows.Forms.Button();
            this.chk_ThemKythi = new System.Windows.Forms.CheckBox();
            this.date_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txt_MaKyThi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_NamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_themNamhoc = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.btn_HoanThanh = new System.Windows.Forms.Button();
            this.txt_TenKyThi = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NamHoc = new System.Windows.Forms.TextBox();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.btn_Clear);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_Xoa);
            this.panel3.Controls.Add(this.btn_TimKiem);
            this.panel3.Controls.Add(this.btn_Them);
            this.panel3.Controls.Add(this.btn_Sua);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btn_Refesh);
            this.panel3.Controls.Add(this.dgv_DanhSach);
            this.panel3.Controls.Add(this.btn_HoanThanh);
            this.panel3.Location = new System.Drawing.Point(1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 641);
            this.panel3.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.cbb_NamHoc);
            this.groupBox2.Controls.Add(this.txt_TenKyThi);
            this.groupBox2.Controls.Add(this.btn_DSKyThi);
            this.groupBox2.Controls.Add(this.chk_ThemKythi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.date_NgayKetThuc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.date_NgayBatDau);
            this.groupBox2.Controls.Add(this.txt_MaKyThi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(11, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 316);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KỲ THI";
            // 
            // btn_DSKyThi
            // 
            this.btn_DSKyThi.BackColor = System.Drawing.Color.DarkGray;
            this.btn_DSKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSKyThi.ForeColor = System.Drawing.Color.Black;
            this.btn_DSKyThi.Location = new System.Drawing.Point(177, 280);
            this.btn_DSKyThi.Name = "btn_DSKyThi";
            this.btn_DSKyThi.Size = new System.Drawing.Size(94, 28);
            this.btn_DSKyThi.TabIndex = 62;
            this.btn_DSKyThi.Text = "DS kỳ thi";
            this.btn_DSKyThi.UseVisualStyleBackColor = false;
            this.btn_DSKyThi.Click += new System.EventHandler(this.btn_DSKyThi_Click);
            // 
            // chk_ThemKythi
            // 
            this.chk_ThemKythi.AutoSize = true;
            this.chk_ThemKythi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ThemKythi.Location = new System.Drawing.Point(175, 27);
            this.chk_ThemKythi.Name = "chk_ThemKythi";
            this.chk_ThemKythi.Size = new System.Drawing.Size(18, 17);
            this.chk_ThemKythi.TabIndex = 65;
            this.chk_ThemKythi.UseVisualStyleBackColor = true;
            this.chk_ThemKythi.CheckedChanged += new System.EventHandler(this.chk_ThemKythi_CheckedChanged);
            // 
            // date_NgayKetThuc
            // 
            this.date_NgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.date_NgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayKetThuc.Location = new System.Drawing.Point(177, 247);
            this.date_NgayKetThuc.Name = "date_NgayKetThuc";
            this.date_NgayKetThuc.Size = new System.Drawing.Size(163, 27);
            this.date_NgayKetThuc.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Tên kỳ thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ngày bắt đầu:";
            // 
            // date_NgayBatDau
            // 
            this.date_NgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.date_NgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_NgayBatDau.Location = new System.Drawing.Point(177, 217);
            this.date_NgayBatDau.Name = "date_NgayBatDau";
            this.date_NgayBatDau.Size = new System.Drawing.Size(163, 27);
            this.date_NgayBatDau.TabIndex = 15;
            // 
            // txt_MaKyThi
            // 
            this.txt_MaKyThi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MaKyThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKyThi.Location = new System.Drawing.Point(175, 50);
            this.txt_MaKyThi.Name = "txt_MaKyThi";
            this.txt_MaKyThi.Size = new System.Drawing.Size(273, 27);
            this.txt_MaKyThi.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã kỳ thi:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(681, 54);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(98, 28);
            this.btn_Clear.TabIndex = 52;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(463, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 36);
            this.label5.TabIndex = 51;
            this.label5.Text = "QUẢN LÝ NĂM HỌC";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(357, 54);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 71);
            this.btn_Xoa.TabIndex = 49;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(243, 54);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(108, 71);
            this.btn_TimKiem.TabIndex = 48;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(15, 54);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 71);
            this.btn_Them.TabIndex = 46;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(129, 54);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 71);
            this.btn_Sua.TabIndex = 47;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cbb_TrangThai);
            this.groupBox1.Controls.Add(this.txt_NamHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chk_themNamhoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(11, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 159);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NĂM HỌC";
            // 
            // cbb_NamHoc
            // 
            this.cbb_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NamHoc.FormattingEnabled = true;
            this.cbb_NamHoc.Location = new System.Drawing.Point(175, 182);
            this.cbb_NamHoc.Name = "cbb_NamHoc";
            this.cbb_NamHoc.Size = new System.Drawing.Size(273, 28);
            this.cbb_NamHoc.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Trạng thái:";
            // 
            // chk_themNamhoc
            // 
            this.chk_themNamhoc.AutoSize = true;
            this.chk_themNamhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_themNamhoc.Location = new System.Drawing.Point(175, 46);
            this.chk_themNamhoc.Name = "chk_themNamhoc";
            this.chk_themNamhoc.Size = new System.Drawing.Size(18, 17);
            this.chk_themNamhoc.TabIndex = 64;
            this.chk_themNamhoc.UseVisualStyleBackColor = true;
            this.chk_themNamhoc.CheckedChanged += new System.EventHandler(this.chk_themNamhoc_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Năm học:";
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refesh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refesh.Location = new System.Drawing.Point(577, 54);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(98, 28);
            this.btn_Refesh.TabIndex = 53;
            this.btn_Refesh.Text = "Refesh";
            this.btn_Refesh.UseVisualStyleBackColor = false;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(471, 88);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.ReadOnly = true;
            this.dgv_DanhSach.RowHeadersWidth = 51;
            this.dgv_DanhSach.RowTemplate.Height = 24;
            this.dgv_DanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSach.Size = new System.Drawing.Size(755, 541);
            this.dgv_DanhSach.TabIndex = 10;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // btn_HoanThanh
            // 
            this.btn_HoanThanh.BackColor = System.Drawing.Color.DarkGray;
            this.btn_HoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoanThanh.ForeColor = System.Drawing.Color.Black;
            this.btn_HoanThanh.Location = new System.Drawing.Point(473, 54);
            this.btn_HoanThanh.Name = "btn_HoanThanh";
            this.btn_HoanThanh.Size = new System.Drawing.Size(98, 28);
            this.btn_HoanThanh.TabIndex = 50;
            this.btn_HoanThanh.Text = "Hoàn thành";
            this.btn_HoanThanh.UseVisualStyleBackColor = false;
            this.btn_HoanThanh.Click += new System.EventHandler(this.btn_HoanThanh_Click);
            // 
            // txt_TenKyThi
            // 
            this.txt_TenKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKyThi.Location = new System.Drawing.Point(175, 84);
            this.txt_TenKyThi.Name = "txt_TenKyThi";
            this.txt_TenKyThi.Size = new System.Drawing.Size(273, 92);
            this.txt_TenKyThi.TabIndex = 66;
            this.txt_TenKyThi.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Năm học:";
            // 
            // txt_NamHoc
            // 
            this.txt_NamHoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NamHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NamHoc.Location = new System.Drawing.Point(175, 72);
            this.txt_NamHoc.Name = "txt_NamHoc";
            this.txt_NamHoc.Size = new System.Drawing.Size(273, 27);
            this.txt_NamHoc.TabIndex = 68;
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Items.AddRange(new object[] {
            "1",
            "Hoàn thành",
            "Chưa hoàn thành"});
            this.cbb_TrangThai.Location = new System.Drawing.Point(175, 107);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(273, 28);
            this.cbb_TrangThai.TabIndex = 69;
            // 
            // frm_School
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 640);
            this.Controls.Add(this.panel3);
            this.Name = "frm_School";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_School";
            this.Load += new System.EventHandler(this.frm_School_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HoanThanh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_NgayBatDau;
        private System.Windows.Forms.TextBox txt_MaKyThi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chk_ThemKythi;
        private System.Windows.Forms.DateTimePicker date_NgayKetThuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chk_themNamhoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DSKyThi;
        private System.Windows.Forms.ComboBox cbb_NamHoc;
        private System.Windows.Forms.RichTextBox txt_TenKyThi;
        private System.Windows.Forms.TextBox txt_NamHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
    }
}