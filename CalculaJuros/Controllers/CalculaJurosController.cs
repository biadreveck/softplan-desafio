using System;
using System.Collections.Generic;
using System.Globalization;
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
        /// <summary>
        /// Calcula o juros do valor inicial e tempo
        /// </summary>
        /// <param name="valorInicial">Valor base para o cálculo do juros</param>
        /// <param name="tempo">Tempo, em meses, usado para cálculo do juros</param>
        /// <returns>Retorna o resultado do cálculo do juros</returns>
        [HttpGet]
        public string Get([FromQuery(Name= "valorinicial")] double valorInicial, [FromQuery(Name = "meses")] int tempo)
        {
            double juros = 0;
            using (HttpClient client = new HttpClient())
            {                
                using (HttpResponseMessage res = client.GetAsync("https://apitaxajuros20190629055121.azurewebsites.net/taxaJuros").Result)
                using (HttpContent content = res.Content)
                {
                    string data = content.ReadAsStringAsync().Result;
                    if (data != null)
                    {
                        juros = Convert.ToDouble(data, CultureInfo.GetCultureInfo("pt-br"));
                    }
                }
            }
            
            double result = valorInicial * Math.Pow(1 + juros, tempo);
            return string.Format(CultureInfo.GetCultureInfo("pt-br"), "{0:N2}", Math.Truncate(100 * result) / 100);
        }
    }
}
