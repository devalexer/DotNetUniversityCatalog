using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetUniversityCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = @"Server=localhost\SQLEXPRESS;Database=DotNetUniversityCatalog;Trusted_Connection=True;";
            using (var connection = new SqlConnection(connectionString))
            {
                var sqlCommand = new SqlCommand(@"SELECT Course.CourseTitle, Instructor.InstName
                                                FROM Course
                                                JOIN Instructor ON Course.InstName = Instructor.Id", 
                                                connection);
                connection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["CourseTitle"] + "--" + reader["InstName"]);
                }

                connection.Close();
            }

        }
    }
}
