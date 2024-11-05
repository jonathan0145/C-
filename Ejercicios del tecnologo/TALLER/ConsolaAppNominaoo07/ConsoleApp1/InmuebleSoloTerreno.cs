using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InmuebleSoloTerreno
    {
        public static int Casa;
        public double AreaTerreno {  get; set; }
        public double CostoPorMetroCuadrado {  get; set; }
        public double PorcentajeGanancia {  get; set; }

        public InmuebleSoloTerreno(int casa, double areaTerreno, double costoPorMetroCuadrado, double porcentajeGanancia) 
        {
            InmuebleSoloTerreno.Casa = casa;
            this.AreaTerreno = areaTerreno;
            this.CostoPorMetroCuadrado = costoPorMetroCuadrado;
            this.PorcentajeGanancia = porcentajeGanancia;
        }

        public double FormulaVenta()
        {
            double valorTerreno, precioVenta;
            PorcentajeGanancia /= 100;
            valorTerreno = AreaTerreno * CostoPorMetroCuadrado;
            precioVenta = valorTerreno * PorcentajeGanancia;
            return precioVenta;
        }
    }
}
