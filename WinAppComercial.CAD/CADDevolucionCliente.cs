using System;
using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADDevolucionCliente
    {
        private static DevolucionClienteTableAdapter adaptador = new DevolucionClienteTableAdapter();

        public static int DevolucionClienteInsertDevolucionCliente(
            DateTime Fecha,
            int IDVenta)
        {
            return (int)adaptador.DevolucionClienteInsertDevolucionCliente(Fecha, IDVenta);
        }
    }
}
