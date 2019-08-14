using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MyCompany.ProjectName.DataAccess
{
    public abstract class BaseRepository
    {
        private readonly IConnectionFactory _connection;

        protected BaseRepository(IConnectionFactory connection)
        {
            _connection = connection;
        }

        protected async Task<T> DataBase<T>(Func<IDbConnection, Task<T>> getData)
        {
            try
            {
                using (var dbConnection = _connection.GetSqlConnection())
                {
                    await dbConnection.OpenAsync().ConfigureAwait(false);
                    return await getData(dbConnection).ConfigureAwait(false);
                }
            }
            catch (TimeoutException ex)
            {
                throw new ArgumentNullException($"{GetType().FullName}.Connection() experienced a SQL timeout", ex);
            }
            catch (SqlException ex)
            {
                throw new ArgumentNullException($"{GetType().FullName}.WithConnection() experienced a SQL exception (not a timeout)", ex);
            }
        }

    }
}
