using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo08
{
    internal class EmpleadoSueldoXHora : Empleado
    {
        public double HorasTrabajadas {  get; private set; }
        public double SueldoXHora {  get; private set; }

        public EmpleadoSueldoXHora(string identificacion, string nombre, double horasTrabajadas, double sueldoXHora):base(identificacion, nombre)
        {
            HorasTrabajadas = HorasTrabajadas;
            SueldoXHora = SueldoXHora;
        }

        public override double calcularSalario()
        {
            return HorasTrabajadas * SueldoXHora;
        }
    }
}
