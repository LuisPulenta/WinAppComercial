using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADBarra
    {
        private static BarraTableAdapter adaptador = new BarraTableAdapter();

        public static bool ExisteBarra(long Barra)
        {
            if (adaptador.BarraExisteBarra(Barra) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void BarraInsert(
            int IDProducto,
            long Barra)
        {
            adaptador.BarraInsertBarra(IDProducto, Barra);
        }

        public static void BarraDelete(long Barra)
        {
            adaptador.BarraDeleteBarra(Barra);
        }

        public static void DeleteBarraByIDProducto(int IDProducto)
        {
            adaptador.DeleteBarraByIDProducto(IDProducto);
        }
    }
}
