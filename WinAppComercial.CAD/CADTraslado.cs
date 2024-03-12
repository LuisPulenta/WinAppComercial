using WinAppComercial.CAD.CADDSTableAdapters;
using System;

namespace WinAppComercial.CAD
{
    public class CADTraslado
    {
        private static TrasladoTableAdapter adaptador = new TrasladoTableAdapter();

        public static int TrasladoInsertTraslado(
            DateTime Fecha,
            int IDBodegaOrigen,
            int IDBodegaDestino)
        {
            return (int)adaptador.TrasladoInsertTraslado(Fecha, IDBodegaOrigen, IDBodegaDestino);
        }
    }
}
