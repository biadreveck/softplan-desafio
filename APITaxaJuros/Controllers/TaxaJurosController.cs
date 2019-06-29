using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APITaxaJuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        // GET taxaJuros
        [HttpGet]
        public string Get()
        {
            return "0,01";
        }
    }
}
