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

namespace sistemaRestaurante.Vistas.Administrador.Ventas
{
    public partial class FrmProdsAVender : Form
    {
        public FrmProdsAVender()
        {
            InitializeComponent();
        }

        public void CargarTabla()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var JoinProd = from prod in bd.ProductosVenta
                               from categoria in bd.Categorias
                               where prod.idCategoria == categoria.idCategoria

                               select new
                               {
                                   ID = prod.idProductoV,
                                   NOMBRE = prod.nombre,
                                   PRECIO = prod.precio,
                                   CATEGORIA = categoria.nombreCategoria
                               };

                foreach (var iterar in JoinProd)
                {
                    dtvDetallesVenta.Rows.Add(iterar.ID, iterar.NOMBRE, iterar.PRECIO, iterar.CATEGORIA);
                }
            }
        }

        public void Filtro()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var JoinProd = from prod in bd.ProductosVenta
                               from categoria in bd.Categorias
                               where prod.idCategoria == categoria.idCategoria
                               where prod.nombre.Contains(txtBusqueda.Text)

                               select new
                               {
                                   ID = prod.idProductoV,
                                   NOMBRE = prod.nombre,
                                   PRECIO = prod.precio,
                                   CATEGORIA = categoria.nombreCategoria
                               };

                foreach (var iterar in JoinProd)
                {
                    var listaR = from recetas in bd.Recetas
                                 where recetas.idProductoV == iterar.ID
                                 select recetas;

                    if (listaR.Count() > 0)
                    {
                        dtvDetallesVenta.Rows.Add(iterar.ID, iterar.NOMBRE, iterar.PRECIO, iterar.CATEGORIA);
                    }
                }
            }
        }

        public void Envio()
        {
            String id = dtvDetallesVenta.CurrentRow.Cells[0].Value.ToString();
            String nombreProd = dtvDetallesVenta.CurrentRow.Cells[1].Value.ToString();
            String precio = dtvDetallesVenta.CurrentRow.Cells[2].Value.ToString();

            FrmAccesoAdmin.venta.txtCodigoProd.Text = id;
            FrmAccesoAdmin.venta.txtNombreProd.Text = nombreProd;
            FrmAccesoAdmin.venta.txtPrecio.Text = precio;

            FrmAccesoUsuario.venta.txtCodigoProd.Text = id;
            FrmAccesoUsuario.venta.txtNombreProd.Text = nombreProd;
            FrmAccesoUsuario.venta.txtPrecio.Text = precio;

            FrmAccesoUsuario.venta.nupCantidad.Focus();
            FrmAccesoAdmin.venta.nupCantidad.Focus();
        }

        private void FrmProdsAVender_Load(object sender, EventArgs e)
        {
            Filtro();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtvDetallesVenta.Rows.Clear();
            Filtro();
        }


        private void dtvDetallesCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Envio();
            this.Close();
            FrmAccesoAdmin.compras.nupCantidad.Value = 0;
        }

        private void dtvDetallesCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Envio();
                this.Close();
                FrmAccesoAdmin.compras.nupCantidad.Value = 0;
            }
        }
    }
}
