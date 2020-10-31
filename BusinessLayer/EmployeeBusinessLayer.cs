using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public IEnumerable <Employee > Employees
        {
            get
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                List<Employee> employees = new List<Employee>();
                using (SqlConnection con= new SqlConnection(connectionstring) )
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees",con );
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.ID = Convert.ToInt32(rdr["id"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.Gender = rdr["Gender"].ToString() ;
                        employee.City = rdr["City"].ToString();

                        employees.Add(employee);
                    }
                }
                return employees;
            }
        }
    }
}
