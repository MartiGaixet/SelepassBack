using System.Text.Json.Serialization;

namespace SelepassBack.Models
{
    public class Asignatura
    {
        public int Id { get; set; }

        public String Nombre { get; set; }

        public String Fase { get; set; }

        public String Categoria { get; set; }
        public DateTime PrimeraConvocatoria { get; set; }
        public DateTime ConvocatoriaExtraordinaria { get; set; }


        [JsonIgnore]
        public List<Examen> Examenes { get; set; }

        [JsonIgnore]
        public List<Apuntes> Apuntes { get; set; }
    }
}
