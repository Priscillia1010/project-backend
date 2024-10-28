using System.ComponentModel.DataAnnotations;

namespace CarRent_Backend.Model
{
    public class MsCustomer
    {
        [Key]
        [StringLength(36)]
        public string customer_id { get; set; } 

        [MaxLength(100)]
        public string customer_email { get; set; }

        [MaxLength(500)]
        public string customer_password { get; set; }

        [MaxLength(200)]
        public string customer_name { get; set; }

        [MaxLength(50)]
        public string customer_phone_number { get; set; }

        [MaxLength(500)]
        public string customer_address { get; set; }

        [MaxLength(100)]
        public string driver_license_number { get; set; }
        public virtual ICollection<TrRental> TrRental { get; set; }
    }
}
