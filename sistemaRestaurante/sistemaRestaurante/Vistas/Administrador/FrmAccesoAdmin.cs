using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para arrastrar ventana.
using System.Runtime.InteropServices;
using sistemaRestaurante.Vistas.Administrador.Productos;
using sistemaRestaurante.Vistas.Administrador.ProveedoresLista;
using sistemaRestaurante.Vistas.Administrador.CategoriasLista;
using sistemaRestaurante.Vistas.Administrador.UsuariosLista;
using sistemaRestaurante.Vistas.Administrador.CompraProductos;
using sistemaRestaurante.Vistas.Administrador.Compras;
using sistemaRestaurante.Model;

namespace sistemaRestaurante.Vistas
{
    public partial class FrmAccesoAdmin : Form
    {
        public FrmAccesoAdmin()
        {
            InitializeComponent();
        }

        #region FuncionesFormulario
        //Este codigo se utiliza para arrastrar la ventana.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Metodo que hace que se pueda mover.
        private void barraTitulos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void AbrirFormulario(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult entrada = MessageBox.Show("¿Estás seguro que desea salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (entrada == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        int ly, lx;
        int sw, sh;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            //this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestoreWindow.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestoreWindow_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

            //this.WindowState = FormWindowState.Normal;
            btnRestoreWindow.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMasOpciones_Click(object sender, EventArgs e)
        {
            if (Submenu.Visible == false)
            {
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            DialogResult entrada = MessageBox.Show("¿Estás seguro que desea cerrar sesión?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (entrada == DialogResult.OK)
            {
                FrmLoguin loguin = new FrmLoguin();
                loguin.Show();
                this.Close();
                Submenu.Visible = false;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProductos());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProveedores());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoCategorias());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoUsuarios());
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProductosCompra());
        }

        public static FrmCompras compras = new FrmCompras();
        private void btnCompras_Click(object sender, EventArgs e)
        {

            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            compras.TopLevel = false;
            compras.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(compras);
            this.panelContenedor.Tag = compras;
            compras.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAccesoAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmDatosFechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
