using System;
using System.IO;
using System.Windows.Forms;
using WinAppComercial.CAD;

namespace WinAppComercial.WIN
{
    public partial class frmConsultaKardex : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmConsultaKardex()
        {
            InitializeComponent();
        }

        private void frmConsultaKardex_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Kardex' Puede moverla o quitarla según sea necesario.
            //this.kardexTableAdapter.Fill(this.dSWIN.Kardex);

            // TODO: esta línea de código carga datos en la tabla 'dSWIN.Bodega' Puede moverla o quitarla según sea necesario.
            bodegaTableAdapter.Fill(dSWIN.Bodega);
            bodegaTableAdapter.Fill(dSWIN.Bodega);
            bodegaComboBox.SelectedIndex = -1;
            //bodegaComboBox.SelectedValue = 0;
            productoLabel.Text = string.Empty;
            //this.kardexTableAdapter.FillBy(this.dSWIN.Kardex, ((int)(System.Convert.ChangeType(bodegaComboBox.SelectedValue, typeof(int)))), ((int)(System.Convert.ChangeType(productoTextBox.Text, typeof(int)))));
            dgvDatos.AutoResizeColumns();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0)
            {
                return;
            }

            productoTextBox.Text = miBusqueda.IDElegido.ToString();
            productoTextBox_Validated(sender, new System.ComponentModel.CancelEventArgs());
        }


        private void productoTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            pbxImagen.Image = null;
            if (productoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Código de Producto o un Código de Barras");
                return;
            }

            if (!long.TryParse(productoTextBox.Text, out long producto))
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un valor numérico");
                productoTextBox.Focus();
                return;
            }

            if (producto <= 0)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un valor mayor a 0");
                productoTextBox.Focus();
                return;
            }

            CADProducto miProducto = CADProducto.ProductoGetProductoByIDProducto((int)producto);
            if (miProducto == null)
            {
                miProducto = CADProducto.ProductoGetProductoByIDBarra(producto);
            }
            if (miProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Producto no existe");
                productoLabel.Text = string.Empty;
                pbxImagen.Image = null;
                return;
            }
            else
            {
                productoLabel.Text = miProducto.Descripcion;
                if (miProducto.Imagen == string.Empty)
                {
                    pbxImagen.Image = null;
                }
                else
                {

                    if (File.Exists("Images\\" + miProducto.Imagen))
                    {
                        if (miProducto.Imagen == string.Empty)
                        {
                            pbxImagen.Image = null;
                        }
                        else
                        {
                            if (File.Exists("Images\\" + miProducto.Imagen))
                            {
                                pbxImagen.Load("Images\\" + miProducto.Imagen);
                            }
                        }
                    }
                    else
                    {
                        pbxImagen.Image = null;
                    }
                }
            }
            productoTextBox.Text = miProducto.IDProducto.ToString();
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            if (bodegaComboBox.SelectedIndex == -1 || productoTextBox.Text == string.Empty)
            {
                return;
            }

            kardexTableAdapter.FillBy(dSWIN.Kardex, ((int)(System.Convert.ChangeType(bodegaComboBox.SelectedValue, typeof(int)))), ((int)(System.Convert.ChangeType(productoTextBox.Text, typeof(int)))));
            dgvDatos.AutoResizeColumns();
        }

        private void bodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

       
    }
}
