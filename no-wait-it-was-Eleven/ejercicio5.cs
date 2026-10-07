namespace upsidedown
{
        public class Rectangulo
        {
            public double Ancho { get; set; }
            public double Alto { get; set; }

            // Propiedad calculada
            public double Perimetro => 2 * (Ancho + Alto);
        }
}