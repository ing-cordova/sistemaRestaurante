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
            try
            {
                int cantidad;
                Double precioProd, total;

                precioProd = Double.Parse(txtPrecio.Text);
                cantidad = Convert.ToInt32(nupCantidad.Value);
                total = (precioProd * cantidad);
                txtTotal.Text = total.ToString();
            }
            catch
            {

            }
        }

        public void CalcularTotalGeneral()
        {
            Double Suma = 0;
            for (int i = 0; i < dtvDetallesCompra.RowCount; i++)
            {
                String DatosAOperar = dtvDetallesCompra.Rows[i].Cells[4].Value.ToString();
                Double DatosCovertidos = Convert.ToDouble(DatosAOperar);

                Suma += DatosCovertidos;
                lblTotalAPagar.Text = Suma.ToString();
            }
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
                try
                {
                    Calculo();
                }
                catch (Exception ex)
                {

                }

                dtvDetallesCompra.Rows.Add(txtCodigoProd.Text, txtNombreProd.Text, txtPrecio.Text, nupCantidad.Value, txtTotal.Text);

                CalcularTotalGeneral();
                dtvDetallesCompra.ClearSelection();
                int lastRow = dtvDetallesCompra.Rows.Count - 1;
                dtvDetallesCompra.FirstDisplayedScrollingRowIndex = lastRow;
                dtvDetallesCompra.Rows[lastRow].Selected = true;
            }
        }

        private void nupCantidad_ValueChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                if(e.KeyCode == Keys.Enter)
                {
                    btnBuscar.PerformClick();
                }
            }
            else if(e.KeyCode == Keys.Enter)
            {
                using(RestauranteBDEntities bd = new RestauranteBDEntities())
                {
                    ProductosCompra prod = new ProductosCompra();

                    int Buscar = int.Parse(txtBusqueda.Text);
                    prod = bd.ProductosCompra.Where(idProducto => idProducto.idProductoC == Buscar).First();

                    txtCodigoProd.Text = Convert.ToString(prod.idProductoC);
                    txtNombreProd.Text = Convert.ToString(prod.nombre);
                    txtPrecio.Text = Convert.ToString(prod.precio);
                    nupCantidad.Focus();
                    txtBusqueda.Text = "";
                    intentos = 2;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmProdsAComprar browse = new FrmProdsAComprar();
            browse.Show();
        }

        int intentos = 1;
        private void nupCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (intentos == 2)
                {
                    btnAgregar.PerformClick();

                    txtCodigoProd.Text = "";
                    txtNombreProd.Text = "";
                    txtPrecio.Text = "";
                    txtTotal.Text = "";

                    intentos = 0;
                    txtBusqueda.Focus();
                }

                intentos += 1;
            }
        }

        private void dtvDetallesCompra_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if(dtvDetallesCompra.Rows.Count == 0)
            {
                lblTotalAPagar.Text = "0.00";
            }
            else
            {
                CalcularTotalGeneral();
            }
        }
    }
}
