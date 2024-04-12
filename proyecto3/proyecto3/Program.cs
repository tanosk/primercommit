using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto3
{
    class Program
    {
        static void Main(string[] args)
        {

                  {

            string prod1;
            int stockmin;
            int stockact;


            Console.WriteLine("Ingrese su producto");
                      prod1=Console.ReadLine();
            Console.WriteLine("Ingrese stock minimo");
                      stockmin=Console.ReadLine();
            Console.WriteLine("Ingrese stock actual");
                      stockact=Console.ReadLine();
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

       