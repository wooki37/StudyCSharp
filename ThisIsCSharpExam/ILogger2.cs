using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam
{
    interface ILogger2
    {
        void WriteLog(string message);
    }
    interface IFormattableLogger : ILogger2
    {
        void WriteLog(string format, params object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message) {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        IFormattableLogger logger = new ConsoleLogger2();
    //        logger.WriteLog("The World is not flat.");
    //        logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
    //    }
    //}
}
