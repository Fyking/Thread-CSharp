using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            Thread th = new Thread(delegate() {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
            });
            th.Start();
            for (int i = 100; i < 200; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
            Console.WriteLine("end");
            Console.ReadKey();
        }
    }
}
