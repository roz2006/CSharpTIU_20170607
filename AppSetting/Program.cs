using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSetting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetAppSetting("ip","127.0.0.1"));
            Console.WriteLine(GetAppSettingGenerics("maxrecords",500));

        }

        static string GetAppSetting(string key, string defaultvalue)
        {
            string ip = System.Configuration.ConfigurationManager.AppSettings[key];
            if (ip == null)
                return defaultvalue;
            else
                return ip;
        }

        static T GetAppSettingGenerics<T>(string key, T defaultvalue)
        {
            T value = (T)Convert.ChangeType(System.Configuration.ConfigurationManager.AppSettings[key.ToString()],typeof(T)) ;
            if (value == null)
                return defaultvalue;
            else
                return value;
        }
    }
}
