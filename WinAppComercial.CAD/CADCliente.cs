using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADCliente
    {
        private static ClienteTableAdapter adaptador = new ClienteTableAdapter();

        public static CADDS.ClienteDataTable GetData()
        {
            return adaptador.GetData();
        }
    }
}