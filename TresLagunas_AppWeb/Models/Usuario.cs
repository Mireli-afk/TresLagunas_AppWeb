using System.ComponentModel.DataAnnotations;

namespace TresLagunas_AppWeb.Models
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        [Required(ErrorMessage = "Campo nombres obligatorio")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Campo apellidos obligatorio")]
        public string Apellidos { get; set; }
        [Display(Name = "Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Campo correo electrónico obligatorio")]
        public string Correo {  get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Campo contraseña obligatorio")]
        public string contrasena { get; set; }

    }
}
