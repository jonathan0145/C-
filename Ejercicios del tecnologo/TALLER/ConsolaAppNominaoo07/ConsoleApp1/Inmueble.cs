using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inmueble
    {
        public static int Casa;
        public double AreaTerreno {  get; set; }
        public double CostoPorMetroCuadrado { get; set; }
        public double CostoInfraestructura {  get; set; }
        public double PorcentajeGanancia {  get; set; }

        public Inmueble(int casa, double areaTerreno, double costoPorMetroCuadrado, double costoInfraestructura, double porcentajeGanancia) { 
            Inmueble.Casa = casa;
            this.AreaTerreno = areaTerreno;
            this.CostoPorMetroCuadrado = costoPorMetroCuadrado;
            this.CostoInfraestructura = costoInfraestructura;
            this.PorcentajeGanancia = costoInfraestructura;
        }

        public double FormulaVenta()
        {
            double valorTerreno, valorTotal, ganancia, precioVenta;

            PorcentajeGanancia /= 100;
            valorTerreno = AreaTerreno * CostoPorMetroCuadrado;
            valorTotal = valorTerreno + CostoInfraestructura;
            ganancia = valorTotal * PorcentajeGanancia;
            precioVenta = valorTotal + ganancia;
            return precioVenta;
        }

    }
}
