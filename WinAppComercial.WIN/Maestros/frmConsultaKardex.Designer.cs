
namespace WinAppComercial.WIN
{
    partial class frmConsultaKardex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaKardex));
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.productoLabel = new System.Windows.Forms.Label();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bodegaComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSWIN = new WinAppComercial.WIN.DSWIN();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.kardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bodegaTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.BodegaTableAdapter();
            this.kardexTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.KardexTableAdapter();
            this.iDKardexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPromedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(677, 6);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(277, 249);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 33;
            this.pbxImagen.TabStop = false;
            // 
            // productoLabel
            // 
            this.productoLabel.AutoSize = true;
            this.productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLabel.ForeColor = System.Drawing.Color.Blue;
            this.productoLabel.Location = new System.Drawing.Point(284, 42);
            this.productoLabel.Name = "productoLabel";
            this.productoLabel.Size = new System.Drawing.Size(190, 17);
            this.productoLabel.TabIndex = 32;
            this.productoLabel.Text = "Descripción del Producto";
            // 
            // productoTextBox
            // 
            this.productoTextBox.Location = new System.Drawing.Point(95, 38);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(100, 22);
            this.productoTextBox.TabIndex = 30;
            this.productoTextBox.Validated += new System.EventHandler(this.productoTextBox_Validated);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(233, 37);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarProducto.TabIndex = 31;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Producto:";
            // 
            // bodegaComboBox
            // 
            this.bodegaComboBox.DataSource = this.bodegaBindingSource;
            this.bodegaComboBox.DisplayMember = "Descripcion";
            this.bodegaComboBox.FormattingEnabled = true;
            this.bodegaComboBox.Location = new System.Drawing.Point(95, 8);
            this.bodegaComboBox.Name = "bodegaComboBox";
            this.bodegaComboBox.Size = new System.Drawing.Size(263, 24);
            this.bodegaComboBox.TabIndex = 28;
            this.bodegaComboBox.ValueMember = "IDBodega";
            this.bodegaComboBox.SelectedIndexChanged += new System.EventHandler(this.bodegaComboBox_SelectedIndexChanged);
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSWIN;
            // 
            // dSWIN
            // 
            this.dSWIN.DataSetName = "DSWIN";
            this.dSWIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bodega:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKardexDataGridViewTextBoxColumn,
            this.iDBodegaDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.ultimoCostoDataGridViewTextBoxColumn,
            this.costoPromedioDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.kardexBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDatos.Location = new System.Drawing.Point(1, 261);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(953, 407);
            this.dgvDatos.TabIndex = 26;
            // 
            // kardexBindingSource
            // 
            this.kardexBindingSource.DataMember = "Kardex";
            this.kardexBindingSource.DataSource = this.dSWIN;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // kardexTableAdapter
            // 
            this.kardexTableAdapter.ClearBeforeFill = true;
            // 
            // iDKardexDataGridViewTextBoxColumn
            // 
            this.iDKardexDataGridViewTextBoxColumn.DataPropertyName = "IDKardex";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDKardexDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDKardexDataGridViewTextBoxColumn.HeaderText = "ID Kardex";
            this.iDKardexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDKardexDataGridViewTextBoxColumn.Name = "iDKardexDataGridViewTextBoxColumn";
            this.iDKardexDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDKardexDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDBodegaDataGridViewTextBoxColumn
            // 
            this.iDBodegaDataGridViewTextBoxColumn.DataPropertyName = "IDBodega";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDBodegaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDBodegaDataGridViewTextBoxColumn.HeaderText = "ID Bodega";
            this.iDBodegaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBodegaDataGridViewTextBoxColumn.Name = "iDBodegaDataGridViewTextBoxColumn";
            this.iDBodegaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBodegaDataGridViewTextBoxColumn.Visible = false;
            this.iDBodegaDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.iDProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn.Visible = false;
            this.iDProductoDataGridViewTextBoxColumn.Width = 80;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 160;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.documentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.entradaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.entradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            this.entradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salidaDataGridViewTextBoxColumn
            // 
            this.salidaDataGridViewTextBoxColumn.DataPropertyName = "Salida";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.salidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.salidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.salidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salidaDataGridViewTextBoxColumn.Name = "salidaDataGridViewTextBoxColumn";
            this.salidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.saldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultimoCostoDataGridViewTextBoxColumn
            // 
            this.ultimoCostoDataGridViewTextBoxColumn.DataPropertyName = "UltimoCosto";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            this.ultimoCostoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.ultimoCostoDataGridViewTextBoxColumn.HeaderText = "Ultimo Costo";
            this.ultimoCostoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ultimoCostoDataGridViewTextBoxColumn.Name = "ultimoCostoDataGridViewTextBoxColumn";
            this.ultimoCostoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultimoCostoDataGridViewTextBoxColumn.Width = 120;
            // 
            // costoPromedioDataGridViewTextBoxColumn
            // 
            this.costoPromedioDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedio";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.costoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.costoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio";
            this.costoPromedioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoPromedioDataGridViewTextBoxColumn.Name = "costoPromedioDataGridViewTextBoxColumn";
            this.costoPromedioDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoPromedioDataGridViewTextBoxColumn.Width = 120;
            // 
            // frmConsultaKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(961, 670);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.productoLabel);
            this.Controls.Add(this.productoTextBox);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bodegaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaKardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--- Consulta Kardex ---";
            this.Load += new System.EventHandler(this.frmConsultaKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label productoLabel;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bodegaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DSWIN dSWIN;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSWINTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.BindingSource kardexBindingSource;
        private DSWINTableAdapters.KardexTableAdapter kardexTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKardexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoCostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPromedioDataGridViewTextBoxColumn;
    }
}