using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace SelepassBack.Models
{
    public class Examen
    {
        public int Id { get; set; }
        public String Asignatura { get; set; }
        public DateTime Fecha { get; set; }
        public bool Corregido { get; set; }
        public Blob Archivo { get; set; }

        [JsonIgnore]
        public List<ExUser> Exusers { get; set; }
    }



}
