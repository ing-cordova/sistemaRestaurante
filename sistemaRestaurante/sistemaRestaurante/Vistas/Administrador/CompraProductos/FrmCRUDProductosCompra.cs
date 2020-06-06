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
    public partial class FrmCRUDProductosCompra : Form
    {
        public FrmCRUDProductosCompra()
        {
            InitializeComponent();
        }

        String categ = "", provee = "";
        ProductosCompra prodC = new ProductosCompra();
        Proveedores proveedor = new Proveedores();
        Categorias categoria = new Categorias();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void CargarCombos()
        {
            using(RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var Categorias = bd.Categorias.ToList();
                var Proveedor = bd.Proveedores.ToList();

                if(Categorias.Count() > 0)
                {
                    cmbCategoria.DataSource = Categorias;
                    cmbCategoria.DisplayMember = "nombreCategoria";
                    cmbCategoria.ValueMember = "idCategoria";
                }
                if (Proveedor.Count() > 0)
                {
                    cmbProveedor.DataSource = Proveedor;
                    cmbProveedor.DisplayMember = "nombre";
                    cmbProveedor.ValueMember = "idProveedor";
                }
            }
        }

        public void LimpiarBox()
        {
            txtNombreProdCompra.Text = "";
            txtPrecioProd.Text = "";
            cmbProveedor.Text = "";
            cmbCategoria.Text = "";
            txtEstado.Text = "";
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmCRUDProductosCompra_Load(object sender, EventArgs e)
        {
            CargarCombos();
            txtNombreProdCompra.Enabled = false;
            txtPrecioProd.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbProveedor.Enabled = false;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            LimpiarBox();
            txtNombreProdCompra.Enabled = true;
            txtPrecioProd.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbProveedor.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                String id2 = lblCodigo.Text;
                int idC = int.Parse(id2);
                decimal precioCon;

                if (decimal.TryParse(txtPrecioProd.Text, out precioCon) == false)
                {
                    MessageBox.Show("¡Ingrese correctamente el precio!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro que quieres editar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        prodC = bd.ProductosCompra.Where(VerificarID => VerificarID.idProductoC == idC).First();
                        prodC.nombre = txtNombreProdCompra.Text;
                        prodC.precio = decimal.Parse(txtPrecioProd.Text);
                        prodC.idProveedor = int.Parse(provee);
                        prodC.idCategoria = int.Parse(categ);

                        bd.Entry(prodC).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();

                        MessageBox.Show("¡Producto editado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                if (txtEstado.Text.Equals("Activo"))
                {
                    MessageBox.Show("¡Actualmente este producto está activo, no se puede eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        String id = lblCodigo.Text;

                        prodC = bd.ProductosCompra.Find(int.Parse(id));
                        bd.ProductosCompra.Remove(prodC);
                        bd.SaveChanges();

                        MessageBox.Show("¡Producto eliminado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                }
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categ = cmbCategoria.SelectedValue.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                decimal precioCon;

                if (decimal.TryParse(txtPrecioProd.Text, out precioCon) == false)
                {
                    MessageBox.Show("¡Ingrese correctamente el precio!");
                }
                else
                {
                    prodC.nombre = txtNombreProdCompra.Text;
                    prodC.precio = decimal.Parse(txtPrecioProd.Text);
                    prodC.idProveedor = int.Parse(provee);
                    prodC.idCategoria = int.Parse(categ);
                    prodC.estado = "Inactivo";

                    int idProv = int.Parse(provee);
                    proveedor = bd.Proveedores.Where(Id => Id.idProveedor == idProv).First();
                    proveedor.estado = "Activo";
                    bd.Entry(proveedor).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();

                    int idCat = int.Parse(categ);
                    categoria = bd.Categorias.Where(Id => Id.idCategoria == idCat).First();
                    categoria.estado = "Activo";
                    bd.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();

                    bd.ProductosCompra.Add(prodC);
                    bd.SaveChanges();

                    MessageBox.Show("¡Producto insertado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
            }
        }

        private void txtPrecioProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            provee = cmbProveedor.SelectedValue.ToString();
        }
    }
}
