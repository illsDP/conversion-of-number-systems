
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zack
{
    public partial class AccountRegister : SkinMain
    {
        string strSql = null;
        DataTable dt = null;
        public AccountRegister()
        {
            InitializeComponent();
            timer1.Start();
            this.labtext.Text = "当前用户【】-项目集成功能【账号注册】";
        }

        private void AccountRegister_Load(object sender, EventArgs e)
        {
            strSql = "select dic_value,dic_key from zack_dictionary where dic_type='A'";
            string[] arryDt = (MySqlDBHelp.getTable(strSql)).AsEnumerable().Select(t => t.Field<string>("dic_value").ToString()).ToArray();
            if (arryDt.Length > 0)
            {
                cmbIdentity_Type.Clear();
                foreach (var item in arryDt)
                {
                    cmbIdentity_Type.Items.Add(item);
                }
                cmbIdentity_Type.SelectedIndex = 2;
            }
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Name.Text))
                {
                    MeassgeBoxUIPage.UIPageWarning("昵称不能为空啊!");
                    return;
                }
                if (string.IsNullOrEmpty(txt_UserName.Text))
                {
                    MeassgeBoxUIPage.UIPageWarning("用户名不能为空啊!");
                    return;
                }
                if (string.IsNullOrEmpty(txt_PassWord.Text))
                {
                    MeassgeBoxUIPage.UIPageWarning("密码要输入啊!");
                    return;
                }
                if (string.IsNullOrEmpty(txt_PwdSure.Text))
                {
                    MeassgeBoxUIPage.UIPageWarning("第二次密码也要输入啊!");
                    return;
                }
                //if (string.IsNullOrEmpty(cmbIdentity_Type.Text))
                //{
                //    MeassgeBoxUIPage.UIPageWarning("选个身份才能体面!");
                //    return;
                //}
                if (!txt_PwdSure.Text.Equals(txt_PassWord.Text))
                {
                    MeassgeBoxUIPage.UIPageWarning("很明显,两次输入的密码都不一样");
                    return;
                }
                strSql = "select * from zack_user where  user='" + txt_UserName.Text + "'";
                string[] arryDt = (MySqlDBHelp.getTable(strSql)).AsEnumerable().Select(t => t.Field<string>("user").ToString()).ToArray();
                if (arryDt.Length > 0)
                {
                    MeassgeBoxUIPage.UIPageWarning("【" + txt_UserName.Text + "】此用户已存在");
                    return;
                }
                strSql = "insert into zack_user set user='" + txt_UserName.Text + "',name='" + txt_Name.Text + "',password='" + txt_PassWord.Text + "',creatertime='" + dp_CreaterTime.Text + "',type='" + (int)(cmbIdentity_Type.SelectedIndex + 1) + "',resume='" + txt_Resume.Text + "',email='" + txt_Email.Text + "',phone='" + txt_Phone.Text + "'";
                int result = MySqlDBHelp.Execute(strSql);
                if (result > 0)
                {
                    MeassgeBoxUIPage.UIPageSuccessNotifier("注册成功!");
                }
            }
            catch (Exception)
            {

                // throw;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_UserName.Text = "";
            txt_PassWord.Text = "";
            txt_PwdSure.Text = "";
            txt_Resume.Text = "";
            txt_Email.Text = "";
            txt_Phone.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labNowTime.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void AccountRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void AccountRegister_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Interval = 1000;
        }
    }
}
