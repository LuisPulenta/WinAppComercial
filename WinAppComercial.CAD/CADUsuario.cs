using System;
using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADUsuario
    {
        public string IDUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Clave { get; set; }
        public DateTime FechaModificacionClave { get; set; }
        public int IDRol { get; set; }
        public string Correo { get; set; }

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

        public static bool ExisteUsuario(string IDUsuario)
        {
            if (adaptador.UsuarioExisteUsuario(IDUsuario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static CADUsuario UsuarioGetUsuarioByIDUsuario(string IDUsuario)
        {
            CADUsuario miUsuario = null;
            CADDS.UsuarioDataTable miTabla = adaptador.UsuarioGetUsuarioByIDUsuario(IDUsuario);
            if (miTabla.Rows.Count == 0)
            {
                return miUsuario;
            }
            else
            {
                CADDS.UsuarioRow miRegistro = (CADDS.UsuarioRow)miTabla.Rows[0];
                miUsuario = new CADUsuario();
                miUsuario.Apellidos = miRegistro.Apellidos;
                miUsuario.Clave = miRegistro.Clave;
                miUsuario.Correo = miRegistro.Correo;
                miUsuario.FechaModificacionClave = miRegistro.FechaModificacionClave;
                miUsuario.IDRol = miRegistro.IDRol;
                miUsuario.IDUsuario = miRegistro.IDUsuario;
                miUsuario.Nombres = miRegistro.Nombres;

                return miUsuario;
            }
        }

        public static void UsuarioUpdateClave(
            string Clave,
            string IDUsuario
            )
        {
            adaptador.UsuarioUpdateClave(Clave, DateTime.Now, IDUsuario);
        }
    }
}
