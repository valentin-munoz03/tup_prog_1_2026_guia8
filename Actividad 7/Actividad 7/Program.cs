using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_7
{
    internal class Program
    {
        static int cantidad1;
        static int cantidad2;
        static int cantidad3;
        static int cantidad4;
        static int cantidad5;
        static int NumeroTransaccionMayor;
        static double montoTransaccionMayor;
        static int ContadorDeTransacciones;
        static double porcentajeCantidadRubro1;
        static double porcentajeCantidadRubro2;
        static double porcentajeCantidadRubro3;
        static double porcentajeCantidadRubro4;
        static double porcentajeCantidadRubro5;
        static double recaudacionTotal; 
        static void inicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            cantidad5 = 0;
            NumeroTransaccionMayor = 0;
            montoTransaccionMayor = 0; 
            ContadorDeTransacciones = 0;
            recaudacionTotal = 0;
        }
        static void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            if (rubro == 1)
                cantidad1 += cantidad;
            else if (rubro == 2)
                cantidad2 += cantidad;
            else if (rubro == 3)
                cantidad3 += cantidad;
            else if (rubro == 4)
                cantidad4 += cantidad;
            else if (rubro == 5)
                cantidad5 += cantidad;

            if (monto > montoTransaccionMayor)
            {
                montoTransaccionMayor = monto;
                NumeroTransaccionMayor = nroTransaccion;
            }

            recaudacionTotal += monto;
        }
        static void CalcularPorcentajesCantidadVentasPorRubro()
        {
            int total = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;
            porcentajeCantidadRubro1 = (cantidad1 * 100) / total;
            porcentajeCantidadRubro2 = (cantidad2 * 100) / total;
            porcentajeCantidadRubro3 = (cantidad3 * 100) / total;
            porcentajeCantidadRubro4 = (cantidad4 * 100) / total;
            porcentajeCantidadRubro5 = (cantidad5 * 100) / total;
        }
        static int MostrarPantallaSolicitarMenu()
        {
            Console.WriteLine("1- Ingresar un resumen de venta.");
            Console.WriteLine("2- Mostrar Número de transacción registrado con el mayor monto total.");
            Console.WriteLine("3- Mostrar porcentaje de cantidad por rubro.");
            Console.WriteLine("4- Mostrar la recaudación total.");
            Console.WriteLine("5- SALIR");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.WriteLine("Ingrese el nro de transaccion");
            int nroT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el rubro");
            int rubro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad");
            int cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el monto");
            double monto = Convert.ToDouble(Console.ReadLine());
            EvaluarTransaccionPuntoDeVenta(nroT,rubro,cant,monto);
        }
        static void MostrarPorcentajeDeCantidadesPorRubro()
        {
               CalcularPorcentajesCantidadVentasPorRubro();
            Console.WriteLine($"El porcentaje del rubro 1 es {porcentajeCantidadRubro1}%");
            Console.WriteLine($"El porcentaje del rubro 2 es {porcentajeCantidadRubro2}%");
            Console.WriteLine($"El porcentaje del rubro 3 es {porcentajeCantidadRubro3}%");
            Console.WriteLine($"El porcentaje del rubro 4 es {porcentajeCantidadRubro4}%");
            Console.WriteLine($"El porcentaje del rubro 5 es {porcentajeCantidadRubro5}%");
        }
        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.WriteLine($"El numero de transaccion mayor es: {NumeroTransaccionMayor}\nEl monto mayor es: {montoTransaccionMayor}");
        }
        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.WriteLine($"El monto total recaudado es {recaudacionTotal}");
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaRegistrarTransaccion(); break;
                    case 2: MostrarPantallaTransaccionMayorMonto(); break;
                    case 3: MostrarPorcentajeDeCantidadesPorRubro(); break;
                    case 4: MostrarPantallaMontoRecaudadoTotal(); break;
                    case 5: Console.WriteLine("Saliendo..."); break;

                }
            }
            while (opcion != 5);

        }
    }
}
