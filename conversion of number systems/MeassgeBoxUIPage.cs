using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zack
{
    public class MeassgeBoxUIPage
    {

        public static UIPage UIPage = new UIPage();
        /// <summary>
        /// 正确提示
        /// </summary>
        /// <param name="Msg"></param>
        public static void UIPageSuccess(string Msg)
        {
            UIPage.ShowSuccessTip(Msg);
        }
        /// <summary>
        /// 警告提示
        /// </summary>
        /// <param name="Msg"></param>
        public static void UIPageWarning(string Msg)
        {
            UIPage.ShowWarningTip(Msg);
        }
        /// <summary>
        /// 错误提示
        /// </summary>
        /// <param name="Msg"></param>
        public static void UIPageError(string Msg)
        {
            UIPage.ShowErrorTip(Msg);
        }
        /// <summary>
        /// 正确提示右下框
        /// </summary>
        /// <param name="Msg"></param>
        public static void UIPageSuccessNotifier(string Msg)
        {
            UIPage.ShowSuccessNotifier(Msg,false,5000);
        }
        /// <summary>
        /// 错误提示右下框
        /// </summary>
        /// <param name="Msg"></param>
        public static void UIPageErrorNotifier(string Msg)
        {
            UIPage.ShowErrorNotifier(Msg, false, 5000);
        }
    }
}
