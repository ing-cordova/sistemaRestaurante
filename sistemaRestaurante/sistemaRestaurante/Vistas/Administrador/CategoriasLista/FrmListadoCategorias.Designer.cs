namespace sistemaRestaurante.Vistas.Administrador.CategoriasLista
{
    partial class FrmListadoCategorias
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
            this.dtvCategorias = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminarSelected = new System.Windows.Forms.Button();
            this.btnEditarSelected = new System.Windows.Forms.Button();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblEtiqueta.Location = new System.Drawing.Point(285, 18);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(402, 38);
            this.lblEtiqueta.TabIndex = 4;
            this.lblEtiqueta.Text = "LISTADO DE CATEGORIAS";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtvCategorias
            // 
            this.dtvCategorias.AllowUserToAddRows = false;
            this.dtvCategorias.AllowUserToDeleteRows = false;
            this.dtvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvCategorias.ColumnHeadersHeight = 25;
            this.dtvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.nombreCategoria});
            this.dtvCategorias.EnableHeadersVisualStyles = false;
            this.dtvCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvCategorias.Location = new System.Drawing.Point(128, 151);
            this.dtvCategorias.Name = "dtvCategorias";
            this.dtvCategorias.ReadOnly = true;
            this.dtvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvCategorias.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvCategorias.Size = new System.Drawing.Size(653, 359);
            this.dtvCategorias.TabIndex = 5;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = global::sistemaRestaurante.Properties.Resources.refresh;
            this.btnActualizar.Location = new System.Drawing.Point(812, 91);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 44);
            this.btnActualizar.TabIndex = 15;
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
            this.btnEliminarSelected.Location = new System.Drawing.Point(543, 91);
            this.btnEliminarSelected.Name = "btnEliminarSelected";
            this.btnEliminarSelected.Size = new System.Drawing.Size(238, 44);
            this.btnEliminarSelected.TabIndex = 14;
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
            this.btnEditarSelected.Location = new System.Drawing.Point(317, 91);
            this.btnEditarSelected.Name = "btnEditarSelected";
            this.btnEditarSelected.Size = new System.Drawing.Size(220, 44);
            this.btnEditarSelected.TabIndex = 13;
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
            this.btnAgregarNuevo.Location = new System.Drawing.Point(128, 91);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(183, 44);
            this.btnAgregarNuevo.TabIndex = 12;
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
            // nombreCategoria
            // 
            this.nombreCategoria.HeaderText = "NOMBRE CATEGORIA";
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.ReadOnly = true;
            // 
            // FrmListadoCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1018, 697);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarSelected);
            this.Controls.Add(this.btnEditarSelected);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.dtvCategorias);
            this.Controls.Add(this.lblEtiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoCategorias";
            this.Text = "FrmListadoCategorias";
            this.Load += new System.EventHandler(this.FrmListadoCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta;
        public System.Windows.Forms.DataGridView dtvCategorias;
        public System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminarSelected;
        private System.Windows.Forms.Button btnEditarSelected;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoria;
    }
}