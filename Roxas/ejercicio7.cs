namespace Trabajo13
{
    public class Equipo
    {
        public string Nombre { get; set; }

        public List<Jugadores> AsignarJugadores { get; set; }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            AsignarJugadores = new List<Jugadores>();
        }
        public void participar()
        {
            Console.WriteLine($"El equipo {Nombre} está participando en el torneo.");
        }
    }

    public class Jugadores
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public Equipo? EquipoAsignado { get; set; }

        public Jugadores(string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}