using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1; 
            double numero2;
            double numero3;
            double prom;

            Console.WriteLine("Ingrese la primera nota");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota");
            numero2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota");
            numero3 = Convert.ToInt32(Console.ReadLine());

            prom = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine("Su promedio es: " + prom);

            Console.ReadKey();
        }
    }
}
