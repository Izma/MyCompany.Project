using MyCompany.ProjectName.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCompany.ProjectName.Core
{
    public interface IHotelCore
    {
        Task<List<Hotel>> GetHotels();
    }
}
