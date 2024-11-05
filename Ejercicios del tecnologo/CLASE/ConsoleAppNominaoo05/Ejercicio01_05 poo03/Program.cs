using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_05_poo03
{
    public class Nomina
    {
        private static Empleado[] losEmpleados = new Empleado[50];
        private static int numeroEmpleados = 0;

        public static void Main(string[] args)
        {
            int opcionMenu = 0;

            while (opcionMenu != 3)
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
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, por favor escoja una opción válida.");
                        break;
                }
            }
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\nMenú de Opciones");
            Console.WriteLine("1- Adicionar Empleado");
            Console.WriteLine("2- Calcular Nómina");
            Console.WriteLine("3- Salir");
            Console.Write("Escoja una opción: ");
        }

        private static void AdicionarEmpleado()
        {
            if (numeroEmpleados >= 50)
            {
                Console.WriteLine("No se pueden adicionar más empleados (máximo 50).");
                return;
            }

            Console.Write("Digite la identificación del empleado: ");
            string identificacion = Console.ReadLine();
            Console.Write("Digite el nombre del empleado: ");
            string nombre = Console.ReadLine();
            Console.Write("Digite el número de horas trabajadas: ");
            double horas = Double.Parse(Console.ReadLine());
            Console.Write("Digite el sueldo por hora del empleado: ");
            double sueldo = Double.Parse(Console.ReadLine());

            Empleado unEmpleado = new Empleado(identificacion, nombre, horas, sueldo);
            losEmpleados[numeroEmpleados] = unEmpleado;
            numeroEmpleados++;

            Console.WriteLine($"Empleado {nombre} agregado exitosamente.");
        }

        private static void CalcularNomina()
        {
            if (numeroEmpleados == 0)
            {
                Console.WriteLine("\nNo hay empleados en la nómina.");
                return;
            }

            double totalNomina = 0;
            for (int i = 0; i < numeroEmpleados; i++)
            {
                totalNomina += losEmpleados[i].CalcularSalario();
            }

            Console.WriteLine($"\nEl total de la nómina es: {totalNomina}");
        }
    }
}
