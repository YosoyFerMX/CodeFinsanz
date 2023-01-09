
namespace controlPrestamos.Presentation
{
    partial class frmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPrestamos = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.printContrato = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.calendarPres = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nUpDawnInteres = new System.Windows.Forms.NumericUpDown();
            this.nUpDawnCuotas = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblValxCuot = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.gbAval = new System.Windows.Forms.GroupBox();
            this.txtTelAval = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDirAval = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNombreAval = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.txtCobAsigAcli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMunicipioCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefonoCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido2Cli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtApellido1Cli = new System.Windows.Forms.TextBox();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.gbPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDawnInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDawnCuotas)).BeginInit();
            this.gbAval.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrestamos
            // 
            this.gbPrestamos.Controls.Add(this.label18);
            this.gbPrestamos.Controls.Add(this.printContrato);
            this.gbPrestamos.Controls.Add(this.label17);
            this.gbPrestamos.Controls.Add(this.btnAjustes);
            this.gbPrestamos.Controls.Add(this.calendarPres);
            this.gbPrestamos.Controls.Add(this.label15);
            this.gbPrestamos.Controls.Add(this.label14);
            this.gbPrestamos.Controls.Add(this.dgvCuotas);
            this.gbPrestamos.Controls.Add(this.groupBox2);
            this.gbPrestamos.Controls.Add(this.groupBox1);
            this.gbPrestamos.Controls.Add(this.btnGuardarPrestamo);
            this.gbPrestamos.Controls.Add(this.label25);
            this.gbPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPrestamos.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrestamos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbPrestamos.Location = new System.Drawing.Point(13, 36);
            this.gbPrestamos.Name = "gbPrestamos";
            this.gbPrestamos.Size = new System.Drawing.Size(1108, 626);
            this.gbPrestamos.TabIndex = 78;
            this.gbPrestamos.TabStop = false;
            this.gbPrestamos.Text = "PRESTAMOS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label18.Location = new System.Drawing.Point(983, 499);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 44);
            this.label18.TabIndex = 109;
            this.label18.Text = "Imprimir\r\nContrato";
            // 
            // printContrato
            // 
            this.printContrato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printContrato.BackgroundImage")));
            this.printContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.printContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printContrato.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.printContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printContrato.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printContrato.Location = new System.Drawing.Point(888, 490);
            this.printContrato.Name = "printContrato";
            this.printContrato.Size = new System.Drawing.Size(98, 74);
            this.printContrato.TabIndex = 108;
            this.printContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printContrato.UseVisualStyleBackColor = true;
            this.printContrato.Click += new System.EventHandler(this.printContrato_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(950, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 22);
            this.label17.TabIndex = 87;
            this.label17.Text = "Prestamos";
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
            this.btnAjustes.Location = new System.Drawing.Point(1053, 12);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(49, 40);
            this.btnAjustes.TabIndex = 107;
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // calendarPres
            // 
            this.calendarPres.CustomFormat = "dd-MM-yyyy";
            this.calendarPres.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarPres.Location = new System.Drawing.Point(763, 24);
            this.calendarPres.Name = "calendarPres";
            this.calendarPres.Size = new System.Drawing.Size(124, 28);
            this.calendarPres.TabIndex = 106;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(757, 499);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 44);
            this.label15.TabIndex = 104;
            this.label15.Text = "Guardar\r\nPrestamo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(28, 388);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 22);
            this.label14.TabIndex = 104;
            this.label14.Text = "Lista de Cuotas";
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvCuotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCuotas.ColumnHeadersHeight = 45;
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folio,
            this.numCuota,
            this.fechaCuota,
            this.montoCuota,
            this.estado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuotas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCuotas.EnableHeadersVisualStyles = false;
            this.dgvCuotas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCuotas.Location = new System.Drawing.Point(28, 413);
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.ReadOnly = true;
            this.dgvCuotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCuotas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuotas.Size = new System.Drawing.Size(622, 207);
            this.dgvCuotas.TabIndex = 88;
            // 
            // folio
            // 
            this.folio.HeaderText = "Folio";
            this.folio.Name = "folio";
            this.folio.ReadOnly = true;
            // 
            // numCuota
            // 
            this.numCuota.HeaderText = "Numero de Cuota";
            this.numCuota.Name = "numCuota";
            this.numCuota.ReadOnly = true;
            // 
            // fechaCuota
            // 
            this.fechaCuota.HeaderText = "Fecha de Pago";
            this.fechaCuota.Name = "fechaCuota";
            this.fechaCuota.ReadOnly = true;
            // 
            // montoCuota
            // 
            this.montoCuota.HeaderText = "Monto de Cuota";
            this.montoCuota.Name = "montoCuota";
            this.montoCuota.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nUpDawnInteres);
            this.groupBox2.Controls.Add(this.nUpDawnCuotas);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblInteres);
            this.groupBox2.Controls.Add(this.lblValxCuot);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMontoPagar);
            this.groupBox2.Controls.Add(this.gbAval);
            this.groupBox2.Controls.Add(this.cmbFormaPago);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox2.Location = new System.Drawing.Point(22, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1047, 162);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Prestamo";
            // 
            // nUpDawnInteres
            // 
            this.nUpDawnInteres.Location = new System.Drawing.Point(510, 107);
            this.nUpDawnInteres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDawnInteres.Name = "nUpDawnInteres";
            this.nUpDawnInteres.Size = new System.Drawing.Size(173, 28);
            this.nUpDawnInteres.TabIndex = 105;
            this.nUpDawnInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDawnInteres.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // nUpDawnCuotas
            // 
            this.nUpDawnCuotas.Location = new System.Drawing.Point(510, 48);
            this.nUpDawnCuotas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDawnCuotas.Name = "nUpDawnCuotas";
            this.nUpDawnCuotas.Size = new System.Drawing.Size(173, 28);
            this.nUpDawnCuotas.TabIndex = 104;
            this.nUpDawnCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDawnCuotas.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(862, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 22);
            this.label13.TabIndex = 103;
            this.label13.Text = "Calcular";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(877, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(58, 60);
            this.btnCalcular.TabIndex = 88;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(835, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 22);
            this.label12.TabIndex = 102;
            this.label12.Text = "Monto a Pagar:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.BackColor = System.Drawing.Color.Transparent;
            this.lblInteres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInteres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblInteres.Location = new System.Drawing.Point(702, 112);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(45, 20);
            this.lblInteres.TabIndex = 101;
            this.lblInteres.Text = "$0.00";
            // 
            // lblValxCuot
            // 
            this.lblValxCuot.AutoSize = true;
            this.lblValxCuot.BackColor = System.Drawing.Color.Transparent;
            this.lblValxCuot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValxCuot.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValxCuot.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblValxCuot.Location = new System.Drawing.Point(702, 46);
            this.lblValxCuot.Name = "lblValxCuot";
            this.lblValxCuot.Size = new System.Drawing.Size(45, 20);
            this.lblValxCuot.TabIndex = 100;
            this.lblValxCuot.Text = "$0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(697, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 99;
            this.label10.Text = "Intereses";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(697, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 98;
            this.label9.Text = "Valor x cuota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(506, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 96;
            this.label7.Text = "Interés %";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(506, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 22);
            this.label6.TabIndex = 94;
            this.label6.Text = "Num de cuotas";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Enabled = false;
            this.txtMontoPagar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPagar.Location = new System.Drawing.Point(820, 122);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(189, 31);
            this.txtMontoPagar.TabIndex = 41;
            this.txtMontoPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbAval
            // 
            this.gbAval.Controls.Add(this.txtTelAval);
            this.gbAval.Controls.Add(this.label20);
            this.gbAval.Controls.Add(this.txtDirAval);
            this.gbAval.Controls.Add(this.label19);
            this.gbAval.Controls.Add(this.txtNombreAval);
            this.gbAval.Controls.Add(this.label16);
            this.gbAval.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAval.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbAval.Location = new System.Drawing.Point(222, 13);
            this.gbAval.Name = "gbAval";
            this.gbAval.Size = new System.Drawing.Size(278, 144);
            this.gbAval.TabIndex = 88;
            this.gbAval.TabStop = false;
            this.gbAval.Text = "Datos del Aval";
            // 
            // txtTelAval
            // 
            this.txtTelAval.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelAval.Location = new System.Drawing.Point(6, 121);
            this.txtTelAval.Name = "txtTelAval";
            this.txtTelAval.Size = new System.Drawing.Size(266, 23);
            this.txtTelAval.TabIndex = 111;
            this.txtTelAval.Tag = "Escriba el número de Teléfono";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label20.Location = new System.Drawing.Point(6, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 20);
            this.label20.TabIndex = 110;
            this.label20.Text = "Tel:";
            // 
            // txtDirAval
            // 
            this.txtDirAval.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirAval.Location = new System.Drawing.Point(6, 77);
            this.txtDirAval.Name = "txtDirAval";
            this.txtDirAval.Size = new System.Drawing.Size(266, 23);
            this.txtDirAval.TabIndex = 109;
            this.txtDirAval.Tag = "Escriba la Dirección";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label19.Location = new System.Drawing.Point(6, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 20);
            this.label19.TabIndex = 108;
            this.label19.Text = "Dirección:";
            // 
            // txtNombreAval
            // 
            this.txtNombreAval.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAval.Location = new System.Drawing.Point(6, 34);
            this.txtNombreAval.Name = "txtNombreAval";
            this.txtNombreAval.Size = new System.Drawing.Size(266, 23);
            this.txtNombreAval.TabIndex = 107;
            this.txtNombreAval.Tag = "Escriba los  Nombres y apellidos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(6, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.TabIndex = 106;
            this.label16.Text = "Nombre:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "DIARIO",
            "SEMANAL"});
            this.cmbFormaPago.Location = new System.Drawing.Point(7, 111);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(198, 29);
            this.cmbFormaPago.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(25, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Forma de Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 22);
            this.label11.TabIndex = 31;
            this.label11.Text = "Monto Requerido";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.Red;
            this.txtMonto.Location = new System.Drawing.Point(6, 49);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(189, 27);
            this.txtMonto.TabIndex = 32;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCli);
            this.groupBox1.Controls.Add(this.txtCobAsigAcli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccionCli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMunicipioCli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefonoCli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido2Cli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.txtFolio);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.txtNombreCli);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtApellido1Cli);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(22, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 162);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Cliente";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCli.BackgroundImage")));
            this.btnBuscarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCli.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCli.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscarCli.Location = new System.Drawing.Point(685, 103);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(331, 42);
            this.btnBuscarCli.TabIndex = 86;
            this.btnBuscarCli.Text = "BUSCAR";
            this.btnBuscarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // txtCobAsigAcli
            // 
            this.txtCobAsigAcli.Enabled = false;
            this.txtCobAsigAcli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCobAsigAcli.Location = new System.Drawing.Point(412, 122);
            this.txtCobAsigAcli.Name = "txtCobAsigAcli";
            this.txtCobAsigAcli.Size = new System.Drawing.Size(189, 23);
            this.txtCobAsigAcli.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(408, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cobrador Asignado";
            // 
            // txtDireccionCli
            // 
            this.txtDireccionCli.Enabled = false;
            this.txtDireccionCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCli.Location = new System.Drawing.Point(191, 122);
            this.txtDireccionCli.Name = "txtDireccionCli";
            this.txtDireccionCli.Size = new System.Drawing.Size(189, 23);
            this.txtDireccionCli.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(248, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Dirección";
            // 
            // txtMunicipioCli
            // 
            this.txtMunicipioCli.Enabled = false;
            this.txtMunicipioCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipioCli.Location = new System.Drawing.Point(6, 122);
            this.txtMunicipioCli.Name = "txtMunicipioCli";
            this.txtMunicipioCli.Size = new System.Drawing.Size(157, 23);
            this.txtMunicipioCli.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Municipio";
            // 
            // txtTelefonoCli
            // 
            this.txtTelefonoCli.Enabled = false;
            this.txtTelefonoCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCli.Location = new System.Drawing.Point(839, 49);
            this.txtTelefonoCli.Name = "txtTelefonoCli";
            this.txtTelefonoCli.Size = new System.Drawing.Size(189, 23);
            this.txtTelefonoCli.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(890, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Telefono";
            // 
            // txtApellido2Cli
            // 
            this.txtApellido2Cli.Enabled = false;
            this.txtApellido2Cli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2Cli.Location = new System.Drawing.Point(620, 49);
            this.txtApellido2Cli.Name = "txtApellido2Cli";
            this.txtApellido2Cli.Size = new System.Drawing.Size(189, 23);
            this.txtApellido2Cli.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(632, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Segundo Apellido";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label30.Location = new System.Drawing.Point(6, 24);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(157, 22);
            this.label30.TabIndex = 31;
            this.label30.Text = "Número de Folio";
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.ForeColor = System.Drawing.Color.Red;
            this.txtFolio.Location = new System.Drawing.Point(6, 49);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.ReadOnly = true;
            this.txtFolio.Size = new System.Drawing.Size(157, 27);
            this.txtFolio.TabIndex = 32;
            this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label28.Location = new System.Drawing.Point(248, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(84, 22);
            this.label28.TabIndex = 34;
            this.label28.Text = "Nombre";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Enabled = false;
            this.txtNombreCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCli.Location = new System.Drawing.Point(191, 49);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(189, 23);
            this.txtNombreCli.TabIndex = 35;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label27.Location = new System.Drawing.Point(433, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(144, 22);
            this.label27.TabIndex = 36;
            this.label27.Text = "Primer Apellido";
            // 
            // txtApellido1Cli
            // 
            this.txtApellido1Cli.Enabled = false;
            this.txtApellido1Cli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1Cli.Location = new System.Drawing.Point(412, 49);
            this.txtApellido1Cli.Name = "txtApellido1Cli";
            this.txtApellido1Cli.Size = new System.Drawing.Size(189, 23);
            this.txtApellido1Cli.TabIndex = 37;
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarPrestamo.BackgroundImage")));
            this.btnGuardarPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPrestamo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(661, 487);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(98, 74);
            this.btnGuardarPrestamo.TabIndex = 74;
            this.btnGuardarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPrestamo.UseVisualStyleBackColor = true;
            this.btnGuardarPrestamo.Click += new System.EventHandler(this.btnGuardarPrestamo_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label25.Location = new System.Drawing.Point(688, 23);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 23);
            this.label25.TabIndex = 40;
            this.label25.Text = "Fecha";
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 674);
            this.Controls.Add(this.gbPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrestamos";
            this.Text = "frmPrestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.gbPrestamos.ResumeLayout(false);
            this.gbPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDawnInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDawnCuotas)).EndInit();
            this.gbAval.ResumeLayout(false);
            this.gbAval.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrestamos;
        private System.Windows.Forms.Button btnGuardarPrestamo;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtApellido1Cli;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellido2Cli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonoCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.TextBox txtCobAsigAcli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMunicipioCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbAval;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblValxCuot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvCuotas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nUpDawnCuotas;
        private System.Windows.Forms.NumericUpDown nUpDawnInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DateTimePicker calendarPres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button printContrato;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTelAval;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDirAval;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNombreAval;
    }
}