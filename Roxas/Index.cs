namespace Trabajo13
{

static class Program
{
    static void Main()
    {
         Console.WriteLine("\n");
         
        Coche coche = new Coche("Toyota", 4);
        Console.WriteLine($"Marca: {coche.Marca}, Cilindros: {coche.Motor.Cilindros}");
        coche.Arrancar();

        Console.WriteLine("\n");

        Computadora computadora = new Computadora(new CPU("Intel i7", 8), new RAM(16));
        Console.WriteLine($"CPU: {computadora.Cpu.Modelo}, Nucleos: {computadora.Cpu.Nucleos}, RAM: {computadora.Ram.Capacidad}GB");
        computadora.Iniciar();

        Console.WriteLine("\n");

        Colectivo colectivo = new Colectivo(123);
        Conductor conductor = new Conductor(456, "Juan Perez");
        colectivo.AsignarConductor(conductor);
        Console.WriteLine($"Colectivo Numero: {colectivo.Numero}, Conductor: {colectivo.ConductorAsignado?.Nombre}, Legajo: {colectivo.ConductorAsignado?.Legajo}");
        colectivo.arranca();

        Console.WriteLine("\n");

        Console.WriteLine("ejercio 7");

        Equipo equipo = new Equipo("Los Tigres");
        Jugadores jugador1 = new Jugadores("Carlos", 10);
        Jugadores jugador2 = new Jugadores("Luis", 7);
        equipo.AsignarJugadores.Add(jugador1);
        equipo.AsignarJugadores.Add(jugador2);
        jugador1.EquipoAsignado = equipo;
        jugador2.EquipoAsignado = equipo;
        Console.WriteLine($"Equipo: {equipo.Nombre}");
        foreach (var jugador in equipo.AsignarJugadores)
        {
            Console.WriteLine($"Jugador: {jugador.Nombre}, Numero: {jugador.Numero}, Equipo Asignado: {jugador.EquipoAsignado?.Nombre}");
        }

        Console.WriteLine("\n");

        Console.WriteLine("ejercio 8");

        Factura factura = new Factura(1);
        Console.WriteLine($"Factura Numero: {factura.Numero}");
        factura.AgreagarFactura();
    }
}
}