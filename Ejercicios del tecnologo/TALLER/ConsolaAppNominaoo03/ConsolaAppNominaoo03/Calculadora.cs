using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAppNominaoo03
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            Venta[] ventas = new Venta[50];
            double areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia;

            double gananciaTotal = 0;
            int i = 0;
            int casa = 1;
            do
            {

                if (i < ventas.Length)
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
                
                    ventas[i] = new Venta(casa,areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia);

                    if (ventas[i].AreaTerreno <= 0 || ventas[i].CostoPorMetroCuadrado <= 0 || ventas[i].CostoInfraestructura <= 0)
                    {
                        Console.WriteLine("Los valores ingresados deben ser positivos.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"El precio de venta es: {ventas[i].FormulaVenta()}\n");
                        gananciaTotal += ventas[i].FormulaVenta();
                    }
                    Console.WriteLine("Presione 1 si desea digitar informacion de otro inmueble o finalice presionando cualquier otra tecla");
                    casa++;
                    i++;
                }
                else
                {
                    Console.WriteLine("No se puede ingresar mas datos debido a que excede al limite permitido");
                }
            }
            while (Convert.ToInt32(Console.ReadLine()) == 1);

            Console.WriteLine($"El precio de venta de todos los inmuebles es: {gananciaTotal}\n");
        }
    }
}
