using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doSomething();
            }
            catch (Exception ex) {
                //报错自动百度
                Process.Start("http://www.baidu.com/s?wd=C%23+"+ex.GetType().Name);
            }
            Console.ReadLine();
        }

        static void doSomething() {
            Console.WriteLine(int.Parse("acvanrfeiougvbhna"));
        }
    }
}
