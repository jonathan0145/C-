using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppNominaoo007
{
    public class InmuebleConTodo : Inmueble 
    {
        public double AreaTerreno {  get; set; }
        public double CostoPorMetroCuadrado {  get; set; }
        public double CostoInfraestructura {  get; set; }

        public InmuebleConTodo(int casa, double areaTerreno, double costoPorMetroCuadrado, double costoInfraestructura, double porcentajeGanancia) : base(casa, porcentajeGanancia)
        {
            this.AreaTerreno = areaTerreno;
            this.CostoPorMetroCuadrado = costoPorMetroCuadrado; 
            this.CostoInfraestructura = costoInfraestructura;
        }

        public override double FormulaVenta()
        {
            double valorTerreno, valorTotal, ganancia, precioVenta;

            PorcetajeGanancia /= 100;
            valorTerreno = AreaTerreno * CostoPorMetroCuadrado;
            valorTotal = valorTerreno + CostoInfraestructura;
            ganancia = valorTotal * PorcetajeGanancia;
            precioVenta = valorTotal + ganancia;
            return precioVenta;
        }
    }
}
