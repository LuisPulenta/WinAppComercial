namespace WinAppComercial.CAD
{
    public class DevolucionClienteDevuelto
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public float CantidadADevolver { get; set; }
        public float PorcentajeIVA { get; set; }
        public float PorcentajeDescuento { get; set; }
    }
}
