using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace _05._Change_Town_Names_Casing
{
    class Program
    {
        public static string connectionString = @"Server=.;DATABASE=MinionsDB;Integrated Security=true;";
        public static SqlConnection connection = new SqlConnection(connectionString);

        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            connection.Open();

            using (connection)
            {
                string command = @"UPDATE Towns SET Name = UPPER(Name) WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";

                SqlCommand sqlCommand = new SqlCommand(command, connection);

                sqlCommand.Parameters.AddWithValue("@countryName", countryName);

                int affectedRows = sqlCommand.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    Console.WriteLine("No town names were affected.");
                }
                else
                {
                    using SqlCommand getCountryCommand = new SqlCommand(
                                           @"SELECT t.Name 
                                                FROM Towns as t
                                                JOIN Countries AS c ON c.Id = t.CountryCode
                                                WHERE c.Name = @countryName",
                                           connection);

                    getCountryCommand.Parameters.AddWithValue("@countryName", countryName);

                    var reader = getCountryCommand.ExecuteReader();

                    List<string> towns = new List<string>();

                    using (reader)
                    {
                        while (reader.Read())
                        {
                            var townName = (string)reader[0];
                            towns.Add(townName);
                        }
                    }

                    Console.WriteLine($"{(int)affectedRows} town names were affected. ");
                    Console.WriteLine($"[{string.Join(", ", towns)}]");
                }
            }
        }
    }
}
