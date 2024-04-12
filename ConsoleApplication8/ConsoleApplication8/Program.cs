using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            Console.Write("Ingrese la primer nota ");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota ");
            nota2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la tercer nota ");
            nota3 = int.Parse(Console.ReadLine());
            double promedio = Convert.ToDouble(nota1 + nota2 + nota3) / 3;
            Console.Write("Su numero es " + promedio);

            Console.ReadKey();
        }
    }
}
