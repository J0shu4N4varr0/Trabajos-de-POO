namespace upsidedown
{
    public class Transaccion
{

    public const decimal IVA = 0.21m;

    public readonly string IdCuenta;

    public Transaccion(string idCuenta)
    {
        IdCuenta = idCuenta;
    }
}
}