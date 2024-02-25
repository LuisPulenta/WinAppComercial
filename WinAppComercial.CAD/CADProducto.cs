using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADProducto
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public int IDDepartamento { get; set; }
        public int IDIVA { get; set; }
        public decimal Precio { get; set; }
        public string Notas { get; set; }
        public string Imagen { get; set; }
        public string IDMedida { get; set; }
        public float Medida { get; set; }

        private static ProductoTableAdapter adaptador = new ProductoTableAdapter();

        public static CADProducto ProductoGetProductoByIDProducto(int IDProducto)
        {
            CADProducto miProducto = null;
            CADDS.ProductoDataTable miTabla = adaptador.ProductoGetProductoByIDProducto(IDProducto);
            if (miTabla.Rows.Count == 0)
            {
                return miProducto;
            }
            else
            {
                CADDS.ProductoRow miRegistro = (CADDS.ProductoRow)miTabla.Rows[0];
                miProducto = new CADProducto();
                miProducto.Descripcion = miRegistro.Descripcion;
                miProducto.IDDepartamento = miRegistro.IDDepartamento;
                miProducto.IDIVA = miRegistro.IDIVA;
                miProducto.IDMedida = miRegistro.IDMedida;
                miProducto.IDProducto = miRegistro.IDProducto;
                miProducto.Imagen = miRegistro.Imagen;
                miProducto.Medida = (float)miRegistro.Medida;
                miProducto.Notas = miRegistro.Notas;
                miProducto.Precio = miRegistro.Precio;
                return miProducto;
            }
        }

        public static CADProducto ProductoGetProductoByIDBarra(long IDBarra)
        {
            CADProducto miProducto = null;
            CADDS.ProductoDataTable miTabla = adaptador.ProductoGetProductoByIDBarra(IDBarra);
            if (miTabla.Rows.Count == 0)
            {
                return miProducto;
            }
            else
            {
                CADDS.ProductoRow miRegistro = (CADDS.ProductoRow)miTabla.Rows[0];
                miProducto = new CADProducto();
                miProducto.Descripcion = miRegistro.Descripcion;
                miProducto.IDDepartamento = miRegistro.IDDepartamento;
                miProducto.IDIVA = miRegistro.IDIVA;
                miProducto.IDMedida = miRegistro.IDMedida;
                miProducto.IDProducto = miRegistro.IDProducto;
                miProducto.Imagen = miRegistro.Imagen;
                miProducto.Medida = (float)miRegistro.Medida;
                miProducto.Notas = miRegistro.Notas;
                miProducto.Precio = miRegistro.Precio;
                return miProducto;
            }
        }
    }
}
