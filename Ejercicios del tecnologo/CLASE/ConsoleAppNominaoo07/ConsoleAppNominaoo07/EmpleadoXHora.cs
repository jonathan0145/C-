using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo07
{
    internal class EmpleadoXHora
    {
        public string Identificacion {  get; private set; }
        public string Nombre { get; private set; }
        public double HorasTrabajadas { get; private set; }
        public double SueldoXHora { get; private set; }

        public EmpleadoXHora(string identificacion, string nombre, double horasTrabajadas, double sueldoXHora) { 
            Identificacion = identificacion;
            Nombre = nombre;
            HorasTrabajadas = horasTrabajadas;
            SueldoXHora = sueldoXHora;
        }

        public double CalcularSalario()
        {
            return HorasTrabajadas * SueldoXHora;
        }
    }
}
