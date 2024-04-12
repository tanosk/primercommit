using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo = 140000, venta, obj1,obj2;
            Console.WriteLine("Ingrese el monto de su venta ");
            venta = double.Parse(Console.ReadLine());
          
            if (venta <= 1000000)
            {
                obj1 = (venta * .03);
                sueldo = sueldo + obj1;
                Console.WriteLine("Su comision es de " + obj1 + " y su sueldo total es de $" + sueldo);
             
                Console.ReadLine();
            }
            else if (venta >1000000 && venta <3000000)
                { 
                    obj2=(venta - 1000000)*.04;
                    obj1=(1000000 *.03);
                    sueldo = sueldo + obj1 + obj2;
                    Console.WriteLine("Al alcanzar el objetivo 2,  su comison es de " + ( obj2 + obj1) + " y su sueldo total es de $" + sueldo);
                    Console.ReadLine();
                }

            Console.ReadKey();



        }
    }
}
