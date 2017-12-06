namespace TestesUnitarios.CalculoFrete
{
    public class FreteSedex : ITipoFrete
    {
        public decimal Calcular(int quilometros)
        {
            if (quilometros < 100)
                return quilometros * 0.40m;

            return quilometros * 0.70m;
        }
    }
}