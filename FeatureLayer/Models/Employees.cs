using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureLayer.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string CVEmployee { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal CordX { get; set; }
        public decimal CordY { get; set; }
        public int fk_EmployeeBoss { get; set; }
        public int fk_Area { get; set; }
    }
}
