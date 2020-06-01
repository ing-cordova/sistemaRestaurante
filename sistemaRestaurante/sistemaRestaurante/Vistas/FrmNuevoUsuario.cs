using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaRestaurante.Vistas;
using sistemaRestaurante.Model;

namespace sistemaRestaurante.Vistas
{
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        Usuarios user = new Usuarios();

        void LimpiarDatos()
        {
            txtEmail.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            cmbUsuario.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtVerifyPass.Text = "";
        }


        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmLoguin loguin = new FrmLoguin();
            loguin.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("") || txtNombres.Text.Equals("") || txtApellidos.Text.Equals("") || txtTelefono.Text.Equals("") || txtEdad.Text.Equals("") ||txtUsuario.Text.Equals("") || txtPassword.Text.Equals("") || cmbUsuario.Text.Equals("") || txtVerifyPass.Text.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPassword.Text == txtVerifyPass.Text)
                {
                    using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                    {
                        var lista = from usuario in bd.Usuarios
                                    where usuario.nombredeUsuario == txtUsuario.Text
                                    select usuario;

                        if (lista.Count() > 0)
                        {
                            MessageBox.Show("¡El usuario ya existe, intente con otro!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (cmbUsuario.Text == "Usuario")
                            {
                                using (RestauranteBDEntities1 db = new RestauranteBDEntities1())
                                {
                                    user.nombre = txtNombres.Text;
                                    user.apellidos = txtApellidos.Text;
                                    user.telefono = txtTelefono.Text;
                                    user.edad = int.Parse(txtEdad.Text);
                                    user.email = txtEmail.Text;
                                    user.nombredeUsuario = txtUsuario.Text;
                                    user.rol = cmbUsuario.Text;
                                    user.contraseña = txtPassword.Text;

                                    db.Usuarios.Add(user);
                                    db.SaveChanges();
                                }

                                MessageBox.Show("¡Cuenta creada con éxito!", "Registro Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                                FrmAccesoUsuario usuN = new FrmAccesoUsuario();
                                usuN.Show();
                                this.Hide();
                                LimpiarDatos();
                            }
                            else if (cmbUsuario.Text == "Administrador")
                            {
                                String PIN_ADMIN = "99999";
                                String PIN = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el PIN de seguridad:", "Registro de Administrador", "", 500, 300);
                                if (PIN == PIN_ADMIN)
                                {
                                    using (RestauranteBDEntities1 db = new RestauranteBDEntities1())
                                    {
                                        user.nombre = txtNombres.Text;
                                        user.apellidos = txtApellidos.Text;
                                        user.telefono = txtTelefono.Text;
                                        user.edad = int.Parse(txtEdad.Text);
                                        user.email = txtEmail.Text;
                                        user.nombredeUsuario = txtUsuario.Text;
                                        user.rol = cmbUsuario.Text;
                                        user.contraseña = txtPassword.Text;

                                        db.Usuarios.Add(user);
                                        db.SaveChanges();
                                    }

                                    MessageBox.Show("Nuevo Administrador Creado con éxito.", "¡Validación Correcta!", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    FrmAccesoAdmin admin = new FrmAccesoAdmin();
                                    admin.Show();
                                    this.Hide();
                                    LimpiarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("Clave de seguridad incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("¡Las contraseñas no coinciden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Validar para que solo se inserten números (txtTelefono):
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsControl(e.KeyChar))
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

        //Validar para que solo se inserten números (txtEdad):
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

        //Validar para que solo se inserten letras (txtNombres):
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        //Validar para que solo se inserten letras (txtApellidos):
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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
