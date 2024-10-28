using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CarRent_Backend.Model
{
    public class MsCarImage
    {
        [Key]
        [StringLength(36)]
        public string image_car_id { get; set; }

        [StringLength(2000)]
        public string image_link { get; set; }

        [ForeignKey("MsCar")]
        [StringLength(36)]
        public string car_id { get; set; }
        public MsCar MsCar { get; set; }
    }
}
