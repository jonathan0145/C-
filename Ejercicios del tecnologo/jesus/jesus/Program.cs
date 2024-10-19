using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaMensual
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroEmpleados;
            string[] identificaciones = new string[50];
            string[] nombres = new string[50];
            double[] horasTrabajadas = new double[50];
            double[] salarioPorHora = new double[50];
            string identificacion, nombre;
            double horas, salario;
            double nominaMensual = 0;

            Console.WriteLine("Digite la cantidad de Empleados: ");
            numeroEmpleados = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numeroEmpleados; i++)
            {
                Console.WriteLine("Digite la Identificacion del Empleado: ");
                identificacion = Console.ReadLine();
                Console.WriteLine("Digite el nombre del Empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Digite las horas trabajadas del Empleado: ");
                horas = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite el salario por horas del Empleado: ");
                salario = Int32.Parse(Console.ReadLine());
                identificaciones[i] = identificacion;
                nombres[i] = nombre;
                horasTrabajadas[i] = horas;
                salarioPorHora[i] = salario;
            }
            for (int i = 0; i < numeroEmpleados; i++)
            {
                nominaMensual += (horasTrabajadas[i] * salarioPorHora[i]);
            }
            Console.WriteLine("El valor total de la Nomina es: " + nominaMensual);
            Console.ReadKey(true);
        }
    }
}