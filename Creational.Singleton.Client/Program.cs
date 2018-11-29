using Creational.Singleton.Entities;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const int expectedNumberOfRecords = 16;

            ILogger logger1 = LoggerFactory.CreateLogger(LoggerType.File);
            logger1.Log("File Log Nb: 1.");

            ILogger logger2 = LoggerFactory.CreateLogger(LoggerType.File);
            logger2.Log("File Log Nb: 2.");

            Parallel.For(1, 8, index => logger1.Log($"File Parallel Log Nb: {index}. from logger1"));
            Parallel.For(1, 8, index => logger2.Log($"File Parallel Log Nb: {index}. from logger2"));

            Console.WriteLine($"Logger1 and Logger2 are the some instance : {Equals(logger1, logger2)}");
            Console.WriteLine($"Expected number of lines in the log file = {expectedNumberOfRecords}");
            Console.WriteLine($"Number of lines in the log file = {GetFileCount()}");
            Console.WriteLine();

            ILogger logger3 = LoggerFactory.CreateLogger(LoggerType.SqlDb);
            logger3.Log("Database Log Nb: 1.");

            ILogger logger4 = LoggerFactory.CreateLogger(LoggerType.SqlDb);
            logger4.Log("Database Log Nb: 3.");

            Parallel.For(1, 8, index => logger3.Log($"Database Parallel Log Nb: {index}. from logger3"));
            Parallel.For(1, 8, index => logger4.Log($"Database Parallel Log Nb: {index}. from logger4"));

            Console.WriteLine($"Logger3 and Logger4 are the some instance : {Equals(logger3, logger4)}");
            Console.WriteLine($"Expected number of records in Db = {expectedNumberOfRecords}");
            Console.WriteLine($"Number of records in Db = {GetDbCount()}");

            Console.ReadKey();
        }

        private static int GetFileCount()
        {
            int result;
            string path = @"C:\Users\Karco\Desktop\Logs\Logs.txt";

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                result = sr.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Count();
            }

            return result;
        }

        private static int GetDbCount()
        {
            int count;
            string sqlQuery = "SELECT COUNT(*) FROM Logs";

            string conS = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDb)\MSSQLLocalDB",
                InitialCatalog = "Vezba1",
                IntegratedSecurity = true,
                AsynchronousProcessing = true
            }.ConnectionString;

            using (SqlConnection thisConnection = new SqlConnection(conS))
            {
                using (SqlCommand cmdCount = new SqlCommand(sqlQuery, thisConnection))
                {
                    thisConnection.Open();
                    count = Convert.ToInt32(cmdCount.ExecuteScalar());
                }
            }

            return count;
        }
    }
}
