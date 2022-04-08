
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zack
{
    public partial class Logion : SkinMain
    {
        AutoCompleteStringCollection lstsourece = new AutoCompleteStringCollection();
        Dictionary<string, object> ReadDic = new Dictionary<string, object>();
        public Logion()
        {

            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLogin.AutoCompleteCustomSource = lstsourece;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MeassgeBoxUIPage.UIPageWarning("用户名不能为空啊!");
                return;
            }
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {
                MeassgeBoxUIPage.UIPageWarning("密码要输入啊!");
                return;
            }

            string strSql = "select * from zack_user where  user='" + txtLogin.Text + "'";
            DataTable dt = MySqlDBHelp.getTable(strSql);
            string[] arryDt = null;
            //进行账号校验  
            if (dt.Rows.Count <= 0 && dt.Rows.Count > 1)
            {
                arryDt = dt.AsEnumerable().Select(t => t.Field<string>("user").ToString()).ToArray();
                if (arryDt.Length <= 0)
                {
                    MeassgeBoxUIPage.UIPageWarning("【" + txtLogin.Text + "】此用户不存在");
                    return;

                }
            }
            //进行密码校验  
            arryDt = dt.AsEnumerable().Select(t => t.Field<string>("password").ToString()).ToArray();
            if (arryDt.Length > 0)
            {
                if (!txtPassWord.Text.Equals(arryDt[0]))
                {
                    MeassgeBoxUIPage.UIPageWarning("很明显,密码错误!");
                    return;
                }
            }
            //个人信息缓存处理
            if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtPassWord.Text))
            {
                if (CkbPasssWord.Checked)
                {
                    Dictionary<string, object> addDic = new Dictionary<string, object>();
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            addDic.Add(col.ColumnName, row[col]);
                        }
                    }                  
                    //addDic.Add("用户账号", txtPassWord.Text);
                    //addDic.Add("用户密码", txtPassWord.Text);
                    //addDic.Add("用户权限", txtPassWord.Text);
                    //addDic.Add("用户等级", txtPassWord.Text);
                    //addDic.Add("使用时间", txtPassWord.Text);
                    //addDic.Add("注册时间", txtPassWord.Text);
                    //addDic.Add("联系方式", txtPassWord.Text);
                    //addDic.Add("E-Mail", txtPassWord.Text);
                    //addDic.Add("用户座右铭", txtPassWord.Text);
                    
                    //判断缓存中是否存在此账号密码，否则添加                   
                    ReadDic = AuthCacheHelper.ReadCache(txtLogin.Text);
                    if (ReadDic == null)
                    {
                        AuthCacheHelper.AddCache(addDic);
                    }
                    lstsourece.Add(txtLogin.Text);
                }
            }


            //主窗体加载
            Main main = new Main();
            this.Hide();
            main.ShowDialog();


        }
        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {


            ReadDic = AuthCacheHelper.ReadCache(txtLogin.Text);
            if (ReadDic != null && ReadDic.Count > 0)
            {
                object pwd = null;
                ReadDic.TryGetValue("password", out pwd);
                txtPassWord.Text = pwd.ToString();
            }
        }

        private void labRegister_Click(object sender, EventArgs e)
        {
            AccountRegister AccountRegister = new AccountRegister();
            AccountRegister.ShowDialog();

        }

        private void labFindPass_Click(object sender, EventArgs e)
        {
            FindPassWord FindPassWord = new FindPassWord();
            FindPassWord.ShowDialog();
        }

        #region 拖动窗体
        //拖动窗体
        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;


        private void Logion_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region 窗体圆角
        public void SetWindowRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(0, 50, this.Width, this.Height - 22);
            FormPath = GetRoundedRectPath(rect, 50);
            this.Region = new Region(FormPath);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            GraphicsPath path = new GraphicsPath();
            //   左上角   
            path.AddArc(arcRect, 180, 90);
            //   右上角   
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);
            //   右下角   
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);
            //   左下角   
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnResize(System.EventArgs e)
        {
            this.Region = null;
            SetWindowRegion();
        }

        #endregion

        #region 鼠标移动变色
        private void labRegister_MouseHover(object sender, EventArgs e)
        {
            labRegister.ForeColor = Color.Brown;
        }

        private void labFindPass_MouseHover(object sender, EventArgs e)
        {
            labFindPass.ForeColor = Color.Brown;
        }

        private void labRegister_MouseLeave(object sender, EventArgs e)
        {
            labRegister.ForeColor = Color.Blue;
        }

        private void labFindPass_MouseLeave(object sender, EventArgs e)
        {
            labFindPass.ForeColor = Color.Blue;
        }





        #endregion


    }
}
