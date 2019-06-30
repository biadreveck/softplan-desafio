using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.IntegrationTests
{
    public class CalculaJurosTests : IClassFixture<WebApplicationFactory<CalculaJuros.Startup>>
    {
        private readonly WebApplicationFactory<CalculaJuros.Startup> _factory;

        public CalculaJurosTests(WebApplicationFactory<CalculaJuros.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetCalculaJurosOk()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/calculajuros?valorinicial=100&meses=5");
            string resultado = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            Assert.Equal("105,10", resultado);
        }
    }
}
