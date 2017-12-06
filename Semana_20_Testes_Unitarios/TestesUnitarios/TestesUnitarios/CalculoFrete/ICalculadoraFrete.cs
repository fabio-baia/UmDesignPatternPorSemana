namespace TestesUnitarios.CalculoFrete
{
    public interface ICalculadoraFrete
    {
        decimal Calcular(TipoFrete tipoFrete, int quilometros);
    }
}