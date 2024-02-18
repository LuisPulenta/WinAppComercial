using System;
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

        public static void ClienteInsert(
    int IDTipoDocumento,
    string Documento,
    string NombreComercial,
    string NombresContacto,
    string ApellidosContacto,
    string Direccion,
    string Telefono1,
    string Telefono2,
    string Correo,
    string Notas,
    DateTime Aniversario)
        {
            adaptador.ClienteInsert(IDTipoDocumento, Documento, NombreComercial, NombresContacto, ApellidosContacto, Direccion, Telefono1, Telefono2, Correo, Notas, Aniversario);
        }

        public static void ClienteUpdate(
            int IDTipoDocumento,
            string Documento,
            string NombreComercial,
            string NombresContacto,
            string ApellidosContacto,
            string Direccion,
            string Telefono1,
            string Telefono2,
            string Correo,
            string Notas,
            DateTime Aniversario,
            int IDCliente)
        {
            adaptador.ClienteUpdate(IDTipoDocumento, Documento, NombreComercial, NombresContacto, ApellidosContacto, Direccion, Telefono1, Telefono2, Correo, Notas, Aniversario, IDCliente);
        }

        public static void ClienteDelete(int IDCliente)
        {
            adaptador.ClienteDelete(IDCliente);
        }

    }
}