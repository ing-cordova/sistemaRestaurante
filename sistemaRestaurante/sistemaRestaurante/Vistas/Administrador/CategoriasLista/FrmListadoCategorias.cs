using sistemaRestaurante.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaRestaurante.Vistas.Administrador.CategoriasLista
{
    public partial class FrmListadoCategorias : Form
    {
        public FrmListadoCategorias()
        {
            InitializeComponent();
        }
        private void cargardatos()
        {
            using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
            {
                var tablacategorias = bd.Categorias;

                foreach (var iterar in tablacategorias)
                {
                    dtvCategorias.Rows.Add(iterar.idCategoria, iterar.nombreCategoria);
                }
            }
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            FrmCRUDCategorias crudC = new FrmCRUDCategorias();
            crudC.Show();
            crudC.lblCodigo.Visible = false;
            crudC.btnEliminar.Visible = false;
            crudC.btnEditar.Visible = false;
        }

        private void FrmListadoCategorias_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dtvCategorias.Rows.Clear();
            cargardatos();
        }

        private void btnEditarSelected_Click(object sender, EventArgs e)
        {
            FrmCRUDCategorias crudC = new FrmCRUDCategorias();
            crudC.Show();
            crudC.lblCodigo.Visible = true;
            crudC.btnEliminar.Visible = false;
            crudC.btnEditar.Visible = true;
            crudC.btnAgregar.Visible = false;
            crudC.btnHabilitar.Visible = false;
            /***************************************/
            crudC.txtCategoria.Enabled = true;

            /************************************************************************/
            String id = dtvCategorias.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvCategorias.CurrentRow.Cells[1].Value.ToString();


            crudC.lblCodigo.Text = id;
            crudC.txtCategoria.Text = Nombre;

        }

        private void btnEliminarSelected_Click(object sender, EventArgs e)
        {
            FrmCRUDCategorias crudC = new FrmCRUDCategorias();
            crudC.Show();
            crudC.lblCodigo.Visible = true;
            crudC.btnEliminar.Visible = true;
            crudC.btnEditar.Visible = false;
            crudC.btnAgregar.Visible = false;
            crudC.btnHabilitar.Visible = false;
            /***************************************/
            crudC.txtCategoria.Enabled = true;

            /**********************************************************************/
            String id = dtvCategorias.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtvCategorias.CurrentRow.Cells[1].Value.ToString();


            crudC.lblCodigo.Text = id;
            crudC.txtCategoria.Text = Nombre;

        }
    }
}
