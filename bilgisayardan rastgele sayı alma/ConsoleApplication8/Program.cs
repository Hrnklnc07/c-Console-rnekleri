using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sayılar = new Random();
            int sayı;
            sayı = sayılar.Next(0,100);
            Console.WriteLine(sayı);
            Console.ReadKey();
        }
    }
}
