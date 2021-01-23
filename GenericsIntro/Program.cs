using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Salih");
            isimler.Add("Engin");
            isimler.Add("Fatma");
            foreach (string item in isimler.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
