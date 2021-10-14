using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesaAyuda
{
    public class DBConnection
    {
        private SqlConnection Connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MesaAyuda.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection OpenConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
            return Connection;
        }
        public SqlConnection CloseConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
            return Connection;
        }
    }
}
