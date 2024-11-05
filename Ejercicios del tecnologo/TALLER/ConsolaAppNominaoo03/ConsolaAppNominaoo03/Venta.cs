namespace ConsolaAppNominaoo03
{
    internal class Venta
    {
        public int casa;
        public double AreaTerreno;
        public double CostoPorMetroCuadrado;
        public double CostoInfraestructura;
        public double PorcentajeGanancia;
        public double PrecioVenta;
        public double valorTerreno, valorTotal, ganancia, precioVenta;

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
