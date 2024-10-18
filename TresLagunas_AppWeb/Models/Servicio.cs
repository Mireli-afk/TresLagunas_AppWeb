namespace TresLagunas_AppWeb.Models
{
    public class Servicio
    {
        public int IDServicio {  get; set; }
        public string NombreServicio { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Solicitud> Solicitudes { get; set; }
    }
}
