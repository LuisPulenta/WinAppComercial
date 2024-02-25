using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADPermisoRol
    {
        private static PermisoRolTableAdapter adaptador = new PermisoRolTableAdapter();

        public static bool PermisoRolPuedeVer(int IDRol, string Formulario)
        {
            if (adaptador.PermisoRolPuedeVer(IDRol, Formulario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool PermisoRolPuedeModificar(int IDRol, string Formulario)
        {
            if (adaptador.PermisoRolPuedeModificar(IDRol, Formulario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool PermisoRolPuedeBorrar(int IDRol, string Formulario)
        {
            if (adaptador.PermisoRolPuedeBorrar(IDRol, Formulario) == null)
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
