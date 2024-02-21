using System;
using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmParametrosBodega : Form
    {
        private int idProducto;

        public int IDProducto
        {
            set { idProducto = value; }
        }
        public frmParametrosBodega()
        {
            InitializeComponent();
        }

        private void frmParametrosBodega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSWIN.Bodega);
            bodegaComboBox.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (bodegaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                bodegaComboBox.Focus();
                return;
            }
            CADBodegaProducto.BodegaProductoUpdate((int)bodegaComboBox.SelectedValue, idProducto, (float)minimoNumericUpDown.Value, (float)maximoNumericUpDown.Value, (int)diasReposicionNumericUpDown.Value, (float)cantidadMinimaNumericUpDown.Value);
            this.Close();
        }

        private void bodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bodegaComboBox.SelectedIndex == -1) return;

            CADBodegaProducto miBodegaProducto = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto((int)bodegaComboBox.SelectedValue, idProducto);

            if (miBodegaProducto == null)
            {
                stockTextBox.Text = string.Empty;
                cantidadMinimaNumericUpDown.Value = 1;
                diasReposicionNumericUpDown.Value = 1;
                minimoNumericUpDown.Value = 1;
                maximoNumericUpDown.Value = 1;                
                return;
            }
            stockTextBox.Text = miBodegaProducto.Stock.ToString();
            cantidadMinimaNumericUpDown.Value = (decimal)miBodegaProducto.Minimo;
            diasReposicionNumericUpDown.Value = miBodegaProducto.DiasReposicion;
            minimoNumericUpDown.Value = (decimal)miBodegaProducto.Minimo;
            maximoNumericUpDown.Value = (decimal)miBodegaProducto.Maximo;
        }
    }
}
