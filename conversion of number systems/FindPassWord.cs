using Zack;

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
    public partial class FindPassWord : SkinMain
    {
        public FindPassWord()
        {
            InitializeComponent();
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
    }
}
