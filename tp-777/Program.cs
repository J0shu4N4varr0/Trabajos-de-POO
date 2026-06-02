int [] numero = { 10, 9, 6, 4, 5 };
    foreach (int n in numero)
    {
        Console.WriteLine(n);
    }

Console.WriteLine("\n");

int suma = 0;
for (int i = 0; i < numero.Length; i++)
{ 
    suma += numero[i];
}
   
    Console.WriteLine($"Promedio: {suma / (double)numero.Length}");

    Console.WriteLine("\n");

    int maximo = numero.Max();
int minimo = numero.Min();

Console.WriteLine($"Máximo: {maximo}"); 
Console.WriteLine($"Mínimo: {minimo}"); 

Console.WriteLine("\n");

for (int i = numero.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numero[i]);
}

Console.WriteLine("\n");

foreach (int num in numero.Where(n => n > 7))
{
    Console.WriteLine(num);
}

Console.WriteLine("\n");

List<string> tareas = new List<string> ();

tareas.Add("Hacer la compra");
tareas.Add("Limpiar la casa");
tareas.Add("Pagar las facturas");
Console.WriteLine($"Número de tareas: {tareas.Count}");

Console.WriteLine("\n");

tareas.Remove("Limpiar la casa");
Console.WriteLine($"Número de tareas: {tareas.Count}");

Console.WriteLine("\n");

foreach (string tarea in tareas)
{
    Console.WriteLine(tarea);
}

Console.WriteLine("\n");

int[,] tabla = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
Console.WriteLine("Diagonal principal:");
        
        
        for (int i = 0; i < tabla.GetLength(0); i++)
        {
            Console.Write(tabla[i, i] + " ");
        }

Console.WriteLine("\n");

int numeroBuscar = 5; // Cambia este número por el que quieras buscar
        bool existe = false;

        // Recorremos la matriz elemento por elemento
        foreach (int elemento in tabla)
        {
            if (elemento == numeroBuscar)
            {
                existe = true;
                break; // Si lo encuentra, rompe el bucle para ahorrar procesamiento
            }
        }

        // Mostramos el resultado
        if (existe)
        {
            Console.WriteLine($"El número {numeroBuscar} SÍ existe en el array.");
        }
        else
        {
            Console.WriteLine($"El número {numeroBuscar} NO existe en el array.");
        }