using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Empresa miPyme = new Empresa("123456", "Acme", "silicon valley");
            string identificacion, nombre;
            double total = 0;

            Console.Write("Digite el numero de Empleados Sueldo Fijo: ");
            int numeroEmpleados1 = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numeroEmpleados1; i++)
            {
                double sueldoFijo;
                Console.WriteLine("Digite la Identificacion del Empleado: ");
                identificacion = Console.ReadLine();
                Console.WriteLine("Digite el nombre del Empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Digite el sueldo fijo del Empleado: ");
                sueldoFijo = Int32.Parse(Console.ReadLine());

                miPyme.adicionarEmpleadoSueldoFijo(identificacion, nombre, sueldoFijo);
            }

            Console.Write("Digite el numero de Empleados Sueldo por Hora: ");
            int numeroEmpleados2 = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numeroEmpleados2; i++)
            {
                double horasTrabajadas, sueldoXHora;
                Console.WriteLine("Digite la Identificacion del Empleado: ");
                identificacion = Console.ReadLine();
                Console.WriteLine("Digite el nombre del Empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Digite las Horas trabajadas del Empleado: ");
                horasTrabajadas = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite el sueldo por Hora del Empleado: ");
                sueldoXHora = Int32.Parse(Console.ReadLine());

                miPyme.adicionarEmpleadoSueldoXHora(identificacion, nombre, horasTrabajadas, sueldoXHora);
            }

            Console.Write("Digite el numero de Empleados Sueldo por Comision: ");
            int numeroEmpleados3 = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numeroEmpleados3; i++)
            {
                double sueldoBasico, porcentaje, ventasTotales;
                Console.WriteLine("Digite la Identificacion del Empleado: ");
                identificacion = Console.ReadLine();
                Console.WriteLine("Digite el nombre del Empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Digite el sueldo basico del Empleado: ");
                sueldoBasico = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite el porcentaje del Empleado: ");
                porcentaje = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite las ventas totales del Empleado: ");
                ventasTotales = Int32.Parse(Console.ReadLine());

                miPyme.adicionarEmpleadoSueldoXComision(identificacion, nombre, sueldoBasico, porcentaje, ventasTotales);
            }
            total = miPyme.calcularNominaTotal();
            Console.WriteLine("La Nomina Total es: " + total);
            Console.ReadKey(true);
        }
    }
}
