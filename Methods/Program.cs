using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SepetManager sepetManager = new SepetManager();

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Taze Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Tarladan Diyarbakır Karpuzu";

            Product[] products = new Product[] { urun1, urun2 };

            foreach (Product urun in products)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                //Encapsulation
                sepetManager.Ekle(urun);
                Console.WriteLine("--------------------");
                
            }

            Console.WriteLine("-------Methods-------");



            //sepetManager.Ekle();



            Console.ReadLine();
        }
    }
}
