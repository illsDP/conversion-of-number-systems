

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
    public partial class Plan : SkinMain
    {
        DataTable dt = null;
        string strSql = null;
        string[] arryDt = null;
        public Plan()
        {
            InitializeComponent();
        }

        #region 界面操作

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

        #endregion
        /// <summary>
        /// 界面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Plan_Load(object sender, EventArgs e)
        {
            RefSelect();
            //添加项目列表
            utfList.ItemsRight.Clear();
            utfList.ItemsLeft.Clear();
            foreach (DataRow rows in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.ColumnName.Equals("entry_state"))
                    {
                        if (rows[col].Equals("未完成"))
                        {
                            utfList.ItemsLeft.Add(rows["entry_name"]);
                        }
                        else
                        {
                            utfList.ItemsRight.Add(rows["entry_name"]);
                        }
                    }
                }

            }
            btnNoWork.TipsText = utfList.ItemsLeft.Count.ToString();
            btnWork.TipsText = utfList.ItemsRight.Count.ToString();
            //储水池界面刷新
            processBar.Value = (int)((double)(100 / dt.Rows.Count) * utfList.ItemsRight.Count);
            if (utfList.ItemsRight.Count.Equals(dt.Rows.Count))
            {
                processBar.Value = 100;
            }
            dhChart(utfList.ItemsRight.Count, utfList.ItemsLeft.Count);
        }
        public void RefSelect()
        {
            //查询功能
            strSql = "select * from zack_plan";
            dt = MySqlDBHelp.getTable(strSql);
            if (dt.Rows.Count <= 0)
            {
                MeassgeBoxUIPage.UIPageWarning("未查询到项目!");
                return;
            }
            //获取所有项目名称
            arryDt = dt.AsEnumerable().Select(t => t.Field<string>("entry_name").ToString()).ToArray();
            if (arryDt.Length > 0)
            {
                cmb_EntryName.Items.Clear();
                foreach (var item in arryDt)
                {
                    cmb_EntryName.Items.Add(item);
                }
                cmb_EntryName.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 查询现有功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            Plan_Load(sender, e);
            MeassgeBoxUIPage.UIPageSuccess("已刷新!");
        }
        /// <summary>
        /// 根据项目名称联动其他项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_EntryName_TextChanged(object sender, EventArgs e)
        {
            DataTable cmbdt = null;
            if (string.IsNullOrEmpty(cmb_EntryName.Text))
            {
                return;
            }
            strSql = "select * from zack_plan where entry_name='" + cmb_EntryName.Text + "'";
            cmbdt = MySqlDBHelp.getTable(strSql);
            if (cmbdt.Rows.Count <= 0)
            {
                MeassgeBoxUIPage.UIPageWarning("未查询到项目!");
                return;
            }
            //获取操作人
            arryDt = cmbdt.AsEnumerable().Select(t => t.Field<string>("entry_operator").ToString()).ToArray();
            if (arryDt.Length > 0)
            {
                cmb_Operator.Items.Clear();
                foreach (var item in arryDt)
                {
                    cmb_Operator.Items.Add(item);
                }
                cmb_Operator.SelectedIndex = 0;
            }
            //获取项目内容
            arryDt = cmbdt.AsEnumerable().Select(t => t.Field<string>("entry_content").ToString()).ToArray();
            if (arryDt.Length > 0)
            {
                txt_EntryContent.Text = arryDt[0];
            }

            //获取项目状态
            arryDt = cmbdt.AsEnumerable().Select(t => t.Field<string>("entry_state").ToString()).ToArray();
            if (arryDt.Length > 0)
            {
                if (arryDt[0].Equals("已完成"))
                {
                    entry_State.Active = true;
                }
                else
                {
                    entry_State.Active = false;
                }
            }
            //获取创建时间
            arryDt = cmbdt.AsEnumerable().Select(t => t.Field<DateTime>("entry_creatertime").ToString()).ToArray();
            if (arryDt.Length > 0)
            {
                dpiker_CreaterTime.Value = DateTime.Parse(arryDt[0]);
            }
            //获取项目ID
            arryDt = cmbdt.AsEnumerable().Select(t => t.Field<int>("id").ToString()).ToArray();
            if (arryDt.Length > 0)
            {
                txt_EntryId.Text = arryDt[0];
            }
        }
        /// <summary>
        /// 添加功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PlanAdd PlanAdd = new PlanAdd();
            PlanAdd.ShowDialog();
            Plan_Load(sender, e);
        }
        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageCls.entryInfo.entry_id = txt_EntryId.Text;
            MessageCls.entryInfo.entry_name = cmb_EntryName.Text;
            MessageCls.entryInfo.entry_creatertime = dpiker_CreaterTime.Value;
            MessageCls.entryInfo.entry_operator = cmb_Operator.Text;
            MessageCls.entryInfo.entry_content = txt_EntryContent.Text;
            if (entry_State.Active)
            {
                entry_State.Text = "已完成";
            }
            else
            {
                entry_State.Text = "未完成";
            }
            MessageCls.entryInfo.entry_state = entry_State.Text;
            PlanUpdate PlanUpdate = new PlanUpdate();
            PlanUpdate.ShowDialog();
            Plan_Load(sender, e);
        }
        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MeassgeBoxUIPage.UIPageShowAskDialog("是否删除【" + cmb_EntryName.Text + "】功能？"))
            {
                strSql = "delete from zack_plan where id=" + txt_EntryId.Text + "";
                int result = MySqlDBHelp.Execute(strSql);
                if (result <= 0)
                {
                    MeassgeBoxUIPage.UIPageError("删除失败,请重新操作");
                }
                Plan_Load(sender, e);
            }
        }

        /// <summary>
        /// 未完成-已完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="item"></param>
        private void utfList_ItemAdd(object sender, object item)
        {
            string strSqlItem = "update zack_plan set entry_state='已完成' where entry_name='" + item + "'";
            int result = MySqlDBHelp.Execute(strSqlItem);
            if (result <= 0)
            {
                MeassgeBoxUIPage.UIPageError("添加失败,请重新操作");
                return;
            }
            RefSelect();
        }
        /// <summary>
        /// 已完成-未完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="item"></param>
        private void utfList_ItemRemove(object sender, object item)
        {
            string strSqlItem = "update zack_plan set entry_state='未完成' where entry_name='" + item + "'";
            int result = MySqlDBHelp.Execute(strSqlItem);
            if (result <= 0)
            {
                MeassgeBoxUIPage.UIPageError("添加失败,请重新操作");
                return;
            }
            RefSelect();
        }

        private void utfList_ItemsLeftCountChange(object sender, EventArgs e)
        {
            btnNoWork.TipsText = utfList.ItemsLeft.Count.ToString();
        }

        private void utfList_ItemsRightCountChange(object sender, EventArgs e)
        {
            btnWork.TipsText = utfList.ItemsRight.Count.ToString();
            processBar.Value = (int)((double)(100 / dt.Rows.Count) * utfList.ItemsRight.Count);
            if (utfList.ItemsRight.Count.Equals(dt.Rows.Count))
            {
                processBar.Value = 100;
            }
            dhChart(utfList.ItemsRight.Count, utfList.ItemsLeft.Count);
        }
        /// <summary>
        /// 圆形图刷新
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rightItem"></param>
        /// <param name="leftItem"></param>
        public void dhChart(int rightItem, int leftItem)
        {
            var option = new UIPieOption();
            //设置Title
            option.Title = new UITitle();
            option.Title.Text = "项目集成功能圆形图表";
            option.Title.SubText = cmb_Operator.Text;
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend  分项标记
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("已完成");
            option.Legend.AddData("未完成");
            //option.Legend.AddData("2020-05-21");
            //option.Legend.AddData("2020-05-22");
            //option.Legend.AddData("2020-05-23");
            //option.Legend.AddData("2020-05-24");
            //option.Legend.AddData("2020-05-25");

            //设置Series
            var series = new UIPieSeries();
            series.Name = "StarCount";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            //增加数据           
            series.AddData("已完成", leftItem);
            series.AddData("未完成", rightItem);


            //增加Series
            option.Series.Clear();
            option.Series.Add(series);

            //设置Option
            udhChart.SetOption(option);


        }
    }
}
