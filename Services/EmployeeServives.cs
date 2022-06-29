using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Model;
using WEB_API_CORE_DEMO.Repositories;
using WEB_API_CORE_DEMO.Services;

namespace WEB_API_CORE_DEMO.Services
{
    public class EmployeeServives: IEmployeeServices
    {
        private readonly IEmployeeRepositories _iEmployeeRepo;
        // Injecition of Dependancy using constructor
        public EmployeeServives(IEmployeeRepositories iEmployeeRepo)
        {
            _iEmployeeRepo = iEmployeeRepo;
        }
        public int AddEmployee(Employee Emp)
        {
            return _iEmployeeRepo.AddEmployee(Emp);
        }
        public int DeleteEmployee(int id)
        {
            return _iEmployeeRepo.DeleteEmployee(id);
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _iEmployeeRepo.GetAllEmployees();
        }
        public int ModifyEmployee(Employee Emp)
        {
            return _iEmployeeRepo.ModifyEmployee(Emp);
        }
    }
}
