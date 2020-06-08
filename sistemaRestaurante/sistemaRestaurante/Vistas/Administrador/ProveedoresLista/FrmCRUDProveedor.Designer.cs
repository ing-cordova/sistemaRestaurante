namespace sistemaRestaurante.Vistas.Administrador.ProveedoresLista
{
    partial class FrmCRUDProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNombreProV = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 36);
            this.panel1.TabIndex = 9;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.btnMinimizar.BackgroundImage = global::sistemaRestaurante.Properties.Resources.Minimize_Window;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(340, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 32);
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(108)))), ((int)(((byte)(125)))));
            this.btnSalir.BackgroundImage = global::sistemaRestaurante.Properties.Resources.CloseWindow;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(375, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 32);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(126, 52);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(68, 21);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(15, 121);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(109, 21);
            this.lblUbicacion.TabIndex = 24;
            this.lblUbicacion.Text = "UBICACION:";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(130, 115);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(241, 27);
            this.txtUbicacion.TabIndex = 23;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(41, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(83, 21);
            this.lblCategoria.TabIndex = 22;
            this.lblCategoria.Text = "NOMBRE:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(97, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 21);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID:";
            // 
            // txtNombreProV
            // 
            this.txtNombreProV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProV.Location = new System.Drawing.Point(130, 82);
            this.txtNombreProV.Name = "txtNombreProV";
            this.txtNombreProV.Size = new System.Drawing.Size(241, 27);
            this.txtNombreProV.TabIndex = 20;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(29, 151);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(95, 21);
            this.lblTelefono.TabIndex = 27;
            this.lblTelefono.Text = "TELEFONO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(130, 148);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(241, 27);
            this.txtTelefono.TabIndex = 26;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(61, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 21);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(130, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 27);
            this.txtEmail.TabIndex = 28;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.Location = new System.Drawing.Point(73, 239);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(129, 40);
            this.btnHabilitar.TabIndex = 31;
            this.btnHabilitar.Text = "HABILITAR";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(208, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 40);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(142, 239);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 40);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(142, 239);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 40);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmCRUDProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(411, 305);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtNombreProV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCRUDProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCRUDProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblUbicacion;
        public System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtNombreProV;
        private System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Button btnHabilitar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnEliminar;
    }
}