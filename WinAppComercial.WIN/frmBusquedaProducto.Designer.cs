
namespace WinAppComercial.WIN
{
    partial class frmBusquedaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarFiltros = new System.Windows.Forms.Button();
            this.rbtIgual = new System.Windows.Forms.RadioButton();
            this.rbtTermina = new System.Windows.Forms.RadioButton();
            this.rbtEmpiece = new System.Windows.Forms.RadioButton();
            this.rbtContenga = new System.Windows.Forms.RadioButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.descripcionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.descripcionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSWIN = new WinAppComercial.WIN.DSWIN();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.ProductoTableAdapter();
            this.departamentoTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.DepartamentoTableAdapter();
            this.iVATableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.IVATableAdapter();
            this.medidaTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.MedidaTableAdapter();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(733, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 60);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(615, 48);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 60);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarFiltros);
            this.groupBox1.Controls.Add(this.rbtIgual);
            this.groupBox1.Controls.Add(this.rbtTermina);
            this.groupBox1.Controls.Add(this.rbtEmpiece);
            this.groupBox1.Controls.Add(this.rbtContenga);
            this.groupBox1.Location = new System.Drawing.Point(9, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 56);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo criterio";
            // 
            // btnQuitarFiltros
            // 
            this.btnQuitarFiltros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitarFiltros.Location = new System.Drawing.Point(466, 12);
            this.btnQuitarFiltros.Name = "btnQuitarFiltros";
            this.btnQuitarFiltros.Size = new System.Drawing.Size(128, 38);
            this.btnQuitarFiltros.TabIndex = 8;
            this.btnQuitarFiltros.Text = "&Quitar Filtros";
            this.btnQuitarFiltros.UseVisualStyleBackColor = true;
            this.btnQuitarFiltros.Click += new System.EventHandler(this.btnQuitarFiltros_Click);
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.Location = new System.Drawing.Point(381, 22);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(79, 21);
            this.rbtIgual.TabIndex = 3;
            this.rbtIgual.Text = "Igual a…";
            this.rbtIgual.UseVisualStyleBackColor = true;
            // 
            // rbtTermina
            // 
            this.rbtTermina.AutoSize = true;
            this.rbtTermina.Location = new System.Drawing.Point(255, 22);
            this.rbtTermina.Name = "rbtTermina";
            this.rbtTermina.Size = new System.Drawing.Size(109, 21);
            this.rbtTermina.TabIndex = 2;
            this.rbtTermina.Text = "Termina en…";
            this.rbtTermina.UseVisualStyleBackColor = true;
            // 
            // rbtEmpiece
            // 
            this.rbtEmpiece.AutoSize = true;
            this.rbtEmpiece.Location = new System.Drawing.Point(133, 22);
            this.rbtEmpiece.Name = "rbtEmpiece";
            this.rbtEmpiece.Size = new System.Drawing.Size(116, 21);
            this.rbtEmpiece.TabIndex = 1;
            this.rbtEmpiece.Text = "Empiece por…";
            this.rbtEmpiece.UseVisualStyleBackColor = true;
            // 
            // rbtContenga
            // 
            this.rbtContenga.AutoSize = true;
            this.rbtContenga.Checked = true;
            this.rbtContenga.Location = new System.Drawing.Point(20, 22);
            this.rbtContenga.Name = "rbtContenga";
            this.rbtContenga.Size = new System.Drawing.Size(98, 21);
            this.rbtContenga.TabIndex = 0;
            this.rbtContenga.TabStop = true;
            this.rbtContenga.Text = "Contenga…";
            this.rbtContenga.UseVisualStyleBackColor = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descripcionToolStripLabel,
            this.descripcionToolStripTextBox,
            this.tsbBuscar});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1317, 31);
            this.fillByToolStrip.TabIndex = 12;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // descripcionToolStripLabel
            // 
            this.descripcionToolStripLabel.Name = "descripcionToolStripLabel";
            this.descripcionToolStripLabel.Size = new System.Drawing.Size(90, 28);
            this.descripcionToolStripLabel.Text = "Descripción:";
            // 
            // descripcionToolStripTextBox
            // 
            this.descripcionToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descripcionToolStripTextBox.Name = "descripcionToolStripTextBox";
            this.descripcionToolStripTextBox.Size = new System.Drawing.Size(100, 31);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(29, 28);
            this.tsbBuscar.Text = "FillBy";
            this.tsbBuscar.ToolTipText = "Aplica los criterios de búsqueda seleccionados";
            this.tsbBuscar.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.iDDepartamentoDataGridViewTextBoxColumn,
            this.iDIVADataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn,
            this.imagenDataGridViewTextBoxColumn,
            this.iDMedidaDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.productoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.Location = new System.Drawing.Point(1, 118);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1296, 541);
            this.dgvDatos.TabIndex = 11;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dSWIN;
            // 
            // dSWIN
            // 
            this.dSWIN.DataSetName = "DSWIN";
            this.dSWIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSWIN;
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataMember = "Medida";
            this.medidaBindingSource.DataSource = this.dSWIN;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSWIN;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // medidaTableAdapter
            // 
            this.medidaTableAdapter.ClearBeforeFill = true;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.iDProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDepartamentoDataGridViewTextBoxColumn
            // 
            this.iDDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IDDepartamento";
            this.iDDepartamentoDataGridViewTextBoxColumn.DataSource = this.departamentoBindingSource;
            this.iDDepartamentoDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDDepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.iDDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDepartamentoDataGridViewTextBoxColumn.Name = "iDDepartamentoDataGridViewTextBoxColumn";
            this.iDDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDepartamentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDepartamentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDepartamentoDataGridViewTextBoxColumn.ValueMember = "IDDepartamento";
            this.iDDepartamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDIVADataGridViewTextBoxColumn
            // 
            this.iDIVADataGridViewTextBoxColumn.DataPropertyName = "IDIVA";
            this.iDIVADataGridViewTextBoxColumn.DataSource = this.iVABindingSource;
            this.iDIVADataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDIVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iDIVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDIVADataGridViewTextBoxColumn.Name = "iDIVADataGridViewTextBoxColumn";
            this.iDIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDIVADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDIVADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDIVADataGridViewTextBoxColumn.ValueMember = "IDIVA";
            this.iDIVADataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            this.notasDataGridViewTextBoxColumn.Width = 125;
            // 
            // imagenDataGridViewTextBoxColumn
            // 
            this.imagenDataGridViewTextBoxColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewTextBoxColumn.HeaderText = "Imagen";
            this.imagenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imagenDataGridViewTextBoxColumn.Name = "imagenDataGridViewTextBoxColumn";
            this.imagenDataGridViewTextBoxColumn.ReadOnly = true;
            this.imagenDataGridViewTextBoxColumn.Visible = false;
            this.imagenDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDMedidaDataGridViewTextBoxColumn
            // 
            this.iDMedidaDataGridViewTextBoxColumn.DataPropertyName = "IDMedida";
            this.iDMedidaDataGridViewTextBoxColumn.DataSource = this.medidaBindingSource;
            this.iDMedidaDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.iDMedidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDMedidaDataGridViewTextBoxColumn.Name = "iDMedidaDataGridViewTextBoxColumn";
            this.iDMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMedidaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDMedidaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDMedidaDataGridViewTextBoxColumn.ValueMember = "IDMedida";
            this.iDMedidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "Medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.medidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmBusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1317, 669);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--- Búsqueda de Producto ---";
            this.Load += new System.EventHandler(this.frmBusquedaProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitarFiltros;
        private System.Windows.Forms.RadioButton rbtIgual;
        private System.Windows.Forms.RadioButton rbtTermina;
        private System.Windows.Forms.RadioButton rbtEmpiece;
        private System.Windows.Forms.RadioButton rbtContenga;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel descripcionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox descripcionToolStripTextBox;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private DSWIN dSWIN;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSWINTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DSWINTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSWINTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private DSWINTableAdapters.MedidaTableAdapter medidaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
    }
}