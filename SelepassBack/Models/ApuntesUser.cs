using System.Text.Json.Serialization;

namespace SelepassBack.Models
{
    public class ApuntesUser
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int ÀpuntesId { get; set; }

        [JsonIgnore]
        public Usuario Usuario { get; set; }
        [JsonIgnore]
        public Apuntes Apuntes { get; set; }
    }
}
