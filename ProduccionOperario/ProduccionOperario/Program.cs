using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionOperario
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int lun, mar, mierc, juev, viern, sab;

            double total, prom;


            Console.WriteLine("Ingrese el nombre del operario");
                name=Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de unidades del dia lunes");
                 lun=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de unidades del dia martes");
                 mar=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de unidades del dia miercoles");
                 mierc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de unidades del dia jueves");
                 juev = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Ingrese la cantidad de unidades del dia viernes");
                 viern = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Ingrese la cantidad de unidades del dia sabado");
                 sab = Convert.ToInt32(Console.ReadLine());


                 total = (lun + mar + mierc + juev + viern + sab);
                 prom = total / 6;

                 if (prom <= 200)
                 {

                     Console.WriteLine( name + " su promedio semanal de unidades vendidas es de " + prom + ", no tiene comisiones.");


                 }else {

                     Console.WriteLine( name + " su promedio semanal de unidades vendidas es de " + prom + ", debe tener comisiones.");
                 }


                 Console.ReadKey();
        }
    }
}
