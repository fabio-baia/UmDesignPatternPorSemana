namespace TestesUnitarios.CalculoFrete
{
    public interface ICalculoFreteFactory
    {
        CalculoFreteBase ObterCalculoFrete(TipoFrete tipo);
    }
}