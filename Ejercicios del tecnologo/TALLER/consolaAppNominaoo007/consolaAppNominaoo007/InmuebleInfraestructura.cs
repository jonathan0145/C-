using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppNominaoo007
{
    public class InmuebleInfraestructura : Inmueble
    {
        public double CostoInfraestructura { get; private set; }

        public InmuebleInfraestructura(int casa, double costoInfraestructura, double porcentajeGanancia) : base(casa, porcentajeGanancia)
        {
            this.CostoInfraestructura = costoInfraestructura;
        }
        public override double FormulaVenta()
        {
            double precioVenta, ganancia;
            PorcetajeGanancia /= 100;
            ganancia = CostoInfraestructura * PorcetajeGanancia;
            precioVenta = CostoInfraestructura + ganancia;
            return precioVenta;
        }
    }
}
