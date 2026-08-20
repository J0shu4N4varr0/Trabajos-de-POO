namespace Trabajo13
{
    public class Computadora
    {
        public CPU Cpu { get; }
        public RAM Ram { get; }

        public Computadora(CPU cpu, RAM ram)
        {
            Cpu = cpu;
            Ram = ram;
        }

        public void Iniciar() => Console.WriteLine("La computadora ha iniciado");
    }

    public class CPU
    {
        public string Modelo { get; }
        public int Nucleos { get; }

        public CPU(string modelo, int nucleos)
        {
            Modelo = modelo;
            Nucleos = nucleos;
        }
    }

    public class RAM
    {
        public int Capacidad { get; }

        public RAM(int capacidad)
        {
            Capacidad = capacidad;
        }
    }
}