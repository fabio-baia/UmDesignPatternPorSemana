using System;
using System.Collections.Generic;

namespace TestesUnitarios.CalculoFrete
{
    public class CalculoFreteFactory : ICalculoFreteFactory
    {
        private IDictionary<TipoFrete, CalculoFreteBase> calculosFrete;

        public CalculoFreteFactory()
        {
            this.calculosFrete = new Dictionary<TipoFrete, CalculoFreteBase>
            {
                { TipoFrete.PAC, new FretePAC() },
                { TipoFrete.Sedex, new FreteSedex() },
                { TipoFrete.Transportadora, new FreteTransportadora() },
                { TipoFrete.RetiradaNoLocal, new FreteRetiradaNoLocal() },
            };
        }

        public CalculoFreteBase ObterCalculoFrete(TipoFrete tipo)
        {
            if (calculosFrete.ContainsKey(tipo))
                return calculosFrete[tipo];

            throw new ArgumentOutOfRangeException("Tipo de frete não implementado");
        }
    }
}