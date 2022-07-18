using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int vize, final;
            double ortalama;
            Console.WriteLine("vize sınavını giriniz");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notunu gir");
            final = Convert.ToInt32(Console.ReadLine());
            ortalama = final * 0.4 + vize * 0.6;
            
            if (ortalama>=50)
            {
                Console.WriteLine("geçti " + ortalama);
            }
            else
            {
                Console.WriteLine("kaldı " + ortalama);
            }

            Console.ReadKey();












        }
    }
}
