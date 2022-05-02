
namespace KisiOtomasyon
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.pic_logins = new System.Windows.Forms.PictureBox();
            this.txt_userPass = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.btn_pass = new System.Windows.Forms.Button();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.lbl_hr = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logins)).BeginInit();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_userName
            // 
            this.txt_userName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userName.Location = new System.Drawing.Point(34, 161);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(214, 29);
            this.txt_userName.TabIndex = 0;
            this.txt_userName.Click += new System.EventHandler(this.txt_userName_Click);
            // 
            // pic_logins
            // 
            this.pic_logins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logins.Image = ((System.Drawing.Image)(resources.GetObject("pic_logins.Image")));
            this.pic_logins.Location = new System.Drawing.Point(102, 37);
            this.pic_logins.Name = "pic_logins";
            this.pic_logins.Size = new System.Drawing.Size(86, 75);
            this.pic_logins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logins.TabIndex = 1;
            this.pic_logins.TabStop = false;
            // 
            // txt_userPass
            // 
            this.txt_userPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userPass.Location = new System.Drawing.Point(34, 216);
            this.txt_userPass.Name = "txt_userPass";
            this.txt_userPass.PasswordChar = '*';
            this.txt_userPass.Size = new System.Drawing.Size(214, 29);
            this.txt_userPass.TabIndex = 1;
            this.txt_userPass.Click += new System.EventHandler(this.txt_userPass_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pass.Location = new System.Drawing.Point(34, 192);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(37, 17);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Şifre:";
            this.lbl_pass.Visible = false;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_userName.Location = new System.Drawing.Point(34, 137);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(81, 17);
            this.lbl_userName.TabIndex = 4;
            this.lbl_userName.Text = "Kullanıcı Adı:";
            this.lbl_userName.Visible = false;
            // 
            // btn_pass
            // 
            this.btn_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pass.FlatAppearance.BorderSize = 0;
            this.btn_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.btn_pass.Location = new System.Drawing.Point(101, 256);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(147, 24);
            this.btn_pass.TabIndex = 2;
            this.btn_pass.Text = "Şifreni mi Unuttun ?";
            this.btn_pass.UseVisualStyleBackColor = true;
            // 
            // pnl_login
            // 
            this.pnl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_login.BackColor = System.Drawing.Color.Transparent;
            this.pnl_login.Controls.Add(this.lbl_hr);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.btn_pass);
            this.pnl_login.Controls.Add(this.lbl_userName);
            this.pnl_login.Controls.Add(this.lbl_pass);
            this.pnl_login.Controls.Add(this.txt_userPass);
            this.pnl_login.Controls.Add(this.pic_logins);
            this.pnl_login.Controls.Add(this.txt_userName);
            this.pnl_login.ForeColor = System.Drawing.SystemColors.Control;
            this.pnl_login.Location = new System.Drawing.Point(60, 66);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(281, 392);
            this.pnl_login.TabIndex = 0;
            // 
            // lbl_hr
            // 
            this.lbl_hr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hr.Location = new System.Drawing.Point(30, 281);
            this.lbl_hr.Name = "lbl_hr";
            this.lbl_hr.Size = new System.Drawing.Size(227, 17);
            this.lbl_hr.TabIndex = 5;
            this.lbl_hr.Text = "------------------------------------";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(150)))), ((int)(((byte)(223)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.ImageIndex = 0;
            this.btn_login.ImageList = this.ımageList1;
            this.btn_login.Location = new System.Drawing.Point(37, 318);
            this.btn_login.Name = "btn_login";
            this.btn_login.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btn_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_login.Size = new System.Drawing.Size(215, 38);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Giriş Yap";
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "login1_79986.png");
            this.ımageList1.Images.SetKeyName(1, "user_add_21977.png");
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(1)))), ((int)(((byte)(72)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(378, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_login);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logins)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.PictureBox pic_logins;
        private System.Windows.Forms.TextBox txt_userPass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_hr;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ImageList ımageList1;
    }
}