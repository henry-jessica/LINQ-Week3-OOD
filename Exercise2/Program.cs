using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using log4net;
using log4net.Config;
using System.IO;

namespace Exercise2
{
    internal class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));


            int[] numbers = {1,2,3,4,5,6};
            try
            {
                _log.Info("Starting Application");
                _log.Info(numbers); 

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

                _log.Info("Ending Application"); 
            }
            catch (Exception e)
            {
                Console.Write("Element not find! Try again.");
                _log.Fatal(e.Message); 
            }

          

            Console.ReadKey(); 
        }
    }
}
