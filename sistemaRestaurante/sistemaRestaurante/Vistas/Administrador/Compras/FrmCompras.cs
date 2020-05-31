using sistemaRestaurante.Vistas.Usuario.ProductosLista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaRestaurante.Vistas.Administrador.Compras
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            FrmAccesoAdmin admin = new FrmAccesoAdmin();
            lblUsuario.Text = admin.lblUsuarioAct.Text;
        }
    }
}
