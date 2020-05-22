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

namespace sistemaRestaurante.Vistas.Administrador.Productos
{
    public partial class FrmListadoProductos : Form
    {
        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            using(RestauranteEntities1 bd = new RestauranteEntities1())
            {
                var JoinProd = from producto in bd.ProductosVenta

                               select new
                               {
                                   ID = producto.idProductoV,
                                   NOMBRE = producto.nombre,
                                   PRECIO = producto.precio,
                                   CATEGORIA = producto.categoria
                               };

                foreach(var iterar in JoinProd)
                {
                    dtvProductos.Rows.Add(iterar.ID, iterar.NOMBRE, iterar.PRECIO, iterar.CATEGORIA);
                }
            }
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
