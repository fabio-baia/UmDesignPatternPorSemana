using NSubstitute;
using NUnit.Framework;
using TestesUnitarios.CalculoFrete;

namespace TestesUnitarios.Tests.CalculoFrete
{
    [TestFixture]
    public class CalculadoraFreteTests
    {
        private ICalculoFreteFactory calculoFreteFactory;
        private ICalculadoraFrete calculadoraFrete;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            calculoFreteFactory = Substitute.For<ICalculoFreteFactory>();
            calculoFreteFactory.ObterCalculoFrete(TipoFrete.PAC).Returns(new FretePAC());
            calculoFreteFactory.ObterCalculoFrete(TipoFrete.Sedex).Returns(new FreteSedex());

            calculadoraFrete = new CalculadoraFrete(calculoFreteFactory);
        }

        [Test]
        public void DeveCalcularFreteViaPACParaDistanciaMenorQue100km()
        {
            var resultado = calculadoraFrete.Calcular(TipoFrete.PAC, 50);

            Assert.AreEqual(7.5, resultado);
        }

        [Test]
        public void DeveCalcularFreteViaPACParaDistanciaMaiorQue100km()
        {
            var resultado = calculadoraFrete.Calcular(TipoFrete.PAC, 150);

            Assert.AreEqual(37.5, resultado);
        }

        [Test]
        public void DeveCalcularFreteViaSedexParaDistanciaMenorQue100km()
        {
            var resultado = calculadoraFrete.Calcular(TipoFrete.Sedex, 50);

            Assert.AreEqual(20, resultado);
        }

        [Test]
        public void DeveCalcularFreteViaSedexParaDistanciaMaiorQue100km()
        {
            var resultado = calculadoraFrete.Calcular(TipoFrete.Sedex, 150);

            Assert.AreEqual(105, resultado);
        }
    }
}