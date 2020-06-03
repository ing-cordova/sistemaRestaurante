namespace sistemaRestaurante.Vistas.Administrador.Ventas
{
    partial class FrmListaVentas
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
            this.dtvVentas = new System.Windows.Forms.DataGridView();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.rbotEnviada = new System.Windows.Forms.RadioButton();
            this.rbotTodos = new System.Windows.Forms.RadioButton();
            this.rbotRecibidas = new System.Windows.Forms.RadioButton();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVerSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiqueta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblEtiqueta.Location = new System.Drawing.Point(278, 19);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(343, 38);
            this.lblEtiqueta.TabIndex = 4;
            this.lblEtiqueta.Text = "LISTADO DE ORDENES";
            this.lblEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtvVentas
            // 
            this.dtvVentas.AllowUserToAddRows = false;
            this.dtvVentas.AllowUserToDeleteRows = false;
            this.dtvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvVentas.ColumnHeadersHeight = 25;
            this.dtvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVenta,
            this.fechadeVenta,
            this.numMesa,
            this.estado});
            this.dtvVentas.EnableHeadersVisualStyles = false;
            this.dtvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.dtvVentas.Location = new System.Drawing.Point(12, 165);
            this.dtvVentas.Name = "dtvVentas";
            this.dtvVentas.ReadOnly = true;
            this.dtvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtvVentas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtvVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvVentas.Size = new System.Drawing.Size(896, 460);
            this.dtvVentas.TabIndex = 5;
            // 
            // idVenta
            // 
            this.idVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idVenta.HeaderText = "Id";
            this.idVenta.Name = "idVenta";
            this.idVenta.ReadOnly = true;
            this.idVenta.Width = 50;
            // 
            // fechadeVenta
            // 
            this.fechadeVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechadeVenta.HeaderText = "FECHA DE VENTA";
            this.fechadeVenta.Name = "fechadeVenta";
            this.fechadeVenta.ReadOnly = true;
            this.fechadeVenta.Width = 170;
            // 
            // numMesa
            // 
            this.numMesa.HeaderText = "NUMERO DE MESA";
            this.numMesa.Name = "numMesa";
            this.numMesa.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
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
            // rbotEnviada
            // 
            this.rbotEnviada.AutoSize = true;
            this.rbotEnviada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotEnviada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbotEnviada.Location = new System.Drawing.Point(180, 131);
            this.rbotEnviada.Name = "rbotEnviada";
            this.rbotEnviada.Size = new System.Drawing.Size(99, 25);
            this.rbotEnviada.TabIndex = 16;
            this.rbotEnviada.Text = "Enviadas";
            this.rbotEnviada.UseVisualStyleBackColor = true;
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
            // 
            // rbotRecibidas
            // 
            this.rbotRecibidas.AutoSize = true;
            this.rbotRecibidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbotRecibidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbotRecibidas.Location = new System.Drawing.Point(276, 131);
            this.rbotRecibidas.Name = "rbotRecibidas";
            this.rbotRecibidas.Size = new System.Drawing.Size(103, 25);
            this.rbotRecibidas.TabIndex = 18;
            this.rbotRecibidas.Text = "Recibidas";
            this.rbotRecibidas.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = global::sistemaRestaurante.Properties.Resources.refresh;
            this.btnActualizar.Location = new System.Drawing.Point(798, 109);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 44);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnVerSelected
            // 
            this.btnVerSelected.FlatAppearance.BorderSize = 0;
            this.btnVerSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSelected.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSelected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerSelected.Image = global::sistemaRestaurante.Properties.Resources.Edit;
            this.btnVerSelected.Location = new System.Drawing.Point(626, 109);
            this.btnVerSelected.Name = "btnVerSelected";
            this.btnVerSelected.Size = new System.Drawing.Size(152, 44);
            this.btnVerSelected.TabIndex = 12;
            this.btnVerSelected.Text = "  Ver Orden";
            this.btnVerSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerSelected.UseVisualStyleBackColor = true;
            this.btnVerSelected.Click += new System.EventHandler(this.btnVerSelected_Click);
            // 
            // FrmListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(920, 637);
            this.Controls.Add(this.rbotRecibidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbotEnviada);
            this.Controls.Add(this.rbotTodos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnVerSelected);
            this.Controls.Add(this.dtvVentas);
            this.Controls.Add(this.lblEtiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaVentas";
            this.Text = "FrmListadoUsuarios";
            this.Load += new System.EventHandler(this.FrmListadoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dtvVentas;
        public System.Windows.Forms.Label lblEtiqueta;
        public System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVerSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbotEnviada;
        private System.Windows.Forms.RadioButton rbotTodos;
        private System.Windows.Forms.RadioButton rbotRecibidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}