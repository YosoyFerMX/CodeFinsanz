
namespace controlPrestamos.Presentation
{
    partial class frmReportePrestamoDetalles
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
            this.repViewDetallesPres = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repViewDetallesPres
            // 
            this.repViewDetallesPres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repViewDetallesPres.Location = new System.Drawing.Point(0, 0);
            this.repViewDetallesPres.Name = "repViewDetallesPres";
            this.repViewDetallesPres.ServerReport.BearerToken = null;
            this.repViewDetallesPres.Size = new System.Drawing.Size(1033, 638);
            this.repViewDetallesPres.TabIndex = 0;
            // 
            // frmReportePrestamoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 638);
            this.Controls.Add(this.repViewDetallesPres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReportePrestamoDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETALLE DEL PRESTAMO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportePrestamoDetalles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repViewDetallesPres;
    }
}