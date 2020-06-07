namespace sistemaRestaurante.Vistas.Administrador.Productos
{
    partial class FrmListadoProductos
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
            this.dtvProductos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminarSelected = new System.Windows.Forms.Button();
            this.btnEditarSelected = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnVerSelected = new System.Windows.Forms.Button();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblEtiqueta.Location = new System.Drawing.Point(214, 21);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(635, 38);
            this.lblEtiqueta.TabIndex = 2;
            this.lblEtiqueta.Text = "LISTADO DE PRODUCTOS EN INVENTARIO";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtvProductos
            // 
            this.dtvProductos.AllowUserToAddRows = false;
            this.dtvProductos.AllowUserToDeleteRows = false;
            this.dtvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvProductos.ColumnHeadersHeight = 25;
            this.dtvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.nombreProd,
            this.precio,
            this.categoria});
            this.dtvProductos.EnableHeadersVisualStyles = false;
            this.dtvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvProductos.Location = new System.Drawing.Point(12, 151);
            this.dtvProductos.Name = "dtvProductos";
            this.dtvProductos.ReadOnly = true;
            this.dtvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvProductos.Size = new System.Drawing.Size(994, 460);
            this.dtvProductos.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = global::sistemaRestaurante.Properties.Resources.refresh;
            this.btnActualizar.Location = new System.Drawing.Point(950, 101);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 44);
            this.btnActualizar.TabIndex = 7;
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
            this.btnEliminarSelected.Location = new System.Drawing.Point(786, 101);
            this.btnEliminarSelected.Name = "btnEliminarSelected";
            this.btnEliminarSelected.Size = new System.Drawing.Size(158, 44);
            this.btnEliminarSelected.TabIndex = 6;
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
            this.btnEditarSelected.Location = new System.Drawing.Point(621, 101);
            this.btnEditarSelected.Name = "btnEditarSelected";
            this.btnEditarSelected.Size = new System.Drawing.Size(159, 44);
            this.btnEditarSelected.TabIndex = 5;
            this.btnEditarSelected.Text = "  Editar";
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
            this.btnAgregarNuevo.Location = new System.Drawing.Point(418, 99);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(183, 44);
            this.btnAgregarNuevo.TabIndex = 4;
            this.btnAgregarNuevo.Text = "  Agregar Nuevo";
            this.btnAgregarNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnVerSelected
            // 
            this.btnVerSelected.FlatAppearance.BorderSize = 0;
            this.btnVerSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerSelected.Image = global::sistemaRestaurante.Properties.Resources.eye;
            this.btnVerSelected.Location = new System.Drawing.Point(12, 101);
            this.btnVerSelected.Name = "btnVerSelected";
            this.btnVerSelected.Size = new System.Drawing.Size(168, 44);
            this.btnVerSelected.TabIndex = 13;
            this.btnVerSelected.Text = "  Ver Receta";
            this.btnVerSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerSelected.UseVisualStyleBackColor = true;
            this.btnVerSelected.Click += new System.EventHandler(this.btnVerSelected_Click);
            // 
            // idproducto
            // 
            this.idproducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idproducto.HeaderText = "ID";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Width = 51;
            // 
            // nombreProd
            // 
            this.nombreProd.HeaderText = "NOMBRE PRODUCTO";
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1018, 697);
            this.Controls.Add(this.btnVerSelected);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarSelected);
            this.Controls.Add(this.btnEditarSelected);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.dtvProductos);
            this.Controls.Add(this.lblEtiqueta);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoProductos";
            this.Load += new System.EventHandler(this.FrmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnEditarSelected;
        private System.Windows.Forms.Button btnEliminarSelected;
        public System.Windows.Forms.DataGridView dtvProductos;
        public System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVerSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}