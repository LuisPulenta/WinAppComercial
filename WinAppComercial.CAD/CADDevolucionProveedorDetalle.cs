using WinAppComercial.CAD.CADDSTableAdapters;
using System;

namespace WinAppComercial.CAD
{
    public class CADDevolucionProveedorDetalle
    {
        private static DevolucionProveedorDetalleTableAdapter adaptador = new DevolucionProveedorDetalleTableAdapter();

        public static void DevolucionProveedorDetalleInsertDevolucionProveedorDetalle(
            int IDDevolucionProveedor,
            int IDProducto,
            string Descripcion,
            decimal Costo,
            float Cantidad,
            int IDKardex,
            float PorcentajeIVA,
            float PorcentajeDescuento)
        {
            adaptador.DevolucionProveedorDetalleInsertDevolucionProveedorDetalle(IDDevolucionProveedor, IDProducto, Descripcion, Costo, Cantidad, IDKardex, PorcentajeIVA, PorcentajeDescuento);
        }

        public static double DevolucionProveedorGetHistoriaDevolucionProveedor(int IDCompra, int IDProducto)
        {
            try
            {
                return (double)adaptador.DevolucionProveedorGetHistoriaDevolucionProveedor(IDCompra, IDProducto);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
