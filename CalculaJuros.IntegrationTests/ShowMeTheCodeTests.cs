using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.IntegrationTests
{
    public class ShowMeTheCodeTests : IClassFixture<WebApplicationFactory<CalculaJuros.Startup>>
    {
        private readonly WebApplicationFactory<CalculaJuros.Startup> _factory;

        public ShowMeTheCodeTests(WebApplicationFactory<CalculaJuros.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetShowMeTheCodeOk()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/showmethecode");
            string url = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            Assert.Equal("https://github.com/biadreveck/softplan-desafio", url);
        }
    }
}
