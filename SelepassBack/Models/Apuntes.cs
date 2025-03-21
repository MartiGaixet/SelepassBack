using System.Text.Json.Serialization;

namespace SelepassBack.Models
{
    public class Apuntes
    {
        public int Id { get; set; }
        public String Asignatura { get; set; }
        public String Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        [JsonIgnore]
        public List<ApuntesUser>? ApuntesUsers { get; set; }
    }
}
