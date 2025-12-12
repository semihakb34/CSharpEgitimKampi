using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  For Döngüler
            //// For Döngüsü
            //// Belirli sayıda tekrarlanan işlemler için kullanılır.
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("For Döngüsü - Sayı: " + i);
            //}
            //Console.WriteLine();
            //// While Döngüsü
            //// Koşul doğru olduğu sürece işlemleri tekrarlar.
            //int j = 1;
            //while (j <= 5)
            //{
            //    Console.WriteLine("While Döngüsü - Sayı: " + j);
            //    j++;
            //}
            //Console.WriteLine();
            //// Do-While Döngüsü
            //// En az bir kez çalışır, ardından koşulu kontrol eder.
            //int k = 1;
            //do
            //{
            //    Console.WriteLine("Do-While Döngüsü - Sayı: " + k);
            //    k++;
            //} while (k <= 5);
            //Console.ReadLine();

            //For(x, y, z)
            // x: Başlangıç değeri
            // y: Koşul
            // z: Artış veya azalış değeri


            // 1. Örnek Denemeler

            //for (int i = 1; i <= 3; i++)      // 1'den başla 3 e kadar 1 er 1 er artır
            //{
            //*Console.WriteLine("Sayı: " + i); veya*/ Console.WriteLine("Yazılım Öğreniyorum");
            //}

            //for (int i = 2; i <= 66; i += 4)   // 2'den başla 66 ya kadar 4 er 4 er artır
            //{
            //    Console.WriteLine("sayı: " + i);
            //}
            //Console.ReadLine();


            // 2. Örnek Denemeler

            // Klavyeden girilen sayı kadar ekrana yazı yazdırma..

            //Console.Write("Yazılmasını İstediginiz Adeti Giriniz: ");
            //int finishvalue = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //for (int i = 1; i <= finishvalue; i++)
            //{
            //    Console.WriteLine("Yazılım Öğreniyorum");
            //}
            //Console.ReadLine();


            #endregion

            #region For Döngüsü ile Karar Yapıları

            // 1 ila 10 sayılarının toplamını ekrana yazdırma

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)

            //{
            //    totalvalue += i;
            //}
            //    Console.WriteLine(totalvalue);


            // 1 ila 25 cift sayıların toplamını ekrana yazdırma


            //int totalvalue = 0;

            //for (int i = 1; i <= 25; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(totalvalue);


            // 1 ila 60 arasında 7 bölünen kaç sayı vardır işlemi.


            //int count = 0;

            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count ++;
            //    }
            //}

            //Console.WriteLine(count);


            // ikiye bölünerek çogalan bir bakteri örnegi 


            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *=2;
            //    Console.WriteLine(i +".Saat Sonunda :" + bacterium);
            //}

            //    Console.ReadLine();



            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 4)
            //{
            //    Console.WriteLine("Merhaba Semih");
            //        i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;

            //while (i <= 12)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            //Console.Read();

            #endregion

            #region Örnek Sınav Sorusu

            // klavyeden girilen 3 basamaklı sayının basamakların toplamını hesaplayan kodu yazınız...


            //Console.Write("Lütfen Bir Sayı Giriniz :");

            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);



            //Console.Read();

            #endregion
        }
    }
}
