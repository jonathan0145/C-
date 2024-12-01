namespace WebAppApi.Model
{
    public class Empleado
    {
        public int Id { get; set; }
        public required string Identificacion { get; set; }
        public required string Nombre { get; set; }
        public double HorasTrabajadas { get; set; }
        public double SueldoPorHora { get; set; }
        public bool IsActive { get; set; }

    }
}
