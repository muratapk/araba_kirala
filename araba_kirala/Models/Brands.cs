using System.ComponentModel.DataAnnotations;

namespace araba_kirala.Models
{
    public class Brands
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int? ModelYear { get; set; } 
        public int? DailyPrice { get; set; }
        virtual public List<Cars>? Cars { get; set; }
        //bir aracın birden fazla Markası olabilir

    }
}
