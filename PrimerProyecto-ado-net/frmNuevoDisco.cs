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
    public partial class frmNuevoDisco : Form
    {
        public frmNuevoDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();

            disco.Titulo = txtTitulo.Text;
            disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
            disco.CantidadCanciones = int.Parse(txtCantCanciones.Text);
            disco.Genero = (Genero)cbGenero.SelectedItem;
            disco.Formato = (Formato)cbFormato.SelectedItem;

            negocio.Agregar(disco);

            Close();

        }

        private void frmNuevoDisco_Load(object sender, EventArgs e)
        {
            FormatoNegocio formatoNegocio = new FormatoNegocio();
            GeneroNegocio generoNegocio = new GeneroNegocio();

            try
            {
                cbFormato.DataSource = formatoNegocio.listar();
                cbGenero.DataSource = generoNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtCantCanciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
