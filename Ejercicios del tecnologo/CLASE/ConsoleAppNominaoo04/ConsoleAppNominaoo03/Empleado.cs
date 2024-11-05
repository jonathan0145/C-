using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo03
{
    internal class Empleado
    {
        private string Identificacion {  get; set; }
        private string Nombre {  get; set; }
        private double HorasTrabajadas {  get; set; }
        private double SueldoXHora {  get; set; }

        public Empleado(string identificacion, string nombre, double horasTrabajadas, double sueldoXHora)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            HorasTrabajadas = horasTrabajadas;
            SueldoXHora = sueldoXHora;
        }

        public double calcularSalario()
        {
            return HorasTrabajadas * SueldoXHora;
        }
    }
}
