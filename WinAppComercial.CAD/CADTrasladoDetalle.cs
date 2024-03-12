using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADTrasladoDetalle
    {
        private static TrasladoDetalleTableAdapter adaptador = new TrasladoDetalleTableAdapter();

        public static void TrasladoDetalleInsertTrasladoDetalle(
            int IDTraslado,
            int IDProducto,
            string Descripcion,
            float Cantidad,
            int IDKardexOrigen,
            int IDKardexDestino)
        {
            adaptador.TrasladoDetalleInsertTrasladoDetalle(IDTraslado, IDProducto, Descripcion, Cantidad, IDKardexOrigen, IDKardexDestino);
        }
    }
}
