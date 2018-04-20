using La_Piazzetta.Models;
using System.Collections.Generic;
using System.Linq;

namespace La_Piazzetta.Managers
{
    public class EmployeeManager
    {
        public List<Employee> GetAll()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return ctx.Employee.ToList();
            }
        }
    }
}