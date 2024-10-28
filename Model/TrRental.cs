using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRent_Backend.Model
{
    public class TrRental
    {
        [Key]
        [StringLength(36)]
        public string rental_id { get; set; } 
        public DateTime rental_date { get; set; }
        public DateTime return_date { get; set; }

        public decimal total_price { get; set; }
        public bool payment_status { get; set; }

        [ForeignKey("MsCustomer")]
        public string customer_id { get; set; }
        public MsCustomer MsCustomer { get; set; }

        [ForeignKey("MsCar")]
        public string car_id { get; set; }
        public MsCar MsCar { get; set; }

        public virtual ICollection<TrPayment> TrPayment { get; set; }
    }
}
