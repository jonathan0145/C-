using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAppNomina00
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] areaTerreno = new double[50];
            double[] costoPorMetroCuadrado = new double[50];
            double[] costoInfraestructura = new double[50];
            double[] porcentajeGanancia = new double[50];
            double[] precioventa = new double[50];
            double valorTerreno, valorTotal, ganancia;
            double total = 0;
            int i = 0, casa = 1;

            do
            {
                if (i < areaTerreno.Length)
                {
                    // Obtener datos del usuario
                    Console.WriteLine("casa numero: " + casa);

                    Console.Write("Ingrese el área del terreno (metros cuadrados): ");
                    areaTerreno[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el costo por metro cuadrado: ");
                    costoPorMetroCuadrado[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el costo total de la infraestructura: ");
                    costoInfraestructura[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el porcentaje de ganancia deseado (%): ");
                    porcentajeGanancia[i] = Convert.ToDouble(Console.ReadLine());

                    // Validar datos
                    if (areaTerreno[i] <= 0 || costoPorMetroCuadrado[i] <= 0 || costoInfraestructura[i] <= 0)
                    {
                        Console.WriteLine("Los valores ingresados deben ser positivos.");
                        continue; // Vuelve al inicio del bucle
                    }
                    else
                    {
                        // Realizar el cálculo
                        porcentajeGanancia[i] /= 100;
                        valorTerreno = areaTerreno[i] * costoPorMetroCuadrado[i];
                        valorTotal = valorTerreno + costoInfraestructura[i];
                        ganancia = valorTotal * porcentajeGanancia[i];
                        precioventa[i] = valorTotal + ganancia;
                        total += precioventa[i];
                    }

                    Console.WriteLine("El precio de venta es: " + precioventa[i]);

                    // Mostrar resultado

                    Console.Write("¿Desea calcular el precio de otro inmueble? (1 para sí, otro número para no): ");
                    i++;
                    casa++;
                }
                else
                {
                    Console.WriteLine("No se puede ingresar mas datos debido a que excede al limite permitido");
                }

            } while (Convert.ToInt32(Console.ReadLine()) == 1);

            Console.WriteLine($"El precio de venta de todos los inmuebles es: {total}\n");

        }
    }
}
