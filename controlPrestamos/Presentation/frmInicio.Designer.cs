
namespace controlPrestamos.Presentation
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.tmrFechayHora = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPres = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCob = new System.Windows.Forms.Label();
            this.gpbInicio = new System.Windows.Forms.GroupBox();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gpbInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrFechayHora
            // 
            this.tmrFechayHora.Enabled = true;
            this.tmrFechayHora.Tick += new System.EventHandler(this.tmrFechayHora_Tick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Green;
            this.lblName.Location = new System.Drawing.Point(200, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 27);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Num";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Tai Le", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHora.Location = new System.Drawing.Point(342, 280);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(330, 122);
            this.lblHora.TabIndex = 87;
            this.lblHora.Text = "HORA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Green;
            this.lblFecha.Location = new System.Drawing.Point(378, 391);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(107, 37);
            this.lblFecha.TabIndex = 88;
            this.lblFecha.Text = "FECHA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(526, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 40);
            this.label11.TabIndex = 120;
            this.label11.Text = "Cantidad de\r\nPrestamos";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 121;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(172, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 40);
            this.label1.TabIndex = 122;
            this.label1.Text = "Cantidad de\r\nClientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPres
            // 
            this.lblPres.AutoSize = true;
            this.lblPres.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPres.ForeColor = System.Drawing.Color.Green;
            this.lblPres.Location = new System.Drawing.Point(573, 113);
            this.lblPres.Name = "lblPres";
            this.lblPres.Size = new System.Drawing.Size(61, 27);
            this.lblPres.TabIndex = 28;
            this.lblPres.Text = "Num";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(755, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 123;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(891, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 124;
            this.label2.Text = "Cantidad de\r\nCobradores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCob
            // 
            this.lblCob.AutoSize = true;
            this.lblCob.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCob.ForeColor = System.Drawing.Color.Green;
            this.lblCob.Location = new System.Drawing.Point(917, 107);
            this.lblCob.Name = "lblCob";
            this.lblCob.Size = new System.Drawing.Size(61, 27);
            this.lblCob.TabIndex = 29;
            this.lblCob.Text = "Num";
            this.lblCob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbInicio
            // 
            this.gpbInicio.Controls.Add(this.label3);
            this.gpbInicio.Controls.Add(this.lblCob);
            this.gpbInicio.Controls.Add(this.label2);
            this.gpbInicio.Controls.Add(this.pictureBox3);
            this.gpbInicio.Controls.Add(this.lblPres);
            this.gpbInicio.Controls.Add(this.label1);
            this.gpbInicio.Controls.Add(this.pictureBox2);
            this.gpbInicio.Controls.Add(this.label11);
            this.gpbInicio.Controls.Add(this.pictureBox1);
            this.gpbInicio.Controls.Add(this.lblFecha);
            this.gpbInicio.Controls.Add(this.lblHora);
            this.gpbInicio.Controls.Add(this.lblName);
            this.gpbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInicio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gpbInicio.Location = new System.Drawing.Point(14, 69);
            this.gpbInicio.Name = "gpbInicio";
            this.gpbInicio.Size = new System.Drawing.Size(1107, 596);
            this.gpbInicio.TabIndex = 87;
            this.gpbInicio.TabStop = false;
            this.gpbInicio.Text = "INICIO";
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.White;
            this.btnAjustes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjustes.BackgroundImage")));
            this.btnAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(1072, 5);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(56, 49);
            this.btnAjustes.TabIndex = 90;
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(714, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 48);
            this.label3.TabIndex = 91;
            this.label3.Text = "Finsan\'z S. A. de C. V.";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 674);
            this.Controls.Add(this.btnAjustes);
            this.Controls.Add(this.gpbInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gpbInicio.ResumeLayout(false);
            this.gpbInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrFechayHora;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPres;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCob;
        private System.Windows.Forms.GroupBox gpbInicio;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Label label3;
    }
}