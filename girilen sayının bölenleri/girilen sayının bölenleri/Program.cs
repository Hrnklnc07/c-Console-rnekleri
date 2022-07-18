using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_sayının_bölenleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi=0;
            
            Console.Write("sayi değerini giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0) 
                {
                    Console.WriteLine("tam böleni= "+i);
                }
                
            }
            Console.ReadKey();


        }
        
    }
}
