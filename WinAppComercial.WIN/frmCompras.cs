using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmCompras : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int totalItems = 0;
        private decimal totalBruto = 0;
        private decimal totalIVA = 0;
        private decimal totalDescuento = 0;
        private decimal totalNeto = 0;
        List<DetalleCompra> misDetalles = new List<DetalleCompra>();
        CADProducto ultimoProducto = null;


        public frmCompras()
        {
            InitializeComponent();
        }



        private void frmCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.FillBy(this.dSWIN.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.FillBy1(this.dSWIN.Proveedor);
            proveedorComboBox.SelectedIndex = -1;
            bodegaComboBox.SelectedIndex = -1;
            fechaDateTimePicker.Value = DateTime.Now;
            productoLabel.Text = string.Empty;
            dgvDatos.DataSource = misDetalles;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDElegido;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            productoTextBox.Text = miBusqueda.IDElegido.ToString();
            productoTextBox_Validating(sender, new System.ComponentModel.CancelEventArgs());

        }

        private void productoTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.Clear();
            pbxImagen.Image = null;
            if (productoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Código de Producto o un Código de Barras");
                return;
            }

            long producto;
            if (!long.TryParse(productoTextBox.Text, out producto))
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un valor numérico");
                productoTextBox.Focus();
                return;
            }

            if (producto <= 0)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un valor mayor a 0");
                productoTextBox.Focus();
                return;
            }

            CADProducto miProducto = CADProducto.ProductoGetProductoByIDProducto((int)producto);
            if (miProducto == null)
            {
                miProducto = CADProducto.ProductoGetProductoByIDBarra(producto);
            }
            if (miProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Producto no existe");
                productoLabel.Text = string.Empty;
                pbxImagen.Image = null;
                ultimoProducto = null;
            }
            else
            {
                productoLabel.Text = miProducto.Descripcion;
                ultimoProducto = miProducto;
                if (miProducto.Imagen == string.Empty)
                {
                    pbxImagen.Image = null;
                }
                else
                {

                    if (File.Exists("Images\\" + miProducto.Imagen))
                    {
                        if (miProducto.Imagen == string.Empty)
                        {
                            pbxImagen.Image = null;
                        }
                        else
                        {
                            if (File.Exists("Images\\" + miProducto.Imagen))
                            {
                                pbxImagen.Load("Images\\" + miProducto.Imagen);
                            }
                        }
                    }
                    else
                    {
                        pbxImagen.Image = null;
                    }
                }
            }
        }




        private void agregarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ultimoProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Producto");
                productoTextBox.Focus();
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

            if (costoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar un Costo");
                return;
            }

            decimal costo;
            if (!decimal.TryParse(costoTextBox.Text, out costo))
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar un valor numérico");
                costoTextBox.Focus();
                return;
            }

            if (costo <= 0)
            {
                errorProvider1.SetError(costoTextBox, "Debe ingresar un valor mayor a 0");
                costoTextBox.Focus();
                return;
            }

            float porcentajeDescuento = 0;
            if (porcentajeDescuentoTextBox.Text != string.Empty)
            {
                if (!float.TryParse(porcentajeDescuentoTextBox.Text, out porcentajeDescuento))
                {
                    errorProvider1.SetError(porcentajeDescuentoTextBox, "Debe ingresar un valor numérico");
                    porcentajeDescuentoTextBox.Focus();
                    return;
                }

                if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                {
                    errorProvider1.SetError(porcentajeDescuentoTextBox, "Debe ingresar un valor igual o mayor a 0 y menor o igual a 100");
                    porcentajeDescuentoTextBox.Focus();
                    return;
                }
                porcentajeDescuento /= 100;
            }

            DetalleCompra miDetalle = new DetalleCompra();
            miDetalle.Cantidad = cantidad;
            miDetalle.Costo = costo;
            miDetalle.Descripcion = ultimoProducto.Descripcion;
            miDetalle.IDProducto = ultimoProducto.IDProducto;
            miDetalle.PorcentajeDescuento = porcentajeDescuento;
            miDetalle.PorcentajeIVA = CADIVA.IVAGetIVAByIDIVA(ultimoProducto.IDIVA).Tarifa;

            misDetalles.Add(miDetalle);

            pbxImagen.Image = null;

            RefrescaGrid();
            LimpiarControles();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;
        }

        private void LimpiarControles()
        {
            ultimoProducto = null;
            productoTextBox.Text = string.Empty;
            productoLabel.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            costoTextBox.Text = string.Empty;
            porcentajeDescuentoTextBox.Text = string.Empty;
            productoTextBox.Focus();
        }

        private void RefrescaGrid()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;

            totalItems = 0;
            totalBruto = 0;
            totalIVA = 0;
            totalDescuento = 0;
            totalNeto = 0;

            foreach (DetalleCompra miDetalle in misDetalles)
            {
                totalItems += 1;
                totalBruto += miDetalle.valorBruto;
                totalIVA += miDetalle.valorIVA;
                totalDescuento += miDetalle.valorDescuento;
                totalNeto += miDetalle.valorNeto;
            }

            totalItemTextBox.Text = string.Format("{0:N0}", totalItems);
            totalBrutoTextBox.Text = string.Format("{0:C2}", totalBruto);
            totalIVATextBox.Text = string.Format("{0:C2}", totalIVA);
            totalDescuentoTextBox.Text = string.Format("{0:C2}", totalDescuento);
            totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);

            PersonalizaGrid();
        }

        private void PersonalizaGrid()
        {
            dgvDatos.Columns["IDProducto"].HeaderText = "ID ProductoXXX";
            dgvDatos.Columns["IDProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatos.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatos.Columns["Costo"].HeaderText = "Costo";
            dgvDatos.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Costo"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            dgvDatos.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";

            dgvDatos.Columns["PorcentajeDescuento"].HeaderText = "% Descuento";
            dgvDatos.Columns["PorcentajeDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["PorcentajeDescuento"].DefaultCellStyle.Format = "P2";

            dgvDatos.Columns["ValorBruto"].HeaderText = "Valor Bruto";
            dgvDatos.Columns["ValorBruto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["ValorBruto"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["ValorIVA"].HeaderText = "Valor IVA";
            dgvDatos.Columns["ValorIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["ValorIVA"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["ValorDescuento"].HeaderText = "Valor Descuento";
            dgvDatos.Columns["ValorDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["ValorDescuento"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["ValorNeto"].HeaderText = "Valor Neto";
            dgvDatos.Columns["ValorNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["ValorNeto"].DefaultCellStyle.Format = "C2";

            //dgvDatos.AutoResizeColumns();

            dgvDatos.Columns["IDProducto"].Width = 80;
            dgvDatos.Columns["Descripcion"].Width = 200;
            dgvDatos.Columns["Cantidad"].Width = 80;
            dgvDatos.Columns["Costo"].Width = 80;
            dgvDatos.Columns["PorcentajeIVA"].Width = 80;
            dgvDatos.Columns["PorcentajeDescuento"].Width = 80;
            dgvDatos.Columns["ValorBruto"].Width = 80;
            dgvDatos.Columns["ValorIVA"].Width = 80;
            dgvDatos.Columns["ValorDescuento"].Width = 80;
            dgvDatos.Columns["ValorNeto"].Width = 80;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (proveedorComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(proveedorComboBox, "Debe seleccionar un Proveedor");
                proveedorComboBox.Focus();
                return;
            }

            if (bodegaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                bodegaComboBox.Focus();
                return;
            }

            if (misDetalles.Count == 0)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar al menos un Producto");
                productoTextBox.Focus();
                return;
            }

            DialogResult rta = MessageBox.Show(
            "¿Está seguro de guardar la Compra?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int IDProveedor = (int)proveedorComboBox.SelectedValue;
            int IDBodega = (int)bodegaComboBox.SelectedValue;
            DateTime fecha = fechaDateTimePicker.Value;

            //Grabamos la Cabecera de la Compra
            int IDCompra = CADCompra.CompraInsertCompra(
                fecha,
                IDProveedor,
                IDBodega);

            //Grabamos el Detalle de la Compra
            foreach (DetalleCompra midetalle in misDetalles)
            {
                //Actualizamos la Tabla BodegaProducto
                CADBodegaProducto miBodegaProducto = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodega, midetalle.IDProducto);

                if (miBodegaProducto == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodega, midetalle.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(midetalle.Cantidad, IDBodega, midetalle.IDProducto);

                //Actualizamos el Kardex
                CADKardex miKardex = CADKardex.KardexUltimoKardex(IDBodega, midetalle.IDProducto);

                int IDKardex;
                float nuevoSaldo;
                decimal nuevoCostoPromedio;
                decimal nuevoUltimoCosto;

                if (miKardex == null)
                {
                    nuevoSaldo = midetalle.Cantidad;
                    nuevoCostoPromedio = midetalle.valorNeto / (decimal)midetalle.Cantidad;
                    nuevoUltimoCosto = nuevoCostoPromedio;
                }
                else
                {
                    nuevoSaldo = miKardex.Saldo + midetalle.Cantidad;
                    nuevoCostoPromedio = (miKardex.CostoPromedio * (decimal)miKardex.Saldo
                        + midetalle.valorNeto) / (decimal)nuevoSaldo;
                    nuevoUltimoCosto = midetalle.valorNeto / (decimal)midetalle.Cantidad;
                }

                IDKardex = CADKardex.KardexInsertKardex(
                        IDBodega,
                        midetalle.IDProducto,
                        fecha,
                        string.Format("CO-{0}", IDCompra),
                        midetalle.Cantidad,
                        0,
                        nuevoSaldo,
                        nuevoUltimoCosto,
                        nuevoCostoPromedio);

                //Actualizamos CompraDetalle
                CADCompraDetalle.CompraDetalleInsertCompraDetalle(
                    IDCompra,
                    midetalle.IDProducto,
                    midetalle.Descripcion,
                    midetalle.Costo,
                    midetalle.Cantidad,
                    IDKardex, midetalle.PorcentajeIVA,
                    midetalle.PorcentajeDescuento);
            }

            MessageBox.Show(
                string.Format("La Compra {0}, fue grabada de forma exitosa", IDCompra),
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            totalItems = 0;
            totalBruto = 0;
            totalIVA = 0;
            totalDescuento = 0;
            totalNeto = 0;
            pbxImagen.Image = null;

            proveedorComboBox.SelectedIndex = -1;
            bodegaComboBox.SelectedIndex = -1;
            misDetalles.Clear();
            pbxImagen.Image = null;
            RefrescaGrid();
            fechaDateTimePicker.Value = DateTime.Now;
            proveedorComboBox.Focus();
        }



        private void eliminarTodoButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;

            DialogResult rta = MessageBox.Show(
             "¿Está seguro de borrar el todas las líneas de la Compra?",
             "Confirmación",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            misDetalles.Clear();

            totalItems = 0;
            totalBruto = 0;
            totalIVA = 0;
            totalDescuento = 0;
            totalNeto = 0;
            RefrescaGrid();
            pbxImagen.Image = null;

        }

        private void eliminarLineaButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;
            if (dgvDatos.SelectedRows.Count == 0)
            {
                misDetalles.RemoveAt(misDetalles.Count - 1);
                RefrescaGrid();
            }
            else
            {
                int IDProducto = (int)dgvDatos.SelectedRows[0].Cells[0].Value;
                for (int i = 0; i < misDetalles.Count; i++)
                {
                    if (misDetalles[i].IDProducto == IDProducto)
                    {
                        misDetalles.RemoveAt(i);
                        break;
                    }
                }
            }
            RefrescaGrid();
        }

        private void frmCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (misDetalles.Count > 0)
            {
                DialogResult rta = MessageBox.Show(
            "La Compra tiene productos cargados, ¿está seguro de salir sin terminar la Compra?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

                if (rta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.proveedorTableAdapter.FillBy1(this.dSWIN.Proveedor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bodegaTableAdapter.FillBy(this.dSWIN.Bodega);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
