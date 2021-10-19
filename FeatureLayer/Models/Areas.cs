using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureLayer.Models
{
    public class Areas
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int fk_Employee { get; set; }
    }
}
