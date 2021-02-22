using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace _07._Print_All_Minion_Names
{
    class Program
    {
        private static string StringConnection = @"Server=.\SQLEXPRESS;Database=MinionsDB;Integrated Security=true;";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(StringConnection);
            connection.Open();

            using (connection)
            {
                using var command = new SqlCommand(
                    @"SELECT Name FROM Minions", connection);

                var reader = command.ExecuteReader();

                var minions = new List<string>();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var name = (string)reader["Name"];
                        minions.Add(name);
                    }
                }

                for (int i = 0; i < minions.Count / 2; i++)
                {
                    var front = minions[i];
                    var back = minions[minions.Count - i - 1];

                    Console.WriteLine(front);
                    Console.WriteLine(back);
                }
            }
        }
    }
}
