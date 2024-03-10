using WinAppComercial.CAD.CADDSTableAdapters;
using System;

namespace WinAppComercial.CAD
{
    public class CADDevolucionClienteDetalle
    {
        private static DevolucionClienteDetalleTableAdapter adaptador = new DevolucionClienteDetalleTableAdapter();

        public static void DevolucionClienteDetalleInsertDevolucionClienteDetalle(
            int IDDevolucionCliente,
            int IDProducto,
            string Descripcion,
            decimal Precio,
            float Cantidad,
            int IDKardex,
            float PorcentajeIVA,
            float PorcentajeDescuento)
        {
            adaptador.DevolucionClienteDetalleInsertDevolucionClienteDetalle(IDDevolucionCliente, IDProducto, Descripcion, Precio, Cantidad, IDKardex, PorcentajeIVA, PorcentajeDescuento);
        }

        public static double DevolucionClienteGetHistoriaDevolucionCliente(int IDVenta, int IDProducto)
        {
            try
            {
                return (double)adaptador.DevolucionClienteGetHistoriaDevolucionCliente(IDVenta, IDProducto);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}