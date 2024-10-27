namespace Ejercicio01_05_POO01
{
    internal class Calculadora
    {
        public double AreaTerreno { get; set; }
        public double CostoPorMetroCuadrado { get; set; }
        public double CostoInfraestructura { get; set; }
        public double PorcentajeGanancia{ get; set; }

        public Calculadora(double areaTerreno, double costoPorMetroCuadrado, double costoInfraestructura, double porcentaGanancia)
        {
            this.AreaTerreno = areaTerreno;
            this.CostoPorMetroCuadrado = costoPorMetroCuadrado;
            this.CostoInfraestructura = costoInfraestructura;
            this.PorcentajeGanancia = porcentaGanancia;
        }

        public double Formula()
        {
            PorcentajeGanancia /= 100;
            double valorTerreno = AreaTerreno * CostoPorMetroCuadrado;
            double valorTotal = valorTerreno + CostoInfraestructura;
            double ganancia = valorTotal * PorcentajeGanancia;
            double precioVenta = valorTotal + ganancia;
            return precioVenta;
        }
    }
}
