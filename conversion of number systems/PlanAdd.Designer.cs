
namespace Zack
{
    partial class PlanAdd
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
            this.txt_EntryName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cmb_Operator = new Sunny.UI.UIComboBox();
            this.txt_EntryContent = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.dp_CreaterTIme = new Sunny.UI.UIDatePicker();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnClear = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.btnOk = new Sunny.UI.UISymbolButton();
            this.entry_State = new Sunny.UI.UISwitch();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_EntryName
            // 
            this.txt_EntryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EntryName.EnterAsTab = true;
            this.txt_EntryName.FillColor = System.Drawing.Color.White;
            this.txt_EntryName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_EntryName.Location = new System.Drawing.Point(126, 62);
            this.txt_EntryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_EntryName.Maximum = 2147483647D;
            this.txt_EntryName.Minimum = -2147483648D;
            this.txt_EntryName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_EntryName.Name = "txt_EntryName";
            this.txt_EntryName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_EntryName.Size = new System.Drawing.Size(556, 29);
            this.txt_EntryName.TabIndex = 7;
            this.txt_EntryName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(32, 66);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 21);
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "功能名称";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(32, 105);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(68, 21);
            this.uiLabel5.TabIndex = 14;
            this.uiLabel5.Text = "操 作 人";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Operator
            // 
            this.cmb_Operator.DataSource = null;
            this.cmb_Operator.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmb_Operator.FillColor = System.Drawing.Color.White;
            this.cmb_Operator.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmb_Operator.Location = new System.Drawing.Point(126, 101);
            this.cmb_Operator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Operator.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmb_Operator.Name = "cmb_Operator";
            this.cmb_Operator.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmb_Operator.Size = new System.Drawing.Size(556, 29);
            this.cmb_Operator.TabIndex = 13;
            this.cmb_Operator.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_EntryContent
            // 
            this.txt_EntryContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_EntryContent.EnterAsTab = true;
            this.txt_EntryContent.FillColor = System.Drawing.Color.White;
            this.txt_EntryContent.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_EntryContent.Location = new System.Drawing.Point(126, 214);
            this.txt_EntryContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_EntryContent.Maximum = 2147483647D;
            this.txt_EntryContent.Minimum = -2147483648D;
            this.txt_EntryContent.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_EntryContent.Multiline = true;
            this.txt_EntryContent.Name = "txt_EntryContent";
            this.txt_EntryContent.Padding = new System.Windows.Forms.Padding(5);
            this.txt_EntryContent.Size = new System.Drawing.Size(556, 71);
            this.txt_EntryContent.TabIndex = 9;
            this.txt_EntryContent.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(32, 214);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(74, 21);
            this.uiLabel4.TabIndex = 10;
            this.uiLabel4.Text = "功能描述";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dp_CreaterTIme
            // 
            this.dp_CreaterTIme.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.dp_CreaterTIme.FillColor = System.Drawing.Color.White;
            this.dp_CreaterTIme.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_CreaterTIme.Location = new System.Drawing.Point(126, 140);
            this.dp_CreaterTIme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_CreaterTIme.MaxLength = 10;
            this.dp_CreaterTIme.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_CreaterTIme.Name = "dp_CreaterTIme";
            this.dp_CreaterTIme.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_CreaterTIme.Size = new System.Drawing.Size(556, 29);
            this.dp_CreaterTIme.SymbolDropDown = 61555;
            this.dp_CreaterTIme.SymbolNormal = 61555;
            this.dp_CreaterTIme.TabIndex = 15;
            this.dp_CreaterTIme.Text = "2020-05-08";
            this.dp_CreaterTIme.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_CreaterTIme.Value = new System.DateTime(2020, 5, 8, 0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(32, 144);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(74, 21);
            this.uiLabel6.TabIndex = 16;
            this.uiLabel6.Text = "创建时间";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel1.Controls.Add(this.btnClear);
            this.uiPanel1.Controls.Add(this.btnCancel);
            this.uiPanel1.Controls.Add(this.btnOk);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 320);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(728, 58);
            this.uiPanel1.TabIndex = 17;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClear.Location = new System.Drawing.Point(332, 13);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Symbol = 61462;
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "重置";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(582, 13);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnOk.Location = new System.Drawing.Point(458, 13);
            this.btnOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.Symbol = 61639;
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // entry_State
            // 
            this.entry_State.ActiveText = "已完成";
            this.entry_State.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.entry_State.InActiveText = "未完成";
            this.entry_State.Location = new System.Drawing.Point(126, 177);
            this.entry_State.MinimumSize = new System.Drawing.Size(1, 1);
            this.entry_State.Name = "entry_State";
            this.entry_State.Size = new System.Drawing.Size(93, 29);
            this.entry_State.SwitchShape = Sunny.UI.UISwitch.UISwitchShape.Square;
            this.entry_State.TabIndex = 436;
            this.entry_State.Text = "关闭";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(32, 180);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(74, 21);
            this.uiLabel2.TabIndex = 435;
            this.uiLabel2.Text = "是否开启";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlanAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 378);
            this.Controls.Add(this.entry_State);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.dp_CreaterTIme);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.txt_EntryContent);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.cmb_Operator);
            this.Controls.Add(this.txt_EntryName);
            this.Controls.Add(this.uiLabel1);
            this.Name = "PlanAdd";
            this.Text = "功能添加";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlanAdd_FormClosed);
            this.Load += new System.EventHandler(this.PlanAdd_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox txt_EntryName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cmb_Operator;
        private Sunny.UI.UITextBox txt_EntryContent;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIDatePicker dp_CreaterTIme;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UISymbolButton btnOk;
        private Sunny.UI.UISymbolButton btnCancel;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UISwitch entry_State;
        private Sunny.UI.UILabel uiLabel2;
    }
}