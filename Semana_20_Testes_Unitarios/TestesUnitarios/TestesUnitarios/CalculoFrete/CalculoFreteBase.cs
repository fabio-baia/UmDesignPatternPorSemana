namespace TestesUnitarios.CalculoFrete
{
    public abstract class CalculoFreteBase
    {
        public decimal ValorAbaixoLimite { get; protected set; }
        public decimal ValorAcimaLimite { get; protected set; }
        public decimal Limite = 100;

        public decimal Calcular(int quilometros)
        {
            if (quilometros < Limite)
                return quilometros * ValorAbaixoLimite;

            return quilometros * ValorAcimaLimite;
        }
    }
}