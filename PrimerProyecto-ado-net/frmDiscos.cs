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
using filtros;
using System.Globalization;
using System.Drawing.Text;

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
            cargarLista();
            cargarCbCampo();
        }

        private void cargarCbCampo()
        {
            cbCampo.Items.Add("Título");
            cbCampo.Items.Add("Fecha De Lanzamiento");
            cbCampo.Items.Add("Cantidad de Canciones");
        }

        private void cargarLista()
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            try
            {
                listaDiscos = discoNegocio.listar();
                dgvDiscos.DataSource = listaDiscos;
                ocultarColumnas();
                cargarImagen(listaDiscos[0].UrlImagen); // cargo la imagen del primer elemento
                txtFiltroRapido.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error inesperado reinicie la aplicación");
            }
        }

        private void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagen"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.SelectedRows.Count > 0)
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {

                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
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

        // Buttons
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoDisco formularioAlta = new frmNuevoDisco();
            formularioAlta.ShowDialog();
            cargarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtFiltroCondicion.Text = "";
            cbCampo.SelectedIndex = 0;
            cargarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow == null )
            {
                MessageBox.Show("Por favor, seleccione una fila antes de modificar un disco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            frmNuevoDisco formularioAlta = new frmNuevoDisco(seleccionado);
            formularioAlta.ShowDialog();
            cargarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDiscos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila antes de eliminar un disco.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DiscoNegocio negocio = new DiscoNegocio();
            Disco seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);  
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado);
                    cargarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el disco: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            FiltroABd filtro = new FiltroABd();

            try
            {
                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string condicion = txtFiltroCondicion.Text;

                if (campo == "Fecha De Lanzamiento")
                {
                    condicion = dtpFiltro.Value.ToString("yyyy/MM/dd");
                }

                dgvDiscos.DataSource = filtro.filtrar(campo, criterio, condicion);
            }
            catch (Exception)
            {

                MessageBox.Show("Se produjo un error intentelo nuevamente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        // TextBoxes

        private void txtFiltroRapido_KeyUp(object sender, KeyEventArgs e)
        {
            List<Disco> listaAFiltrar = listaDiscos;
            String condicionFiltro = txtFiltroRapido.Text;

            // Filtro por titulo
            if (!string.IsNullOrWhiteSpace(condicionFiltro))
            {
                listaAFiltrar = listaAFiltrar.FindAll(disco => disco.Titulo.ToUpper().Contains(condicionFiltro.ToUpper()));
            }

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaAFiltrar;
            ocultarColumnas();
        }

        private void txtFiltroCondicion_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFiltroCondicion.Text))
            {
                btnAplicar.Enabled = false;
            }
            else
            {
                btnAplicar.Enabled = true;
            }
        }

        private void txtFiltroCondicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el campo selccionado es la cantidad de canciones solo permite escribir carácteres numéricos
            if(cbCampo.SelectedIndex == 2 && !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b')) 
            {
                e.Handled = true;
            }
        }

        // Comboboxes
        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemElegido = cbCampo.SelectedItem.ToString();

            configuracionInicialControles();

            if (itemElegido == "Título")
            {
                cbCriterio.Items.Add("Empieza con..");
                cbCriterio.Items.Add("Termina con..");
                cbCriterio.Items.Add("Contiene..");
                txtFiltroCondicion.MaxLength = 100;
            } else
            {
                cbCriterio.Items.Add("Menor a..");
                cbCriterio.Items.Add("Mayor a..");
                cbCriterio.Items.Add("Igual a..");
                txtFiltroCondicion.MaxLength = 10;
            }
            
        }

        private void configuracionInicialControles()
        {
            cbCriterio.Items.Clear();
            btnAplicar.Enabled = false;
            txtFiltroCondicion.Visible = false;
            txtFiltroCondicion.Clear();
            dtpFiltro.Visible = false;
            btnAplicar.Location = new Point(372, 451);
        }

        private void cbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCampo.SelectedIndex != 1 )
            {
               txtFiltroCondicion.Visible = true ;
            } else
            {
               dtpFiltro.Visible = true ;
               btnAplicar.Enabled = true ;
            }
            btnAplicar.Location = new Point(485, 450);
        }




    }
}
