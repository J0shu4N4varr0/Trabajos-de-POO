namespace Trabajo13
{
    public class Colectivo
    {
        public int Numero{ get; }

        public Conductor? ConductorAsignado { get; set;}

        public Colectivo(int numero)
        {
            Numero = numero;
        }

        public void AsignarConductor(Conductor conductor)
        {
            ConductorAsignado = conductor;
        }

        public void arranca() => Console.WriteLine($"El colectivo {Numero} ha arrancado");
    }

    public class Conductor
    {
        public int Legajo { get; set; } 
        public string Nombre { get; set; }

        public Conductor(int legajo, string nombre)
        {
            Legajo = legajo;
            Nombre = nombre;
        }
    }
}