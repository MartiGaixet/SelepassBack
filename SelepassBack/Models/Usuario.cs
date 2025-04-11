using System.Text.Json.Serialization;

namespace SelepassBack.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public bool Suscrito { get; set; }
        public String ComunidadAutonoma { get; set; }
        public float Nota_Academica { get; set; }
        public float? Nota_fase_general { get; set; }
        public float Nota_fase_especifica { get; set; }

        [JsonIgnore]
        public List<ApuntesUser>? ApuntesUsers { get; set; }

        [JsonIgnore]
        public List<ExUser>? Exusers { get; set; }
    }
}
