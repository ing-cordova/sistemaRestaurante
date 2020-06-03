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

namespace sistemaRestaurante
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        public static  FrmLoguin Login = new FrmLoguin();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                lblProgreso.Text = ("Cargando el Sistema... " + progressBar1.Value + " %").ToString();
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Login.Show();
            }
        }
    }
}
