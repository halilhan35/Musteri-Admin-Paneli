using System.ComponentModel.DataAnnotations;

namespace KisiselWebProjesii.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string profile { get; set; }
        public string isim { get; set; }
        public string job  { get; set; }
        public string description { get; set; }
        public string communication { get; set; }
    }
}