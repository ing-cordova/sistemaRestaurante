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
    public partial class FrmCRUDProveedor : Form
    {
        public FrmCRUDProveedor()
        {
            InitializeComponent();
        }
        FrmListadoProveedores listadoP = new FrmListadoProveedores();
        Proveedores prov = new Proveedores();
        public void LimpiarCajas()
        {
            txtNombreProV.Text = "";
            txtUbicacion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            txtNombreProV.Enabled = true;
            txtUbicacion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreProV.Text.Equals("") || txtUbicacion.Text.Equals("") || txtTelefono.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("¡Complete todos los campos para continuar!", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (RestauranteBDEntities bd = new RestauranteBDEntities())
                {
                    prov.nombre = txtNombreProV.Text;
                    prov.ubicacion = txtUbicacion.Text;
                    prov.telefono = txtTelefono.Text;
                    prov.email = txtEmail.Text;

                    bd.Proveedores.Add(prov);
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Proveedor insertado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
                listadoP.dtvProveedores.Rows.Clear();               
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres editar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities bd = new RestauranteBDEntities())
                {
                    String idpv = lblCodigo.Text;
                    int idC = int.Parse(idpv);

                    prov = bd.Proveedores.Where(VerificarID => VerificarID.idProveedor == idC).First();
                    prov.nombre = txtNombreProV.Text;
                    prov.ubicacion = txtUbicacion.Text;
                    prov.telefono = txtTelefono.Text;
                    prov.email = txtEmail.Text;


                    bd.Entry(prov).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Proveedor editado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities bd = new RestauranteBDEntities())
                {
                    String id = lblCodigo.Text;

                    prov = bd.Proveedores.Find(int.Parse(id));
                    bd.Proveedores.Remove(prov);
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Proveedor ha sido eliminado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void FrmCRUDProveedor_Load(object sender, EventArgs e)
        {
            LimpiarCajas();           
            txtNombreProV.Enabled = false;
            txtUbicacion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
        }
    }
}
