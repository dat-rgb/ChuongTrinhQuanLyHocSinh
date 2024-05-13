namespace GUI
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_LoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.cbb_LoaiTaiKhoan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Login);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Username);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Name = "panel2";
            // 
            // cbb_LoaiTaiKhoan
            // 
            resources.ApplyResources(this.cbb_LoaiTaiKhoan, "cbb_LoaiTaiKhoan");
            this.cbb_LoaiTaiKhoan.FormattingEnabled = true;
            this.cbb_LoaiTaiKhoan.Items.AddRange(new object[] {
            resources.GetString("cbb_LoaiTaiKhoan.Items"),
            resources.GetString("cbb_LoaiTaiKhoan.Items1"),
            resources.GetString("cbb_LoaiTaiKhoan.Items2")});
            this.cbb_LoaiTaiKhoan.Name = "cbb_LoaiTaiKhoan";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btn_Login
            // 
            resources.ApplyResources(this.btn_Login, "btn_Login");
            this.btn_Login.BackColor = System.Drawing.Color.Red;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txt_Username
            // 
            resources.ApplyResources(this.txt_Username, "txt_Username");
            this.txt_Username.BackColor = System.Drawing.Color.LightGray;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.ForeColor = System.Drawing.Color.Red;
            this.txt_Username.Name = "txt_Username";
            // 
            // txt_Password
            // 
            resources.ApplyResources(this.txt_Password, "txt_Password");
            this.txt_Password.BackColor = System.Drawing.Color.LightGray;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.ForeColor = System.Drawing.Color.Red;
            this.txt_Password.Name = "txt_Password";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // frm_DangNhap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_DangNhap";
            this.ShowIcon = false;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_LoaiTaiKhoan;
    }
}

