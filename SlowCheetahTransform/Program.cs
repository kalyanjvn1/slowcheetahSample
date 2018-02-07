using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlowCheetahTransform
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Collections.Specialized.NameValueCollection settings = ConfigurationManager.AppSettings;

            //foreach (ConnectionStringSettings cs in settings)
            //{
            //    Console.WriteLine(cs.Name);
            //    Console.WriteLine(cs.ConnectionString);
            //}

            foreach (var appSetting in settings)
            {
               Console.WriteLine(settings[appSetting.ToString()]);     
            }

            Console.ReadLine();

        }
    }
}
