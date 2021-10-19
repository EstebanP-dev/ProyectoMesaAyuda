using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using FeatureLayer.Models;

namespace BusinessLayer
{
    public class AreasService
    {
        DBAreas data = new DBAreas();

        public List<Areas> SearchAreas(string nameAreas)
        {
            return data.SearchAreas(nameAreas);
        }
        public List<Areas> GetAreas()
        {
            return data.GetAreas();
        }

        public void InsertArea(Areas area)
        {
            data.InsertArea(area);
        }

        public void EditArea(Areas area)
        {
            data.EditArea(area);
        }

        public void DeleteArea(Areas area)
        {
            data.DeleteArea(area);
        }
    }
}
