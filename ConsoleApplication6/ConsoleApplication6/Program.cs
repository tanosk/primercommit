using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(String[] args)
        {
            int numero1,numero2;
            Console.Write("Ingerse el primer numero " );
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero " );
            numero2 = int.Parse(Console.ReadLine());
          Console.WriteLine(" El resultado de la suma es " + (numero1 + numero2));
          Console.ReadLine();
        }
    }
}
