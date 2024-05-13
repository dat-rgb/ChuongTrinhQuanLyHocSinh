namespace GUI
{
    partial class frm_QuanLyDiemTrungBinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyDiemTrungBinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DanhSachDiemHS = new System.Windows.Forms.DataGridView();
            this.gpb_ThongTinHocSinh = new System.Windows.Forms.GroupBox();
            this.cbb_NamHoc = new System.Windows.Forms.ComboBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_TinhDiemTBHK1 = new System.Windows.Forms.Button();
            this.cbb_HocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDiemHS)).BeginInit();
            this.gpb_ThongTinHocSinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.dgv_DanhSachDiemHS);
            this.panel1.Controls.Add(this.gpb_ThongTinHocSinh);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 798);
            this.panel1.TabIndex = 6;
            // 
            // dgv_DanhSachDiemHS
            // 
            this.dgv_DanhSachDiemHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDiemHS.Location = new System.Drawing.Point(13, 220);
            this.dgv_DanhSachDiemHS.Name = "dgv_DanhSachDiemHS";
            this.dgv_DanhSachDiemHS.ReadOnly = true;
            this.dgv_DanhSachDiemHS.RowHeadersWidth = 51;
            this.dgv_DanhSachDiemHS.RowTemplate.Height = 24;
            this.dgv_DanhSachDiemHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachDiemHS.Size = new System.Drawing.Size(1005, 562);
            this.dgv_DanhSachDiemHS.TabIndex = 0;
            // 
            // gpb_ThongTinHocSinh
            // 
            this.gpb_ThongTinHocSinh.BackColor = System.Drawing.Color.Gainsboro;
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_NamHoc);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_TimKiem);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_Save);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_Xoa);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_Sua);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label9);
            this.gpb_ThongTinHocSinh.Controls.Add(this.btn_TinhDiemTBHK1);
            this.gpb_ThongTinHocSinh.Controls.Add(this.cbb_HocKy);
            this.gpb_ThongTinHocSinh.Controls.Add(this.label2);
            this.gpb_ThongTinHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ThongTinHocSinh.ForeColor = System.Drawing.Color.Red;
            this.gpb_ThongTinHocSinh.Location = new System.Drawing.Point(15, 16);
            this.gpb_ThongTinHocSinh.Name = "gpb_ThongTinHocSinh";
            this.gpb_ThongTinHocSinh.Size = new System.Drawing.Size(1003, 198);
            this.gpb_ThongTinHocSinh.TabIndex = 17;
            this.gpb_ThongTinHocSinh.TabStop = false;
            this.gpb_ThongTinHocSinh.Text = "Thông tin Học sinh";
            // 
            // cbb_NamHoc
            // 
            this.cbb_NamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NamHoc.FormattingEnabled = true;
            this.cbb_NamHoc.Location = new System.Drawing.Point(172, 23);
            this.cbb_NamHoc.Name = "cbb_NamHoc";
            this.cbb_NamHoc.Size = new System.Drawing.Size(236, 28);
            this.cbb_NamHoc.TabIndex = 71;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search_48;
            this.btn_TimKiem.Location = new System.Drawing.Point(628, 119);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(119, 71);
            this.btn_TimKiem.TabIndex = 20;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Gold;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(172, 138);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(194, 34);
            this.btn_Save.TabIndex = 67;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(878, 121);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 71);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(753, 119);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 71);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(46, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Năm học:";
            // 
            // btn_TinhDiemTBHK1
            // 
            this.btn_TinhDiemTBHK1.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_TinhDiemTBHK1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_TinhDiemTBHK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhDiemTBHK1.ForeColor = System.Drawing.Color.Black;
            this.btn_TinhDiemTBHK1.Location = new System.Drawing.Point(172, 98);
            this.btn_TinhDiemTBHK1.Name = "btn_TinhDiemTBHK1";
            this.btn_TinhDiemTBHK1.Size = new System.Drawing.Size(194, 34);
            this.btn_TinhDiemTBHK1.TabIndex = 67;
            this.btn_TinhDiemTBHK1.Text = "Tính TB HK1";
            this.btn_TinhDiemTBHK1.UseVisualStyleBackColor = false;
            this.btn_TinhDiemTBHK1.Click += new System.EventHandler(this.btn_TinhDiemTBHK_Click);
            // 
            // cbb_HocKy
            // 
            this.cbb_HocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_HocKy.FormattingEnabled = true;
            this.cbb_HocKy.Location = new System.Drawing.Point(172, 61);
            this.cbb_HocKy.Name = "cbb_HocKy";
            this.cbb_HocKy.Size = new System.Drawing.Size(236, 28);
            this.cbb_HocKy.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Học Kỳ:";
            // 
            // frm_QuanLyDiemTrungBinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 790);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLyDiemTrungBinh";
            this.Text = "frm_QuanLyDiemTrungBinh";
            this.Load += new System.EventHandler(this.frm_QuanLyDiemTrungBinh_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDiemHS)).EndInit();
            this.gpb_ThongTinHocSinh.ResumeLayout(false);
            this.gpb_ThongTinHocSinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DanhSachDiemHS;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox gpb_ThongTinHocSinh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_TinhDiemTBHK1;
        private System.Windows.Forms.ComboBox cbb_NamHoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_HocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}