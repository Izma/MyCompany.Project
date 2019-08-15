using Microsoft.AspNetCore.Mvc;
using MyCompany.ProjectName.Core;
using System.Threading.Tasks;

namespace MyCompany.ProjectName.Web.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelCore _hotel;

        public HotelsController(IHotelCore hotel)
        {
            _hotel = hotel;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetHotels()
        {
            var hotels = await _hotel.GetHotels().ConfigureAwait(false);
            if (hotels.Count > 0)
                return Ok(hotels);
            return NotFound();
        }

    }
}