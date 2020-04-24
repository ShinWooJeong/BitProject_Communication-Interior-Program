using System;
//using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//namespace 필요


    public class MySqlCreate
    {


        public void SQLConnection()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "unity-daniel-db.mysql.database.azure.com",
                Database = "unity3d_db",
                UserID = "unity3d@unity-daniel-db",
                Password = "Gustmdrnldyal!",
                SslMode = MySqlSslMode.Required,
            };

            using (var conn = new MySqlConnection(builder.ConnectionString))
            {
                Console.WriteLine("Opening connection");
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "DROP TABLE IF EXIST inventory;";
                    command.ExecuteNonQuery();
                    Console.WriteLine("Finished dropping table(if existed)");

                    command.CommandText = "CREATE TABLE user (Id serial PRIMARY KEY, Name VARCHAR(200), Quantity INTEGER);";
                    command.ExecuteNonQuery();
                    Console.WriteLine("Finished creating table");

                    command.CommandText = @"INSERT INTO user (Name, Quantity) VALUES(@Name1, @Quantity1),(@Name2, @Quantity2),(@Name3, @Quantity3);";
                    command.Parameters.Add("@Name1", "Banana");
                    command.Parameters.Add("@Quantity1", 150);
                    command.Parameters.Add("@Name2", "Orange");
                    command.Parameters.Add("@Quantity2", 154);
                    command.Parameters.Add("@Name3", "Apple");
                    command.Parameters.Add("@Quantity3", 100);

                    int rowCount = command.ExecuteNonQuery();
                    Console.WriteLine(String.Format("Number of rows inserted = {0}", rowCount));


                }

                Console.WriteLine("Closing connection");

            }

            Console.WriteLine("Press RETURN to exit");
            Console.ReadLine();
        }

        //// 비동기 반환방식
        //static async Task Main(string[] args)
        //{
            
        //    var builder = new MySqlConnectionStringBuilder
        //    {
        //        Server = "unity-daniel-db.mysql.database.azure.com",
        //        Database = "unity3d_db",
        //        UserID = "unity3d@unity-daniel-db",
        //        Password = "Gustmdrnldyal!",
        //        SslMode = MySqlSslMode.Required,
        //    };

        //    using (var conn = new MySqlConnection(builder.ConnectionString))
        //    {
        //        Console.WriteLine("Opening connection");
        //        await conn.OpenAsync();

        //        using (var command = conn.CreateCommand())
        //        {
        //            command.CommandText = "DROP TABLE IF EXIST inventory;";
        //            await command.ExecuteNonQueryAsync();
        //            Console.WriteLine("Finished dropping table(if existed)");

        //            command.CommandText = "CREATE TABLE user (Id serial PRIMARY KEY, Name VARCHAR(200), Quantity INTEGER);";
        //            await command.ExecuteNonQueryAsync();
        //            Console.WriteLine("Finished creating table");

        //            command.CommandText = @"INSERT INTO user (Name, Quantity) VALUES(@Name1, @Quantity1),(@Name2, @Quantity2),(@Name3, @Quantity3);";
        //            command.Parameters.AddWithValues("@Name1", "Banana");
        //            command.Parameters.AddWithValues("@Quantity1", 150);
        //            command.Parameters.AddWithValues("@Name2", "Orange");
        //            command.Parameters.AddWithValues("@Quantity2", 154);
        //            command.Parameters.AddWithValues("@Name3", "Apple");
        //            command.Parameters.AddWithValues("@Quantity3", 100);

        //            int rowCount = await command.ExecuteNonQueryAsync();
        //            Console.WriteLine(String.Format("Number of rows inserted = {0}", rowCount));


        //        }

        //        Console.WriteLine("Closing connection");

        //    }

        //    Console.WriteLine("Press RETURN to exit");
        //    Console.ReadLine();

            
        //}

    }
