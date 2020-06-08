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
    public partial class FrmCRUDCategorias : Form
    {
        public FrmCRUDCategorias()
        {
            InitializeComponent();
        }
        FrmListadoCategorias listadoC = new FrmListadoCategorias();
        Categorias Cate = new Categorias();
        private void limpiarcajas()
        {
            txtCategoria.Text = "";
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            limpiarcajas();
            txtCategoria.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Equals(""))
            {
                MessageBox.Show("¡Complete todos los campos para continuar!", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nombre = txtCategoria.Text;
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    var listaC = from categoria in bd.Categorias
                        where categoria.nombreCategoria.Equals(nombre) && categoria.estado == "Activo"
                                 select categoria;

                    if (listaC.Count() > 0)
                    {
                        MessageBox.Show("¡La Categoria ya existe!", "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var listaCate = from categoria in bd.Categorias
                            where categoria.nombreCategoria.Equals(nombre) && categoria.estado == "Inactivo"
                            select categoria;

                        if (listaCate.Count() > 0)
                        {
                            Cate = bd.Categorias.Where(VerificarNombre => VerificarNombre.nombreCategoria == nombre).First();
                            Cate.estado = "Activo";

                            bd.Entry(Cate).State = System.Data.Entity.EntityState.Modified;
                            bd.SaveChanges();
                            MessageBox.Show("¡Categoria insertada con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Close();
                            listadoC.dtvCategorias.Rows.Clear();
                            listadoC.btnEditarSelected.Enabled = true;
                            listadoC.btnEliminarSelected.Enabled = true;
                        }
                        else
                        {
                            Cate.nombreCategoria = txtCategoria.Text;
                            Cate.estado = "Activo";

                            bd.Categorias.Add(Cate);
                            bd.SaveChanges();
                            MessageBox.Show("¡Categoria insertada con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Close();
                            listadoC.dtvCategorias.Rows.Clear();
                        }
                    }
                }
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres editar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    String idca = lblCodigo.Text;
                    int idC = int.Parse(idca);

                    Cate = bd.Categorias.Where(VerificarID => VerificarID.idCategoria == idC).First();
                    Cate.nombreCategoria = txtCategoria.Text;

                    bd.Entry(Cate).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }

                MessageBox.Show("¡Categoria editada con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar?, \n¡la acción no se podrá deshacer!", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (RestauranteBDEntities1 bd = new RestauranteBDEntities1())
                {
                    String id = lblCodigo.Text;

                    Cate = bd.Categorias.Find(int.Parse(id));
                    Cate.estado = "Inactivo";
                    bd.Entry(Cate).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }

                MessageBox.Show("¡La Categoria ha sido eliminada con éxito!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        private void FrmCRUDCategorias_Load(object sender, EventArgs e)
        {
            limpiarcajas();
            txtCategoria.Enabled = false;
        }
    }
}
