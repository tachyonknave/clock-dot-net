namespace ClockDotNet.DB;
using System.Data.SQLite;

public class SqliteDatabase
{
    private SQLiteConnection? connection;

    public void ConnectToDatabase(string filePath)
    {
        string connectionString = $"Data Source={filePath};Version=3;";
        connection = new SQLiteConnection(connectionString);
        connection.Open();
    }

    public void Close()
    {
        connection?.Close();
    }
}