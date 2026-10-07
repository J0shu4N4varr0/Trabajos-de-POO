namespace upsidedown
{
    public class CuentaBancaria
    {
        private decimal _saldo;
        public CuentaBancaria(decimal saldoInicial)
    {
        if (saldoInicial >= 0)
        {
            _saldo = saldoInicial;
        }
    }
    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            _saldo += monto;
            Console.WriteLine($"Depósito exitoso. Saldo actual: ${_saldo}");
        }
    }
    public void Retirar(decimal monto)
    {
        if (monto > _saldo)
        {
            Console.WriteLine($"[Error] Fondos insuficientes. Intentaste retirar ${monto}, pero tu saldo es ${_saldo}.");
        }
        else if (monto <= 0)
        {
            Console.WriteLine("[Error] El monto a retirar debe ser mayor a cero.");
        }
        else
        {
            _saldo -= monto;
            Console.WriteLine($"Retiro exitoso. Saldo actual: ${_saldo}");
        }
    }
    public decimal ObtenerSaldo()
    {
        return _saldo;
    }
    }
}