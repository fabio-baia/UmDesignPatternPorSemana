namespace TestesUnitarios.CalculoFrete
{
    public class FreteSedex : CalculoFreteBase
    {
        public FreteSedex()
        {
            ValorAbaixoLimite = 0.40m;
            ValorAcimaLimite = 0.70m;
        }
    }
}