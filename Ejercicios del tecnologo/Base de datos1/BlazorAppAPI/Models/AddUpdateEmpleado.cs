namespace BlazorAppAPI.Models
{
    public class AddUpdateEmpleado
    {
        public string Identificacion { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public double HorasTrabajadas { get; set; }
        public double SueldoPorHora { get; set; }
        public bool IsActive { get; set; }
    }
}
