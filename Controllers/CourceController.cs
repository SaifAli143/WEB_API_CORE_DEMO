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
    public class CourceController : ControllerBase
    {
        private readonly ICourceServices _courservice;
        public CourceController(ICourceServices courservice)
        {
            _courservice = courservice;
        }
        [HttpGet]
        [Route("GetCources")]
        public IActionResult GetCources()
        {
            return new ObjectResult(_courservice.GetAllCources());
            // test code
        }
        [HttpPost]
        [Route("AddCource")]
        public IActionResult AddCource(Cource cour)
        {
            return new ObjectResult(_courservice.AddCource(cour));
        }

        [HttpPost]
        [Route("ModifyCource")]
        public IActionResult ModifyCource(Cource cour)
        {
            return new ObjectResult(_courservice.ModifyCource(cour));
        }

        [HttpGet]
        [Route("DeleteCource/{id}")]
        public IActionResult DeleteCource(int id)
        {
            return new ObjectResult(_courservice.DeleteCource(id));
        }

    }
}
