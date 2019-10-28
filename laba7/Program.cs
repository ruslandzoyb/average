using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace laba7
{
    class Program
    {
       static Random r = new Random();
        static int i=0;
       // static double[] avarege;
        static int sum = 0;
        static int[] element;
        static DateTime time1;
        static void Main(string[] args)
        {
           // var end = 1000;
            
            Thread[] threads = new Thread[2];

            threads[0] = new Thread(RandomLoop);
            threads[1] = new Thread(SumCalculate);
             time1 = DateTime.Now;
            threads[0].Start(100);
            threads[1].Start();





            Console.ReadKey();
        }
        static void RandomLoop(object e)
        {
            int end = (int)e;
           
            element = new int[end+1];
            for ( i = 0; i <= end; i++)
            {
                element[i] =  r.Next(1,500);
              // Console.BackgroundColor = ConsoleColor.Green;
               Console.WriteLine($" Element {i} = {element[i]} ");
              // Console.ResetColor();
                Thread.Sleep(50);
            }

        }
        static void SumCalculate()
        {
            Thread.Sleep(20);
            for (; i <= 100; )
            {
                sum += element[i];
                
                
               // Console.BackgroundColor = ConsoleColor.Red;
               Console.WriteLine($"Suma {i} = { sum}  ");
            //  Console.ResetColor();
                Thread.Sleep(50);
                
            }
            Console.WriteLine(sum);
            var time2 = DateTime.Now;
            Console.WriteLine(time2-time1);
            int s=0;
            int ind = 0;
            foreach (var item in element)
            {
                if (item==0)
                {
                    Console.WriteLine("Zero" +ind );
                }
                s += item;
                ++ind;
            }
            Console.WriteLine(s);
        }
    }
}
