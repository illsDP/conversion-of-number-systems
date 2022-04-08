using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Zack
{
    public class CssStyleRewrite
    {
        #region 窗体移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        #endregion




        /// <summary>
        /// 底部下划线重绘
        /// </summary>
        /// <param name="e"></param>
        /// <param name="panel"></param>
        public static void panelPaintBottom(PaintEventArgs e, Panel panel)
        {
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
            Color.White, 1, ButtonBorderStyle.None, //左边
                 Color.White, 1, ButtonBorderStyle.None, //上边
                 Color.DimGray, 1, ButtonBorderStyle.None, //右边
                 Color.FromArgb(204, 204, 204), 1, ButtonBorderStyle.Solid);//底边
        }

        /// <summary>
        /// 顶部下划线重绘
        /// </summary>
        /// <param name="e"></param>
        /// <param name="panel"></param>
        public static void panelPaintTop(PaintEventArgs e, Panel panel)
        {
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
            Color.White, 1, ButtonBorderStyle.None, //左边
                 Color.FromArgb(204, 204, 204), 1, ButtonBorderStyle.Solid, //上边
                 Color.DimGray, 1, ButtonBorderStyle.None, //右边
                 Color.White, 1, ButtonBorderStyle.None);//底边
        }
    }
}
