using Microsoft.Data.SqlClient;
using System;

namespace _03._Minion_Names
{
    class Program
    {
        private const string connectionString = @"Server=.;DATABASE=MinionsDB;Integrated Security=true;";

        static void Main(string[] args)
        {
            var id = int.Parse(Console.ReadLine());

            var connection = new SqlConnection(connectionString);
            connection.Open();

            using (connection)
            {
                var queryNameMinions = @"SELECT Name FROM Villains WHERE Id = @Id";

                using var selectNameCommand = new SqlCommand(queryNameMinions, connection);
                selectNameCommand.Parameters.AddWithValue("@Id", id);

                var currentMinion = (string)selectNameCommand.ExecuteScalar();

                if (currentMinion == null)
                {
                    Console.WriteLine($"No villain with ID {id} exists in the database.");
                }
                else
                {
                    var queryNameAndAgeMinions = @"SELECT ROW_NUMBER() OVER 
                                            (ORDER BY m.Name) as RowNum,
                                                 m.Name, 
                                                 m.Age
                                                FROM MinionsVillains AS mv
                                                    JOIN Minions As m ON mv.MinionId = m.Id
                                                WHERE mv.VillainId = @Id
                                                ORDER BY m.Name";
                    using var selectNameAndAgeCommand = new SqlCommand(queryNameAndAgeMinions, connection);
                    selectNameAndAgeCommand.Parameters.AddWithValue("@Id", id);

                    var reader = selectNameAndAgeCommand.ExecuteReader();

                    using (reader)
                    {
                        Console.WriteLine($"Villain: {currentMinion}");
                        int countRow = 1;
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("(no minions)");
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                var name = (string)reader["Name"];
                                var age = (int)reader["Age"];

                                Console.WriteLine($"{countRow++}. {name} {age}");
                            }
                        }
                    }
                }
            }
        }
    }
}