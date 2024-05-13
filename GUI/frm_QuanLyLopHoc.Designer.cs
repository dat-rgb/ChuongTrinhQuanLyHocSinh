namespace GUI
{
    partial class frm_QuanLyLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyLopHoc));
            this.dgv_DanhSachLopHoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.btn_KhoiPhucHSDaXoa = new System.Windows.Forms.Button();
            this.gpb_ThongTinLopHoc = new System.Windows.Forms.GroupBox();
            this.cbb_GiaoVien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MaLop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.chk_ThemLop = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_NamHoc = new System.Windows.Forms.ComboBox();
            this.cbb_PhongHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_SoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachLopHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpb_ThongTinLopHoc.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSachLopHoc
            // 
            this.dgv_DanhSachLopHoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DanhSachLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachLopHoc.Location = new System.Drawing.Point(26, 81);
            this.dgv_DanhSachLopHoc.Name = "dgv_DanhSachLopHoc";
            this.dgv_DanhSachLopHoc.ReadOnly = true;
            this.dgv_DanhSachLopHoc.RowHeadersWidth = 51;
            this.dgv_DanhSachLopHoc.RowTemplate.Height = 24;
            this.dgv_DanhSachLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachLopHoc.Size = new System.Drawing.Size(732, 554);
            this.dgv_DanhSachLopHoc.TabIndex = 1;
            this.dgv_DanhSachLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachLopHoc_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_DanhSachLopHoc);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Refesh);
            this.panel1.Controls.Add(this.btn_KhoiPhucHSDaXoa);
            this.panel1.Location = new System.Drawing.Point(468, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 649);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH LỚP";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(225, 40);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 33);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refesh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refesh.Location = new System.Drawing.Point(126, 40);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(93, 33);
            this.btn_Refesh.TabIndex = 39;
            this.btn_Refesh.Text = "Refesh";
            this.btn_Refesh.UseVisualStyleBackColor = false;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // btn_KhoiPhucHSDaXoa
            // 
            this.btn_KhoiPhucHSDaXoa.BackColor = System.Drawing.Color.DarkGray;
            this.btn_KhoiPhucHSDaXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_KhoiPhucHSDaXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhucHSDaXoa.ForeColor = System.Drawing.Color.Black;
            this.btn_KhoiPhucHSDaXoa.Location = new System.Drawing.Point(27, 40);
            this.btn_KhoiPhucHSDaXoa.Name = "btn_KhoiPhucHSDaXoa";
            this.btn_KhoiPhucHSDaXoa.Size = new System.Drawing.Size(93, 33);
            this.btn_KhoiPhucHSDaXoa.TabIndex = 41;
            this.btn_KhoiPhucHSDaXoa.Text = "Khôi phục";
            this.btn_KhoiPhucHSDaXoa.UseVisualStyleBackColor = false;
            // 
            // gpb_ThongTinLopHoc
            // 
            this.gpb_ThongTinLopHoc.BackColor = System.Drawing.Color.Gainsboro;
            this.gpb_ThongTinLopHoc.Controls.Add(this.cbb_PhongHoc);
            this.gpb_ThongTinLopHoc.Controls.Add(this.chk_ThemLop);
            this.gpb_ThongTinLopHoc.Controls.Add(this.cbb_GiaoVien);
            this.gpb_ThongTinLopHoc.Controls.Add(this.cbb_NamHoc);
            this.gpb_ThongTinLopHoc.Controls.Add(this.nud_SoLuong);
            this.gpb_ThongTinLopHoc.Controls.Add(this.label6);
            this.gpb_ThongTinLopHoc.Controls.Add(this.label5);
            this.gpb_ThongTinLopHoc.Controls.Add(this.label3);
            this.gpb_ThongTinLopHoc.Controls.Add(this.label4);
            this.gpb_ThongTinLopHoc.Controls.Add(this.txt_MaLop);
            this.gpb_ThongTinLopHoc.Controls.Add(this.txt_TenLop);
            this.gpb_ThongTinLopHoc.Controls.Add(this.label1);
            this.gpb_ThongTinLopHoc.Controls.Add(this.lbl_MaLop);
            this.gpb_ThongTinLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ThongTinLopHoc.ForeColor = System.Drawing.Color.Red;
            this.gpb_ThongTinLopHoc.Location = new System.Drawing.Point(10, 11);
            this.gpb_ThongTinLopHoc.Name = "gpb_ThongTinLopHoc";
            this.gpb_ThongTinLopHoc.Size = new System.Drawing.Size(450, 330);
            this.gpb_ThongTinLopHoc.TabIndex = 1;
            this.gpb_ThongTinLopHoc.TabStop = false;
            this.gpb_ThongTinLopHoc.Text = "Thông tin Lớp";
            // 
            // cbb_GiaoVien
            // 
            this.cbb_GiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbb_GiaoVien.FormattingEnabled = true;
            this.cbb_GiaoVien.Location = new System.Drawing.Point(122, 175);
            this.cbb_GiaoVien.Name = "cbb_GiaoVien";
            this.cbb_GiaoVien.Size = new System.Drawing.Size(312, 28);
            this.cbb_GiaoVien.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "GVCN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phòng:";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLop.Location = new System.Drawing.Point(122, 70);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(312, 27);
            this.txt_MaLop.TabIndex = 9;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLop.Location = new System.Drawing.Point(122, 105);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(312, 27);
            this.txt_TenLop.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên lớp:";
            // 
            // lbl_MaLop
            // 
            this.lbl_MaLop.AutoSize = true;
            this.lbl_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLop.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaLop.Location = new System.Drawing.Point(20, 73);
            this.lbl_MaLop.Name = "lbl_MaLop";
            this.lbl_MaLop.Size = new System.Drawing.Size(77, 20);
            this.lbl_MaLop.TabIndex = 1;
            this.lbl_MaLop.Text = "Mã Lớp:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.gpb_ThongTinLopHoc);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Controls.Add(this.btn_TimKiem);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 649);
            this.panel2.TabIndex = 6;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(352, 347);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 71);
            this.btn_Xoa.TabIndex = 45;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(124, 347);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 71);
            this.btn_Sua.TabIndex = 43;
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.Location = new System.Drawing.Point(10, 347);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(108, 71);
            this.btn_Them.TabIndex = 42;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.Location = new System.Drawing.Point(238, 347);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(108, 71);
            this.btn_TimKiem.TabIndex = 44;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // chk_ThemLop
            // 
            this.chk_ThemLop.AutoSize = true;
            this.chk_ThemLop.ForeColor = System.Drawing.Color.Black;
            this.chk_ThemLop.Location = new System.Drawing.Point(122, 36);
            this.chk_ThemLop.Name = "chk_ThemLop";
            this.chk_ThemLop.Size = new System.Drawing.Size(115, 26);
            this.chk_ThemLop.TabIndex = 44;
            this.chk_ThemLop.Text = "Thêm lớp";
            this.chk_ThemLop.UseVisualStyleBackColor = true;
            this.chk_ThemLop.CheckedChanged += new System.EventHandler(this.chk_ThemLop_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm học:";
            // 
            // cbb_NamHoc
            // 
            this.cbb_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbb_NamHoc.FormattingEnabled = true;
            this.cbb_NamHoc.Location = new System.Drawing.Point(122, 247);
            this.cbb_NamHoc.Name = "cbb_NamHoc";
            this.cbb_NamHoc.Size = new System.Drawing.Size(312, 28);
            this.cbb_NamHoc.TabIndex = 20;
            // 
            // cbb_PhongHoc
            // 
            this.cbb_PhongHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbb_PhongHoc.FormattingEnabled = true;
            this.cbb_PhongHoc.Location = new System.Drawing.Point(122, 209);
            this.cbb_PhongHoc.Name = "cbb_PhongHoc";
            this.cbb_PhongHoc.Size = new System.Drawing.Size(312, 28);
            this.cbb_PhongHoc.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng:";
            // 
            // nud_SoLuong
            // 
            this.nud_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.nud_SoLuong.Location = new System.Drawing.Point(122, 140);
            this.nud_SoLuong.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_SoLuong.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud_SoLuong.Name = "nud_SoLuong";
            this.nud_SoLuong.Size = new System.Drawing.Size(148, 27);
            this.nud_SoLuong.TabIndex = 19;
            this.nud_SoLuong.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // frm_QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLyLopHoc";
            this.Text = "frm_QuanLyLopHoc";
            this.Load += new System.EventHandler(this.frm_QuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachLopHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_ThongTinLopHoc.ResumeLayout(false);
            this.gpb_ThongTinLopHoc.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_DanhSachLopHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_KhoiPhucHSDaXoa;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.GroupBox gpb_ThongTinLopHoc;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_MaLop;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cbb_GiaoVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_PhongHoc;
        private System.Windows.Forms.CheckBox chk_ThemLop;
        private System.Windows.Forms.ComboBox cbb_NamHoc;
        private System.Windows.Forms.NumericUpDown nud_SoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}