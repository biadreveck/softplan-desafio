using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        // GET calculajuros
        [HttpGet]
        public string Get([FromQuery(Name= "valorinicial")] double valorInicial, [FromQuery(Name = "meses")] int tempo)
        {
            double juros = 0;
            using (HttpClient client = new HttpClient())
            {                
                using (HttpResponseMessage res = client.GetAsync("http://localhost:58899/taxaJuros").Result)
                using (HttpContent content = res.Content)
                {
                    string data = content.ReadAsStringAsync().Result;
                    if (data != null)
                    {
                        juros = Convert.ToDouble(data);
                    }
                }
            }
            
            double result = valorInicial * Math.Pow(1 + juros, tempo);
            return string.Format("{0:N2}", Math.Truncate(100 * result) / 100);
        }
    }
}
