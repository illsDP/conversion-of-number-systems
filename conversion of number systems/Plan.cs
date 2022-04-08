

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zack
{
    public partial class Plan : SkinMain
    {

        public Plan()
        {
            InitializeComponent();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
            CssStyleRewrite.panelPaintBottom(e, panelTitle);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            CssStyleRewrite.ReleaseCapture();
            CssStyleRewrite.SendMessage(this.Handle, CssStyleRewrite.WM_SYSCOMMAND, CssStyleRewrite.SC_MOVE + CssStyleRewrite.HTCAPTION, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            CssStyleRewrite.panelPaintTop(e, panel3);
        }

        private void Plan_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Plan_Load(object sender, EventArgs e)
        {
            //MySqlDBHelp.Execute("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable dt = null;
            string strSql = null;
            strSql = "select id,user,name, from zack_user";
            dt = MySqlDBHelp.getTable(strSql);
            dt.AsEnumerable().Select(t => t.Field<string>("列名").ToString()).ToArray();
            if (string.IsNullOrEmpty(txt_EntryName.Text))
            {
                MeassgeBoxUIPage.UIPageWarning("这项目叫啥？!");
            }
            if (string.IsNullOrEmpty(cmb_Operator.Text))
            {
                MeassgeBoxUIPage.UIPageWarning("做项目的人都没？!");
            }
            if (string.IsNullOrEmpty(dpiker_CreaterTime.Text))
            {
                MeassgeBoxUIPage.UIPageWarning(cmb_Operator.Text + "啥时候做的项目？!");
            }
            if (string.IsNullOrEmpty(txt_EntryContent.Text))
            {
                MeassgeBoxUIPage.UIPageWarning(cmb_Operator.Text + "做项目的目的是啥？!");
            }
            strSql = "insert into zack_plan set entry_name='" + txt_EntryName.Text + "',entry_operator='" + cmb_Operator.Text + "',entry_creatertime='" + dpiker_CreaterTime.Text + "',entry_content='" + txt_EntryContent.Text + "'";
        }
    }
}
