﻿using NSubstitute;
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

        [TestCase(TipoFrete.PAC, 50, 7.5, TestName = "Deve calcular frete PAC para distancia MENOR que 100km")]
        [TestCase(TipoFrete.PAC, 150, 37.5, TestName = "Deve calcular frete PAC para distancia MAIOR que 100km ")]
        [TestCase(TipoFrete.Sedex, 50, 20, TestName = "Deve calcular frete Sedex para distancia MENOR que 100km ")]
        [TestCase(TipoFrete.Sedex, 150, 105, TestName = "Deve calcular frete Sedex para distancia MAIOR que 100km ")]
        public void DeveCalcularFreteCorretamente(TipoFrete tipoFrete, int quilometros, decimal valorEsperado)
        {
            var resultado = calculadoraFrete.Calcular(tipoFrete, quilometros);

            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}