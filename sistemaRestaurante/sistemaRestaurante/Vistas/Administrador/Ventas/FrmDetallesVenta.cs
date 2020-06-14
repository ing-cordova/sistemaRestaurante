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
using CrystalDecisions.CrystalReports.Engine;
using  CrystalDecisions.Shared;
using sistemaRestaurante.Reports;

namespace sistemaRestaurante.Vistas.Administrador.Ventas
{
    public partial class FrmDetallesVenta : Form
    {
        public FrmDetallesVenta()
        {
            InitializeComponent();
        }
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        Model.Ventas ventas = new Model.Ventas();
        private void CargarDatos()
        {
            dtvDetallesVenta.Rows.Clear();
            int id;
            id = Int32.Parse(txtIdVenta.Text);
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                ventas = bd.Ventas.Where(idVenta => idVenta.idVenta == id).First();
                txtFecha.Text = ventas.fechadeVenta.ToString();
                txtNumerodeMesa.Text = ventas.NumMesa.ToString();
                txtEstado.Text = ventas.estado.ToString();
                if (txtEstado.Text.Equals("Recibida"))
                {
                    btnRecibida.Enabled = false;
                    btnEntregada.Enabled = true;
                    btnPagada.Enabled = false;
                }
                else if(txtEstado.Text.Equals("Enviada"))
                {
                    btnRecibida.Enabled = true;
                    btnEntregada.Enabled = false;
                    btnPagada.Enabled = false;
                }else if (txtEstado.Text.Equals("Entregada"))
                {
                    btnRecibida.Enabled = false;
                    btnEntregada.Enabled = false;
                    btnPagada.Enabled = true;
                }

                var JoinDetalles = from detallesVenta in bd.DetallesVenta
                    from productosVenta in bd.ProductosVenta
                    where detallesVenta.idProductoV == productosVenta.idProductoV
                    where detallesVenta.idVenta == id
                    select new
                    {
                        ID = detallesVenta.idProductoV,
                        NOMBRE = productosVenta.nombre,
                        CANTIDAD = detallesVenta.cantidad
                    };

                foreach (var iterar in JoinDetalles)
                {
                    dtvDetallesVenta.Rows.Add(iterar.ID, iterar.NOMBRE, iterar.CANTIDAD);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoguin.accessAd.AbrirFormulario(new FrmListaVentas());
        }

        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRecibida_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres marcar la orden como Recibida? \n¡La acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {

                    String idVenta = txtIdVenta.Text;
                    int idV = int.Parse(idVenta);

                    ventas = bd.Ventas.Where(VerificarID => VerificarID.idVenta == idV).First();
                    ventas.estado = "Recibida";


                    bd.Entry(ventas).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Orden modificada con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                CargarDatos();
            }
        }

        private void btnEntregada_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres marcar la orden como Entregada? \n¡La acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {

                    String idVenta = txtIdVenta.Text;
                    int idV = int.Parse(idVenta);

                    ventas = bd.Ventas.Where(VerificarID => VerificarID.idVenta == idV).First();
                    ventas.estado = "Entregada";


                    bd.Entry(ventas).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                    
                }

                MessageBox.Show("¡Orden modificada con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                CargarDatos();
            }
        }

        private void btnPagada_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres marcar la orden como Entregada? \n¡La acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                String idVenta = txtIdVenta.Text;
                int idV = int.Parse(idVenta);
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {

                    ventas = bd.Ventas.Where(VerificarID => VerificarID.idVenta == idV).First();
                    ventas.estado = "Pagada";


                    bd.Entry(ventas).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();

                }

                DialogResult dialog = MessageBox.Show("¿DESEA EMITIR UNA FACTURA?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    FrmRptFacturaVenta frmRptFactura = new FrmRptFacturaVenta();
                    ReportDocument Rd = new ReportDocument();
                    ParameterField pf = new ParameterField();
                    ParameterFields pfs = new ParameterFields();
                    ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                    pf.Name = "@IdVenta";
                    pdv.Value = idV;
                    pf.CurrentValues.Add(pdv);
                    pfs.Add(pf);
                    frmRptFactura.crDetalleVenta.ParameterFieldInfo = pfs;
                    Rd.Load(@"C:\Users\Usuario\Documents\GitHub\sistemaRestaurante\sistemaRestaurante\sistemaRestaurante\Reports\rptFacturaVentas.rpt");
                    frmRptFactura.crDetalleVenta.ReportSource = Rd;
                    btnRegresar.PerformClick();
                    frmRptFactura.Show();
                }
                
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
