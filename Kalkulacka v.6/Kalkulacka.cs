using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka_v._6
{
    public class Kalkulacka
    {
        
        
        public void ZadaniCisla()
        {
            Console.WriteLine("Zadej číslo: ");
        }

        public double Scitani(double prvniCislo,double cislo)
        {
            return prvniCislo + cislo;
            
        }

        public double Odcitani(double prvniCislo, double cislo)
        {
            return prvniCislo - cislo;
            
        }

        public double Nasobeni(double prvniCislo, double cislo)
        {
            return prvniCislo * cislo;
            
        }
        
        public double Deleni(double prvniCislo, double cislo)
        {
            return prvniCislo / cislo;
            
        }

        public double Mocneni(double prvniCislo, double cislo)
        {
            double vysledek = 1;
            for (int i = 1; i <= cislo; i++)
            {
                
                vysledek *=  prvniCislo;
                
                
            }
            return vysledek;
        }

        public bool OvereniOperatoru(string operat2)
        {
            return operat2 == "+" || operat2 == "-" || operat2 == "*" || operat2 == "/" || operat2 == "^";



        }
            
    }
}
