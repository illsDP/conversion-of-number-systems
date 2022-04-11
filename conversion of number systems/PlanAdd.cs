using Sunny.UI;
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
    public partial class PlanAdd : UIForm
    {
        public PlanAdd()
        {
            InitializeComponent();
        }
        string strSql = null;
        private void PlanAdd_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> cacheDic = new Dictionary<string, object>();
            cacheDic = AuthCacheHelper.cacheInfo;
            cmb_Operator.Items.Add(cacheDic["name"]);
            cmb_Operator.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EntryName.Text.Trim()))
            {
                MeassgeBoxUIPage.UIPageWarning("这项目叫啥？!");
                return;
            }
            if (string.IsNullOrEmpty(cmb_Operator.Text.Trim()))
            {
                MeassgeBoxUIPage.UIPageWarning("做项目的人都没？!");
                return;
            }
            if (string.IsNullOrEmpty(dp_CreaterTIme.Text.Trim()))
            {
                MeassgeBoxUIPage.UIPageWarning(cmb_Operator.Text.Trim() + "啥时候做的项目？!");
                return;
            }
            if (string.IsNullOrEmpty(txt_EntryContent.Text.Trim()))
            {
                MeassgeBoxUIPage.UIPageWarning(cmb_Operator.Text.Trim() + "做项目的目的是啥？!");
                return;
            }
            if (entry_State.Active)
            {
                entry_State.Text = "未完成";
            }
            else
            {
                entry_State.Text = "已完成";
            }
            strSql = "insert into zack_plan set entry_name='" + txt_EntryName.Text.Trim() + "',entry_operator='" + cmb_Operator.Text.Trim() + "',entry_creatertime='" + dp_CreaterTIme.Text.Trim() + "',entry_content='" + txt_EntryContent.Text.Trim() + "' ,entry_state='" + entry_State.Text + "'";
            int result = MySqlDBHelp.Execute(strSql);
            if (result > 0)
            {
                MeassgeBoxUIPage.UIPageSuccessNotifier("项目添加成功!");           
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_EntryName.Text = "";
            txt_EntryContent.Text = "";
        }
    }
}
