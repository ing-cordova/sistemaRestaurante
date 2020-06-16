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

        public String provee = "";
        Proveedores proveedor = new Proveedores();
        ProductosCompra prodCompra = new ProductosCompra();
        List<Proveedores> listaproveedores = new List<Proveedores>();
        public void CargarCombo()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var Proveedor = bd.Proveedores.ToList();
                foreach (var iterar in Proveedor)
                {
                    if (iterar.estado == "Activo")
                    {
                        listaproveedores.Add(iterar);
                    }
                }
                if (listaproveedores.Count() > 0)
                {
                    cmbProveedores.DataSource = listaproveedores;
                    cmbProveedores.DisplayMember = "nombre";
                    cmbProveedores.ValueMember = "idProveedor";
                }
            }
        }
        public void LimpiarCompra()
        {
            dtvDetallesCompra.Rows.Clear();
            txtCodigoProd.Text = "";
            txtBusqueda.Text = "";
            txtNombreProd.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
            nupCantidad.Value = 0;

        }
        public void RetornoId()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var tbCompras = bd.Compraas;

                lblCodigo.Text = "1";
                foreach (var iterarCompras in tbCompras)
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
            provee = cmbProveedores.SelectedValue.ToString();
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
                DialogResult result = MessageBox.Show("¿Desea agregar algo más antes de comprar?", "Validación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                    {
                        Compraas compra = new Compraas();

                        String nombre = lblUsuario.Text;

                        compra.fechadeCompra = Convert.ToDateTime(dtpFecha.Text);
                        compra.totalaPagar = Convert.ToDecimal(lblTotalAPagar.Text);
                        compra.idProveedor = Convert.ToInt32(provee);
                        compra.nombredeUsuario = nombre.ToString();

                        int idProv = int.Parse(provee);
                        proveedor = bd.Proveedores.Where(Id => Id.idProveedor == idProv).First();
                        proveedor.estado = "Activo";
                        bd.Entry(proveedor).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();

                        bd.Compraas.Add(compra);
                        bd.SaveChanges();

                        DetallesCompra detalleC = new DetallesCompra();
                        for (int i = 0; i < dtvDetallesCompra.RowCount; i++)
                        {
                            String idProdC = dtvDetallesCompra.Rows[i].Cells[0].Value.ToString();
                            int idProdConv = Convert.ToInt32(idProdC);

                            String cantidad = dtvDetallesCompra.Rows[i].Cells[3].Value.ToString();
                            int cantiConver = Convert.ToInt32(cantidad);

                            String precio = dtvDetallesCompra.Rows[i].Cells[2].Value.ToString();
                            Double precioConv = Convert.ToDouble(precio);

                            String total = dtvDetallesCompra.Rows[i].Cells[4].Value.ToString();
                            Decimal totalConv = Convert.ToDecimal(total);

                            detalleC.idCompra = Convert.ToInt32(lblCodigo.Text);
                            detalleC.idProductoC = idProdConv;
                            detalleC.cantidad = cantiConver;
                            detalleC.precioCompra = precioConv;
                            detalleC.totalProducto = totalConv;

                            int idProd = idProdConv;
                            prodCompra = bd.ProductosCompra.Where(Id => Id.idProductoC == idProd).First();
                            prodCompra.estado = "Activo";
                            bd.Entry(prodCompra).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();

                            bd.DetallesCompra.Add(detalleC);
                            bd.SaveChanges();

                            Almacen almaceen = new Almacen();
                            var lista = from almacen in bd.Almacen
                                        where almacen.idProductoC == idProdConv
                                        select almacen;
                            if (lista.Count() > 0)
                            {
                                int idA = int.Parse(dtvDetallesCompra.Rows[i].Cells[0].Value.ToString());
                                int CantidadProd = int.Parse(dtvDetallesCompra.Rows[i].Cells[3].Value.ToString());
                                almaceen = bd.Almacen.Where(VerificarID => VerificarID.idProductoC == idA).First();
                                almaceen.cantidadDisponible = almaceen.cantidadDisponible + CantidadProd;
                                bd.Entry(almaceen).State = System.Data.Entity.EntityState.Modified;
                                bd.SaveChanges();
                            }
                            else
                            {
                                almaceen.idProductoC = idProdConv;
                                almaceen.cantidadDisponible = int.Parse(dtvDetallesCompra.Rows[i].Cells[3].Value.ToString());
                                bd.Almacen.Add(almaceen);
                                bd.SaveChanges();
                            }
                        }

                        MessageBox.Show("¡Venta Realizada con éxito! \n\nCON UN TOTAL DE: $" + lblTotalAPagar.Text, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbProveedores.Enabled = true;
                        dtvDetallesCompra.Rows.Clear();
                    }

                    RetornoId();
                    txtCodigoProd.Text = "";
                    txtNombreProd.Text = "";
                    txtPrecio.Text = "";
                    nupCantidad.Value = 0;
                    txtTotal.Text = "";
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
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    int idProdtxt = Int32.Parse(txtCodigoProd.Text);
                    double totalProd = Convert.ToDouble(txtTotal.Text);
                    if (dtvDetallesCompra.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtvDetallesCompra.Rows.Count; i++)
                        {
                            int idProddtv = Int32.Parse(dtvDetallesCompra.Rows[i].Cells[0].Value.ToString());
                            if (idProddtv == idProdtxt)
                            {
                                try
                                {
                                    Calculo();
                                }
                                catch (Exception ex)
                                {

                                }

                                int NuevaCantidad = Int32.Parse(nupCantidad.Text) +
                                                    Int32.Parse(dtvDetallesCompra.Rows[i].Cells[3].Value
                                                        .ToString());
                                double NuevoTotal =
                                    totalProd + Convert.ToDouble(dtvDetallesCompra.Rows[i].Cells[4].Value);
                                dtvDetallesCompra.Rows[i].Cells[3].Value = NuevaCantidad;
                                dtvDetallesCompra.Rows[i].Cells[4].Value = NuevoTotal;
                                CalcularTotalGeneral();
                                dtvDetallesCompra.ClearSelection();
                                dtvDetallesCompra.FirstDisplayedScrollingRowIndex = i;
                                dtvDetallesCompra.Rows[i].Selected = true;
                                break;

                            }
                            else if (i == dtvDetallesCompra.Rows.Count - 1 && idProddtv != idProdtxt)
                            {
                                dtvDetallesCompra.Rows.Add(txtCodigoProd.Text, txtNombreProd.Text, txtPrecio.Text,
                                    nupCantidad.Value, txtTotal.Text);
                                cmbProveedores.Enabled = false;
                                CalcularTotalGeneral();
                                dtvDetallesCompra.ClearSelection();
                                int lastRow = dtvDetallesCompra.Rows.Count - 1;
                                dtvDetallesCompra.FirstDisplayedScrollingRowIndex = lastRow;
                                dtvDetallesCompra.Rows[lastRow].Selected = true;
                                break;
                            }

                        }
                    }
                    else if (dtvDetallesCompra.Rows.Count == 0)
                    {
                        dtvDetallesCompra.Rows.Add(txtCodigoProd.Text, txtNombreProd.Text, txtPrecio.Text,
                            nupCantidad.Value, txtTotal.Text);
                        cmbProveedores.Enabled = false;
                        CalcularTotalGeneral();
                        dtvDetallesCompra.ClearSelection();
                        int lastRow = dtvDetallesCompra.Rows.Count - 1;
                        dtvDetallesCompra.FirstDisplayedScrollingRowIndex = lastRow;
                        dtvDetallesCompra.Rows[lastRow].Selected = true;
                    }

                    try
                    {
                        Calculo();
                    }
                    catch (Exception ex)
                    {

                    }

                }
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

                    int idBusqueda = Int32.Parse(txtBusqueda.Text);
                    var buscarProd = from producto in bd.ProductosCompra
                                     where producto.idProductoC == idBusqueda && producto.estado == "Activo"
                                     select producto;
                    if (buscarProd.Count() > 0)
                    {
                        prodCompra = bd.ProductosCompra.Where(VerificarId => VerificarId.idProductoC == idBusqueda).First();
                        Categorias categorias = new Categorias();
                        categorias = bd.Categorias.Where(VerificarId => VerificarId.idCategoria == prodCompra.idCategoria).First();
                        Proveedores proveedores = new Proveedores();
                        proveedores = bd.Proveedores.Where(VerificarId => VerificarId.idProveedor == prodCompra.idProveedor).First();
                        if (categorias.estado == "Activo" && proveedores.estado == "Activo")
                        {
                            int idprovee = Int32.Parse(cmbProveedores.SelectedValue.ToString());
                            var buscarProdProveedor = from producto in bd.ProductosCompra
                                                      where producto.idProductoC == idBusqueda && producto.estado == "Activo"
                                                      where producto.idProveedor == idprovee
                                                      select producto;

                            if (buscarProdProveedor.Count() > 0)
                            {
                                ProductosCompra prod = new ProductosCompra();
                                int idProveedor = Int32.Parse(provee);
                                int Buscar = int.Parse(txtBusqueda.Text);
                                prod = bd.ProductosCompra.Where(idProducto => idProducto.idProductoC == Buscar && idProducto.idProveedor == idProveedor).First();

                                txtCodigoProd.Text = Convert.ToString(prod.idProductoC);
                                txtNombreProd.Text = Convert.ToString(prod.nombre);
                                txtPrecio.Text = Convert.ToString(prod.precio);
                                nupCantidad.Focus();
                                txtBusqueda.Text = "";
                                intentos = 2;
                            }
                            else
                            {
                                MessageBox.Show("¡El producto no se encuentra en los Registros" + "\n o no pertenece al proveedor seleccionado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBusqueda.Text = "";
                            }

                        }
                        else
                        {
                            MessageBox.Show("¡La categoria o el Proveedor del Producto ingresado ha sido eliminada!", "Actualize Producto", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡El producto no se encuentra en los Registros!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBusqueda.Text = "";
                    }

                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmProdsAComprar browse = new FrmProdsAComprar(provee);
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
            if (dtvDetallesCompra.Rows.Count == 0)
            {
                lblTotalAPagar.Text = "0.00";
            }
            else
            {
                CalcularTotalGeneral();
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
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
            else
            {
                e.Handled = true;
            }
        }
    }
}
