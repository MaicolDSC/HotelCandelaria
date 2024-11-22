using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Candelaria_Maicol
{
    internal class HabitacionDisponible:Hotel
    {
        private int n = 50, SencillasAireA = 10, SencillaV = 10, DobleAireA = 10, DobleV = 10, FamiliarAireA = 5, FamiliarV = 5; 

        public override void HabitacionesD()
        {
            Console.WriteLine("\nCantidad de habitaciones en el hotel " + n);

            Console.WriteLine("Habitaciones disponibles: " + n);
            Console.WriteLine("Habitaciones sencillas con aire acondicionado " + SencillasAireA);
            Console.WriteLine("Habitaciones sencillas con ventilador " + SencillaV);
            Console.WriteLine("Habitaciones dobles con aire acondiconado " + DobleAireA);
            Console.WriteLine("Habitaciones dobles con ventilador " + DobleV);
            Console.WriteLine("Habitaciones familiares con aire acondicionado " + FamiliarAireA);
            Console.WriteLine("Habitaciones familiares con ventilador " + FamiliarV);
        }
    }
}
