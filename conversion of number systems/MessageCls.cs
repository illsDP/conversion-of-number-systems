using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zack
{
    public class MessageCls
    {
        public class userinfo
        {
            public string name { get; set; }
            public string user { get; set; }
            public string password { get; set; }
            public string type { get; set; }
            public string phono { get; set; }
            public string email { get; set; }
            public string resume { get; set; }
            public DateTime creatertime { get; set; }
        }

        public class entryInfo
        {
            public static string entry_id { get; set; }
            public static string entry_name { get; set; }
            public static DateTime entry_creatertime { get; set; }
            public static string entry_content { get; set; }
            public static string entry_operator { get; set; }
            public static string entry_state { get; set; }
        }
    }
}
