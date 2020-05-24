namespace sistemaRestaurante.Vistas.Usuario.ProductosLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtvProductos = new System.Windows.Forms.DataGridView();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbotNombre = new System.Windows.Forms.RadioButton();
            this.rbotCategoria = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtvProductos.ColumnHeadersHeight = 25;
            this.dtvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.nombreProd,
            this.precio,
            this.categoria});
            this.dtvProductos.EnableHeadersVisualStyles = false;
            this.dtvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvProductos.Location = new System.Drawing.Point(12, 149);
            this.dtvProductos.Name = "dtvProductos";
            this.dtvProductos.ReadOnly = true;
            this.dtvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dtvProductos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvProductos.Size = new System.Drawing.Size(828, 460);
            this.dtvProductos.TabIndex = 4;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblEtiqueta.Location = new System.Drawing.Point(85, 9);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(685, 38);
            this.lblEtiqueta.TabIndex = 5;
            this.lblEtiqueta.Text = "BIENVENIDO A LA SECCIÓN DE PRODUCTOS";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Para buscar, escriba aquí:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(12, 96);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(434, 31);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // idproducto
            // 
            this.idproducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idproducto.HeaderText = "ID";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Visible = false;
            this.idproducto.Width = 51;
            // 
            // nombreProd
            // 
            this.nombreProd.HeaderText = "NOMBRE PRODUCTO";
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.ReadOnly = true;
            this.nombreProd.Visible = false;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Visible = false;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Visible = false;
            // 
            // rbotNombre
            // 
            this.rbotNombre.AutoSize = true;
            this.rbotNombre.Checked = true;
            this.rbotNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbotNombre.Location = new System.Drawing.Point(572, 98);
            this.rbotNombre.Name = "rbotNombre";
            this.rbotNombre.Size = new System.Drawing.Size(91, 25);
            this.rbotNombre.TabIndex = 8;
            this.rbotNombre.TabStop = true;
            this.rbotNombre.Text = "Nombre";
            this.rbotNombre.UseVisualStyleBackColor = true;
            this.rbotNombre.CheckedChanged += new System.EventHandler(this.rbotNombre_CheckedChanged);
            // 
            // rbotCategoria
            // 
            this.rbotCategoria.AutoSize = true;
            this.rbotCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbotCategoria.Location = new System.Drawing.Point(675, 98);
            this.rbotCategoria.Name = "rbotCategoria";
            this.rbotCategoria.Size = new System.Drawing.Size(109, 25);
            this.rbotCategoria.TabIndex = 9;
            this.rbotCategoria.Text = "Categoria";
            this.rbotCategoria.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(468, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrar por:";
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(852, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbotCategoria);
            this.Controls.Add(this.rbotNombre);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.dtvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProductos";
            this.Text = "FrmListadoProductos";
            this.Load += new System.EventHandler(this.FrmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtvProductos;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.RadioButton rbotNombre;
        private System.Windows.Forms.RadioButton rbotCategoria;
        private System.Windows.Forms.Label label2;
    }
}