namespace No_Pa_Entregarla.Models
{
    public class Producto
    {
        // Propiedades con encapsulamiento
        public string Nombre { get; set; }
        public string CodigoDeBarra { get; set; }
        public int Precio { get; set; }
        public int CantidadDisponible { get; set; }
        public bool Estado { get; set; }
    }
}