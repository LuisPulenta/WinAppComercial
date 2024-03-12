using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADSalidaDetalle
    {
        private static SalidaDetalleTableAdapter adaptador = new SalidaDetalleTableAdapter();

        public static void SalidaDetalleInsertSalidaDetalle(
            int IDSalida,
            int IDProducto,
            string Descripcion,
            float Cantidad,
            int IDKardex)
        {
            adaptador.SalidaDetalleInsertSalidaDetalle(IDSalida, IDProducto, Descripcion, Cantidad, IDKardex);
        }
    }
}
