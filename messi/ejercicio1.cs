namespace messi
{
    public class Persona
    {
        public string ?Nombre{get; set;} 
        public int Edad{get; set;}

        public int Fecha_de_Nacimiento {get; set;}

        public void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre}, tengo {Edad} años y nací en {Fecha_de_Nacimiento}.");
        }
        
        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }

    }

}