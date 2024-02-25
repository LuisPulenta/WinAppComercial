namespace WinAppComercial.CAD
{
    public class DetalleCompra
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public float Cantidad { get; set; }
        public float PorcentajeIVA { get; set; }
        public float PorcentajeDescuento { get; set; }

        public decimal valorBruto { get { return Costo * (decimal)Cantidad / (1 + (decimal)PorcentajeIVA); } }
        public decimal valorIVA { get { return Costo * (decimal)Cantidad - valorBruto; } }
        public decimal valorDescuento { get { return valorBruto * (decimal)PorcentajeDescuento; } }
        public decimal valorNeto { get { return Costo * (decimal)Cantidad - valorDescuento; } }
    }

}
