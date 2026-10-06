namespace messi
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("\n");

            var persona1 = new Persona();
            persona1.Nombre = "Messi";
            persona1.Edad = 35;
            persona1.Fecha_de_Nacimiento = 1987;
            persona1.Presentarse();

            Console.WriteLine("\n");

            var persona2 = new Persona();
            persona2.Nombre = "Martincito";
            persona2.Edad = 16;
            persona2.Fecha_de_Nacimiento = 2007;
            persona2.Presentarse();

            var persona3 = new Persona();
            persona3.Nombre = "Juan";
            persona3.Edad = 25;
            persona3.Fecha_de_Nacimiento = 1998;
            persona3.Presentarse();

            Console.WriteLine("\n");

            var rectangulo = new Regtangulo();
            rectangulo.Base = 5.8;
            rectangulo.Altura = 3.7;
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine("\n");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro()}");

            Console.WriteLine("\n");
            var auto = new Auto();
            Auto auto1 = new Auto { Marca = "Toyota", Modelo = "Corolla", Año = 2020 };
            Auto auto2 = new Auto { Marca = "Ford", Modelo = "Fiesta", Año = 2018 };
            Auto auto3 = new Auto { Marca = "Chevrolet", Modelo = "Cruze", Año = 2022 };

            Console.WriteLine($"Auto 1: {auto1.Marca} - {auto1.Modelo} - {auto1.Año}");
            Console.WriteLine($"Auto 2: {auto2.Marca} - {auto2.Modelo} - {auto2.Año}");
            Console.WriteLine($"Auto 3: {auto3.Marca} - {auto3.Modelo} - {auto3.Año}");

            auto1.Modelo = "Hilux";
            auto1.Año = 2024;

            Console.WriteLine($"Auto 1: {auto1.Marca} - {auto1.Modelo} - {auto1.Año}");
            Console.WriteLine($"Auto 2: {auto2.Marca} - {auto2.Modelo} - {auto2.Año}"); 
            Console.WriteLine($"Auto 3: {auto3.Marca} - {auto3.Modelo} - {auto3.Año}"); 

            auto1.Descripcion();

            Console.WriteLine("\n");

            Console.WriteLine("Ejercicio 4");

            Console.WriteLine("\n");

            
            Persona[] personas = new Persona[]
            {
                new Persona { Nombre = "Messi", Edad = 25, Fecha_de_Nacimiento = 1998 },
                new Persona { Nombre = "Carlos", Edad = 30, Fecha_de_Nacimiento = 1993 },
                new Persona { Nombre = "Lucía", Edad = 22, Fecha_de_Nacimiento = 2001 }
            };

            Console.WriteLine("--- LISTA DE PERSONAS ---");
            foreach (Persona p in personas)
            {
                 Console.WriteLine($"Nombre: {p.Nombre}, Edad: {p.Edad}, Fecha de Nacimiento: {p.Fecha_de_Nacimiento}");
            }
        }
    }
}