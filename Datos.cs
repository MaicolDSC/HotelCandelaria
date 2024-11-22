using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Candelaria_Maicol
{
    internal class Datos: Hotel
    {
        private int n = 50, npersonas; 
        private int[] personas;
        private int[] habitaciones;

        public override void registrar()
        {
            Console.WriteLine("\nDesea realizar una reserva 1.Si 2.No");
            int respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 1)
            {
                habitaciones = new int[n];
                Console.WriteLine("\nFecha en la que se dea hospedar: ");

                Console.Write("Dia: ");
                int dia = int.Parse(Console.ReadLine());

                Console.Write("Mes: ");
                string mes = Console.ReadLine();

                Console.Write("Año: ");
                int año = int.Parse(Console.ReadLine());

                SistemaDeReserva x = new SistemaDeReserva(); //Se hace el llamado a la clase sistema de reserva
                x.crear_vectores();
                x.NumeroHabitaciones();
                x.reservar(dia, mes, año);
            }
            else
            {
                Console.WriteLine("Que tenga un buen dia");
            }

        }
    }
}
