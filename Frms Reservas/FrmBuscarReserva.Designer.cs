namespace Loggin
{
    partial class FrmBuscarReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBuscarReserva = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbNumRerva = new System.Windows.Forms.CheckBox();
            this.ckbDestino = new System.Windows.Forms.CheckBox();
            this.ckbFechaReserva = new System.Windows.Forms.CheckBox();
            this.ckbFechaSalida = new System.Windows.Forms.CheckBox();
            this.ckbFechaRegreso = new System.Windows.Forms.CheckBox();
            this.ckbNombre = new System.Windows.Forms.CheckBox();
            this.ckbApellido = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarReserva)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Location = new System.Drawing.Point(737, 52);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(134, 20);
            this.dtpFechaRegreso.TabIndex = 49;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(8, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 35);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasta";
            // 
            // dgvBuscarReserva
            // 
            this.dgvBuscarReserva.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBuscarReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarReserva.Location = new System.Drawing.Point(12, 241);
            this.dgvBuscarReserva.Name = "dgvBuscarReserva";
            this.dgvBuscarReserva.RowHeadersWidth = 51;
            this.dgvBuscarReserva.Size = new System.Drawing.Size(1067, 412);
            this.dgvBuscarReserva.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(102, 165);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 35);
            this.btnEditar.TabIndex = 50;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(196, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 35);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(313, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 20);
            this.txtApellido.TabIndex = 62;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(262, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "Apellido";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Cancelada",
            "Pendiente",
            "Abierta"});
            this.cmbEstado.Location = new System.Drawing.Point(546, 49);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(138, 21);
            this.cmbEstado.TabIndex = 65;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(455, 54);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 64;
            this.lblEstado.Text = "Estado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(313, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 63;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(219, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Nombre Pasajero";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(97, 49);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(110, 20);
            this.txtDestino.TabIndex = 59;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Destino";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Location = new System.Drawing.Point(97, 19);
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.Size = new System.Drawing.Size(110, 20);
            this.txtNumReserva.TabIndex = 57;
            this.txtNumReserva.TextChanged += new System.EventHandler(this.txtNumReserva_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Numero Reserva";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(737, 19);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(138, 20);
            this.dtpFechaSalida.TabIndex = 67;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(690, 23);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 66;
            this.lblDesde.Text = "Desde";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(290, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 35);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(545, 20);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(138, 20);
            this.dtpFechaReserva.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Fecha Reserva";
            // 
            // ckbNumRerva
            // 
            this.ckbNumRerva.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbNumRerva.AutoSize = true;
            this.ckbNumRerva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbNumRerva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNumRerva.Location = new System.Drawing.Point(126, 8);
            this.ckbNumRerva.Name = "ckbNumRerva";
            this.ckbNumRerva.Size = new System.Drawing.Size(82, 26);
            this.ckbNumRerva.TabIndex = 71;
            this.ckbNumRerva.Text = "N° Reseva";
            this.ckbNumRerva.UseVisualStyleBackColor = true;
            this.ckbNumRerva.CheckedChanged += new System.EventHandler(this.ckbNumRerva_CheckedChanged);
            // 
            // ckbDestino
            // 
            this.ckbDestino.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbDestino.AutoSize = true;
            this.ckbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDestino.Location = new System.Drawing.Point(471, 8);
            this.ckbDestino.Name = "ckbDestino";
            this.ckbDestino.Size = new System.Drawing.Size(63, 26);
            this.ckbDestino.TabIndex = 72;
            this.ckbDestino.Text = "Destino";
            this.ckbDestino.UseVisualStyleBackColor = true;
            this.ckbDestino.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckbFechaReserva
            // 
            this.ckbFechaReserva.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbFechaReserva.AutoSize = true;
            this.ckbFechaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbFechaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFechaReserva.Location = new System.Drawing.Point(355, 8);
            this.ckbFechaReserva.Name = "ckbFechaReserva";
            this.ckbFechaReserva.Size = new System.Drawing.Size(110, 26);
            this.ckbFechaReserva.TabIndex = 73;
            this.ckbFechaReserva.Text = "Fecha Reserva";
            this.ckbFechaReserva.UseVisualStyleBackColor = true;
            this.ckbFechaReserva.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ckbFechaSalida
            // 
            this.ckbFechaSalida.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbFechaSalida.AutoSize = true;
            this.ckbFechaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFechaSalida.Location = new System.Drawing.Point(541, 8);
            this.ckbFechaSalida.Name = "ckbFechaSalida";
            this.ckbFechaSalida.Size = new System.Drawing.Size(100, 26);
            this.ckbFechaSalida.TabIndex = 74;
            this.ckbFechaSalida.Text = "Fecha  Salida";
            this.ckbFechaSalida.UseVisualStyleBackColor = true;
            this.ckbFechaSalida.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ckbFechaRegreso
            // 
            this.ckbFechaRegreso.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbFechaRegreso.AutoSize = true;
            this.ckbFechaRegreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbFechaRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFechaRegreso.Location = new System.Drawing.Point(647, 8);
            this.ckbFechaRegreso.Name = "ckbFechaRegreso";
            this.ckbFechaRegreso.Size = new System.Drawing.Size(111, 26);
            this.ckbFechaRegreso.TabIndex = 75;
            this.ckbFechaRegreso.Text = "Fecha Regreso";
            this.ckbFechaRegreso.UseVisualStyleBackColor = true;
            this.ckbFechaRegreso.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // ckbNombre
            // 
            this.ckbNombre.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbNombre.AutoSize = true;
            this.ckbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNombre.Location = new System.Drawing.Point(214, 8);
            this.ckbNombre.Name = "ckbNombre";
            this.ckbNombre.Size = new System.Drawing.Size(66, 26);
            this.ckbNombre.TabIndex = 76;
            this.ckbNombre.Text = "Nombre";
            this.ckbNombre.UseVisualStyleBackColor = true;
            this.ckbNombre.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // ckbApellido
            // 
            this.ckbApellido.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbApellido.AutoSize = true;
            this.ckbApellido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbApellido.Location = new System.Drawing.Point(285, 8);
            this.ckbApellido.Name = "ckbApellido";
            this.ckbApellido.Size = new System.Drawing.Size(67, 26);
            this.ckbApellido.TabIndex = 77;
            this.ckbApellido.Text = "Apellido";
            this.ckbApellido.UseVisualStyleBackColor = true;
            this.ckbApellido.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 207);
            this.panel1.TabIndex = 78;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblDesde);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.dtpFechaRegreso);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNumReserva);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.cmbEstado);
            this.panel3.Controls.Add(this.dtpFechaReserva);
            this.panel3.Controls.Add(this.txtApellido);
            this.panel3.Controls.Add(this.lblEstado);
            this.panel3.Controls.Add(this.dtpFechaSalida);
            this.panel3.Controls.Add(this.txtDestino);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 97);
            this.panel3.TabIndex = 79;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ckbFechaReserva);
            this.panel2.Controls.Add(this.ckbDestino);
            this.panel2.Controls.Add(this.ckbApellido);
            this.panel2.Controls.Add(this.ckbNumRerva);
            this.panel2.Controls.Add(this.ckbFechaSalida);
            this.panel2.Controls.Add(this.ckbFechaRegreso);
            this.panel2.Controls.Add(this.ckbNombre);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 49);
            this.panel2.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Buscar Por:";
            // 
            // BuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBuscarReserva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BuscarReserva";
            this.Text = "BuscarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarReserva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.DataGridView dgvBuscarReserva;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbNumRerva;
        private System.Windows.Forms.CheckBox ckbDestino;
        private System.Windows.Forms.CheckBox ckbFechaReserva;
        private System.Windows.Forms.CheckBox ckbFechaSalida;
        private System.Windows.Forms.CheckBox ckbFechaRegreso;
        private System.Windows.Forms.CheckBox ckbNombre;
        private System.Windows.Forms.CheckBox ckbApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
    }
}