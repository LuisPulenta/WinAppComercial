using System;
using System.Windows.Forms;

namespace WinAppComercial.WIN
{
    public partial class frmBusquedaProducto : Form
    {
        private int idElegido;

        public int IDElegido { get => idElegido; }

        public frmBusquedaProducto()
        {
            InitializeComponent();
        }

        private void frmBusquedaProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Medida' Puede moverla o quitarla según sea necesario.
            this.medidaTableAdapter.Fill(this.dSWIN.Medida);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.IVA' Puede moverla o quitarla según sea necesario.
            this.iVATableAdapter.Fill(this.dSWIN.IVA);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSWIN.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSWIN.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dSWIN.Producto);
            dgvDatos.AutoResizeColumns();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string descripcion;

            if (rbtContenga.Checked)
            {
                descripcion = "%" + descripcionToolStripTextBox.Text + "%";
            }

            else if (rbtEmpiece.Checked)
            {
                descripcion = descripcionToolStripTextBox.Text + "%";
            }
            else if (rbtTermina.Checked)
            {
                descripcion = "%" + descripcionToolStripTextBox.Text;
            }
            else
            {
                descripcion = descripcionToolStripTextBox.Text;
            }
            try
            {
                this.productoTableAdapter.FillBy(
                    this.dSWIN.Producto,
                    descripcion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            descripcionToolStripTextBox.Text = string.Empty;
            fillByToolStripButton_Click(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                idElegido = 0;
            }
            else if (dgvDatos.SelectedRows.Count != 0)
            {
                idElegido = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                idElegido = Convert.ToInt32(dgvDatos.Rows[0].Cells[0].Value);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idElegido = 0;
            this.Close();
        }
    }
}