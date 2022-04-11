using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zack
{
    public static class AuthCacheHelper
    {
        private static long timeout = 300;//缓存时间
        public static Dictionary<string, object> cacheInfo = new Dictionary<string, object>();
        //private static Dictionary<string, object> initialize = new Dictionary<string, object>();


        /// <summary>
        /// 缓存数据存储
        /// </summary>
        /// <param name="CacheInfo"></param>
        public static void AddCache(Dictionary<string, object> CacheInfo)
        {
           
            if (CacheInfo != null && CacheInfo.Count > 0)
            {
                //存储用户信息
                CacheClear();
                cacheInfo = CacheInfo;              
                //if (CacheInfo.ContainsKey(CacheInfo.FirstOrDefault().Key))
                //{
                //    cacheInfo.Add("id", CacheInfo.FirstOrDefault().Value);
                //}
                //缓存时间
                cacheInfo.Add("joinTime", DateTime.Now.Ticks);
            }
        }
        /// <summary>
        /// 从缓存中读取数据
        /// </summary>
        public static Dictionary<string, object> ReadCache(string name)
        {

            if (cacheInfo != null && cacheInfo.Count > 0)
            {
                if (cacheInfo.ContainsValue(name))
                {
                    return cacheInfo;
                }
            }
            else
            {
                return null;
            }

            //if (cacheInfo != null && cacheInfo.Count > 0 && cacheInfo.ContainsKey("1"))
            //{
            //    long joinTime = (long)cacheInfo["joinTime"];
            //    long now = DateTime.Now.Ticks;
            //    if ((now - joinTime) / 10000000 >= timeout)
            //    {
            //        //超时清空缓存
            //        cacheInfo.Clear();
            //        return null;
            //    }
            //    else
            //    {
            //        return cacheInfo;
            //    }
            //}
            return null;
        }

        /// <summary>
        /// 清空缓存
        /// </summary>
        public static void CacheClear()
        {
            cacheInfo.Clear();
        }
    }
}
