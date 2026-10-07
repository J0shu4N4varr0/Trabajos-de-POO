namespace upsidedown
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("\n");

            CuentaBancaria miCuenta = new CuentaBancaria(1000);

            Console.WriteLine($"Saldo inicial: ${miCuenta.ObtenerSaldo()}");

            Console.WriteLine("\n--- PROBANDO DEPÓSITO ---");
            miCuenta.Depositar(500);

            Console.WriteLine("\n--- PROBANDO RETIRO VÁLIDO ---");
            miCuenta.Retirar(200);

            Console.WriteLine("\n--- PROBANDO RETIRO INVÁLIDO (MÁS DE LO QUE HAY) ---");
            miCuenta.Retirar(3000);

            Console.WriteLine("\n");

            Temperatura temp = new Temperatura();
            temp.Celsius = -280;
            Console.WriteLine($"Temperatura: {temp.Celsius}°C");

            Console.WriteLine("\n");

            Transaccion transaccion = new Transaccion("123456789");
            Console.WriteLine($"ID de cuenta: {transaccion.IdCuenta}");
            Console.WriteLine($"IVA: {Transaccion.IVA}");

            Console.WriteLine("\n");

            Usuario usuario = new Usuario();
            Console.WriteLine("Ingrese su contraseña:");
            string? passwordInput = Console.ReadLine();
            usuario.Password = passwordInput!;
            Console.WriteLine("Contraseña establecida correctamente.");

            Console.WriteLine("\n");

            Rectangulo rectangulo = new Rectangulo();
            Console.WriteLine($"Inserte el alto:");
            rectangulo.Alto = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Inserte el ancho:");
            rectangulo.Ancho = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Perímetro del rectángulo es: {rectangulo.Perimetro}");

            Console.WriteLine("\n");

            Person person = new Person();
            Console.WriteLine("Ingrese su nombre:");
            person.Nombre = Console.ReadLine()!;
            Console.WriteLine($"Nombre: {person.Nombre}");
            Console.WriteLine("Ingrese su edad:");
            person.Edad = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Edad: {person.Edad}");
        }
    }
}
