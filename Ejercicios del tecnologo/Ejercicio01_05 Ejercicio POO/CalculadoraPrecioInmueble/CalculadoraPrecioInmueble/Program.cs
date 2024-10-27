using System;

namespace CalculadoraPrecioInmueble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            do
            {
                // Obtener datos del usuario y asignarlos a las propiedades de la calculadora
                Console.Write("Ingrese el área del terreno (metros cuadrados): ");
                calculadora.AreaTerreno = Convert.ToDouble(Console.ReadLine());



                Console.Write("Ingrese el costo por metro cuadrado: ");
                calculadora.CostoPorMetroCuadrado = Convert.ToDouble(Console.ReadLine());



                Console.Write("Ingrese el costo total de la infraestructura: ");
                calculadora.CostoInfraestructura = Convert.ToDouble(Console.ReadLine());



                Console.Write("Ingrese el porcentaje de ganancia deseado (%): ");
                calculadora.PorcentajeGanancia = Convert.ToDouble(Console.ReadLine());



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

    public class Calculadora
    {
        private double AreaTerreno { get; set; }
        private double CostoPorMetroCuadrado { get; set; }
        private double CostoInfraestructura { get; set; }
        public double PorcentajeGanancia
        {
            get { return _porcentajeGanancia; }
        }
        private double _porcentajeGanancia;

        public double Formula()
        {
            PorcentajeGanancia /= 100; // Asegurarse que el porcentaje esté en formato decimal
            double valorTerreno = AreaTerreno * CostoPorMetroCuadrado;
            double valorTotal = valorTerreno + CostoInfraestructura;
            double ganancia = valorTotal * PorcentajeGanancia;
            double precioVenta = valorTotal + ganancia;
            return precioVenta;
        }
    }
}