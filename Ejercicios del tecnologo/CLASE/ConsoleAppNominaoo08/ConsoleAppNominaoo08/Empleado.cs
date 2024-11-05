using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo08
{
    public abstract class Empleado
    {
        public string Identificacion {  get; private set; }
        public string Nombre { get; private set; }
        protected Empleado(string identificacion, string nombre)
        {
            Identificacion = identificacion;
            Nombre = nombre;
        }

        public abstract double calcularSalario();
    }
}
