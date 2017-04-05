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
            const string connectionString = 
                @"Server=localhost\SQLEXPRESS;Database=DotNetUniversityCatalog;Trusted_Connection=True;";

            var courses = new List<Course>();
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
                    var course = new Course(reader);
                    courses.Add(course);
                }
                connection.Close();
            }

            foreach(var course in courses)
            {
                Console.WriteLine(course.CourseTitle);
            }

            //var course = new List<Course>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    courses = GetAllCourses(connection);
            //    foreach (var city in course)
            //    {
            //        Console.WriteLine(course.CourseTitle);
            //    }



            //}
        }
    }
}
