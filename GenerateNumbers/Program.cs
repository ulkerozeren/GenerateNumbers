using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GenerateNumbers
{
    class Program
    {
        public static readonly Random random = new Random();
        public static Thread thread1;
        public static Thread thread2;

        static void Main(string[] args)
        {
            thread1 = new Thread(GenerateNumber);
            thread1.Name = "thread1";
            thread1.Start();

            Thread.Sleep(500);

            thread2 = new Thread(GenerateNumber);
            thread2.Name = "thread2";
            thread2.Start();

            Console.ReadLine();

        }
        private static void GenerateNumber()
        {
            int randomNumber = random.Next(1, 100);
            Console.WriteLine(Thread.CurrentThread.Name+": "+randomNumber);           
        }
    }
}
