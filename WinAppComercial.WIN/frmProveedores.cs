using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppComercial.WIN
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSWIN.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dSWIN.Proveedor);
            dgvDatos.AutoResizeColumns();
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSWIN);
            Habilitar(false);
        }

        //-----------------------------------------------------------------------------------------
        private void Habilitar(bool campo)
        {
            iDTipoDocumentoComboBox.Enabled = campo;
            documentoTextBox.ReadOnly = !campo;
            nombreTextBox.ReadOnly = !campo;
            nombresContactoTextBox.ReadOnly = !campo;
            apellidosContactoTextBox.ReadOnly = !campo;
            direccionTextBox.ReadOnly = !campo;
            telefono1TextBox.ReadOnly = !campo;
            telefono2TextBox.ReadOnly = !campo;
            correoTextBox.ReadOnly = !campo;
            notasTextBox.ReadOnly = !campo;

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
            this.proveedorBindingSource.CancelEdit();
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

            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un Nombre de Proveedor");
                nombreTextBox.Focus();
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
            proveedorBindingSource.AddNew();
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
                nombreTextBox.Text = nombresContactoTextBox.Text + " " + apellidosContactoTextBox.Text;
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
            this.proveedorBindingSource.RemoveAt(proveedorBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSWIN);
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            int position = proveedorBindingSource.Find("IDProveedor", miBusqueda.IDElegido);
            proveedorBindingSource.Position = position;
        }
    }
}