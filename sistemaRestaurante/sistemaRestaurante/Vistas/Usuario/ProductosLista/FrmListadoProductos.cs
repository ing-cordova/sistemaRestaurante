using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaRestaurante.Model;

namespace sistemaRestaurante.Vistas.Usuario.ProductosLista
{
    public partial class FrmListadoProductos : Form
    {
        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        public void Filtro()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                String nombre = txtBusqueda.Text;

                if (rbotNombre.Checked == true)
                {
                    var JoinProd = from producto in bd.ProductosVenta
                                   from categoria in bd.Categorias
                                   where producto.idCategoria == categoria.idCategoria
                                   where producto.nombre.Contains(nombre)

                                   select new
                                   {
                                       ID = producto.idProductoV,
                                       NOMBRE = producto.nombre,
                                       PRECIO = producto.precio,
                                       CATEGORIA = categoria.nombreCategoria
                                   };

                    dtvProductos.DataSource = JoinProd.ToList();
                }
                else if (rbotCategoria.Checked == true)
                {
                    var JoinProd = from producto in bd.ProductosVenta
                                   from categoria in bd.Categorias
                                   where producto.idCategoria == categoria.idCategoria
                                   where categoria.nombreCategoria.Contains(nombre)

                                   select new
                                   {
                                       ID = producto.idProductoV,
                                       NOMBRE = producto.nombre,
                                       PRECIO = producto.precio,
                                       CATEGORIA = categoria.nombreCategoria
                                   };

                    dtvProductos.DataSource = JoinProd.ToList();
                }
            }
        }
        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            Filtro();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Filtro();
        }

        private void rbotNombre_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
