namespace messi
{
    public class Auto
    {
        public string ?Marca { get; set; }
        public string ?Modelo { get; set; }
        public int Año { get; set; }

        public void Descripcion()
        {
            Console.WriteLine($"El auto {Modelo} de la {Marca}, fué creado en el año {Año}.");
        }
        
    }
}