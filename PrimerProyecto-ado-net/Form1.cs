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
            DiscoNegocio discoNegocio = new DiscoNegocio();
            listaDiscos = discoNegocio.listar();

            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["UrlImagen"].Visible = false; 

            this.cargarImagen(listaDiscos[0].UrlImagen ); // cargo la imagen del primer elemento

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
            frmNuevoDisco formulario = new frmNuevoDisco();
            formulario.ShowDialog();
        }
    }
}
