using EntityMimarisi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMimarisi.DataAccess.Abstract
{
    public  interface IEmployeeRepository
    {
        List<Employee> GetAll();
        IEnumerable<Employee> GetById(int id);
        IEnumerable<Employee> Created(Employee employee);
    }
}
