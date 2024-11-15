using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppNominaoo007
{
    public class InmuebleTerreno : Inmueble
    {
        public double AreaTerreno {  get; private set; }
        public double CostoPorMetroCuadrado {  get; private set; }
        
        public InmuebleTerreno(int casa, double areaTerreno, double costoPorMetroCuadrado, double porcentajeGanancia) : base(casa, porcentajeGanancia)
        {
            this.AreaTerreno = areaTerreno;
            this.CostoPorMetroCuadrado = costoPorMetroCuadrado;
        }

        public override double FormulaVenta()
        {
            double valorTerreno, precioVenta, valorTotal;

            PorcetajeGanancia /= 100;
            valorTerreno = AreaTerreno * CostoPorMetroCuadrado;
            valorTotal = valorTerreno * PorcetajeGanancia;
            precioVenta = valorTerreno + valorTotal;
            return precioVenta;
        }
    }
}
