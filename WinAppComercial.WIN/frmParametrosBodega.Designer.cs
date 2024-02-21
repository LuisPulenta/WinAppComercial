
namespace WinAppComercial.WIN
{
    partial class frmParametrosBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametrosBodega));
            this.cantidadMinimaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.diasReposicionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minimoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bodegaComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSWIN = new WinAppComercial.WIN.DSWIN();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bodegaTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.BodegaTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadMinimaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReposicionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadMinimaNumericUpDown
            // 
            this.cantidadMinimaNumericUpDown.Location = new System.Drawing.Point(445, 70);
            this.cantidadMinimaNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.cantidadMinimaNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidadMinimaNumericUpDown.Name = "cantidadMinimaNumericUpDown";
            this.cantidadMinimaNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.cantidadMinimaNumericUpDown.TabIndex = 36;
            this.cantidadMinimaNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // diasReposicionNumericUpDown
            // 
            this.diasReposicionNumericUpDown.Location = new System.Drawing.Point(145, 70);
            this.diasReposicionNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.diasReposicionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.diasReposicionNumericUpDown.Name = "diasReposicionNumericUpDown";
            this.diasReposicionNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.diasReposicionNumericUpDown.TabIndex = 35;
            this.diasReposicionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maximoNumericUpDown
            // 
            this.maximoNumericUpDown.Location = new System.Drawing.Point(445, 42);
            this.maximoNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.maximoNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maximoNumericUpDown.Name = "maximoNumericUpDown";
            this.maximoNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.maximoNumericUpDown.TabIndex = 34;
            this.maximoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minimoNumericUpDown
            // 
            this.minimoNumericUpDown.Location = new System.Drawing.Point(145, 42);
            this.minimoNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.minimoNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimoNumericUpDown.Name = "minimoNumericUpDown";
            this.minimoNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.minimoNumericUpDown.TabIndex = 33;
            this.minimoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bodegaComboBox
            // 
            this.bodegaComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.bodegaComboBox.DataSource = this.bodegaBindingSource;
            this.bodegaComboBox.DisplayMember = "Descripcion";
            this.bodegaComboBox.FormattingEnabled = true;
            this.bodegaComboBox.Location = new System.Drawing.Point(145, 12);
            this.bodegaComboBox.Name = "bodegaComboBox";
            this.bodegaComboBox.Size = new System.Drawing.Size(201, 24);
            this.bodegaComboBox.TabIndex = 32;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cant. Mín. a Ordenar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "&Días Repos.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cantidad Má&xima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cantidad &Mínima:";
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(445, 15);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(120, 22);
            this.stockTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Stock:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(302, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 60);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(179, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 60);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "&Bodega:";
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmParametrosBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(605, 237);
            this.Controls.Add(this.cantidadMinimaNumericUpDown);
            this.Controls.Add(this.diasReposicionNumericUpDown);
            this.Controls.Add(this.maximoNumericUpDown);
            this.Controls.Add(this.minimoNumericUpDown);
            this.Controls.Add(this.bodegaComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametrosBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--- Parámetros Bodega ---";
            this.Load += new System.EventHandler(this.frmParametrosBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadMinimaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReposicionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown cantidadMinimaNumericUpDown;
        private System.Windows.Forms.NumericUpDown diasReposicionNumericUpDown;
        private System.Windows.Forms.NumericUpDown maximoNumericUpDown;
        private System.Windows.Forms.NumericUpDown minimoNumericUpDown;
        private System.Windows.Forms.ComboBox bodegaComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private DSWIN dSWIN;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSWINTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}