using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Users;

namespace DAL.Users
{
    public class UserDb:DALBase
    {
        public  int InsertEmployee(EmployeeDTO emp)
        {
            SqlCommand cmd = GetDbSprocCommand("sp_InsertEmployee");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@Gender", emp.Gender);
            cmd.Parameters.AddWithValue("@Department", emp.Department);

            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();

            return result;
        }
    }
}
