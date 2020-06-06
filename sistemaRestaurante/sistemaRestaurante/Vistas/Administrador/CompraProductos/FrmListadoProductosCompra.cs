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

namespace sistemaRestaurante.Vistas.Administrador.CompraProductos
{
    public partial class FrmListadoProductosCompra : Form
    {
        public FrmListadoProductosCompra()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var JoinProd = from prod in bd.ProductosCompra
                               from provee in bd.Proveedores
                               from categoria in bd.Categorias
                               where prod.idProveedor == provee.idProveedor
                               where prod.idCategoria == categoria.idCategoria

                               select new
                               {
                                   ID = prod.idProductoC,
                                   NOMBRE = prod.nombre,
                                   PRECIO = prod.precio,
                                   PROVEEDOR = provee.nombre,
                                   CATEGORIA = categoria.nombreCategoria,
                                   ESTADO = prod.estado
                               };

                foreach (var iterar in JoinProd)
                {
                    dtvProductos.Rows.Add(iterar.ID, iterar.NOMBRE, iterar.PRECIO, iterar.PROVEEDOR, iterar.CATEGORIA, iterar.ESTADO);
                }
            }
        }
        private void FrmListadoProductosCompra_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvProductos.Rows.Clear();
            CargarDatos();
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            FrmCRUDProductosCompra prod = new FrmCRUDProductosCompra();
            prod.Show();
            prod.lblCodigo.Visible = false;
            prod.btnEditar.Visible = false;
            prod.btnEliminar.Visible = false;
        }

        private void btnEditarSelected_Click(object sender, EventArgs e)
        {
            FrmCRUDProductosCompra prod = new FrmCRUDProductosCompra();
            prod.Show();
            prod.lblCodigo.Visible = true;
            prod.btnEditar.Visible = true;
            prod.btnEliminar.Visible = false;
            prod.btnAgregar.Visible = false;
            prod.btnHabilitar.Visible = false;

            prod.txtNombreProdCompra.Enabled = true;
            prod.txtPrecioProd.Enabled = true;
            prod.cmbCategoria.Enabled = true;
            prod.cmbProveedor.Enabled = true;

            String id = dtvProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtvProductos.CurrentRow.Cells[2].Value.ToString();
            String Proveedor = dtvProductos.CurrentRow.Cells[3].Value.ToString();
            String Categoria = dtvProductos.CurrentRow.Cells[4].Value.ToString();
            String Estado = dtvProductos.CurrentRow.Cells[5].Value.ToString();

            prod.lblCodigo.Text = id;
            prod.txtNombreProdCompra.Text = Nombre;
            prod.txtPrecioProd.Text = Precio;
            prod.cmbCategoria.Text = Categoria;
            prod.cmbProveedor.Text = Proveedor;
            prod.txtEstado.Text = Estado;
        }

        private void btnEliminarSelected_Click(object sender, EventArgs e)
        {
            FrmCRUDProductosCompra prod = new FrmCRUDProductosCompra();
            prod.Show();
            prod.lblCodigo.Visible = true;
            prod.btnEditar.Visible = false;
            prod.btnEliminar.Visible = true;
            prod.btnAgregar.Visible = false;
            prod.btnHabilitar.Visible = false;

            prod.txtNombreProdCompra.Enabled = false;
            prod.txtPrecioProd.Enabled = false;
            prod.cmbCategoria.Enabled = false;
            prod.cmbProveedor.Enabled = false;

            String id = dtvProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtvProductos.CurrentRow.Cells[2].Value.ToString();
            String Proveedor = dtvProductos.CurrentRow.Cells[3].Value.ToString();
            String Categoria = dtvProductos.CurrentRow.Cells[4].Value.ToString();
            String Estado = dtvProductos.CurrentRow.Cells[5].Value.ToString();

            prod.lblCodigo.Text = id;
            prod.txtNombreProdCompra.Text = Nombre;
            prod.txtPrecioProd.Text = Precio;
            prod.cmbCategoria.Text = Categoria;
            prod.cmbProveedor.Text = Proveedor;
            prod.txtEstado.Text = Estado;
        }
    }
}
