using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo08
{
    internal class Empresa
    {
        private static string Nit;
        private string Nombre { get; set; }
        private string Direccion {  get; set; }
        private List<Empleado> empleados;

        public Empresa(string nit, string nombre, string direccion)
        {
            Empresa.Nit = nit;
            this.Nombre = nombre;
            this.Direccion = direccion;
            empleados = new List<Empleado>();
        }

        public void AdicionarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public double CalcularNominalTotal()
        {
            return empleados.Sum(e => e.calcularSalario());
        }

    }
}
