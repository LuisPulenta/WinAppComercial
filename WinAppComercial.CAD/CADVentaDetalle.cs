using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{    public class CADVentaDetalle
    {
        private static VentaDetalleTableAdapter adaptador = new VentaDetalleTableAdapter();

        public static void VentaDetalleInsertVentaDetalle(
            int IDVenta,
            int IDProducto,
            string Descripcion,
            decimal Costo,
            float Cantidad,
            int IDKardex,
            float PorcentajeIVA,
            float PorcentajeDescuento)
        {
            adaptador.VentaDetalleInsertVentaDetalle(IDVenta, IDProducto, Descripcion, Costo, Cantidad, IDKardex, PorcentajeIVA, PorcentajeDescuento);
        }

        public static CADDS.VentaDetalleDataTable VentaDetalleGetVentaDetalleByIDVenta(int IDVenta)
        {
            return adaptador.VentaDetalleGetVentaDetalleByIDVenta(IDVenta);
        }
    }
}
