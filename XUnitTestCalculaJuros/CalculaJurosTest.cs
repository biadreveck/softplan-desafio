using CalculaJuros.Controllers;
using Xunit;

namespace XUnitTestCalculaJuros
{
    public class CalculaJurosTest
    {
        [Fact]
        public void GetCalculaJurosOk()
        {
            CalculaJurosController controller = new CalculaJurosController();

            string resultado = controller.Get(100, 5);
            Assert.Equal("105,10", resultado);
        }
    }
}
