using System.Data.SqlClient;

namespace Creational.Singleton.Entities.Loggers
{
    internal class DatabaseLogger : Logger<DatabaseLogger>
    {
        private readonly string connectionString;
        private const string sqlQuery = "INSERT INTO Logs(Message) VALUES(@message)";

        private DatabaseLogger() => connectionString = new SqlConnectionStringBuilder()
        {
            DataSource = @"(LocalDb)\MSSQLLocalDB",
            InitialCatalog = "Vezba1",
            IntegratedSecurity = true,
            AsynchronousProcessing = true
        }.ConnectionString;

        public override void Log(string message)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@message", message);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
