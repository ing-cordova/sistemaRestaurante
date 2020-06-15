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
using sistemaRestaurante.Vistas;
using sistemaRestaurante.Vistas.Administrador.Compras;

namespace sistemaRestaurante.Vistas
{
    public partial class FrmLoguin : Form
    {
        public FrmLoguin()
        {
            InitializeComponent();
        }

        public static FrmAccesoAdmin accessAd = new FrmAccesoAdmin();
        public static FrmAccesoUsuario accessU = new FrmAccesoUsuario();
        void LimpiarDatos()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        //Acá se valida el estado del txtPassword, para poder ver o no los carácteres.
        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password")
            {
                if (checkBoxPass.Checked == true)
                {
                    if (txtPassword.PasswordChar == '•')
                    {
                        txtPassword.PasswordChar = '\0';
                    }
                }
                else
                {
                    txtPassword.PasswordChar = '•';
                }
            }
            
        }

        //En este botón estará la validación a la base de datos.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("¡Complete todos los campos \npara iniciar sesión!", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using(RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    var lista = from usuario in bd.Usuarios
                                where usuario.nombredeUsuario == txtUsuario.Text
                                && usuario.contraseña == txtPassword.Text && usuario.estado == "Activo"
                                select usuario;

                    if (lista.Count() > 0)
                    {
                        var rol = from user in bd.Usuarios
                                  where user.nombredeUsuario == txtUsuario.Text

                                  select new
                                  {
                                      Rol = user.rol
                                  };
                        foreach(var iterar in rol)
                        {
                            if(iterar.Rol == "Usuario")
                            {
                                accessU.Show();
                                accessU.lblUsuarioAct.Text = txtUsuario.Text;
                                FrmAccesoUsuario.venta.lblUsuario.Text = txtUsuario.Text;
                                this.Hide();
                            }
                            else if (iterar.Rol == "Administrador")
                            {
                                accessAd.Show();
                                accessAd.lblUsuarioAct.Text = txtUsuario.Text;
                                FrmAccesoAdmin.compras.lblUsuario.Text = txtUsuario.Text;
                                FrmAccesoAdmin.venta.lblUsuario.Text = txtUsuario.Text;
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡El usuario no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LimpiarDatos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult entrada = MessageBox.Show("¿Estás seguro que desea salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (entrada == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lklNuevoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNuevoUsuario newUser = new FrmNuevoUsuario();
            newUser.Show();
            this.Hide();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                if (checkBoxPass.Checked == false)
                {

                    txtPassword.PasswordChar = '•';
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                }
                
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Username")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Username";
            }
        }
    }
}
