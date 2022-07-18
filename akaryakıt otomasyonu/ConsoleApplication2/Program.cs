using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dizel = 23.6, benzin = 21.4, lpg = 11.78;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismikarı = 0;
            char anamenü_secim = '0', altmenü_secim = '0', akaryakıt_fiyat_güncelle = '0', akaryakit_satis_tipi = '0';

        menü:

            Console.WriteLine("Akaryakit satış takip");
            Console.WriteLine("***********************");
            Console.WriteLine("1-Birim fiyat göster");
            Console.WriteLine("2-Birim fiyat güncelle");
            Console.WriteLine("3-Akaryakıt satışı yap");
            Console.WriteLine("4-Depo Durumunu göster");
            Console.WriteLine("5-Toplam satışları göster");
            Console.WriteLine("6-Çıkış");

            Console.WriteLine("Bir secim yapınız [1,2,3,4,5,6]");
            anamenü_secim = Convert.ToChar(Console.ReadLine());




            if (anamenü_secim == '1')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:1 <<");
                Console.WriteLine("*******************");
                Console.WriteLine("Birim fiyatlar listesi");
                Console.WriteLine("Dizel (D): {0} TL/litre ", dizel);
                Console.WriteLine("Benzin (B): {0} TL/litre", benzin);
                Console.WriteLine("Lpg (L): {0} TL/litre", lpg);

            altmenü:

                Console.WriteLine("Seçiminizi yapınız: [ 1-Ana menü dön  2-Programı kapat ]");
                altmenü_secim = Convert.ToChar(Console.ReadLine());

                if (altmenü_secim == '1')
                {
                    Console.Clear();
                    goto menü;
                }
                else if (altmenü_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1,2 secenekleri dışında Yanlış Seçim yaptınız");
                    goto altmenü;
                }

            }





            else if (anamenü_secim == '2')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:2 <<");
                Console.WriteLine("*******************");
                Console.WriteLine("Birim fiyat güncelleme");

            akaryakıttipi:

                Console.WriteLine("Akaryakıt tipini seçin [D,B,L] ");
                akaryakıt_fiyat_güncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakıt_fiyat_güncelle == 'D' || akaryakıt_fiyat_güncelle == 'd')
                {
                    Console.WriteLine("Dizel (D): {0} Tl/Litre", dizel);
                    Console.WriteLine("Dizel için yeni fiyat giriniz");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik yapılmıştır");
                    Console.WriteLine("Dizel (D): {0} Tl/Litre ", dizel);

                }
                else if (akaryakıt_fiyat_güncelle == 'B' || akaryakıt_fiyat_güncelle == 'b')
                {
                    Console.WriteLine("Benzin (B): {0} Tl/Litre", benzin);
                    Console.WriteLine("Benzin için yeni fiyat giriniz");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik yapılmıştır");
                    Console.WriteLine("Benzin (B): {0} Tl/Litre ", benzin);
                }
                else if (akaryakıt_fiyat_güncelle == 'L' || akaryakıt_fiyat_güncelle == 'l')
                {
                    Console.WriteLine("Lpg (L) {0}: Tl/Litre", lpg);
                    Console.WriteLine("Lpg için yeni fiyat giriniz");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik yapılmıştır");
                    Console.WriteLine("Lpg (L) {0}: Tl/Litre ", lpg);

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("[ D,L,B ] Seçimlerinden birini yapmadınız Tekrar deneyin");
                    goto akaryakıttipi;
                }


            altmenü:


                Console.WriteLine("Seçiminizi yapınız: [ 1-Ana menü dön  2-Programı kapat ]");
                altmenü_secim = Convert.ToChar(Console.ReadLine());
                if (altmenü_secim == '1')
                {
                    Console.Clear();
                    goto menü;
                }
                else if (altmenü_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1,2 secenekleri dışında Yanlış Seçim yaptınız");
                    goto altmenü;
                }

            }









            else if (anamenü_secim == '3')
            {
                Console.Clear();
                Console.WriteLine(">>Seçiminiz:3<<");
                Console.WriteLine("*****************");
                Console.WriteLine("Akaryakıt satışı yap");

            akaryakitsatisi:

                Console.WriteLine("Akaryakit seçimi yapınız [ D,B,L ]");
                akaryakit_satis_tipi = Convert.ToChar(Console.ReadLine());

                if (akaryakit_satis_tipi == 'd' || akaryakit_satis_tipi == 'D')
                {
                    if (dizeltank == 0)
                    {
                        Console.WriteLine("Yakıt tankında Hiç dizel yakt kalmamıştır");
                        goto menü;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık dizel yakıt alacaksınız?");
                        satismikarı = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank < satismikarı)
                        {
                            Console.WriteLine("Yakit tankında {0} dizel yakıt vardır ve işlem yapılamadı", dizeltank);
                            goto menü;
                        }
                        else if (satismikarı <= dizeltank)
                        {
                            dizeltank = dizeltank - satismikarı;
                            Console.WriteLine("Yakit dolumu tamamlanmıştır");
                            Console.WriteLine("Yakit tankında {0} litre dizel yakıt kaldı", dizeltank);
                        }
                    }
                }




                else if (akaryakit_satis_tipi == 'b' || akaryakit_satis_tipi == 'B')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("Yakıt tankında Hiç benzin  kalmamıştır");
                        goto menü;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık benzin  alacaksınız?");
                        satismikarı = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismikarı)
                        {
                            Console.WriteLine("Yakit tankında {0} benzin  vardır ve işlem yapılamadı", benzintank);
                            goto menü;
                        }
                        else if (satismikarı <= benzintank)
                        {
                            benzintank = benzintank - satismikarı;
                            Console.WriteLine("Yakit dolumu tamamlanmıştır");
                            Console.WriteLine("Yakit tankında {0} litre benzin  kaldı", benzintank);
                        }
                    }
                }


                else if (akaryakit_satis_tipi == 'L' || akaryakit_satis_tipi == 'l')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("Yakıt tankında Hiç lpg  kalmamıştır");
                        goto menü;
                    }
                    else
                    {
                        Console.WriteLine("Ne kadarlık lpg  alacaksınız?");
                        satismikarı = Convert.ToDouble(Console.ReadLine());
                        if (lpgtank < satismikarı)
                        {
                            Console.WriteLine("Yakit tankında {0} lpg  vardır ve işlem yapılamadı", lpgtank);
                            goto menü;
                        }
                        else if (satismikarı <= lpgtank)
                        {
                            lpgtank = lpgtank - satismikarı;
                            Console.WriteLine("Yakit dolumu tamamlanmıştır");
                            Console.WriteLine("Yakit tankında {0} litre lpg kaldı", lpgtank);
                        }
                    }
                }


                else
                {
                    Console.WriteLine("Yanlis Akaryakit seçimi tekrar deneyiniz");
                    goto akaryakitsatisi;
                }

            altmenü:

                Console.WriteLine("Seçiminizi yapınız: [ 1-Ana menü dön  2-Programı kapat ]");
                altmenü_secim = Convert.ToChar(Console.ReadLine());
                if (altmenü_secim == '1')
                {
                    Console.Clear();
                    goto menü;
                }
                else if (altmenü_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1,2 secenekleri dışında Yanlış Seçim yaptınız");
                    goto altmenü;
                }

            }

            else if (anamenü_secim=='4')
            {

                Console.Clear();
                Console.WriteLine(">>Seçiminiz:4<<");
                Console.WriteLine("*****************");
                Console.WriteLine("Depo durumu");
                Console.WriteLine("Dizel yakıt tankı %{0} doludur", (dizeltank / 10));
                Console.WriteLine("Benzin tankı %{0} doludur", (benzintank / 10));
                Console.WriteLine("lpg  tankı %{0} doludur", (lpgtank / 10));

            altmenü:

                Console.WriteLine("Seçiminizi yapınız: [1-Ana menü dön  2-Programı kapat]");
                altmenü_secim = Convert.ToChar(Console.ReadLine());
                if (altmenü_secim == '1')
                {
                    Console.Clear();
                    goto menü;
                }
                else if (altmenü_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1,2 secenekleri dışında Yanlış Seçim yaptınız");
                    goto altmenü;
                }




            }

            else if (anamenü_secim=='5')
            {

                Console.Clear();
                Console.WriteLine(">>Seçiminiz:5<<");
                Console.WriteLine("*****************");
                Console.WriteLine("Toplam Satıs durumu");
                Console.WriteLine("Satılan toplam dizel yakıt:{0}", 1000 - dizeltank);
                Console.WriteLine("Dizel yakıt tutarı:{0}", (1000 - dizeltank) * dizel);
                Console.WriteLine("Satılan toplam benzin :{0}", 1000 - benzintank);
                Console.WriteLine("Benzin tutarı:{0}", (1000 - benzintank) * benzin);
                Console.WriteLine("Satılan toplam lpg :{0}", 1000 - lpgtank);
                Console.WriteLine("Lpg tutarı:{0}", (1000 - lpgtank)*lpg);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Toplam Tutar:{0}",((1000-dizeltank)*dizel)+ ((1000 - benzintank)*benzin)+((1000 - lpgtank)*lpg));

            altmenü:

                Console.WriteLine("Seçiminizi yapınız: [ 1-Ana menü dön  2-Programı kapat ]");
                altmenü_secim = Convert.ToChar(Console.ReadLine());
                if (altmenü_secim == '1')
                {
                    Console.Clear();
                    goto menü;
                }
                else if (altmenü_secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1,2 secenekleri dışında Yanlış Seçim yaptınız");
                    goto altmenü;
                }

  
            }

            else if (anamenü_secim=='6')
            {
                
                Environment.Exit(0);
            }


            else
            {
                Console.Clear();
                Console.WriteLine("[1,2,3,4,5,6] Dışında yanlış seçim yaptınız tekrar deneyiniz");
                goto menü;

            }

            Console.ReadKey();



        }
    }
}
