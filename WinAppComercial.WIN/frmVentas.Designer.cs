
namespace WinAppComercial.WIN
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eliminarTodoButton = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalNetoTextBox = new System.Windows.Forms.TextBox();
            this.totalDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.totalIVATextBox = new System.Windows.Forms.TextBox();
            this.totalBrutoTextBox = new System.Windows.Forms.TextBox();
            this.totalItemTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.porcentajeDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.eliminarLineaButton = new System.Windows.Forms.Button();
            this.agregarButton = new System.Windows.Forms.Button();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bodegaComboBox = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.productoLabel = new System.Windows.Forms.Label();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dSWIN = new WinAppComercial.WIN.DSWIN();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.ClienteTableAdapter();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.BodegaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminarTodoButton
            // 
            this.eliminarTodoButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarTodoButton.Image")));
            this.eliminarTodoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarTodoButton.Location = new System.Drawing.Point(866, 142);
            this.eliminarTodoButton.Name = "eliminarTodoButton";
            this.eliminarTodoButton.Size = new System.Drawing.Size(132, 48);
            this.eliminarTodoButton.TabIndex = 89;
            this.eliminarTodoButton.Text = "Elim. Todo";
            this.eliminarTodoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarTodoButton.UseVisualStyleBackColor = true;
            this.eliminarTodoButton.Click += new System.EventHandler(this.eliminarTodoButton_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(590, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 48);
            this.btnCancelar.TabIndex = 87;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(452, 142);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(132, 48);
            this.btnGrabar.TabIndex = 86;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(979, 602);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 96;
            this.label14.Text = "Valor IVA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1182, 600);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 100;
            this.label13.Text = "Valor Neto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1085, 600);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 98;
            this.label12.Text = "Valor Desc.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1085, 600);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 103;
            this.label11.Text = "Valor IVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(873, 602);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 94;
            this.label10.Text = "Valor Bruto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(772, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 92;
            this.label9.Text = "Items";
            // 
            // totalNetoTextBox
            // 
            this.totalNetoTextBox.Location = new System.Drawing.Point(1182, 622);
            this.totalNetoTextBox.Name = "totalNetoTextBox";
            this.totalNetoTextBox.ReadOnly = true;
            this.totalNetoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalNetoTextBox.TabIndex = 101;
            this.totalNetoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalDescuentoTextBox
            // 
            this.totalDescuentoTextBox.Location = new System.Drawing.Point(1076, 622);
            this.totalDescuentoTextBox.Name = "totalDescuentoTextBox";
            this.totalDescuentoTextBox.ReadOnly = true;
            this.totalDescuentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalDescuentoTextBox.TabIndex = 99;
            this.totalDescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalIVATextBox
            // 
            this.totalIVATextBox.Location = new System.Drawing.Point(970, 622);
            this.totalIVATextBox.Name = "totalIVATextBox";
            this.totalIVATextBox.ReadOnly = true;
            this.totalIVATextBox.Size = new System.Drawing.Size(100, 22);
            this.totalIVATextBox.TabIndex = 97;
            this.totalIVATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalBrutoTextBox
            // 
            this.totalBrutoTextBox.Location = new System.Drawing.Point(863, 622);
            this.totalBrutoTextBox.Name = "totalBrutoTextBox";
            this.totalBrutoTextBox.ReadOnly = true;
            this.totalBrutoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalBrutoTextBox.TabIndex = 95;
            this.totalBrutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalItemTextBox
            // 
            this.totalItemTextBox.Location = new System.Drawing.Point(757, 622);
            this.totalItemTextBox.Name = "totalItemTextBox";
            this.totalItemTextBox.ReadOnly = true;
            this.totalItemTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalItemTextBox.TabIndex = 93;
            this.totalItemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(684, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 91;
            this.label8.Text = "Totales:";
            // 
            // porcentajeDescuentoTextBox
            // 
            this.porcentajeDescuentoTextBox.Location = new System.Drawing.Point(127, 197);
            this.porcentajeDescuentoTextBox.Name = "porcentajeDescuentoTextBox";
            this.porcentajeDescuentoTextBox.Size = new System.Drawing.Size(141, 22);
            this.porcentajeDescuentoTextBox.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "% Descuento:";
            // 
            // precioTextBox
            // 
            this.precioTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.precioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.ForeColor = System.Drawing.Color.Blue;
            this.precioTextBox.Location = new System.Drawing.Point(127, 169);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(141, 22);
            this.precioTextBox.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 84;
            this.label6.Text = "Precio:";
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Location = new System.Drawing.Point(9, 269);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1298, 328);
            this.dgvDatos.TabIndex = 90;
            // 
            // eliminarLineaButton
            // 
            this.eliminarLineaButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarLineaButton.Image")));
            this.eliminarLineaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarLineaButton.Location = new System.Drawing.Point(728, 143);
            this.eliminarLineaButton.Name = "eliminarLineaButton";
            this.eliminarLineaButton.Size = new System.Drawing.Size(132, 48);
            this.eliminarLineaButton.TabIndex = 88;
            this.eliminarLineaButton.Text = "Elim. Línea";
            this.eliminarLineaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarLineaButton.UseVisualStyleBackColor = true;
            this.eliminarLineaButton.Click += new System.EventHandler(this.eliminarLineaButton_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarButton.Image")));
            this.agregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarButton.Location = new System.Drawing.Point(313, 141);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(132, 48);
            this.agregarButton.TabIndex = 81;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(127, 141);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(141, 22);
            this.cantidadTextBox.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Cantidad:";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataSource = this.clienteBindingSource;
            this.clienteComboBox.DisplayMember = "NombreComercial";
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(127, 51);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(323, 24);
            this.clienteComboBox.TabIndex = 71;
            this.clienteComboBox.ValueMember = "IDCliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Location = new System.Drawing.Point(127, 23);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.fechaDateTimePicker.TabIndex = 69;
            // 
            // bodegaComboBox
            // 
            this.bodegaComboBox.DataSource = this.bodegaBindingSource;
            this.bodegaComboBox.DisplayMember = "Descripcion";
            this.bodegaComboBox.FormattingEnabled = true;
            this.bodegaComboBox.Location = new System.Drawing.Point(127, 81);
            this.bodegaComboBox.Name = "bodegaComboBox";
            this.bodegaComboBox.Size = new System.Drawing.Size(263, 24);
            this.bodegaComboBox.TabIndex = 74;
            this.bodegaComboBox.ValueMember = "IDBodega";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(491, 51);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarCliente.TabIndex = 72;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Bodega:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(313, 110);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarProducto.TabIndex = 82;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Producto:";
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(1018, 14);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(277, 249);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 102;
            this.pbxImagen.TabStop = false;
            // 
            // productoLabel
            // 
            this.productoLabel.AutoSize = true;
            this.productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLabel.ForeColor = System.Drawing.Color.Blue;
            this.productoLabel.Location = new System.Drawing.Point(364, 115);
            this.productoLabel.Name = "productoLabel";
            this.productoLabel.Size = new System.Drawing.Size(190, 17);
            this.productoLabel.TabIndex = 83;
            this.productoLabel.Text = "Descripción del Producto";
            // 
            // productoTextBox
            // 
            this.productoTextBox.Location = new System.Drawing.Point(127, 111);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(141, 22);
            this.productoTextBox.TabIndex = 76;
            this.productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.productoTextBox_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dSWIN
            // 
            this.dSWIN.DataSetName = "DSWIN";
            this.dSWIN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSWIN;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSWIN;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1316, 659);
            this.Controls.Add(this.eliminarTodoButton);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalNetoTextBox);
            this.Controls.Add(this.totalDescuentoTextBox);
            this.Controls.Add(this.totalIVATextBox);
            this.Controls.Add(this.totalBrutoTextBox);
            this.Controls.Add(this.totalItemTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.porcentajeDescuentoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.eliminarLineaButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.bodegaComboBox);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.productoLabel);
            this.Controls.Add(this.productoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--- Ventas ---";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminarTodoButton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalNetoTextBox;
        private System.Windows.Forms.TextBox totalDescuentoTextBox;
        private System.Windows.Forms.TextBox totalIVATextBox;
        private System.Windows.Forms.TextBox totalBrutoTextBox;
        private System.Windows.Forms.TextBox totalItemTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox porcentajeDescuentoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button eliminarLineaButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox bodegaComboBox;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label productoLabel;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DSWIN dSWIN;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DSWINTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSWINTableAdapters.BodegaTableAdapter bodegaTableAdapter;
    }
}