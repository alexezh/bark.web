using Microsoft.Data.Sqlite;

public static class DbUtils
{
  public static SqliteConnection CreateConnection()
  {
    return new SqliteConnection("Data Source=hello.db");
  }

  public static void Create()
  {
    using (var connection = CreateConnection())
    {
      connection.Open();

      {
        var command = connection.CreateCommand();
        command.CommandText = "CREATE TABLE IF NOT EXISTS Project (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)";

        using (var reader = command.ExecuteReader())
        {
          // reader.
        }
      }

      {
        var command = connection.CreateCommand();
        command.CommandText = "CREATE TABLE IF NOT EXISTS Resource (projectId INTEGER, id TEXT)";
        using (var reader = command.ExecuteReader())
        {
          // reader.
        }
      }
    }
  }

  public static void CreateProject(string id)
  {
    using (var connection = CreateConnection())
    {
      connection.Open();

      {
        var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO project(name) VALUES($name)";
        command.Parameters.AddWithValue("$name", id);

        var inserted = command.ExecuteNonQuery();
        if (inserted != 1)
        {
          throw new ArgumentException("Cannot insert");
        }
      }
    }
  }
}
