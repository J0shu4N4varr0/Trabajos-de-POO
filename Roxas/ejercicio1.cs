namespace Trabajo13
{
public class Motor
{
    public int Cilindros { get; }
    public Motor(int c) => Cilindros = c;
    public void Arrancar() => Console.WriteLine("El motor ha arrancado");
}

public class Coche
{
    public string Marca { get; }
    public Motor Motor { get; }
    public Coche(string m, int cil)
    {
        Marca = m;
        Motor = new Motor(cil);
    }
    public void Arrancar() => Motor.Arrancar();
}
}