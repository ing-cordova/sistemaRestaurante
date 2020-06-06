using sistemaRestaurante.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaRestaurante.Vistas.Administrador.Productos
{
    public partial class FrmCRUDProductos : Form
    {
        public FrmCRUDProductos()
        {
            InitializeComponent();
        }

        String categ = "";
        FrmListadoProductos listado = new FrmListadoProductos();
        ProductosVenta prod = new ProductosVenta();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void CargarCombo()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var Categorias = bd.Categorias.ToList();
                if (Categorias.Count > 0)
                {
                    cmbCategoria.DataSource = Categorias;
                    cmbCategoria.DisplayMember = "nombreCategoria";
                    cmbCategoria.ValueMember = "idCategoria";
                }
            }
        }

        public void LimpiarCajas()
        {
            txtNombreProd.Text = "";
            txtPrecioProd.Text = "";
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            txtNombreProd.Enabled = true;
            txtPrecioProd.Enabled = true;
            cmbCategoria.Enabled = true;
        }

        private void FrmCRUDProductos_Load(object sender, EventArgs e)
        {
            LimpiarCajas();
            CargarCombo();
            txtNombreProd.Enabled = false;
            txtPrecioProd.Enabled = false;
            cmbCategoria.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioCon;
            if (txtNombreProd.Text.Equals("") || txtPrecioProd.Text.Equals("") || cmbCategoria.SelectedItem.Equals(""))
            {
                MessageBox.Show("¡Complete todos los campos para continuar!", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(decimal.TryParse(txtPrecioProd.Text, out precioCon) == false)
                {
                    MessageBox.Show("¡Ingrese correctamente el precio!");
                }
                else
                {
                    using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                    {
                        prod.nombre = txtNombreProd.Text;
                        prod.precio = decimal.Parse(txtPrecioProd.Text);
                        prod.idCategoria = int.Parse(categ);

                        bd.ProductosVenta.Add(prod);
                        bd.SaveChanges();
                    }

                    MessageBox.Show("¡Producto insertado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                    listado.dtvProductos.Rows.Clear();
                    listado.CargarDatos();
                }
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categ = cmbCategoria.SelectedValue.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres editar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    String id2 = lblCodigo.Text;
                    int idC = int.Parse(id2);

                    prod = bd.ProductosVenta.Where(VerificarID => VerificarID.idProductoV == idC).First();
                    prod.nombre = txtNombreProd.Text;
                    prod.precio = decimal.Parse(txtPrecioProd.Text);
                    prod.idCategoria = int.Parse(categ);

                    bd.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Producto editado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    String id = lblCodigo.Text;

                    prod = bd.ProductosVenta.Find(int.Parse(id));
                    bd.ProductosVenta.Remove(prod);
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Producto eliminado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }
    }
}
