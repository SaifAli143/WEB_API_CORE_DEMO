using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Model;
using WEB_API_CORE_DEMO.Services;

namespace WEB_API_CORE_DEMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _Empservice;
        public EmployeeController(IEmployeeServices Empservice)
        {
            _Empservice = Empservice;
        }
        [HttpGet]
        [Route("GetEmployee")]
        public IActionResult GetEmployees()
        {
            return new ObjectResult(_Empservice.GetAllEmployees());
            // test code
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee Emp)
        {
            return new ObjectResult(_Empservice.AddEmployee(Emp));
        }

        [HttpPost]
        [Route("ModifyEmployee")]
        public IActionResult ModifyEmployee(Employee Emp)
        {
            return new ObjectResult(_Empservice.ModifyEmployee(Emp));
        }

        [HttpGet]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            return new ObjectResult(_Empservice.DeleteEmployee(id));
        }
    }
}
