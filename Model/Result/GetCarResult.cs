using System;

namespace CarRent_Backend.Model.Result
{
    public class GetCarResult
    {
        public string car_id { get; set; }
        public string car_name { get; set; }
        public decimal price_per_day { get; set; }
        public string image_link { get; set; }
    }
}
