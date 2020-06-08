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
            this.lblUsuarioAct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRestoreWindow = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SubMenuVentas = new System.Windows.Forms.Panel();
            this.btnVentaProceso = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnMasOpciones = new System.Windows.Forms.Button();
            this.Submenu = new System.Windows.Forms.Panel();
            this.btnCerrarS = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tmHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.barraTitulos.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.SubMenuVentas.SuspendLayout();
            this.Submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulos
            // 
            this.barraTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.barraTitulos.Controls.Add(this.lblUsuarioAct);
            this.barraTitulos.Controls.Add(this.label2);
            this.barraTitulos.Controls.Add(this.label3);
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
            this.barraTitulos.Size = new System.Drawing.Size(1236, 42);
            this.barraTitulos.TabIndex = 0;
            this.barraTitulos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulos_MouseDown);
            // 
            // lblUsuarioAct
            // 
            this.lblUsuarioAct.AutoSize = true;
            this.lblUsuarioAct.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioAct.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.lblUsuarioAct.Location = new System.Drawing.Point(596, 8);
            this.lblUsuarioAct.Name = "lblUsuarioAct";
            this.lblUsuarioAct.Size = new System.Drawing.Size(87, 25);
            this.lblUsuarioAct.TabIndex = 20;
            this.lblUsuarioAct.Text = "Usuario";
            this.lblUsuarioAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(518, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(538, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "User:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.button2.BackgroundImage = global::sistemaRestaurante.Properties.Resources.Minimize_Window;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1122, 3);
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
            this.btnRestoreWindow.Location = new System.Drawing.Point(1161, 3);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1161, 3);
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
            this.btnSalir.Location = new System.Drawing.Point(1200, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 32);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.MenuVertical.Controls.Add(this.SubMenuVentas);
            this.MenuVertical.Controls.Add(this.panel8);
            this.MenuVertical.Controls.Add(this.btnMasOpciones);
            this.MenuVertical.Controls.Add(this.Submenu);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Controls.Add(this.pbLogo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 42);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 697);
            this.MenuVertical.TabIndex = 1;
            // 
            // SubMenuVentas
            // 
            this.SubMenuVentas.Controls.Add(this.btnVentaProceso);
            this.SubMenuVentas.Controls.Add(this.panel13);
            this.SubMenuVentas.Controls.Add(this.btnNuevaVenta);
            this.SubMenuVentas.Controls.Add(this.panel12);
            this.SubMenuVentas.Location = new System.Drawing.Point(12, 231);
            this.SubMenuVentas.Name = "SubMenuVentas";
            this.SubMenuVentas.Size = new System.Drawing.Size(210, 85);
            this.SubMenuVentas.TabIndex = 4;
            this.SubMenuVentas.Visible = false;
            // 
            // btnVentaProceso
            // 
            this.btnVentaProceso.FlatAppearance.BorderSize = 0;
            this.btnVentaProceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnVentaProceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnVentaProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaProceso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaProceso.ForeColor = System.Drawing.Color.White;
            this.btnVentaProceso.Image = global::sistemaRestaurante.Properties.Resources.hourglass;
            this.btnVentaProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaProceso.Location = new System.Drawing.Point(8, 46);
            this.btnVentaProceso.Name = "btnVentaProceso";
            this.btnVentaProceso.Size = new System.Drawing.Size(200, 40);
            this.btnVentaProceso.TabIndex = 12;
            this.btnVentaProceso.Text = "  Ventas en Proceso";
            this.btnVentaProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaProceso.UseVisualStyleBackColor = true;
            this.btnVentaProceso.Click += new System.EventHandler(this.btnVentaProceso_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel13.Location = new System.Drawing.Point(-2, 46);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 40);
            this.panel13.TabIndex = 13;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVenta.Image = global::sistemaRestaurante.Properties.Resources.add__1_;
            this.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.Location = new System.Drawing.Point(8, 0);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(159, 40);
            this.btnNuevaVenta.TabIndex = 2;
            this.btnNuevaVenta.Text = "  Nueva Venta";
            this.btnNuevaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel12.Location = new System.Drawing.Point(-2, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 40);
            this.panel12.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel8.Location = new System.Drawing.Point(1, 322);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(6, 40);
            this.panel8.TabIndex = 14;
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
            this.btnMasOpciones.Location = new System.Drawing.Point(9, 322);
            this.btnMasOpciones.Name = "btnMasOpciones";
            this.btnMasOpciones.Size = new System.Drawing.Size(213, 40);
            this.btnMasOpciones.TabIndex = 13;
            this.btnMasOpciones.Text = "  Más Opciones";
            this.btnMasOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasOpciones.UseVisualStyleBackColor = true;
            this.btnMasOpciones.Click += new System.EventHandler(this.btnMasOpciones_Click);
            // 
            // Submenu
            // 
            this.Submenu.Controls.Add(this.btnCerrarS);
            this.Submenu.Controls.Add(this.panel7);
            this.Submenu.Location = new System.Drawing.Point(48, 368);
            this.Submenu.Name = "Submenu";
            this.Submenu.Size = new System.Drawing.Size(169, 54);
            this.Submenu.TabIndex = 12;
            this.Submenu.Visible = false;
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
            this.button1.Text = "  Ventas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.panel1.Location = new System.Drawing.Point(2, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 40);
            this.panel1.TabIndex = 5;
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
            // pbLogo
            // 
            this.pbLogo.Image = global::sistemaRestaurante.Properties.Resources.Inicio;
            this.pbLogo.Location = new System.Drawing.Point(47, 16);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(122, 99);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // tmHoraFecha
            // 
            this.tmHoraFecha.Enabled = true;
            this.tmHoraFecha.Tick += new System.EventHandler(this.tmHoraFecha_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 42);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1016, 697);
            this.panelContenedor.TabIndex = 2;
            // 
            // FrmAccesoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1236, 739);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.barraTitulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAccesoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAccesoUsuario_Load);
            this.barraTitulos.ResumeLayout(false);
            this.barraTitulos.PerformLayout();
            this.MenuVertical.ResumeLayout(false);
            this.SubMenuVentas.ResumeLayout(false);
            this.Submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulos;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRestoreWindow;
        private System.Windows.Forms.PictureBox pbLogo;
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
        public System.Windows.Forms.Label lblUsuarioAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SubMenuVentas;
        private System.Windows.Forms.Button btnVentaProceso;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelContenedor;
    }
}