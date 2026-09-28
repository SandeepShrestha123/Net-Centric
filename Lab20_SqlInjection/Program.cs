using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=users.db");
connection.Open();

// Setup: create table and insert a sample user
var setup = connection.CreateCommand();
setup.CommandText = @"
    DROP TABLE IF EXISTS Users;
    CREATE TABLE Users (Id INTEGER PRIMARY KEY, Username TEXT, Password TEXT);
    INSERT INTO Users (Username, Password) VALUES ('admin', 'secret123');
";
setup.ExecuteNonQuery();

Console.WriteLine("Real login is Username: admin  Password: secret123");
Console.WriteLine("Try typing:  admin' --   as the username (with any password) to see the attack.\n");

Console.Write("Enter username: ");
string username = Console.ReadLine();

Console.Write("Enter password: ");
string password = Console.ReadLine();

Console.WriteLine("\n=== VULNERABLE: Raw string concatenation ===");
VulnerableLogin(connection, username, password);

Console.WriteLine("\n=== SAFE: Parameterized query ===");
SafeLogin(connection, username, password);

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();


static void VulnerableLogin(SqliteConnection connection, string username, string password)
{
    var cmd = connection.CreateCommand();
    cmd.CommandText = "SELECT * FROM Users WHERE Username = '" + username +
                       "' AND Password = '" + password + "'";

    Console.WriteLine("Executed SQL: " + cmd.CommandText);

    using var reader = cmd.ExecuteReader();
    if (reader.Read())
        Console.WriteLine("LOGIN SUCCESS");
    else
        Console.WriteLine("Login failed.");
}

static void SafeLogin(SqliteConnection connection, string username, string password)
{
    var cmd = connection.CreateCommand();
    cmd.CommandText = "SELECT * FROM Users WHERE Username = @username AND Password = @password";
    cmd.Parameters.AddWithValue("@username", username);
    cmd.Parameters.AddWithValue("@password", password);

    Console.WriteLine("Executed SQL: " + cmd.CommandText);

    using var reader = cmd.ExecuteReader();
    if (reader.Read())
        Console.WriteLine("LOGIN SUCCESS");
    else
        Console.WriteLine("Login failed.");
}