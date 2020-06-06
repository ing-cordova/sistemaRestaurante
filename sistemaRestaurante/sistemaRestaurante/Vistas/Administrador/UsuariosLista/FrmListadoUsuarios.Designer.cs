namespace sistemaRestaurante.Vistas.Administrador.UsuariosLista
{
    partial class FrmListadoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.dtvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminarSelected = new System.Windows.Forms.Button();
            this.btnEditarSelected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbotUsuarios = new System.Windows.Forms.RadioButton();
            this.rbotTodos = new System.Windows.Forms.RadioButton();
            this.rbotAdministradores = new System.Windows.Forms.RadioButton();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblEtiqueta.Location = new System.Drawing.Point(343, 9);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(353, 38);
            this.lblEtiqueta.TabIndex = 4;
            this.lblEtiqueta.Text = "LISTADO DE USUARIOS";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtvUsuarios
            // 
            this.dtvUsuarios.AllowUserToAddRows = false;
            this.dtvUsuarios.AllowUserToDeleteRows = false;
            this.dtvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtvUsuarios.ColumnHeadersHeight = 25;
            this.dtvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.nombre,
            this.apellidos,
            this.edad,
            this.telefono,
            this.email,
            this.contrasenia,
            this.rol,
            this.estado});
            this.dtvUsuarios.EnableHeadersVisualStyles = false;
            this.dtvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvUsuarios.Location = new System.Drawing.Point(12, 165);
            this.dtvUsuarios.Name = "dtvUsuarios";
            this.dtvUsuarios.ReadOnly = true;
            this.dtvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvUsuarios.Size = new System.Drawing.Size(994, 460);
            this.dtvUsuarios.TabIndex = 5;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(12, 99);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(434, 31);
            this.txtBusqueda.TabIndex = 9;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Busque un usuario aquí:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = global::sistemaRestaurante.Properties.Resources.refresh;
            this.btnActualizar.Location = new System.Drawing.Point(949, 99);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 44);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminarSelected
            // 
            this.btnEliminarSelected.FlatAppearance.BorderSize = 0;
            this.btnEliminarSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarSelected.Image = global::sistemaRestaurante.Properties.Resources.delete;
            this.btnEliminarSelected.Location = new System.Drawing.Point(820, 99);
            this.btnEliminarSelected.Name = "btnEliminarSelected";
            this.btnEliminarSelected.Size = new System.Drawing.Size(123, 44);
            this.btnEliminarSelected.TabIndex = 13;
            this.btnEliminarSelected.Text = "  Eliminar";
            this.btnEliminarSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarSelected.UseVisualStyleBackColor = true;
            this.btnEliminarSelected.Click += new System.EventHandler(this.btnEliminarSelected_Click);
            // 
            // btnEditarSelected
            // 
            this.btnEditarSelected.FlatAppearance.BorderSize = 0;
            this.btnEditarSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarSelected.Image = global::sistemaRestaurante.Properties.Resources.Edit;
            this.btnEditarSelected.Location = new System.Drawing.Point(702, 99);
            this.btnEditarSelected.Name = "btnEditarSelected";
            this.btnEditarSelected.Size = new System.Drawing.Size(111, 44);
            this.btnEditarSelected.TabIndex = 12;
            this.btnEditarSelected.Text = "  Editar";
            this.btnEditarSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarSelected.UseVisualStyleBackColor = true;
            this.btnEditarSelected.Click += new System.EventHandler(this.btnEditarSelected_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mostrar:";
            // 
            // rbotUsuarios
            // 
            this.rbotUsuarios.AutoSize = true;
            this.rbotUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbotUsuarios.Location = new System.Drawing.Point(180, 131);
            this.rbotUsuarios.Name = "rbotUsuarios";
            this.rbotUsuarios.Size = new System.Drawing.Size(90, 25);
            this.rbotUsuarios.TabIndex = 16;
            this.rbotUsuarios.Text = "Usuarios";
            this.rbotUsuarios.UseVisualStyleBackColor = true;
            this.rbotUsuarios.CheckedChanged += new System.EventHandler(this.rbotUsuarios_CheckedChanged);
            // 
            // rbotTodos
            // 
            this.rbotTodos.AutoSize = true;
            this.rbotTodos.Checked = true;
            this.rbotTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbotTodos.Location = new System.Drawing.Point(101, 131);
            this.rbotTodos.Name = "rbotTodos";
            this.rbotTodos.Size = new System.Drawing.Size(73, 25);
            this.rbotTodos.TabIndex = 15;
            this.rbotTodos.TabStop = true;
            this.rbotTodos.Text = "Todos";
            this.rbotTodos.UseVisualStyleBackColor = true;
            this.rbotTodos.CheckedChanged += new System.EventHandler(this.rbotTodos_CheckedChanged);
            // 
            // rbotAdministradores
            // 
            this.rbotAdministradores.AutoSize = true;
            this.rbotAdministradores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotAdministradores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbotAdministradores.Location = new System.Drawing.Point(276, 131);
            this.rbotAdministradores.Name = "rbotAdministradores";
            this.rbotAdministradores.Size = new System.Drawing.Size(154, 25);
            this.rbotAdministradores.TabIndex = 18;
            this.rbotAdministradores.Text = "Administradores";
            this.rbotAdministradores.UseVisualStyleBackColor = true;
            this.rbotAdministradores.CheckedChanged += new System.EventHandler(this.rbotAdministradores_CheckedChanged);
            // 
            // usuario
            // 
            this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 106;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.HeaderText = "NOMBRES";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 111;
            // 
            // apellidos
            // 
            this.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidos.HeaderText = "APELLIDOS";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 118;
            // 
            // edad
            // 
            this.edad.HeaderText = "EDAD";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Visible = false;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono.HeaderText = "TELÉFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 115;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.DefaultCellStyle = dataGridViewCellStyle5;
            this.email.HeaderText = "E-MAIL";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 88;
            // 
            // contrasenia
            // 
            this.contrasenia.HeaderText = "CONTRASEÑA";
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.ReadOnly = true;
            this.contrasenia.Visible = false;
            // 
            // rol
            // 
            this.rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rol.HeaderText = "ROL";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 65;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // FrmListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1018, 697);
            this.Controls.Add(this.rbotAdministradores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbotUsuarios);
            this.Controls.Add(this.rbotTodos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarSelected);
            this.Controls.Add(this.btnEditarSelected);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtvUsuarios);
            this.Controls.Add(this.lblEtiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoUsuarios";
            this.Text = "FrmListadoUsuarios";
            this.Load += new System.EventHandler(this.FrmListadoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dtvUsuarios;
        public System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminarSelected;
        private System.Windows.Forms.Button btnEditarSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbotUsuarios;
        private System.Windows.Forms.RadioButton rbotTodos;
        private System.Windows.Forms.RadioButton rbotAdministradores;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}