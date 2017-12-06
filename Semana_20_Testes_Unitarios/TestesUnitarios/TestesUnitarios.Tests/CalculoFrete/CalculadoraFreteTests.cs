using NUnit.Framework;
using TestesUnitarios.CalculoFrete;

namespace TestesUnitarios.Tests.CalculoFrete
{
    [TestFixture]
    public class CalculadoraFreteTests
    {
        [Test]
        public void DeveCalcularFreteViaPACParaDistanciaMenorQue100km()
        {
            var calculadoraFrete = new CalculadoraFrete(new FretePAC());

            var resultado = calculadoraFrete.Calcular(50);

            Assert.AreEqual(7.5, resultado);
        }

        [Test]
        public void DeveCalcularFreteViaPACParaDistanciaMaiorQue100km()
        {
            var calculadoraFrete = new CalculadoraFrete(new FretePAC());

            var resultado = calculadoraFrete.Calcular(150);

            Assert.AreEqual(37.5, resultado);
        }
    }
}
