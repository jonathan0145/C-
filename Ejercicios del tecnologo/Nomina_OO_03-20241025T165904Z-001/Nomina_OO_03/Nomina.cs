using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaOO03
{
    public class Nomina
    {
        public static void Main(string[] args)
        {
            int opcionMenu = 0;
            int numeroEmpleados = 0;
            Empleado[] losEmpleados = new Empleado[50];
            string identificacion, nombre;
            double horas, sueldo;
            double total = 0;

            while (opcionMenu != 3)
            {
                Console.WriteLine("\nMenu de Opciones");
                Console.WriteLine("1- Adicionar Empleado");
                Console.WriteLine("2- Calcular Nómina");
                Console.WriteLine("3- Salir");
                Console.Write("Escoja una opción: ");
                opcionMenu = Int32.Parse(Console.ReadLine());

                if (opcionMenu == 1)
                {
                    if (numeroEmpleados < 50)
                    {
                        Console.Write("Digite la identificación del empleado: ");
                        identificacion = Console.ReadLine();
                        Console.Write("Digite el nombre del empleado: ");
                        nombre = Console.ReadLine();
                        Console.Write("Digite el número de horas trabajadas: ");
                        horas = Double.Parse(Console.ReadLine());
                        Console.Write("Digite el sueldo por hora del empleado: ");
                        sueldo = Double.Parse(Console.ReadLine());

                        Empleado unEmpleado = new Empleado(identificacion, nombre, horas, sueldo);
                        losEmpleados[numeroEmpleados] = unEmpleado;
                        numeroEmpleados++;
                    }
                    else
                    {
                        Console.WriteLine("No se pueden adicionar más empleados (máximo 50).");
                    }
                }
                else if (opcionMenu == 2)
                {
                    total = 0;
                    if (numeroEmpleados > 0)
                    {
                        for (int i = 0; i < numeroEmpleados; i++)
                        {
                            total += losEmpleados[i].CalcularSalario();
                        }
                        Console.WriteLine("\nEl total de la nómina es: " + total);
                    }
                    else
                    {
                        Console.WriteLine("\nNo hay empleados en la nómina.");
                    }
                }
                else if (opcionMenu == 3)
                {
                    Console.WriteLine("Saliendo del programa...");
                }
                else
                {
                    Console.WriteLine("Opción inválida, por favor escoja una opción válida.");
                }
            }
        }
    }

}
