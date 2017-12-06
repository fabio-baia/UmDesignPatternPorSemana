namespace TestesUnitarios.CalculoFrete
{
    public class CalculadoraFrete : ICalculadoraFrete
    {
        FreteBase tipoFrete;

        public CalculadoraFrete(FreteBase tipoFrete)
        {
            this.tipoFrete = tipoFrete;
        }

        public decimal Calcular(int quilometros)
        {
            return tipoFrete.Calcular(quilometros);
        }
    }
}