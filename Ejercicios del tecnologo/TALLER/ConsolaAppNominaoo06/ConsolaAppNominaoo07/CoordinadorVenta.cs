using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaAppNominaoo07
{
    internal class CoordinadorVenta
    {
        private int IdVenta { get; set; }
        private DateTime FechaVenta { get; set; }
        private string Cliente { get; set; }
        private Venta[] venta;
        private int numeroInmuebles { get; set; }

        public CoordinadorVenta(int idVenta, DateTime fechaVenta, string cliente)
        {
            this.IdVenta = idVenta;
            this.FechaVenta = fechaVenta;
            this.Cliente = cliente;
            venta = new Venta[50];
            numeroInmuebles = 0;
        }
        public void adicionarInmueble(int casa1, double areaTerreno1, double costoPorMetroCuadrado1, double costoInfraestructura1, double porcentajeGanancia1)
        {
            Venta e = new Venta(casa1, areaTerreno1, costoPorMetroCuadrado1, costoInfraestructura1, porcentajeGanancia1);
            venta[numeroInmuebles] = e;
            numeroInmuebles++;
        }

        public double FormulaVentaTotal()
        {
            double total = 0;
            for (int i = 0; i < numeroInmuebles; i++)
            {
                total = total + venta[i].FormulaVenta();
            }
            return total;
        }
    }
}