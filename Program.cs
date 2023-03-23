using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methode_kreis_aufga
{
    class Program
    {
        static void Main(string[] args)
        {
            double ra;
            double erg;
            
           
           ra =Eingabe() ;
            erg = Flasche(ra);
            Console.WriteLine(" die Kreisfläche beträgt:" + Math.Round(erg,2));
            Console.ReadLine();
        }
        static double Eingabe( )
        {
             Console.WriteLine("Geben sie ein radios ein");
             double ra=Convert.ToDouble(Convert.ToDouble(Console.ReadLine()));
            return ra;
        }
        static double Flasche(double r)
        {
            double area;
            area = Math.Pow(r, 2) * Math.PI;
            return area;

        }      
    }
}
