using sistemaRestaurante.Vistas.Usuario.ProductosLista;
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

namespace sistemaRestaurante.Vistas.Administrador.Compras
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        String provee = "";
        public void CargarCombo()
        {
            using(RestauranteBDEntities bd = new RestauranteBDEntities())
            {
                var proveedor = bd.Proveedores.ToList();

                if (proveedor.Count() > 0)
                {
                    cmbProveedores.DataSource = proveedor;
                    cmbProveedores.DisplayMember = "nombre";
                    cmbProveedores.ValueMember = "idProveedor";
                }
            }
        }

        public void RetornoId()
        {
            using(RestauranteBDEntities bd = new RestauranteBDEntities())
            {
                var tbCompras = bd.Compras;

                lblCodigo.Text = "1";
                foreach(var iterarCompras in tbCompras)
                {
                    int idCompra = iterarCompras.idCompra;
                    int suma = idCompra + 1;
                    lblCodigo.Text = suma.ToString();
                }
            }
        }

        public void Calculo()
        {
            int cantidad;
            Double precioProd, total;

            precioProd = Double.Parse(txtPrecio.Text);
            cantidad = Convert.ToInt32(nupCantidad.Value);
            total = (precioProd * cantidad);
            txtTotal.Text = total.ToString();
        }
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CargarCombo();
            RetornoId();
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            provee = cmbProveedores.SelectedValue.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (dtvDetallesCompra.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay nada en el carrito!", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCodigoProd.Text.Equals("") || txtNombreProd.Text.Equals("") || txtPrecio.Text.Equals("") || nupCantidad.Value==0 || txtTotal.Text.Equals("") || txtTotal.Text.Equals("0"))
            {
                MessageBox.Show("¡Todos los campos son obligatorios!", "Rellenar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void nupCantidad_ValueChanged(object sender, EventArgs e)
        {
            Calculo();
        }
    }
}
