namespace Trabajo13
{
    public class colectivo
    {
        public int Numero { get; }

        public conductor? ConductorAsignado { get; set; }

        public colectivo(int numero)
        {
            Numero = numero;
        }

        public void AsignarConductor(conductor conductor)
        {
            ConductorAsignado = conductor;
        }

        public void arranca() 
        {
            // Usamos ?. para acceder de forma segura y ?? para un valor por defecto
            string nombreConductor = ConductorAsignado?.Nombre ?? "Sin conductor asignado";
            
            Console.WriteLine($"El colectivo {Numero} ha arrancado, conducido por: {nombreConductor}");
        }
    }

    public class Conductor2
    {
        public int Legajo { get; set; } 
        public string Nombre { get; set; }

        public Conductor2(int legajo, string nombre)
        {
            Legajo = legajo;
            Nombre = nombre;
        }
    }
}