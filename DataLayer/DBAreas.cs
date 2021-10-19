using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using FeatureLayer.Models;
using System.Data;
using Newtonsoft.Json;
using System.Reflection;

namespace DataLayer
{
    public class DBAreas
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        public List<Areas> SearchAreas(string nameArea)
        {
            List<Areas> data = new List<Areas>();
            SqlDataReader read;
            SqlCommand cmd = new SqlCommand("SP_SEARCHAREA", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@NAMEAREA", nameArea);

            read = cmd.ExecuteReader();

            while (read.Read())
            {
                data.Add(new Areas
                {
                    Id = read.GetInt32(0),
                    Code = read.GetString(1),
                    Name = read.GetString(2),
                    fk_Employee = read.GetInt32(3)
                });
            }
            connection.Close();
            read.Close();

            return data;
        }
        public List<Areas> GetAreas()
        {
            List<Areas> data = new List<Areas>();
            SqlDataReader read;
            SqlCommand cmd = new SqlCommand("SP_GETAREAS", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            read = cmd.ExecuteReader();

            while (read.Read())
            {
                data.Add(new Areas
                {
                    Id = read.GetInt32(0),
                    Code = read.GetString(1),
                    Name = read.GetString(2),
                    fk_Employee = read.GetInt32(3)
                });
            }
            connection.Close();
            read.Close();

            return data;
        }

        public void InsertArea(Areas area)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAREA", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@NAME", area.Name);
            cmd.Parameters.AddWithValue("@MANAGER", area.fk_Employee);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void EditArea(Areas area)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAREA", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDAREA", area.Id);
            cmd.Parameters.AddWithValue("@NAME", area.Name);
            cmd.Parameters.AddWithValue("@MANAGER", area.fk_Employee);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void DeleteArea(Areas area)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETEAREA", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();

            cmd.Parameters.AddWithValue("@IDAREA", area.Id);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
