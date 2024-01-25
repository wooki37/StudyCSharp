using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharpExam
{
    interface ILogger
    {
        void WriteLog(string message);
    }
        class ConsoleLogger : ILogger
        {
            public void WriteLog(string message)
            {
                Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
            }
        }
        class FileLogger : ILogger
        {
            private StreamWriter writer;
            public FileLogger(string path)
            {
                writer = File.CreateText(path);
                writer.AutoFlush = true;
            }
            public void WriteLog(string message)
            {
                writer.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
            }
        }
        class ClimateMonitor
        {
            private ILogger logger;
            public ClimateMonitor(ILogger logger)
            {
                this.logger = logger;
            }
            public void start()
            {
                while (true)
                {
                    Console.Write("온도를 입력해주세요 : ");
                    string temperature = Console.ReadLine();
                    if (temperature == "")
                        break;

                    logger.WriteLog("현재 온도 : " + temperature);
                }
            }
        }
        //class MainApp
        //{
        //    static void Main(string[] args)
        //    {
        //        ClimateMonitor monitor = new ClimateMonitor(new  ConsoleLogger());  // ConsoleLogger 객체를 가리킴
        //        ClimateMonitor monitor = new ClimateMonitor(new FileLogger("C:\\Users\\USER\\Desktop\\CSharp\\StudyCSharp\\ThisIsCSharpExam\\MyLog.txt"));    // FileLogger 객체를 가리킴
        //        monitor.start();
        //    }
        //}
}
