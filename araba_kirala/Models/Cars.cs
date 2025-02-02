using System.ComponentModel.DataAnnotations;

namespace araba_kirala.Models
{
    public class Cars
    {
        [Key]
        public int CarID { get; set; }
        public int? BrandID { get; set; }
        public int? ColorID { get; set; }
        public bool Status { get; set; } = false;
        virtual public List<Rentals>? Rentals { get; set; }
        //bir araç birden fazla kiralanabilir
        virtual public Colors?  Colors { get; set; }
        virtual public Brands? Brands { get; set; }  
        
    }
}
