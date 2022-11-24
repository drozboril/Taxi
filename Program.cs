using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počet ujetých km a vypočítej na základě sazby, kolik zákazník zaplatí");
            double km = double.Parse(Console.ReadLine());
            if (km < 0)
            {
                Console.WriteLine("Chyba zadání");
            }
            while (km >= 0 && km <= 20)
            {
                double a = km * 45;
                Console.WriteLine("Zákazník zaplatí {0} Kč", a);
                Console.ReadLine();
                break;
            }
            while (km >= 20 && km <= 50)
            {
                double a1 = km * 40;
                Console.WriteLine("Zákazník zaplatí {0} Kč", a1);
                Console.ReadLine();
                break;
            }
            while (km >= 50 && km <= 100)
            {
                double a2 = km * 35;
                Console.WriteLine("Zákazník zaplatí {0} Kč", a2);
                Console.ReadLine();
                break;
            }
            while (km > 100)
            {
                double a3 = km * 30;
                Console.WriteLine("Zákazník zaplatí {0} Kč", a3);
                Console.ReadLine();
                break;
            }
        }
    }
}