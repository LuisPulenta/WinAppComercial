using System;

using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmCambioUsuario : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmCambioUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar un Usuario");
                txtUsuario.Focus();
                return;
            }

            if (txtClave.Text == string.Empty)
            {
                errorProvider1.SetError(txtClave, "Debe ingresar una Clave");
                txtClave.Focus();
                return;
            }

            if (!CADUsuario.ValidaUsuario(txtUsuario.Text, txtClave.Text))
            {
                MessageBox.Show("Usuario o Clave no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
                txtUsuario.Focus();
                return;
            }

            usuarioLogueado = CADUsuario.UsuarioGetUsuarioByIDUsuario(txtUsuario.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            usuarioLogueado = null;
            this.Close();
        }
    }
}
