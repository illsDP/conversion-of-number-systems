using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zack
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);           
            Logion Logion = new Logion();
            DialogResult result = Logion.ShowDialog();
            if (result == DialogResult.OK)
            {
                string loginName = Logion.Text;
                Main Main = new Zack.Main();
                Application.Run(Main);
            }
            
        }
    }
}
