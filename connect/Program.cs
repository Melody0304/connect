using MySqlConnector;

namespace connect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder() 
            { 
                Server = "127.0.01",
                UserID = "root",
                Password = "password",
                Database = "demo211",
            };
            
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            connection.Open();

            Console.WriteLine("Connected to database.");

            connection.Close();
        }
    }
}