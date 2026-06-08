Console.WriteLine("ingrese nombre:");
string nombre = Console.ReadLine() ?? ""; 
Console.WriteLine("Hola, " + nombre);

Console.WriteLine("\n");

Console.WriteLine("ingrese un numero1:");
string entrada1 = Console.ReadLine() ?? "0"; 
int numero1 = int.Parse(entrada1);

Console.WriteLine("ingrese un numero2:");
string entrada2 = Console.ReadLine() ?? "0";
int numero2 = int.Parse(entrada2);

int suma = Sumar(numero1, numero2); 
Console.WriteLine("La suma es: " + suma);

Console.WriteLine("\n");

if (EsPar(suma))
{
    Console.WriteLine("¡El resultado de la suma es un número PAR!");
}
else
{
    Console.WriteLine("El resultado de la suma es un número IMPAR.");
}


int Sumar(int a, int b)
{
    return a + b;
}

bool EsPar(int numero)
{
    if (numero % 2 == 0) 
    {
        return true;  
    }
    else 
    {
        return false; 
    }
}

Console.WriteLine("\n");

int numeroMasGrande = Mayor(numero1, numero2);
Console.WriteLine("El número más grande que ingresaste es: " + numeroMasGrande);


int Mayor(int a, int b)
{
    if (a > b) return a;
    else return b;
}

Console.WriteLine("\n");

int CalcularFactorial(int n)
{
    
    if (n < 0) 
    {
        Console.WriteLine("¡Error! No existe el factorial de números negativos.");
        return 0; 
    }

    int resultado = 1; 

    for (int i = 1; i <= n; i++)
    {
        resultado = resultado * i; 
    }

    return resultado; 
}

Console.WriteLine("Ingrese un número para calcular su factorial:");
int numeroFactorial = int.Parse(Console.ReadLine() ?? "0");

int resultadoFactorial = CalcularFactorial(numeroFactorial);

Console.WriteLine($"El factorial de {numeroFactorial} es: {resultadoFactorial}");

Console.WriteLine("\n");

int Sumari(int a, int b = 1)
{
    return a + b;
}

int resultado1 = Sumari(5, 4); 
int resultado2 = Sumari(5);

Console.WriteLine($"Sumari(5, 4) = {resultado1}"); 
Console.WriteLine($"Sumari(5) = {resultado2}");

Console.WriteLine("\n");

CalcularTotal(100); 

void CalcularTotal(double precioBase)
{
    double impuesto = precioBase * 0.21; 
    
    double total = precioBase + impuesto;
    Console.WriteLine("El total dentro del método es: " + total);
    
}

Console.WriteLine("\n");

int[] misNumeros = { 5, 12, 8, 23, 42 };

Console.WriteLine();

ImprimirArray(misNumeros); 


void ImprimirArray(int[] arr)
{
   
    foreach (int elemento in arr)
    {
        Console.Write(elemento + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");

int[] losNumeros = { 7, 22, 14, 9, 30, 5, 2 };

int cantidadPares = ContarPares(misNumeros);

Console.WriteLine("En el array hay " + cantidadPares + " números pares.");

int ContarPares(int[] arr)
{
    int contador = 0;
    foreach (int numero in arr)
    {
        if (numero % 2 == 0)
        {
            contador++;
        }
    }
    return contador;
}

Console.WriteLine("\n");


int[] Numeros = GenerarArray();


int cuantosPares = ContarPares2(Numeros);


MostrarResultado(cuantosPares);



//          DEFINICIÓN DE MÉTODOS


// MÉTODO 1
int[] GenerarArray()
{
    int[] numeros = { 7, 22, 14, 9, 30, 5, 2 };
    return numeros; 
}

// MÉTODO 2
int ContarPares2(int[] arr)
{
    int contador = 0;
    foreach (int numero in arr)
    {
        if (numero % 2 == 0)
        {
            contador++;
        }
    }
    return contador;
}

// MÉTODO 3
void MostrarResultado(int total)
{
    Console.WriteLine(" El total de números pares es: " + total);   
}