using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Program
    {
        static int acumulador;
        static int contador;
        static int maximo = 0;
        static int minimo = 9999; 
        static void RegistrarValor(int valor)
        {
            acumulador += valor;
            contador++;
            if (valor > maximo)
            {
                maximo = valor;
            }
            if (valor < minimo)
            {
                minimo = valor;
            }
        }
        static double CalcularPromedio()
        {
            double promedio = acumulador / contador;
            return promedio;
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1- Procesar un solo número");
            Console.WriteLine("2- Procesar varios números");
            Console.WriteLine("3- Mostrar máximo y mínimo.");
            Console.WriteLine("4- Mostrar promedio.");
            Console.WriteLine("5- Mostrar cantidad de números ingresados.");
            Console.WriteLine("6- Reiniciar variables");
            Console.WriteLine("7- Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarIniciarVariables()
        {
            acumulador = 0;
            contador = 0;
            maximo = 0;
            minimo = 9999;
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(num);
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            int num;
            Console.WriteLine("Ingrese VARIOS numeros, -1 para salir");
            num = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(num);
            while (num != -1)
            {
                Console.WriteLine("Ingrese VARIOS numeros, -1 para salir");
                num = Convert.ToInt32(Console.ReadLine());
                RegistrarValor(num);
            }
          
        }
        static void MostrarPantallaMaximoYMinimo()
        {
            Console.WriteLine($"El numero maximo es {maximo} y el numero minimo es {minimo}");
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            double promedio = CalcularPromedio();
            Console.WriteLine($"El promedio de los numeros ingresados es {promedio}");
        }
        static void MostrarCantidadDeNumeros()
        {
            Console.WriteLine($"La cantidad de numeros ingresados es {contador}");
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaSolicitarNumero(); break;
                    case 2: MostrarPantallaSolicitarVariosNumeros(); break;
                    case 3: MostrarPantallaMaximoYMinimo(); break;
                    case 4: MostrarPantallaCalcularYMostrarPromedio(); break;
                    case 5: MostrarCantidadDeNumeros(); break;
                    case 6: MostrarIniciarVariables(); break;
                    case 7: Console.WriteLine("saliendo"); break;

                }
            }
            while (opcion != 7);
            
        }
    }
}
