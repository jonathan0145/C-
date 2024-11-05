using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo08
{
    public class EmpleadoSueldoFijo : Empleado
    {
        public double SueldoFijo {  get; private set; }
        public EmpleadoSueldoFijo(string identificacion, string nombre, double sueldoFijo) : base(identificacion, nombre)
        {
            SueldoFijo = sueldoFijo;
        }
        public override double calcularSalario()
        {
            return SueldoFijo;
        }
    }
}
