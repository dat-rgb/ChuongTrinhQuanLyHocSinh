namespace GUI
{
    partial class frm_QuanLyMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyMonHoc));
            this.panel_MonHoc_PhanCong = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.gpb_danhsach = new System.Windows.Forms.GroupBox();
            this.cbb_GiaoVien = new System.Windows.Forms.ComboBox();
            this.dgv_DanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.lbl_giaoVienDay = new System.Windows.Forms.Label();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.lbl_mon = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.gpb_Thongtin = new System.Windows.Forms.GroupBox();
            this.cbb_TatCaMonhoc = new System.Windows.Forms.ComboBox();
            this.lbl_MonDay = new System.Windows.Forms.Label();
            this.cbb_TatCaGiaoVien = new System.Windows.Forms.ComboBox();
            this.lbl_GV = new System.Windows.Forms.Label();
            this.rad_DSPhanCong = new System.Windows.Forms.RadioButton();
            this.rad_DSMonHoc = new System.Windows.Forms.RadioButton();
            this.panel_MonHoc_PhanCong.SuspendLayout();
            this.gpb_danhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonHoc)).BeginInit();
            this.gpb_Thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MonHoc_PhanCong
            // 
            this.panel_MonHoc_PhanCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_MonHoc_PhanCong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_MonHoc_PhanCong.Controls.Add(this.btn_Thoat);
            this.panel_MonHoc_PhanCong.Controls.Add(this.gpb_danhsach);
            this.panel_MonHoc_PhanCong.Controls.Add(this.btn_Sua);
            this.panel_MonHoc_PhanCong.Controls.Add(this.btn_Clear);
            this.panel_MonHoc_PhanCong.Controls.Add(this.btn_Xoa);
            this.panel_MonHoc_PhanCong.Controls.Add(this.btn_Refesh);
            this.panel_MonHoc_PhanCong.Controls.Add(this.btn_Them);
            this.panel_MonHoc_PhanCong.Controls.Add(this.gpb_Thongtin);
            this.panel_MonHoc_PhanCong.Location = new System.Drawing.Point(0, 0);
            this.panel_MonHoc_PhanCong.Name = "panel_MonHoc_PhanCong";
            this.panel_MonHoc_PhanCong.Size = new System.Drawing.Size(1239, 657);
            this.panel_MonHoc_PhanCong.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Red;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(12, 596);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(244, 40);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // gpb_danhsach
            // 
            this.gpb_danhsach.BackColor = System.Drawing.Color.White;
            this.gpb_danhsach.Controls.Add(this.cbb_GiaoVien);
            this.gpb_danhsach.Controls.Add(this.dgv_DanhSachMonHoc);
            this.gpb_danhsach.Controls.Add(this.btn_TimKiem);
            this.gpb_danhsach.Controls.Add(this.lbl_giaoVienDay);
            this.gpb_danhsach.Controls.Add(this.cbb_MonHoc);
            this.gpb_danhsach.Controls.Add(this.lbl_mon);
            this.gpb_danhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_danhsach.Location = new System.Drawing.Point(264, 143);
            this.gpb_danhsach.Name = "gpb_danhsach";
            this.gpb_danhsach.Size = new System.Drawing.Size(963, 493);
            this.gpb_danhsach.TabIndex = 0;
            this.gpb_danhsach.TabStop = false;
            this.gpb_danhsach.Text = "Tìm kiếm nhanh";
            // 
            // cbb_GiaoVien
            // 
            this.cbb_GiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GiaoVien.FormattingEnabled = true;
            this.cbb_GiaoVien.Location = new System.Drawing.Point(470, 23);
            this.cbb_GiaoVien.Name = "cbb_GiaoVien";
            this.cbb_GiaoVien.Size = new System.Drawing.Size(344, 26);
            this.cbb_GiaoVien.TabIndex = 4;
            // 
            // dgv_DanhSachMonHoc
            // 
            this.dgv_DanhSachMonHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachMonHoc.Location = new System.Drawing.Point(6, 70);
            this.dgv_DanhSachMonHoc.Name = "dgv_DanhSachMonHoc";
            this.dgv_DanhSachMonHoc.ReadOnly = true;
            this.dgv_DanhSachMonHoc.RowHeadersWidth = 51;
            this.dgv_DanhSachMonHoc.RowTemplate.Height = 24;
            this.dgv_DanhSachMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachMonHoc.Size = new System.Drawing.Size(948, 417);
            this.dgv_DanhSachMonHoc.TabIndex = 0;
            this.dgv_DanhSachMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachMonHoc_CellClick);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(820, 17);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(137, 37);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // lbl_giaoVienDay
            // 
            this.lbl_giaoVienDay.AutoSize = true;
            this.lbl_giaoVienDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaoVienDay.ForeColor = System.Drawing.Color.Black;
            this.lbl_giaoVienDay.Location = new System.Drawing.Point(404, 27);
            this.lbl_giaoVienDay.Name = "lbl_giaoVienDay";
            this.lbl_giaoVienDay.Size = new System.Drawing.Size(60, 18);
            this.lbl_giaoVienDay.TabIndex = 0;
            this.lbl_giaoVienDay.Text = "GV dạy:";
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(88, 23);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(310, 26);
            this.cbb_MonHoc.TabIndex = 3;
            this.cbb_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbb_MonHoc_SelectedIndexChanged);
            // 
            // lbl_mon
            // 
            this.lbl_mon.AutoSize = true;
            this.lbl_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mon.ForeColor = System.Drawing.Color.Black;
            this.lbl_mon.Location = new System.Drawing.Point(11, 27);
            this.lbl_mon.Name = "lbl_mon";
            this.lbl_mon.Size = new System.Drawing.Size(71, 18);
            this.lbl_mon.TabIndex = 0;
            this.lbl_mon.Text = "Môn học:";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(12, 102);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(244, 71);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Cập nhật";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(1084, 101);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(143, 33);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(12, 179);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(244, 71);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refesh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refesh.Location = new System.Drawing.Point(1084, 62);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(143, 33);
            this.btn_Refesh.TabIndex = 9;
            this.btn_Refesh.Text = "Refesh";
            this.btn_Refesh.UseVisualStyleBackColor = false;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(12, 25);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(244, 71);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gpb_Thongtin
            // 
            this.gpb_Thongtin.BackColor = System.Drawing.Color.White;
            this.gpb_Thongtin.Controls.Add(this.cbb_TatCaMonhoc);
            this.gpb_Thongtin.Controls.Add(this.lbl_MonDay);
            this.gpb_Thongtin.Controls.Add(this.cbb_TatCaGiaoVien);
            this.gpb_Thongtin.Controls.Add(this.lbl_GV);
            this.gpb_Thongtin.Controls.Add(this.rad_DSPhanCong);
            this.gpb_Thongtin.Controls.Add(this.rad_DSMonHoc);
            this.gpb_Thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Thongtin.ForeColor = System.Drawing.Color.Red;
            this.gpb_Thongtin.Location = new System.Drawing.Point(264, 25);
            this.gpb_Thongtin.Name = "gpb_Thongtin";
            this.gpb_Thongtin.Size = new System.Drawing.Size(814, 112);
            this.gpb_Thongtin.TabIndex = 0;
            this.gpb_Thongtin.TabStop = false;
            this.gpb_Thongtin.Text = "Phân công giảng dạy";
            // 
            // cbb_TatCaMonhoc
            // 
            this.cbb_TatCaMonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TatCaMonhoc.FormattingEnabled = true;
            this.cbb_TatCaMonhoc.Location = new System.Drawing.Point(169, 73);
            this.cbb_TatCaMonhoc.Name = "cbb_TatCaMonhoc";
            this.cbb_TatCaMonhoc.Size = new System.Drawing.Size(346, 28);
            this.cbb_TatCaMonhoc.TabIndex = 2;
            // 
            // lbl_MonDay
            // 
            this.lbl_MonDay.AutoSize = true;
            this.lbl_MonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MonDay.ForeColor = System.Drawing.Color.Black;
            this.lbl_MonDay.Location = new System.Drawing.Point(15, 76);
            this.lbl_MonDay.Name = "lbl_MonDay";
            this.lbl_MonDay.Size = new System.Drawing.Size(85, 20);
            this.lbl_MonDay.TabIndex = 0;
            this.lbl_MonDay.Text = "Môn dạy:";
            // 
            // cbb_TatCaGiaoVien
            // 
            this.cbb_TatCaGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TatCaGiaoVien.FormattingEnabled = true;
            this.cbb_TatCaGiaoVien.Location = new System.Drawing.Point(169, 26);
            this.cbb_TatCaGiaoVien.Name = "cbb_TatCaGiaoVien";
            this.cbb_TatCaGiaoVien.Size = new System.Drawing.Size(346, 28);
            this.cbb_TatCaGiaoVien.TabIndex = 1;
            // 
            // lbl_GV
            // 
            this.lbl_GV.AutoSize = true;
            this.lbl_GV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GV.ForeColor = System.Drawing.Color.Black;
            this.lbl_GV.Location = new System.Drawing.Point(15, 29);
            this.lbl_GV.Name = "lbl_GV";
            this.lbl_GV.Size = new System.Drawing.Size(129, 20);
            this.lbl_GV.TabIndex = 0;
            this.lbl_GV.Text = "Giáo viên dạy:";
            // 
            // rad_DSPhanCong
            // 
            this.rad_DSPhanCong.AutoSize = true;
            this.rad_DSPhanCong.ForeColor = System.Drawing.Color.Black;
            this.rad_DSPhanCong.Location = new System.Drawing.Point(545, 72);
            this.rad_DSPhanCong.Name = "rad_DSPhanCong";
            this.rad_DSPhanCong.Size = new System.Drawing.Size(206, 26);
            this.rad_DSPhanCong.TabIndex = 11;
            this.rad_DSPhanCong.TabStop = true;
            this.rad_DSPhanCong.Text = "Danh sách phân công\r\n";
            this.rad_DSPhanCong.UseVisualStyleBackColor = true;
            this.rad_DSPhanCong.CheckedChanged += new System.EventHandler(this.rad_DSPhanCong_CheckedChanged);
            // 
            // rad_DSMonHoc
            // 
            this.rad_DSMonHoc.AutoSize = true;
            this.rad_DSMonHoc.ForeColor = System.Drawing.Color.Black;
            this.rad_DSMonHoc.Location = new System.Drawing.Point(545, 27);
            this.rad_DSMonHoc.Name = "rad_DSMonHoc";
            this.rad_DSMonHoc.Size = new System.Drawing.Size(195, 26);
            this.rad_DSMonHoc.TabIndex = 12;
            this.rad_DSMonHoc.TabStop = true;
            this.rad_DSMonHoc.Text = "Danh sách môn học ";
            this.rad_DSMonHoc.UseVisualStyleBackColor = true;
            this.rad_DSMonHoc.CheckedChanged += new System.EventHandler(this.rad_DSMonHoc_CheckedChanged);
            // 
            // frm_QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 648);
            this.Controls.Add(this.panel_MonHoc_PhanCong);
            this.Name = "frm_QuanLyMonHoc";
            this.Text = "Môn học & Phân công";
            this.Load += new System.EventHandler(this.frm_QuanLyMonHoc_Load);
            this.panel_MonHoc_PhanCong.ResumeLayout(false);
            this.gpb_danhsach.ResumeLayout(false);
            this.gpb_danhsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachMonHoc)).EndInit();
            this.gpb_Thongtin.ResumeLayout(false);
            this.gpb_Thongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MonHoc_PhanCong;
        private System.Windows.Forms.GroupBox gpb_Thongtin;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_mon;
        private System.Windows.Forms.DataGridView dgv_DanhSachMonHoc;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_giaoVienDay;
        private System.Windows.Forms.ComboBox cbb_GiaoVien;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.GroupBox gpb_danhsach;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.RadioButton rad_DSPhanCong;
        private System.Windows.Forms.RadioButton rad_DSMonHoc;
        private System.Windows.Forms.Label lbl_GV;
        private System.Windows.Forms.ComboBox cbb_TatCaGiaoVien;
        private System.Windows.Forms.ComboBox cbb_TatCaMonhoc;
        private System.Windows.Forms.Label lbl_MonDay;
    }
}