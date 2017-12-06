namespace TestesUnitarios.CalculoFrete
{
    public class FretePAC : ITipoFrete
    {
        public decimal Calcular(int quilometros)
        {
            if (quilometros < 100)
                return quilometros * 0.15m;

            return quilometros * 0.25m;
        }
    }
}