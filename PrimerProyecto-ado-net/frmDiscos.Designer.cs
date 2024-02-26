namespace PrimerProyecto_ado_net
{
    partial class frmDiscos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscos));
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbTapa = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroCondicion = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.dtpFiltro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.Location = new System.Drawing.Point(23, 82);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(667, 248);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbTapa
            // 
            this.pbTapa.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbTapa.ErrorImage")));
            this.pbTapa.Location = new System.Drawing.Point(696, 82);
            this.pbTapa.Name = "pbTapa";
            this.pbTapa.Size = new System.Drawing.Size(307, 248);
            this.pbTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTapa.TabIndex = 1;
            this.pbTapa.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(37, 358);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 52);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(615, 336);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(75, 23);
            this.btnRestablecer.TabIndex = 3;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(200, 358);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 52);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(364, 358);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 52);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(34, 47);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(101, 13);
            this.lblFiltroRapido.TabIndex = 6;
            this.lblFiltroRapido.Text = "Busqueda por titulo:";
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Location = new System.Drawing.Point(154, 44);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(184, 20);
            this.txtFiltroRapido.TabIndex = 7;
            this.txtFiltroRapido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltroRapido_KeyUp);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(20, 454);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(61, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Buscar por:";
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(87, 450);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(135, 21);
            this.cbCampo.TabIndex = 9;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(228, 454);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(276, 451);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(90, 21);
            this.cbCriterio.TabIndex = 11;
            this.cbCriterio.SelectedIndexChanged += new System.EventHandler(this.cbCriterio_SelectedIndexChanged);
            // 
            // txtFiltroCondicion
            // 
            this.txtFiltroCondicion.Location = new System.Drawing.Point(372, 452);
            this.txtFiltroCondicion.MaxLength = 100;
            this.txtFiltroCondicion.Name = "txtFiltroCondicion";
            this.txtFiltroCondicion.Size = new System.Drawing.Size(94, 20);
            this.txtFiltroCondicion.TabIndex = 13;
            this.txtFiltroCondicion.Visible = false;
            this.txtFiltroCondicion.TextChanged += new System.EventHandler(this.txtFiltroCondicion_TextChanged);
            this.txtFiltroCondicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroCondicion_KeyPress);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Location = new System.Drawing.Point(372, 451);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 14;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // dtpFiltro
            // 
            this.dtpFiltro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpFiltro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltro.Location = new System.Drawing.Point(372, 454);
            this.dtpFiltro.Name = "dtpFiltro";
            this.dtpFiltro.Size = new System.Drawing.Size(94, 20);
            this.dtpFiltro.TabIndex = 15;
            this.dtpFiltro.Visible = false;
            // 
            // frmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 500);
            this.Controls.Add(this.dtpFiltro);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txtFiltroCondicion);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbTapa);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "frmDiscos";
            this.Text = "Discos DB";
            this.Load += new System.EventHandler(this.frmDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbTapa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.TextBox txtFiltroCondicion;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.DateTimePicker dtpFiltro;
    }
}

