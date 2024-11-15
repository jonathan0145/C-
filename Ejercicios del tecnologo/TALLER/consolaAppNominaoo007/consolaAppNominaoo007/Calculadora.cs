using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppNominaoo007
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            CoordinadorVenta nuevaVenta = new CoordinadorVenta(12, new DateTime(2023, 11, 7, 10, 30, 0), "jonathan");
            Console.WriteLine("Digite el numero Total de Inmuebles: ");
            int numeroEmpleados = Int32.Parse(Console.ReadLine());
            int casa = 1;

            for (int i = 0; i < numeroEmpleados; i++)
            {
                AdicionarInmueble(nuevaVenta);
            }

            double total = nuevaVenta.FormulaVentaTotal();
            Console.WriteLine($"El Total de los inmuebles valorados es: {total}");
            Console.ReadKey(true);

            void AdicionarInmueble(CoordinadorVenta nuevaventa)
            {
                Console.WriteLine("Seleccione una Opcion: ");
                Console.WriteLine("1. Inmueble Con Todo");
                Console.WriteLine("2. Inmueble Solo Infraestructura");
                Console.WriteLine("3. Inmueble Solo Terreno");

                int opcion = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"El numero de la casa es {casa++}"); /*mirar si toca modificar*/
                Console.WriteLine($"Digite el porcentaje de Ganancia que desea ganar: ");
                double porcentajeGanancia = double.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("INMUEBLE CON TODO");
                        Console.WriteLine("Digite el Area Del Terreno: ");
                        double areaTerreno = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el Costo Por Metro Cuadrado: ");
                        double costoPorMetroCuadrado = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el Costo de la Infraestructura: ");
                        double costoInfraestructura = double.Parse(Console.ReadLine());

                        Inmueble inmuebleConTodo = new InmuebleConTodo(casa, areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia);
                        nuevaVenta.AdicionarInmueble(inmuebleConTodo);

                        break;

                    case 2:
                        Console.WriteLine("INMUEBLE SOLO INFRAESTRUCTURA");
                        Console.WriteLine("Digite el Costo de la Infraestructura: ");
                        double costoInfraestructura1 = Double.Parse(Console.ReadLine());
                        
                        Inmueble inmuebleInfraestructura = new InmuebleInfraestructura(casa, costoInfraestructura1, porcentajeGanancia);
                        nuevaVenta.AdicionarInmueble(inmuebleInfraestructura);
                        break;

                    case 3:
                        Console.WriteLine("INMUEBLE SOLO TERRENO");
                        Console.WriteLine("Digite el Area Del Terreno: ");
                        double areaTerreno1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el Costo Por Metro Cuadrado: ");
                        double costoPorMetroCuadrado1 = double.Parse(Console.ReadLine());

                        Inmueble inmuebleTerreno = new InmuebleTerreno(casa, areaTerreno1, costoPorMetroCuadrado1, porcentajeGanancia);
                        nuevaventa.AdicionarInmueble(inmuebleTerreno);
                        break;
                }
            }
        }
    }
}
