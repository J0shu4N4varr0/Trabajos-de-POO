//estos los hare en uno solo por que no sé si el de edad pertence a banco

namespace upsidedown
{
    public class Person
{
    private string ?_nombre;
    private int _edad;

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

   
    public int Edad
    {
        get { return _edad; }
        set
        {
            if (value >= 0 && value <= 150)
            {
                _edad = value;
            }
            else
            {
                Console.WriteLine("[Error] La edad debe estar entre 0 y 150 años.");
            }
        }
    }
}
}