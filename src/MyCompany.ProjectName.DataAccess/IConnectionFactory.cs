using System.Data.SqlClient;

namespace MyCompany.ProjectName.DataAccess
{
    public interface IConnectionFactory
    {
        SqlConnection GetSqlConnection();
    }
}
