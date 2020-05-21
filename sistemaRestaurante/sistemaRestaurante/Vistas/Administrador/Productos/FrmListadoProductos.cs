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
                var Productos = bd.Productos;

                foreach(var iterar in Productos)
                {
                    dtvProductos.Rows.Add(iterar.idProducto, iterar.Nombre, iterar.Precio, iterar.idCategoria);
                }
            }
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
