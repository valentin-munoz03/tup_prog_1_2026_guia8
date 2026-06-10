using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    internal class Program
    {
        static int edad0;
        static int edad1;
        static int edad2;
        static int edad3;
        static double Monto;
        static double porcentaje0; 
        static double porcentaje1;
        static double porcentaje2;  
        static double porcentaje3;
        static double monto0; 
        static double monto1;
        static double monto2;
        static double monto3;   
        static void RegistrarMontoARepartir(double monto)
        {
            Monto = monto;              
        }
        static void RegistrarEdad()
        {
            Console.WriteLine("Ingrese la edad de la primer niña");
            edad0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la segunda niña");
            edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la tercer niña");
            edad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la edad de la cuarta niña");
            edad3 = Convert.ToInt32(Console.ReadLine());
        }
        static void CalcularMontosYPorcentajesARepartir()
        {
            int SumaEdades; 
            SumaEdades = edad0 + edad1 + edad2 + edad3;
            porcentaje0 = (edad0 * 100) / SumaEdades;
            porcentaje1 = (edad1 * 100) / SumaEdades;
            porcentaje2 = (edad2 * 100) / SumaEdades;
            porcentaje3 = (edad3 * 100) / SumaEdades;
            monto0 = (Monto * porcentaje0) / 100;
            monto1 = (Monto * porcentaje1) / 100;
            monto2 = (Monto * porcentaje2) / 100;
            monto3 = (Monto * porcentaje3) / 100;
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            int opcion;
            Console.WriteLine("1- Iniciar monto edad");
            Console.WriteLine("2- Solicitar edad por niña");
            Console.WriteLine("3- Mostrar monto y porcentajes que corresponde a cada niña");
            Console.WriteLine("4- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            int monto; 
            Console.WriteLine("Ingrese el monto a repartir");
            monto = Convert.ToInt32(Console.ReadLine());
            RegistrarMontoARepartir(monto);
        }
        static void MostrarPantallaSolicitarEdadesDeLasNiñas()
        {
            RegistrarEdad();
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            CalcularMontosYPorcentajesARepartir();
            Console.WriteLine($"El monto de la niña con edad {edad0} es {monto0} y el porcentaje es {porcentaje0}%");
            Console.WriteLine($"El monto de la niña con edad {edad1} es {monto1} y el porcentaje es {porcentaje1}%");
            Console.WriteLine($"El monto de la niña con edad {edad2} es {monto2} y el porcentaje es {porcentaje2}%");
            Console.WriteLine($"El monto de la niña con edad {edad3} es {monto3} y el porcentaje es {porcentaje3}%");
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaSolicitarMontoARepartir(); break;
                    case 2: MostrarPantallaSolicitarEdadesDeLasNiñas(); break;
                    case 3: MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña(); break;
                    case 4: Console.WriteLine("SALIENDO"); break;
                }

            } 
            while (opcion != 4);
        }   
    }
}
