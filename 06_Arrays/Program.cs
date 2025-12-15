using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];

            //colors[0] = "Sarı";
            //colors[1] = "Lacıvert";
            //colors[2] = "Mor";
            //colors[3] = "Turuncu";

            //Console.WriteLine(colors[0] + " " + colors[1]);



            //int[] numbers = new int[6];

            //numbers[0] = 24;
            //numbers[1] = 66;
            //numbers[3] = 82;
            //numbers[4] = 722;
            //numbers[5] = 94;

            //Console.WriteLine(numbers[3]); // Console.WriteLine(numbers[2]); şeklinde yaparsak 0 olarak bir değer ekrana gelecektir.

            // Farklı yöntem ile 

            //string[] cities = {"İstanbul", "Ankara", "İzmir", "Bursa", "Antalya"};

            //Console.WriteLine(cities[2]);



            #endregion

            #region Dizideki Tüm Elemanları Listele

            //string[] colors = { "Sarı", "Lacıvert", "Mor", "Turuncu", "Bordo", "Yeşil" };

            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}




            //int[] numbers = { 21, 66, 54, 44, 29, 77, 93, 46 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}




            //char[] symbols = { '*', '-', '#', '$', '$', '{' };

            //for (int i = 0; i < symbols.Length; i++)

            //    Console.WriteLine(symbols[i]);




            //int[] mynumbers = { 95, 44, 62, 126, 35, 74, 432, 332, 85, 24 };

            //int maxnumber = mynumbers[0];

            //for (int i = 0; i < mynumbers.Length; i++)
            //{
            //    if (mynumbers[i] > maxnumber)
            //    {
            //        maxnumber = mynumbers[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);

            //string[] persons = { "Semih", "Eda", "Çisem", "Kumsal", "Pera", "Aslan" };

            //Console.WriteLine(persons.Length);


            // Kücükten büyüge dogru sıralayarak ekrana yazdır

            //int[] numbers = { 45, 27, 85, 23, 53, 211, 22, 63, 61, 95 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            // En sondan başlayarak sayıları ekrana yazdır 

            //int[] numbers = { 45, 27, 85, 23, 53, 211, 22, 63, 61, 95 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotları  

            //string[] customers = { "Semih", "Eda", "Tuğçe", "Selim", "Tuğba", "Ateş" };
            //int index = Array.IndexOf(customers, "Tuğçe");
            //{
            //    Console.WriteLine(index);
            //}

            //int[] numbers = { 21, 66, 54, 44, 29, 77, 93, 46 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string [5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Sayıyı Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------");

            //for (int i = 0; i < cities.Length; i++)
            //    Console.WriteLine(cities[i]);



            //int[] numbers = {20, 40, 35, 52, 74, 77, 29, 97, 56,};
            //int total = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine(total);


            //int[] numbers = { 23, 24, 75, 33, 64, 84, 12, 87, 93, 55 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
