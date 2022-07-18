using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 2 tamsayı arasındaki tamsayıları ekrana yazdıran aşağıda algoritması olan programı yapınız.
            int sayi1, sayi2, buyuk=0, kucuk=0;
            Console.WriteLine("sayi1 gir");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayi2 gir");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1>sayi2)
            {
                buyuk = sayi1;
                kucuk = sayi2;
            }
            else if (sayi1==sayi2)
            {
                Console.WriteLine("sayılar biribirine eşittir arasında tam sayı yoktur =)");
            }
            else
            {
                buyuk = sayi2;
                kucuk = sayi1;

            }
            Console.WriteLine("buyuk olan" + buyuk);
        
            Console.WriteLine("kucuk olan" + kucuk);
            for (int i = kucuk; i < buyuk; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
           
        }
    }
}
