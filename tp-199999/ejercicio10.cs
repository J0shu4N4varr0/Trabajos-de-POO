using System;
using System.Linq; // Necesario para usar el truco de voltear el texto

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce una palabra para verificar si es palíndromo:");
        string entrada = Console.ReadLine();

        // 1. Limpiamos el texto: todo a minúsculas y sin espacios (por si escriben una frase)
        string palabraOriginal = entrada.ToLower().Replace(" ", "");

        // 2. Volteamos la palabra
        // Convertimos a arreglo de caracteres, lo invertimos y creamos un nuevo string
        char[] caracteres = palabraOriginal.ToCharArray();
        Array.Reverse(caracteres);
        string palabraAlReves = new string(caracteres);

        // 3. Comparamos e imprimimos el resultado
        if (palabraOriginal == palabraAlReves)
        {
            Console.WriteLine($"¡Sí! '{entrada}' es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"No, '{entrada}' no es un palíndromo.");
        }
    }
}