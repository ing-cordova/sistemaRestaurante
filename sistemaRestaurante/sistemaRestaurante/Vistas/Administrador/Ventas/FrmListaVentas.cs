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
                    if (txtBusqueda.Text.Equals(""))
                    {
                        var Ventas = from ventas in bd.Ventas
                            where ventas.estado != "Pagada"

                            select new
                            {
                                ID = ventas.idVenta,
                                FECHA = ventas.fechadeVenta,
                                NMESA = ventas.NumMesa,
                                TOTAL = ventas.totalPagar,
                                ESTADO = ventas.estado,

                            };


                        foreach (var iterar in Ventas)
                        {
                            dtvVentas.Rows.Add(iterar.ID, iterar.FECHA, iterar.NMESA, iterar.TOTAL, iterar.ESTADO);
                        }
                    }
                    else
                    {
                        int Busqueda = Int32.Parse(txtBusqueda.Text);
                        var listaVentas = from ventas in bd.Ventas
                            where ventas.estado != "Pagada" && ventas.NumMesa == Busqueda
                            select new
                            {
                                ID = ventas.idVenta,
                                FECHA = ventas.fechadeVenta,
                                NMESA = ventas.NumMesa,
                                ESTADO = ventas.estado,
                            };
                        if (listaVentas.Count() > 0)
                        {
                            foreach (var iterar in listaVentas)
                            {
                                dtvVentas.Rows.Add(iterar.ID, iterar.FECHA, iterar.NMESA, iterar.ESTADO);
                            }
                        }

                    }
                }
                else if (rbotEnviada.Checked == true)
                {
                    if (txtBusqueda.Text.Equals(""))
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
                    else
                    {
                        int Busqueda = Int32.Parse(txtBusqueda.Text);
                        var listaVentas = from ventas in bd.Ventas
                            where ventas.estado.Equals("Enviada") && ventas.NumMesa == Busqueda
                            select new
                            {
                                ID = ventas.idVenta,
                                FECHA = ventas.fechadeVenta,
                                NMESA = ventas.NumMesa,
                                ESTADO = ventas.estado,
                            };
                        if(listaVentas.Count()>0)
                        {
                            foreach (var iterar in listaVentas)
                            {
                                dtvVentas.Rows.Add(iterar.ID, iterar.FECHA, iterar.NMESA, iterar.ESTADO);
                            }
                        }
                        
                    }
                }
                else if (rbotRecibidas.Checked == true)
                {
                    if (txtBusqueda.Text.Equals(""))
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
                    else
                    {
                        int Busqueda = Int32.Parse(txtBusqueda.Text);
                        var listaVentas = from ventas in bd.Ventas
                            where ventas.estado.Equals("Recibida") && ventas.NumMesa == Busqueda
                            select new
                            {
                                ID = ventas.idVenta,
                                FECHA = ventas.fechadeVenta,
                                NMESA = ventas.NumMesa,
                                ESTADO = ventas.estado,
                            };
                        if (listaVentas.Count() > 0)
                        {
                            foreach (var iterar in listaVentas)
                            {
                                dtvVentas.Rows.Add(iterar.ID, iterar.FECHA, iterar.NMESA, iterar.ESTADO);
                            }
                        }

                    }
                }
                else if (rbotEntregadas.Checked == true)
                {
                    if (txtBusqueda.Text.Equals(""))
                    {
                        var Ventas = from ventas in bd.Ventas
                            where ventas.estado.Equals("Entregada")
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
                    else
                    {
                        int Busqueda = Int32.Parse(txtBusqueda.Text);
                        var listaVentas = from ventas in bd.Ventas
                            where ventas.estado.Equals("Entregada") && ventas.NumMesa == Busqueda
                            select new
                            {
                                ID = ventas.idVenta,
                                FECHA = ventas.fechadeVenta,
                                NMESA = ventas.NumMesa,
                                ESTADO = ventas.estado,
                            };
                        if (listaVentas.Count() > 0)
                        {
                            foreach (var iterar in listaVentas)
                            {
                                dtvVentas.Rows.Add(iterar.ID, iterar.FECHA, iterar.NMESA, iterar.ESTADO);
                            }
                        }

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
            if(dtvVentas.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay orden en proceso!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Inicio.Login.TipodeAcceso == 1)
                {
                    FrmDetalles.txtIdVenta.Text = dtvVentas.CurrentRow.Cells[0].Value.ToString();
                    FrmLoguin.accessU.AbrirFormulario(FrmDetalles);
                    this.Close();
                }
                else if (Inicio.Login.TipodeAcceso == 0)
                {
                    FrmDetalles.txtIdVenta.Text = dtvVentas.CurrentRow.Cells[0].Value.ToString();
                    FrmLoguin.accessAd.AbrirFormulario(FrmDetalles);
                    this.Close();
                }
            } 
        }

        private void rbotTodos_CheckedChanged(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void rbotEnviada_CheckedChanged(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void rbotRecibidas_CheckedChanged(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void rbotEntregadas_CheckedChanged(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtvVentas.Rows.Clear();
                Filtro();
            }
            catch(Exception ex)
            {

            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
