using System;
using Microsoft.Data.SqlClient;

namespace _06._Remove_Villain
{
    class Program
    {
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=MinionsDB;Integrated Security=true;";

        static void Main(string[] args)
        {
            int villain = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            using (connection)
            {
                using SqlCommand command = new SqlCommand(@"SELECT Name FROM Villains WHERE Id = @villainId", connection);

                command.Parameters.AddWithValue("@villainId", villain);

                var result = command.ExecuteScalar();

                if (result == null)
                {
                    Console.WriteLine("No such villain was found.");
                }
                else
                {
                    using var deleteMappingTableCommand = new SqlCommand(
                        @"DELETE FROM MinionsVillains 
                            WHERE VillainId = @villainId", connection);

                    deleteMappingTableCommand.Parameters.AddWithValue("@villainId", villain);
                    deleteMappingTableCommand.ExecuteNonQuery();

                    using var deleteVillainsTableCommand = new SqlCommand(
                        @"DELETE FROM Villains
                            WHERE Id = @villainId", connection);

                    deleteVillainsTableCommand.Parameters.AddWithValue("@villainId", villain);
                    var minionReleased = deleteVillainsTableCommand.ExecuteNonQuery();

                    Console.WriteLine($"{(string)result} was deleted.");
                    Console.WriteLine($"{minionReleased} minions were released.");
                }
            }
        }
    }
}
