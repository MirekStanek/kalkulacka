using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Zacatek:
            Console.Write("\n1. Sčítání \n2.Odčítání \n3. Násobení \n4. Dělení \n5.Mocniny \n6. Procenta\n");
            Console.Write("Vyber si operaci: ");
            int operace = Convert.ToInt32(Console.ReadLine());
            if (operace == 1)
            {
                Console.Write("Sčítanec 1: ");
                double scitanec_1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sčítanec 2: ");
                double scitanec_2 = Convert.ToDouble(Console.ReadLine());
                double soucet = scitanec_1 + scitanec_2;
                Console.Write("Součet: " + soucet);
            }
            else if (operace == 2)
            {
                Console.Write("Menšenec: ");
                double mensenec = Convert.ToDouble(Console.ReadLine());
                Console.Write("Menšitel: ");
                double mensitel = Convert.ToDouble(Console.ReadLine());
                double rozdil = mensenec - mensitel;
                Console.Write("Součet: " + rozdil);
            }
            else if (operace == 3)
            {
                Console.Write("Činitel 1: ");
                double cinitel_1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Činitel 2: ");
                double cinitel_2 = Convert.ToDouble(Console.ReadLine());
                double soucin = cinitel_1 * cinitel_2;
                Console.Write("Součin: " + soucin);
            }
            else if (operace == 4)
            {
                Console.Write("Dělenec: ");
                double delenec = Convert.ToDouble(Console.ReadLine());
                Console.Write("Dělitel: ");
                double delitel = Convert.ToDouble(Console.ReadLine());
                double podil = delenec / delitel;
                Console.Write("Podíl: " + podil);
            }
            else if (operace == 5)
            {
                Console.Write("Zadej mocninu: ");
                int mocnina = Convert.ToInt32(Console.ReadLine());
                int vysledek = mocnina * mocnina;
                Console.Write("Výsledek: " + vysledek);
            }
            else if (operace == 6)
            {
                Console.Write("Hodnota: ");
                double hodnota = Convert.ToDouble(Console.ReadLine());
                double operace1 = hodnota / 100;
                Console.Write("1% z hodnoty: " + operace1);
                Console.Write("\nZadej kolik chceš počet %: ");
                double procenta = Convert.ToDouble(Console.ReadLine());
                double operace_2 = operace1 * procenta;
                Console.Write("Počet % z hodnoty: " + operace_2);
            }

            Console.ReadKey();
            goto Zacatek;
        }
    }
}
