using System;
using System.Windows.Forms;

namespace WinAppComercial.WIN
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------
        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSWIN.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Proveedor' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dSWIN.Cliente);
            dgvDatos.AutoResizeColumns();
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.clienteBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dSWIN);
                errorProvider1.Clear();
            }
            catch (Exception)
            {
                errorProvider1.SetError(documentoTextBox, "Este N° de Documento ya está asignado");
                documentoTextBox.Focus();
                return;
            }
            Habilitar(false);
        }

        //-----------------------------------------------------------------------------------------
        private void Habilitar(bool campo)
        {
            iDTipoDocumentoComboBox.Enabled = campo;
            documentoTextBox.ReadOnly = !campo;
            nombreComercialTextBox.ReadOnly = !campo;
            nombresContactoTextBox.ReadOnly = !campo;
            apellidosContactoTextBox.ReadOnly = !campo;
            direccionTextBox.ReadOnly = !campo;
            telefono1TextBox.ReadOnly = !campo;
            telefono2TextBox.ReadOnly = !campo;
            correoTextBox.ReadOnly = !campo;
            notasTextBox.ReadOnly = !campo;
            aniversarioDateTimePicker.Enabled = campo;

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

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        //-----------------------------------------------------------------------------------------
        private bool Validarcampos()
        {
            errorProvider1.Clear();
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox, "Debe seleccionar un Tipo de Documento");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }

            if (documentoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(documentoTextBox, "Debe ingresar un N° de Documento");
                documentoTextBox.Focus();
                return false;
            }

            if (nombreComercialTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreComercialTextBox, "Debe ingresar un Nombre de Cliente");
                nombreComercialTextBox.Focus();
                return false;
            }

            if (nombresContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombresContactoTextBox, "Debe ingresar un Nombre de Contacto");
                nombresContactoTextBox.Focus();
                return false;
            }

            if (apellidosContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidosContactoTextBox, "Debe ingresar un Apellido de Contacto");
                apellidosContactoTextBox.Focus();
                return false;
            }

            if (correoTextBox.Text != string.Empty)
            {
                RegexUtilities regexUtilities = new RegexUtilities();
                if (!regexUtilities.IsValidEmail(correoTextBox.Text))
                {
                    errorProvider1.SetError(correoTextBox, "Si ingresa un correo, éste debe ser válido");
                    correoTextBox.Focus();
                    return false;
                }
            }
            return true;
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            clienteBindingSource.AddNew();
            iDTipoDocumentoComboBox.Focus();
        }

        //-----------------------------------------------------------------------------------------
        private void nombresContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            ArmaNombre();
        }

        //-----------------------------------------------------------------------------------------
        private void apellidosContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            ArmaNombre();
        }

        //-----------------------------------------------------------------------------------------
        private void ArmaNombre()
        {
            if (iDTipoDocumentoComboBox.SelectedIndex == 0)
            {
                nombreComercialTextBox.Text = nombresContactoTextBox.Text + " " + apellidosContactoTextBox.Text;
            }
        }
        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
                "¿Está seguro de borrar el Registro actual?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            this.Validate();
            this.clienteBindingSource.RemoveAt(clienteBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSWIN);
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            int position = clienteBindingSource.Find("IDCliente", miBusqueda.IDElegido);
            clienteBindingSource.Position = position;
        }
    }
}

