using System;

namespace ConsoleAppNominaoo02
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            Venta[] ventas = new Venta[50];
            int i = 0;
            int casa = 1;
            double areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia;
            double total=0;
            double valorTerreno, valorTotal, ganancia, precioVenta;

            do
            {
                if (i<ventas.Length)
                {
                    // Obtener datos del usuario y asignarlos a las propiedades de la calculadora
                    Console.WriteLine("casa numero: " + casa);

                    Console.Write("Ingrese el área del terreno (metros cuadrados): ");
                    areaTerreno = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el costo por metro cuadrado: ");
                    costoPorMetroCuadrado = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el costo total de la infraestructura: ");
                    costoInfraestructura = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el porcentaje de ganancia deseado (%): ");
                    porcentajeGanancia = Convert.ToDouble(Console.ReadLine());

                    Venta venta = new Venta();
                    ventas[i] = venta;
                    ventas[i].casa = casa;
                    ventas[i].AreaTerreno = areaTerreno;
                    ventas[i].CostoPorMetroCuadrado = costoPorMetroCuadrado;
                    ventas[i].CostoInfraestructura = costoInfraestructura;
                    ventas[i].PorcentajeGanancia = porcentajeGanancia;



                    // Validar datos
                    if (areaTerreno <= 0 || costoPorMetroCuadrado <= 0 || costoInfraestructura <= 0)
                    {
                        Console.WriteLine("Los valores ingresados deben ser positivos.");
                        continue;
                    }
                    else
                    {

                        ventas[i].PorcentajeGanancia /= 100; // Asegurarse que el porcentaje esté en formato decimal
                        valorTerreno = ventas[i].AreaTerreno * ventas[i].CostoPorMetroCuadrado;
                        valorTotal = valorTerreno + ventas[i].CostoInfraestructura;
                        ganancia = valorTotal * ventas[i].PorcentajeGanancia;
                        precioVenta = valorTotal + ganancia;
                        ventas[i].PrecioVenta = precioVenta;
                        total += ventas[i].PrecioVenta;


                    }
                    // Calcular el precio de venta utilizando el método Formula

                    Console.WriteLine($"El precio de venta es: {precioVenta}\n");

                    Console.WriteLine("Presione 1 si desea digitar informacion de otro inmueble o finalice presionando cualquier otra tecla");
                    i++; /* me sirve para limitar las veces de repeticion del bucle y no sea mayor a la longitud del arreglo*/
                    casa++; /*es el numero de casa de cada objeto*/
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
