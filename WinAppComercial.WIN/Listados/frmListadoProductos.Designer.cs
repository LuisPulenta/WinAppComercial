
namespace WinAppComercial.WIN.Listados
{
    partial class frmListadoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoProductos));
            this.departamentoComboBox = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSWIN = new WinAppComercial.WIN.DSWIN();
            this.label1 = new System.Windows.Forms.Label();
            this.todosCheckBox = new System.Windows.Forms.CheckBox();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cachedcryListadoProductos1 = new WinAppComercial.WIN.Listados.CachedcryListadoProductos();
            this.departamentoTableAdapter = new WinAppComercial.WIN.DSWINTableAdapters.DepartamentoTableAdapter();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // departamentoComboBox
            // 
            this.departamentoComboBox.DataSource = this.departamentoBindingSource;
            this.departamentoComboBox.DisplayMember = "Descripcion";
            this.departamentoComboBox.FormattingEnabled = true;
            this.departamentoComboBox.Location = new System.Drawing.Point(227, 26);
            this.departamentoComboBox.Name = "departamentoComboBox";
            this.departamentoComboBox.Size = new System.Drawing.Size(308, 24);
            this.departamentoComboBox.TabIndex = 7;
            this.departamentoComboBox.ValueMember = "IDDepartamento";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Departamento:";
            // 
            // todosCheckBox
            // 
            this.todosCheckBox.AutoSize = true;
            this.todosCheckBox.Checked = true;
            this.todosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todosCheckBox.Location = new System.Drawing.Point(22, 28);
            this.todosCheckBox.Name = "todosCheckBox";
            this.todosCheckBox.Size = new System.Drawing.Size(70, 21);
            this.todosCheckBox.TabIndex = 4;
            this.todosCheckBox.Text = "Todos";
            this.todosCheckBox.UseVisualStyleBackColor = true;
            this.todosCheckBox.CheckedChanged += new System.EventHandler(this.todosCheckBox_CheckedChanged);
            // 
            // verReporteButton
            // 
            this.verReporteButton.Image = ((System.Drawing.Image)(resources.GetObject("verReporteButton.Image")));
            this.verReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verReporteButton.Location = new System.Drawing.Point(592, 14);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(143, 49);
            this.verReporteButton.TabIndex = 8;
            this.verReporteButton.Text = "Ver Reporte";
            this.verReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.verReporteButton.UseVisualStyleBackColor = true;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(10, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 678);
            this.panel1.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1343, 678);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 761);
            this.Controls.Add(this.departamentoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todosCheckBox);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--- Listado de Productos ---";
            this.Load += new System.EventHandler(this.frmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSWIN)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox departamentoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox todosCheckBox;
        private System.Windows.Forms.Button verReporteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CachedcryListadoProductos cachedcryListadoProductos1;
        private DSWIN dSWIN;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DSWINTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}