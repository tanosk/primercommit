using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            int num3;

            Console.WriteLine("Ingrese el primero de los 3 numeros");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo de los 3 numeros");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercero de los 3 numeros");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num2>num3)
            {
                Console.WriteLine("El numero " + num1 + " es el mayor de los 3");

            }
            else if (num2 > num1 && num1>num3)
            {

                Console.WriteLine("El numero " + num2 + " es el mayor de los 3");

            }
            else {

                Console.WriteLine("El numero " + num3 + " es el mayor de los 3");
            }

            Console.ReadLine();


        }
    }
}
