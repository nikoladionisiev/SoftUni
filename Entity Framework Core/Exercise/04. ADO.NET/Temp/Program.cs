using Microsoft.Data.SqlClient;
using System;

namespace Temp
{
    class Program
    {
        public static string connectionString = @"Server=.;DATABASE=MinionsDB;Integrated Security=true;";
        public static SqlConnection connection = new SqlConnection(connectionString);

        static void Main(string[] args)
        {

            connection.Open();

            var minionData = Console.ReadLine().Split();
            var villainData = Console.ReadLine().Split();

            var minionName = minionData[1];
            var minionAge = minionData[2];
            var minionTown = minionData[3];

            var villainName = villainData[1];



            if (!IsTownInDatabase(minionTown))
            {
                InsertTown(minionTown);
                Console.WriteLine($"Town {minionTown} was added to the database.");
            }

            InsertMinion(minionName, minionAge, minionTown);
            Console.WriteLine("Connection is " + connection.State.ToString());

            if (!IsVillainInDatabase(villainName))
            {
                InsertVillain(villainName);
                Console.WriteLine($"Villain {villainName} was added to the database.");
            }



        }

        //insert minion
        private static void InsertMinion(string minionName, string minionAge, string minionTown)
        {
            string command = @"INSERT INTO Minions(Name, Age, TownId) VALUES(@minionName, @minionAge, @townId)";
            using (connection)
            {
               
                var townId = GetIdTown(minionTown);

                SqlCommand sqlCommand = new SqlCommand(command, connection);

                sqlCommand.Parameters.AddWithValue("@minionName", minionName);
                sqlCommand.Parameters.AddWithValue("@minionAge", minionAge);
                sqlCommand.Parameters.AddWithValue("@townId", townId);

                sqlCommand.ExecuteNonQuery();

                Console.WriteLine("Connection is " + connection.State.ToString());
            }
        }




        //inserts villain into database
        private static void InsertVillain(string villainName)
        {
            using (connection)
            {
                string command = @"INSERT INTO Villains([Name], EvilnessFactorId) VALUES(@villainName, 4)";

                SqlCommand sqlCommand = new SqlCommand(command, connection);

                sqlCommand.Parameters.AddWithValue(@"villainName", villainName);

                sqlCommand.ExecuteNonQuery();

            }

        }

        //check if villain is in database
        private static bool IsVillainInDatabase(string villainName)
        {
            string command = @"SELECT [Name] FROM Villains WHERE [Name] = @villainName";

            using (SqlCommand sqlCommand = new SqlCommand(command, connection))
            {
                sqlCommand.Parameters.AddWithValue("@villainName", villainName);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    bool isVillainInDatabase = reader.Read();
                    return isVillainInDatabase;
                }

            }

        }

        //inserts town into database
        private static void InsertTown(string minionTown)
        {
            string command = @"INSERT INTO Towns (Name) VALUES (@townName)";

            using (SqlCommand sqlCommand = new SqlCommand(command, connection))
            {

                sqlCommand.Parameters.AddWithValue("@townName", minionTown);
                sqlCommand.ExecuteNonQuery();
            }

        }

        //checks if town is in database
        private static bool IsTownInDatabase(string minionTown)
        {
            string command = @"SELECT Id FROM Towns WHERE Name = @townName";

            using (SqlCommand sqlCommand = new SqlCommand(command, connection))
            {
                sqlCommand.Parameters.AddWithValue("townName", minionTown);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    bool isTownInDatabase = reader.Read();

                    return isTownInDatabase;
                }


            }

        }
        private static int GetIdTown(string town)
        {
            using (var containsTownCommand = new SqlCommand(
               @"SELECT Id FROM Towns WHERE Name = @townName", connection))
            {
                 

                containsTownCommand.Parameters.AddWithValue("@townName", town);

                var result = containsTownCommand.ExecuteScalar();
                Console.WriteLine("Connection is " + connection.State.ToString());
                return result == null ? 0 : (int)result;
            }
           
        }
    }
}
