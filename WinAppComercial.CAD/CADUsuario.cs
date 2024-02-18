using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADUsuario
    {
        private static UsuarioTableAdapter adaptador = new UsuarioTableAdapter();

        public static bool ValidaUsuario(string IDUsuario, string Clave)
        {
            if (adaptador.ValidaUsuario(IDUsuario, Clave) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
