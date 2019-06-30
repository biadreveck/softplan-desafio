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
        /// <summary>
        /// Retorna o caminho do fonte do projeto
        /// </summary>
        [HttpGet]
        public string Get()
        {
            return "https://github.com/biadreveck/softplan-desafio";
        }
    }
}
