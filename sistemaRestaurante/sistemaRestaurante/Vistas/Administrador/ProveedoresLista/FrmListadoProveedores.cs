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

namespace sistemaRestaurante.Vistas.Administrador.ProveedoresLista
{
    public partial class FrmListadoProveedores : Form
    {
        public FrmListadoProveedores()
        {
            InitializeComponent();
        }
        public void cargardatos ()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var tablaProvee = from proveedor in bd.Proveedores
                                  where proveedor.estado == "Activo"
                                  select proveedor;

                foreach (var iterar in tablaProvee)
                {
                    dtvProveedores.Rows.Add(iterar.idProveedor, iterar.nombre, iterar.ubicacion, iterar.telefono, iterar.email);
                }
            }
        }

        private void FrmListadoProveedores_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            FrmCRUDProveedor crudp = new FrmCRUDProveedor();
            crudp.Show();
            crudp.lblCodigo.Visible = false;
            crudp.btnEliminar.Visible = false;
            crudp.btnEditar.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvProveedores.Rows.Clear();
            cargardatos();
        }

        private void btnEditarSelected_Click(object sender, EventArgs e)
        {
            if (dtvProveedores.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay proveedores en existencia!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmCRUDProveedor crudp = new FrmCRUDProveedor();
                crudp.Show();
                crudp.lblCodigo.Visible = true;
                crudp.btnEliminar.Visible = false;
                crudp.btnEditar.Visible = true;
                crudp.btnAgregar.Visible = false;
                crudp.btnHabilitar.Visible = false;
                /***************************************/
                crudp.txtNombreProV.Enabled = true;
                crudp.txtUbicacion.Enabled = true;
                crudp.txtTelefono.Enabled = true;
                crudp.txtEmail.Enabled = true;
                /************************************************************************/
                String id = dtvProveedores.CurrentRow.Cells[0].Value.ToString();
                String Nombre = dtvProveedores.CurrentRow.Cells[1].Value.ToString();
                String ubicacion = dtvProveedores.CurrentRow.Cells[2].Value.ToString();
                String telefono = dtvProveedores.CurrentRow.Cells[3].Value.ToString();
                String email = dtvProveedores.CurrentRow.Cells[4].Value.ToString();

                crudp.lblCodigo.Text = id;
                crudp.txtNombreProV.Text = Nombre;
                crudp.txtUbicacion.Text = ubicacion;
                crudp.txtTelefono.Text = telefono;
                crudp.txtEmail.Text = email;
            } 
        }

        private void btnEliminarSelected_Click(object sender, EventArgs e)
        {
            if(dtvProveedores.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay proveedores en existencia!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmCRUDProveedor crudp = new FrmCRUDProveedor();
                crudp.Show();
                crudp.lblCodigo.Visible = true;
                crudp.btnEliminar.Visible = true;
                crudp.btnEditar.Visible = false;
                crudp.btnAgregar.Visible = false;
                crudp.btnHabilitar.Visible = false;
                /***************************************/
                crudp.txtNombreProV.Enabled = true;
                crudp.txtUbicacion.Enabled = true;
                crudp.txtTelefono.Enabled = true;
                crudp.txtEmail.Enabled = true;
                /**********************************************************************/
                String id = dtvProveedores.CurrentRow.Cells[0].Value.ToString();
                String Nombre = dtvProveedores.CurrentRow.Cells[1].Value.ToString();
                String ubicacion = dtvProveedores.CurrentRow.Cells[2].Value.ToString();
                String telefono = dtvProveedores.CurrentRow.Cells[3].Value.ToString();
                String email = dtvProveedores.CurrentRow.Cells[4].Value.ToString();

                crudp.lblCodigo.Text = id;
                crudp.txtNombreProV.Text = Nombre;
                crudp.txtUbicacion.Text = ubicacion;
                crudp.txtTelefono.Text = telefono;
                crudp.txtEmail.Text = email;
            }
        }
    }
}
