using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Entities;
using WEB_API_CORE_DEMO.Model;

namespace WEB_API_CORE_DEMO.Repositories
{
    public class EmployeeRepositories : IEmployeeRepositories
    {
        RepositoriesContext context;
        public EmployeeRepositories(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddEmployee(Employee Emp)
        {
            context.Employees.Add(Emp);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteEmployee(int id)
        {
            var Emp = context.Employees.Where(p => p.Id == id).SingleOrDefault();
            if (Emp != null)
            {
                context.Employees.Remove(Emp);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public int ModifyEmployee(Employee Emp)
        {
            var Employee = context.Employees.Where(p => p.Id == Emp.Id).SingleOrDefault();
            if (Employee != null)
            {
                Employee.Name = Emp.Name;
                Employee.Salary = Emp.Salary;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }

    }
}
