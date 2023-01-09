
namespace controlPrestamos.Presentation
{
    partial class frmAjustes
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
            this.resp = new System.Windows.Forms.GroupBox();
            this.btnGenCop = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrarClientes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrarPrestamos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nUpDawnMorDia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMorSem = new System.Windows.Forms.NumericUpDown();
            this.resp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDawnMorDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMorSem)).BeginInit();
            this.SuspendLayout();
            // 
            // resp
            // 
            this.resp.Controls.Add(this.btnGenCop);
            this.resp.Controls.Add(this.label16);
            this.resp.Location = new System.Drawing.Point(12, 32);
            this.resp.Name = "resp";
            this.resp.Size = new System.Drawing.Size(316, 245);
            this.resp.TabIndex = 0;
            this.resp.TabStop = false;
            this.resp.Text = "RESPALDO DE LA BD";
            this.resp.Enter += new System.EventHandler(this.resp_Enter);
            // 
            // btnGenCop
            // 
            this.btnGenCop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenCop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenCop.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenCop.Location = new System.Drawing.Point(67, 121);
            this.btnGenCop.Name = "btnGenCop";
            this.btnGenCop.Size = new System.Drawing.Size(149, 42);
            this.btnGenCop.TabIndex = 106;
            this.btnGenCop.Text = "Generar Copia";
            this.btnGenCop.UseVisualStyleBackColor = true;
            this.btnGenCop.Click += new System.EventHandler(this.btnGenCop_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(3, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(307, 22);
            this.label16.TabIndex = 105;
            this.label16.Text = "REALIZAR COPIA DE SEGURIDAD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrarClientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBorrarPrestamos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AJUSTES DEL SISTEMA";
            // 
            // btnBorrarClientes
            // 
            this.btnBorrarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarClientes.Location = new System.Drawing.Point(69, 236);
            this.btnBorrarClientes.Name = "btnBorrarClientes";
            this.btnBorrarClientes.Size = new System.Drawing.Size(149, 42);
            this.btnBorrarClientes.TabIndex = 108;
            this.btnBorrarClientes.Text = "BORRAR";
            this.btnBorrarClientes.UseVisualStyleBackColor = true;
            this.btnBorrarClientes.Click += new System.EventHandler(this.btnBorrarClientes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(4, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 44);
            this.label2.TabIndex = 107;
            this.label2.Text = "BORRAR TODOS LOS REGISTROS\r\nDE CLIENTES";
            // 
            // btnBorrarPrestamos
            // 
            this.btnBorrarPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPrestamos.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPrestamos.Location = new System.Drawing.Point(69, 87);
            this.btnBorrarPrestamos.Name = "btnBorrarPrestamos";
            this.btnBorrarPrestamos.Size = new System.Drawing.Size(149, 42);
            this.btnBorrarPrestamos.TabIndex = 106;
            this.btnBorrarPrestamos.Text = "BORRAR";
            this.btnBorrarPrestamos.UseVisualStyleBackColor = true;
            this.btnBorrarPrestamos.Click += new System.EventHandler(this.btnBorrarPrestamos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 44);
            this.label1.TabIndex = 105;
            this.label1.Text = "BORRAR TODOS REGISTROS DE\r\nPRESTAMOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownMorSem);
            this.groupBox2.Controls.Add(this.nUpDawnMorDia);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAplicar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(342, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 245);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AJUSTES DE LOS DIAS MORATORIOS";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(67, 189);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(149, 42);
            this.btnAplicar.TabIndex = 106;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 44);
            this.label3.TabIndex = 105;
            this.label3.Text = "Configure la moratoria por día\r\no semana atrasado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(76, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 107;
            this.label4.Text = "DÍA $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(31, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 108;
            this.label5.Text = "SEMANA $";
            // 
            // nUpDawnMorDia
            // 
            this.nUpDawnMorDia.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDawnMorDia.Location = new System.Drawing.Point(135, 93);
            this.nUpDawnMorDia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUpDawnMorDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDawnMorDia.Name = "nUpDawnMorDia";
            this.nUpDawnMorDia.Size = new System.Drawing.Size(81, 32);
            this.nUpDawnMorDia.TabIndex = 109;
            this.nUpDawnMorDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDawnMorDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMorSem
            // 
            this.numericUpDownMorSem.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMorSem.Location = new System.Drawing.Point(136, 134);
            this.numericUpDownMorSem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMorSem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMorSem.Name = "numericUpDownMorSem";
            this.numericUpDownMorSem.Size = new System.Drawing.Size(80, 32);
            this.numericUpDownMorSem.TabIndex = 110;
            this.numericUpDownMorSem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMorSem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Load += new System.EventHandler(this.frmAjustes_Load);
            this.resp.ResumeLayout(false);
            this.resp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDawnMorDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMorSem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox resp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenCop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrarClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrarPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMorSem;
        private System.Windows.Forms.NumericUpDown nUpDawnMorDia;
    }
}