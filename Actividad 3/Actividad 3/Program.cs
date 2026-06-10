using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Program
    {
        static string nombre0;
        static int numeroLibreta0;
        static string nombre1;
        static int numeroLibreta1;
        static string nombre2;
        static int numeroLibreta2;
        static int orden; 
        static void RegistrarNombreYNumeroLibreta()
        {
            nombre0 = MostrarPantallaSolicitarAlumnos();
            numeroLibreta0 = SolicitarNumeroDeLibreta();
            nombre1 = MostrarPantallaSolicitarAlumnos();
            numeroLibreta1 =  SolicitarNumeroDeLibreta();
            nombre2 = MostrarPantallaSolicitarAlumnos();
            numeroLibreta2= SolicitarNumeroDeLibreta();
        }
        static int MostrarPantallaSolicitarMenu()
        {
            int opcion;
            Console.WriteLine("1- Registrar el nombre y la nota de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("3- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static string MostrarPantallaSolicitarAlumnos()
        {
            string nombre;
            Console.WriteLine("Ingrese el nombre del alumno del alumno");
            nombre = Console.ReadLine();
            return nombre; 
        }
        static int SolicitarNumeroDeLibreta()
        {
            int numeroLibreta;
            Console.WriteLine("Ingrese el numero de libreta"); 
            numeroLibreta = Convert.ToInt32(Console.ReadLine());
            return numeroLibreta;
        }
        static void MostrarPantallaMostrarListaOrdenada()
        {
            if (numeroLibreta0 > numeroLibreta1 && numeroLibreta0 > numeroLibreta2)
            {
                if (numeroLibreta1 > numeroLibreta2)
                {
                    Console.WriteLine(nombre0 + " / " + numeroLibreta0 + "\n" + nombre1 + " / " + numeroLibreta1 + "\n" + nombre2 + " / " + numeroLibreta2);
                }
                else
                {
                    Console.WriteLine(nombre0 + " / " + numeroLibreta0 + "\n" + nombre2 + " / " + numeroLibreta2 + "\n" + nombre1 + " / " + numeroLibreta1);
                }
            }
            else if (numeroLibreta1 > numeroLibreta0 && numeroLibreta1 > numeroLibreta2)
            {
                if (numeroLibreta0 > numeroLibreta2)
                {
                    Console.WriteLine(nombre1 + " / " + numeroLibreta1 + "\n" + nombre0 + " / " + numeroLibreta0 + "\n" + nombre2 + " / " + numeroLibreta2);
                }
                else
                {
                    Console.WriteLine(nombre1 + " / " + numeroLibreta1 + "\n" + nombre2 + " / " + numeroLibreta2 + "\n" + nombre0 + " / " + numeroLibreta0);
                }
            }
            else if (numeroLibreta2 > numeroLibreta0 && numeroLibreta2 > numeroLibreta1)
            {
                if (numeroLibreta0 > numeroLibreta1)
                {
                    Console.WriteLine(nombre2 + " / " + numeroLibreta2 + "\n" + nombre0 + " / " + numeroLibreta0 + "\n" + nombre1 + " / " + numeroLibreta1);
                }
                else
                {
                    Console.WriteLine(nombre2 + " / " + numeroLibreta2 + "\n" + nombre1 + " / " + numeroLibreta1 + "\n" + nombre0 + " / " + numeroLibreta0);
                }
            }
        }
        
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarMenu();
                switch (opcion)
                {
                    case 1: RegistrarNombreYNumeroLibreta(); break;
                    case 2: MostrarPantallaMostrarListaOrdenada(); break;
                    case 3: Console.WriteLine("Saliendo"); break;
                }
            }
            while (opcion != 3);
        }
    }
}
