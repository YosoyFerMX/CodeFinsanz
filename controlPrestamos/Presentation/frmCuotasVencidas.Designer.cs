
namespace controlPrestamos.Presentation
{
    partial class frmCuotasVencidas
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
            this.repViewCuotVenci = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repViewCuotVenci
            // 
            this.repViewCuotVenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repViewCuotVenci.Location = new System.Drawing.Point(0, 0);
            this.repViewCuotVenci.Name = "repViewCuotVenci";
            this.repViewCuotVenci.ServerReport.BearerToken = null;
            this.repViewCuotVenci.Size = new System.Drawing.Size(1195, 678);
            this.repViewCuotVenci.TabIndex = 0;
            // 
            // frmCuotasVencidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 678);
            this.Controls.Add(this.repViewCuotVenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCuotasVencidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUOTAS VENCIDAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCuotasVencidas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repViewCuotVenci;
    }
}