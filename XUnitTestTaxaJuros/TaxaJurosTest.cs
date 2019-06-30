using APITaxaJuros.Controllers;
using Xunit;

namespace XUnitTestTaxaJuros
{
    public class TaxaJurosTest
    {
        [Fact]
        public void GetTaxaJurosOk()
        {
            TaxaJurosController controller = new TaxaJurosController();

            string juros = controller.Get();
            Assert.Equal("0,01", juros);
        }
    }
}
