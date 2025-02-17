namespace interfazPpal
{
    partial class FrmIngresarEditarPaquetes
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbTipoBus = new System.Windows.Forms.ComboBox();
            this.cmbRegimen = new System.Windows.Forms.ComboBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.btnAgregarDestino = new System.Windows.Forms.Button();
            this.btnBuscarHotel = new System.Windows.Forms.Button();
            this.btnBuscarBus = new System.Windows.Forms.Button();
            this.npdCantidadAsientos = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadAsientos = new System.Windows.Forms.Label();
            this.txtCoste = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblSingle = new System.Windows.Forms.Label();
            this.npdCantidadNoches = new System.Windows.Forms.NumericUpDown();
            this.npdCantidasDias = new System.Windows.Forms.NumericUpDown();
            this.lblCuadruples = new System.Windows.Forms.Label();
            this.lblTriples = new System.Windows.Forms.Label();
            this.lblDoble = new System.Windows.Forms.Label();
            this.lblCantidadHabitaciones = new System.Windows.Forms.Label();
            this.npdDisponibilidad = new System.Windows.Forms.NumericUpDown();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.npdAsientosCama = new System.Windows.Forms.NumericUpDown();
            this.lbbAsientosSemicama = new System.Windows.Forms.Label();
            this.npdAsientosSemicama = new System.Windows.Forms.NumericUpDown();
            this.lblNombreBus = new System.Windows.Forms.Label();
            this.lblAsientosCama = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.txtPrecioEfectivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioLista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGastosAdministrativos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegreso = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblCantidadSingle = new System.Windows.Forms.Label();
            this.lblCantidadDobles = new System.Windows.Forms.Label();
            this.lblCantidadTriples = new System.Windows.Forms.Label();
            this.lblCantidadCuadruples = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadAsientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadNoches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidasDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdDisponibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosCama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosSemicama)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(572, 655);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(199, 47);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1055, 655);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 47);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(330, 655);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(199, 47);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquetes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPaquetes.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dgvPaquetes.Location = new System.Drawing.Point(21, 296);
            this.dgvPaquetes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPaquetes.MultiSelect = false;
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.RowHeadersWidth = 51;
            this.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquetes.Size = new System.Drawing.Size(1284, 241);
            this.dgvPaquetes.TabIndex = 19;
            this.dgvPaquetes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaquetes_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHabitaciones);
            this.groupBox1.Controls.Add(this.lblCantidadCuadruples);
            this.groupBox1.Controls.Add(this.lblCantidadTriples);
            this.groupBox1.Controls.Add(this.lblCantidadDobles);
            this.groupBox1.Controls.Add(this.lblCantidadSingle);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.cmbTipoBus);
            this.groupBox1.Controls.Add(this.cmbRegimen);
            this.groupBox1.Controls.Add(this.cmbBus);
            this.groupBox1.Controls.Add(this.cmbHotel);
            this.groupBox1.Controls.Add(this.btnAgregarDestino);
            this.groupBox1.Controls.Add(this.btnBuscarHotel);
            this.groupBox1.Controls.Add(this.btnBuscarBus);
            this.groupBox1.Controls.Add(this.npdCantidadAsientos);
            this.groupBox1.Controls.Add(this.lblCantidadAsientos);
            this.groupBox1.Controls.Add(this.txtCoste);
            this.groupBox1.Controls.Add(this.lblCosto);
            this.groupBox1.Controls.Add(this.lblSingle);
            this.groupBox1.Controls.Add(this.npdCantidadNoches);
            this.groupBox1.Controls.Add(this.npdCantidasDias);
            this.groupBox1.Controls.Add(this.lblCuadruples);
            this.groupBox1.Controls.Add(this.lblTriples);
            this.groupBox1.Controls.Add(this.lblDoble);
            this.groupBox1.Controls.Add(this.lblCantidadHabitaciones);
            this.groupBox1.Controls.Add(this.npdDisponibilidad);
            this.groupBox1.Controls.Add(this.lblDisponibilidad);
            this.groupBox1.Controls.Add(this.npdAsientosCama);
            this.groupBox1.Controls.Add(this.lbbAsientosSemicama);
            this.groupBox1.Controls.Add(this.npdAsientosSemicama);
            this.groupBox1.Controls.Add(this.lblNombreBus);
            this.groupBox1.Controls.Add(this.lblAsientosCama);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.lblFechaSalida);
            this.groupBox1.Controls.Add(this.txtPrecioEfectivo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPrecioLista);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGastosAdministrativos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTransporte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaRegreso);
            this.groupBox1.Controls.Add(this.lblFechaRegreso);
            this.groupBox1.Location = new System.Drawing.Point(21, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1284, 270);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Nuevo Paquete";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(152, 90);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(197, 24);
            this.cmbDestino.TabIndex = 3;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged_1);
            // 
            // cmbTipoBus
            // 
            this.cmbTipoBus.AutoCompleteCustomSource.AddRange(new string[] {
            "Suite",
            "Cama",
            "Semicama"});
            this.cmbTipoBus.FormattingEnabled = true;
            this.cmbTipoBus.Location = new System.Drawing.Point(475, 224);
            this.cmbTipoBus.Name = "cmbTipoBus";
            this.cmbTipoBus.Size = new System.Drawing.Size(197, 24);
            this.cmbTipoBus.TabIndex = 17;
            // 
            // cmbRegimen
            // 
            this.cmbRegimen.FormattingEnabled = true;
            this.cmbRegimen.Location = new System.Drawing.Point(480, 58);
            this.cmbRegimen.Name = "cmbRegimen";
            this.cmbRegimen.Size = new System.Drawing.Size(197, 24);
            this.cmbRegimen.TabIndex = 10;
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(475, 169);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(197, 24);
            this.cmbBus.TabIndex = 16;
            this.cmbBus.SelectedIndexChanged += new System.EventHandler(this.cmbBus_SelectedIndexChanged);
            // 
            // cmbHotel
            // 
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(480, 11);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(197, 24);
            this.cmbHotel.TabIndex = 8;
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            // 
            // btnAgregarDestino
            // 
            this.btnAgregarDestino.AutoSize = true;
            this.btnAgregarDestino.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregarDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDestino.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDestino.Location = new System.Drawing.Point(152, 125);
            this.btnAgregarDestino.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDestino.Name = "btnAgregarDestino";
            this.btnAgregarDestino.Size = new System.Drawing.Size(197, 37);
            this.btnAgregarDestino.TabIndex = 4;
            this.btnAgregarDestino.Text = "Destino";
            this.btnAgregarDestino.UseVisualStyleBackColor = false;
            this.btnAgregarDestino.Click += new System.EventHandler(this.btnAgregarDestino_Click);
            // 
            // btnBuscarHotel
            // 
            this.btnBuscarHotel.AutoSize = true;
            this.btnBuscarHotel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHotel.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHotel.Location = new System.Drawing.Point(679, 7);
            this.btnBuscarHotel.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarHotel.Name = "btnBuscarHotel";
            this.btnBuscarHotel.Size = new System.Drawing.Size(192, 37);
            this.btnBuscarHotel.TabIndex = 9;
            this.btnBuscarHotel.Text = "Hotel";
            this.btnBuscarHotel.UseVisualStyleBackColor = false;
            this.btnBuscarHotel.Click += new System.EventHandler(this.btnBuscarHotel_Click);
            // 
            // btnBuscarBus
            // 
            this.btnBuscarBus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscarBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBus.ForeColor = System.Drawing.Color.White;
            this.btnBuscarBus.Location = new System.Drawing.Point(679, 162);
            this.btnBuscarBus.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarBus.Name = "btnBuscarBus";
            this.btnBuscarBus.Size = new System.Drawing.Size(192, 44);
            this.btnBuscarBus.TabIndex = 17;
            this.btnBuscarBus.Text = "Transporte";
            this.btnBuscarBus.UseVisualStyleBackColor = false;
            this.btnBuscarBus.Click += new System.EventHandler(this.btnBuscarBus_Click);
            // 
            // npdCantidadAsientos
            // 
            this.npdCantidadAsientos.Location = new System.Drawing.Point(779, 228);
            this.npdCantidadAsientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdCantidadAsientos.Name = "npdCantidadAsientos";
            this.npdCantidadAsientos.Size = new System.Drawing.Size(44, 22);
            this.npdCantidadAsientos.TabIndex = 19;
            // 
            // lblCantidadAsientos
            // 
            this.lblCantidadAsientos.AutoSize = true;
            this.lblCantidadAsientos.Location = new System.Drawing.Point(692, 218);
            this.lblCantidadAsientos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadAsientos.Name = "lblCantidadAsientos";
            this.lblCantidadAsientos.Size = new System.Drawing.Size(80, 32);
            this.lblCantidadAsientos.TabIndex = 127;
            this.lblCantidadAsientos.Text = "Cantidad de\r\n      Asientos:";
            // 
            // txtCoste
            // 
            this.txtCoste.Location = new System.Drawing.Point(1079, 22);
            this.txtCoste.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoste.Name = "txtCoste";
            this.txtCoste.Size = new System.Drawing.Size(197, 22);
            this.txtCoste.TabIndex = 22;
            this.txtCoste.Leave += new System.EventHandler(this.txtCoste_Leave);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(1017, 25);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(48, 16);
            this.lblCosto.TabIndex = 125;
            this.lblCosto.Text = "Coste: ";
            // 
            // lblSingle
            // 
            this.lblSingle.AutoSize = true;
            this.lblSingle.Location = new System.Drawing.Point(404, 111);
            this.lblSingle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSingle.Name = "lblSingle";
            this.lblSingle.Size = new System.Drawing.Size(48, 16);
            this.lblSingle.TabIndex = 124;
            this.lblSingle.Text = "Single:";
            // 
            // npdCantidadNoches
            // 
            this.npdCantidadNoches.Location = new System.Drawing.Point(302, 177);
            this.npdCantidadNoches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdCantidadNoches.Name = "npdCantidadNoches";
            this.npdCantidadNoches.Size = new System.Drawing.Size(47, 22);
            this.npdCantidadNoches.TabIndex = 6;
            // 
            // npdCantidasDias
            // 
            this.npdCantidasDias.Location = new System.Drawing.Point(187, 177);
            this.npdCantidasDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdCantidasDias.Name = "npdCantidasDias";
            this.npdCantidasDias.Size = new System.Drawing.Size(47, 22);
            this.npdCantidasDias.TabIndex = 5;
            // 
            // lblCuadruples
            // 
            this.lblCuadruples.AutoSize = true;
            this.lblCuadruples.Location = new System.Drawing.Point(749, 108);
            this.lblCuadruples.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuadruples.Name = "lblCuadruples";
            this.lblCuadruples.Size = new System.Drawing.Size(82, 16);
            this.lblCuadruples.TabIndex = 116;
            this.lblCuadruples.Text = "Cuadruples :";
            this.lblCuadruples.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTriples
            // 
            this.lblTriples.AutoSize = true;
            this.lblTriples.Location = new System.Drawing.Point(633, 111);
            this.lblTriples.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriples.Name = "lblTriples";
            this.lblTriples.Size = new System.Drawing.Size(55, 16);
            this.lblTriples.TabIndex = 114;
            this.lblTriples.Text = "Triples :";
            // 
            // lblDoble
            // 
            this.lblDoble.AutoSize = true;
            this.lblDoble.Location = new System.Drawing.Point(515, 111);
            this.lblDoble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoble.Name = "lblDoble";
            this.lblDoble.Size = new System.Drawing.Size(57, 16);
            this.lblDoble.TabIndex = 112;
            this.lblDoble.Text = "Dobles :";
            // 
            // lblCantidadHabitaciones
            // 
            this.lblCantidadHabitaciones.AutoSize = true;
            this.lblCantidadHabitaciones.Location = new System.Drawing.Point(700, 55);
            this.lblCantidadHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadHabitaciones.Name = "lblCantidadHabitaciones";
            this.lblCantidadHabitaciones.Size = new System.Drawing.Size(93, 32);
            this.lblCantidadHabitaciones.TabIndex = 110;
            this.lblCantidadHabitaciones.Text = "Cantidad de \r\nHabitaciones :\r\n";
            // 
            // npdDisponibilidad
            // 
            this.npdDisponibilidad.Location = new System.Drawing.Point(270, 216);
            this.npdDisponibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdDisponibilidad.Name = "npdDisponibilidad";
            this.npdDisponibilidad.Size = new System.Drawing.Size(61, 22);
            this.npdDisponibilidad.TabIndex = 7;
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(163, 220);
            this.lblDisponibilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(100, 16);
            this.lblDisponibilidad.TabIndex = 106;
            this.lblDisponibilidad.Text = "Disponibilidad :";
            // 
            // npdAsientosCama
            // 
            this.npdAsientosCama.Location = new System.Drawing.Point(965, 228);
            this.npdAsientosCama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdAsientosCama.Name = "npdAsientosCama";
            this.npdAsientosCama.Size = new System.Drawing.Size(47, 22);
            this.npdAsientosCama.TabIndex = 20;
            // 
            // lbbAsientosSemicama
            // 
            this.lbbAsientosSemicama.AutoSize = true;
            this.lbbAsientosSemicama.Location = new System.Drawing.Point(1031, 227);
            this.lbbAsientosSemicama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbAsientosSemicama.Name = "lbbAsientosSemicama";
            this.lbbAsientosSemicama.Size = new System.Drawing.Size(132, 16);
            this.lbbAsientosSemicama.TabIndex = 104;
            this.lbbAsientosSemicama.Text = "Asientos SemiCama:";
            // 
            // npdAsientosSemicama
            // 
            this.npdAsientosSemicama.Location = new System.Drawing.Point(1170, 222);
            this.npdAsientosSemicama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.npdAsientosSemicama.Name = "npdAsientosSemicama";
            this.npdAsientosSemicama.Size = new System.Drawing.Size(47, 22);
            this.npdAsientosSemicama.TabIndex = 21;
            // 
            // lblNombreBus
            // 
            this.lblNombreBus.AutoSize = true;
            this.lblNombreBus.Location = new System.Drawing.Point(395, 172);
            this.lblNombreBus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreBus.Name = "lblNombreBus";
            this.lblNombreBus.Size = new System.Drawing.Size(73, 16);
            this.lblNombreBus.TabIndex = 101;
            this.lblNombreBus.Text = "Transporte";
            // 
            // lblAsientosCama
            // 
            this.lblAsientosCama.AutoSize = true;
            this.lblAsientosCama.Location = new System.Drawing.Point(844, 228);
            this.lblAsientosCama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsientosCama.Name = "lblAsientosCama";
            this.lblAsientosCama.Size = new System.Drawing.Size(104, 16);
            this.lblAsientosCama.TabIndex = 100;
            this.lblAsientosCama.Text = "Asientos Cama :";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(152, 20);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(197, 22);
            this.dtpFechaSalida.TabIndex = 1;
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(51, 17);
            this.lblFechaSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(71, 32);
            this.lblFechaSalida.TabIndex = 97;
            this.lblFechaSalida.Text = "Fecha \r\nde Salida :";
            // 
            // txtPrecioEfectivo
            // 
            this.txtPrecioEfectivo.Location = new System.Drawing.Point(1079, 137);
            this.txtPrecioEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioEfectivo.Name = "txtPrecioEfectivo";
            this.txtPrecioEfectivo.Size = new System.Drawing.Size(197, 22);
            this.txtPrecioEfectivo.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(974, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 87;
            this.label9.Text = "Precio Efectivo";
            // 
            // txtPrecioLista
            // 
            this.txtPrecioLista.Location = new System.Drawing.Point(1079, 105);
            this.txtPrecioLista.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioLista.Name = "txtPrecioLista";
            this.txtPrecioLista.Size = new System.Drawing.Size(197, 22);
            this.txtPrecioLista.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(994, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 85;
            this.label8.Text = "Precio Lista";
            // 
            // txtGastosAdministrativos
            // 
            this.txtGastosAdministrativos.Location = new System.Drawing.Point(1079, 62);
            this.txtGastosAdministrativos.Margin = new System.Windows.Forms.Padding(4);
            this.txtGastosAdministrativos.Name = "txtGastosAdministrativos";
            this.txtGastosAdministrativos.Size = new System.Drawing.Size(197, 22);
            this.txtGastosAdministrativos.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(933, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 83;
            this.label7.Text = "Gast. Administrativos";
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Location = new System.Drawing.Point(379, 224);
            this.lblTransporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(86, 16);
            this.lblTransporte.TabIndex = 79;
            this.lblTransporte.Text = "Tipo de Bus :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 77;
            this.label3.Text = "Régimen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Noches";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(63, 98);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(59, 16);
            this.lblDestino.TabIndex = 71;
            this.lblDestino.Text = "Destino :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Días";
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Location = new System.Drawing.Point(152, 56);
            this.dtpFechaRegreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(197, 22);
            this.dtpFechaRegreso.TabIndex = 2;
            // 
            // lblFechaRegreso
            // 
            this.lblFechaRegreso.AutoSize = true;
            this.lblFechaRegreso.Location = new System.Drawing.Point(40, 52);
            this.lblFechaRegreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaRegreso.Name = "lblFechaRegreso";
            this.lblFechaRegreso.Size = new System.Drawing.Size(82, 32);
            this.lblFechaRegreso.TabIndex = 67;
            this.lblFechaRegreso.Text = "Fecha \r\nde Regreso:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(67, 655);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(199, 47);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(811, 655);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(199, 47);
            this.btnVer.TabIndex = 29;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblCantidadSingle
            // 
            this.lblCantidadSingle.AutoSize = true;
            this.lblCantidadSingle.Location = new System.Drawing.Point(459, 111);
            this.lblCantidadSingle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadSingle.Name = "lblCantidadSingle";
            this.lblCantidadSingle.Size = new System.Drawing.Size(0, 16);
            this.lblCantidadSingle.TabIndex = 128;
            // 
            // lblCantidadDobles
            // 
            this.lblCantidadDobles.AutoSize = true;
            this.lblCantidadDobles.Location = new System.Drawing.Point(577, 111);
            this.lblCantidadDobles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDobles.Name = "lblCantidadDobles";
            this.lblCantidadDobles.Size = new System.Drawing.Size(0, 16);
            this.lblCantidadDobles.TabIndex = 129;
            // 
            // lblCantidadTriples
            // 
            this.lblCantidadTriples.AutoSize = true;
            this.lblCantidadTriples.Location = new System.Drawing.Point(692, 111);
            this.lblCantidadTriples.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadTriples.Name = "lblCantidadTriples";
            this.lblCantidadTriples.Size = new System.Drawing.Size(0, 16);
            this.lblCantidadTriples.TabIndex = 130;
            // 
            // lblCantidadCuadruples
            // 
            this.lblCantidadCuadruples.AutoSize = true;
            this.lblCantidadCuadruples.Location = new System.Drawing.Point(839, 111);
            this.lblCantidadCuadruples.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadCuadruples.Name = "lblCantidadCuadruples";
            this.lblCantidadCuadruples.Size = new System.Drawing.Size(0, 16);
            this.lblCantidadCuadruples.TabIndex = 131;
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Location = new System.Drawing.Point(812, 62);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(0, 16);
            this.lblHabitaciones.TabIndex = 132;
            // 
            // FrmIngresarEditarPaquetes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 767);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvPaquetes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmIngresarEditarPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIngresarEditarPaquetes";
            this.Load += new System.EventHandler(this.FrmIngresarEditarPaquetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadAsientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidadNoches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdCantidasDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdDisponibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosCama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdAsientosSemicama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblSingle;
        private System.Windows.Forms.NumericUpDown npdCantidadNoches;
        private System.Windows.Forms.NumericUpDown npdCantidasDias;
        private System.Windows.Forms.Label lblCuadruples;
        private System.Windows.Forms.Label lblTriples;
        private System.Windows.Forms.Label lblDoble;
        private System.Windows.Forms.Label lblCantidadHabitaciones;
        private System.Windows.Forms.NumericUpDown npdDisponibilidad;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.NumericUpDown npdAsientosCama;
        private System.Windows.Forms.Label lbbAsientosSemicama;
        private System.Windows.Forms.NumericUpDown npdAsientosSemicama;
        private System.Windows.Forms.Label lblNombreBus;
        private System.Windows.Forms.Label lblAsientosCama;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.TextBox txtPrecioEfectivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioLista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGastosAdministrativos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.Label lblFechaRegreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCoste;
        private System.Windows.Forms.NumericUpDown npdCantidadAsientos;
        private System.Windows.Forms.Label lblCantidadAsientos;
        private System.Windows.Forms.Button btnBuscarHotel;
        private System.Windows.Forms.Button btnBuscarBus;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAgregarDestino;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.ComboBox cmbRegimen;
        private System.Windows.Forms.ComboBox cmbTipoBus;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblCantidadSingle;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblCantidadCuadruples;
        private System.Windows.Forms.Label lblCantidadTriples;
        private System.Windows.Forms.Label lblCantidadDobles;
    }
}