using System.ComponentModel.DataAnnotations;

namespace TresLagunas_AppWeb.Models
{
    public class Servicio
    {
        public int IDServicio { get; set; }
        [Display(Name = "Nombre de servicio")]
        [Required(ErrorMessage = "Campo nombre de servicio obligatorio")]
        public string NombreServicio { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Campo descripción de servicio obligatorio")]
        public string Descripcion { get; set; }
        public ICollection<Solicitud> Solicitudes { get; set; }
    }
}
