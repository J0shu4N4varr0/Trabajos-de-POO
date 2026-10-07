namespace upsidedown
{
    public class Temperatura
    {
    private double _celsius;

    public double Celsius
    {
        get { return _celsius; }
        set
        {
            if (value >= -273)
            {
                _celsius = value;
            }
            else
            {
                Console.WriteLine("[Error] La temperatura no puede ser menor al cero absoluto (-273°C).");
            }
        }
    }
}
}