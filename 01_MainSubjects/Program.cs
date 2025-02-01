using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("****** Yemek Türleri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Mezeler");
            //Console.WriteLine("6- Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Türleri *****");

            #endregion


            #region StringDeğişkenler_Variable

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Mali";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, district, city;

            //customerName = "Sevda";
            //customerSurname = "Vuran";
            //customerEmail = "svdvrn@gmail.com";
            //customerPhone = "05123456789";
            //district = "Sincan";
            //city = "Ankara";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ahmet";
            //customerSurname = "Kartal";
            //customerEmail = "kartalsizahmet@gmail.com";
            //customerPhone = "0559 455 33 21";
            //district = "tr";
            //city = "TRTR";

            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------------------");

            #endregion


            #region İntDeğişkenler_Variable

            //int
            //int number = 54;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("Kola: " + cokePrice + " TL");
            Console.WriteLine("Su: " + waterPrice + " TL");
            Console.WriteLine("Kızartma: " + friesPrice + " TL");
            Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatları *****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;


            hamburgerCount = 3;
            cokeCount = 2;
            waterCount = 3;
            friesCount = 4;
            pizzaCount = 2;
            lemonadeCount = 2;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            int totaltotalPrice;
            totaltotalPrice= totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL" );
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("Toplam: " + totaltotalPrice + " TL");
            Console.WriteLine("------------------------------------------------");

            #endregion
            Console.Read();

        }
    }
}
