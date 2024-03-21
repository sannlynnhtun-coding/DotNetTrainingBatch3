using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.Shared
{
    public class DapperService
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder;

        public DapperService(string connectionString)
        {
            _sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
        }

        public List<T> Query<T>(string query, object? parameters = null)
        {
            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            List<T> lst = db.Query<T>(query).ToList();
            return lst;
        }

        public T QueryFirstOrDefault<T>(string query, object? parameters = null)
        {
            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            T item = db.QueryFirstOrDefault<T>(query)!;
            return item;
        }

        public int Execute(string query, object? parameters = null)
        {
            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            int result = db.Execute(query, parameters);
            return result;
        }
    }
}
