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
            using(RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var JoinProd = from producto in bd.ProductosVenta
                               from categoria in bd.Categorias
                               where producto.idCategoria == categoria.idCategoria
                               where producto.estado == "Activo"
                               select new
                               {
                                   ID = producto.idProductoV,
                                   NOMBRE = producto.nombre,
                                   PRECIO = producto.precio,
                                   CATEGORIA = categoria.nombreCategoria,
                                   ESTADO = producto.estado
                               };

                foreach (var iterar in JoinProd)
                {
                    dtvProductos.Rows.Add(iterar.ID, iterar.NOMBRE, iterar.PRECIO, iterar.CATEGORIA, iterar.ESTADO);
                }
            }
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            if (dtvProductos.Rows.Count == 0)
            {
                btnEditarSelected.Enabled = false;
                btnEliminarSelected.Enabled = false;
            }
            else
            {
                btnEditarSelected.Enabled = true;
                btnEliminarSelected.Enabled = true;
                btnActualizar.PerformClick();
            }
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
            /************************************************************************/
            String id = dtvProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtvProductos.CurrentRow.Cells[2].Value.ToString();
            String Categoria = dtvProductos.CurrentRow.Cells[3].Value.ToString();

            crud.lblCodigo.Text = id;
            crud.txtNombreProd.Text = Nombre;
            crud.txtPrecioProd.Text = Precio;
            crud.cmbCategoria.Text = Categoria;
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
            /**********************************************************************/
            String id = dtvProductos.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvProductos.CurrentRow.Cells[1].Value.ToString();
            String Precio = dtvProductos.CurrentRow.Cells[2].Value.ToString();
            String Categoria = dtvProductos.CurrentRow.Cells[3].Value.ToString();

            crud.lblCodigo.Text = id;
            crud.txtNombreProd.Text = Nombre;
            crud.txtPrecioProd.Text = Precio;
            crud.cmbCategoria.Text = Categoria;
        }

        public static FrmRecetas frmRecetas = new FrmRecetas();
        private void btnVerSelected_Click(object sender, EventArgs e)
        {
            frmRecetas.txtIdProd.Text = dtvProductos.CurrentRow.Cells[0].Value.ToString();
            frmRecetas.btnActualizar.PerformClick();
            FrmLoguin.accessAd.AbrirFormulario(frmRecetas);
            this.Hide();
        }
    }
}
