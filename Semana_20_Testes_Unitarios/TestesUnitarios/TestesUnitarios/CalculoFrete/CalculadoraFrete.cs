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

    public class FretePAC : ITipoFrete
    {
        public decimal Calcular(int quilometros)
        {
            if (quilometros < 100)
                return quilometros * 0.15m;

            return quilometros * 0.25m;
        }
    }

    public interface ICalculadoraFrete
    {
        decimal Calcular(int quilometros);
    }

    public interface ITipoFrete
    {
        decimal Calcular(int quilometros);
    }
}