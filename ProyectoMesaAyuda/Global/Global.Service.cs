using ProyectoMesaAyuda.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesaAyuda.Global.Service
{
    public class Global
    {
        private ApiCall.Global api = new ApiCall.Global();

        public DataTable GetData(string tableQuery)
        {
            DataTable table = new DataTable();
            table = api.GetData(tableQuery);

            return table;
        }

        public void PostAreas(Areas area)
        {
            api.PostAreas(area);
        }
    }
}
