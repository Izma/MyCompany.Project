using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyCompany.ProjectName.DataAccess;
using MyCompany.ProjectName.Entities;

namespace MyCompany.ProjectName.Core
{
    public class HotelCore : IHotelCore
    {
        private readonly IHotelRepository _repository;

        public HotelCore(IHotelRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Hotel>> GetHotels()
        {
            var hotels = await _repository.GetHotels().ConfigureAwait(false);
            return hotels ?? new List<Hotel>();
        }
    }
}
