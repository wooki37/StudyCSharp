using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam
{
    interface ILogger3
    {
        void WriteLog(string message);
        void WriteError(string error);
    }
    class ConsoleLogger3 : ILogger3
    {
        public void WriteLog(string message) {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
        public void WriteError(string error)
        {
            WriteLog($"Error: {error}");
        }
    }
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        ILogger3 logger3 = new ConsoleLogger3();
    //        logger3.WriteLog("System Up!");
    //        logger3.WriteError("System Fail");

    //        ConsoleLogger3 clogger3 = new ConsoleLogger3();
    //        clogger3.WriteLog("System Up!");
    //    }
    //}
}
