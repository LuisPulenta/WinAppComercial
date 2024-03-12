namespace WinAppComercial.CAD
{
    public class DetalleTraslado
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public float Cantidad { get; set; }
        public float PorcentajeIVA { get; set; }
        public decimal valorBruto { get { return Precio * (decimal)Cantidad / (1 + (decimal)PorcentajeIVA); } }
        public decimal valorIVA { get { return Precio * (decimal)Cantidad - valorBruto; } }
        public decimal valorNeto { get { return Precio * (decimal)Cantidad; } }
    }
}
