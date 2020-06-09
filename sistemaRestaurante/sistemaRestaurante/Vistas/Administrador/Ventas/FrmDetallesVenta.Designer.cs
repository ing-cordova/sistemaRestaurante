namespace sistemaRestaurante.Vistas.Administrador.Ventas
{
    partial class FrmDetallesVenta
    {/// <summary>
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumerodeMesa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.dtvDetallesVenta = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnEntregada = new System.Windows.Forms.Button();
            this.btnRecibida = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnPagada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDetallesVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id:";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Enabled = false;
            this.txtIdVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenta.Location = new System.Drawing.Point(16, 152);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(138, 27);
            this.txtIdVenta.TabIndex = 10;
            this.txtIdVenta.TextChanged += new System.EventHandler(this.txtIdVenta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(156, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha:";
            // 
            // txtNumerodeMesa
            // 
            this.txtNumerodeMesa.Enabled = false;
            this.txtNumerodeMesa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerodeMesa.Location = new System.Drawing.Point(521, 152);
            this.txtNumerodeMesa.Name = "txtNumerodeMesa";
            this.txtNumerodeMesa.Size = new System.Drawing.Size(142, 27);
            this.txtNumerodeMesa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(517, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numero de Mesa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(665, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(669, 152);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(206, 27);
            this.txtEstado.TabIndex = 19;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblEtiqueta.Location = new System.Drawing.Point(12, 192);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(501, 28);
            this.lblEtiqueta.TabIndex = 21;
            this.lblEtiqueta.Text = "Productos agregados al carrito de ventas:";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtvDetallesVenta
            // 
            this.dtvDetallesVenta.AllowUserToAddRows = false;
            this.dtvDetallesVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvDetallesVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvDetallesVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvDetallesVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvDetallesVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvDetallesVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvDetallesVenta.ColumnHeadersHeight = 25;
            this.dtvDetallesVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.producto,
            this.cantidad});
            this.dtvDetallesVenta.EnableHeadersVisualStyles = false;
            this.dtvDetallesVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvDetallesVenta.Location = new System.Drawing.Point(17, 223);
            this.dtvDetallesVenta.Name = "dtvDetallesVenta";
            this.dtvDetallesVenta.ReadOnly = true;
            this.dtvDetallesVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvDetallesVenta.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtvDetallesVenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvDetallesVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvDetallesVenta.Size = new System.Drawing.Size(965, 315);
            this.dtvDetallesVenta.TabIndex = 22;
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idProducto.HeaderText = "Código";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 92;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 111;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(160, 151);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(353, 27);
            this.txtFecha.TabIndex = 23;
            // 
            // btnEntregada
            // 
            this.btnEntregada.FlatAppearance.BorderSize = 0;
            this.btnEntregada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntregada.Image = global::sistemaRestaurante.Properties.Resources.correct;
            this.btnEntregada.Location = new System.Drawing.Point(356, 83);
            this.btnEntregada.Name = "btnEntregada";
            this.btnEntregada.Size = new System.Drawing.Size(307, 44);
            this.btnEntregada.TabIndex = 26;
            this.btnEntregada.Text = "  Marcar como Entregada";
            this.btnEntregada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntregada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntregada.UseVisualStyleBackColor = true;
            this.btnEntregada.Click += new System.EventHandler(this.btnEntregada_Click);
            // 
            // btnRecibida
            // 
            this.btnRecibida.FlatAppearance.BorderSize = 0;
            this.btnRecibida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecibida.Image = global::sistemaRestaurante.Properties.Resources.inbox__1_;
            this.btnRecibida.Location = new System.Drawing.Point(80, 83);
            this.btnRecibida.Name = "btnRecibida";
            this.btnRecibida.Size = new System.Drawing.Size(260, 44);
            this.btnRecibida.TabIndex = 25;
            this.btnRecibida.Text = "  Marcar como Recibida";
            this.btnRecibida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecibida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecibida.UseVisualStyleBackColor = true;
            this.btnRecibida.Click += new System.EventHandler(this.btnRecibida_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Image = global::sistemaRestaurante.Properties.Resources.back;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(879, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(127, 40);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "  Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnPagada
            // 
            this.btnPagada.FlatAppearance.BorderSize = 0;
            this.btnPagada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPagada.Image = global::sistemaRestaurante.Properties.Resources.correct;
            this.btnPagada.Location = new System.Drawing.Point(669, 83);
            this.btnPagada.Name = "btnPagada";
            this.btnPagada.Size = new System.Drawing.Size(275, 44);
            this.btnPagada.TabIndex = 27;
            this.btnPagada.Text = "  Marcar como Pagada";
            this.btnPagada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagada.UseVisualStyleBackColor = true;
            this.btnPagada.Click += new System.EventHandler(this.btnPagada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(260, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "Estados de las Ventas Actuales:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDetallesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1018, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagada);
            this.Controls.Add(this.btnEntregada);
            this.Controls.Add(this.btnRecibida);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.dtvDetallesVenta);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumerodeMesa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDetallesVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDetallesVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.Label lblEtiqueta;
        public System.Windows.Forms.DataGridView dtvDetallesVenta;
        public System.Windows.Forms.TextBox txtIdVenta;
        public System.Windows.Forms.TextBox txtNumerodeMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        public System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnRecibida;
        private System.Windows.Forms.Button btnEntregada;
        private System.Windows.Forms.Button btnPagada;
        public System.Windows.Forms.Label label1;
    }
}