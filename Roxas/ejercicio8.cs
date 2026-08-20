namespace Trabajo13
{
    public class Lista_de_Facturas
    {
        public string Producto {get; set;}
        public decimal Precio {get; set;}

        public Lista_de_Facturas(string producto, decimal precio)
        {
            Producto = producto;
            Precio = precio;
        }
    }

    public class Factura
    {
        public int Numero {get; set;}
        private List<Lista_de_Facturas> listaDeFacturas;

        public Factura(int numero)
        {
            Numero = numero;

            listaDeFacturas = new List<Lista_de_Facturas>();
        }

        public void AgreagarFactura()
        {
            Console.WriteLine($"Factura Numero: {Numero}");
            foreach (var factura in listaDeFacturas)
            {
                Console.WriteLine($"Producto: {factura.Producto}, Precio: {factura.Precio}");
            }
        }
    }
}