using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDAD7
{
    class Program
    {
        static void Main(string[] args)
        {
             private string[] empleados;
        private int[,] sueldos;
        private int[] totalSueldos;

        public void cargar() 
        {
            empleados = new string[4];
            sueldos = new int[4, 3];

            Console.Title = "Práctica Profesionalizante II - Métodos en C# y uso de un procedimiento";

            for (int i = 0; i < empleados.Length; i++) 
            {
                Console.Write("Ingrese el nombre del empleado: ");
                empleados[i] = Console.ReadLine();

                for (int j = 0; j < sueldos.GetLength(1); j++) 
                {
                    Console.Write("Ingrese sueldo: ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[i, j] = int.Parse(linea);
                }
            }
        }

        public void calcularSumaSueldos() 
        {
            totalSueldos = new int[4];
            for (int i = 0; i < sueldos.GetLength(0); i++)
            {
                int suma = 0;
                for (int j = 0; j < sueldos.GetLength(1); j++) 
                {
                    suma += sueldos[i, j];
                }
                totalSueldos[i] = suma;
            }
        }

        public void imprimirTotalPagado() 
        {
            Console.WriteLine("Total de los sueldos pagados por empleado.");
            for (int i = 0; i < totalSueldos.Length; i++) 
            {
            Console.WriteLine(empleados[i] + " - " + totalSueldos[i]);
            }
        }

        public void empleadoMayorSueldo() 
        {
            double may = totalSueldos[0];
            string nom = empleados[0];
            for (int i = 0; i < totalSueldos.Length; i++) 
            {
                if (totalSueldos[i] > may) 
                {
                    may = totalSueldos[i];
                    nom = empleados[i];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es " + nom + " que tiene un sueldo de " + may);
        }


        static void Main(string[] args)
        {
            Act_Matriz nuevaMatriz = new Act_Matriz();
            nuevaMatriz.cargar();
            nuevaMatriz.calcularSumaSueldos();
            nuevaMatriz.imprimirTotalPagado();
            nuevaMatriz.empleadoMayorSueldo();
            Console.ReadKey();
        }
    }
}
