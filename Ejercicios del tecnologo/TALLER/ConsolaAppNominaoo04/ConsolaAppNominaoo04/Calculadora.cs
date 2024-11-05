using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAppNominaoo04
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            int opcionMenu = 0;
            int casa = 1;
            int i = 0;
            double total = 0;
            Venta[] venta = new Venta[50];
            double areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia;

            do
            {
                Console.WriteLine("\n Menu de Opciones");
                Console.WriteLine("1- Adicionar Inmueble");
                Console.WriteLine("2- Calcular Precio total Inmueble");
                Console.Write("Escoja una opcion:");
                opcionMenu = Int32.Parse(Console.ReadLine());

                if (opcionMenu == 1)
                {
                    if (i < 50)
                    {
                        
                        Console.WriteLine("\n casa numero: " + casa);

                        // Obtener datos del usuario y asignarlos a las propiedades de la calculadora
                        Console.Write("Ingrese el área del terreno (metros cuadrados): ");
                        areaTerreno = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese el costo por metro cuadrado: ");
                        costoPorMetroCuadrado = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese el costo total de la infraestructura: ");
                        costoInfraestructura = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Ingrese el porcentaje de ganancia deseado (%): ");
                        porcentajeGanancia = Convert.ToDouble(Console.ReadLine());

                        Venta unaVenta = new Venta(casa, areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia);
                        venta[i] = unaVenta;

                        i++;
                        casa++;
                    }
                    else
                    {
                        Console.WriteLine("No se pueden adicionar mas Inmuebles (máximo 50).");

                    }
                }
                else if (opcionMenu == 2)
                {
                    total = 0;

                    if (i > 0)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            total += venta[j].FormulaVenta();

                        }
                            Console.WriteLine("\nEl total de los inmuebles es: " + total);
                    }
                    else
                    {
                        Console.WriteLine("\nNo hay inmuebles para calcular el total de inmuebles. ");

                    }
                }

                Console.WriteLine("Presione 1 si desea consultar el (MENU)");
            }
            while (Convert.ToInt32(Console.ReadLine()) == 1);
        }
    }
}
