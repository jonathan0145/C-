using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace consolaAppNominaoo007
{
    internal class CoordinadorVenta
    {
        private static int IdVenta {  get; set; }
        private DateTime FechaVenta { get; set; }
        private string Cliente {  get; set; }
        private List<Inmueble> inmuebles;

        public CoordinadorVenta(int idVenta, DateTime fechaVenta, string cliente)
        {
            CoordinadorVenta.IdVenta = idVenta;
            this.FechaVenta = fechaVenta;
            this.Cliente = cliente;
            inmuebles = new List<Inmueble>();

        }
        public void AdicionarInmueble(Inmueble inmueble)
        {
            inmuebles.Add(inmueble);
        }

        public double FormulaVentaTotal()
        {
            return inmuebles.Sum(e => e.FormulaVenta());
        }
    }
}
