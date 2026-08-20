namespace Trabajo13
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            
            Conductor2 c1 = new Conductor2(101, "Carlos Gómez");
            Conductor2 c2 = new Conductor2(102, "Ana Pérez");

           
            Colectivo colectivoA = new Colectivo(42);
            Colectivo colectivoB = new Colectivo(15);

            
            colectivoA.AsignarConductor(c1);
            colectivoB.AsignarConductor(c2);

            Console.WriteLine($"Estado inicial:");
            Console.WriteLine($"Colectivo {colectivoA.Numero} tiene al conductor: {colectivoA.ConductorAsignado?.Nombre}");
            Console.WriteLine($"Colectivo {colectivoB.Numero} tiene al conductor: {colectivoB.ConductorAsignado?.Nombre}");

            Console.WriteLine("\n--- Reasignando a Carlos Gómez del Colectivo 42 al Colectivo 15 ---\n");

            
            Conductor conductorAExtraido = colectivoA.ConductorAsignado;
            colectivoA.AsignarConductor(null); 

           
            if (conductorAExtraido != null)
            {
                colectivoB.AsignarConductor(conductorAExtraido);
            }

            
            Console.WriteLine($"Estado final:");
            string conductorA_nombre = colectivoA.ConductorAsignado?.Nombre ?? "Sin conductor";
            string conductorB_nombre = colectivoB.ConductorAsignado?.Nombre ?? "Sin conductor";

            Console.WriteLine($"Colectivo {colectivoA.Numero} tiene al conductor: {conductorA_nombre}");
            Console.WriteLine($"Colectivo {colectivoB.Numero} tiene al conductor: {conductorB_nombre}");
        }
    }}
