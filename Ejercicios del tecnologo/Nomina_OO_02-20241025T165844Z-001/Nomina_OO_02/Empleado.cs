using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaOO02
{
    public class Empleado
    {
        public string identificacion;

        public string nombre;

        public double horasTrabajadas;

        public double sueldoXHora;

        public Empleado(string identificacion, string nombre, double horasTrabajadas, double sueldoXHora)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.sueldoXHora = sueldoXHora;
        }

        public double calcularSalario()
        {
            return horasTrabajadas * sueldoXHora;
        }
    }

}
