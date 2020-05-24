namespace sistemaRestaurante.Vistas
{
    partial class FrmAccesoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccesoUsuario));
            this.barraTitulos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Submenu = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.btnMasOpciones = new System.Windows.Forms.Button();
            this.btnCerrarS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRestoreWindow = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.barraTitulos.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.Submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulos
            // 
            this.barraTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.barraTitulos.Controls.Add(this.label1);
            this.barraTitulos.Controls.Add(this.lblHora);
            this.barraTitulos.Controls.Add(this.lblFecha);
            this.barraTitulos.Controls.Add(this.button2);
            this.barraTitulos.Controls.Add(this.btnRestoreWindow);
            this.barraTitulos.Controls.Add(this.btnMaximizar);
            this.barraTitulos.Controls.Add(this.btnSalir);
            this.barraTitulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulos.Location = new System.Drawing.Point(0, 0);
            this.barraTitulos.Name = "barraTitulos";
            this.barraTitulos.Size = new System.Drawing.Size(1069, 42);
            this.barraTitulos.TabIndex = 0;
            this.barraTitulos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulos_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(349, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.lblHora.Location = new System.Drawing.Point(369, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 25);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(75, 25);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.MenuVertical.Controls.Add(this.panel8);
            this.MenuVertical.Controls.Add(this.btnMasOpciones);
            this.MenuVertical.Controls.Add(this.Submenu);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 42);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 593);
            this.MenuVertical.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel8.Location = new System.Drawing.Point(2, 231);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(6, 40);
            this.panel8.TabIndex = 14;
            // 
            // Submenu
            // 
            this.Submenu.Controls.Add(this.btnCerrarS);
            this.Submenu.Controls.Add(this.panel7);
            this.Submenu.Location = new System.Drawing.Point(51, 277);
            this.Submenu.Name = "Submenu";
            this.Submenu.Size = new System.Drawing.Size(169, 54);
            this.Submenu.TabIndex = 12;
            this.Submenu.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel7.Location = new System.Drawing.Point(-2, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 40);
            this.panel7.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel2.Location = new System.Drawing.Point(2, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 40);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel1.Location = new System.Drawing.Point(2, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 40);
            this.panel1.TabIndex = 5;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 42);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(849, 593);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tmHoraFecha
            // 
            this.tmHoraFecha.Enabled = true;
            this.tmHoraFecha.Tick += new System.EventHandler(this.tmHoraFecha_Tick);
            // 
            // btnMasOpciones
            // 
            this.btnMasOpciones.FlatAppearance.BorderSize = 0;
            this.btnMasOpciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnMasOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnMasOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasOpciones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasOpciones.ForeColor = System.Drawing.Color.White;
            this.btnMasOpciones.Image = global::sistemaRestaurante.Properties.Resources.more;
            this.btnMasOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasOpciones.Location = new System.Drawing.Point(7, 231);
            this.btnMasOpciones.Name = "btnMasOpciones";
            this.btnMasOpciones.Size = new System.Drawing.Size(213, 40);
            this.btnMasOpciones.TabIndex = 13;
            this.btnMasOpciones.Text = "  Más Opciones";
            this.btnMasOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasOpciones.UseVisualStyleBackColor = true;
            this.btnMasOpciones.Click += new System.EventHandler(this.btnMasOpciones_Click);
            // 
            // btnCerrarS
            // 
            this.btnCerrarS.FlatAppearance.BorderSize = 0;
            this.btnCerrarS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnCerrarS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarS.ForeColor = System.Drawing.Color.White;
            this.btnCerrarS.Image = global::sistemaRestaurante.Properties.Resources.arrows;
            this.btnCerrarS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarS.Location = new System.Drawing.Point(6, 0);
            this.btnCerrarS.Name = "btnCerrarS";
            this.btnCerrarS.Size = new System.Drawing.Size(159, 40);
            this.btnCerrarS.TabIndex = 2;
            this.btnCerrarS.Text = "  Cerrar Sesión";
            this.btnCerrarS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarS.UseVisualStyleBackColor = true;
            this.btnCerrarS.Click += new System.EventHandler(this.btnCerrarS_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::sistemaRestaurante.Properties.Resources.Venta;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "  Comprar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::sistemaRestaurante.Properties.Resources.barcode;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(7, 139);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(213, 40);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "  Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaRestaurante.Properties.Resources.Inicio;
            this.pictureBox1.Location = new System.Drawing.Point(47, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.button2.BackgroundImage = global::sistemaRestaurante.Properties.Resources.Minimize_Window;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(955, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 32);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRestoreWindow
            // 
            this.btnRestoreWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnRestoreWindow.BackgroundImage = global::sistemaRestaurante.Properties.Resources.Restore_Window;
            this.btnRestoreWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestoreWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRestoreWindow.FlatAppearance.BorderSize = 0;
            this.btnRestoreWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreWindow.Location = new System.Drawing.Point(994, 3);
            this.btnRestoreWindow.Name = "btnRestoreWindow";
            this.btnRestoreWindow.Size = new System.Drawing.Size(33, 32);
            this.btnRestoreWindow.TabIndex = 12;
            this.btnRestoreWindow.UseVisualStyleBackColor = false;
            this.btnRestoreWindow.Visible = false;
            this.btnRestoreWindow.Click += new System.EventHandler(this.btnRestoreWindow_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnMaximizar.BackgroundImage = global::sistemaRestaurante.Properties.Resources.Maximize_Window;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(994, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(33, 32);
            this.btnMaximizar.TabIndex = 11;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnSalir.BackgroundImage = global::sistemaRestaurante.Properties.Resources.CloseWindow;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1033, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 32);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAccesoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1069, 635);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.barraTitulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAccesoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAccesoUsuario";
            this.barraTitulos.ResumeLayout(false);
            this.barraTitulos.PerformLayout();
            this.MenuVertical.ResumeLayout(false);
            this.Submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulos;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRestoreWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnMasOpciones;
        private System.Windows.Forms.Panel Submenu;
        private System.Windows.Forms.Button btnCerrarS;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmHoraFecha;
    }
}