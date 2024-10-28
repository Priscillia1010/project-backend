using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using CarRent_Backend.Data;
using CarRent_Backend.Model;
using CarRent_Backend.Model.Result;

namespace CarRent_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarRentDbContext _context;

        public CarController(CarRentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponseCar<IEnumerable<GetCarResult>>>> Get(
            [FromQuery] DateTime? rental_date = null,
            [FromQuery] DateTime? return_date = null,
            [FromQuery] int? car_year = null)
        {
            var query = _context.MsCar.Include(x => x.MsCarImage).AsQueryable();

            if (car_year.HasValue)
            {
                query = query.Where(x => x.car_year == car_year.Value); 
            }

            if(rental_date.HasValue && return_date.HasValue)
            {
                query = query.Where(car => !_context.TrRental
                    .Any(rental => rental.car_id == car.car_id &&
                                   rental.return_date < return_date.Value &&
                                   rental.return_date > rental_date.Value));
            }

            var listCar = await _context.MsCar
                .Include(x => x.MsCarImage)
                .Select(x => new GetCarResult
                {
                    car_id = x.car_id,
                    car_name = x.car_name,
                    image_link = x.MsCarImage.FirstOrDefault().image_link,
                    price_per_day = x.price_per_day,
                }).ToListAsync();

            var response = new ApiResponseCar<IEnumerable<GetCarResult>>()
            {
                StatusCode = StatusCodes.Status200OK,
                RequestMethod = HttpContext.Request.Method,
                Data = listCar
            };

            return Ok(response);
        }
    }
}
