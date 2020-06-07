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

        public void LimpiarVenta()
        {
            dtvDetallesVenta.Rows.Clear();
            txtNMesa.Text = "";
            txtCodigoProd.Text = "";
            txtBusqueda.Text = "";
            txtNombreProd.Text = "";
            txtPrecio.Text = "";
            txtTotal.Text = "";
            nupCantidad.Value = 0;

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
            Limpiar();
        }

        private void Limpiar()
        {
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

                        venta.fechadeVenta = DateTime.Now;
                        venta.totalPagar = Convert.ToDecimal(lblTotalAPagar.Text);
                        venta.nombredeUsuario = nombre.ToString();
                        venta.estado = "Enviada";
                        venta.NumMesa = Convert.ToInt32(txtNMesa.Text);

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

                            var listaReceta = from recetas in bd.Recetas
                                              where recetas.idProductoV == idProdConv
                                              select recetas;
                            foreach (var iterar in listaReceta)
                            {
                                Recetas recetas = new Recetas();
                                Almacen almaceen = new Almacen();
                                recetas = iterar;
                                int idR = Int32.Parse(recetas.idProductoC.ToString());
                                almaceen = bd.Almacen.Where(VerificarID => VerificarID.idProductoC == idR).First();
                                double cantidadRestada = (Convert.ToDouble(cantiConver) / Convert.ToDouble(recetas.cantidadProdIngrediente));
                                almaceen.cantidadDisponible = almaceen.cantidadDisponible - cantidadRestada;
                            }

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
                        txtNMesa.Enabled = true;
                    }

                    RetornoId();
                }
            }
        }

        internal void AgregarCarrito()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                int idProd = Int32.Parse(txtCodigoProd.Text);
                int cantidad = Int32.Parse(nupCantidad.Text);
                var listaReceta = from recetas in bd.Recetas
                                  where recetas.idProductoV == idProd
                                  select recetas;
                bool agregar = true;
                foreach (var iterar in listaReceta)
                {
                    Recetas recetas = new Recetas();
                    Almacen almaceen = new Almacen();
                    recetas = iterar;
                    int idR = Int32.Parse(recetas.idProductoC.ToString());
                    var listaR = from table_almacen in bd.Almacen
                                  where table_almacen.idProductoC == idR
                                  select table_almacen;
                    if (listaR.Count() > 0)
                    {
                        almaceen = bd.Almacen.Where(VerificarID => VerificarID.idProductoC == idR).First();
                        double verificarCantidad =
                            (Convert.ToDouble(cantidad) / Convert.ToDouble(recetas.cantidadProdIngrediente));
                        if (almaceen.cantidadDisponible < verificarCantidad)
                        {
                            agregar = false;
                            break;
                        }
                    }
                    else
                    {
                        agregar = false;
                        break;
                    }
                    
                }

                if (agregar == false)
                {
                    MessageBox.Show("¡No se puede agregar el Producto!", "Ingredientes Insuficientes",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    int NumeroMesa = Int32.Parse(txtNMesa.Text);
                    var lista = from ventas in bd.Ventas
                                where ventas.NumMesa == NumeroMesa && ventas.estado != "Pagada"
                                select ventas;

                    if (lista.Count() > 0)
                    {
                        MessageBox.Show(
                            "¡No se puede realizar otra Orden en ese Numero de Mesa \nhasta que haya pagado la actual orden!",
                            "Completar",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        dtvDetallesVenta.Rows.Add(txtCodigoProd.Text, txtNombreProd.Text, txtPrecio.Text,
                            nupCantidad.Value, txtTotal.Text);
                        txtNMesa.Enabled = false;
                        CalcularTotalGeneral();
                        dtvDetallesVenta.ClearSelection();
                        int lastRow = dtvDetallesVenta.Rows.Count - 1;
                        dtvDetallesVenta.FirstDisplayedScrollingRowIndex = lastRow;
                        dtvDetallesVenta.Rows[lastRow].Selected = true;
                        Limpiar();

                    }
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {

                if (txtCodigoProd.Text.Equals("") || txtNombreProd.Text.Equals("") ||
                    txtPrecio.Text.Equals("") ||
                    nupCantidad.Value == 0 || txtTotal.Text.Equals("") || txtTotal.Text.Equals("0") ||
                    txtNMesa.Text.Equals(""))
                {
                    MessageBox.Show("¡Todos los campos son obligatorios!", "Rellenar campos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    int idProdtxt = Int32.Parse(txtCodigoProd.Text);
                    double totalProd = Convert.ToDouble(txtTotal.Text);
                    if (dtvDetallesVenta.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtvDetallesVenta.Rows.Count; i++)
                        {
                            int idProddtv = Int32.Parse(dtvDetallesVenta.Rows[i].Cells[0].Value.ToString());
                            if (idProddtv == idProdtxt)
                            {

                                int cantidad = Int32.Parse(nupCantidad.Text);
                                var listaReceta = from recetas in bd.Recetas
                                                  where recetas.idProductoV == idProdtxt
                                                  select recetas;
                                bool agregar = true;
                                foreach (var iterar in listaReceta)
                                {
                                    Recetas recetas = new Recetas();
                                    Almacen almaceen = new Almacen();
                                    recetas = iterar;
                                    int idR = Int32.Parse(recetas.idProductoC.ToString());
                                    almaceen = bd.Almacen.Where(VerificarID => VerificarID.idProductoC == idR).First();
                                    double verificarCantidad = ((Convert.ToDouble(cantidad) + Convert.ToDouble(dtvDetallesVenta.Rows[i].Cells[3].Value)) / Convert.ToDouble(recetas.cantidadProdIngrediente));
                                    if (almaceen.cantidadDisponible < verificarCantidad)
                                    {
                                        agregar = false;
                                        break;
                                    }
                                }
                                if (agregar == false)
                                {
                                    MessageBox.Show("¡No se puede agregar el Producto!", "Ingredientes Insuficientes", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
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
                                    int NuevaCantidad = Int32.Parse(nupCantidad.Text) + Int32.Parse(dtvDetallesVenta.Rows[i].Cells[3].Value.ToString());
                                    double NuevoTotal = totalProd + Convert.ToDouble(dtvDetallesVenta.Rows[i].Cells[4].Value);
                                    dtvDetallesVenta.Rows[i].Cells[3].Value = NuevaCantidad;
                                    dtvDetallesVenta.Rows[i].Cells[4].Value = NuevoTotal;
                                    CalcularTotalGeneral();
                                    dtvDetallesVenta.ClearSelection();
                                    dtvDetallesVenta.FirstDisplayedScrollingRowIndex = i;
                                    dtvDetallesVenta.Rows[i].Selected = true;
                                    Limpiar();
                                    break;
                                }
                            }
                            else if (i == dtvDetallesVenta.Rows.Count - 1 && idProddtv != idProdtxt)
                            {
                                AgregarCarrito();
                                break;
                            }

                        }
                    }
                    else if (dtvDetallesVenta.Rows.Count == 0)
                    {
                        AgregarCarrito();
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
                    ProductosVenta prod = new ProductosVenta();

                    int Buscar = int.Parse(txtBusqueda.Text);
                    var buscarProd = from producto in bd.ProductosVenta
                                     where producto.idProductoV == Buscar
                                     select producto;

                    if (buscarProd.Count() > 0)
                    {
                        prod = bd.ProductosVenta.Where(idProducto => idProducto.idProductoV == Buscar).First();
                        var listaR = from recetas in bd.Recetas
                                     where recetas.idProductoV == prod.idProductoV
                                     select recetas;
                        if (listaR.Count() > 0)
                        {
                            txtCodigoProd.Text = Convert.ToString(prod.idProductoV);
                            txtNombreProd.Text = Convert.ToString(prod.nombre);
                            txtPrecio.Text = Convert.ToString(prod.precio);
                            nupCantidad.Focus();
                            txtBusqueda.Text = "";
                            intentos = 2;
                        }
                        else
                        {
                            MessageBox.Show("¡El codigo del Producto ingresado aun no tiene Receta!", "Ingrese Receta", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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

        private void txtNMesa_KeyPress(object sender, KeyPressEventArgs e)
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
