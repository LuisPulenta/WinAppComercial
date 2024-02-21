using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADBodegaProducto
    {
        public int IDBodega { get; set; }
        public int IDProducto { get; set; }
        public float Stock { get; set; }
        public float Minimo { get; set; }
        public float Maximo { get; set; }
        public int DiasReposicion { get; set; }
        public float CantidadMinima { get; set; }

        private static BodegaProductoTableAdapter adaptador = new BodegaProductoTableAdapter();

        public static CADBodegaProducto BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(int IDBodega, int IDProducto)
        {
            CADBodegaProducto miBodegaProducto = null;
            CADDS.BodegaProductoDataTable miTabla = adaptador.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodega, IDProducto);
            if (miTabla.Rows.Count == 0)
            {
                return miBodegaProducto;
            }
            else
            {
                CADDS.BodegaProductoRow miRegistro = (CADDS.BodegaProductoRow)miTabla.Rows[0];
                miBodegaProducto = new CADBodegaProducto();
                miBodegaProducto.CantidadMinima = (float)miRegistro.CantidadMinima;
                miBodegaProducto.DiasReposicion = miRegistro.DiasReposicion;
                miBodegaProducto.IDBodega = miRegistro.IDBodega;
                miBodegaProducto.IDProducto = miRegistro.IDProducto;
                miBodegaProducto.Minimo = (float)miRegistro.Minimo;
                miBodegaProducto.Maximo = (float)miRegistro.Maximo;
                miBodegaProducto.Stock = (float)miRegistro.Stock;

                return miBodegaProducto;
            }
        }

        public static void BodegaProductoUpdate(
           int IDBodega,
           int IDProducto,
           float Minimo,
           float Maximo,
           int DiasReposicion,
           float CantidadMinima)
        {
            try
            {
                adaptador.BodegaProductoInsert(IDBodega, IDProducto, Minimo, Maximo, DiasReposicion, CantidadMinima);
            }
            catch (System.Exception)
            {
                adaptador.BodegaProductoUpdate(Minimo, Maximo, DiasReposicion, CantidadMinima, IDBodega, IDProducto);
            }
        }

        public static void BodegaProductoActualizaStock(float Cantidad, int IDBodega, int IDProducto)
        {
            adaptador.BodegaProductoActualizaStock(Cantidad, IDBodega, IDProducto);
        }

        public static void DeleteBodegaProductoByIDProducto(int IDProducto)
        {
            adaptador.DeleteBodegaProductoByIdProducto(IDProducto);
        }

        public static CADDS.BodegaProductoDataTable GetData()
        {
            return adaptador.GetData();
        }
    }
}
