using WinAppComercial.CAD.CADDSTableAdapters;
using System;

namespace WinAppComercial.CAD
{
    public class CADDevolucionProveedor
    {
        private static DevolucionProveedorTableAdapter adaptador = new DevolucionProveedorTableAdapter();

        public static int DevolucionProveedorInsertDevolucionProveedor(
            DateTime Fecha,
            int IDCompra)
        {
            return (int)adaptador.DevolucionProveedorInsertDevolucionProveedor(Fecha, IDCompra);
        }
    }
}
