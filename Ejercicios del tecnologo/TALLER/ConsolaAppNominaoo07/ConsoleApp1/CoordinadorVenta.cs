using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CoordinadorVenta
    {
        public static string IdVenta;
        public DateTime FechaVenta { get; private set; }
        public string Cliente { get; private set; }

        private Inmueble[] inmueble1;
        private InmuebleSinTerreno[] inmueble2;
        private InmuebleSoloTerreno[] inmueble3;
        private int numeroInmueble1 { get; set; }
        private int numeroInmueble2 { get; set; }
        private int numeroInmueble3 { get; set; }

        public CoordinadorVenta(string idVenta, DateTime fechaVenta, string cliente)
        {
            CoordinadorVenta.IdVenta = idVenta;
            this.FechaVenta = fechaVenta;
            this.Cliente = cliente;
            this.inmueble1 = new Inmueble[50];
            this.inmueble2 = new InmuebleSinTerreno[50];
            this.inmueble3 = new InmuebleSoloTerreno[50];
            this.numeroInmueble1 = 0;
            this.numeroInmueble2 = 0;
            this.numeroInmueble3 = 0;
        }

        public void adicionarInmueble(int casa, double areaTerreno, double costoPorMetroCuadrado, double costoInfraestructura, double porcentajeGanancia)
        {
            inmueble1[numeroInmueble1] = new Inmueble(casa, areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia);
            numeroInmueble1++;
        }

        public void adicionarInmuebleSinTerreno(int casa, double costoInfraestructura, double porcentajeGanancia)
        {
            inmueble2[numeroInmueble2] = new InmuebleSinTerreno( casa, costoInfraestructura, porcentajeGanancia);
        }

        public void adicionarInmuebleSoloTerreno(int casa, double areaTerreno, double costoPorMetroCuadrado, double porcentajeGanancia)
        {
            inmueble3[numeroInmueble3] = new InmuebleSoloTerreno(casa, areaTerreno, costoPorMetroCuadrado, porcentajeGanancia);
        }

        public double FormulaVentaTotal()
        {

        }
    }
}
