using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppComercial.CAD.CADDSTableAdapters;

namespace WinAppComercial.CAD
{
    public class CADKardex
    {
        public int IDKardex { get; set; }
        public int IDBodega { get; set; }
        public int IDProducto { get; set; }
        public DateTime Fecha { get; set; }
        public string Documento { get; set; }
        public float Entrada { get; set; }
        public float Salida { get; set; }
        public float Saldo { get; set; }
        public decimal UltimoCosto { get; set; }
        public decimal CostoPromedio { get; set; }

        private static KardexTableAdapter adaptador = new KardexTableAdapter();

        public static CADKardex KardexUltimoKardex(int IDBodega, int IDProducto)
        {
            CADKardex miKardex = null;
            CADDS.KardexDataTable miTabla = adaptador.KardexUltimoKardex(IDBodega, IDProducto);
            if (miTabla.Rows.Count == 0)
            {
                return miKardex;
            }
            else
            {
                CADDS.KardexRow miRegistro = (CADDS.KardexRow)miTabla.Rows[0];
                miKardex = new CADKardex();
                miKardex.IDKardex = miRegistro.IDKardex;
                miKardex.IDBodega = miRegistro.IDBodega;
                miKardex.IDProducto = miRegistro.IDProducto;
                miKardex.Fecha = miRegistro.Fecha;
                miKardex.Documento = miRegistro.Documento;
                miKardex.Entrada = (float)miRegistro.Entrada;
                miKardex.Salida = (float)miRegistro.Salida;
                miKardex.Saldo = (float)miRegistro.Saldo;
                miKardex.UltimoCosto = miRegistro.UltimoCosto;
                miKardex.CostoPromedio = miRegistro.CostoPromedio;
                return miKardex;
            }
        }

        public static int KardexInsertKardex(
           int IDBodega,
           int IDProducto,
           DateTime Fecha,
           string Documento,
           float Entrada,
           float Salida,
           float Saldo,
           decimal UltimoCosto,
           decimal CostoPromedio)
        {
            return (int)adaptador.KardexInsertKardex(IDBodega, IDProducto, Fecha, Documento, Entrada, Salida, Saldo, UltimoCosto, CostoPromedio);
        }

        public static bool KardexProductoTieneMovimientos(int IDProducto)
        {
            if (adaptador.KardexProductoTieneMovimientos(IDProducto) == null)
            {
                return false;
            }
            return true;
        }

        public static bool KardexBodegaTieneMovimientos(int IDBodega)
        {
            if (adaptador.KardexTieneMovimientoByIDBodega(IDBodega) == null)
            {
                return false;
            }
            return true;
        }

        public static void ReKardex()
        {
            CADDS.BodegaProductoDataTable misBodegaProductos = CADBodegaProducto.GetData();
            foreach (CADDS.BodegaProductoRow miBodegaProducto in misBodegaProductos.Rows)
            {
                CADDS.KardexDataTable misKardex = adaptador.KardexGetKardexByIDBodegaAndIDProducto(miBodegaProducto.IDBodega, miBodegaProducto.IDProducto);
                if (misKardex.Rows.Count > 0)
                {
                    float saldo = 0;
                    decimal costoPromedio = 0;
                    decimal ultimoCosto = 0;
                    if (misKardex[0].Entrada > 0)
                    {
                        saldo = (float)misKardex[0].Entrada;
                        costoPromedio = misKardex[0].UltimoCosto;
                        ultimoCosto = misKardex[0].UltimoCosto;
                    }
                    else
                    {
                        saldo = (float)misKardex[0].Salida;
                        ultimoCosto = 0;
                    }

                    adaptador.KardexUpdateKardex(saldo, costoPromedio, ultimoCosto, misKardex[0].IDKardex);

                    for (int i = 1; i < misKardex.Rows.Count; i++)
                    {
                        if (misKardex[i].Entrada > 0)
                        {
                            if ((decimal)(saldo + misKardex[i].Entrada) != 0)
                            {
                                costoPromedio = ((decimal)saldo * costoPromedio + (decimal)misKardex[i].Entrada * misKardex[i].UltimoCosto) / (decimal)(saldo + misKardex[i].Entrada);
                            }
                            else
                            {
                                costoPromedio = 0;
                            }

                            ultimoCosto = misKardex[i].UltimoCosto;
                            saldo += (float)misKardex[i].Entrada;
                        }
                        else
                        {
                            saldo -= (float)misKardex[i].Salida;
                        }
                        adaptador.KardexUpdateKardex(saldo, costoPromedio, ultimoCosto, misKardex[i].IDKardex);
                    }
                }
            }
        }
    }
}
