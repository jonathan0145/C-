using System;

namespace CalculadoraPrecioInmueble
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // Declaración de variables
                double areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia, valorTerreno, valorTotal, ganancia, precioVenta;

                // Obtener datos del usuario
                Console.Write("Ingrese el área del terreno (metros cuadrados): ");
                areaTerreno = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el costo por metro cuadrado: ");
                costoPorMetroCuadrado = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el costo total de la infraestructura: ");
                costoInfraestructura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el porcentaje de ganancia deseado (%): ");
                porcentajeGanancia = Convert.ToDouble(Console.ReadLine());

                // Validar datos
                if (areaTerreno <= 0 || costoPorMetroCuadrado <= 0 || costoInfraestructura <= 0)
                {
                    Console.WriteLine("Los valores ingresados deben ser positivos.");
                    continue; // Vuelve al inicio del bucle
                }

                // Realizar el cálculo
                porcentajeGanancia /= 100;
                valorTerreno = areaTerreno * costoPorMetroCuadrado;
                valorTotal = valorTerreno + costoInfraestructura;
                ganancia = valorTotal * porcentajeGanancia;
                precioVenta = valorTotal + ganancia;

                // Mostrar resultado
                Console.WriteLine("El precio de venta total es: " + precioVenta);

                Console.Write("¿Desea calcular el precio de otro inmueble? (1 para sí, otro número para no): ");
            } while (Convert.ToInt32(Console.ReadLine()) == 1);
        }
    }
}