using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_05_POO04
{
    public class Nomina
    {
        static void Main(string[] args)
        {
            int numeroEmpleados;
            Empresa pyme = new Empresa("123", "Acme Inc.", "805 Silicon Valley");
            string identificacion, nombre;
            double horasTrabajadas, sueldoXHora;
            double total = 0;

            Console.WriteLine("Digite el numero de empleados: ");
            numeroEmpleados = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numeroEmpleados; i++)
            {
                Console.WriteLine("Digite la identificacion del empleado: ");
                identificacion = (Console.ReadLine());
                Console.WriteLine("Digite el Nombre del empleado: ");
                nombre = (Console.ReadLine()); ;
                Console.WriteLine("Digite el numero de horas trabajadas: ");
                horasTrabajadas = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite el sueldo por hora del empleado: ");
                sueldoXHora = Int32.Parse(Console.ReadLine());

                pyme.adicionarEmpleado(identificacion, nombre, horasTrabajadas, sueldoXHora);
            }
            total = pyme.calcularNominaTotal();
            Console.WriteLine("La Nomina es: " + total);
            Console.ReadKey(true);
        }
    }


}
