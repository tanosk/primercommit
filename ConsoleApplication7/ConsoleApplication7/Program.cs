using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingrese su primer numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su segundo numero ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write(" La suma es " + (num1 + num2));
            Console.ReadKey();

        }
    }
}
