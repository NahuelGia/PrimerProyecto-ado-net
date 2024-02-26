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
        private Disco disco = null;
        public frmNuevoDisco()
        {
            InitializeComponent();
        }

        public frmNuevoDisco(Disco recibido)
        {
            InitializeComponent();
            this.disco = recibido;
            this.Text = "Modificar Disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            DiscoNegocio negocio = new DiscoNegocio();

            if (camposObligatorios().Any(campo => String.IsNullOrWhiteSpace(campo.Text)))
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar");
                return;
            }

            try
            {
                if(disco == null)
                {
                    disco = new Disco();
                }

                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.CantidadCanciones = int.Parse(txtCantCanciones.Text);
                disco.Genero = (Genero)cbGenero.SelectedItem;
                disco.Formato = (Formato)cbFormato.SelectedItem;
                disco.UrlImagen = txtUrlImagen.Text;

                if(disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Disco modificado");

                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Disco agregado");
                }

                Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        

        }

        private void frmNuevoDisco_Load(object sender, EventArgs e)
        {
            FormatoNegocio formatoNegocio = new FormatoNegocio();
            GeneroNegocio generoNegocio = new GeneroNegocio();

            try
            {
                cbFormato.DataSource = formatoNegocio.listar();
                cbFormato.ValueMember = "Id";
                cbFormato.DisplayMember = "Nombre";

                cbGenero.DataSource = generoNegocio.listar();
                cbGenero.ValueMember = "Id";
                cbGenero.DisplayMember = "Nombre";

                if(disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFechaLanzamiento.Value = disco.FechaLanzamiento;
                    txtCantCanciones.Text = disco.CantidadCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagen;
                    cargarImagen(disco.UrlImagen);
                    cbFormato.SelectedValue = disco.Formato.Id;
                    cbGenero.SelectedValue = disco.Genero.Id;
                }

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

        private List<TextBox> camposObligatorios()
        {
            List<TextBox> lista = new List<TextBox>
            {
                txtCantCanciones,
                txtTitulo,
                txtUrlImagen
            };
            return lista;
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbUrlImagen.Load(imagen);
            }
            catch (Exception)
            {

                pbUrlImagen.Image = pbUrlImagen.ErrorImage;

            }
        }

    }
}
