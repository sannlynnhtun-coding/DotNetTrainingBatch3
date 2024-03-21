using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace DotNetTrainingBatch3.Shared
{
    public class AdoDotNetService
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder;

        public AdoDotNetService(string connectionString)
        {
            _sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
        }

        public List<T> Query<T>(string query, List<SqlParameter>? parameters = null)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            if (parameters is not null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            string json = JsonConvert.SerializeObject(dt);
            var lst = JsonConvert.DeserializeObject<List<T>>(json);
            return lst!;
        }

        public T QueryFirstOrDefault<T>(string query, List<SqlParameter>? parameters = null)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            if (parameters is not null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();

            string json = JsonConvert.SerializeObject(dt);
            var lst = JsonConvert.DeserializeObject<List<T>>(json);
            return lst![0];
        }

        public int Execute(string query, List<SqlParameter>? parameters = null)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            if (parameters is not null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }

            int result = cmd.ExecuteNonQuery();
            connection.Close();

            return result;
        }
    }
}
