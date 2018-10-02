using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication3
{
    class ClaseFibonacci
    {

        public static void Fibonacci(int c)
        {
        int a;
        int b;
        int i;
        int aux;

            a = 0;
            b = 1;
            for (i = 0; i < c; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                Console.WriteLine(a);
            }
            
        }


        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Fibonacci(10);

            Console.WriteLine("-------------------------------");
            stopWatch.Stop();
            Console.WriteLine("Proceso Finalizado en " +
            stopWatch.Elapsed.ToString(), "Mensaje Sistema");
            Console.ReadKey();
        }
    }
}
