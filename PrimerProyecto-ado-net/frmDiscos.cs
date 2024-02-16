using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace PrimerProyecto_ado_net
{
    public partial class frmDiscos : Form

    {  
        private List<Disco> listaDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            try
            {
                listaDiscos = discoNegocio.listar();
                dgvDiscos.DataSource = listaDiscos;
                dgvDiscos.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaDiscos[0].UrlImagen); // cargo la imagen del primer elemento
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

            this.cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbTapa.Load(imagen);
            }
            catch (Exception )
            {

                pbTapa.Image = pbTapa.ErrorImage;
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoDisco formularioAlta = new frmNuevoDisco();
            formularioAlta.ShowDialog();
            cargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            frmNuevoDisco formularioAlta = new frmNuevoDisco(seleccionado);
            formularioAlta.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            Disco seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);  
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado);
                    this.cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
