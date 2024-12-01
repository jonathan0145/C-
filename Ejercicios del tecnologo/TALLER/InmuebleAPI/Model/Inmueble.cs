using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InmuebleAPI.Model
{
    public class Inmueble
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Casa { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double AreaTerreno { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double CostoPorMetroCuadrado { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double CostoInfraestructura { get; set; }

        [Required]
        [Range(0, 100)] // Assuming percentage gain is between 0 and 100
        public double PorcentajeGanancia { get; set; }

        public bool IsActive { get; set; }
    }
}
