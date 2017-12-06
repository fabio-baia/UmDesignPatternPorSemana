namespace TestesUnitarios.CalculoFrete
{
    public class CalculadoraFrete : ICalculadoraFrete
    {
        ITipoFrete tipoFrete;

        public CalculadoraFrete(ITipoFrete tipoFrete)
        {
            this.tipoFrete = tipoFrete;
        }

        public decimal Calcular(int quilometros)
        {
            return tipoFrete.Calcular(quilometros);
        }
    }
}