using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAppNominaoo05
{
    internal class Venta
    {
        public int casa { get; private set; }
        public double AreaTerreno { get; private set; }
        public double CostoPorMetroCuadrado { get; private set; }
        public double CostoInfraestructura { get; private set; }
        public double PorcentajeGanancia { get; private set; }
        public double PrecioVenta { get; private set; }
        public double valorTerreno { get; private set; }
        public double valorTotal { get; private set; }
        public double ganancia { get; private set; }
        public double precioVenta { get; private set; }

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
