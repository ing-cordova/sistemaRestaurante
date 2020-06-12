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

namespace sistemaRestaurante.Vistas.Administrador.Ventas
{
    public partial class FrmRptFacturaVenta : Form
    {
        public FrmRptFacturaVenta()
        {
            InitializeComponent();
        }

        private void FrmRptFacturaVenta_Load(object sender, EventArgs e)
        {
            using(RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {

            }
        }
    }
}
