using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADProductosAInventariar
    {
        private static ProductosAInventariarTableAdapter adaptador = new ProductosAInventariarTableAdapter();

        public static CADDS.ProductosAInventariarDataTable ProductosAInventariarByIDBodega(int IDBodega)
        {
            return adaptador.ProductosAInventariarByIDBodega(IDBodega);
        }

        public static CADDS.ProductosAInventariarDataTable ProductosAInventariarByIDBodegaAndIDDepartamento(int IDBodega, int IDDepartamento)
        {
            return adaptador.ProductosAInventariarByIDBodegaAndIDDepartamento(IDBodega, IDDepartamento);
        }
    }
}
