using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADCompraDetalle
    {
        private static CompraDetalleTableAdapter adaptador = new CompraDetalleTableAdapter();

        public static void CompraDetalleInsertCompraDetalle(
            int IDCompra,
            int IDProducto,
            string Descripcion,
            decimal Costo,
            float Cantidad,
            int IDKardex,
            float PorcentajeIVA,
            float PorcentajeDescuento)
        {
            adaptador.CompraDetalleInsertCompraDetalle(IDCompra, IDProducto, Descripcion, Costo, Cantidad, IDKardex, PorcentajeIVA, PorcentajeDescuento);
        }

        public static CADDS.CompraDetalleDataTable CompraDetalleGetCompraDetalleByIDCompra(int IDCompra)
        {
            return adaptador.CompraDetalleGetCompraDetalleByIDCompra(IDCompra);
        }
    }
}
