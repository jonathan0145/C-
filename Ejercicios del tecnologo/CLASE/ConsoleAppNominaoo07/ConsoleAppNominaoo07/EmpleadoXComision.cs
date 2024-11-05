using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo07
{
    internal class EmpleadoXComision
    {
        public string Identificacion {  get; private set; }
        public string Nombre { get; private set; }
        public double SueldoBasico {  get; private set; }
        public double Porcentaje {  get; private set; }
        public double VentasTotales {  get; private set; }

        public EmpleadoXComision(string identificacion, string nombre, double sueldoBasico, double porcentaje, double ventasTotales)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            SueldoBasico = sueldoBasico;
            Porcentaje = porcentaje;
            VentasTotales = ventasTotales;
        }

        public double CalcularSalario()
        {
            return SueldoBasico + Porcentaje * VentasTotales;
        }
    }
}
