namespace GUI
{
    partial class frm_QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLy));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_ThuChi = new System.Windows.Forms.Button();
            this.btn_PhongHoc = new System.Windows.Forms.Button();
            this.btn_MonHoc = new System.Windows.Forms.Button();
            this.btn_LopHoc = new System.Windows.Forms.Button();
            this.btn_GiaoVien = new System.Windows.Forms.Button();
            this.btn_HocSinh = new System.Windows.Forms.Button();
            this.panel_ChucNang = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_School = new System.Windows.Forms.Button();
            this.btn_LichThi = new System.Windows.Forms.Button();
            this.btn_LichGiangDay = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_ThoiKhoaBieu = new System.Windows.Forms.Button();
            this.panel_Navbar = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Menu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_Menu.Controls.Add(this.btn_ThuChi);
            this.panel_Menu.Controls.Add(this.btn_PhongHoc);
            this.panel_Menu.Controls.Add(this.btn_MonHoc);
            this.panel_Menu.Controls.Add(this.btn_LopHoc);
            this.panel_Menu.Controls.Add(this.btn_GiaoVien);
            this.panel_Menu.Controls.Add(this.btn_HocSinh);
            this.panel_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Menu.Location = new System.Drawing.Point(289, 43);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(957, 605);
            this.panel_Menu.TabIndex = 8;
            // 
            // btn_ThuChi
            // 
            this.btn_ThuChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThuChi.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThuChi.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThuChi.Image")));
            this.btn_ThuChi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ThuChi.Location = new System.Drawing.Point(638, 203);
            this.btn_ThuChi.Name = "btn_ThuChi";
            this.btn_ThuChi.Size = new System.Drawing.Size(217, 120);
            this.btn_ThuChi.TabIndex = 10;
            this.btn_ThuChi.Text = "Thu chi";
            this.btn_ThuChi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ThuChi.UseVisualStyleBackColor = false;
            // 
            // btn_PhongHoc
            // 
            this.btn_PhongHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PhongHoc.BackColor = System.Drawing.Color.Transparent;
            this.btn_PhongHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhongHoc.Image = global::GUI.Properties.Resources.phongHoc_72;
            this.btn_PhongHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_PhongHoc.Location = new System.Drawing.Point(395, 203);
            this.btn_PhongHoc.Name = "btn_PhongHoc";
            this.btn_PhongHoc.Size = new System.Drawing.Size(217, 120);
            this.btn_PhongHoc.TabIndex = 9;
            this.btn_PhongHoc.Text = "Phòng học";
            this.btn_PhongHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_PhongHoc.UseVisualStyleBackColor = false;
            this.btn_PhongHoc.Click += new System.EventHandler(this.btn_PhongHoc_Click);
            // 
            // btn_MonHoc
            // 
            this.btn_MonHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MonHoc.BackColor = System.Drawing.Color.Transparent;
            this.btn_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MonHoc.Image = global::GUI.Properties.Resources.subject_72;
            this.btn_MonHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_MonHoc.Location = new System.Drawing.Point(156, 203);
            this.btn_MonHoc.Name = "btn_MonHoc";
            this.btn_MonHoc.Size = new System.Drawing.Size(217, 120);
            this.btn_MonHoc.TabIndex = 8;
            this.btn_MonHoc.Text = "Môn học";
            this.btn_MonHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_MonHoc.UseVisualStyleBackColor = false;
            this.btn_MonHoc.Click += new System.EventHandler(this.btn_MonHoc_Click);
            // 
            // btn_LopHoc
            // 
            this.btn_LopHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LopHoc.BackColor = System.Drawing.Color.Transparent;
            this.btn_LopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LopHoc.Image = global::GUI.Properties.Resources.Classroom_72;
            this.btn_LopHoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_LopHoc.Location = new System.Drawing.Point(638, 63);
            this.btn_LopHoc.Name = "btn_LopHoc";
            this.btn_LopHoc.Size = new System.Drawing.Size(217, 120);
            this.btn_LopHoc.TabIndex = 7;
            this.btn_LopHoc.Text = "Lớp học";
            this.btn_LopHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_LopHoc.UseVisualStyleBackColor = false;
            this.btn_LopHoc.Click += new System.EventHandler(this.btn_LopHoc_Click);
            // 
            // btn_GiaoVien
            // 
            this.btn_GiaoVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.btn_GiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiaoVien.Image = global::GUI.Properties.Resources.teacher_72;
            this.btn_GiaoVien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_GiaoVien.Location = new System.Drawing.Point(395, 63);
            this.btn_GiaoVien.Name = "btn_GiaoVien";
            this.btn_GiaoVien.Size = new System.Drawing.Size(217, 120);
            this.btn_GiaoVien.TabIndex = 6;
            this.btn_GiaoVien.Text = "Giáo viên";
            this.btn_GiaoVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_GiaoVien.UseVisualStyleBackColor = false;
            this.btn_GiaoVien.Click += new System.EventHandler(this.btn_GiaoVien_Click);
            // 
            // btn_HocSinh
            // 
            this.btn_HocSinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_HocSinh.BackColor = System.Drawing.Color.Transparent;
            this.btn_HocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HocSinh.Image = global::GUI.Properties.Resources.student_72;
            this.btn_HocSinh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HocSinh.Location = new System.Drawing.Point(156, 63);
            this.btn_HocSinh.Name = "btn_HocSinh";
            this.btn_HocSinh.Size = new System.Drawing.Size(217, 120);
            this.btn_HocSinh.TabIndex = 5;
            this.btn_HocSinh.Text = "Học sinh";
            this.btn_HocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HocSinh.UseVisualStyleBackColor = false;
            this.btn_HocSinh.Click += new System.EventHandler(this.btn_HocSinh_Click);
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ChucNang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_ChucNang.Controls.Add(this.btn_DangXuat);
            this.panel_ChucNang.Controls.Add(this.btn_School);
            this.panel_ChucNang.Controls.Add(this.btn_LichThi);
            this.panel_ChucNang.Controls.Add(this.btn_LichGiangDay);
            this.panel_ChucNang.Controls.Add(this.btn_ThongKe);
            this.panel_ChucNang.Controls.Add(this.btn_ThoiKhoaBieu);
            this.panel_ChucNang.Location = new System.Drawing.Point(1, 43);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Size = new System.Drawing.Size(292, 605);
            this.panel_ChucNang.TabIndex = 7;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DangXuat.BackColor = System.Drawing.Color.Red;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.Location = new System.Drawing.Point(11, 560);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(271, 42);
            this.btn_DangXuat.TabIndex = 9;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_School
            // 
            this.btn_School.BackColor = System.Drawing.Color.Transparent;
            this.btn_School.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_School.Image = ((System.Drawing.Image)(resources.GetObject("btn_School.Image")));
            this.btn_School.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_School.Location = new System.Drawing.Point(11, 361);
            this.btn_School.Name = "btn_School";
            this.btn_School.Size = new System.Drawing.Size(271, 80);
            this.btn_School.TabIndex = 8;
            this.btn_School.Text = "School";
            this.btn_School.UseVisualStyleBackColor = false;
            this.btn_School.Click += new System.EventHandler(this.btn_School_Click);
            // 
            // btn_LichThi
            // 
            this.btn_LichThi.BackColor = System.Drawing.Color.Transparent;
            this.btn_LichThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichThi.Image = global::GUI.Properties.Resources.Thi_48;
            this.btn_LichThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LichThi.Location = new System.Drawing.Point(11, 272);
            this.btn_LichThi.Name = "btn_LichThi";
            this.btn_LichThi.Size = new System.Drawing.Size(271, 80);
            this.btn_LichThi.TabIndex = 7;
            this.btn_LichThi.Text = "Lịch thi";
            this.btn_LichThi.UseVisualStyleBackColor = false;
            this.btn_LichThi.Click += new System.EventHandler(this.btn_LichThi_Click);
            // 
            // btn_LichGiangDay
            // 
            this.btn_LichGiangDay.BackColor = System.Drawing.Color.Transparent;
            this.btn_LichGiangDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichGiangDay.Image = global::GUI.Properties.Resources.List_48;
            this.btn_LichGiangDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LichGiangDay.Location = new System.Drawing.Point(11, 183);
            this.btn_LichGiangDay.Name = "btn_LichGiangDay";
            this.btn_LichGiangDay.Size = new System.Drawing.Size(271, 80);
            this.btn_LichGiangDay.TabIndex = 5;
            this.btn_LichGiangDay.Text = "Lịch Giảng dạy";
            this.btn_LichGiangDay.UseVisualStyleBackColor = false;
            this.btn_LichGiangDay.Click += new System.EventHandler(this.btn_LichGiangDay_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Image = global::GUI.Properties.Resources.thongke_48;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(11, 5);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(271, 80);
            this.btn_ThongKe.TabIndex = 4;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_ThoiKhoaBieu
            // 
            this.btn_ThoiKhoaBieu.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThoiKhoaBieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThoiKhoaBieu.Image = global::GUI.Properties.Resources.Lich_48;
            this.btn_ThoiKhoaBieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoiKhoaBieu.Location = new System.Drawing.Point(11, 94);
            this.btn_ThoiKhoaBieu.Name = "btn_ThoiKhoaBieu";
            this.btn_ThoiKhoaBieu.Size = new System.Drawing.Size(271, 80);
            this.btn_ThoiKhoaBieu.TabIndex = 6;
            this.btn_ThoiKhoaBieu.Text = "Thời Khóa biểu";
            this.btn_ThoiKhoaBieu.UseVisualStyleBackColor = false;
            // 
            // panel_Navbar
            // 
            this.panel_Navbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Navbar.Location = new System.Drawing.Point(1, 1);
            this.panel_Navbar.Name = "panel_Navbar";
            this.panel_Navbar.Size = new System.Drawing.Size(1236, 41);
            this.panel_Navbar.TabIndex = 6;
            // 
            // frm_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 648);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.panel_Navbar);
            this.Name = "frm_QuanLy";
            this.Text = "Quản lý trường THPT";
            this.panel_Menu.ResumeLayout(false);
            this.panel_ChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_ThuChi;
        private System.Windows.Forms.Button btn_PhongHoc;
        private System.Windows.Forms.Button btn_MonHoc;
        private System.Windows.Forms.Button btn_LopHoc;
        private System.Windows.Forms.Button btn_GiaoVien;
        private System.Windows.Forms.Button btn_HocSinh;
        private System.Windows.Forms.Panel panel_ChucNang;
        private System.Windows.Forms.Button btn_ThoiKhoaBieu;
        private System.Windows.Forms.Button btn_LichGiangDay;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Panel panel_Navbar;
        private System.Windows.Forms.Button btn_School;
        private System.Windows.Forms.Button btn_LichThi;
        private System.Windows.Forms.Button btn_DangXuat;
    }
}