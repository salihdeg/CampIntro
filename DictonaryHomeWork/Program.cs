using System;
using System.Collections.Generic;

namespace DictionaryHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> myDictonary = new MyDictonary<int, string>();
            myDictonary.Add(1, "Bilgisayarlar");
            myDictonary.Add(2, "Ev Eşyaları");
            myDictonary.Add(3, "Moda");
            myDictonary.Add(4, "Kozmetik");
            myDictonary.Add(5, "Spor");
            myDictonary.Add(6, "Kitap");

            Console.WriteLine("Kategoriler: ->>>>\n");
            for (int i = 0; i < myDictonary.Length; i++)
            {
                Console.WriteLine("Kodu: " + myDictonary.Keys[i] + " Adı: " + myDictonary.Values[i]);
            }
        }
    }
}
