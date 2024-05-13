namespace GUI
{
    partial class frm_HocSinhDiem
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TBHK1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TBHK2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CaNam = new System.Windows.Forms.TextBox();
            this.dgv_DSDiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_NamHoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_HocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_MonHoc = new System.Windows.Forms.ComboBox();
            this.lbl_MonHoc = new System.Windows.Forms.Label();
            this.txt_MaHS = new System.Windows.Forms.TextBox();
            this.lbl_MaHS = new System.Windows.Forms.Label();
            this.btn_TraCuu = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.btn_TraCuu);
            this.panel3.Controls.Add(this.dgv_DSDiem);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(-1, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 716);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "DANH SÁCH ĐIỂM MÔN HỌC";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_TBHK1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_TBHK2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_CaNam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(914, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 143);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điểm TB học kỳ";
            // 
            // txt_TBHK1
            // 
            this.txt_TBHK1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TBHK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TBHK1.ForeColor = System.Drawing.Color.Red;
            this.txt_TBHK1.Location = new System.Drawing.Point(131, 25);
            this.txt_TBHK1.Name = "txt_TBHK1";
            this.txt_TBHK1.Size = new System.Drawing.Size(124, 24);
            this.txt_TBHK1.TabIndex = 51;
            this.txt_TBHK1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "TB học kỳ 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "TB học kỳ 2:";
            // 
            // txt_TBHK2
            // 
            this.txt_TBHK2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TBHK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TBHK2.ForeColor = System.Drawing.Color.Red;
            this.txt_TBHK2.Location = new System.Drawing.Point(131, 65);
            this.txt_TBHK2.Name = "txt_TBHK2";
            this.txt_TBHK2.Size = new System.Drawing.Size(124, 24);
            this.txt_TBHK2.TabIndex = 53;
            this.txt_TBHK2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(22, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 54;
            this.label12.Text = "Cả năm:";
            // 
            // txt_CaNam
            // 
            this.txt_CaNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CaNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CaNam.ForeColor = System.Drawing.Color.Red;
            this.txt_CaNam.Location = new System.Drawing.Point(131, 107);
            this.txt_CaNam.Name = "txt_CaNam";
            this.txt_CaNam.Size = new System.Drawing.Size(124, 24);
            this.txt_CaNam.TabIndex = 55;
            this.txt_CaNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_DSDiem
            // 
            this.dgv_DSDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDiem.GridColor = System.Drawing.Color.Gainsboro;
            this.dgv_DSDiem.Location = new System.Drawing.Point(13, 247);
            this.dgv_DSDiem.Name = "dgv_DSDiem";
            this.dgv_DSDiem.ReadOnly = true;
            this.dgv_DSDiem.RowHeadersWidth = 51;
            this.dgv_DSDiem.RowTemplate.Height = 24;
            this.dgv_DSDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSDiem.Size = new System.Drawing.Size(895, 450);
            this.dgv_DSDiem.TabIndex = 1;
            this.dgv_DSDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSDiem_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbb_NamHoc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbb_HocKy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbb_MonHoc);
            this.groupBox1.Controls.Add(this.lbl_MonHoc);
            this.groupBox1.Controls.Add(this.txt_MaHS);
            this.groupBox1.Controls.Add(this.lbl_MaHS);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ĐIỂM HỌC SINH";
            // 
            // cbb_NamHoc
            // 
            this.cbb_NamHoc.FormattingEnabled = true;
            this.cbb_NamHoc.Location = new System.Drawing.Point(516, 32);
            this.cbb_NamHoc.Name = "cbb_NamHoc";
            this.cbb_NamHoc.Size = new System.Drawing.Size(321, 28);
            this.cbb_NamHoc.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(430, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 71;
            this.label9.Text = "Năm học:";
            // 
            // cbb_HocKy
            // 
            this.cbb_HocKy.FormattingEnabled = true;
            this.cbb_HocKy.Location = new System.Drawing.Point(516, 80);
            this.cbb_HocKy.Name = "cbb_HocKy";
            this.cbb_HocKy.Size = new System.Drawing.Size(321, 28);
            this.cbb_HocKy.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(430, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Học Kỳ:";
            // 
            // cbb_MonHoc
            // 
            this.cbb_MonHoc.FormattingEnabled = true;
            this.cbb_MonHoc.Location = new System.Drawing.Point(92, 82);
            this.cbb_MonHoc.Name = "cbb_MonHoc";
            this.cbb_MonHoc.Size = new System.Drawing.Size(321, 28);
            this.cbb_MonHoc.TabIndex = 68;
            // 
            // lbl_MonHoc
            // 
            this.lbl_MonHoc.AutoSize = true;
            this.lbl_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MonHoc.ForeColor = System.Drawing.Color.Black;
            this.lbl_MonHoc.Location = new System.Drawing.Point(6, 87);
            this.lbl_MonHoc.Name = "lbl_MonHoc";
            this.lbl_MonHoc.Size = new System.Drawing.Size(79, 18);
            this.lbl_MonHoc.TabIndex = 61;
            this.lbl_MonHoc.Text = "Môn học:";
            // 
            // txt_MaHS
            // 
            this.txt_MaHS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_MaHS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaHS.Location = new System.Drawing.Point(92, 31);
            this.txt_MaHS.Name = "txt_MaHS";
            this.txt_MaHS.ReadOnly = true;
            this.txt_MaHS.Size = new System.Drawing.Size(321, 28);
            this.txt_MaHS.TabIndex = 12;
            // 
            // lbl_MaHS
            // 
            this.lbl_MaHS.AutoSize = true;
            this.lbl_MaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaHS.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaHS.Location = new System.Drawing.Point(6, 31);
            this.lbl_MaHS.Name = "lbl_MaHS";
            this.lbl_MaHS.Size = new System.Drawing.Size(64, 18);
            this.lbl_MaHS.TabIndex = 7;
            this.lbl_MaHS.Text = "Mã HS:";
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_TraCuu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_TraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraCuu.ForeColor = System.Drawing.Color.Black;
            this.btn_TraCuu.Image = global::GUI.Properties.Resources.search_48;
            this.btn_TraCuu.Location = new System.Drawing.Point(712, 171);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(196, 61);
            this.btn_TraCuu.TabIndex = 74;
            this.btn_TraCuu.UseVisualStyleBackColor = false;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // frm_HocSinhDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 715);
            this.Controls.Add(this.panel3);
            this.Name = "frm_HocSinhDiem";
            this.Text = "Điểm học sinh";
            this.Load += new System.EventHandler(this.frm_HocSinhDiem_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MaHS;
        private System.Windows.Forms.Label lbl_MaHS;
        private System.Windows.Forms.ComboBox cbb_NamHoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_HocKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_MonHoc;
        private System.Windows.Forms.Label lbl_MonHoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TBHK1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TBHK2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CaNam;
        private System.Windows.Forms.Button btn_TraCuu;
        private System.Windows.Forms.DataGridView dgv_DSDiem;
        private System.Windows.Forms.Label label2;
    }
}