using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            string prod1;
            int stockmin;
            int stockact;


            Console.WriteLine("Ingrese su producto");
            Console.WriteLine("Ingrese stock minimo");
            Console.WriteLine("Ingrese stock actual");

            if (stockmin <= 5)
            {

                Console.WriteLine("Debe reponer este producto");
            } else {
            
               Console.WriteLine("Su stock es de " + stockact);
            
            }

            Console.ReadLine();

        }
    }
}
