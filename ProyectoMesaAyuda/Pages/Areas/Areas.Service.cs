using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesaAyuda.Pages.Areas.Service
{
    public class Areas
    {
        private Db.Areas objectArea = new Db.Areas();

        public DataTable GetAreas()
        {
            DataTable table = new DataTable();
            table = objectArea.GetAreas();

            return table;
        }
    }
}
