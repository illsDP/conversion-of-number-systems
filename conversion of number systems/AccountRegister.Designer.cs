namespace Zack
{
    partial class AccountRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountRegister));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labtext = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.btnRegister = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.txt_Resume = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.txt_Phone = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txt_Email = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.labNowTime = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_UserName = new Sunny.UI.UITextBox();
            this.txt_PassWord = new Sunny.UI.UITextBox();
            this.txt_PwdSure = new Sunny.UI.UITextBox();
            this.dp_CreaterTime = new Sunny.UI.UIDatePicker();
            this.cmbIdentity_Type = new Sunny.UI.UIComboBox();
            this.txt_Name = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiImageButton2 = new Sunny.UI.UIImageButton();
            this.panelTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelTitle.Controls.Add(this.labtext);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(854, 40);
            this.panelTitle.TabIndex = 190;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // labtext
            // 
            this.labtext.AutoSize = true;
            this.labtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labtext.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.labtext.Location = new System.Drawing.Point(13, 15);
            this.labtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labtext.Name = "labtext";
            this.labtext.Size = new System.Drawing.Size(0, 14);
            this.labtext.TabIndex = 584;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(822, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.labNowTime);
            this.panel3.Controls.Add(this.uiLabel11);
            this.panel3.Controls.Add(this.btnRegister);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 490);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 58);
            this.panel3.TabIndex = 405;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(37, 76);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(91, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 406;
            this.uiLabel1.Text = "用户账号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(37, 115);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(91, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 408;
            this.uiLabel2.Text = "用户密码：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(37, 155);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(91, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 410;
            this.uiLabel3.Text = "确认密码：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(37, 195);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(91, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 412;
            this.uiLabel4.Text = "身份类型：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(37, 234);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(91, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 415;
            this.uiLabel5.Text = "创建时间：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRegister.Location = new System.Drawing.Point(711, 11);
            this.btnRegister.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.Style = Sunny.UI.UIStyle.Custom;
            this.btnRegister.TabIndex = 417;
            this.btnRegister.Text = "确定注册";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(591, 11);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.TabIndex = 418;
            this.btnCancel.Text = "取消重置";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.White;
            this.uiGroupBox1.Controls.Add(this.uiImageButton2);
            this.uiGroupBox1.Controls.Add(this.uiTextBox1);
            this.uiGroupBox1.Controls.Add(this.txt_Name);
            this.uiGroupBox1.Controls.Add(this.uiLabel6);
            this.uiGroupBox1.Controls.Add(this.dp_CreaterTime);
            this.uiGroupBox1.Controls.Add(this.cmbIdentity_Type);
            this.uiGroupBox1.Controls.Add(this.txt_PwdSure);
            this.uiGroupBox1.Controls.Add(this.txt_PassWord);
            this.uiGroupBox1.Controls.Add(this.txt_UserName);
            this.uiGroupBox1.Controls.Add(this.txt_Email);
            this.uiGroupBox1.Controls.Add(this.uiLabel10);
            this.uiGroupBox1.Controls.Add(this.txt_Phone);
            this.uiGroupBox1.Controls.Add(this.uiLabel9);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.FillColor = System.Drawing.Color.White;
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(422, 51);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.Gray;
            this.uiGroupBox1.Size = new System.Drawing.Size(389, 430);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 419;
            this.uiGroupBox1.Text = "用户注册";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.BackColor = System.Drawing.Color.White;
            this.uiGroupBox2.Controls.Add(this.uiLabel8);
            this.uiGroupBox2.Controls.Add(this.uiLabel7);
            this.uiGroupBox2.Controls.Add(this.txt_Resume);
            this.uiGroupBox2.Controls.Add(this.uiButton1);
            this.uiGroupBox2.Controls.Add(this.uiImageButton1);
            this.uiGroupBox2.FillColor = System.Drawing.Color.White;
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(13, 51);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.Gray;
            this.uiGroupBox2.Size = new System.Drawing.Size(401, 430);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox2.TabIndex = 420;
            this.uiGroupBox2.Text = "用户注册";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.BackColor = System.Drawing.SystemColors.Menu;
            this.uiImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton1.Location = new System.Drawing.Point(52, 42);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(149, 114);
            this.uiImageButton1.TabIndex = 0;
            this.uiImageButton1.TabStop = false;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(207, 121);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 419;
            this.uiButton1.Text = "头像上传";
            // 
            // txt_Resume
            // 
            this.txt_Resume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Resume.FillColor = System.Drawing.Color.White;
            this.txt_Resume.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Resume.Location = new System.Drawing.Point(52, 181);
            this.txt_Resume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Resume.Maximum = 2147483647D;
            this.txt_Resume.Minimum = -2147483648D;
            this.txt_Resume.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Resume.Multiline = true;
            this.txt_Resume.Name = "txt_Resume";
            this.txt_Resume.RectColor = System.Drawing.Color.Gray;
            this.txt_Resume.Size = new System.Drawing.Size(333, 231);
            this.txt_Resume.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Resume.TabIndex = 420;
            this.txt_Resume.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(13, 181);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(33, 231);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 417;
            this.uiLabel7.Text = "简介";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel8.Location = new System.Drawing.Point(13, 42);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(33, 114);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 421;
            this.uiLabel8.Text = "头像";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.FillColor = System.Drawing.Color.White;
            this.txt_Phone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Phone.Location = new System.Drawing.Point(135, 310);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Phone.Maximum = 2147483647D;
            this.txt_Phone.Minimum = -2147483648D;
            this.txt_Phone.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_Phone.Size = new System.Drawing.Size(215, 29);
            this.txt_Phone.Style = Sunny.UI.UIStyle.Gray;
            this.txt_Phone.TabIndex = 411;
            this.txt_Phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel9.Location = new System.Drawing.Point(37, 311);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(91, 23);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 410;
            this.uiLabel9.Text = "联系电话：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Email
            // 
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.FillColor = System.Drawing.Color.White;
            this.txt_Email.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Email.Location = new System.Drawing.Point(135, 271);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Email.Maximum = 2147483647D;
            this.txt_Email.Minimum = -2147483648D;
            this.txt_Email.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_Email.Size = new System.Drawing.Size(215, 29);
            this.txt_Email.Style = Sunny.UI.UIStyle.Gray;
            this.txt_Email.TabIndex = 413;
            this.txt_Email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel10.Location = new System.Drawing.Point(37, 272);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(91, 23);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 412;
            this.uiLabel10.Text = "E - Mail ：";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.Location = new System.Drawing.Point(5, 17);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(81, 23);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 417;
            this.uiLabel11.Text = "当前时间：";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labNowTime
            // 
            this.labNowTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNowTime.Location = new System.Drawing.Point(75, 17);
            this.labNowTime.Name = "labNowTime";
            this.labNowTime.Size = new System.Drawing.Size(299, 23);
            this.labNowTime.Style = Sunny.UI.UIStyle.Custom;
            this.labNowTime.TabIndex = 419;
            this.labNowTime.Text = "当前时间";
            this.labNowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.FillColor = System.Drawing.Color.White;
            this.txt_UserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_UserName.Location = new System.Drawing.Point(135, 75);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UserName.Maximum = 2147483647D;
            this.txt_UserName.Minimum = -2147483648D;
            this.txt_UserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_UserName.Size = new System.Drawing.Size(215, 29);
            this.txt_UserName.Style = Sunny.UI.UIStyle.Custom;
            this.txt_UserName.TabIndex = 412;
            this.txt_UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PassWord.FillColor = System.Drawing.Color.White;
            this.txt_PassWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_PassWord.Location = new System.Drawing.Point(135, 114);
            this.txt_PassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PassWord.Maximum = 2147483647D;
            this.txt_PassWord.Minimum = -2147483648D;
            this.txt_PassWord.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '●';
            this.txt_PassWord.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_PassWord.Size = new System.Drawing.Size(215, 29);
            this.txt_PassWord.Style = Sunny.UI.UIStyle.Custom;
            this.txt_PassWord.TabIndex = 413;
            this.txt_PassWord.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_PwdSure
            // 
            this.txt_PwdSure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PwdSure.FillColor = System.Drawing.Color.White;
            this.txt_PwdSure.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_PwdSure.Location = new System.Drawing.Point(135, 154);
            this.txt_PwdSure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PwdSure.Maximum = 2147483647D;
            this.txt_PwdSure.Minimum = -2147483648D;
            this.txt_PwdSure.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_PwdSure.Name = "txt_PwdSure";
            this.txt_PwdSure.PasswordChar = '●';
            this.txt_PwdSure.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_PwdSure.Size = new System.Drawing.Size(215, 29);
            this.txt_PwdSure.Style = Sunny.UI.UIStyle.Custom;
            this.txt_PwdSure.TabIndex = 413;
            this.txt_PwdSure.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dp_CreaterTime
            // 
            this.dp_CreaterTime.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dp_CreaterTime.FillColor = System.Drawing.Color.White;
            this.dp_CreaterTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_CreaterTime.Location = new System.Drawing.Point(135, 232);
            this.dp_CreaterTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_CreaterTime.MaxLength = 10;
            this.dp_CreaterTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_CreaterTime.Name = "dp_CreaterTime";
            this.dp_CreaterTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_CreaterTime.RectColor = System.Drawing.Color.Gray;
            this.dp_CreaterTime.Size = new System.Drawing.Size(215, 29);
            this.dp_CreaterTime.Style = Sunny.UI.UIStyle.Custom;
            this.dp_CreaterTime.SymbolDropDown = 61555;
            this.dp_CreaterTime.SymbolNormal = 61555;
            this.dp_CreaterTime.TabIndex = 425;
            this.dp_CreaterTime.Text = "2022-04-08";
            this.dp_CreaterTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_CreaterTime.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            // 
            // cmbIdentity_Type
            // 
            this.cmbIdentity_Type.DataSource = null;
            this.cmbIdentity_Type.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbIdentity_Type.FillColor = System.Drawing.Color.White;
            this.cmbIdentity_Type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbIdentity_Type.Location = new System.Drawing.Point(135, 193);
            this.cmbIdentity_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIdentity_Type.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbIdentity_Type.Name = "cmbIdentity_Type";
            this.cmbIdentity_Type.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbIdentity_Type.RectColor = System.Drawing.Color.Gray;
            this.cmbIdentity_Type.Size = new System.Drawing.Size(215, 29);
            this.cmbIdentity_Type.Style = Sunny.UI.UIStyle.Custom;
            this.cmbIdentity_Type.TabIndex = 424;
            this.cmbIdentity_Type.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Name
            // 
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.FillColor = System.Drawing.Color.White;
            this.txt_Name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_Name.Location = new System.Drawing.Point(135, 36);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Maximum = 2147483647D;
            this.txt_Name.Minimum = -2147483648D;
            this.txt_Name.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txt_Name.Size = new System.Drawing.Size(215, 29);
            this.txt_Name.Style = Sunny.UI.UIStyle.Custom;
            this.txt_Name.TabIndex = 414;
            this.txt_Name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(37, 37);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(91, 23);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 413;
            this.uiLabel6.Text = "用户昵称：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(135, 366);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiTextBox1.Size = new System.Drawing.Size(106, 29);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox1.TabIndex = 412;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "请输入验证码";
            // 
            // uiImageButton2
            // 
            this.uiImageButton2.BackColor = System.Drawing.SystemColors.Menu;
            this.uiImageButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiImageButton2.Location = new System.Drawing.Point(248, 347);
            this.uiImageButton2.Name = "uiImageButton2";
            this.uiImageButton2.Size = new System.Drawing.Size(102, 65);
            this.uiImageButton2.TabIndex = 422;
            this.uiImageButton2.TabStop = false;
            // 
            // AccountRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 548);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitle);
            this.Name = "AccountRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账号注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountRegister_FormClosing);
            this.Load += new System.EventHandler(this.AccountRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountRegister_KeyDown);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labtext;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton btnRegister;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox txt_Resume;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox txt_Phone;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txt_Email;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel labNowTime;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UITextBox txt_UserName;
        private Sunny.UI.UITextBox txt_PassWord;
        private Sunny.UI.UITextBox txt_PwdSure;
        private Sunny.UI.UIDatePicker dp_CreaterTime;
        private Sunny.UI.UIComboBox cmbIdentity_Type;
        private Sunny.UI.UITextBox txt_Name;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIImageButton uiImageButton2;
    }
}