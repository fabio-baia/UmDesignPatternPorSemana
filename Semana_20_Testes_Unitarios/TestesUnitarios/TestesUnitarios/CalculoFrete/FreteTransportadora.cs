namespace TestesUnitarios.CalculoFrete
{
    public class FreteTransportadora : CalculoFreteBase
    {
        public FreteTransportadora()
        {
            ValorAbaixoLimite = 0.30m;
            ValorAcimaLimite = 0.35m;
            Limite = 400;
        }
    }
}