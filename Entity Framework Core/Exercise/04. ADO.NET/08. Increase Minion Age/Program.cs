using Microsoft.Data.SqlClient;
using System;
using System.Linq;

namespace _08._Increase_Minion_Age
{
    class Program
    {
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=MinionsDB;Integrated Security=true;";

        static void Main(string[] args)
        {
            var ids = Console.ReadLine().Split().Select(int.Parse).ToList();

            var connection = new SqlConnection(connectionString);
            connection.Open();

            using (connection)
            {
                foreach (var id in ids)
                {
                    using var command = new SqlCommand(
                                    @"UPDATE Minions
                                    SET Name = UPPER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1
                                    WHERE Id = @Id",
                                  connection);

                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }

                using var getCommand = new SqlCommand(
                    "SELECT Name, Age FROM Minions", connection);

                var reader = getCommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var name = (string)reader["Name"];
                        var age = (int)reader["Age"];

                        Console.WriteLine($"{name} {age}");
                    }
                }
            }
        }
    }
}
