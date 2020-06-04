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
using sistemaRestaurante.Vistas.Administrador;
using sistemaRestaurante.Vistas.Administrador.Productos;

namespace sistemaRestaurante.Vistas.Administrador.Compras
{
    public partial class FrmBuscarIngredientes : Form
    {
        public FrmBuscarIngredientes()
        {
            InitializeComponent();
        }

        
        public void Filtro()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var JoinProd = from prod in bd.ProductosCompra
                               from provee in bd.Proveedores
                               from categoria in bd.Categorias
                               where prod.idProveedor == provee.idProveedor
                               where prod.idCategoria == categoria.idCategoria
                               where prod.nombre.Contains(txtBusqueda.Text)

                               select new
                               {
                                   ID = prod.idProductoC,
                                   NOMBRE = prod.nombre,
                                   PRECIO = prod.precio,
                                   PROVEEDOR = provee.nombre,
                                   CATEGORIA = categoria.nombreCategoria
                               };

                foreach (var iterar in JoinProd)
                {
                    dtvDetallesCompra.Rows.Add(iterar.ID, iterar.NOMBRE, iterar.PRECIO, iterar.PROVEEDOR, iterar.CATEGORIA);
                }
            }
        }

        public void Envio()
        {
            String id = dtvDetallesCompra.CurrentRow.Cells[0].Value.ToString();
            String nombreProd = dtvDetallesCompra.CurrentRow.Cells[1].Value.ToString();

            FrmListadoProductos.frmRecetas.txtIdProdC.Text = id;
            FrmListadoProductos.frmRecetas.txtNombreProdC.Text = nombreProd;

            FrmAccesoAdmin.compras.nupCantidad.Focus();
        }

        private void FrmProdsAComprar_Load(object sender, EventArgs e)
        {
            Filtro();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtvDetallesCompra.Rows.Clear();
            Filtro();
        }

        
        private void dtvDetallesCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Envio();
            this.Close();
        }

        private void dtvDetallesCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Envio();
                this.Close();
                FrmAccesoAdmin.compras.nupCantidad.Value = 0;
            }
        }
    }
}
