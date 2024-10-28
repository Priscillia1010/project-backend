using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CarRent_Backend.Model
{
    public class MsCar
    {
        [Key]
        [StringLength(36)]
        public string car_id { get; set; }

        [MaxLength(200)]
        public string car_name { get; set; }

        [MaxLength(100)]
        public string car_model { get; set; }

        public int car_year;

        [MaxLength(50)]
        public string license_plate {  get; set; }

        public int number_of_car_seats;

        [MaxLength(100)]
        public string transmission;

        public decimal price_per_day;

        public bool car_status;

        public ICollection<MsCarImage> MsCarImage { get; set; }
        public ICollection<TrRental> TrRental { get; set; }
    }
}
