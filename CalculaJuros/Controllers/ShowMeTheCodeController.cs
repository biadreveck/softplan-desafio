using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        // GET: showmethecode
        [HttpGet]
        public string Get()
        {
            return "[URL GITHUB]";
        }
    }
}
