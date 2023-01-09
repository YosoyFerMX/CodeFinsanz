
namespace controlPrestamos.Presentation
{
    partial class frmCobradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobradores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCobradores = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDesbloq = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReporteCob = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnEliminarCob = new System.Windows.Forms.Button();
            this.btnEditarCobrador = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dgvCobradores = new System.Windows.Forms.DataGridView();
            this.gbCobradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobradores)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCobradores
            // 
            this.gbCobradores.Controls.Add(this.btnLimpiar);
            this.gbCobradores.Controls.Add(this.btnDesbloq);
            this.gbCobradores.Controls.Add(this.label11);
            this.gbCobradores.Controls.Add(this.btnReporteCob);
            this.gbCobradores.Controls.Add(this.label20);
            this.gbCobradores.Controls.Add(this.btnEliminarCob);
            this.gbCobradores.Controls.Add(this.btnEditarCobrador);
            this.gbCobradores.Controls.Add(this.btnGuardar);
            this.gbCobradores.Controls.Add(this.label21);
            this.gbCobradores.Controls.Add(this.txtBuscar);
            this.gbCobradores.Controls.Add(this.txtTelefono);
            this.gbCobradores.Controls.Add(this.label24);
            this.gbCobradores.Controls.Add(this.txtZona);
            this.gbCobradores.Controls.Add(this.label25);
            this.gbCobradores.Controls.Add(this.txtMunicipio);
            this.gbCobradores.Controls.Add(this.label26);
            this.gbCobradores.Controls.Add(this.txtApellido2);
            this.gbCobradores.Controls.Add(this.label27);
            this.gbCobradores.Controls.Add(this.txtApellido1);
            this.gbCobradores.Controls.Add(this.label28);
            this.gbCobradores.Controls.Add(this.label29);
            this.gbCobradores.Controls.Add(this.txtNombre);
            this.gbCobradores.Controls.Add(this.label30);
            this.gbCobradores.Controls.Add(this.dgvCobradores);
            this.gbCobradores.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCobradores.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbCobradores.Location = new System.Drawing.Point(13, 53);
            this.gbCobradores.Name = "gbCobradores";
            this.gbCobradores.Size = new System.Drawing.Size(1108, 617);
            this.gbCobradores.TabIndex = 77;
            this.gbCobradores.TabStop = false;
            this.gbCobradores.Text = "COBRADORES";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(438, 555);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 42);
            this.btnLimpiar.TabIndex = 121;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDesbloq
            // 
            this.btnDesbloq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesbloq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloq.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesbloq.Location = new System.Drawing.Point(332, 555);
            this.btnDesbloq.Name = "btnDesbloq";
            this.btnDesbloq.Size = new System.Drawing.Size(100, 42);
            this.btnDesbloq.TabIndex = 120;
            this.btnDesbloq.Text = "EDITAR";
            this.btnDesbloq.UseVisualStyleBackColor = true;
            this.btnDesbloq.Click += new System.EventHandler(this.btnDesbloq_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(895, 569);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 119;
            this.label11.Text = "GENERAR INFORME";
            // 
            // btnReporteCob
            // 
            this.btnReporteCob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReporteCob.BackgroundImage")));
            this.btnReporteCob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReporteCob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteCob.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReporteCob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReporteCob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReporteCob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCob.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCob.Location = new System.Drawing.Point(1017, 540);
            this.btnReporteCob.Name = "btnReporteCob";
            this.btnReporteCob.Size = new System.Drawing.Size(85, 72);
            this.btnReporteCob.TabIndex = 84;
            this.btnReporteCob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporteCob.UseVisualStyleBackColor = true;
            this.btnReporteCob.Click += new System.EventHandler(this.btnReporteCob_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(234, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(193, 22);
            this.label20.TabIndex = 75;
            this.label20.Text = "Lista de Cobradores";
            // 
            // btnEliminarCob
            // 
            this.btnEliminarCob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCob.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCob.Location = new System.Drawing.Point(620, 555);
            this.btnEliminarCob.Name = "btnEliminarCob";
            this.btnEliminarCob.Size = new System.Drawing.Size(109, 42);
            this.btnEliminarCob.TabIndex = 74;
            this.btnEliminarCob.Text = "ELIMINAR";
            this.btnEliminarCob.UseVisualStyleBackColor = true;
            this.btnEliminarCob.Click += new System.EventHandler(this.btnEliminarCob_Click);
            // 
            // btnEditarCobrador
            // 
            this.btnEditarCobrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCobrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCobrador.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCobrador.Location = new System.Drawing.Point(226, 555);
            this.btnEditarCobrador.Name = "btnEditarCobrador";
            this.btnEditarCobrador.Size = new System.Drawing.Size(100, 42);
            this.btnEditarCobrador.TabIndex = 73;
            this.btnEditarCobrador.Text = "VER";
            this.btnEditarCobrador.UseVisualStyleBackColor = true;
            this.btnEditarCobrador.Click += new System.EventHandler(this.btnEditarCobrador_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(19, 475);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 42);
            this.btnGuardar.TabIndex = 72;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label21.Location = new System.Drawing.Point(883, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(175, 24);
            this.label21.TabIndex = 71;
            this.label21.Text = "Buscar por Nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.txtBuscar.Location = new System.Drawing.Point(853, 71);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(235, 24);
            this.txtBuscar.TabIndex = 70;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(19, 398);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(189, 23);
            this.txtTelefono.TabIndex = 43;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label24.Location = new System.Drawing.Point(15, 373);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 22);
            this.label24.TabIndex = 42;
            this.label24.Text = "Teléfono";
            // 
            // txtZona
            // 
            this.txtZona.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZona.Location = new System.Drawing.Point(19, 347);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(189, 23);
            this.txtZona.TabIndex = 41;
            this.txtZona.TextChanged += new System.EventHandler(this.txtZona_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label25.Location = new System.Drawing.Point(15, 325);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 22);
            this.label25.TabIndex = 40;
            this.label25.Text = "Zona";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(19, 298);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(189, 23);
            this.txtMunicipio.TabIndex = 39;
            this.txtMunicipio.TextChanged += new System.EventHandler(this.txtMunicipio_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label26.Location = new System.Drawing.Point(15, 276);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(187, 22);
            this.label26.TabIndex = 38;
            this.label26.Text = "Municipio de cobro";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(19, 250);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(189, 23);
            this.txtApellido2.TabIndex = 37;
            this.txtApellido2.TextChanged += new System.EventHandler(this.txtApellido2_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label27.Location = new System.Drawing.Point(15, 225);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(172, 22);
            this.label27.TabIndex = 36;
            this.label27.Text = "Segundo Apellido";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(19, 199);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(189, 23);
            this.txtApellido1.TabIndex = 35;
            this.txtApellido1.TextChanged += new System.EventHandler(this.txtApellido1_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(15, 178);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(144, 22);
            this.label28.TabIndex = 34;
            this.label28.Text = "Primer Apellido";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label29.Location = new System.Drawing.Point(6, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(165, 22);
            this.label29.TabIndex = 33;
            this.label29.Text = "Datos personales";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(19, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 23);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label30.Location = new System.Drawing.Point(15, 132);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(89, 22);
            this.label30.TabIndex = 31;
            this.label30.Text = "Nombre:";
            // 
            // dgvCobradores
            // 
            this.dgvCobradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCobradores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCobradores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCobradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvCobradores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCobradores.ColumnHeadersHeight = 45;
            this.dgvCobradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCobradores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCobradores.EnableHeadersVisualStyles = false;
            this.dgvCobradores.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCobradores.Location = new System.Drawing.Point(228, 96);
            this.dgvCobradores.Name = "dgvCobradores";
            this.dgvCobradores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobradores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCobradores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCobradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobradores.Size = new System.Drawing.Size(874, 442);
            this.dgvCobradores.TabIndex = 48;
            // 
            // frmCobradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 674);
            this.Controls.Add(this.gbCobradores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCobradores";
            this.Text = "frmCobradores";
            this.Load += new System.EventHandler(this.frmCobradores_Load);
            this.gbCobradores.ResumeLayout(false);
            this.gbCobradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCobradores;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEliminarCob;
        private System.Windows.Forms.Button btnEditarCobrador;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dgvCobradores;
        private System.Windows.Forms.Button btnReporteCob;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDesbloq;
        private System.Windows.Forms.Button btnLimpiar;
    }
}