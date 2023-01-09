
namespace controlPrestamos.Presentation
{
    partial class frmReporteClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteClientes));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCountPres = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportCli = new System.Windows.Forms.Button();
            this.gpbEstadoPres = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbMunicipio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMpioCli = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbEstadoPres.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            reportDataSource2.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.Location = new System.Drawing.Point(231, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(788, 752);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnCountPres
            // 
            this.btnCountPres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCountPres.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCountPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountPres.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountPres.ForeColor = System.Drawing.Color.Black;
            this.btnCountPres.Location = new System.Drawing.Point(22, 178);
            this.btnCountPres.Name = "btnCountPres";
            this.btnCountPres.Size = new System.Drawing.Size(189, 42);
            this.btnCountPres.TabIndex = 73;
            this.btnCountPres.Text = "Mostrar Reporte";
            this.btnCountPres.UseVisualStyleBackColor = true;
            this.btnCountPres.Click += new System.EventHandler(this.btnCountPres_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(0, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(228, 44);
            this.label20.TabIndex = 76;
            this.label20.Text = "Cantidad de prestamos\r\npor Cliente";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 77;
            this.label1.Text = "Reporte de Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReportCli
            // 
            this.btnReportCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportCli.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnReportCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportCli.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportCli.ForeColor = System.Drawing.Color.Black;
            this.btnReportCli.Location = new System.Drawing.Point(16, 268);
            this.btnReportCli.Name = "btnReportCli";
            this.btnReportCli.Size = new System.Drawing.Size(189, 42);
            this.btnReportCli.TabIndex = 78;
            this.btnReportCli.Text = "Mostrar Reporte";
            this.btnReportCli.UseVisualStyleBackColor = true;
            this.btnReportCli.Click += new System.EventHandler(this.btnReportCli_Click);
            // 
            // gpbEstadoPres
            // 
            this.gpbEstadoPres.Controls.Add(this.rbTodos);
            this.gpbEstadoPres.Controls.Add(this.rbMunicipio);
            this.gpbEstadoPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbEstadoPres.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEstadoPres.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gpbEstadoPres.Location = new System.Drawing.Point(29, 66);
            this.gpbEstadoPres.Name = "gpbEstadoPres";
            this.gpbEstadoPres.Size = new System.Drawing.Size(169, 76);
            this.gpbEstadoPres.TabIndex = 129;
            this.gpbEstadoPres.TabStop = false;
            this.gpbEstadoPres.Text = "Filtro";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(49, 46);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(69, 20);
            this.rbTodos.TabIndex = 2;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "TODOS";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbMunicipio
            // 
            this.rbMunicipio.AutoSize = true;
            this.rbMunicipio.Location = new System.Drawing.Point(49, 20);
            this.rbMunicipio.Name = "rbMunicipio";
            this.rbMunicipio.Size = new System.Drawing.Size(91, 20);
            this.rbMunicipio.TabIndex = 0;
            this.rbMunicipio.TabStop = true;
            this.rbMunicipio.Text = "MUNICIPIO";
            this.rbMunicipio.UseVisualStyleBackColor = true;
            this.rbMunicipio.CheckedChanged += new System.EventHandler(this.rbMunicipio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(85, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 128;
            this.label2.Text = "FILTRAR";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.BackgroundImage")));
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(49, 250);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 109);
            this.btnFiltrar.TabIndex = 127;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.label4);
            this.gbFiltro.Controls.Add(this.txtMpioCli);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.gpbEstadoPres);
            this.gbFiltro.Controls.Add(this.btnFiltrar);
            this.gbFiltro.Controls.Add(this.label2);
            this.gbFiltro.Location = new System.Drawing.Point(6, 352);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(218, 395);
            this.gbFiltro.TabIndex = 130;
            this.gbFiltro.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(30, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 133;
            this.label4.Text = "Selecciona el municipio";
            // 
            // txtMpioCli
            // 
            this.txtMpioCli.AutoCompleteCustomSource.AddRange(new string[] {
            "Acala",
            "Acapetahua",
            "Altamirano",
            "Amatán",
            "Amatenango de la Frontera",
            "Amatenango del Valle",
            "Ángel Albino Corzo",
            "Arriaga",
            "Bejucal de Ocampo",
            "Bella Vista",
            "Berriozábal",
            "Bochil",
            "El Bosque",
            "Cacahoatán",
            "Catazajá",
            "Cintalapa",
            "Coapilla",
            "Comitán de Domínguez",
            "La Concordia",
            "Copainalá",
            "Chalchihuitán",
            "Chamula",
            "Chanal",
            "Chapultenango",
            "Chenalhó",
            "Chiapa de Corzo",
            "Chiapilla",
            "Chicoasén",
            "Chicomuselo",
            "Chilón",
            "Escuintla",
            "Francisco León",
            "Frontera Comalapa",
            "Frontera Hidalgo",
            "La Grandeza",
            "Huehuetán",
            "Huixtán",
            "Huitiupán",
            "Huixtla",
            "La Independencia",
            "Ixhuatán",
            "Ixtacomitán",
            "Ixtapa",
            "Ixtapangajoya",
            "Jiquipilas",
            "Jitotol",
            "Juárez",
            "Larráinzar",
            "La Libertad",
            "Mapastepec",
            "Las Margaritas",
            "Mazapa de Madero",
            "Mazatán",
            "Metapa",
            "Mitontic",
            "Motozintla",
            "Nicolás Ruíz",
            "Ocosingo",
            "Ocotepec",
            "Ocozocoautla de Espinosa",
            "Ostuacán",
            "Osumacinta",
            "Oxchuc",
            "Palenque",
            "Pantelhó",
            "Pantepec",
            "Pichucalco",
            "Pijijiapan",
            "El Porvenir",
            "Villa Comaltitlán",
            "Pueblo Nuevo Solistahuacán",
            "Rayón",
            "Reforma",
            "Las Rosas",
            "Sabanilla",
            "Salto de Agua",
            "San Cristóbal de las Casas",
            "San Fernando",
            "Siltepec",
            "Simojovel",
            "Sitalá",
            "Socoltenango",
            "Solosuchiapa",
            "Soyaló",
            "Suchiapa",
            "Suchiate",
            "Sunuapa",
            "Tapachula",
            "Tapalapa",
            "Tapilula",
            "Tecpatán",
            "Tenejapa",
            "Teopisca",
            "Tila",
            "Tonalá",
            "Totolapa",
            "La Trinitaria",
            "Tumbalá",
            "Tuxtla Gutiérrez",
            "Tuxtla Chico",
            "Tuzantán",
            "Tzimol",
            "Unión Juárez",
            "Venustiano Carranza",
            "Villa Corzo",
            "Villaflores",
            "Yajalón",
            "San Lucas",
            "Zinacantán",
            "San Juan Cancuc",
            "Aldama",
            "Benemérito de las Américas",
            "Maravilla Tenejapa",
            "Marqués de Comillas",
            "Montecristo de Guerrero",
            "San Andrés Duraznal",
            "Santiago el Pinar",
            "Capitán Luis Ángel Vidal",
            "Rincón Chamula San Pedro",
            "El Parral",
            "Emiliano Zapata",
            "Mezcalapa",
            "Honduras de la Sierra"});
            this.txtMpioCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMpioCli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMpioCli.BackColor = System.Drawing.Color.White;
            this.txtMpioCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMpioCli.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMpioCli.FormattingEnabled = true;
            this.txtMpioCli.Items.AddRange(new object[] {
            "Acala",
            "Acapetahua",
            "Altamirano",
            "Amatán",
            "Amatenango de la Frontera",
            "Amatenango del Valle",
            "Ángel Albino Corzo",
            "Arriaga",
            "Bejucal de Ocampo",
            "Bella Vista",
            "Berriozábal",
            "Bochil",
            "El Bosque",
            "Cacahoatán",
            "Catazajá",
            "Cintalapa",
            "Coapilla",
            "Comitán de Domínguez",
            "La Concordia",
            "Copainalá",
            "Chalchihuitán",
            "Chamula",
            "Chanal",
            "Chapultenango",
            "Chenalhó",
            "Chiapa de Corzo",
            "Chiapilla",
            "Chicoasén",
            "Chicomuselo",
            "Chilón",
            "Escuintla",
            "Francisco León",
            "Frontera Comalapa",
            "Frontera Hidalgo",
            "La Grandeza",
            "Huehuetán",
            "Huixtán",
            "Huitiupán",
            "Huixtla",
            "La Independencia",
            "Ixhuatán",
            "Ixtacomitán",
            "Ixtapa",
            "Ixtapangajoya",
            "Jiquipilas",
            "Jitotol",
            "Juárez",
            "Larráinzar",
            "La Libertad",
            "Mapastepec",
            "Las Margaritas",
            "Mazapa de Madero",
            "Mazatán",
            "Metapa",
            "Mitontic",
            "Motozintla",
            "Nicolás Ruíz",
            "Ocosingo",
            "Ocotepec",
            "Ocozocoautla de Espinosa",
            "Ostuacán",
            "Osumacinta",
            "Oxchuc",
            "Palenque",
            "Pantelhó",
            "Pantepec",
            "Pichucalco",
            "Pijijiapan",
            "El Porvenir",
            "Villa Comaltitlán",
            "Pueblo Nuevo Solistahuacán",
            "Rayón",
            "Reforma",
            "Las Rosas",
            "Sabanilla",
            "Salto de Agua",
            "San Cristóbal de las Casas",
            "San Fernando",
            "Siltepec",
            "Simojovel",
            "Sitalá",
            "Socoltenango",
            "Solosuchiapa",
            "Soyaló",
            "Suchiapa",
            "Suchiate",
            "Sunuapa",
            "Tapachula",
            "Tapalapa",
            "Tapilula",
            "Tecpatán",
            "Tenejapa",
            "Teopisca",
            "Tila",
            "Tonalá",
            "Totolapa",
            "La Trinitaria",
            "Tumbalá",
            "Tuxtla Gutiérrez",
            "Tuxtla Chico",
            "Tuzantán",
            "Tzimol",
            "Unión Juárez",
            "Venustiano Carranza",
            "Villa Corzo",
            "Villaflores",
            "Yajalón",
            "San Lucas",
            "Zinacantán",
            "San Juan Cancuc",
            "Aldama",
            "Benemérito de las Américas",
            "Maravilla Tenejapa",
            "Marqués de Comillas",
            "Montecristo de Guerrero",
            "San Andrés Duraznal",
            "Santiago el Pinar",
            "Capitán Luis Ángel Vidal",
            "Rincón Chamula San Pedro",
            "El Parral",
            "Emiliano Zapata",
            "Mezcalapa",
            "Honduras de la Sierra"});
            this.txtMpioCli.Location = new System.Drawing.Point(15, 183);
            this.txtMpioCli.Name = "txtMpioCli";
            this.txtMpioCli.Size = new System.Drawing.Size(189, 27);
            this.txtMpioCli.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 44);
            this.label3.TabIndex = 131;
            this.label3.Text = "FILTRAR CLIENTES\r\nPOR:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 752);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.btnReportCli);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnCountPres);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteClientes_Load);
            this.gpbEstadoPres.ResumeLayout(false);
            this.gpbEstadoPres.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnCountPres;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportCli;
        private System.Windows.Forms.GroupBox gpbEstadoPres;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbMunicipio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtMpioCli;
    }
}