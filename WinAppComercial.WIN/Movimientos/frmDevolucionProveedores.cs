using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN.Movimientos
{
    public partial class frmDevolucionProveedores : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private List<DevolucionProveedorDisponible> misDisponibles = new List<DevolucionProveedorDisponible>();
        private List<DevolucionProveedorDevuelto> misDevueltos = new List<DevolucionProveedorDevuelto>();


        public frmDevolucionProveedores()
        {
            InitializeComponent();
        }

        private void frmDevolucionProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter.Fill(this.dSWIN.Compra);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSWIN.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dSWIN.Proveedor);
            this.proveedorTableAdapter.FillBy2(this.dSWIN.Proveedor);
            this.compraTableAdapter.Fill(this.dSWIN.Compra);
            this.bodegaTableAdapter.Fill(this.dSWIN.Bodega);
            compraComboBox.SelectedIndex = -1;
            proveedorComboBox.SelectedIndex = -1;
            bodegaComboBox.SelectedIndex = -1; ;
            fechaDevolucionDateTimePicker.Value = DateTime.Now;
            dgvDatosDisponible.DataSource = misDisponibles;
            dgvDatosDevuelto.DataSource = misDevueltos;
            PersonalizarDisponibles();
            PersonalizarDevueltos();
        }

        private void PersonalizarDisponibles()
        {
            dgvDatosDisponible.Columns["IDProducto"].HeaderText = "ID Producto";
            dgvDatosDisponible.Columns["IDProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatosDisponible.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatosDisponible.Columns["Costo"].HeaderText = "Costo";
            dgvDatosDisponible.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["Costo"].DefaultCellStyle.Format = "C2";

            dgvDatosDisponible.Columns["CantidadOriginal"].HeaderText = "Cant. Orig.";
            dgvDatosDisponible.Columns["CantidadOriginal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadOriginal"].DefaultCellStyle.Format = "N2";

            dgvDatosDisponible.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            dgvDatosDisponible.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";

            dgvDatosDisponible.Columns["PorcentajeDescuento"].HeaderText = "% Descuento";
            dgvDatosDisponible.Columns["PorcentajeDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["PorcentajeDescuento"].DefaultCellStyle.Format = "P2";

            dgvDatosDisponible.Columns["CantidadDevuelta"].HeaderText = "Cant. Dev.";
            dgvDatosDisponible.Columns["CantidadDevuelta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadDevuelta"].DefaultCellStyle.Format = "N2";

            dgvDatosDisponible.Columns["CantidadDisponible"].HeaderText = "Cant. Disp.";
            dgvDatosDisponible.Columns["CantidadDisponible"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadDisponible"].DefaultCellStyle.Format = "N2";


            //dgvDatosDisponible.AutoResizeColumns();

            dgvDatosDisponible.Columns["IDProducto"].Width = 80;
            dgvDatosDisponible.Columns["Descripcion"].Width = 200;
            dgvDatosDisponible.Columns["CantidadOriginal"].Width = 80;
            dgvDatosDisponible.Columns["Costo"].Width = 80;
            dgvDatosDisponible.Columns["PorcentajeIVA"].Width = 80;
            dgvDatosDisponible.Columns["PorcentajeDescuento"].Width = 80;
            dgvDatosDisponible.Columns["CantidadDevuelta"].Width = 80;
            dgvDatosDisponible.Columns["CantidadDisponible"].Width = 80;
        }

        private void PersonalizarDevueltos()
        {
            dgvDatosDevuelto.Columns["IDProducto"].HeaderText = "ID Producto";
            dgvDatosDevuelto.Columns["IDProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatosDevuelto.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatosDevuelto.Columns["Costo"].HeaderText = "Costo";
            dgvDatosDevuelto.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDevuelto.Columns["Costo"].DefaultCellStyle.Format = "C2";

            dgvDatosDevuelto.Columns["CantidadADevolver"].HeaderText = "Cant. a devolver.";
            dgvDatosDevuelto.Columns["CantidadADevolver"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDevuelto.Columns["CantidadADevolver"].DefaultCellStyle.Format = "N2";

            dgvDatosDevuelto.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            dgvDatosDevuelto.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDevuelto.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";

            dgvDatosDevuelto.Columns["PorcentajeDescuento"].HeaderText = "% Descuento";
            dgvDatosDevuelto.Columns["PorcentajeDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDevuelto.Columns["PorcentajeDescuento"].DefaultCellStyle.Format = "P2";

            //dgvDatosDevuelto.AutoResizeColumns();

            dgvDatosDevuelto.Columns["IDProducto"].Width = 80;
            dgvDatosDevuelto.Columns["Descripcion"].Width = 200;
            dgvDatosDevuelto.Columns["CantidadADevolver"].Width = 80;
            dgvDatosDevuelto.Columns["Costo"].Width = 80;
            dgvDatosDevuelto.Columns["PorcentajeIVA"].Width = 80;
            dgvDatosDevuelto.Columns["PorcentajeDescuento"].Width = 80;
        }

        private void compraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (compraComboBox.SelectedValue == null) return;
            CADCompra miCompra = CADCompra.ComprasGetCompraByIDCompra((int)compraComboBox.SelectedValue);
            fechaTextBox.Text = miCompra.Fecha.ToString();
            proveedorComboBox.SelectedValue = miCompra.IDProveedor;
            bodegaComboBox.SelectedValue = miCompra.IDBodega;
            misDisponibles.Clear();
            misDevueltos.Clear();
            productoComboBox.SelectedIndex = -1;

            CADDS.CompraDetalleDataTable miTabla = CADCompraDetalle.CompraDetalleGetCompraDetalleByIDCompra(miCompra.IDCompra);
            foreach (CADDS.CompraDetalleRow miRegistro in miTabla.Rows)
            {
                DevolucionProveedorDisponible miDisponible = new DevolucionProveedorDisponible();
                miDisponible.CantidadDevuelta = (float)CADDevolucionProveedorDetalle.DevolucionProveedorGetHistoriaDevolucionProveedor(miRegistro.IDCompra, miRegistro.IDProducto);
                miDisponible.CantidadOriginal = (float)miRegistro.Cantidad;
                miDisponible.Descripcion = miRegistro.Descripcion;
                miDisponible.IDProducto = miRegistro.IDProducto;
                miDisponible.PorcentajeDescuento = (float)miRegistro.PorcentajeDescuento;
                miDisponible.PorcentajeIVA = (float)miRegistro.PorcentajeIVA;
                miDisponible.Costo = miRegistro.Costo;
                misDisponibles.Add(miDisponible);
            }
            dgvDatosDisponible.DataSource = null;

            dgvDatosDisponible.DataSource = misDisponibles;
            PersonalizarDisponibles();
            PersonalizarDevueltos();

            productoComboBox.DataSource = null;
            productoComboBox.DataSource = misDisponibles;
            productoComboBox.SelectedIndex = -1;

            dgvDatosDisponible.AutoResizeColumns();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (productoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(productoComboBox, "Debe seleccionar un Producto");
                productoComboBox.Focus();
                return;
            }
            if (cantidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar una Cantidad");
                return;
            }

            float cantidad;
            if (!float.TryParse(cantidadTextBox.Text, out cantidad))
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor numérico");
                cantidadTextBox.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor mayor a 0");
                cantidadTextBox.Focus();
                return;
            }

            if (cantidad > misDisponibles[productoComboBox.SelectedIndex].CantidadDisponible)
            {
                errorProvider1.SetError(cantidadTextBox, "La cantidad a devolver no puede ser mayor a la disponible");
                cantidadTextBox.Focus();
                return;
            }

            foreach (DevolucionProveedorDevuelto nuevoDevuelto in misDevueltos)
            {
                if ((int)productoComboBox.SelectedValue == nuevoDevuelto.IDProducto)
                {
                    errorProvider1.SetError(productoComboBox, "El Producto ya fue agregado a la devolución");
                    productoComboBox.Focus();
                    return;
                }
            }

            DevolucionProveedorDevuelto miDevuelto = new DevolucionProveedorDevuelto();
            miDevuelto.CantidadADevolver = cantidad;
            miDevuelto.Descripcion = misDisponibles[productoComboBox.SelectedIndex].Descripcion;
            miDevuelto.IDProducto = misDisponibles[productoComboBox.SelectedIndex].IDProducto;
            miDevuelto.PorcentajeDescuento = misDisponibles[productoComboBox.SelectedIndex].PorcentajeDescuento;
            miDevuelto.PorcentajeIVA = misDisponibles[productoComboBox.SelectedIndex].PorcentajeIVA;
            miDevuelto.Costo = misDisponibles[productoComboBox.SelectedIndex].Costo;
            misDevueltos.Add(miDevuelto);

            productoComboBox.SelectedIndex = -1;
            cantidadTextBox.Text = string.Empty;
            productoComboBox.Focus();

            dgvDatosDevuelto.DataSource = null;
            dgvDatosDevuelto.DataSource = misDevueltos;
            PersonalizarDevueltos();
        }

        private void btnDevolverTodo_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
             "¿Está seguro de agregar todos los ítems de la compra original a la Devolución?",
             "Confirmación",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            misDevueltos.Clear();
            foreach (DevolucionProveedorDisponible miDisponible in misDisponibles)
            {
                if (miDisponible.CantidadDisponible > 0)
                {
                    DevolucionProveedorDevuelto miDevuelto = new DevolucionProveedorDevuelto();
                    miDevuelto.CantidadADevolver = miDisponible.CantidadDisponible;
                    miDevuelto.Descripcion = miDisponible.Descripcion;
                    miDevuelto.IDProducto = miDisponible.IDProducto;
                    miDevuelto.PorcentajeDescuento = miDisponible.PorcentajeDescuento;
                    miDevuelto.PorcentajeIVA = miDisponible.PorcentajeIVA;
                    miDevuelto.Costo = miDisponible.Costo;
                    misDevueltos.Add(miDevuelto);
                }
            }
            RefrescarDevueltos();
            PersonalizarDevueltos();
        }

        private void RefrescarDevueltos()
        {
            dgvDatosDevuelto.DataSource = null;
            dgvDatosDevuelto.DataSource = misDevueltos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarLineaButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDevueltos.Count == 0) return;
            if (dgvDatosDevuelto.SelectedRows.Count == 0)
            {
                misDevueltos.RemoveAt(misDevueltos.Count - 1);
                RefrescarDevueltos();
            }
            else
            {
                int IDProducto = (int)dgvDatosDevuelto.SelectedRows[0].Cells[0].Value;
                for (int i = 0; i < misDevueltos.Count; i++)
                {
                    if (misDevueltos[i].IDProducto == IDProducto)
                    {
                        misDevueltos.RemoveAt(i);
                        break;
                    }
                }
            }
            RefrescarDevueltos();
            PersonalizarDevueltos();
        }

        private void eliminarTodoButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDevueltos.Count == 0) return;

            DialogResult rta = MessageBox.Show(
             "¿Está seguro de borrar el todas las líneas de la Devolución?",
             "Confirmación",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            misDevueltos.Clear();
            RefrescarDevueltos();
            PersonalizarDevueltos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (compraComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(compraComboBox, "Debe seleccionar una Compra");
                compraComboBox.Focus();
                return;
            }

            if (misDevueltos.Count == 0)
            {
                errorProvider1.SetError(productoComboBox, "Debe ingresar al menos un Producto en la Devolución");
                productoComboBox.Focus();
                return;
            }

            DialogResult rta = MessageBox.Show(
            "¿Está seguro de guardar la Devolución a Proveedor?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int IDCompra = (int)compraComboBox.SelectedValue;
            int IDBodega = (int)bodegaComboBox.SelectedValue;
            DateTime fecha = fechaDevolucionDateTimePicker.Value;

            //Grabamos la Cabecera de la Devolución
            int IDDevolucion = CADDevolucionProveedor.DevolucionProveedorInsertDevolucionProveedor(fecha, IDCompra);

            //Grabamos el Detalle de la Devolución
            foreach (DevolucionProveedorDevuelto midevuelto in misDevueltos)
            {
                //Actualizamos la Tabla BodegaProducto
                CADBodegaProducto miBodegaProducto = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodega, midevuelto.IDProducto);

                if (miBodegaProducto == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodega, midevuelto.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(-midevuelto.CantidadADevolver, IDBodega, midevuelto.IDProducto);

                //Actualizamos el Kardex
                CADKardex miKardex = CADKardex.KardexUltimoKardex(IDBodega, midevuelto.IDProducto);

                int IDKardex;
                float nuevoSaldo;
                decimal nuevoCostoPromedio;
                decimal nuevoUltimoCosto;

                if (miKardex == null)
                {
                    nuevoSaldo = -midevuelto.CantidadADevolver;
                    nuevoCostoPromedio = midevuelto.Costo;
                    nuevoUltimoCosto = nuevoCostoPromedio;
                }
                else
                {
                    nuevoSaldo = miKardex.Saldo - midevuelto.CantidadADevolver;
                    if (nuevoSaldo != 0)
                    {
                        nuevoCostoPromedio = (miKardex.CostoPromedio * (decimal)miKardex.Saldo
                        + midevuelto.Costo * (decimal)midevuelto.CantidadADevolver) / (decimal)nuevoSaldo;
                    }
                    else
                    {
                        nuevoCostoPromedio = 0;
                    }
                    nuevoUltimoCosto = (decimal)midevuelto.Costo;
                }

                IDKardex = CADKardex.KardexInsertKardex(
                        IDBodega,
                        midevuelto.IDProducto,
                        fecha,
                        string.Format("DP-{0}", IDDevolucion),
                        0,
                        midevuelto.CantidadADevolver,
                        nuevoSaldo,
                        nuevoUltimoCosto,
                        nuevoCostoPromedio);

                //Actualizamos DevolucionCompraDetalle
                CADDevolucionProveedorDetalle.DevolucionProveedorDetalleInsertDevolucionProveedorDetalle(
                    IDDevolucion,
                    midevuelto.IDProducto,
                    midevuelto.Descripcion,
                    midevuelto.Costo,
                    midevuelto.CantidadADevolver,
                    IDKardex,
                    midevuelto.PorcentajeIVA,
                    midevuelto.PorcentajeDescuento)
                    ;
            }
            

            MessageBox.Show(
                string.Format("La Devolución a Proveedor {0}, fue grabada de forma exitosa", IDDevolucion),
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            compraComboBox.SelectedIndex = -1;
            bodegaComboBox.SelectedIndex = -1;
            proveedorComboBox.SelectedIndex = -1;
            fechaDevolucionDateTimePicker.Value = DateTime.Now;
            fechaTextBox.Text = string.Empty;
            productoComboBox.SelectedIndex = -1;

            misDisponibles.Clear();
            misDevueltos.Clear();

            dgvDatosDisponible.DataSource = null;
            dgvDatosDevuelto.DataSource = null;

            dgvDatosDisponible.DataSource = misDisponibles;
            dgvDatosDevuelto.DataSource = misDevueltos;

            PersonalizarDisponibles();
            PersonalizarDevueltos();

            compraComboBox.Focus();
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.proveedorTableAdapter.FillBy2(this.dSWIN.Proveedor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
