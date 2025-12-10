using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else Yapısı

            // 1. DENEME



            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "admin123")
            //{
            //       Console.WriteLine("Giriş Başarılı! Hoşgeldiniz.");
            //}
            //else
            //{
            //       Console.WriteLine("Giriş Başarısız! Lütfen bilgilerinizi kontrol ediniz.");
            //}
            //       Console.Read();


            // 2. DENEME & VE anlamına gelen operatör

            //string capital, country;
            //Console.Write("Lütfen Bir Başkent Adı Giriniz: ");
            //capital = Console.ReadLine();


            //Console.Write("Lütfen Ülke Adı Giriniz ");
            //country = Console.ReadLine();


            //if (capital == "istanbul" & country == "türkiye")
            //{
            //    Console.Write("Veriler Dogrulandı.");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            //Console.Read();


            // 3. DENEME == eşittir operatörü

            //int number;
            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 29)
            //{
            //    Console.Write("Sayı Dogru ");
            //}
            //else
            //{
            //    Console.Write("Sayı Hatalı ");
            //}

            //Console.Read();




            // sınav ortalamasına göre ögrenci sınıflandırması
            // 4. DENEME > < = operatörleri 

            //int exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("");

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + result);

            //Console.WriteLine("");

            //if (result > 0 &  result <= 25)
            //{
            //    Console.Write("Çok Kötü Bir Ögrenci ");

            //}
            //if (result > 26 & result <= 49)
            //{
            //    Console.Write("Kötü Bir Ögrenci ");
            //}
            //if (result > 50 & result <= 69)
            //{
            //    Console.Write("Ortalama Bir Ögrenci ");
            //}
            //if (result > 70 & result <= 85)
            //{
            //    Console.Write("İyi Bir Ögrenci ");
            //}
            //if (result >=86)
            //{
            //    Console.Write("Mükemmel Bir Ögrenci ");
            //}

            ////Console.WriteLine(result);

            //    Console.Read();


            // 5. DENEME || veya operatörü. | veya anlamına gelir.

            //string city;

            //Console.Write("Lütfen Bir Şehir Giriniz: ");
            //city = Console.ReadLine();
            //city = city.ToLower(); // Verilen cevapların hepsini kücük harfe dönüştüren kod..

            //if (city == "istanbul" || city == "ankara" || city == "izmir" || city == "bursa")

            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Degil");
            //}

            //Console.Read();

            // 6. DENEME != eşit değildir operatörü. 

            //Console.Write("Bir Kullanıcı Adı Giriniz: ");
            //string username = (Console.ReadLine());
            //if (username != "admin")
            //{
            //    Console.WriteLine("Giriş Başarısız");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}

            //Console.Read();



            #endregion

            #region Mod işlemleri

            // 1. DENEME % operatörü 

            //int number;
            //number = 42;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.ReadLine(

            // 2. DENEME klavyeden girilen iki sayının modunu alıp bölümünden kalanı ekrana yazdırma

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number % number2;
            //Console.WriteLine("1. Sayının 2. Sayıya bölümünden kalan: " + result);
            //Console.ReadLine();

            // 3. DENEME klavyeden girilen bir sayının tek mi çift mi olduğunu bulma

            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Girilen Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı Tektir.");
            //}
            //Console.ReadLine();

            #endregion

            #region Char Degişkenleri ile Karar Yapıları
            // 4. DENEME takımların baş harflerine göre takım isimlerini yazdırma

            //char team;
            //Console.Write("Lütfen bir takım baş harfi girini: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            //Console.Read();



            #endregion

            #region Örnek proje uygulamaları

            //Console.Write("***** Sıcak Eller Restorant *****");
            //Console.WriteLine("");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine(" * Ana Yemekler");
            //Console.WriteLine(" * Çorbalar");
            //Console.WriteLine(" * Tatlılar");
            //Console.WriteLine(" * İçecekler");

            //string Menüseçim;

            //Console.WriteLine("");
            //Console.Write(" Detayları Görmek İçin Seçim Yapınız: ");
            //Menüseçim = Console.ReadLine();

            //if (Menüseçim == "1")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("***** Ana Yemek Çeşitleri *****");
            //    Console.WriteLine("");
            //    Console.WriteLine(" * Izgara Köfte Menüsü");
            //    Console.WriteLine(" * Tavuk Sote");
            //    Console.WriteLine(" * Fırında Sebzeli Et Yemeği");
            //    Console.WriteLine(" * Spagetti Bolonez");
            //    Console.WriteLine(" * Mantı");
            //}

            //if (Menüseçim == "2")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("***** Çorba Çeşitleri *****");
            //    Console.WriteLine("");
            //    Console.WriteLine(" * Mercimek Çorbası");
            //    Console.WriteLine(" * Domates Çorbası");
            //    Console.WriteLine(" * Ezogelin Çorbası");
            //    Console.WriteLine(" * Yayla Çorbası");
            //    Console.WriteLine(" * Tavuk Suyu Çorbası");
            //}

            //if (Menüseçim == "3")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("***** Tatlı Çeşitleri *****");
            //    Console.WriteLine("");
            //    Console.WriteLine(" * Sütlaç (Fırın Sütlaç)");
            //    Console.WriteLine(" * Krem Karamel");
            //    Console.WriteLine(" * Tiramisu");
            //    Console.WriteLine(" * Profiterol");
            //    Console.WriteLine(" * Kabak Tatlısı");
            //}

            //if (Menüseçim == "4")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("***** İçecek Çeşitleri *****");
            //    Console.WriteLine("");
            //    Console.WriteLine(" * Filtre Kahve");
            //    Console.WriteLine(" * Limonata");
            //    Console.WriteLine(" * Sıcak Çikolata");
            //    Console.WriteLine(" * Ayran");
            //    Console.WriteLine(" * Espresso");
            //}

            //Console.Read();
            #endregion

            #region Switch Case 

            // switch-case yapısı: Bu yapı, birden fazla if-else if bloğu kullanmaktan daha temizdir.
            // Break yapısı: Belirli bir case (durum) bloğunun içindeki kod çalıştırıldıktan sonra, programın diğer case bloklarını kontrol etmesini
            // engeller ve switch yapısından hemen çıkılmasını sağlar.



            //Console.Write(" Lütfen Bir Sayı Giriniz: ");
            //int monthnumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //switch (monthnumber)
            //{
            //    case 1: Console.Write(" * Ocak");break;
            //    case 2: Console.Write(" * Şubat");break;
            //    case 3: Console.Write(" * Mart");break;
            //    case 4: Console.Write(" * Nisan");break;
            //    case 5: Console.Write(" * Mayıs");break;
            //    case 6: Console.Write(" * Haziran");break;
            //    case 7: Console.Write(" * Temmuz");break;
            //    case 8: Console.Write(" * Agustos");break;
            //    case 9: Console.Write(" * Eylül");break;
            //    case 10: Console.Write(" * Ekim");break;
            //    case 11: Console.Write(" * Kasım");break;
            //    case 12: Console.Write(" * Aralık");break;
            //    default: Console.Write(" * Hatalı Giriş");break;
            //}

            //Console.ReadLine();

            #endregion

            #region  Switch Case İle Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //Console.Write("Lütfen Yapmak İstediginiz İşlemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Farkı: " + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpımı: " + result); break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme İşlemi: " + result); break;
            //}

            //Console.ReadLine();
            #endregion


        }
    }
}
