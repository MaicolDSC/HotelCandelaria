/* 1. El hotel Candelaria que se ubica en el municipio de Río Quito, desea
llevar el registro automatizado de las distintas reservaciones que se
realizan por parte de sus posibles huéspedes.
Para realizar una reserva, el empleado del hotel podrá verificar las
habitaciones que se encuentran disponibles, conociendo la
información de esta (estado cantidad de personas, ventilador o aire
acondicionado). Una vez el huésped indique la fecha en que utilizará
la habitación en concreto, así como la cantidad de personas que se
hospedarán en la misma, es necesario que el sistema reserve la
habitación no permitiendo alquilar dicha habitación a otra persona,
así como que calcule el monto que deberá pagar el usuario por la
reserva de esta.

Nombre: Maicol David Siachoque Cubides
Grupo: 82
Programa: Ingenieria de sistemas
Codigo funte: Autoria propia  */

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Candelaria_Maicol
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Hotel Candelaria");
            Console.WriteLine("==================================================");
            Console.WriteLine("Sistema de Reservas");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Menu De Opciones");


            HabitacionDisponible v = new HabitacionDisponible();
            v.HabitacionesD();

            Datos w = new Datos();
            w.registrar();
        }
    }
}
