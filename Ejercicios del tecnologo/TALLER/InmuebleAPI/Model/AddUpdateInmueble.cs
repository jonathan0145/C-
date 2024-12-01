namespace InmuebleAPI.Model
{
    public class AddUpdateInmueble
    {
        public int Casa { get; set; }
        public double AreaTerreno { get; set; }
        public double CostoPorMetroCuadrado { get; set; }
        public double CostoInfraestructura { get; set; }
        public double PorcentajeGanancia { get; set; }
        public bool IsActive { get; set; }
    }
}
