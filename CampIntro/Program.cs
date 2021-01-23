using System;
using System.Collections.Generic;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rakamlar = new List<int>();
            rakamlar.Add(123);
            rakamlar.Add(21312);
            rakamlar.Add(122131233);
            rakamlar.Add(1098765423);
            int[] sayilar = new int[5];
            sayilar[4] = 25;
            /*foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }*/

            /*for (int i = 0; i < rakamlar.Count; i++)
            {
                Console.WriteLine(rakamlar[i]);
            }*/

            Kurs[] kurslar = new Kurs[] { };

            Product urun1 = new Product();
            urun1.UrunAdi = "Kasa";
            urun1.SaticiAdi = "Kasalar Store";
            urun1.Fiyat = 800;
            urun1.UrunGorsel = @"src\kasa1.webp";

            Product urun2 = new Product();
            urun2.UrunAdi = "İşlemci";
            urun2.SaticiAdi = "İşlemciler Store";
            urun2.Fiyat = 2300;
            urun2.UrunGorsel = @"src\islemci1.webp";

            Product urun3 = new Product();
            urun3.UrunAdi = "Anakart";
            urun3.SaticiAdi = "Anakart Store";
            urun3.Fiyat = 900;
            urun3.UrunGorsel = @"src\anakart1Image.webp";

            Product urun4 = new Product();
            urun4.UrunAdi = "Ekran Kartı Süper";
            urun4.SaticiAdi = "Ekran Kartları Store";
            urun4.Fiyat = 6500;
            urun4.UrunGorsel = @"src\superGpuImage.webp";

            Product[] products = new Product[] {urun1,urun2,urun3,urun4 };
            Console.WriteLine("ForEach");

            foreach (var product in products)
            {
                string ekranMesaji = "Satıcı Adı: " + product.SaticiAdi + "\nÜrün Adı: " + product.UrunAdi + "\nFiyatı: " + product.Fiyat + "\nGörsel: " + product.UrunGorsel;
                Console.WriteLine(ekranMesaji);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("FOR");
            for (int i = 0; i < products.Length; i++)
            {
                string ekranMesaji = "Satıcı Adı: " + products[i].SaticiAdi + "\nÜrün Adı: " + products[i].UrunAdi + "\nFiyatı: " + products[i].Fiyat + "\nGörsel: " + products[i].UrunGorsel;
                Console.WriteLine(ekranMesaji);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("While");
            int counter = 0;
            while (counter<products.Length)
            {
                string ekranMesaji = "Satıcı Adı: " + products[counter].SaticiAdi + "\nÜrün Adı: " + products[counter].UrunAdi + "\nFiyatı: " + products[counter].Fiyat + "\nGörsel: " + products[counter].UrunGorsel;
                Console.WriteLine(ekranMesaji);
                Console.WriteLine();
                counter ++;
            }


            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }

    class Product
    {
        public string UrunAdi { get; set; }
        public string SaticiAdi { get; set; }
        public int Fiyat { get; set; }
        public int MyProperty { get; set; }
        public string UrunGorsel { get; set; }
    }



}
