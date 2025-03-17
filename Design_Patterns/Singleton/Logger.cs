using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class Logger
    {
        private static Logger instance;
        private static readonly object _lock = new object();

        private Logger()
        {
            
        }

        public static Logger getInstance()
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                Console.WriteLine(instance.GetHashCode());

                return instance;
            }
          
        }

        public static void InfoMessage(string message , string filePath)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            File.AppendAllText(filePath, message);
        }

        public static void WarningMessage(string message , string filePath)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            File.AppendAllText(filePath, message);
        }

        public static void ErrorMessage(string message , string filePath)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            File.AppendAllText(filePath, message);
        }
    }
}
