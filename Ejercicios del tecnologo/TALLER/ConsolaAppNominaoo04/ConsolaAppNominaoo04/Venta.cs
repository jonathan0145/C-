using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAppNominaoo04
{
    internal class Venta
    {
        private int casa { get; set; }
        private double AreaTerreno { get; set; }
        private double CostoPorMetroCuadrado { get; set; }
        private double CostoInfraestructura { get; set; }
        private double PorcentajeGanancia { get; set; }
        private double PrecioVenta { get; set; }
        private double valorTerreno { get; set; }
        private double valorTotal { get; set; }
        private double ganancia { get; set; }
        private double precioVenta { get; set; }

        public Venta(int casa, double areaTerreno, double costoPorMetroCuadrado, double costoInfraestructura, double porcentajeGanancia)
        {
            this.casa = casa;
            this.AreaTerreno = areaTerreno;
            this.CostoPorMetroCuadrado = costoPorMetroCuadrado;
            this.CostoInfraestructura = costoInfraestructura;
            this.PorcentajeGanancia = porcentajeGanancia;
        }

        public double FormulaVenta()
        {
            PorcentajeGanancia /= 100;
            valorTerreno = AreaTerreno * CostoPorMetroCuadrado;
            valorTotal = valorTerreno + CostoInfraestructura;
            ganancia = valorTotal * PorcentajeGanancia;
            precioVenta = valorTotal + ganancia;
            return precioVenta;
        }
    }
}
