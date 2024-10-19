using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jesus_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEmpleados;
            Empleado[] empleados = new Empleado[50];
            double nominaTotal = 0;

            Console.WriteLine("Digite la cantidad de Empleados: ");
            numeroEmpleados = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n Digito la cantidad de Empleados: " + numeroEmpleados);

            for (int i = 0; i < numeroEmpleados; i++)
            {
                empleados[i] = new Empleado();

                Console.WriteLine("\n Digite la identificacion del empleado numero " + (i+1));
                empleados[i].identificaciones = Console.ReadLine();

                Console.WriteLine("Digite el nombre del empleado numero " + (i + 1));
                empleados[i].nombres = Console.ReadLine();

                Console.WriteLine("Digite las horas trabajadas del empleado numero " + (i + 1));
                empleados[i].horasTrabajadas = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite el salario por horas del empleado numero " + (i + 1));
                empleados[i].salarioPorHora = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numeroEmpleados; i++)
            {
                Console.WriteLine("\nInformacion Del empleado numero: " + (i + 1));
                Console.WriteLine("Digito " + empleados[i].identificaciones + " como numero de identificacion.");
                Console.WriteLine("Digito " + empleados[i].nombres + " como nombre.");
                Console.WriteLine("Digito " + empleados[i].horasTrabajadas + " como horas de trabajadas.");
                Console.WriteLine("Digito " + empleados[i].salarioPorHora + " como salario por hora");
            }
            for (int i = 0; i < numeroEmpleados; i++)
            {
                nominaTotal += empleados[i].Formula();
            }
                Console.WriteLine("\nLa nomina total a pagar por el empleado es: " + nominaTotal);
        }
    }
}
