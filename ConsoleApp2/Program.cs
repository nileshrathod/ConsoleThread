using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Application Execution Process Start");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thread Process Start On " + DateTime.Now.ToString("ddMMyyyy  hh:mm:ss"));

            for (int i = 1; i < 6; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("********************* Thread Sleep Start **********************");
                System.Threading.Thread.Sleep(5000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Sleeping for Item " + i.ToString() + " Thread is Exexuing on Inteval of 5 Seconds " + DateTime.Now.ToString("ddMMyyyy  hh:mm:ss"));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("********************* Thread Sleep End ************************");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thread Process End On " + DateTime.Now.ToString("ddMMyyyy  hh:mm:ss"));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Application Execution Process End");

            Console.Read();
        }
    }
}
