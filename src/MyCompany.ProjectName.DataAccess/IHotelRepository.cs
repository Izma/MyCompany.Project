using MyCompany.ProjectName.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCompany.ProjectName.DataAccess
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetHotels();
        Task<int> RegisterHotel(Hotel hotel);
    }
}
