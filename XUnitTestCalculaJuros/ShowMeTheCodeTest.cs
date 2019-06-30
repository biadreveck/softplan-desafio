using CalculaJuros.Controllers;
using Xunit;

namespace CalculaJuros.UnitTests
{
    public class ShowMeTheCodeTest
    {
        [Fact]
        public void GetShowMeTheCodeOk()
        {
            ShowMeTheCodeController controller = new ShowMeTheCodeController();

            string url = controller.Get();
            Assert.Equal("https://github.com/biadreveck/softplan-desafio", url);
        }
    }
}
