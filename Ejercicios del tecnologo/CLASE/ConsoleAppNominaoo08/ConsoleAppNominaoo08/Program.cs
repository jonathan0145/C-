using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Empresa mipyme = new Empresa("123", "Acme", "Silicon Valley");
            Console.WriteLine("Digite el numero Total de Empleados: ");
            int numeroEmpleados = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numeroEmpleados; i++)
            {
                AdicionarEmpleado(mipyme);
            }
            double total = mipyme.CalcularNominalTotal();
            Console.WriteLine($"La Nomina es: {total}");
            Console.ReadKey(true);

            void AdicionarEmpleado(Empresa miPyme)
            {
                Console.WriteLine("Seleccione una Opcion: ");
                Console.WriteLine("1. Empleado Sueldo Fijo");
                Console.WriteLine("2. Empleado Sueldo por Hora");
                Console.WriteLine("3. Empleado ´pr Comision");

                int opcion = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite la Identificacion del Empleado: ");
                string identificacion = Console.ReadLine();
                Console.WriteLine("Digite el nombre del Empleado: ");
                string nombre = Console.ReadLine();

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Digite el Sueldo Fijo del Empleado: ");
                        double sueldoFijo = Double.Parse(Console.ReadLine());
                        Empleado empleadoSueldoFijo = new EmpleadoSueldoFijo(identificacion, nombre, sueldoFijo);
                        miPyme.AdicionarEmpleado(empleadoSueldoFijo);
                        break;
                        
                    case 2:
                        Console.WriteLine("Digite el numero de horas trabajadas del Empleado: ");
                        double horasTrabajadas = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el sueldo por horas del Empleado: ");
                        double sueldoXHora = double.Parse(Console.ReadLine());
                        Empleado empleadoPorHora = new EmpleadoSueldoXHora(identificacion, nombre, horasTrabajadas, sueldoXHora);
                        break;

                    case 3:
                        Console.WriteLine("Digite el sueldo basico del Empleado: ");
                        double sueldobasico = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el porcentaje del Empleado: ");
                        double porcentaje = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite el VentasTotales del Empleado");
                        double ventasTotales = Double.Parse(Console.ReadLine());
                        Empleado empleadoPorComision = new EmpleadoXComision(identificacion, nombre, sueldobasico, porcentaje, ventasTotales);
                        mipyme.AdicionarEmpleado(empleadoPorComision);
                        break;

                }


            }
        }
    }
}
