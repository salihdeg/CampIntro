using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Salih", "Murat", "Halil" };

            List<string> isimler2 = new List<string> { "Engin", "Salih", "Murat", "Halil" };
            foreach (string item in isimler2)
            {
                Console.WriteLine(item);
            }
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4] + "----" + isimler2.IndexOf("İlker"));
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
