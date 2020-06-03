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

namespace sistemaRestaurante.Vistas.Administrador.Ventas
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        public void RetornoId()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var tbVentas = bd.Ventas;

                lblCodigo.Text = "1";
                foreach (var iterarCompras in tbVentas)
                {
                    int idCompra = iterarCompras.idVenta;
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
            for (int i = 0; i < dtvDetallesVenta.RowCount; i++)
            {
                String DatosAOperar = dtvDetallesVenta.Rows[i].Cells[4].Value.ToString();
                Double DatosCovertidos = Convert.ToDouble(DatosAOperar);

                Suma += DatosCovertidos;
                lblTotalAPagar.Text = Suma.ToString();
            }
        }
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            RetornoId();
            txtCodigoProd.Text = "";
            txtNombreProd.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
        }

        

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (dtvDetallesVenta.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay nada en el carrito!", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea agregar algo más antes de comprar?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                    {
                        Model.Ventas venta = new Model.Ventas();

                        String nombre = lblUsuario.Text;

                        venta.fechadeVenta = Convert.ToDateTime(dtpFecha.Text);
                        venta.totalPagar = Convert.ToDecimal(lblTotalAPagar.Text);
                        venta.nombredeUsuario = nombre.ToString();
                        venta.estado = "Enviada";

                        bd.Ventas.Add(venta);
                        bd.SaveChanges();

                        DetallesVenta detallesV = new DetallesVenta();
                        for (int i = 0; i < dtvDetallesVenta.RowCount; i++)
                        {
                            String idProdV = dtvDetallesVenta.Rows[i].Cells[0].Value.ToString();
                            int idProdConv = Convert.ToInt32(idProdV);

                            String cantidad = dtvDetallesVenta.Rows[i].Cells[3].Value.ToString();
                            int cantiConver = Convert.ToInt32(cantidad);

                            String precio = dtvDetallesVenta.Rows[i].Cells[2].Value.ToString();
                            Double precioConv = Convert.ToDouble(precio);

                            String total = dtvDetallesVenta.Rows[i].Cells[4].Value.ToString();
                            Decimal totalConv = Convert.ToDecimal(total);

                            detallesV.idVenta = Convert.ToInt32(lblCodigo.Text);
                            detallesV.idProductoV = idProdConv;
                            detallesV.cantidad = cantiConver;
                            detallesV.precioCompra = precioConv;
                            detallesV.totalProducto = totalConv;

                            bd.DetallesVenta.Add(detallesV);
                            bd.SaveChanges();
                        }

                        MessageBox.Show("¡Venta Realizada con éxito! \n\nCON UN TOTAL DE: $" + lblTotalAPagar.Text, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dtvDetallesVenta.Rows.Clear();
                    }

                    RetornoId();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProd.Text.Equals("") || txtNombreProd.Text.Equals("") || txtPrecio.Text.Equals("") || nupCantidad.Value == 0 || txtTotal.Text.Equals("") || txtTotal.Text.Equals("0"))
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

                dtvDetallesVenta.Rows.Add(txtCodigoProd.Text, txtNombreProd.Text, txtPrecio.Text, nupCantidad.Value, txtTotal.Text);

                CalcularTotalGeneral();
                dtvDetallesVenta.ClearSelection();
                int lastRow = dtvDetallesVenta.Rows.Count - 1;
                dtvDetallesVenta.FirstDisplayedScrollingRowIndex = lastRow;
                dtvDetallesVenta.Rows[lastRow].Selected = true;
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
                if (e.KeyCode == Keys.Enter)
                {
                    btnBuscar.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    ProductosVenta prod = new ProductosVenta();

                    int Buscar = int.Parse(txtBusqueda.Text);
                    prod = bd.ProductosVenta.Where(idProducto => idProducto.idProductoV == Buscar).First();

                    txtCodigoProd.Text = Convert.ToString(prod.idProductoV);
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
            FrmProdsAVender browse = new FrmProdsAVender();
            browse.Show();
        }

        int intentos = 1;
        private void nupCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
            if (dtvDetallesVenta.Rows.Count == 0)
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
