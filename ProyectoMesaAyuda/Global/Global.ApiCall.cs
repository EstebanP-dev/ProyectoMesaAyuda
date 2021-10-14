using ProyectoMesaAyuda.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesaAyuda.Global.ApiCall
{
    public class Global
    {
        private DBConnection connection = new DBConnection();

        SqlDataReader read;

        DataTable table = new DataTable();

        SqlCommand command = new SqlCommand();

        public DataTable GetData(string tableQuery)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = $"SELECT * FROM {tableQuery}";
            read = command.ExecuteReader();

            table.Load(read);

            connection.CloseConnection();

            return table;
        }

        public void PostAreas(Areas area)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = $"INSERT INTO Areas VALUES ({area.Id},{area.Name},{area.fk_Employee})";
            command.ExecuteNonQuery();
        }
    }
}
