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

        // Constructor por defecto
        public Producto() { }

        // Constructor con parámetros
        public Producto(string nombre, string codigoDeBarra, int precio, int cantidadDisponible, bool estado)
        {
            Nombre = nombre;
            CodigoDeBarra = codigoDeBarra;
            Precio = precio;
            CantidadDisponible = cantidadDisponible;
            Estado = estado;
        }

        // Método para mostrar la información del producto
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Código de Barra: {CodigoDeBarra}, Precio: {Precio}, Cantidad Disponible: {CantidadDisponible}, Estado: {(Estado ? "Activo" : "Inactivo")}";
        }
    }
}