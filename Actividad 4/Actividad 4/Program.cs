using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    internal class Program
    {
        static string jugador1;
        static int setGanados1;
        static string jugador2;
        static int setGanados2;
        static void RegistrarJugadores(string nombre1, string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
        }
        static void RegistrarResultadosSets(int resultado1, int resultado2)
        {
            if (resultado1 > resultado2)
            {
                setGanados1++;
            }
            else
            {
                setGanados2++;
            }
        }
        static string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
            {
                return jugador1;
            }
            else
            {
                return jugador2;
            }
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            int opcion;
            Console.WriteLine("1- Registrar los nombres de los jugadores");
            Console.WriteLine("2- Registrar los resultados de cada set");
            Console.WriteLine("3- Mostrar el ganador");
            Console.WriteLine("4- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.WriteLine("Ingrese el nombre del jugador 1");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del jugador 2");
            string nombre2 = Console.ReadLine();
            RegistrarJugadores(nombre1, nombre2);
        }
        static void MostrarPantallaSolicitarResultado()
        {
            Console.WriteLine("Ingrese el resultado del jugador 1: ");
            int resultado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del jugador 2:");
            int resultado2 = Convert.ToInt32(Console.ReadLine());
            RegistrarResultadosSets(resultado1, resultado2);
        }
        static void MostrarPantallaDeterminarGanador()
        {
            Console.WriteLine("El ganador es " + DeterminarGanador());
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaSolicitarNombreJugadores(); break;
                    case 2: MostrarPantallaSolicitarResultado(); break;
                    case 3: MostrarPantallaDeterminarGanador(); break;
                    case 4: Console.WriteLine("SALIENDO"); break;
                }
            }
            while (opcion != 4);
        }
    }

}
