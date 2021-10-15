using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMesaAyuda.Models
{
    public class Employees
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Employee_CV { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal Cord_X { get; set; }
        public decimal Cord_Y { get; set; }
        public string fk_EmployeeBoss { get; set; }
        public string fk_Area { get; set; }
    }
}
