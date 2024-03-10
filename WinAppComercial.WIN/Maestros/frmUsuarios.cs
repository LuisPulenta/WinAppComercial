using System;
using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmUsuarios : Form
    {
        private bool nuevo = false;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSWIN);

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dSWIN.Rol);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dSWIN.Usuario);
            dgvDatos.AutoResizeColumns();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void Habilitar(bool campo)
        {
            iDUsuarioTextBox.ReadOnly = false;
            iDRolComboBox.Enabled = campo;
            nombresTextBox.ReadOnly = !campo;
            apellidosTextBox.ReadOnly = !campo;
            claveTextBox.ReadOnly = !campo;
            confirmacionTextBox.ReadOnly = !campo;
            correoTextBox.ReadOnly = !campo;

            bindingNavigatorEditItem.Enabled = !campo;
            bindingNavigatorAddNewItem.Enabled = !campo;
            bindingNavigatorDeleteItem.Enabled = !campo;
            bindingNavigatorSaveItem.Enabled = campo;
            bindingNavigatorCancelItem.Enabled = campo;

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

            if (nuevo)
            {
                if (iDUsuarioTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "Debe ingresar un IDUsuario");
                    iDUsuarioTextBox.Focus();
                    return false;
                }

                if (CADUsuario.ExisteUsuario(iDUsuarioTextBox.Text))
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "Este IDUsuario ya existe");
                    iDUsuarioTextBox.Focus();
                    return false;
                }
            }

            if (iDRolComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDRolComboBox, "Debe seleccionar un Rol");
                iDRolComboBox.Focus();
                return false;
            }

            if (nombresTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombresTextBox, "Debe ingresar un Nombre");
                nombresTextBox.Focus();
                return false;
            }

            if (apellidosTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidosTextBox, "Debe ingresar un Apellido");
                apellidosTextBox.Focus();
                return false;
            }

            if (claveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(claveTextBox, "Debe ingresar una Clave");
                claveTextBox.Focus();
                return false;
            }

            if (confirmacionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(confirmacionTextBox, "Debe ingresar una Confirmación de Clave");
                confirmacionTextBox.Focus();
                return false;
            }

            if (claveTextBox.Text != confirmacionTextBox.Text)
            {
                errorProvider1.SetError(claveTextBox, "La Clave y su Confirmación no son iguales");
                errorProvider1.SetError(confirmacionTextBox, "La Clave y su Confirmación no son iguales");
                claveTextBox.Focus();
                return false;
            }


            if (correoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(correoTextBox, "Debe ingresar un Correo");
                correoTextBox.Focus();
                return false;
            }

            RegexUtilities regexUtilities = new RegexUtilities();
            if (!regexUtilities.IsValidEmail(correoTextBox.Text))
            {
                errorProvider1.SetError(correoTextBox, "El correo ingresado no es válido");
                correoTextBox.Focus();
                return false;
            }

            return true;
        }


        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.usuarioBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            fechaModificacionClaveDateTimePicker.Value = DateTime.Now;
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSWIN);
            Habilitar(false);
        }

        private void bindingNavigatorEditItem_Click_1(object sender, EventArgs e)
        {
            Habilitar(true);
            iDUsuarioTextBox.ReadOnly = true;
            nuevo = false;
            iDRolComboBox.Focus();
        }

        private void bindingNavigatorCancelItem_Click_1(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
            this.usuarioBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
            iDUsuarioTextBox.ReadOnly = false;
            confirmacionTextBox.Clear();
            fechaModificacionClaveDateTimePicker.Value = DateTime.Now;
            usuarioBindingSource.AddNew();
            iDUsuarioTextBox.Focus();
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

            this.Validate();
            this.usuarioBindingSource.RemoveAt(usuarioBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSWIN);
        }
    }
}
