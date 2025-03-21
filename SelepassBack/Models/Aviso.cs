namespace SelepassBack.Models
{
    public class Aviso
    {
        public int Id { get; set; }
        public DateTime pre_fecha { get; set; }
        public String pre_desc { get; set; }
        public DateTime insc_fecha  { get; set; }
        public String insc_desc { get; set; }
        public DateTime mat_fecha { get; set; }
        public String mat_desc { get; set; }
        public DateTime ex_fecha { get; set; }
        public String ex_desc { get; set; }
        public DateTime notas_fecha { get; set; }
        public String notas_desc { get;set; }     
    }
}
