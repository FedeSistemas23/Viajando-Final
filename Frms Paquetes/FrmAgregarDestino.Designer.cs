namespace interfazPpal
{
    partial class FrmAgregarDestino
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
            this.lblNombreDelDestino = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvDestinos = new System.Windows.Forms.DataGridView();
            this.lblIdentifcador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreDelDestino
            // 
            this.lblNombreDelDestino.AutoSize = true;
            this.lblNombreDelDestino.Location = new System.Drawing.Point(333, 94);
            this.lblNombreDelDestino.Name = "lblNombreDelDestino";
            this.lblNombreDelDestino.Size = new System.Drawing.Size(130, 16);
            this.lblNombreDelDestino.TabIndex = 0;
            this.lblNombreDelDestino.Text = "Nombre del Destino:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(393, 142);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(310, 186);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(153, 16);
            this.lblPartido.TabIndex = 2;
            this.lblPartido.Text = "Partido o Departamento:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(397, 224);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(66, 16);
            this.lblProvincia.TabIndex = 3;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(507, 94);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(230, 22);
            this.txtDestino.TabIndex = 1;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(507, 139);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(230, 22);
            this.txtLocalidad.TabIndex = 2;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(507, 224);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(230, 22);
            this.txtProvincia.TabIndex = 4;
            // 
            // txtPartido
            // 
            this.txtPartido.Location = new System.Drawing.Point(507, 183);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(230, 22);
            this.txtPartido.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(235, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(178, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(655, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 50);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(454, 282);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(174, 50);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvDestinos
            // 
            this.dgvDestinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinos.Location = new System.Drawing.Point(211, 352);
            this.dgvDestinos.MultiSelect = false;
            this.dgvDestinos.Name = "dgvDestinos";
            this.dgvDestinos.ReadOnly = true;
            this.dgvDestinos.RowHeadersWidth = 51;
            this.dgvDestinos.RowTemplate.Height = 24;
            this.dgvDestinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinos.Size = new System.Drawing.Size(630, 248);
            this.dgvDestinos.TabIndex = 8;
            this.dgvDestinos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinos_CellContentDoubleClick);
            // 
            // lblIdentifcador
            // 
            this.lblIdentifcador.AutoSize = true;
            this.lblIdentifcador.Location = new System.Drawing.Point(377, 53);
            this.lblIdentifcador.Name = "lblIdentifcador";
            this.lblIdentifcador.Size = new System.Drawing.Size(86, 16);
            this.lblIdentifcador.TabIndex = 9;
            this.lblIdentifcador.Text = "Identificador: ";
            // 
            // FrmAgregarDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1063, 649);
            this.Controls.Add(this.lblIdentifcador);
            this.Controls.Add(this.dgvDestinos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblNombreDelDestino);
            this.Name = "FrmAgregarDestino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAgregarDestino";
            this.Load += new System.EventHandler(this.FrmAgregarDestino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreDelDestino;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvDestinos;
        private System.Windows.Forms.Label lblIdentifcador;
    }
}