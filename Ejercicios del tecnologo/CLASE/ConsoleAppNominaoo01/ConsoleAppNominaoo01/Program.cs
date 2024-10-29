using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo01
{
    public class Nomina
    {
        public static void Main(string[] args)
        {
            int numeroEmpleados;
            Empleado[] losEmpleados = new Empleado[50];
            string identificacion, nombre;
            double horas, sueldo;
            double total = 0;

            Console.WriteLine("Digite el numero de empleados(1): ");
            numeroEmpleados = Int32.Parse(Console.ReadLine());


            for (int i = 0; i < numeroEmpleados; i++)
            {
                Console.WriteLine("Digite la identificacion del empleado: ");
                identificacion = (Console.ReadLine());
                Console.WriteLine("Digite el Nombre del empleado: ");
                nombre = (Console.ReadLine()); ;
                Console.WriteLine("Digite el numero de horas trabajadas: ");
                horas = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite el sueldo por hora del empleado: ");
                sueldo = Int32.Parse(Console.ReadLine());

                Empleado unEmpleado = new Empleado();
                unEmpleado.identificacion = identificacion;
                unEmpleado.nombre = nombre;
                unEmpleado.horasTrabajadas = horas;
                unEmpleado.sueldoXHora = sueldo;
                losEmpleados[i] = unEmpleado;
            }

            for (int i = 0; i < numeroEmpleados; i++)
            {
                total = total + losEmpleados[i].horasTrabajadas * losEmpleados[i].sueldoXHora;
            }

            Console.WriteLine("La Nomina es: " + total);
            Console.ReadKey(true);
        }
    }
}
