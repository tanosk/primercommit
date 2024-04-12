using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escrituraCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            string producto1;
            int stockmin;
            int stockact;

            Console.WriteLine("Ingrese su producto");
            Console.WriteLine("Ingrese stock minimo");
            Console.WriteLine("Ingrese stock actual");

            if (stockmin <= 5)
            { 
                Console.WriteLine("Tiene que reponer este producto");
          
            } else {
                Console.WriteLine("Su stock actual es " + stockact);
            }

            Console.ReadLine();






        }
    }
}
