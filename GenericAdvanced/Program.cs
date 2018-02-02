using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Zadaj a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadaj b");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zadali ste a: " + a + " " + "Zadali ste b:" + b);
                        
            Swapper.Swap<int>(ref a, ref b);
                        
            Console.WriteLine("Teraz je a:" + a + " " + "becko je:" + b );
            


            string s1 = "ahoj";

            string s2 = "cav";

            Swapper.Swap<string>(ref s1, ref s2);

            Console.WriteLine(s1 + " " + s2);
            */

            Osobak osobak1 = new Osobak(); // pozreme cez break point
            osobak1.VykonMotoru = 225;
            Osobak osobak2 = new Osobak() { VykonMotoru = 99 };

            Nakladak n1 = new Nakladak() { VykonMotoru = 500 };
            Nakladak n2 = new Nakladak() { VykonMotoru = 999 };

            SpravcaAut<Nakladak> spravcaNakladakov = new SpravcaAut<Nakladak>(); // moze byt nakladak / osobak lebo dedia z auta
            SpravcaAut<Osobak> spravcaOsobakov = new SpravcaAut<Osobak>();
            spravcaOsobakov.PrehodMotor(osobak1,osobak2);
            spravcaNakladakov.PrehodMotor(n1,n2);

            Console.WriteLine(n1.VykonMotoru);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
