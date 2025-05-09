namespace No_Pa_Entregarla.Models
{
    public class ProductoPerecible : Producto
    {
        DateTime Fecha_Vencimiento;
        int Dias_para_Vencer;

        public ProductoPerecible(DateTime fecha_Vencimiento, int dias_para_Vencer)
        {
            Fecha_Vencimiento = fecha_Vencimiento;
        }
    }
}
