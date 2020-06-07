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
using sistemaRestaurante.Vistas.Administrador.Compras;
using sistemaRestaurante.Vistas.Administrador.Ventas;

namespace sistemaRestaurante.Vistas.Administrador.Productos
{
    public partial class FrmRecetas : Form
    {
        public FrmRecetas()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        ProductosVenta productosVenta = new ProductosVenta();
        Recetas recetas = new Recetas();

        private void CargarDatos()
        {
            lblEtiqueta.Text = "Receta de " + txtNombre.Text + ":";
            dtvReceta.Rows.Clear();
            int id;
            id = Int32.Parse(txtIdProd.Text);
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                productosVenta = bd.ProductosVenta.Where(idProdV => idProdV.idProductoV == id).First();
                txtNombre.Text = productosVenta.nombre.ToString();

                var JoinReceta = from recetass in bd.Recetas
                    from productosCompra in bd.ProductosCompra
                    where recetass.idProductoV == id
                    where recetass.idProductoC == productosCompra.idProductoC
                    select new
                    {
                        ID = recetass.idReceta,
                        IDPROD = productosCompra.idProductoC,
                        NOMBRE = productosCompra.nombre,
                        CANTIDAD = recetass.cantidadProdIngrediente
                    };

                foreach (var iterar in JoinReceta)
                {
                    dtvReceta.Rows.Add(iterar.ID, iterar.IDPROD, iterar.NOMBRE, iterar.CANTIDAD);
                }
            }
        }

        private void Limpiar()
        {
            txtNombreProdC.Text = "";
            txtIdProdC.Text = "";
            nupCantidad.Value = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoguin.accessAd.AbrirFormulario( FrmAccesoAdmin.frmListadoProd);
        }

        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
            nupCantidad.Enabled = true;
            btnAgregar.Enabled = true;
            btnEditarSelected.Enabled = false;
            btnEliminarSelected.Enabled = false;
            Limpiar();
        }

        int intentos = 1;

        private void nupCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (intentos == 2)
                {
                    btnAgregar.PerformClick();

                    txtNombreProdC.Text = "";
                    txtNombreProdC.Text = "";
                    nupCantidad.Value = 0;

                    intentos = 0;
                    txtBusqueda.Focus();
                }

                intentos += 1;
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnBuscar.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    ProductosCompra prod = new ProductosCompra();

                    int Buscar = int.Parse(txtBusqueda.Text);
                    prod = bd.ProductosCompra.Where(idProducto => idProducto.idProductoC == Buscar).First();

                    txtIdProdC.Text = Convert.ToString(prod.idProductoC);
                    txtNombreProdC.Text = Convert.ToString(prod.nombre);
                    nupCantidad.Focus();
                    txtBusqueda.Text = "";
                    intentos = 2;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarIngredientes buscar = new FrmBuscarIngredientes();
            buscar.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdProdC.Text.Equals("") || txtNombreProdC.Text.Equals("") ||
                  nupCantidad.Value == 0)
            {
                MessageBox.Show("¡Todos los campos son obligatorios!", "Rellenar campos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                btnNuevo.Enabled = true;
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {

                    recetas.idProductoV = Int32.Parse(txtIdProd.Text);
                    recetas.idProductoC = Int32.Parse(txtIdProdC.Text);
                    recetas.cantidadProdIngrediente = Int32.Parse(nupCantidad.Text);

                    bd.Recetas.Add(recetas);
                    bd.SaveChanges();
                }

                CargarDatos();
                Limpiar();
                btnActualizar.Enabled = false;
                btnEditarSelected.Enabled = false;
                btnEliminarSelected.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditarSelected_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres editar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    
                    int idR = int.Parse(dtvReceta.CurrentRow.Cells[0].Value.ToString());

                    recetas = bd.Recetas.Where(VerificarID => VerificarID.idReceta == idR).First();
                    recetas.idProductoC = Int32.Parse(txtIdProdC.Text);
                    recetas.idProductoV = Int32.Parse(txtIdProd.Text);
                    recetas.cantidadProdIngrediente = Int32.Parse(nupCantidad.Text);

                    bd.Entry(recetas).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Ingrediente editado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void dtvReceta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBuscar.Enabled = false;
            txtBusqueda.Enabled = false;
            btnAgregar.Enabled = false;
            btnNuevo.Enabled = true;
            nupCantidad.Enabled = true;
            btnEditarSelected.Enabled = true;
            btnEliminarSelected.Enabled = true;

            String idProdC = dtvReceta.CurrentRow.Cells[1].Value.ToString();
            String Nombre = dtvReceta.CurrentRow.Cells[2].Value.ToString();
            String Cantidad = dtvReceta.CurrentRow.Cells[3].Value.ToString();

            txtIdProdC.Text = idProdC;
            txtNombreProdC.Text = Nombre;
            nupCantidad.Value = Int32.Parse(Cantidad);
        }

        private void btnEliminarSelected_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    int idR = int.Parse(dtvReceta.CurrentRow.Cells[0].Value.ToString());

                    recetas = bd.Recetas.Find(idR);
                    bd.Recetas.Remove(recetas);
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Ingrediente eliminado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}