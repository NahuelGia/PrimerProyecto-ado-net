namespace PrimerProyecto_ado_net
{
    partial class frmNuevoDisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoDisco));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaDeLanzamiento = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCantCanciones = new System.Windows.Forms.TextBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbUrlImagen = new System.Windows.Forms.PictureBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(126, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(48, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblFechaDeLanzamiento
            // 
            this.lblFechaDeLanzamiento.AutoSize = true;
            this.lblFechaDeLanzamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeLanzamiento.Location = new System.Drawing.Point(9, 72);
            this.lblFechaDeLanzamiento.Name = "lblFechaDeLanzamiento";
            this.lblFechaDeLanzamiento.Size = new System.Drawing.Size(165, 18);
            this.lblFechaDeLanzamiento.TabIndex = 1;
            this.lblFechaDeLanzamiento.Text = "Fecha De Lanzamiento:";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCanciones.Location = new System.Drawing.Point(9, 95);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(168, 18);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad De Canciones:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(115, 122);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 18);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Género:";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(108, 149);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(69, 18);
            this.lblFormato.TabIndex = 4;
            this.lblFormato.Text = "Formato:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(183, 44);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(144, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Location = new System.Drawing.Point(183, 96);
            this.txtCantCanciones.MaxLength = 4;
            this.txtCantCanciones.Name = "txtCantCanciones";
            this.txtCantCanciones.Size = new System.Drawing.Size(45, 20);
            this.txtCantCanciones.TabIndex = 2;
            this.txtCantCanciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantCanciones_KeyPress);
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(183, 70);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(81, 20);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // cbFormato
            // 
            this.cbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(183, 149);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(121, 21);
            this.cbFormato.TabIndex = 4;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(183, 122);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 21);
            this.cbGenero.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(71, 218);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 47);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 218);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 47);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbUrlImagen
            // 
            this.pbUrlImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrlImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbUrlImagen.ErrorImage")));
            this.pbUrlImagen.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbUrlImagen.InitialImage")));
            this.pbUrlImagen.Location = new System.Drawing.Point(365, 44);
            this.pbUrlImagen.Name = "pbUrlImagen";
            this.pbUrlImagen.Size = new System.Drawing.Size(325, 219);
            this.pbUrlImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrlImagen.TabIndex = 7;
            this.pbUrlImagen.TabStop = false;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlImagen.Location = new System.Drawing.Point(91, 176);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(83, 18);
            this.lblUrlImagen.TabIndex = 8;
            this.lblUrlImagen.Text = "Url Imagen:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(183, 177);
            this.txtUrlImagen.MaxLength = 200;
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(144, 20);
            this.txtUrlImagen.TabIndex = 9;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // frmNuevoDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 312);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.pbUrlImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbFormato);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.txtCantCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.lblFechaDeLanzamiento);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmNuevoDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmNuevoDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUrlImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaDeLanzamiento;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCantCanciones;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbUrlImagen;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
    }
}