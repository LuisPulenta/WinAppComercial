using System;
using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADCompra
    {
        public int IDCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int IDProveedor { get; set; }
        public int IDBodega { get; set; }

        private static CompraTableAdapter adaptador = new CompraTableAdapter();

        public static int CompraInsertCompra(
            DateTime Fecha,
            int IDProveedor,
            int IDBodega)
        {
            return (int)adaptador.CompraInsertCompra(Fecha, IDProveedor, IDBodega);
        }

        public static bool ProveedorTieneCompras(int IDProveedor)
        {
            if (adaptador.ProveedorTieneCompras(IDProveedor) == null)
            {
                return false;
            }
            return true;
        }

        public static CADCompra ComprasGetCompraByIDCompra(int IDCompra)
        {
            CADCompra miCompra = null;
            CADDS.CompraDataTable miTabla = adaptador.ComprasGetCompraByIDCompra(IDCompra);
            if (miTabla.Rows.Count == 0)
            {
                return miCompra;
            }
            else
            {
                CADDS.CompraRow miRegistro = (CADDS.CompraRow)miTabla.Rows[0];
                miCompra = new CADCompra();
                miCompra.Fecha = miRegistro.Fecha;
                miCompra.IDProveedor = miRegistro.IDProveedor;
                miCompra.IDBodega = miRegistro.IDBodega;
                miCompra.IDCompra = miRegistro.IDCompra;
                return miCompra;
            }
        }
    }
}
