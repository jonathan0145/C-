using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_05_POO04
{
    public class Empresa
    {
        private static string nit;
        private string nombre { get; set; }
        private string direccion { get; set; }

        private Empleado[] empleados;
        private int numeroEmpleados { get; set; }
        public Empresa(string nit, string nombre, string direccion)
        {
            Empresa.nit = nit;
            this.nombre = nombre;
            this.direccion = direccion;
            empleados = new Empleado[50];
            numeroEmpleados = 0;
        }
        public void adicionarEmpleado(string identificacion, string nombre, double horasTrabajadas, double sueldoXHora)
        {
            Empleado e = new Empleado(identificacion, nombre, horasTrabajadas, sueldoXHora);
            empleados[numeroEmpleados] = e;
            numeroEmpleados++;
        }
        public double calcularNominaTotal()
        {
            double total = 0;
            for (int i = 0; i < numeroEmpleados; i++)
            {
                total = total + empleados[i].CalcularSalario();
            }
            return total;
        }

    }
}
