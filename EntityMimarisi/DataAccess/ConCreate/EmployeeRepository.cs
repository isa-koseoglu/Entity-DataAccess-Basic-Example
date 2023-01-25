using EntityMimarisi.DataAccess.Abstract;
using EntityMimarisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMimarisi.DataAccess.ConCreate
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> Created(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            using(var employee=new EmployeeDbContext())
            {
                return employee.Employees.ToList();
            }
            
        }

        public IEnumerable<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
