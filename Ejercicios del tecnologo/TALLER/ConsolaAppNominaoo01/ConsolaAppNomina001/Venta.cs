namespace ConsolaAppNomina001
{
    internal class Venta
    {
        public double AreaTerreno {  get; set; }
        public double CostoPorMetroCuadrado { get; set; }
        public double CostoInfraestructura { get; set; }
        public double PorcentajeGanancia { get; set; }
        public double valorTerreno, valorTotal, ganancia, precioVenta;
        public int casa;

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
