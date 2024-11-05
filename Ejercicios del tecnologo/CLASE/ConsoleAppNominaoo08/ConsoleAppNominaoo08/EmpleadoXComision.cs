using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo08
{
    public class EmpleadoXComision : Empleado
    {
        public double SueldoBasico {  get; private set; }
        public double Porcentaje { get; private set; }
        public double VentasTotales { get; private set; }
        public EmpleadoXComision(string identificacion, string nombre, double sueldoBasico, double porcentaje, double ventasTotales):base(identificacion, nombre)
        {
            SueldoBasico = sueldoBasico;
            Porcentaje = porcentaje;
            VentasTotales = ventasTotales;
        }

        public override double calcularSalario()
        {
            return SueldoBasico + Porcentaje * VentasTotales;
        }
    }
}
