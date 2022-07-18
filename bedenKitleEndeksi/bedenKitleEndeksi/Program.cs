using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedenKitleEndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen boyunuzu giriniz");
               double boy=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("lütfen kilonuzu giriniz");
                double kilo=Convert.ToDouble(Console.ReadLine());
            double endex;
            endex=kilo/(boy*boy);
            if (endex<=18)
	{
		Console.WriteLine("zayıf" + endex);
	}
            else if (endex>18 && endex<25)
	{
		 Console.WriteLine("normal" + endex);
	}

            else
	{
                Console.WriteLine("obez" + endex);
	}
            Console.ReadKey();




        }
    }
}
