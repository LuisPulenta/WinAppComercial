
namespace WinAppComercial.WIN
{
    partial class frmClientesTemp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesTemp));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrimero = new System.Windows.Forms.ToolStripButton();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.tsbSiguiente = new System.Windows.Forms.ToolStripButton();
            this.tsbUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSWIN = new WinAppComercial.WIN.DSWIN();
            this.tipoDocumentoTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.TipoDocumentoTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoContacto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpAniversario = new System.Windows.Forms.DateTimePicker();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrimero,
            this.tsbAnterior,
            this.tsbSiguiente,
            this.tsbUltimo,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbBorrar,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1235, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrimero
            // 
            this.tsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimero.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrimero.Image")));
            this.tsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimero.Name = "tsbPrimero";
            this.tsbPrimero.Size = new System.Drawing.Size(29, 24);
            this.tsbPrimero.Text = "toolStripButton1";
            this.tsbPrimero.ToolTipText = "Primer Registro";
            this.tsbPrimero.Click += new System.EventHandler(this.tsbPrimero_Click);
            // 
            // tsbAnterior
            // 
            this.tsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnterior.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnterior.Image")));
            this.tsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnterior.Name = "tsbAnterior";
            this.tsbAnterior.Size = new System.Drawing.Size(29, 24);
            this.tsbAnterior.Text = "toolStripButton2";
            this.tsbAnterior.ToolTipText = "Registro Anterior";
            this.tsbAnterior.Click += new System.EventHandler(this.tsbAnterior_Click);
            // 
            // tsbSiguiente
            // 
            this.tsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("tsbSiguiente.Image")));
            this.tsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSiguiente.Name = "tsbSiguiente";
            this.tsbSiguiente.Size = new System.Drawing.Size(29, 24);
            this.tsbSiguiente.Text = "toolStripButton3";
            this.tsbSiguiente.ToolTipText = "Registro Siguiente";
            this.tsbSiguiente.Click += new System.EventHandler(this.tsbSiguiente_Click);
            // 
            // tsbUltimo
            // 
            this.tsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUltimo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUltimo.Image")));
            this.tsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUltimo.Name = "tsbUltimo";
            this.tsbUltimo.Size = new System.Drawing.Size(29, 24);
            this.tsbUltimo.Text = "toolStripButton4";
            this.tsbUltimo.ToolTipText = "Ultimo Registro";
            this.tsbUltimo.Click += new System.EventHandler(this.tsbUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(29, 24);
            this.tsbNuevo.Text = "toolStripButton5";
            this.tsbNuevo.ToolTipText = "Nuevo Registro";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(29, 24);
            this.tsbEditar.Text = "toolStripButton6";
            this.tsbEditar.ToolTipText = "Editar Registro";
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBorrar.Image")));
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(29, 24);
            this.tsbBorrar.Text = "toolStripButton7";
            this.tsbBorrar.ToolTipText = "Borrar Registro";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(29, 24);
            this.tsbGuardar.Text = "toolStripButton8";
            this.tsbGuardar.ToolTipText = "Guardar Cambios";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(29, 24);
            this.tsbCancelar.Text = "toolStripButton9";
            this.tsbCancelar.ToolTipText = "Cancelar Cambios";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(29, 24);
            this.tsbBuscar.Text = "toolStripButton10";
            this.tsbBuscar.ToolTipText = "Buscar Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(41, 42);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(76, 22);
            this.txtIdCliente.TabIndex = 2;
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.BackColor = System.Drawing.Color.Aquamarine;
            this.cbTipoDocumento.DataSource = this.tipoDocumentoBindingSource;
            this.cbTipoDocumento.DisplayMember = "Descripcion";
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(287, 41);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(202, 24);
            this.cbTipoDocumento.TabIndex = 3;
            this.cbTipoDocumento.ValueMember = "IDTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSWIN;
            // 
            // dSWIN
            // 
            this.dSWIN.DataSetName = "DSWIN";
            this.dSWIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documento:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.Aquamarine;
            this.txtDocumento.Location = new System.Drawing.Point(600, 42);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(114, 22);
            this.txtDocumento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre Comercial:";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.BackColor = System.Drawing.Color.Aquamarine;
            this.txtNombreComercial.Location = new System.Drawing.Point(146, 76);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.ReadOnly = true;
            this.txtNombreComercial.Size = new System.Drawing.Size(343, 22);
            this.txtNombreComercial.TabIndex = 9;
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.BackColor = System.Drawing.Color.Aquamarine;
            this.txtNombreContacto.Location = new System.Drawing.Point(618, 76);
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.ReadOnly = true;
            this.txtNombreContacto.Size = new System.Drawing.Size(215, 22);
            this.txtNombreContacto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre Contacto:";
            // 
            // txtApellidoContacto
            // 
            this.txtApellidoContacto.BackColor = System.Drawing.Color.Aquamarine;
            this.txtApellidoContacto.Location = new System.Drawing.Point(994, 76);
            this.txtApellidoContacto.Name = "txtApellidoContacto";
            this.txtApellidoContacto.ReadOnly = true;
            this.txtApellidoContacto.Size = new System.Drawing.Size(215, 22);
            this.txtApellidoContacto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(860, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apellido Contacto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(498, 112);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(105, 22);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(709, 112);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(105, 22);
            this.txtCelular.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(635, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Celular:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(937, 112);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(272, 22);
            this.txtCorreo.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(860, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Correo:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(89, 112);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(272, 22);
            this.txtDireccion.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Aniversario:";
            // 
            // dtpAniversario
            // 
            this.dtpAniversario.Location = new System.Drawing.Point(89, 147);
            this.dtpAniversario.Name = "dtpAniversario";
            this.dtpAniversario.Size = new System.Drawing.Size(274, 22);
            this.dtpAniversario.TabIndex = 24;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(471, 147);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ReadOnly = true;
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotas.Size = new System.Drawing.Size(738, 74);
            this.txtNotas.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(394, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Notas:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(0, 227);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1238, 430);
            this.dgvDatos.TabIndex = 27;
            // 
            // frmClientesTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1235, 656);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpAniversario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApellidoContacto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientesTemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--- Clientes ---";
            this.Load += new System.EventHandler(this.frmClientesTemp_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrimero;
        private System.Windows.Forms.ToolStripButton tsbAnterior;
        private System.Windows.Forms.ToolStripButton tsbSiguiente;
        private System.Windows.Forms.ToolStripButton tsbUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private DSWIN dSWIN;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSWINTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoContacto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpAniversario;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}