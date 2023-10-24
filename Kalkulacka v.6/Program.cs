using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka_v._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka kalkulacka = new Kalkulacka();

            kalkulacka.ZadaniCisla();

            string prvniCisloText = Console.ReadLine();

            if (prvniCisloText == "X")
            {
                Console.WriteLine("Kalkulačka končí.");
                Console.ReadLine();
                return;
            }

            bool jePrvniCisloCislo = double.TryParse(prvniCisloText, out double prvniCislo);

            while (!jePrvniCisloCislo)
            {
                Console.WriteLine("Nezadal jsi číslo, zkus to znovu: ");
                prvniCisloText = Console.ReadLine();
                jePrvniCisloCislo = double.TryParse(prvniCisloText, out prvniCislo);
            }



            while (true)
            {

                Console.WriteLine("Zadej prosím operátor (+ ,  - ,  * ,  / , ^ )");
                string operat1 = Console.ReadLine();

                if (operat1 == "X")
                {
                    Console.WriteLine("Kalkulačka končí.");
                    Console.ReadLine();
                    return;
                }



                while (!kalkulacka.OvereniOperatoru(operat1))
                {
                    Console.WriteLine("Nezadal jsi operátor z nabídky, zkus to prosím znovu:");
                    operat1 = Console.ReadLine();

                    if (operat1 == "X")
                    {
                        Console.WriteLine("Kalkulačka končí.");
                        Console.ReadLine();
                        return;
                    }
                }

                kalkulacka.ZadaniCisla();
                string cisloText = Console.ReadLine();

                if (cisloText == "X")
                {
                    Console.WriteLine("Kalkulačka končí.");
                    Console.ReadLine();
                    return;
                }

                double cislo;
                bool jeCisloCislo = double.TryParse(cisloText, out cislo);



                while (!jeCisloCislo)
                {
                    Console.WriteLine("Nezadal jsi číslo, zkus to znovu: ");
                    cisloText = Console.ReadLine();

                    if (cisloText == "X")
                    {
                        Console.WriteLine("Kalkulačka končí.");
                        Console.ReadLine();
                        return;
                    }

                    jeCisloCislo = double.TryParse(cisloText, out cislo);
                }



                double vysledek = 1;

                if (operat1 == "+")
                {
                    vysledek = kalkulacka.Scitani(prvniCislo, cislo);

                }

                else if (operat1 == "-")
                {
                    vysledek = kalkulacka.Odcitani(prvniCislo, cislo);
                }

                else if (operat1 == "*")
                {
                    vysledek = kalkulacka.Nasobeni(prvniCislo, cislo);
                }

                else if (operat1 == "/")
                {
                    vysledek = kalkulacka.Deleni(prvniCislo, cislo);
                }

                else if (operat1 == "^")
                {
                    vysledek = kalkulacka.Mocneni(prvniCislo, cislo);
                }

                Console.WriteLine("Výsledek: {0} {1} {2} = {3}", prvniCislo, operat1, cislo, vysledek);

                prvniCislo = vysledek;

            }





        }
    }
}
