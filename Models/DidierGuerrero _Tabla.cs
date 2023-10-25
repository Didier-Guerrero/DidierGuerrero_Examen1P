using System.ComponentModel.DataAnnotations;

namespace DidierGuerrero_Examen1P.Models
{
    public class DidierGuerrero__Tabla
    {
        [Required]
        public int dgEntradasDisponibles { get; set; }
        [Range(4.50, 8.50)]
        public decimal dgPrecio { get; set; }
        [MinLength(5)]
        [Display(Name = "Nombre de pelicula")]
        public string? dgNombrePelicula { get; set; }
        [Required]
        public DateTime? dgFechaPelicula { get; set; }
        public bool MdgMayorEdad { get; set; }
    }
}
