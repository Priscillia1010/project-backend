using System;
namespace CarRent_Backend.Model.Result
{
    public class ApiResponseCar<T>
    {
        public int StatusCode { get; set; }
        public string RequestMethod { get; set; }
        public T Data { get; set; }
    }
}
