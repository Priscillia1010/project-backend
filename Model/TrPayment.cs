using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRent_Backend.Model
{
    public class TrPayment
    {
        [Key]
        [StringLength(36)]
        public string payment_id { get; set; } = Guid.NewGuid().ToString();
        public DateTime payment_date { get; set; }
        public decimal amount { get; set; }

        [MaxLength(100)]
        public string payment_method { get; set; }

        [ForeignKey("TrRental")]
        public string rental_id { get; set; }
        public TrRental TrRental { get; set; }
    }
}
