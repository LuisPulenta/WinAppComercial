using System;
using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmCambioClave : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmCambioClave()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (claveAnteriorTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(claveAnteriorTextBox, "Debe ingresar la Clave actual");
                claveAnteriorTextBox.Focus();
                return;
            }

            if (claveAnteriorTextBox.Text != usuarioLogueado.Clave)
            {
                errorProvider1.SetError(claveAnteriorTextBox, "Clave actual incorrecta");
                claveAnteriorTextBox.Focus();
                return;
            }

            if (nuevaClaveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "Debe ingresar la Nueva Clave");
                nuevaClaveTextBox.Focus();
                return;
            }

            if (confirmacionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(confirmacionTextBox, "Debe ingresar la Confirmacion");
                confirmacionTextBox.Focus();
                return;
            }

            if (nuevaClaveTextBox.Text != confirmacionTextBox.Text)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "La nueva Clave y su confirmación no coinciden");
                errorProvider1.SetError(confirmacionTextBox, "La nueva Clave y su confirmación no coinciden");
                confirmacionTextBox.Focus();
                return;
            }

            CADUsuario.UsuarioUpdateClave(nuevaClaveTextBox.Text, usuarioLogueado.IDUsuario);
            MessageBox.Show("Cambio de Clave realizado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            usuarioLogueado.Clave = nuevaClaveTextBox.Text;
            usuarioLogueado.FechaModificacionClave = DateTime.Now;
            this.Close();
        }

        private void frmCambioClave_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usuarioLogueado.FechaModificacionClave.AddDays(30) < DateTime.Now)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "Debe cambiar la Clave");
                nuevaClaveTextBox.Focus();
                e.Cancel = true;
                return;
            }
        }
    }
}