using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    class Program
    {
        static void Main(string[] args)
        {//ввод переменных 
            double Shag = 0;
            bool ok = false;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out Shag);

            } while (!ok);
            // ввод переменных через консоль 
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double granica1 = Math.Pow(2,Shag-1);
            double granica2 = Math.Pow(2, Shag);
            double dist = (granica2 - granica1)/2;
            //if (first < granica1 + dist && second > granica1 + dist) Console.WriteLine(1);
            //else
           // {
                ok = false;
                do
                {
                    Shag = Shag - 1;
                if (first == 1 || second == 1) { Console.WriteLine(1); break; }
                else
                {
                    double predok = first / 2;
                    double predok2 = second / 2;
                    first = Math.Truncate(predok);
                    second = Math.Truncate(predok2);
                    if (first == second)
                    {
                        ok = true;
                        Console.WriteLine(first);
                    }
                }   
                   // else
                    //{
                    //    ok = true;
                    //    Console.WriteLine(1);
                    //}
                } while (!ok);
         //   }
        }
    }
}
