using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MySqlDBHelp
{
     public static string ConnectionString=ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;


}

