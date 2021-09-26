# hosvet_loscuatro
Tablero para planeación y seguimiento del primer Sprint
using System;

namespace Hostvet.app.Dominio
{
    public class Consulta_auxiliar_paciente
    {
        
    public void MostrarAuxiliar()
        {
            int num1 = 1, num2 = 2, num3 = 3, num4 = 4, num5 = 5;
            Console.WriteLine("Los auxiliares disponibles son: ");
            Console.WriteLine("Auxiliar" + num1);
            Console.WriteLine("Auxiliar" + num2);
            Console.WriteLine("Auxiliar" + num3);
            Console.WriteLine("Auxiliar" + num4);
            Console.WriteLine("Auxiliar" + num5);

        }
        public void Eleccion()
        {
            Console.WriteLine("digite el numero de auxiliar a elegir  ");
            int eleccion;
            eleccion = Convert.ToInt32(Console.ReadLine());
            if(eleccion>=1 && eleccion <= 5)
            {
                if (eleccion == 1)
                {
                    Console.WriteLine("El auxiliar asigando es el : " + eleccion);
                }
                if (eleccion == 2)
                {
                    Console.WriteLine("El auxiliar asigando es el : " + eleccion);
                }
                if (eleccion == 3)
                {
                    Console.WriteLine("El auxiliar asigando es el : " + eleccion);
                }
                if (eleccion == 4)
                {
                    Console.WriteLine("El auxiliar asigando es el : " + eleccion);
                }
                if (eleccion == 5)
                {
                    Console.WriteLine("El auxiliar asigando es el : " + eleccion);
                }
            }
            else
            {
                Console.WriteLine("no disponible");
            }


        }
    }}
            
