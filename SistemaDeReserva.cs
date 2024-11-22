using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Candelaria_Maicol
{
    internal class SistemaDeReserva:Persona
    {
        private int i, SencillasAireA = 10, SencillaV = 10, DobleAireA = 10, DobleV = 10, FamiliarAireA = 5, FamiliarV = 5; 
        private int m = 20; 
        int ocupada, opcion, j, k, dia_reservado, año_reservado;
        string mes_reservado;

        private int[] habitacionS;
        private int[] habitacionD;
        private int[] habitacionF;
        private int[] reservada;

        public void crear_vectores()
        {
            habitacionS = new int[m];
            habitacionD = new int[m];
            habitacionF = new int[m];
            reservada = new int[m];
        }

        public void NumeroHabitaciones()
        {
            int a = 101, b = 201, c = 301;
            for (int i = 0; i < 20; i++)  
            {
                habitacionS[i] = a;
                a++;
                
            }

            for (int j = 0; j < 20; j++) 
            {
                habitacionD[j] = b;
                b++;
                
            }

            for (int k = 0; k < 20; k++) 
            {
                habitacionF[k] = c;
                c++;
                
            }
        }
        public override void reservar(int dia, string mes, int año)
        {
            Console.Write("\nCantidad de personas que se hospedan en la misma habitacion: ");
            int cpersonas = int.Parse(Console.ReadLine());

            if (cpersonas == 1)
            {
                Console.Write("Desea la habitacion con 1.Aire acondicionado o 2.Ventilador: ");

                for (int i = 0; i < 20; i++)
                {
                    opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        if (dia_reservado == dia)
                        {
                            if (mes_reservado == mes)
                            {
                                if (año_reservado == año)
                                {
                                    Console.Write("Se reserva la habitacion " + habitacionS[i] + " sencilla con Aire acondicionado");
                                }
                            }
                        }

                        reservada[i] = habitacionS[i];  

                        dia_reservado = dia;
                        mes_reservado = mes;
                        año_reservado = año;

                        Persona y = new Persona();
                        y.Datos_Ingresar(cpersonas);

                        Cuenta z = new Cuenta();
                        z.Habitacion_Sencilla_Aireacondicionado();

                    }
                    else
                    {
                        if (opcion == 2)
                        {
                            Console.WriteLine("Se reserva una habitacion " + habitacionS[i + 10] + " sencilla con ventilador");

                            Persona y = new Persona();
                            y.Datos_Ingresar(cpersonas);

                            Cuenta z = new Cuenta();
                            z.Habitacion_Sencilla_Ventilador();
                        }
                    }
                }
            }
            else
            {
                if (cpersonas == 2)
                {
                    Console.Write("Desea la habitacion con 1.Aire acondicionado o 2.Ventilador: ");

                    do
                    {
                        for (j = 0; j < 10; j++)
                        {
                            opcion = int.Parse(Console.ReadLine());
                            if (opcion == 1)
                            {
                                Console.WriteLine("Se reserva la habitacion " + habitacionD[j] + " doble con Aire acondicionado");
                                ocupada = 1;

                                Persona y = new Persona();
                                y.Datos_Ingresar(cpersonas);

                                Cuenta z = new Cuenta();
                                z.Habitacion_Doble_Aireacondicionado();
                            }
                            else
                            if (opcion == 2)
                            {
                                Console.WriteLine("Se reserva una habitacion " + habitacionD[j + 10] + " doble con ventilador");
                                ocupada = 1;

                                Persona y = new Persona();
                                y.Datos_Ingresar(cpersonas);

                                Cuenta z = new Cuenta();
                                z.Habitacion_Doble_Ventilador();
                            }

                        }
                    }
                    while (ocupada == 1);

                }
                else
                {
                    if ((cpersonas > 2) && (cpersonas <= 8))
                    {
                        Console.Write("Desea la habitacion con 1.Aire acondicionado o 2.Ventilador: ");

                        do
                        {
                            for (k = 4; k < 10; k++)
                            {
                                opcion = int.Parse(Console.ReadLine());
                                if (opcion == 1)
                                {
                                    Console.WriteLine("Se reserva la habitacion " + habitacionF[k] + " familiar con Aire acondicionado");
                                    ocupada = 1;

                                    Persona y = new Persona();
                                    y.Datos_Ingresar(cpersonas);

                                    Cuenta z = new Cuenta();
                                    z.Habitacion_Familiar_Aireacondicionado();
                                }
                                else
                                if (opcion == 2)
                                {
                                    Console.WriteLine("Se reserva la habitacion " + habitacionF[k + 5] + " familiar con ventilador");
                                    ocupada = 1;
                                   

                                    Persona y = new Persona();
                                    y.Datos_Ingresar(cpersonas);

                                    Cuenta z = new Cuenta();
                                    z.Habitacion_Familiar_Ventilador();

                                }
                            }
                        } while (ocupada == 1);
                    }
                }
            }
        }
    }
}

