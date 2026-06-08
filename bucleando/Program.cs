for (int i = 0; i <= 20; i++)

    Console.Write(i + "\n");

   Console.WriteLine("\n");


for (int a = 0; a <= 20; a += 2)

    Console.Write(a + "\n");

    Console.WriteLine("\n");


    int suma = 0;
    for (int b = 0; b <= 100; b ++)
{
    suma += b;
}

    Console.WriteLine("Total: " + suma);

    Console.WriteLine("\n");


    int contador =10;
    while (contador >= 0)
    {
        Console.WriteLine(contador);
        contador--;
    }

    Console.WriteLine("\n");

 int opcion;

do
{
    Console.Write("Ingrese un número: ");
    opcion = int.Parse(Console.ReadLine());

    // Si el número es menor o igual a cero, avisamos al usuario antes de repetir
    if (opcion <= 0)
    {
        Console.WriteLine("Debe ser un número positivo. Intente nuevamente.");
        Console.WriteLine(); // Una línea en blanco para ordenar la consola
    }

} while (opcion <= 0);

// Al salir del bucle, ya estamos seguros de que el número es positivo
Console.WriteLine("¡Gracias! Ingresaste el número: " + opcion);

Console.WriteLine("\n");

for (int i = 0; i <= 50; i+=5)

    Console.Write(i + "\n");

    Console.WriteLine("\n");

    string[] letra = { "J", "M", "P", "A", "L" };
    foreach (string l in letra)
    {
        Console.WriteLine(l);
    }

    Console.WriteLine("\n");

for (int z = 0; z <= 20; z++)
{
    if (z == 13) break;
    if (z % 2 == 0) continue;
    Console.WriteLine(z);
}

Console.WriteLine("\n");

for (int x = 0; x <= 20; x++)
{
    if (x % 3 == 0) continue;
    Console.WriteLine(x);
}

Console.WriteLine("\n");

for (int fila = 1; fila <= 5; fila++)
{
    for (int columna = 1; columna <= 5; columna++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

                                //GRACIAS POR VER