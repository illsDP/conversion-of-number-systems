
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
    public partial class Main : UIForm
    {
        public Main()
        {
            InitializeComponent();
        }

        Setting Setting;
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tspSetting_Click(object sender, EventArgs e)
        {
            // if variable 'Setting' is null, then new Setting();

            try
            {
                if (Setting == null || Setting.IsDisposed)
                {
                    Setting = new Setting();
                    Setting.Show();
                    Setting.MdiParent = this;
                }

            }
            catch (Exception ee)
            {

                throw;
            }

        }

        private void 委托ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting = new Setting();
            Setting.event_txt += new Setting.delegate_txt(change_delegate);
            Setting.Show();
            Setting.MdiParent = this;
        }
        public string change_delegate(string txt)
        {
           // 委托ToolStripMenuItem.Text = txt;
            return null;
        }
        /// <summary>
        /// 缓存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmlCache_Click(object sender, EventArgs e)
        {
           
        }

        private void tlsMenuItemPlan_Click(object sender, EventArgs e)
        {
            Plan Plan = new Plan();
            Plan.Show();
            //Plan.MdiParent = this;
        }
    }
}
