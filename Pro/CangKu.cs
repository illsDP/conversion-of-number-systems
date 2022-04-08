using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pro
{
    class CangKu
    {
        //存储货物

        List<List<ProductFather>> listProDuctFather = new List<List<ProductFather>>();

        //List<SamSung> listSamSung = new List<SamSung>();
        //List<Acer> listAcer = new List<Acer>();
        //List<JiangYouL> listJiangYou = new List<JiangYouL>();
        public CangKu()
        {
            listProDuctFather.Add(new List<ProductFather>());
            listProDuctFather.Add(new List<ProductFather>());
            listProDuctFather.Add(new List<ProductFather>());
            listProDuctFather.Add(new List<ProductFather>());
        }


        /// <summary>
        /// 向用户展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in listProDuctFather)
            {
                Console.WriteLine("我们超市有:" + item[0].Name + "," + "\t" + "有" + item.Count + "个m" + "\t" + "每个" + item[0].Price + "元" + "\r\n");
            }
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">货物数量</param>
        public void GetPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        listProDuctFather[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "宏碁电脑"));
                        break;
                    case "SamSung":
                        listProDuctFather[1].Add(new SamSung(Guid.NewGuid().ToString(), 1000, "三星手机"));
                        break;
                    case "JiangYou":
                        listProDuctFather[1].Add(new JiangYou(Guid.NewGuid().ToString(), 50, "酱油"));
                        break;
                    case "Banana":
                        listProDuctFather[1].Add(new Banana(Guid.NewGuid().ToString(), 10, "香蕉"));
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        ///  提货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">货物数量</param>
        public ProductFather[] QuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        pros[i] = listProDuctFather[0][0];
                        listProDuctFather[0].RemoveAt(0);
                        break;
                    case "SumSung":
                        pros[i] = listProDuctFather[1][0];
                        listProDuctFather[1].RemoveAt(0);
                        break;
                    case "JiangYou":
                        pros[i] = listProDuctFather[2][0];
                        listProDuctFather[2].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = listProDuctFather[3][0];
                        listProDuctFather[3].RemoveAt(0);
                        break;
                    default:
                        break;
                }
            }
            return pros;
        }
    }
}
