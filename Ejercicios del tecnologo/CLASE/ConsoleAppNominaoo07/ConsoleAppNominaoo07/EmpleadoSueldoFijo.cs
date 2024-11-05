using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo07
{
    public class EmpleadoSueldoFijo
    {
        public string Identificacion {  get; set; }
        public string Nombre { get; set; }
        public double SueldoFijo {  get; set; }

        public EmpleadoSueldoFijo(string identificacion, string nombre, double sueldoFijo) { 
            Identificacion = identificacion;
            Nombre = nombre;
            SueldoFijo = sueldoFijo;
        }

        public double CalcularSalario()
        {
            return SueldoFijo;
        }
    }
}
