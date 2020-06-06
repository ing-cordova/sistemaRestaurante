namespace sistemaRestaurante.Vistas.Administrador.ProveedoresLista
{
    partial class FrmListadoProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.dtvProveedores = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminarSelected = new System.Windows.Forms.Button();
            this.btnEditarSelected = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailprove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblEtiqueta.Location = new System.Drawing.Point(306, 21);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(422, 38);
            this.lblEtiqueta.TabIndex = 3;
            this.lblEtiqueta.Text = "LISTADO DE PROVEEDORES";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtvProveedores
            // 
            this.dtvProveedores.AllowUserToAddRows = false;
            this.dtvProveedores.AllowUserToDeleteRows = false;
            this.dtvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvProveedores.ColumnHeadersHeight = 25;
            this.dtvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.nombreProve,
            this.ubicacion,
            this.telefono,
            this.Emailprove,
            this.Estado});
            this.dtvProveedores.EnableHeadersVisualStyles = false;
            this.dtvProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvProveedores.Location = new System.Drawing.Point(12, 129);
            this.dtvProveedores.Name = "dtvProveedores";
            this.dtvProveedores.ReadOnly = true;
            this.dtvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvProveedores.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvProveedores.Size = new System.Drawing.Size(982, 548);
            this.dtvProveedores.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = global::sistemaRestaurante.Properties.Resources.refresh;
            this.btnActualizar.Location = new System.Drawing.Point(944, 81);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 44);
            this.btnActualizar.TabIndex = 11;
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
            this.btnEliminarSelected.Location = new System.Drawing.Point(590, 79);
            this.btnEliminarSelected.Name = "btnEliminarSelected";
            this.btnEliminarSelected.Size = new System.Drawing.Size(238, 44);
            this.btnEliminarSelected.TabIndex = 10;
            this.btnEliminarSelected.Text = "  Eliminar Seleccionado";
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
            this.btnEditarSelected.Location = new System.Drawing.Point(364, 79);
            this.btnEditarSelected.Name = "btnEditarSelected";
            this.btnEditarSelected.Size = new System.Drawing.Size(220, 44);
            this.btnEditarSelected.TabIndex = 9;
            this.btnEditarSelected.Text = "  Editar Seleccionado";
            this.btnEditarSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarSelected.UseVisualStyleBackColor = true;
            this.btnEditarSelected.Click += new System.EventHandler(this.btnEditarSelected_Click);
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarNuevo.Image = global::sistemaRestaurante.Properties.Resources.add;
            this.btnAgregarNuevo.Location = new System.Drawing.Point(175, 79);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(183, 44);
            this.btnAgregarNuevo.TabIndex = 8;
            this.btnAgregarNuevo.Text = "  Agregar Nuevo";
            this.btnAgregarNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // idproducto
            // 
            this.idproducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idproducto.HeaderText = "ID";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Width = 51;
            // 
            // nombreProve
            // 
            this.nombreProve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreProve.HeaderText = "NOMBRE PROVEEDOR";
            this.nombreProve.Name = "nombreProve";
            this.nombreProve.ReadOnly = true;
            this.nombreProve.Width = 205;
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "UBICACION";
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 115;
            // 
            // Emailprove
            // 
            this.Emailprove.HeaderText = "EMAIL";
            this.Emailprove.Name = "Emailprove";
            this.Emailprove.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // FrmListadoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1018, 697);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarSelected);
            this.Controls.Add(this.btnEditarSelected);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.dtvProveedores);
            this.Controls.Add(this.lblEtiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProveedores";
            this.Text = "FrmListadoProveedores";
            this.Load += new System.EventHandler(this.FrmListadoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta;
        public System.Windows.Forms.DataGridView dtvProveedores;
        public System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminarSelected;
        private System.Windows.Forms.Button btnEditarSelected;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProve;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}