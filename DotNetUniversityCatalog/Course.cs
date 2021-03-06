﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetUniversityCatalog
{
    class Course
    {
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public string InstName { get; set; }
        public string CourseNumber { get; set; }
        public int DeptCode { get; set; }

        public Course(SqlDataReader reader)
        {
            Id = (int)reader["Id"];
            CourseTitle = reader["CourseTitle"].ToString();
            InstName = reader["InstName"].ToString();
            CourseNumber = reader["CourseNumber"].ToString();
            DeptCode = (int)reader["DeptCode"];
        }
    }
}
