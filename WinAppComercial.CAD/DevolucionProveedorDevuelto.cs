namespace WinAppComercial.CAD
{
    public class DevolucionProveedorDevuelto
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public float CantidadADevolver { get; set; }
        public float PorcentajeIVA { get; set; }
        public float PorcentajeDescuento { get; set; }
    }
}
