using System;

using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmPrincipal : Form
    {

        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes miForm = new frmClientes();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores miForm = new frmProveedores();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBodegas miForm = new frmBodegas();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConceptos miForm = new frmConceptos();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamentos miForm = new frmDepartamentos();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void ivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIvas miForm = new frmIvas();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedidas miForm = new frmMedidas();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void tiposDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposDocumento miForm = new frmTiposDocumento();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProductos miForm = new frmProductos();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmClientes miForm = new frmClientes();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void tsbProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores miForm = new frmProveedores();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            frmProductos miForm = new frmProductos();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios miForm = new frmUsuarios();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            nombresUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombres + " " + usuarioLogueado.Apellidos;
            VerificaCambioClave(sender, e);
            VerificarPermisos();
        }

        private void VerificarPermisos()
        {
            proveedoresToolStripMenuItem.Visible = CADPermisoRol.PermisoRolPuedeVer(usuarioLogueado.IDRol, "frmProveedores");
            tsbProveedores.Visible = CADPermisoRol.PermisoRolPuedeVer(usuarioLogueado.IDRol, "frmProveedores");
        }


        private void cambioDeClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioClave miForm = new frmCambioClave();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.ShowDialog();
        }

        private void VerificaCambioClave(object sender, System.EventArgs e)
        {
            if (usuarioLogueado.FechaModificacionClave.AddDays(30) < DateTime.Now)
            {
                cambioDeClaveToolStripMenuItem_Click(sender, e);
            }
        }

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioUsuario miForm = new frmCambioUsuario();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.ShowDialog();
            if (miForm.UsuarioLogueado != null)
            {
                usuarioLogueado = miForm.UsuarioLogueado;
            }
            nombresUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombres + " " + usuarioLogueado.Apellidos;
            VerificarPermisos();
        }
    }
}
