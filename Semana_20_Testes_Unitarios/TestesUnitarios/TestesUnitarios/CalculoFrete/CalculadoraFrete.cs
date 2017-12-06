namespace TestesUnitarios.CalculoFrete
{
    public class CalculadoraFrete : ICalculadoraFrete
    {
        private ICalculoFreteFactory calculoFreteFactory;

        public CalculadoraFrete(ICalculoFreteFactory calculoFreteFactory)
        {
            this.calculoFreteFactory = calculoFreteFactory;
        }

        public decimal Calcular(TipoFrete tipoFrete, int quilometros)
        {
            return this.calculoFreteFactory.ObterCalculoFrete(tipoFrete).Calcular(quilometros);
        }
    }
}