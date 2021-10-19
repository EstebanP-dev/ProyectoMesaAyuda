using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using FeatureLayer.Models;

namespace BusinessLayer
{
    public class EmployeesService
    {
        DBEmployees data = new DBEmployees();

        public List<Employees> GetEmployees()
        {
            return data.GetEmployees();
        }

        public void InsertEmployee(Employees employee)
        {
            data.InsertEmployee(employee);
        }

        public void EditEmployee(Employees employee)
        {
            data.EditEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            data.DeleteEmployee(id);
        }
    }
}
