using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Candelaria_Maicol
{
    internal class Persona:Hotel
    {
        public override void Datos_Ingresar(int cpersonas) 
        {
            for (int i = 0; i < cpersonas; i++)
            {
                Console.WriteLine("\nDATOS DEL HUESPED QUE SE VA A HOSPEDAR");

                Console.Write("Ingresar el nombre del huesped " + (i + 1) + ": ");
                string nombre = Console.ReadLine();

                Console.Write("Ingresar el apellido del huesped: ");
                string apellido = Console.ReadLine();

                Console.Write("Ingresar el numero de identificacion: ");
                double.Parse(Console.ReadLine());
            }

        }
    }
}
