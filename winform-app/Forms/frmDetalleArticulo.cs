using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;

        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Ver Detalle Articulo";
        }

        private void frmDetalleArticulo_Load_1(object sender, EventArgs e)
        {
            txtBoxDetalleNombre.Text = articulo.Nombre;
            txtBoxDetalleMarca.Text = articulo.Marca.Nombre;
            txtBoxDetalleCategoria.Text = articulo.Categoria.Descripcion;
            txtBoxDetallePrecio.Text = Math.Round(Convert.ToDecimal(articulo.Precio), 2).ToString();
            txtBoxDetalleDescrip.Text = articulo.Descripcion;
            cargarImagen(articulo.ImagenUrl);

        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pboxDetalle.Load(imagen);


            }
            catch (Exception)
            {
                pboxDetalle.Load("https://cdn.shopify.com/s/files/1/0533/2089/files/placeholder-images-image_large.png?format=jpg&quality=90&v=1530129081");
            }
        }

        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}