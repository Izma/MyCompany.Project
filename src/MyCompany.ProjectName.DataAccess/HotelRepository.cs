using Dapper;
using MyCompany.ProjectName.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace MyCompany.ProjectName.DataAccess
{
    public class HotelRepository : BaseRepository, IHotelRepository
    {
        public HotelRepository(IConnectionFactory connection) : base(connection)
        {
        }

        public async Task<List<Hotel>> GetHotels()
        {
            return await DataBase(async db =>
             {
                 var result = await db.QueryAsync<Hotel>(sql: "[dbo].[spGetHotels]", param: null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
                 return result.AsList();
             }).ConfigureAwait(false);
        }

        public Task<int> RegisterHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
