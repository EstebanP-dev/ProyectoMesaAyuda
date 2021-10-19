using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;
using System.Reflection;
using FeatureLayer.Models;

namespace DataLayer
{
    public class DBEmployees
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        public List<Employees> GetEmployees()
        {
            List<Employees> data = new List<Employees>();
            SqlDataReader read;
            SqlCommand cmd = new SqlCommand("@SP_GETEMPLOYEES", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            read = cmd.ExecuteReader();

            while (read.Read())
            {
                data.Add(new Employees
                {
                    Id = read.GetInt32(0),
                    Code = read.GetString(1),
                    Photo = read.GetString(2),
                    CVEmployee = read.GetString(3),
                    Telephone = read.GetString(4),
                    Email = read.GetString(5),
                    Address = read.GetString(6),
                    CordX = read.GetDecimal(7),
                    CordY = read.GetDecimal(8),
                    fk_EmployeeBoss = read.GetInt32(9),
                    fk_Area = read.GetInt32(10),
                });
            }
            connection.Close();
            read.Close();

            return data;
        }

        public void InsertEmployee(Employees employee)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTEMPLOYEE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@NAME", employee.Name);
            cmd.Parameters.AddWithValue("@PHOTO", employee.Photo);
            cmd.Parameters.AddWithValue("@CVEMPLOYEE", employee.CVEmployee);
            cmd.Parameters.AddWithValue("@TELEPHONE", employee.Telephone);
            cmd.Parameters.AddWithValue("@EMAIL", employee.Email);
            cmd.Parameters.AddWithValue("@ADDRESS", employee.Address);
            cmd.Parameters.AddWithValue("@CORDX", employee.CordX);
            cmd.Parameters.AddWithValue("@CORDY", employee.CordY);
            cmd.Parameters.AddWithValue("@FKEMPLOYEEBOSS", employee.fk_EmployeeBoss);
            cmd.Parameters.AddWithValue("@FKAREA", employee.fk_Area);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void EditEmployee(Employees employee)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITEMPLOYEE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDEMPLOYEE", employee.Id);
            cmd.Parameters.AddWithValue("@NAME", employee.Name);
            cmd.Parameters.AddWithValue("@PHOTO", employee.Photo);
            cmd.Parameters.AddWithValue("@CVEMPLOYEE", employee.CVEmployee);
            cmd.Parameters.AddWithValue("@TELEPHONE", employee.Telephone);
            cmd.Parameters.AddWithValue("@EMAIL", employee.Email);
            cmd.Parameters.AddWithValue("@ADDRESS", employee.Address);
            cmd.Parameters.AddWithValue("@CORDX", employee.CordX);
            cmd.Parameters.AddWithValue("@CORDY", employee.CordY);
            cmd.Parameters.AddWithValue("@FKEMPLOYEEBOSS", employee.fk_EmployeeBoss);
            cmd.Parameters.AddWithValue("@FKAREA", employee.fk_Area);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void DeleteEmployee(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETEEMPLOYEE", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDEMPLOYEE", id);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
