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
using  sistemaRestaurante.Vistas;
using sistemaRestaurante.Vistas.Administrador.UsuariosLista;

namespace sistemaRestaurante.Vistas.Administrador.Ventas
{
    public partial class FrmListaVentas : Form
    {
        public FrmListaVentas()
        {
            InitializeComponent();
        }


        void Filtro()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                

                if (rbotTodos.Checked == true)
                {
                    var Ventas = from ventas in bd.Ventas
                        where ventas.estado != "Entregada"

                        select new
                        {
                            ID = ventas.idVenta,
                            FECHA = ventas.fechadeVenta,
                            NMESA = ventas.NumMesa,
                            ESTADO = ventas.estado,

                        };


                    foreach (var iterar in Ventas)
                    {
                        dtvVentas.Rows.Add(iterar.ID, iterar.FECHA, iterar.NMESA, iterar.ESTADO);
                    }
                }
                else if (rbotEnviada.Checked == true)
                {
                    var Ventas = from ventas in bd.Ventas
                                  where ventas.estado.Equals("Enviada")
                                  select new
                                  {
                                      ID = ventas.idVenta,
                                      FECHA = ventas.fechadeVenta,
                                      NMESA = ventas.NumMesa,
                                      ESTADO = ventas.estado,
                                  };

                    foreach (var iterar in Ventas)
                    {
                        dtvVentas.Rows.Add(iterar.ID, iterar.FECHA, iterar.NMESA, iterar.ESTADO);
                    }
                }
                else if (rbotRecibidas.Checked == true)
                {
                    var Ventas = from ventas in bd.Ventas
                        where ventas.estado.Equals("Recibida")
                        select new
                        {
                            ID = ventas.idVenta,
                            FECHA = ventas.fechadeVenta,
                            NMESA = ventas.NumMesa,
                            ESTADO = ventas.estado,
                        };

                    foreach (var iterar in Ventas)
                    {
                        dtvVentas.Rows.Add(iterar.ID, iterar.FECHA, iterar.NMESA, iterar.ESTADO);
                    }
                }
            }
        }

        private void FrmListadoUsuarios_Load(object sender, EventArgs e)
        {
            dtvVentas.Rows.Clear();
            Filtro();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvVentas.Rows.Clear();
            Filtro();
        }

       
        public static FrmDetallesVenta FrmDetalles = new FrmDetallesVenta();
        private void btnVerSelected_Click(object sender, EventArgs e)
        {
            FrmDetalles.txtIdVenta.Text = dtvVentas.CurrentRow.Cells[0].Value.ToString();
            FrmLoguin.accessAd.AbrirFormulario(FrmDetalles);
            this.Close();
        }
    }
}
