using System;
using System.Windows.Forms;

namespace WinAppComercial.WIN
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSWIN);

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSWIN.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Medida' Puede moverla o quitarla según sea necesario.
            this.medidaTableAdapter.Fill(this.dSWIN.Medida);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.IVA' Puede moverla o quitarla según sea necesario.
            this.iVATableAdapter.Fill(this.dSWIN.IVA);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSWIN.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dSWIN.Producto);
            dgvDatos.AutoResizeColumns();
            LlenarGrillas();           
        }

        private void LlenarGrillas()
        {
            if (iDProductoTextBox.Text == string.Empty) return;
            this.barraTableAdapter.FillBy(this.dSWIN.Barra, Convert.ToInt32(iDProductoTextBox.Text));
            this.bodegaProductoTableAdapter.FillBy(this.dSWIN.BodegaProducto, Convert.ToInt32(iDProductoTextBox.Text));
            barrasDataGridView.AutoResizeColumns();
            bodegasDataGridView.AutoResizeColumns();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
        }

        private void iDProductoTextBox_TextChanged(object sender, EventArgs e)
        {
            LlenarGrillas();
        }
    }
}
