using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetUniversityCatalog
{
    class Instructor
    {
        public int Id { get; set; }
        public string InstName { get; set; }
        public string CourseNumber { get; set; }


        public Instructor(SqlDataReader reader)
        {
            Id = (int)reader["Id"];
            InstName = reader["InstName"].ToString();
            CourseNumber = reader["CourseNumber"].ToString();
        }

    }
}
