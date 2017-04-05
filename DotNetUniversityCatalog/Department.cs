using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetUniversityCatalog
{
    class Department
    {
        public int Id { get; set; }
        public string HeadInst { get; set; }
        public string DeptName { get; set; }
        public int DeptCode { get; set; }

        public Department(SqlDataReader reader)
        {
            Id = (int)reader["Id"];
            HeadInst = reader["HeadInst"].ToString();
            DeptName = reader["DeptName"].ToString();
            DeptCode = (int)reader["DeptCode"];
        }
    }
}
