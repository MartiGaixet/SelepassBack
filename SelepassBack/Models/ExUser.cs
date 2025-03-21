using System.Text.Json.Serialization;

namespace SelepassBack.Models
{
    public class ExUser
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ExamenId { get; set; }

        [JsonIgnore]
        public Usuario Usuario { get; set; }
        [JsonIgnore]
        public Examen Examen { get; set; }
    }
}
