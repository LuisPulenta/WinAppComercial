using System;
using System.Windows.Forms;
using WinAppComercial.WIN.DSWINTableAdapters;

namespace WinAppComercial.WIN.Listados
{
    public partial class frmListadoProductos : Form
    {
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            cryListadoProductos miReporte = new cryListadoProductos();
            DSWIN miDS = new DSWIN();
            ListadoProductosTableAdapter miAdaptador = new ListadoProductosTableAdapter();
            errorProvider1.Clear();
            if (todosCheckBox.Checked)
            {
                miAdaptador.Fill(miDS.ListadoProductos);
                departamentoComboBox.SelectedIndex = -1;
                departamentoComboBox.Enabled = false;
            }
            else
            {
                departamentoComboBox.Enabled = true;
                if (departamentoComboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(departamentoComboBox, "Debe seleccionar un Departamento");
                    return;
                }
                miAdaptador.FillBy(miDS.ListadoProductos, (int)departamentoComboBox.SelectedValue);
            }
            miReporte.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miReporte;
        }

        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dSWIN.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dSAppComercial.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.FillBy(this.dSWIN.Departamento);
            departamentoComboBox.SelectedIndex = -1;
            departamentoComboBox.Enabled = false;
        }

        private void todosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (todosCheckBox.Checked)
            {
                departamentoComboBox.Enabled = false;
            }
            else
            {
                departamentoComboBox.Enabled = true;
            }
        }       
    }
}
