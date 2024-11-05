using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAppNominaoo05
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            Venta[] venta = new Venta[50];
            int i = 0;
            int casa = 1;
            int opcionMenu = 0;
            double areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia;

            do
            {
                MostrarMenu();
                opcionMenu = Int32.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        AdicionarEmpleado();
                        break;
                    case 2:
                        CalcularNomina();
                        break;
                    default:
                        Console.WriteLine("Opción inválida, por favor escoja una opción válida.");
                        break;
                }

                Console.WriteLine("Presione 1 si desea consultar el (MENU) o otra tecla para (SALIR)");

            }
            while (Convert.ToInt32(Console.ReadLine()) == 1);

            void MostrarMenu()
            {
                Console.WriteLine("\n Menu de Opciones");
                Console.WriteLine("1- Adicionar Inmueble");
                Console.WriteLine("2- Calcular Precio total Inmueble");
                Console.Write("Escoja una opcion:");
            }
            
            void AdicionarEmpleado()
            {
                if(i >= 50)
                {
                    Console.WriteLine("No se pueden adicionar mas Inmuebles (máximo 50).");

                }
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
                Console.WriteLine($"la casa numero: {casa} agregada exitosamente.");
                casa++;


            }

            void CalcularNomina()
            {
                if (i == 0)
                {
                    Console.WriteLine("\nNo hay inmuebles para calcular el total de inmuebles. ");

                    return;
                }

                double total = 0;

                for (int j = 0; j < i; j++)
                {
                    total += venta[j].FormulaVenta();
                }

                Console.WriteLine("\nEl total de los inmuebles es: " + total);

            }
        }
    }
}
