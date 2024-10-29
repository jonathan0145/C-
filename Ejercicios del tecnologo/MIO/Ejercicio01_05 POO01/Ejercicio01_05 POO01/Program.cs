using System;


namespace Ejercicio01_05_POO01
{
    internal class Program
    {
        /*quiero hacer que despues de haber digitado varios inmuebles me de el total de cada uno de los datos ingesados el total*/
        static void Main(string[] args)
        {
            double areaT = 0;
            double costoM = 0;
            double costoI = 0;
            double porcentajeG = 0;

            do
            {
                // Obtener datos del usuario y asignarlos a las propiedades de la calculadora
                Console.Write("Ingrese el área del terreno (metros cuadrados): ");
                areaT = Convert.ToDouble(Console.ReadLine());



                Console.Write("Ingrese el costo por metro cuadrado: ");
                costoM = Convert.ToDouble(Console.ReadLine());



                Console.Write("Ingrese el costo total de la infraestructura: ");
                costoI = Convert.ToDouble(Console.ReadLine());



                Console.Write("Ingrese el porcentaje de ganancia deseado (%): ");
                porcentajeG = Convert.ToDouble(Console.ReadLine());

                Calculadora calculadora = new Calculadora(areaT, costoM, costoI, porcentajeG);


                // Validar datos
                if (calculadora.AreaTerreno <= 0 || calculadora.CostoPorMetroCuadrado <= 0 || calculadora.CostoInfraestructura <= 0)
                {
                    Console.WriteLine("Los valores ingresados deben ser positivos.");
                    continue;
                }

                // Calcular el precio de venta utilizando el método Formula
                double precioVenta = calculadora.Formula();
                Console.WriteLine($"El precio de venta es: {precioVenta}\n");

                Console.WriteLine("Presione 1 si desea digitar informacion de otro inmueble o finalice presionando cualquier otra tecla");


            } while (Convert.ToInt32(Console.ReadLine()) == 1);
        }
    }
}
