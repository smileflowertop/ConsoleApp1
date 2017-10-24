using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i, j;
            //for (i = 1; i < 10; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}

            int max = 0;
            for (int i = 0; i < 100; i++)
                if (i % 3 == 0)
                    max = i;
            Console.WriteLine(max);
            Console.Read();




        }
    }
}
