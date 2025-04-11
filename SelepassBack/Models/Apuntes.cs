using System.Text.Json.Serialization;

namespace SelepassBack.Models
{
    public class Apuntes
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public int AsignaturaId { get; set; }

        [JsonIgnore]
        public List<ApuntesUser>? ApuntesUsers { get; set; }

        [JsonIgnore]
        public Asignatura Asignatura { get; set; }
    }
}
