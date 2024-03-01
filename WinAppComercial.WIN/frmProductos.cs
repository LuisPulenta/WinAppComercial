using System;
using System.Windows.Forms;
using System.IO;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSWIN.Bodega);
            this.medidaTableAdapter.Fill(this.dSWIN.Medida);
            this.iVATableAdapter.Fill(this.dSWIN.IVA);
            this.departamentoTableAdapter.Fill(this.dSWIN.Departamento);
            this.productoTableAdapter.Fill(this.dSWIN.Producto);
            LlenarGrillas();
            CargarImagen();

            dgvDatos.AutoResizeColumns();
            barrasDataGridView.AutoResizeColumns();
            bodegasDataGridView.AutoResizeColumns();

        }

        private void Habilitar(bool campo)
        {
            descripcionTextBox.ReadOnly = !campo;
            iDDepartamentoComboBox.Enabled = campo;
            precioTextBox.ReadOnly = !campo;
            iDIVAComboBox.Enabled = campo;
            btnBuscarImagen.Enabled = campo;
            notasTextBox.ReadOnly = !campo;
            iDMedidaComboBox.Enabled = campo;
            medidaTextBox.ReadOnly = !campo;
            btnAgregarBarra.Enabled = campo;
            btnEliminarBarra.Enabled = campo;
            btnAgregarBodega.Enabled = campo;

            bindingNavigatorEditItem.Enabled = !campo;
            bindingNavigatorAddNewItem.Enabled = !campo;
            bindingNavigatorDeleteItem.Enabled = !campo;
            bindingNavigatorSaveItem.Enabled = campo;
            bindingNavigatorCancelItem.Enabled = campo;
            bindingNavigatorSearchItem.Enabled = !campo;

            bindingNavigatorMoveFirstItem.Enabled = !campo;
            bindingNavigatorMovePreviousItem.Enabled = !campo;
            bindingNavigatorMoveNextItem.Enabled = !campo;
            bindingNavigatorMoveLastItem.Enabled = !campo;
            bindingNavigatorPositionItem.Enabled = !campo;
            bindingNavigatorCountItem.Enabled = !campo;
        }

        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una Descripción");
                descripcionTextBox.Focus();
                return false;
            }

            if (iDDepartamentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDDepartamentoComboBox, "Debe seleccionar un Departamento");
                iDDepartamentoComboBox.Focus();
                return false;
            }

            if (precioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un Precio");
                precioTextBox.Focus();
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(precioTextBox.Text, out precio))
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un valor numérico");
                precioTextBox.Focus();
                return false;
            }

            if (precio <= 0)
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un valor mayor a 0");
                precioTextBox.Focus();
                return false;
            }

            errorProvider1.Clear();
            if (iDIVAComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDIVAComboBox, "Debe seleccionar un IVA");
                iDIVAComboBox.Focus();
                return false;
            }

            errorProvider1.Clear();
            if (iDMedidaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDMedidaComboBox, "Debe seleccionar una Unidad");
                iDMedidaComboBox.Focus();
                return false;
            }

            if (medidaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar una Medida");
                medidaTextBox.Focus();
                return false;
            }

            float medida;
            if (!float.TryParse(medidaTextBox.Text, out medida))
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar un valor numérico");
                medidaTextBox.Focus();
                return false;
            }

            if (medida <= 0)
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar un valor mayor a 0");
                medidaTextBox.Focus();
                return false;
            }

            return true;
        }
               
        private void LlenarGrillas()
        {
            if (iDProductoTextBox.Text == string.Empty) return;
            this.barraTableAdapter.FillBy(this.dSWIN.Barra, Convert.ToInt32(iDProductoTextBox.Text));
            this.bodegaProductoTableAdapter.FillBy(this.dSWIN.BodegaProducto, Convert.ToInt32(iDProductoTextBox.Text));
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.productoBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSWIN);
            Habilitar(false);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            productoBindingSource.AddNew();
            iDDepartamentoComboBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de borrar el Registro actual?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (CADKardex.KardexProductoTieneMovimientos(Convert.ToInt32(iDProductoTextBox.Text)))
            {
                MessageBox.Show(
                    "No se puede borrar Producto porque tiene movimientos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            this.Validate();

            CADBarra.DeleteBarraByIDProducto(Convert.ToInt32(iDProductoTextBox.Text));
            CADBodegaProducto.DeleteBodegaProductoByIDProducto(Convert.ToInt32(iDProductoTextBox.Text));
            this.productoBindingSource.RemoveAt(productoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSWIN);
            CargarImagen();

        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imagenTextBox.Text = openFileDialog1.SafeFileName;
            CargarImagen();
        }

        private void CargarImagen()
        {
            if (imagenTextBox.Text == string.Empty)
            {
                pbxImagen.Image = null;
            }
            else
            {
                if (File.Exists("Images\\" + imagenTextBox.Text))
                {
                    pbxImagen.Load("Images\\" + imagenTextBox.Text);
                }
                else
                {
                    pbxImagen.Image = null;
                }
            }
        }

        private void btnAgregarBarra_Click(object sender, EventArgs e)
        {
            frmBarras miForm = new frmBarras();
            miForm.ShowDialog();
            if (miForm.Barra == 0) return;
            CADBarra.BarraInsert(Convert.ToInt32(iDProductoTextBox.Text), miForm.Barra);
            this.barraTableAdapter.FillBy(this.dSWIN.Barra, Convert.ToInt32(iDProductoTextBox.Text));
        }

        private void btnEliminarBarra_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de borrar el Código de Barras?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            long barra = (long)barrasDataGridView.Rows[barraBindingSource.Position].Cells[0].Value;
            CADBarra.BarraDelete(barra);
            this.barraTableAdapter.FillBy(this.dSWIN.Barra, Convert.ToInt32(iDProductoTextBox.Text));
        }

        private void btnAgregarBodega_Click(object sender, EventArgs e)
        {
            frmParametrosBodega miForm = new frmParametrosBodega();
            miForm.IDProducto = Convert.ToInt32(iDProductoTextBox.Text);
            miForm.ShowDialog();
            this.bodegaProductoTableAdapter.FillBy(this.dSWIN.BodegaProducto, Convert.ToInt32(iDProductoTextBox.Text));
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            int position = productoBindingSource.Find("IDProducto", miBusqueda.IDElegido);
            productoBindingSource.Position = position;
            LlenarGrillas();
            CargarImagen();
        }

        private void productoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            LlenarGrillas();
            CargarImagen();
        }

        

        //private void bindingNavigatorPrint_Click(object sender, EventArgs e)
        //{
        //    frmListadoProductos miForm = new frmListadoProductos();
        //    miForm.ShowDialog();
        //}
    }
}
