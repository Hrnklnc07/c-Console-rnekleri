using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double fakt = 1, n;
            string acilim = "1";
            Console.WriteLine("sayı gir");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <=n; i++)
            {
                fakt = fakt * i;
                acilim=acilim+"."+i.ToString();
            }
            
            Console.WriteLine(acilim);
            Console.WriteLine(n.ToString()+ "faktöriyel");
            Console.WriteLine("çarpımları "+fakt);
            Console.ReadKey();



        }
    }
}
