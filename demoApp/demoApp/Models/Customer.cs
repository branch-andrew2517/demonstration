using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoApp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime Birthday { get; set; }
        public string Product { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal InvestmentValue { get; set; }
    }
}
