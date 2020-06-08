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
    public partial class FrmListadoUsuarios : Form
    {
        public FrmListadoUsuarios()
        {
            InitializeComponent();
        }

        void Filtro()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                String usuarios = txtBusqueda.Text;

                if (rbotTodos.Checked == true)
                {
                    var Usuario = from usuario in bd.Usuarios
                                  where usuario.nombredeUsuario.Contains(usuarios)
                                  where usuario.estado == "Activo"

                                  select new
                                  {
                                      USUARIO = usuario.nombredeUsuario,
                                      NOMBRES = usuario.nombre,
                                      APELLIDOS = usuario.apellidos,
                                      EDAD = usuario.edad,
                                      TELEFONO = usuario.telefono,
                                      EMAIL = usuario.email,
                                      CONTRASENIA = usuario.contraseña,
                                      ROL = usuario.rol,
                                      ESTADO = usuario.estado
                                  };

                    foreach (var iterar in Usuario)
                    {
                        dtvUsuarios.Rows.Add(iterar.USUARIO, iterar.NOMBRES, iterar.APELLIDOS, iterar.EDAD, iterar.TELEFONO, iterar.EMAIL, iterar.CONTRASENIA, iterar.ROL, iterar.ESTADO);
                    }
                }
                else if (rbotUsuarios.Checked == true)
                {
                    var Usuario = from usuario in bd.Usuarios
                                  where usuario.nombredeUsuario.Contains(usuarios)
                                  where usuario.rol.Contains("Usuario")
                                  where usuario.estado == "Activo"
                                  select new
                                  {
                                      USUARIO = usuario.nombredeUsuario,
                                      NOMBRES = usuario.nombre,
                                      APELLIDOS = usuario.apellidos,
                                      EDAD = usuario.edad,
                                      TELEFONO = usuario.telefono,
                                      EMAIL = usuario.email,
                                      CONTRASENIA = usuario.contraseña,
                                      ROL = usuario.rol,
                                      ESTADO = usuario.estado
                                  };

                    foreach (var iterar in Usuario)
                    {
                        dtvUsuarios.Rows.Add(iterar.USUARIO, iterar.NOMBRES, iterar.APELLIDOS, iterar.EDAD, iterar.TELEFONO, iterar.EMAIL, iterar.CONTRASENIA, iterar.ROL, iterar.ESTADO);
                    }
                }
                else if (rbotAdministradores.Checked == true)
                {
                    var Usuario = from usuario in bd.Usuarios
                                  where usuario.nombredeUsuario.Contains(usuarios)
                                  where usuario.rol.Contains("Administrador")
                                  where usuario.estado == "Activo"
                                  select new
                                  {
                                      USUARIO = usuario.nombredeUsuario,
                                      NOMBRES = usuario.nombre,
                                      APELLIDOS = usuario.apellidos,
                                      EDAD = usuario.edad,
                                      TELEFONO = usuario.telefono,
                                      EMAIL = usuario.email,
                                      CONTRASENIA = usuario.contraseña,
                                      ROL = usuario.rol,
                                      ESTADO = usuario.estado
                                  };

                    foreach (var iterar in Usuario)
                    {
                        dtvUsuarios.Rows.Add(iterar.USUARIO, iterar.NOMBRES, iterar.APELLIDOS, iterar.EDAD, iterar.TELEFONO, iterar.EMAIL, iterar.CONTRASENIA, iterar.ROL, iterar.ESTADO);
                    }
                }
            }
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            dtvUsuarios.Rows.Clear();
            Filtro();

            if(dtvUsuarios.Rows.Count == 0)
            {
                btnEditarSelected.Enabled = false;
                btnEliminarSelected.Enabled = false;
            }
            else
            {
                btnEditarSelected.Enabled = true;
                btnEliminarSelected.Enabled = true;
            }
        }

        private void btnEditarSelected_Click(object sender, EventArgs e)
        {
            FrmCRUDUsuarios usua = new FrmCRUDUsuarios();
            usua.Show();
            usua.btnEliminar.Visible = false;

            String usuario = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombres = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellidos = dtvUsuarios.CurrentRow.Cells[2].Value.ToString();
            String edad = dtvUsuarios.CurrentRow.Cells[3].Value.ToString();
            String telefono = dtvUsuarios.CurrentRow.Cells[4].Value.ToString();
            String email = dtvUsuarios.CurrentRow.Cells[5].Value.ToString();
            String contrasenia = dtvUsuarios.CurrentRow.Cells[6].Value.ToString();
            String rol = dtvUsuarios.CurrentRow.Cells[7].Value.ToString();
            String estado = dtvUsuarios.CurrentRow.Cells[8].Value.ToString();

            usua.lblUsuario.Text = usuario;
            usua.txtNombres.Text = Nombres;
            usua.txtApellidos.Text = Apellidos;
            usua.txtEdad.Text = edad;
            usua.txtTelefono.Text = telefono;
            usua.txtEmail.Text = email;
            usua.txtContrasenia.Text = contrasenia;
            usua.cmbRol.Text = rol;
            usua.txtEstado.Text = estado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvUsuarios.Rows.Clear();
            Filtro();
        }

        private void btnEliminarSelected_Click(object sender, EventArgs e)
        {
            FrmCRUDUsuarios usua = new FrmCRUDUsuarios();
            usua.Show();
            usua.btnEditar.Visible = false;

            String usuario = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombres = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellidos = dtvUsuarios.CurrentRow.Cells[2].Value.ToString();
            String edad = dtvUsuarios.CurrentRow.Cells[3].Value.ToString();
            String telefono = dtvUsuarios.CurrentRow.Cells[4].Value.ToString();
            String email = dtvUsuarios.CurrentRow.Cells[5].Value.ToString();
            String contrasenia = dtvUsuarios.CurrentRow.Cells[6].Value.ToString();
            String rol = dtvUsuarios.CurrentRow.Cells[7].Value.ToString();
            String estado = dtvUsuarios.CurrentRow.Cells[8].Value.ToString();

            usua.lblUsuario.Text = usuario;
            usua.txtNombres.Text = Nombres;
            usua.txtApellidos.Text = Apellidos;
            usua.txtEdad.Text = edad;
            usua.txtTelefono.Text = telefono;
            usua.txtEmail.Text = email;
            usua.txtContrasenia.Text = contrasenia;
            usua.cmbRol.Text = rol;
            usua.txtEstado.Text = estado;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            dtvUsuarios.Rows.Clear();
            Filtro();
        }

        private void rbotTodos_CheckedChanged(object sender, EventArgs e)
        {
            Filtro();
            btnActualizar.PerformClick();
        }

        private void rbotUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            Filtro();
            btnActualizar.PerformClick();
        }

        private void rbotAdministradores_CheckedChanged(object sender, EventArgs e)
        {
            Filtro();
            btnActualizar.PerformClick();
        }
    }
}
