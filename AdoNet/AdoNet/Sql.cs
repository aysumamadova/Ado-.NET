using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AdoNet
{
    class Sql
    {
        private static string connectionString = @"Server=213-18;Database=MoviesS;Trusted_Connection=True;";
        public static void InfoActors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Actors";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            Console.WriteLine($"{dr["Id"]} {dr["Name"]} {dr["Surname"]} {dr["Age"]}");
                        }
                    }
                   
                    
                }
            }
        }
       public static void CreateActors(string Name, string Surname, int Age)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Actors VALUES (N'{Name}', N'{Surname}', N'{Age}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Actors create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
       public static void DeleteActors(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Actors WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Actors deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void UpdateActors(string Name, string Surname, int Age,int ID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"UPDATE Actor SET  Name='{Name}', Surname= '{Surname}', Age= '{Age} WHERE ID='{ID}'";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Actors Update");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }


        public static void InfoCustomers ()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Customers";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            Console.WriteLine($"{dr["Id"]} {dr["Name"]} {dr["Surname"]} {dr["Age"]}");
                        }
                    }


                }
            }
        }
        public static void CreateCustomers(string Name, string Surname, int Age)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Customers VALUES (N'{Name}', N'{Surname}', N'{Age}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Customers create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void DeleteCustomers(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Customers WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Customers deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void UpdateCustomers(string Name, string Surname, int Age, int ID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"UPDATE Customers SET  Name='{Name}', Surname= '{Surname}', Age= '{Age} WHERE ID='{ID}'";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Customers Update");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }


        public static void InfoMoviesActors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM MoviesActors";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr["Id"]} {dr["MoviesID"]} {dr["ActorID"]}");
                    }
                }
            }
        }
        public static void CreateMoviesActors(int MoviesID, int ActorsID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO MoviesActors VALUES (N'{MoviesID}', N'{ActorsID}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("MoviesActors create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void DeleteMoviesActors(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE MoviesActors WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("MoviesActors deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void UpdateMoviesActors(int MoviesActorsid, int MoviesID, int ActorID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"UPDATE MoviesActors SET  MoviesID='{MoviesID}', ActorID= '{ActorID}' WHERE ID='{MoviesActorsid}'";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("MoviesActors Update");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        //Eyni oldugunan digerlerine update qeyd etmemisem
        public static void InfoGenres()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Genres";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr["Id"]} {dr["Name"]}");
                    }
                }
            }
        }
       public static void CreateGenres(string Name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Genres VALUES (N'{Name}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Genres create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
       public static void DeleteGenres(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Genres WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Genres deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

       public static void InfoMovies()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Movies";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr["Id"]} {dr["Name"]} {dr["ReleaseDate"]}");
                    }
                }
            }
        }
      public  static void CreateMovies(string Name, string RelaseDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Movies VALUES (N'{Name}', N'{RelaseDate}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Movies create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
       public static void DeleteMovies(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Movies WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Movies deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        public static void InfoMoviesGenres()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM MoviesGenres";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr["Id"]} {dr["GenresID"]} {dr["MoviesID"]}");
                    }
                }
            }
        }
        public static void CreateMoviesGenres(int GenresID, int MoviesID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO MoviesGenres VALUES (N'{GenresID}', N'{MoviesID}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("MoviesGenres create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void DeleteMoviesGenres(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE MoviesGenres WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("MoviesGenres deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        public static void InfoSessionss()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Sessionss";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr["Id"]} {dr["Time"]} ");
                    }
                }
            }
        }
        public static void CreateSessionss(string Time)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Sessionss VALUES ('{Time}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Sessionss create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void DeleteSessionss(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Sessionss WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Sessionss deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        public static void InfoHalls()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Halls";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr["Id"]} {dr["Name"]} {dr["SeatCount"]}");
                    }
                }
            }
        }
        public static void CreateHalls(string Name, int SeatCount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Halls VALUES (N'{Name}', '{SeatCount}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Halls create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void DeleteHalls(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Halls WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Halls deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

        public static void InfoTickets()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "SELECT * FROM Tickets";
                using (SqlDataAdapter sda = new SqlDataAdapter(command, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr["Id"]} {dr["SolDate"]} {dr["Price"]} {dr["Place"]} {dr["CustomerID"]} {dr["HALLID"]} {dr["MoviesID"]} {dr["SessionsID"]}");
                    }
                }
            }
        }
        public static void CreateTickets(string SolDate,double  Price,int Place,int CustomerID, int HALLID, int MoviesID,int SessionsID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"INSERT INTO Tickets VALUES ('{SolDate}', '{Price}','{Place}', '{MoviesID}','{CustomerID}', '{MoviesID}','{HALLID}', '{MoviesID}','{SessionsID}')";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Tickets create");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }
        public static void DeleteTickets(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = $"DELETE Tickets WHERE Id ={id}";
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    if (comm.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("Tickets deleted");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
            }
        }

      

    }
}

