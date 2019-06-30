using CalculaJuros.Controllers;
using Xunit;

namespace XUnitTestCalculaJuros
{
    public class ShowMeTheCodeTest
    {
        [Fact]
        public void GetShowMeTheCodeOk()
        {
            ShowMeTheCodeController controller = new ShowMeTheCodeController();

            string juros = controller.Get();
            Assert.Equal("https://github.com/biadreveck/softplan-desafio", juros);
        }
    }
}
