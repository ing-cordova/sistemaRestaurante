using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            using(RestauranteBDEntities bd = new RestauranteBDEntities())
            {
                var JoinProd = from producto in bd.ProductosVenta
                               from categoria in bd.Categorias
                               where producto.idCategoria == categoria.idCategoria
                               select new
                               {
                                   ID = producto.idProductoV,
                                   NOMBRE = producto.nombre,
                                   PRECIO = producto.precio,
                                   CATEGORIA = categoria.nombreCategoria
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

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            FrmCRUDProductos crud = new FrmCRUDProductos();
            crud.Show();
            crud.lblCodigo.Visible = false;
            crud.btnEliminar.Visible = false;
            crud.btnEditar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvProductos.Rows.Clear();
            CargarDatos();
        }

        private void btnEditarSelected_Click(object sender, EventArgs e)
        {
            FrmCRUDProductos crud = new FrmCRUDProductos();
            crud.Show();
            crud.lblCodigo.Visible = true;
            crud.btnEliminar.Visible = false;
            crud.btnEditar.Visible = true;
            crud.btnAgregar.Visible = false;
            crud.btnHabilitar.Visible = false;
            /***************************************/
            crud.txtNombreProd.Enabled = true;
            crud.txtPrecioProd.Enabled = true;
            crud.cmbCategoria.Enabled = true;
        }

        private void btnEliminarSelected_Click(object sender, EventArgs e)
        {
            FrmCRUDProductos crud = new FrmCRUDProductos();
            crud.Show();
            crud.lblCodigo.Visible = true;
            crud.btnEliminar.Visible = true;
            crud.btnEditar.Visible = false;
            crud.btnAgregar.Visible = false;
            crud.btnHabilitar.Visible = false;
            /***************************************/
            crud.txtNombreProd.Enabled = true;
            crud.txtPrecioProd.Enabled = true;
            crud.cmbCategoria.Enabled = true;
        }
    }
}
