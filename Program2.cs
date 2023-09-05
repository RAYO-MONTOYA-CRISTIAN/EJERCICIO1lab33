using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la categoría del hotel (3 estrellas o 5 estrellas):");
            string categoriaHotel = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese la cantidad de días de estadía:");
            int diasEstadia = int.Parse(Console.ReadLine());
            double precioBasePorDia = 0.0;

            if (categoriaHotel == "3 estrellas")
            {
                if (diasEstadia >= 1 && diasEstadia <= 5)
                    precioBasePorDia = 100.00;
                else if (diasEstadia >= 6 && diasEstadia <= 10)
                    precioBasePorDia = 85.00;
                else if (diasEstadia >= 11)
                    precioBasePorDia = 70.00;
            }
            else if (categoriaHotel == "5 estrellas")
            {
                if (diasEstadia >= 1 && diasEstadia <= 5)
                    precioBasePorDia = 300.00;
                else if (diasEstadia >= 6 && diasEstadia <= 10)
                    precioBasePorDia = 270.00;
                else if (diasEstadia >= 11)
                    precioBasePorDia = 250.00;
            }
            else
            {
                Console.WriteLine("Categoría de hotel no válida.");
                return;
            }
            double costoHospedaje = precioBasePorDia * diasEstadia;
            double costoDesayuno = 7.00 * diasEstadia;
            double costoTotal = costoHospedaje + costoDesayuno;

            Console.WriteLine($"El costo total del hospedaje es: S/{costoTotal}");

            Console.ReadLine();

        }
    }
}
