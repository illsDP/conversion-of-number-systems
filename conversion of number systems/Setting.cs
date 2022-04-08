
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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        public delegate string delegate_txt(string txtName);
        public event delegate_txt event_txt = null;
        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void txtDelegate_Click(object sender, EventArgs e)
        {
            event_txt("content");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSql.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string Sql = "";
            double Count = 20210318162012;
            for (int i = 0; i < 100; i++)
            {
                Count++;
                Sql = "INSERT INTO `masi_znwg_test`.`gwvw_503`(`ipt_otp_no`, `feedetl_sn`, `chrg_bchno`, `dise_codg`, `rxno`, `rx_circ_flag`, `fee_ocur_time`, `medins_list_codg`, `det_item_fee_sumamt`, `cnt`, `pric`, `sin_dos_dscr`, `used_frqu_dscr`, `prd_days`, `medc_way_dscr`, `bilg_dept_codg`, `bilg_dept_name`, `bilg_dr_codg`, `bilg_dr_name`, `acord_dept_codg`, `acord_dept_name`, `orders_dr_code`, `orders_dr_name`, `hosp_appr_flag`, `tcmdrug_used_way`, `etip_flag`, `etip_hosp_code`, `dscg_tkdrug_flag`, `matn_fee_flag`, `invono`, `medins_list_name`) VALUES ('02', '" + Count + "', '000001', 'BN80907', '200001', '1', '2021-07-29 09:57:15', 'ZZ01AAZ0484020105717', 50.00, 10.0000, 5.000000, '测试剂型描述', '测试频次描述', 2.00, '测试用药途径描述', '1001', '内科', '0003', '王医生', '002', '神经科', '0004', '何医生', '0', '中药使用方式', '1', '9158', '1', '1', '99970171712', '测试药品2');";
                if (MySqlDBHelp.Execute(Sql) < 0)
                {
                    break;
                }
            }

        }

       
    }
}
