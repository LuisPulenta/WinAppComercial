using System;
using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmClientesTemp : Form
    {

        private int i = 0;
        public frmClientesTemp()
        {
            InitializeComponent();
        }

        private void frmClientesTemp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.TipoDocumento' Puede moverla o quitarla según sea necesario.
            cbTipoDocumento.SelectedIndex = -1;
            this.tipoDocumentoTableAdapter.Fill(this.dSWIN.TipoDocumento);
            dgvDatos.DataSource = CADCliente.GetData();
            dgvDatos.AutoResizeColumns();
            MostrarRegistro();
        }

        private void MostrarRegistro()
        {
            if (dgvDatos.Rows.Count == 0) return;
            txtIdCliente.Text = dgvDatos.Rows[i].Cells["IDCliente"].Value.ToString();
            txtNombreComercial.Text = dgvDatos.Rows[i].Cells["NombreComercial"].Value.ToString();
            txtNombreContacto.Text = dgvDatos.Rows[i].Cells["NombresContacto"].Value.ToString();
            txtApellidoContacto.Text = dgvDatos.Rows[i].Cells["ApellidosContacto"].Value.ToString();
            txtDocumento.Text = dgvDatos.Rows[i].Cells["Documento"].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[i].Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgvDatos.Rows[i].Cells["Telefono1"].Value.ToString();
            txtCelular.Text = dgvDatos.Rows[i].Cells["Telefono2"].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[i].Cells["Direccion"].Value.ToString();
            txtNotas.Text = dgvDatos.Rows[i].Cells["Notas"].Value.ToString();
            txtCorreo.Text = dgvDatos.Rows[i].Cells["Correo"].Value.ToString();
            cbTipoDocumento.SelectedValue = dgvDatos.Rows[i].Cells["IDTipoDocumento"].Value;
            try
            {
                dtpAniversario.Value = Convert.ToDateTime(dgvDatos.Rows[i].Cells["Aniversario"].Value);
            }
            catch (Exception)
            {
                dtpAniversario.Value = DateTime.Now;
            }
        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (i >= dgvDatos.Rows.Count - 1) return;
            i++;
            MostrarRegistro();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i--;
            MostrarRegistro();
        }

        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            MostrarRegistro();
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            i = dgvDatos.Rows.Count - 1;
            MostrarRegistro();
        }
    }
}
