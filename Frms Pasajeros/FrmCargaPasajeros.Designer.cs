namespace interfazPpal
{
    partial class FrmCargaPasajeros
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
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NroPasajero = new System.Windows.Forms.Label();
            this.lblNroPasajero = new System.Windows.Forms.Label();
            this.btnAscenso = new System.Windows.Forms.Button();
            this.cmbAscenso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgragarObraSocial = new System.Windows.Forms.Button();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblNroReserva = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNroReserva = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.ckbTieneObraSocial = new System.Windows.Forms.CheckBox();
            this.ckbEsMenor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombrePax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Location = new System.Drawing.Point(27, 544);
            this.dgvPasajeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.RowHeadersWidth = 51;
            this.dgvPasajeros.RowTemplate.Height = 24;
            this.dgvPasajeros.Size = new System.Drawing.Size(1359, 208);
            this.dgvPasajeros.TabIndex = 26;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(29, 491);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 47);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(509, 491);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 47);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(189, 491);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 47);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(349, 491);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 47);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NroPasajero);
            this.groupBox2.Controls.Add(this.lblNroPasajero);
            this.groupBox2.Controls.Add(this.btnAscenso);
            this.groupBox2.Controls.Add(this.cmbAscenso);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAgragarObraSocial);
            this.groupBox2.Controls.Add(this.cmbObraSocial);
            this.groupBox2.Controls.Add(this.lblCalle);
            this.groupBox2.Controls.Add(this.txtCalle);
            this.groupBox2.Controls.Add(this.lblNroReserva);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtNroReserva);
            this.groupBox2.Controls.Add(this.lblProvincia);
            this.groupBox2.Controls.Add(this.txtProvincia);
            this.groupBox2.Controls.Add(this.lblPartido);
            this.groupBox2.Controls.Add(this.txtPartido);
            this.groupBox2.Controls.Add(this.lblLocalidad);
            this.groupBox2.Controls.Add(this.txtLocalidad);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.btnBuscarReserva);
            this.groupBox2.Controls.Add(this.lblSeguro);
            this.groupBox2.Controls.Add(this.ckbTieneObraSocial);
            this.groupBox2.Controls.Add(this.ckbEsMenor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNacionalidad);
            this.groupBox2.Controls.Add(this.cmbTipoDoc);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.txtNumDoc);
            this.groupBox2.Controls.Add(this.FechaNacimiento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNombrePax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(47, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1295, 436);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Datos Pasajero";
            // 
            // NroPasajero
            // 
            this.NroPasajero.AutoSize = true;
            this.NroPasajero.Location = new System.Drawing.Point(256, 130);
            this.NroPasajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NroPasajero.Name = "NroPasajero";
            this.NroPasajero.Size = new System.Drawing.Size(26, 16);
            this.NroPasajero.TabIndex = 102;
            this.NroPasajero.Text = "nro";
            // 
            // lblNroPasajero
            // 
            this.lblNroPasajero.AutoSize = true;
            this.lblNroPasajero.Location = new System.Drawing.Point(91, 130);
            this.lblNroPasajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroPasajero.Name = "lblNroPasajero";
            this.lblNroPasajero.Size = new System.Drawing.Size(81, 16);
            this.lblNroPasajero.TabIndex = 101;
            this.lblNroPasajero.Text = "nroPasajero";
            // 
            // btnAscenso
            // 
            this.btnAscenso.AutoSize = true;
            this.btnAscenso.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAscenso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscenso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscenso.ForeColor = System.Drawing.Color.White;
            this.btnAscenso.Location = new System.Drawing.Point(814, 216);
            this.btnAscenso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAscenso.Name = "btnAscenso";
            this.btnAscenso.Size = new System.Drawing.Size(191, 42);
            this.btnAscenso.TabIndex = 20;
            this.btnAscenso.Text = "Agregar Ascenso";
            this.btnAscenso.UseVisualStyleBackColor = false;
            // 
            // cmbAscenso
            // 
            this.cmbAscenso.FormattingEnabled = true;
            this.cmbAscenso.Items.AddRange(new object[] {
            "Seleccione Tipo",
            "D.N.I",
            "Pasaporte",
            "Cuil",
            "Cuit",
            "Cedula Identidad"});
            this.cmbAscenso.Location = new System.Drawing.Point(796, 184);
            this.cmbAscenso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAscenso.Name = "cmbAscenso";
            this.cmbAscenso.Size = new System.Drawing.Size(232, 24);
            this.cmbAscenso.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(840, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "Ascenso:";
            // 
            // btnAgragarObraSocial
            // 
            this.btnAgragarObraSocial.AutoSize = true;
            this.btnAgragarObraSocial.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAgragarObraSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragarObraSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragarObraSocial.ForeColor = System.Drawing.Color.White;
            this.btnAgragarObraSocial.Location = new System.Drawing.Point(645, 380);
            this.btnAgragarObraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgragarObraSocial.Name = "btnAgragarObraSocial";
            this.btnAgragarObraSocial.Size = new System.Drawing.Size(228, 42);
            this.btnAgragarObraSocial.TabIndex = 21;
            this.btnAgragarObraSocial.Text = "Agregar Obra Social";
            this.btnAgragarObraSocial.UseVisualStyleBackColor = false;
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Items.AddRange(new object[] {
            "Seleccione Tipo",
            "D.N.I",
            "Pasaporte",
            "Cuil",
            "Cuit",
            "Cedula Identidad"});
            this.cmbObraSocial.Location = new System.Drawing.Point(740, 348);
            this.cmbObraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(265, 24);
            this.cmbObraSocial.TabIndex = 18;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(416, 159);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(38, 16);
            this.lblCalle.TabIndex = 99;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(480, 159);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(265, 22);
            this.txtCalle.TabIndex = 11;
            // 
            // lblNroReserva
            // 
            this.lblNroReserva.AutoSize = true;
            this.lblNroReserva.Location = new System.Drawing.Point(459, 75);
            this.lblNroReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroReserva.Name = "lblNroReserva";
            this.lblNroReserva.Size = new System.Drawing.Size(81, 16);
            this.lblNroReserva.TabIndex = 97;
            this.lblNroReserva.Text = "NroReserva";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 160);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 95;
            this.label14.Text = "NroReserva";
            // 
            // txtNroReserva
            // 
            this.txtNroReserva.Location = new System.Drawing.Point(159, 156);
            this.txtNroReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroReserva.Name = "txtNroReserva";
            this.txtNroReserva.Size = new System.Drawing.Size(232, 22);
            this.txtNroReserva.TabIndex = 2;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(416, 297);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(66, 16);
            this.lblProvincia.TabIndex = 92;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(480, 293);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(265, 22);
            this.txtProvincia.TabIndex = 15;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(416, 255);
            this.lblPartido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(53, 16);
            this.lblPartido.TabIndex = 90;
            this.lblPartido.Text = "Partido:";
            // 
            // txtPartido
            // 
            this.txtPartido.Location = new System.Drawing.Point(480, 255);
            this.txtPartido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(265, 22);
            this.txtPartido.TabIndex = 14;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(416, 224);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidad.TabIndex = 88;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(480, 224);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(265, 22);
            this.txtLocalidad.TabIndex = 13;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(416, 192);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 16);
            this.lblNumero.TabIndex = 86;
            this.lblNumero.Text = "Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(480, 189);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(265, 22);
            this.txtNumero.TabIndex = 12;
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Location = new System.Drawing.Point(297, 65);
            this.btnBuscarReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(149, 36);
            this.btnBuscarReserva.TabIndex = 1;
            this.btnBuscarReserva.Text = "Buscar Reserva";
            this.btnBuscarReserva.UseVisualStyleBackColor = true;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(602, 353);
            this.lblSeguro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(130, 16);
            this.lblSeguro.TabIndex = 71;
            this.lblSeguro.Text = "Nombre Obra Social";
            // 
            // ckbTieneObraSocial
            // 
            this.ckbTieneObraSocial.AutoSize = true;
            this.ckbTieneObraSocial.Location = new System.Drawing.Point(480, 353);
            this.ckbTieneObraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.ckbTieneObraSocial.Name = "ckbTieneObraSocial";
            this.ckbTieneObraSocial.Size = new System.Drawing.Size(100, 20);
            this.ckbTieneObraSocial.TabIndex = 17;
            this.ckbTieneObraSocial.Text = "Obra Social";
            this.ckbTieneObraSocial.UseVisualStyleBackColor = true;
            // 
            // ckbEsMenor
            // 
            this.ckbEsMenor.AutoSize = true;
            this.ckbEsMenor.Location = new System.Drawing.Point(480, 325);
            this.ckbEsMenor.Margin = new System.Windows.Forms.Padding(4);
            this.ckbEsMenor.Name = "ckbEsMenor";
            this.ckbEsMenor.Size = new System.Drawing.Size(110, 20);
            this.ckbEsMenor.TabIndex = 16;
            this.ckbEsMenor.Text = "Menor 3 años";
            this.ckbEsMenor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(159, 380);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(232, 22);
            this.txtNacionalidad.TabIndex = 9;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "Seleccione Tipo",
            "D.N.I",
            "Pasaporte",
            "Cuil",
            "Cuit",
            "Cedula Identidad"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(159, 251);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(232, 24);
            this.cmbTipoDoc.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(160, 220);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(232, 22);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(160, 284);
            this.txtNumDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(232, 22);
            this.txtNumDoc.TabIndex = 6;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Location = new System.Drawing.Point(160, 318);
            this.FechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(232, 22);
            this.FechaNacimiento.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Número Documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Apellido";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 348);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(232, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 353);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Télefono";
            // 
            // txtNombrePax
            // 
            this.txtNombrePax.Location = new System.Drawing.Point(160, 188);
            this.txtNombrePax.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePax.Name = "txtNombrePax";
            this.txtNombrePax.Size = new System.Drawing.Size(232, 22);
            this.txtNombrePax.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tipo documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre Pasajero";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 411);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 320);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Fecha Nacimiento";
            // 
            // FrmCargaPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 786);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvPasajeros);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCargaPasajeros";
            this.Text = "CargaPasajeros";
            this.Load += new System.EventHandler(this.FrmCargaPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasajeros;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNroReserva;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.CheckBox ckbTieneObraSocial;
        private System.Windows.Forms.CheckBox ckbEsMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.DateTimePicker FechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombrePax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNroReserva;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.ComboBox cmbObraSocial;
        private System.Windows.Forms.Button btnAgragarObraSocial;
        private System.Windows.Forms.Button btnAscenso;
        private System.Windows.Forms.ComboBox cmbAscenso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NroPasajero;
        private System.Windows.Forms.Label lblNroPasajero;
    }
}