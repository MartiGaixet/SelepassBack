using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace SelepassBack.Models
{
    public class Examen
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public bool Corregido { get; set; }
        public Blob Archivo { get; set; }
        public String CAutonoma { get; set; }

        public int AsignaturaId { get; set; }

        [JsonIgnore]
        public List<ExUser> Exusers { get; set; }

        [JsonIgnore]
        public Asignatura Asignatura { get; set; }
    }



}
