Console.Write("Ingrese su nombre, por favor: ");
string nombre = Console.ReadLine()!;
Console.Write("Ingrese su apellido, por favor: ");
string apellido = Console.ReadLine()!;
Console.WriteLine($"Usted es, {nombre} {apellido}.");

Console.WriteLine("\n");

string oracion = "update laptop please";
string oracionSinEspacios = oracion.Replace(" ", "");
int cantidadLetras = oracionSinEspacios.Length;
Console.WriteLine($"La oración tiene {cantidadLetras} letras (sin contar espacios).");

Console.WriteLine("\n");

string palabra1 = "programacion";
Console.WriteLine(palabra1.ToUpper());
Console.WriteLine(palabra1.ToLower());

Console.WriteLine("\n");

string palabra2 = "paralelepipedo";
int tamañoOriginal = palabra2.Length;
string palabraSinA = palabra2.Replace("a", "");
int tamañoNuevo = palabraSinA.Length;
int cantidadDeA = tamañoOriginal - tamañoNuevo;
Console.WriteLine($"La palabra tiene {cantidadDeA} letra(s) 'a'.");

Console.WriteLine("\n");

string palabra3 = "Sistema operativo";
string palabraConGuiones = palabra3.Replace(" ", "-");
Console.WriteLine($"{palabraConGuiones}.");

Console.WriteLine("\n");

string lista = "manzana,platano,pera,uva";
string[] frutas = lista.Split(',');
Console.WriteLine(frutas[0]);
Console.WriteLine(frutas[1]); 
Console.WriteLine(frutas[2]); 
Console.WriteLine(frutas[3]);

Console.WriteLine("\n");

string frase = "holaMundo";
string frase2 = "Holamundo";
if (frase.Equals(frase2, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Las frases son iguales.");
}
else
{
    Console.WriteLine("Las frases son diferentes.");
}


Console.WriteLine("\n");

string g = "25";
int h = int.Parse(g);
Console.WriteLine(g);

Console.WriteLine("\n");

Console.Write("Ingrese su nombre, por favor: ");
string nombre2 = Console.ReadLine()!;
Console.Write("Ingrese su edad, por favor: ");
string edad = Console.ReadLine()!;
Console.Write("Ingrese su ciudad, por favor: ");
string ciudad = Console.ReadLine()!;
Console.WriteLine($"Usted es, {nombre2} , tiene {edad} años y vive en {ciudad}.");