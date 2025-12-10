using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDegişkenler

            //double number; // ondalıklı sayı türü double
            //number = 6.75; // küsüratlı sayı ataması   
            //Console.WriteLine(number);

            //Console.ReadLine();

            //Console.WriteLine(" Fiyat Listesi");
            //Console.WriteLine(" ");

            //double apppePrice = 12.54;
            //double strawberryPrice = 8.95;
            //double bananaPrice = 10.90;
            //double orangePrice = 8.75;
            //double grapePrice = 15.94;

            //Console.WriteLine("**** Elma Birim Fiyatı: " + apppePrice + " TL");
            //Console.WriteLine("**** Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("**** Muz Birim Fiyatı: " + bananaPrice + " TL");
            //Console.WriteLine("**** Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("**** Üzüm Birim Fiyatı: " + grapePrice + " TL");

            //Console.WriteLine("");

            //double appelegram = 1.433;
            //double strawberrygram = 2.534;
            //double bananagram = 0.942;
            //double orangegram = 3.433;
            //double grapegram = 0.664;

            //double totalappleprice = appelegram * apppePrice;
            //double totalstrawberryprice = strawberrygram * strawberryPrice;
            //double totalbananaprice = bananagram * bananaPrice;
            //double totalorangeprice = orangegram * orangePrice;
            //double totalgrapeprice = grapegram * grapePrice;

            ///*Console.WriteLine(totalappleprice + " TL");*/  // dogru yöntem alınan ürünün kilosuna göre fiyat belirliyor..

            //Console.WriteLine("Alınan Ürün: Elma " + "- Birim Fiyatı: " + apppePrice + " - Gramaj: " + appelegram + " - Toplam Tutar: "  + totalappleprice+ " TL");
            //Console.WriteLine("Alınan Ürün: Çilek " + "- Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberrygram + " - Toplam Tutar: "  + totalstrawberryprice + " TL");
            //Console.WriteLine("Alınan Ürün: Muz " + "- Birim Fiyatı: " + bananaPrice + " - Gramaj: " + bananagram + " - Toplam Tutar: "  + totalbananaprice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal " + "- Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangegram + " - Toplam Tutar: "  + totalorangeprice + " TL");
            //Console.WriteLine("Alınan Ürün: Üzüm " + "- Birim Fiyatı: " + orangePrice + " - Gramaj: " + grapegram + " - Toplam Tutar: "  + totalgrapeprice + " TL");


            //Console.WriteLine("");
            //Console.WriteLine("");

            //double shoppingtotalprice = totalappleprice + totalstrawberryprice + totalorangeprice + totalbananaprice + totalgrapeprice;

            //Console.WriteLine("Toplam Sipariş Tutarı: " + shoppingtotalprice + " TL");

            //Console.ReadLine();

            #endregion

            #region Char Degişkenler    

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            //Console.Read();

            #endregion

            #region Klavyeden Veri Girişleri String Degişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");

            //string passengerfullname, passengerdistrict, passengercity, passengerphone, passengeridentitynumber, passengerage;
            //Console.WriteLine(" ");
            //Console.WriteLine(" -------------------------- ");
            //Console.WriteLine(" ");

            //Console.Write("İsim Soyisim: ");
            //passengerfullname = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerage = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerdistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengercity = Console.ReadLine();

            //Console.Write("Yolcu Telefon Numarası: ");
            //passengerphone = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengeridentitynumber = Console.ReadLine();

            //Console.WriteLine(" ");

            //Console.WriteLine("Yolcu Tc Kimlik No: " + passengeridentitynumber + " - " + "Yolcu Adı Soyadı: " + passengerfullname + " - " + passengerdistrict +" / " + passengercity + " - " + passengerage);

            //Console.ReadLine();

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler 

            //int computerprice, keyboardprice, mouseprice, mikrophoneprice, cameraprice;

            //computerprice = 45000;
            //keyboardprice = 3444;
            //mouseprice = 1999;
            //mikrophoneprice = 5599;
            //cameraprice = 2333;

            //int computercount, keyboardcount, mousecount, mikrophonecount, cameracount;

            //// Console.Write komutu klavyeden giriş ile işlem yapmanı saglııyor


            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computercount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Klavye Sayısını Giriniz: ");
            //keyboardcount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Mouse Sayısını Giriniz: ");
            //mousecount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Mikrofon Sayısını Giriniz: ");
            //mikrophonecount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Kamera Sayısını Giriniz: ");
            //cameracount = int.Parse(Console.ReadLine());

            //Console.WriteLine("-----------------");

            //int totalprice = computercount * computerprice + keyboardcount * keyboardprice + mousecount * mouseprice + mikrophonecount * mikrophoneprice + cameracount * cameraprice;

            //Console.WriteLine("Toplam Fiyat " + totalprice + " TL" );




            //Console.ReadLine();

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız: " + result);

            //Console.Read();




            #endregion

            #region Klavyeden Karakter Girişleri

            //    char gender;

            //Console.Write("Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());


            //Console.WriteLine("Seçtiginiz Cinsiyet: " + gender);

            //Console.Read();

            #endregion

            // ..........
        }
    }
}
