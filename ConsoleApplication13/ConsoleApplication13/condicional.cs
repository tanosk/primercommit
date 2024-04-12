using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod1;
            int stockact;

        
            Console.WriteLine("Ingrese su producto");
                      prod1=Console.ReadLine();

            Console.WriteLine("Ingrese stock actual");
                      stockact=Convert.ToInt32(Console.ReadLine());

           
            if (stockact <= 5)

            {

                Console.WriteLine("Debe reponer este producto");

            } else {
            
               Console.WriteLine("Su stock es de " + stockact);
            
            }

            Console.ReadLine();

        }
    }
}

       