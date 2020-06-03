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
using sistemaRestaurante.Vistas.Usuario.ProductosLista;
using sistemaRestaurante.Vistas.Administrador.Ventas;

namespace sistemaRestaurante.Vistas
{
    public partial class FrmAccesoUsuario : Form
    {
        public FrmAccesoUsuario()
        {
            InitializeComponent();
        }

        public void AbrirFormulario(object FormHijo)
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

        private void OrdenarMenu()
        {
            btnMasOpciones.Location = new Point(9, 231);
            panel8.Location = new Point(1, 231);
            Submenu.Location = new Point(48, 277);
        }
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

        private void btnRestoreWindow_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

            //this.WindowState = FormWindowState.Normal;
            btnRestoreWindow.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListadoProductos());
        }

        public static FrmVentas venta = new FrmVentas();
        private void button1_Click(object sender, EventArgs e)
        {
            if (SubMenuVentas.Visible == false)
            {
                SubMenuVentas.Visible = true;
                btnMasOpciones.Location = new Point(9, 322);
                panel8.Location = new Point(1, 322);
                Submenu.Location = new Point(48, 368);
            }
            else
            {
                SubMenuVentas.Visible = false;
                OrdenarMenu();
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            venta.TopLevel = false;
            venta.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(venta);
            this.panelContenedor.Tag = venta;
            venta.Show();
        }

        private void FrmAccesoUsuario_Load(object sender, EventArgs e)
        {
            OrdenarMenu();
        }

        private void btnVentaProceso_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListaVentas());
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            DialogResult entrada = MessageBox.Show("¿Estás seguro que desea cerrar sesión?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (entrada == DialogResult.OK)
            {
                FrmLoguin loguin = new FrmLoguin();
                loguin.Show();
                this.Hide();
                Submenu.Visible = false;
            }
        }

        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
