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

namespace sistemaRestaurante.Vistas.Administrador.UsuariosLista
{
    public partial class FrmCRUDUsuarios : Form
    {
        public FrmCRUDUsuarios()
        {
            InitializeComponent();
        }

        Usuarios usua = new Usuarios();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void CargarCombo()
        {
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Usuario");
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmCRUDUsuarios_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres editar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    String usuario = lblUsuario.Text;

                    usua = bd.Usuarios.Where(VerificarUsuario => VerificarUsuario.nombredeUsuario == usuario).First();
                    usua.nombre = txtNombres.Text;
                    usua.apellidos = txtApellidos.Text;
                    usua.edad = int.Parse(txtEdad.Text);
                    usua.telefono = txtTelefono.Text;
                    usua.email = txtEmail.Text;
                    usua.contraseña = txtContrasenia.Text;
                    usua.rol = cmbRol.Text;

                    bd.Entry(usua).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Usuario editado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }       
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminarlo?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    String usuario = lblUsuario.Text;

                    usua = bd.Usuarios.Find(usuario);
                    bd.Usuarios.Remove(usua);
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Usuario eliminado con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
