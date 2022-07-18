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
            int sayi, birler=0, onlar=0, yüzler;
            Console.Write("sayi değerini giriniz");
            sayi=Convert.ToInt32(Console.ReadLine());
            if (sayi>=100)
            {
              yüzler = sayi/100;  
              Console.WriteLine("yüzler basamağı= "+yüzler);
              sayi = sayi - yüzler * 100;   
              onlar = sayi / 10;    
              Console.WriteLine("onlar basamağı= "+onlar);
              birler = sayi - onlar * 10;
              Console.WriteLine("birler basamağı= "+birler);
            }

            Console.ReadKey();
            
            
           

        }
    }
}
