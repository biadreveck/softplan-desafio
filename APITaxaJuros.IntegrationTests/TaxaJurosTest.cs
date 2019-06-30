using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace APITaxaJuros.IntegrationTests
{
    public class TaxaJurosTest : IClassFixture<WebApplicationFactory<APITaxaJuros.Startup>>
    {
        private readonly WebApplicationFactory<APITaxaJuros.Startup> _factory;

        public TaxaJurosTest(WebApplicationFactory<APITaxaJuros.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetTaxaJurosOk()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/taxaJuros");
            string juros = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            Assert.Equal("0,01", juros);
        }
    }
}
