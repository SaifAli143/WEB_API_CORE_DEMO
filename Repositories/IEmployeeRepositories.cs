using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Model;

namespace WEB_API_CORE_DEMO.Repositories
{
    public interface IEmployeeRepositories
    {
        IEnumerable<Employee> GetAllEmployees();
        int AddEmployee(Employee Emp);
        int ModifyEmployee(Employee Emp);
        int DeleteEmployee(int id);
    }
}
