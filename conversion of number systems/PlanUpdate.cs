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
    public partial class PlanUpdate : UIForm
    {
        string strSql = null;
        DataTable dt = null;
        public PlanUpdate()
        {
            InitializeComponent();
        }

        private void PlanUpdate_Load(object sender, EventArgs e)
        {
            txt_EntryName.Text = MessageCls.entryInfo.entry_name;
            dp_CreaterTime.Value = MessageCls.entryInfo.entry_creatertime;
            cmb_Operator.Text = MessageCls.entryInfo.entry_operator;
            txt_EntryContent.Text = MessageCls.entryInfo.entry_content;
            if (MessageCls.entryInfo.entry_state.Equals("已完成"))
            {
                entry_State.Active = true;
            }
            else
            {
                entry_State.Active = false;
            }            
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
            if (string.IsNullOrEmpty(dp_CreaterTime.Text.Trim()))
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
            strSql = "update zack_plan set entry_name='" + txt_EntryName.Text + "',entry_operator='" + cmb_Operator.Text + "',entry_creatertime='" + dp_CreaterTime.Text + "',entry_content='" + txt_EntryContent.Text + "' ,entry_state='" + entry_State.Text + "'  where  id='" + MessageCls.entryInfo.entry_id + "'";
            int result = MySqlDBHelp.Execute(strSql);
            if (result > 0)
            {
                MeassgeBoxUIPage.UIPageSuccessNotifier("项目修改成功!");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
