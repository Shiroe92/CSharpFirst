using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDeğişkenler_Variable

            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, melonPrice;

            //applePrice = 9.85;
            //orangePrice = 14.65;
            //strawberryPrice = 47.87;
            //potatoPrice = 7.50;
            //melonPrice = 8.50;

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //Console.WriteLine("Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("Kavun Birim Fiyatı: " + melonPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, melonGram;

            //appleGram = 4.867;
            //orangeGram = 3.468;
            //strawberryGram = 1.320;
            //potatoGram = 5.400;
            //melonGram = 9.850;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, melonTotalPrice, totalPrice;

            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;    
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //potatoTotalPrice = potatoPrice * potatoGram;
            //melonTotalPrice = melonPrice * melonGram;

            //totalPrice= appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + melonTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("*** Aldıklarınız ve Toplam Fiyat ***");
            //Console.WriteLine();
            //Console.WriteLine("Elma - " + "Birim Fiyat: " + applePrice + "Gramaj: " + appleGram + "Toplam Tutar: " + appleTotalPrice + " TL");
            //Console.WriteLine("Portakal - " + "Birim Fiyat: " + orangePrice + "Gramaj: " + orangeGram + "Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Çilek - " + "Birim Fiyat: " + strawberryPrice + "Gramaj: " + strawberryGram + "Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Patates - " + "Birim Fiyat: " + potatoPrice + "Gramaj: " + potatoGram + "Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Kavun - " + "Birim Fiyat: " + melonPrice + "Gramaj: " + melonGram + "Toplam Tutar: " + melonTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Genel Toplam: " + totalPrice + " TL");


            #endregion

            #region CharDeğişkenler_Variable

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.WriteLine("---- Mali Havayolları Yolcu Bilgisi ----");
            //Console.WriteLine();
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcunun Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcunun Bulunduğu Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Yolcunun Bulunduğu Bölge: ");
            //passengerDistrict = Console.ReadLine();
            //Console.WriteLine();


            //Console.WriteLine("-----------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yaş: " + passengerAge);
            //Console.WriteLine("Kimlik No: " + passengerIdentityNumber);
            //Console.WriteLine("Bulunduğu Bölge ve Şehir: " + passengerDistrict + "/" + passengerCity);
            //Console.WriteLine();



            #endregion

            #region Klavyeden Tamsayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 14000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı miktarını giriniz: ");
            //shoesCount = int.Parse (Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Lütfen aldığınız bilgisayar miktarını giriniz: ");
            //computerCount = int.Parse (Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Lütfen aldığınız sandalye miktarını giriniz: ");
            //chairCount = int.Parse (Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Lütfen aldığınız televizyon miktarını giriniz: ");
            //tvCount = int.Parse (Console.ReadLine());

            //Console.WriteLine();

            //int shoesTotal, computerTotal, chairTotal, tvTotal, totalTotal;
            //shoesTotal = shoesPrice * shoesCount;
            //computerTotal = computerPrice * computerCount;
            //chairTotal = chairPrice * chairCount;
            //tvTotal = tvPrice * tvCount;

            //totalTotal= shoesTotal + computerTotal + chairTotal + tvTotal;

            //Console.WriteLine("Genel Toplam: " +  totalTotal + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Not Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Giriniz: "); 
            gender = char.Parse(Console.ReadLine());  //Tek Karakter Girişine Uygun!!!

            Console.WriteLine();
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion


            Console.Read();

        }
    }
}
