﻿using System;
using System.Windows.Forms;

namespace WinAppComercial.WIN
{
    public partial class frmTiposDocumento : Form
    {
        public frmTiposDocumento()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------
        private void frmTiposDocumento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Proveedor' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSWIN.TipoDocumento);
            dgvDatos.AutoResizeColumns();
        }

        //-----------------------------------------------------------------------------------------
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.tipoDocumentoBindingSource.EndEdit();
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
            this.tipoDocumentoBindingSource.CancelEdit();
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
            tipoDocumentoBindingSource.AddNew();
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

            this.Validate();
            this.tipoDocumentoBindingSource.RemoveAt(tipoDocumentoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSWIN);
        }
    }
}
