namespace Zack
{
    partial class Logion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logion));
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CkbPasssWord = new System.Windows.Forms.CheckBox();
            this.CkbLogin = new System.Windows.Forms.CheckBox();
            this.labRegister = new System.Windows.Forms.Label();
            this.labFindPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicBox.BackgroundImage")));
            this.PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBox.Location = new System.Drawing.Point(64, 265);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(102, 98);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.Location = new System.Drawing.Point(182, 402);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(218, 33);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.AcceptsTab = true;
            this.txtLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(3, 7);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(212, 22);
            this.txtLogin.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new System.Drawing.Point(182, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 35);
            this.panel1.TabIndex = 4;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassWord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassWord.Location = new System.Drawing.Point(3, 6);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(212, 22);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.txtPassWord);
            this.panel2.Location = new System.Drawing.Point(182, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 35);
            this.panel2.TabIndex = 5;
            // 
            // CkbPasssWord
            // 
            this.CkbPasssWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CkbPasssWord.AutoSize = true;
            this.CkbPasssWord.Location = new System.Drawing.Point(182, 347);
            this.CkbPasssWord.Name = "CkbPasssWord";
            this.CkbPasssWord.Size = new System.Drawing.Size(72, 16);
            this.CkbPasssWord.TabIndex = 6;
            this.CkbPasssWord.Text = "记住密码";
            this.CkbPasssWord.UseVisualStyleBackColor = true;
            // 
            // CkbLogin
            // 
            this.CkbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CkbLogin.AutoSize = true;
            this.CkbLogin.Location = new System.Drawing.Point(328, 347);
            this.CkbLogin.Name = "CkbLogin";
            this.CkbLogin.Size = new System.Drawing.Size(72, 16);
            this.CkbLogin.TabIndex = 7;
            this.CkbLogin.Text = "自动登录";
            this.CkbLogin.UseVisualStyleBackColor = true;
            // 
            // labRegister
            // 
            this.labRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labRegister.AutoSize = true;
            this.labRegister.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRegister.ForeColor = System.Drawing.Color.Blue;
            this.labRegister.Location = new System.Drawing.Point(406, 276);
            this.labRegister.Name = "labRegister";
            this.labRegister.Size = new System.Drawing.Size(63, 14);
            this.labRegister.TabIndex = 8;
            this.labRegister.Text = "注册账号";
            this.labRegister.Click += new System.EventHandler(this.labRegister_Click);
            this.labRegister.MouseLeave += new System.EventHandler(this.labRegister_MouseLeave);
            this.labRegister.MouseHover += new System.EventHandler(this.labRegister_MouseHover);
            // 
            // labFindPass
            // 
            this.labFindPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labFindPass.AutoSize = true;
            this.labFindPass.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFindPass.ForeColor = System.Drawing.Color.Blue;
            this.labFindPass.Location = new System.Drawing.Point(406, 312);
            this.labFindPass.Name = "labFindPass";
            this.labFindPass.Size = new System.Drawing.Size(63, 14);
            this.labFindPass.TabIndex = 9;
            this.labFindPass.Text = "找回密码";
            this.labFindPass.Click += new System.EventHandler(this.labFindPass_Click);
            this.labFindPass.MouseLeave += new System.EventHandler(this.labFindPass_MouseLeave);
            this.labFindPass.MouseHover += new System.EventHandler(this.labFindPass_MouseHover);
            // 
            // Logion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 447);
            this.Controls.Add(this.labFindPass);
            this.Controls.Add(this.labRegister);
            this.Controls.Add(this.CkbLogin);
            this.Controls.Add(this.CkbPasssWord);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.PicBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logion_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CkbPasssWord;
        private System.Windows.Forms.CheckBox CkbLogin;
        private System.Windows.Forms.Label labRegister;
        private System.Windows.Forms.Label labFindPass;


    }
}