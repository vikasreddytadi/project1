using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DotnetAPI
{
    class DataContextDapper
    {
        private readonly IConfiguration _config;

        public DataContextDapper(IConfiguration config)
        {
            _config = config;
        }

        public IEnumerable<T> LoadData<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(
                _config.GetConnectionString("DefaultConnnection")
            );
            return dbConnection.Query<T>(sql);
        }

        public T LoadDataSingle<T>(string sql)
        {
            IDbConnection dbConnection = new SqlConnection(
                _config.GetConnectionString("DefaultConnnection")
            );
            return dbConnection.QuerySingle<T>(sql);
        }
    }
}
