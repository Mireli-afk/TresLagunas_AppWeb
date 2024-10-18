using System.ComponentModel.DataAnnotations;

namespace TresLagunas_AppWeb.Models
{
    public class Solicitud
    {

        public int IDSolicitud {  get; set; }

        [Required(ErrorMessage ="Campo Nombres Obligatorio")]
        [Display(Name = "Nombre del Solcitante")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Campo Apellidos Obligatorio")]
        [Display(Name = "Apellidos del Solcitante")]
        public string Apellidos {  get; set; }

        [Required(ErrorMessage = "Campo Numero de Celular Obligatorio")]
        [Display(Name = "Numero de Celular del Solcitante")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El número de teléfono debe tener exactamente 9 dígitos")]
        public string NroCelular { get; set; }

        [Required(ErrorMessage = "Campo Correo Obligatorio")]
        [Display(Name = "Correo del Solcitante")]
        [DataType(DataType.EmailAddress)]
        public string Correo {  get; set; }

        [Required(ErrorMessage = "Campo Descripción Obligatorio")]
        [Display(Name = "Descripción del Solicitante")]
        public string Descripcion { get; set; }
        public int IDServicio { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}
