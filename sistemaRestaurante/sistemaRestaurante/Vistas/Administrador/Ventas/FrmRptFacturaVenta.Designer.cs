namespace sistemaRestaurante.Vistas.Administrador.Ventas
{
    partial class FrmRptFacturaVenta
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
            this.crDetalleVenta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crDetalleVenta
            // 
            this.crDetalleVenta.ActiveViewIndex = -1;
            this.crDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crDetalleVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crDetalleVenta.Location = new System.Drawing.Point(0, 0);
            this.crDetalleVenta.Name = "crDetalleVenta";
            this.crDetalleVenta.Size = new System.Drawing.Size(800, 450);
            this.crDetalleVenta.TabIndex = 0;
            // 
            // FrmRptFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crDetalleVenta);
            this.Name = "FrmRptFacturaVenta";
            this.Text = "FACTURA EMITIDA";
            this.Load += new System.EventHandler(this.FrmRptFacturaVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crDetalleVenta;
    }
}