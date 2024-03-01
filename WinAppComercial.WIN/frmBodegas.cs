using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmBodegas : Form
    {
        public frmBodegas()
        {
            InitializeComponent();
        }       

        //-----------------------------------------------------------------------------------------
        private void frmBodegas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Proveedor' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSWIN.Bodega);
            dgvDatos.AutoResizeColumns();
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.bodegaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSWIN);
            Habilitar(false);
        }

        //-----------------------------------------------------------------------------------------
        private void Habilitar(bool campo)
        {
            descripcionTextBox.ReadOnly = !campo;

            bindingNavigatorEditItem.Enabled = !campo;
            bindingNavigatorAddNewItem.Enabled = !campo;
            bindingNavigatorDeleteItem.Enabled = !campo;
            bindingNavigatorSaveItem.Enabled = campo;
            bindingNavigatorCancelItem.Enabled = campo;
            bindingNavigatorSearchItem.Enabled = !campo;

            bindingNavigatorMoveFirstItem.Enabled = !campo;
            bindingNavigatorMovePreviousItem.Enabled = !campo;
            bindingNavigatorMoveNextItem.Enabled = !campo;
            bindingNavigatorMoveLastItem.Enabled = !campo;
            bindingNavigatorPositionItem.Enabled = !campo;
            bindingNavigatorCountItem.Enabled = !campo;
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.bodegaBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        //-----------------------------------------------------------------------------------------
        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una Descripción");
                descripcionTextBox.Focus();
                return false;
            }
            return true;
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            bodegaBindingSource.AddNew();
            descripcionTextBox.Focus();
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
                "¿Está seguro de borrar el Registro actual?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            if (CADKardex.KardexBodegaTieneMovimientos(Convert.ToInt32(iDBodegaTextBox.Text)))
            {
                MessageBox.Show(
                    "No se puede borrar Bodega porque tiene movimientos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            this.Validate();
            this.bodegaBindingSource.RemoveAt(bodegaBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSWIN);
        }
    }
}
