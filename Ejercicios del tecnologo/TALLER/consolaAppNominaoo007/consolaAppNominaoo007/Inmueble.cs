using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppNominaoo007
{
    public abstract class Inmueble
    {
        public static int Casa;
        public double PorcetajeGanancia {  get; set; }

        protected Inmueble(int casa, double porcetajeGanancia)
        {
            Inmueble.Casa = casa;
            this.PorcetajeGanancia = porcetajeGanancia;
        }

        public abstract double FormulaVenta();
    }
}
