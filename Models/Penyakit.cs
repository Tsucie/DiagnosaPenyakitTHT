
namespace DiagnosaPenyakitTHT.Models
{
    public class Penyakit
    {
        public string name { get; set; }
        public bool cancer { get; set; }
        public bool sinus { get; set; }
        public int[] no_gejala { get; set; }
    }
}