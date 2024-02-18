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
    public partial class frmClientesTemp : Form
    {
        public frmClientesTemp()
        {
            InitializeComponent();
        }

        private void frmClientesTemp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSWIN.TipoDocumento);

        }
    }
}
