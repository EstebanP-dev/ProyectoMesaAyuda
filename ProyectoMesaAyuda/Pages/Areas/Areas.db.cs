using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesaAyuda.Pages.Areas.Db
{
    public class Areas
    {
        private DBConnection connection = new DBConnection();

        SqlDataReader read;

        DataTable table = new DataTable();

        SqlCommand command = new SqlCommand();

        public DataTable GetAreas()
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "SELECT * FROM Areas";
            read = command.ExecuteReader();

            table.Load(read);

            connection.CloseConnection();

            return table;
        }
    }
}
