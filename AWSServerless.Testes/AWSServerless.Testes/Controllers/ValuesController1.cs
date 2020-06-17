using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AWSServerless.Testes.Controllers
{
    [Route("v1/awsTeste")]
    [ApiController]
    public class ValuesController1 : ControllerBase
    {

        // POST api/<ValuesController1>
        [HttpGet]
        public IActionResult GetTeste()
        {
            var result = "Green AWS LAmbda functioooon!!!!";
            return Ok(result);
        }

    }
}
