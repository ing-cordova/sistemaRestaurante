﻿using System;
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

namespace sistemaRestaurante.Vistas
{
    public partial class FrmLoguin : Form
    {
        public FrmLoguin()
        {
            InitializeComponent();
        }

        void LimpiarDatos()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        //Acá se valida el estado del txtPassword, para poder ver o no los carácteres.
        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
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

        //En este botón estará la validación a la base de datos.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("¡Complete todos los campos \npara iniciar sesión!", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using(RestauranteEntities bd = new RestauranteEntities())
                {
                    var lista = from usuario in bd.Usuarios
                                where usuario.nombredeUsuario == txtUsuario.Text
                                && usuario.contraseña == txtPassword.Text
                                select usuario;

                    if (lista.Count() > 0)
                    {
                        var rol = from user in bd.Usuarios
                                  where user.nombredeUsuario == txtUsuario.Text

                                  select new
                                  {
                                      IdRol = user.idRol
                                  };
                        foreach(var iterar in rol)
                        {
                            if(iterar.IdRol == 1)
                            {
                                FrmAccesoUsuario accessU = new FrmAccesoUsuario();
                                accessU.Show();
                                this.Hide();
                            }
                            else if (iterar.IdRol == 2)
                            {
                                FrmAccesoAdmin accessAd = new FrmAccesoAdmin();
                                accessAd.Show();
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
    }
}