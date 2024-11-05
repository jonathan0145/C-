using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InmuebleSinTerreno
    {
        public static int Casa;
        public double CostoInfraestructura {  get; set; }
        public double PorcentajeGanancia { get; set; }

        public InmuebleSinTerreno(int casa, double costoInfraestructura, double porcentajeGanancia)
        {
            InmuebleSinTerreno.Casa = casa;
            this.CostoInfraestructura = costoInfraestructura;
            this.PorcentajeGanancia = PorcentajeGanancia;
        }

        public double FormulaVenta()
        {
            double precioVenta = 0;

            PorcentajeGanancia /= 100;
            precioVenta = CostoInfraestructura* PorcentajeGanancia;
            return precioVenta;
        }
    }
}
