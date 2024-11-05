using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAppNominaoo07
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            CoordinadorVenta inmueble = new CoordinadorVenta(123, new DateTime(2023, 5, 15), "juan");
            int casa=1;
            int i = 0;
            double AreaTerreno;
            double CostoPorMetroCuadrado;
            double CostoInfraestructura;
            double PorcentajeGanancia;
            double total = 0;

            do
            {
                if (i < 50)
                {
                    Console.WriteLine("\n casa numero: " + casa);

                    // Obtener datos del usuario y asignarlos a las propiedades de la calculadora
                    Console.Write("Ingrese el área del terreno (metros cuadrados): ");
                    AreaTerreno = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el costo por metro cuadrado: ");
                    CostoPorMetroCuadrado = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el costo total de la infraestructura: ");
                    CostoInfraestructura = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el porcentaje de ganancia deseado (%): ");
                    PorcentajeGanancia = Convert.ToDouble(Console.ReadLine());

                    inmueble.adicionarInmueble(casa, AreaTerreno, CostoPorMetroCuadrado, CostoInfraestructura, PorcentajeGanancia);

                    if (AreaTerreno <= 0 || CostoPorMetroCuadrado <= 0 || CostoInfraestructura <= 0)
                    {
                        Console.WriteLine("Los valores ingresados deben ser positivos.");
                        continue;
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

            total = inmueble.FormulaVentaTotal();
            Console.WriteLine($"El precio de venta de todos los inmuebles es: {total}\n");
        }
    }
}
