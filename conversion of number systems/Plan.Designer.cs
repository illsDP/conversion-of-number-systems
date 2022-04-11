namespace Zack
{
    partial class Plan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plan));
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.udhChart = new Sunny.UI.UIPieChart();
            this.processBar = new Sunny.UI.UIProcessBar();
            this.uiLine11 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.dpiker_CreaterTime = new Sunny.UI.UIDatePicker();
            this.cmb_Operator = new Sunny.UI.UIComboBox();
            this.txt_EntryContent = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txt_EntryId = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.utfList = new Sunny.UI.UITransfer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmb_EntryName = new Sunny.UI.UIComboBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.entry_State = new Sunny.UI.UISwitch();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.btnUpdate = new Sunny.UI.UISymbolButton();
            this.btnDelete = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.btnWork = new Sunny.UI.UIButton();
            this.btnNoWork = new Sunny.UI.UIButton();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(874, 645);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolButton2.Size = new System.Drawing.Size(100, 27);
            this.uiSymbolButton2.Symbol = 61473;
            this.uiSymbolButton2.TabIndex = 426;
            this.uiSymbolButton2.Text = "更新";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(668, 645);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 27);
            this.uiSymbolButton1.Symbol = 61952;
            this.uiSymbolButton1.TabIndex = 425;
            this.uiSymbolButton1.Text = "数据";
            // 
            // udhChart
            // 
            this.udhChart.FillColor = System.Drawing.Color.White;
            this.udhChart.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.udhChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.udhChart.Location = new System.Drawing.Point(665, 381);
            this.udhChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.udhChart.Name = "udhChart";
            this.udhChart.Size = new System.Drawing.Size(309, 258);
            this.udhChart.Style = Sunny.UI.UIStyle.Custom;
            this.udhChart.TabIndex = 424;
            this.udhChart.Text = "uiPieChart1";
            // 
            // processBar
            // 
            this.processBar.DecimalCount = 2;
            this.processBar.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.processBar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.processBar.Location = new System.Drawing.Point(980, 381);
            this.processBar.MinimumSize = new System.Drawing.Size(70, 1);
            this.processBar.Name = "processBar";
            this.processBar.Radius = 50;
            this.processBar.Size = new System.Drawing.Size(193, 258);
            this.processBar.Step = 50;
            this.processBar.Style = Sunny.UI.UIStyle.Custom;
            this.processBar.TabIndex = 423;
            this.processBar.Value = 50;
            // 
            // uiLine11
            // 
            this.uiLine11.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine11.FillColor = System.Drawing.Color.White;
            this.uiLine11.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine11.LineColor = System.Drawing.Color.Gray;
            this.uiLine11.Location = new System.Drawing.Point(608, 359);
            this.uiLine11.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine11.Name = "uiLine11";
            this.uiLine11.Size = new System.Drawing.Size(51, 326);
            this.uiLine11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine11.TabIndex = 422;
            this.uiLine11.Text = "uiLine11";
            this.uiLine11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.White;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine2.LineColor = System.Drawing.Color.Gray;
            this.uiLine2.Location = new System.Drawing.Point(16, 349);
            this.uiLine2.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(1157, 20);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 421;
            this.uiLine2.Text = "功能列表";
            this.uiLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpiker_CreaterTime
            // 
            this.dpiker_CreaterTime.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dpiker_CreaterTime.FillColor = System.Drawing.Color.White;
            this.dpiker_CreaterTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dpiker_CreaterTime.Location = new System.Drawing.Point(121, 192);
            this.dpiker_CreaterTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpiker_CreaterTime.MaxLength = 10;
            this.dpiker_CreaterTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpiker_CreaterTime.Name = "dpiker_CreaterTime";
            this.dpiker_CreaterTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpiker_CreaterTime.RectColor = System.Drawing.Color.Gray;
            this.dpiker_CreaterTime.Size = new System.Drawing.Size(1052, 29);
            this.dpiker_CreaterTime.Style = Sunny.UI.UIStyle.Custom;
            this.dpiker_CreaterTime.SymbolDropDown = 61555;
            this.dpiker_CreaterTime.SymbolNormal = 61555;
            this.dpiker_CreaterTime.TabIndex = 420;
            this.dpiker_CreaterTime.Text = "2022-04-08";
            this.dpiker_CreaterTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpiker_CreaterTime.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            // 
            // cmb_Operator
            // 
            this.cmb_Operator.DataSource = null;
            this.cmb_Operator.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_Operator.FillColor = System.Drawing.Color.White;
            this.cmb_Operator.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_Operator.Location = new System.Drawing.Point(121, 153);
            this.cmb_Operator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Operator.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_Operator.Name = "cmb_Operator";
            this.cmb_Operator.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_Operator.RectColor = System.Drawing.Color.Gray;
            this.cmb_Operator.Size = new System.Drawing.Size(1052, 29);
            this.cmb_Operator.Style = Sunny.UI.UIStyle.Custom;
            this.cmb_Operator.TabIndex = 419;
            this.cmb_Operator.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_EntryContent
            // 
            this.txt_EntryContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EntryContent.EnterAsTab = true;
            this.txt_EntryContent.FillColor = System.Drawing.Color.White;
            this.txt_EntryContent.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_EntryContent.Location = new System.Drawing.Point(121, 266);
            this.txt_EntryContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_EntryContent.Maximum = 2147483647D;
            this.txt_EntryContent.Minimum = -2147483648D;
            this.txt_EntryContent.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_EntryContent.Multiline = true;
            this.txt_EntryContent.Name = "txt_EntryContent";
            this.txt_EntryContent.Padding = new System.Windows.Forms.Padding(5);
            this.txt_EntryContent.RectColor = System.Drawing.Color.Gray;
            this.txt_EntryContent.Size = new System.Drawing.Size(1052, 55);
            this.txt_EntryContent.Style = Sunny.UI.UIStyle.Custom;
            this.txt_EntryContent.TabIndex = 418;
            this.txt_EntryContent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(27, 271);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(90, 21);
            this.uiLabel5.TabIndex = 417;
            this.uiLabel5.Text = "功能描述：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(26, 192);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(90, 21);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 415;
            this.uiLabel4.Text = "立项时间：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(27, 153);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(89, 21);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 415;
            this.uiLabel3.Text = "操  作 人：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_EntryId
            // 
            this.txt_EntryId.CanEmpty = true;
            this.txt_EntryId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EntryId.Enabled = false;
            this.txt_EntryId.FillColor = System.Drawing.Color.White;
            this.txt_EntryId.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_EntryId.Location = new System.Drawing.Point(121, 75);
            this.txt_EntryId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_EntryId.Maximum = 9D;
            this.txt_EntryId.Minimum = 0D;
            this.txt_EntryId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_EntryId.Name = "txt_EntryId";
            this.txt_EntryId.Padding = new System.Windows.Forms.Padding(5);
            this.txt_EntryId.RectColor = System.Drawing.Color.Gray;
            this.txt_EntryId.Size = new System.Drawing.Size(221, 29);
            this.txt_EntryId.Style = Sunny.UI.UIStyle.Custom;
            this.txt_EntryId.TabIndex = 413;
            this.txt_EntryId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_EntryId.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(27, 116);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(90, 21);
            this.uiLabel2.TabIndex = 412;
            this.uiLabel2.Text = "功能名称：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(27, 75);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(90, 21);
            this.uiLabel1.TabIndex = 411;
            this.uiLabel1.Text = "功 能  ID：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.White;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.Gray;
            this.uiLine1.Location = new System.Drawing.Point(16, 47);
            this.uiLine1.MinimumSize = new System.Drawing.Size(16, 16);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(1157, 20);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 410;
            this.uiLine1.Text = "添加列表";
            this.uiLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // utfList
            // 
            this.utfList.BackColor = System.Drawing.Color.Gray;
            this.utfList.FillColor = System.Drawing.Color.White;
            this.utfList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utfList.Location = new System.Drawing.Point(31, 413);
            this.utfList.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.utfList.MinimumSize = new System.Drawing.Size(1, 1);
            this.utfList.Name = "utfList";
            this.utfList.Padding = new System.Windows.Forms.Padding(1);
            this.utfList.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.utfList.RectColor = System.Drawing.Color.Gray;
            this.utfList.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.utfList.Size = new System.Drawing.Size(568, 259);
            this.utfList.Style = Sunny.UI.UIStyle.Custom;
            this.utfList.TabIndex = 409;
            this.utfList.Text = null;
            this.utfList.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.utfList.ItemsLeftCountChange += new System.EventHandler(this.utfList_ItemsLeftCountChange);
            this.utfList.ItemsRightCountChange += new System.EventHandler(this.utfList_ItemsRightCountChange);
            this.utfList.ItemAdd += new Sunny.UI.UITransfer.ItemChange(this.utfList_ItemAdd);
            this.utfList.ItemRemove += new Sunny.UI.UITransfer.ItemChange(this.utfList_ItemRemove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 685);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1188, 50);
            this.panel3.TabIndex = 407;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panelTitle.Controls.Add(this.label53);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1188, 40);
            this.panelTitle.TabIndex = 406;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label53.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(55)))), ((int)(((byte)(87)))));
            this.label53.Location = new System.Drawing.Point(13, 14);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(52, 14);
            this.label53.TabIndex = 585;
            this.label53.Text = "计划表";
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
            this.btnClose.Location = new System.Drawing.Point(1156, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmb_EntryName
            // 
            this.cmb_EntryName.DataSource = null;
            this.cmb_EntryName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_EntryName.FillColor = System.Drawing.Color.White;
            this.cmb_EntryName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_EntryName.Location = new System.Drawing.Point(121, 114);
            this.cmb_EntryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_EntryName.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_EntryName.Name = "cmb_EntryName";
            this.cmb_EntryName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_EntryName.RectColor = System.Drawing.Color.Gray;
            this.cmb_EntryName.Size = new System.Drawing.Size(1052, 29);
            this.cmb_EntryName.Style = Sunny.UI.UIStyle.Custom;
            this.cmb_EntryName.TabIndex = 420;
            this.cmb_EntryName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmb_EntryName.TextChanged += new System.EventHandler(this.cmb_EntryName_TextChanged);
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(27, 232);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(90, 21);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 431;
            this.uiLabel6.Text = "项目状态：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entry_State
            // 
            this.entry_State.ActiveText = "已完成";
            this.entry_State.Enabled = false;
            this.entry_State.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.entry_State.InActiveText = "未完成";
            this.entry_State.Location = new System.Drawing.Point(121, 229);
            this.entry_State.MinimumSize = new System.Drawing.Size(1, 1);
            this.entry_State.Name = "entry_State";
            this.entry_State.Size = new System.Drawing.Size(91, 29);
            this.entry_State.SwitchShape = Sunny.UI.UISwitch.UISwitchShape.Square;
            this.entry_State.TabIndex = 432;
            this.entry_State.Text = "uiSwitch1";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAdd.Location = new System.Drawing.Point(774, 71);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 35);
            this.btnAdd.Style = Sunny.UI.UIStyle.Custom;
            this.btnAdd.Symbol = 61543;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加新项";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(1044, 71);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 35);
            this.btnUpdate.Style = Sunny.UI.UIStyle.Custom;
            this.btnUpdate.Symbol = 61508;
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "编辑项目";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDelete.Location = new System.Drawing.Point(909, 71);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 35);
            this.btnDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelete.Symbol = 61809;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除旧项";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton4.Location = new System.Drawing.Point(639, 71);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.Size = new System.Drawing.Size(129, 35);
            this.uiSymbolButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton4.Symbol = 61473;
            this.uiSymbolButton4.TabIndex = 434;
            this.uiSymbolButton4.Text = "查询项目";
            this.uiSymbolButton4.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnWork
            // 
            this.btnWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWork.FillColor = System.Drawing.Color.White;
            this.btnWork.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnWork.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnWork.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnWork.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnWork.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnWork.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnWork.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnWork.Location = new System.Drawing.Point(506, 375);
            this.btnWork.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWork.Name = "btnWork";
            this.btnWork.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnWork.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnWork.ShowTips = true;
            this.btnWork.Size = new System.Drawing.Size(93, 35);
            this.btnWork.Style = Sunny.UI.UIStyle.White;
            this.btnWork.StyleCustomMode = true;
            this.btnWork.TabIndex = 437;
            this.btnWork.Text = "已完成";
            this.btnWork.TipsColor = System.Drawing.Color.ForestGreen;
            this.btnWork.TipsText = "16";
            // 
            // btnNoWork
            // 
            this.btnNoWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoWork.FillColor = System.Drawing.Color.White;
            this.btnNoWork.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnNoWork.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnNoWork.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnNoWork.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnNoWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnNoWork.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnNoWork.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnNoWork.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnNoWork.Location = new System.Drawing.Point(31, 375);
            this.btnNoWork.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNoWork.Name = "btnNoWork";
            this.btnNoWork.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnNoWork.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnNoWork.ShowTips = true;
            this.btnNoWork.Size = new System.Drawing.Size(88, 35);
            this.btnNoWork.Style = Sunny.UI.UIStyle.White;
            this.btnNoWork.StyleCustomMode = true;
            this.btnNoWork.TabIndex = 438;
            this.btnNoWork.Text = "待完成";
            this.btnNoWork.TipsText = "16";
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 735);
            this.Controls.Add(this.btnNoWork);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.uiSymbolButton4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.entry_State);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.cmb_EntryName);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.udhChart);
            this.Controls.Add(this.processBar);
            this.Controls.Add(this.uiLine11);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.dpiker_CreaterTime);
            this.Controls.Add(this.cmb_Operator);
            this.Controls.Add(this.txt_EntryContent);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txt_EntryId);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.utfList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitle);
            this.Name = "Plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Plan_FormClosing);
            this.Load += new System.EventHandler(this.Plan_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label53;
        private Sunny.UI.UITransfer utfList;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txt_EntryId;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txt_EntryContent;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cmb_Operator;
        private Sunny.UI.UIDatePicker dpiker_CreaterTime;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine11;
        private Sunny.UI.UIProcessBar processBar;
        private Sunny.UI.UIPieChart udhChart;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIComboBox cmb_EntryName;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UISwitch entry_State;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnUpdate;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UIButton btnWork;
        private Sunny.UI.UIButton btnNoWork;
    }
}