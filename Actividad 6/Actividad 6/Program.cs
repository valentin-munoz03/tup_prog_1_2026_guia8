using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6
{
    internal class Program
    {
        
        static int indecisos;
        static int negativos;
        static int positivos;
        static double porcentajeIndecisos; 
        static double porcentajeNegativos;
        static double porcentajePositivos;
        
        static void RegistrarOpinion(int opinion)
        {
            if (opinion  == 0)
            {
                positivos++; 
            }
            if (opinion == 1)
            {
                negativos++;
            }
            if (opinion == 2)
            {
                indecisos++;
            }
        }
        
        static void ProcesarEncuesta()
        {
            int total = indecisos + negativos + positivos;
            porcentajeIndecisos = (indecisos * 100.0) / total;
            porcentajeNegativos = (negativos * 100.0) / total;
            porcentajePositivos = (positivos * 100.0) / total; 
        }
         
        static int MostrarPantallaSolicitarMenu()
        {
            Console.WriteLine("1- Registrar opinion");
            Console.WriteLine("2- Procesar y mostrar resultados encuesta");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        
        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.WriteLine("Ingrese una opinion");
            Console.WriteLine("0- Positivo");
            Console.WriteLine("1- Negativo");
            Console.WriteLine("2- Indecisos");
            int opcion = Convert.ToInt32(Console.ReadLine());
            RegistrarOpinion(opcion);
        }
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            ProcesarEncuesta();
           int totalencuestados = negativos + positivos + indecisos;
            Console.WriteLine($"La cantidad total de encuestados son {totalencuestados}");
            Console.WriteLine($"El porcentaje de negativos es: {porcentajeNegativos}%");
            Console.WriteLine($"El porcentaje de positivos es: {porcentajePositivos}%");
            Console.WriteLine($"El porcentaje de indecisos es: {porcentajeIndecisos}%");
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaRegistrarEncuesta(); break;
                    case 2: MostrarPantallaProcesarMostrarResultadosEncuesta(); break;
                    case 3: Console.WriteLine("Saliendo..."); break;
                }

            }
            while (opcion != 3);
        }
    }
}
