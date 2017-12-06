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
            calculoFreteFactory.ObterCalculoFrete(TipoFrete.Transportadora).Returns(new FreteTransportadora());

            calculadoraFrete = new CalculadoraFrete(calculoFreteFactory);
        }

        [TestCase(TipoFrete.PAC, 50, 7.5, TestName = "Deve calcular frete PAC para distancia MENOR que 100km")]
        [TestCase(TipoFrete.PAC, 150, 37.5, TestName = "Deve calcular frete PAC para distancia MAIOR que 100km")]
        [TestCase(TipoFrete.Sedex, 50, 20, TestName = "Deve calcular frete Sedex para distancia MENOR que 100km")]
        [TestCase(TipoFrete.Sedex, 150, 105, TestName = "Deve calcular frete Sedex para distancia MAIOR que 100km")]
        [TestCase(TipoFrete.Transportadora, 250, 75, TestName = "Deve calcular frete Transportadora para distancia MENOR que 400km")]
        [TestCase(TipoFrete.Transportadora, 427, 149.45, TestName = "Deve calcular frete Transportadora para distancia MAIOR que 400km")]
        [TestCase(TipoFrete.RetiradaNoLocal, 0, 0, TestName = "Deve retornar frete custo zero quando a retirada no local")]
        public void DeveCalcularFreteCorretamente(TipoFrete tipoFrete, int quilometros, decimal valorEsperado)
        {
            var resultado = calculadoraFrete.Calcular(tipoFrete, quilometros);

            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}