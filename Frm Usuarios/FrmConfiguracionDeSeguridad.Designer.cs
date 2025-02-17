namespace interfazPpal
{
    partial class FrmConfiguracionDeSeguridad
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chbDatosPersonales = new System.Windows.Forms.CheckBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.npdBloqueadoPorDias = new System.Windows.Forms.NumericUpDown();
            this.lblBloqueadoPor = new System.Windows.Forms.Label();
            this.npdVenceCada = new System.Windows.Forms.NumericUpDown();
            this.ckbRealizarPreguntasSeguridad = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.npdIntentos = new System.Windows.Forms.NumericUpDown();
            this.ckbAvisarVencimiento = new System.Windows.Forms.CheckBox();
            this.ckbMinimo = new System.Windows.Forms.CheckBox();
            this.ckbEspecial = new System.Windows.Forms.CheckBox();
            this.ckbNumero = new System.Windows.Forms.CheckBox();
            this.ckbMayuscula = new System.Windows.Forms.CheckBox();
            this.ckbMinuscula = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.npdHorasDeBloqueo = new System.Windows.Forms.NumericUpDown();
            this.ckbAutenticacion2FA = new System.Windows.Forms.CheckBox();
            this.chbDesbloqueoAuto = new System.Windows.Forms.CheckBox();
            this.chbContraseñasAnteriores = new System.Windows.Forms.CheckBox();
            this.chbBloqueado = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarPreguntas = new System.Windows.Forms.Button();
            this.cmbFamilias = new System.Windows.Forms.ComboBox();
            this.lblFamilias = new System.Windows.Forms.Label();
            this.btnAgregarFamilia = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.txtPermisos = new System.Windows.Forms.TextBox();
            this.btnAgregarPermisos = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdBloqueadoPorDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdVenceCada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdIntentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdHorasDeBloqueo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbDatosPersonales);
            this.groupBox3.Controls.Add(this.lblDias);
            this.groupBox3.Controls.Add(this.npdBloqueadoPorDias);
            this.groupBox3.Controls.Add(this.lblBloqueadoPor);
            this.groupBox3.Controls.Add(this.npdVenceCada);
            this.groupBox3.Controls.Add(this.ckbRealizarPreguntasSeguridad);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.npdIntentos);
            this.groupBox3.Controls.Add(this.ckbAvisarVencimiento);
            this.groupBox3.Controls.Add(this.ckbMinimo);
            this.groupBox3.Controls.Add(this.ckbEspecial);
            this.groupBox3.Controls.Add(this.ckbNumero);
            this.groupBox3.Controls.Add(this.ckbMayuscula);
            this.groupBox3.Controls.Add(this.ckbMinuscula);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.npdHorasDeBloqueo);
            this.groupBox3.Controls.Add(this.ckbAutenticacion2FA);
            this.groupBox3.Controls.Add(this.chbDesbloqueoAuto);
            this.groupBox3.Controls.Add(this.chbContraseñasAnteriores);
            this.groupBox3.Controls.Add(this.chbBloqueado);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(498, 445);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seguridad y Contraseña";
            // 
            // chbDatosPersonales
            // 
            this.chbDatosPersonales.AutoSize = true;
            this.chbDatosPersonales.Location = new System.Drawing.Point(8, 408);
            this.chbDatosPersonales.Margin = new System.Windows.Forms.Padding(4);
            this.chbDatosPersonales.Name = "chbDatosPersonales";
            this.chbDatosPersonales.Size = new System.Drawing.Size(194, 20);
            this.chbDatosPersonales.TabIndex = 51;
            this.chbDatosPersonales.Text = "Contener Datos Personales";
            this.chbDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(346, 352);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(36, 16);
            this.lblDias.TabIndex = 50;
            this.lblDias.Text = "dias.";
            // 
            // npdBloqueadoPorDias
            // 
            this.npdBloqueadoPorDias.Location = new System.Drawing.Point(280, 346);
            this.npdBloqueadoPorDias.Margin = new System.Windows.Forms.Padding(4);
            this.npdBloqueadoPorDias.Name = "npdBloqueadoPorDias";
            this.npdBloqueadoPorDias.Size = new System.Drawing.Size(43, 22);
            this.npdBloqueadoPorDias.TabIndex = 35;
            // 
            // lblBloqueadoPor
            // 
            this.lblBloqueadoPor.AutoSize = true;
            this.lblBloqueadoPor.Location = new System.Drawing.Point(162, 352);
            this.lblBloqueadoPor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloqueadoPor.Name = "lblBloqueadoPor";
            this.lblBloqueadoPor.Size = new System.Drawing.Size(100, 16);
            this.lblBloqueadoPor.TabIndex = 30;
            this.lblBloqueadoPor.Text = "Bloqueado por:";
            // 
            // npdVenceCada
            // 
            this.npdVenceCada.Location = new System.Drawing.Point(80, 66);
            this.npdVenceCada.Margin = new System.Windows.Forms.Padding(4);
            this.npdVenceCada.Name = "npdVenceCada";
            this.npdVenceCada.Size = new System.Drawing.Size(45, 22);
            this.npdVenceCada.TabIndex = 23;
            // 
            // ckbRealizarPreguntasSeguridad
            // 
            this.ckbRealizarPreguntasSeguridad.AutoSize = true;
            this.ckbRealizarPreguntasSeguridad.Location = new System.Drawing.Point(8, 296);
            this.ckbRealizarPreguntasSeguridad.Margin = new System.Windows.Forms.Padding(4);
            this.ckbRealizarPreguntasSeguridad.Name = "ckbRealizarPreguntasSeguridad";
            this.ckbRealizarPreguntasSeguridad.Size = new System.Drawing.Size(228, 20);
            this.ckbRealizarPreguntasSeguridad.TabIndex = 32;
            this.ckbRealizarPreguntasSeguridad.Text = "Realizar Preguntas de Seguridad";
            this.ckbRealizarPreguntasSeguridad.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 33);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 16);
            this.label20.TabIndex = 48;
            this.label20.Text = "Intentos Fallidos";
            // 
            // npdIntentos
            // 
            this.npdIntentos.Location = new System.Drawing.Point(127, 27);
            this.npdIntentos.Margin = new System.Windows.Forms.Padding(4);
            this.npdIntentos.Name = "npdIntentos";
            this.npdIntentos.Size = new System.Drawing.Size(55, 22);
            this.npdIntentos.TabIndex = 25;
            // 
            // ckbAvisarVencimiento
            // 
            this.ckbAvisarVencimiento.AutoSize = true;
            this.ckbAvisarVencimiento.Location = new System.Drawing.Point(8, 100);
            this.ckbAvisarVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.ckbAvisarVencimiento.Name = "ckbAvisarVencimiento";
            this.ckbAvisarVencimiento.Size = new System.Drawing.Size(235, 20);
            this.ckbAvisarVencimiento.TabIndex = 24;
            this.ckbAvisarVencimiento.Text = "Avisar Vencimiento de Contraseña";
            this.ckbAvisarVencimiento.UseVisualStyleBackColor = true;
            // 
            // ckbMinimo
            // 
            this.ckbMinimo.AutoSize = true;
            this.ckbMinimo.Location = new System.Drawing.Point(8, 240);
            this.ckbMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMinimo.Name = "ckbMinimo";
            this.ckbMinimo.Size = new System.Drawing.Size(156, 20);
            this.ckbMinimo.TabIndex = 31;
            this.ckbMinimo.Text = "8 caracteres Mínimos";
            this.ckbMinimo.UseVisualStyleBackColor = true;
            // 
            // ckbEspecial
            // 
            this.ckbEspecial.AutoSize = true;
            this.ckbEspecial.Location = new System.Drawing.Point(8, 268);
            this.ckbEspecial.Margin = new System.Windows.Forms.Padding(4);
            this.ckbEspecial.Name = "ckbEspecial";
            this.ckbEspecial.Size = new System.Drawing.Size(146, 20);
            this.ckbEspecial.TabIndex = 30;
            this.ckbEspecial.Text = "1 Caracter Especial";
            this.ckbEspecial.UseVisualStyleBackColor = true;
            // 
            // ckbNumero
            // 
            this.ckbNumero.AutoSize = true;
            this.ckbNumero.Location = new System.Drawing.Point(8, 212);
            this.ckbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.ckbNumero.Name = "ckbNumero";
            this.ckbNumero.Size = new System.Drawing.Size(87, 20);
            this.ckbNumero.TabIndex = 29;
            this.ckbNumero.Text = "1 Número";
            this.ckbNumero.UseVisualStyleBackColor = true;
            // 
            // ckbMayuscula
            // 
            this.ckbMayuscula.AutoSize = true;
            this.ckbMayuscula.Location = new System.Drawing.Point(8, 156);
            this.ckbMayuscula.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMayuscula.Name = "ckbMayuscula";
            this.ckbMayuscula.Size = new System.Drawing.Size(104, 20);
            this.ckbMayuscula.TabIndex = 28;
            this.ckbMayuscula.Text = "1 Mayúscula";
            this.ckbMayuscula.UseVisualStyleBackColor = true;
            // 
            // ckbMinuscula
            // 
            this.ckbMinuscula.AutoSize = true;
            this.ckbMinuscula.Location = new System.Drawing.Point(8, 184);
            this.ckbMinuscula.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMinuscula.Name = "ckbMinuscula";
            this.ckbMinuscula.Size = new System.Drawing.Size(99, 20);
            this.ckbMinuscula.TabIndex = 27;
            this.ckbMinuscula.Text = "1 Minúscula";
            this.ckbMinuscula.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(190, 384);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Cantidad Horas";
            // 
            // npdHorasDeBloqueo
            // 
            this.npdHorasDeBloqueo.Location = new System.Drawing.Point(299, 382);
            this.npdHorasDeBloqueo.Margin = new System.Windows.Forms.Padding(4);
            this.npdHorasDeBloqueo.Name = "npdHorasDeBloqueo";
            this.npdHorasDeBloqueo.Size = new System.Drawing.Size(46, 22);
            this.npdHorasDeBloqueo.TabIndex = 37;
            // 
            // ckbAutenticacion2FA
            // 
            this.ckbAutenticacion2FA.AutoSize = true;
            this.ckbAutenticacion2FA.Location = new System.Drawing.Point(8, 324);
            this.ckbAutenticacion2FA.Margin = new System.Windows.Forms.Padding(4);
            this.ckbAutenticacion2FA.Name = "ckbAutenticacion2FA";
            this.ckbAutenticacion2FA.Size = new System.Drawing.Size(145, 20);
            this.ckbAutenticacion2FA.TabIndex = 33;
            this.ckbAutenticacion2FA.Text = "Autentificacion 2 FA";
            this.ckbAutenticacion2FA.UseVisualStyleBackColor = true;
            // 
            // chbDesbloqueoAuto
            // 
            this.chbDesbloqueoAuto.AutoSize = true;
            this.chbDesbloqueoAuto.Location = new System.Drawing.Point(8, 380);
            this.chbDesbloqueoAuto.Margin = new System.Windows.Forms.Padding(4);
            this.chbDesbloqueoAuto.Name = "chbDesbloqueoAuto";
            this.chbDesbloqueoAuto.Size = new System.Drawing.Size(174, 20);
            this.chbDesbloqueoAuto.TabIndex = 35;
            this.chbDesbloqueoAuto.Text = "Desbloqueo Automático";
            this.chbDesbloqueoAuto.UseVisualStyleBackColor = true;
            // 
            // chbContraseñasAnteriores
            // 
            this.chbContraseñasAnteriores.AutoSize = true;
            this.chbContraseñasAnteriores.Location = new System.Drawing.Point(8, 128);
            this.chbContraseñasAnteriores.Margin = new System.Windows.Forms.Padding(4);
            this.chbContraseñasAnteriores.Name = "chbContraseñasAnteriores";
            this.chbContraseñasAnteriores.Size = new System.Drawing.Size(217, 20);
            this.chbContraseñasAnteriores.TabIndex = 26;
            this.chbContraseñasAnteriores.Text = "Permitir Contraseñas Anteriores";
            this.chbContraseñasAnteriores.UseVisualStyleBackColor = true;
            // 
            // chbBloqueado
            // 
            this.chbBloqueado.AutoSize = true;
            this.chbBloqueado.Location = new System.Drawing.Point(8, 352);
            this.chbBloqueado.Margin = new System.Windows.Forms.Padding(4);
            this.chbBloqueado.Name = "chbBloqueado";
            this.chbBloqueado.Size = new System.Drawing.Size(134, 20);
            this.chbBloqueado.TabIndex = 34;
            this.chbBloqueado.Text = "Bloquear Usuario";
            this.chbBloqueado.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "Vence en ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(537, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 148);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnAgregarPreguntas
            // 
            this.btnAgregarPreguntas.AutoSize = true;
            this.btnAgregarPreguntas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPreguntas.Location = new System.Drawing.Point(1106, 61);
            this.btnAgregarPreguntas.Name = "btnAgregarPreguntas";
            this.btnAgregarPreguntas.Size = new System.Drawing.Size(217, 26);
            this.btnAgregarPreguntas.TabIndex = 25;
            this.btnAgregarPreguntas.Text = "Agregar Preguntas De Seguridad";
            this.btnAgregarPreguntas.UseVisualStyleBackColor = true;
            // 
            // cmbFamilias
            // 
            this.cmbFamilias.FormattingEnabled = true;
            this.cmbFamilias.Location = new System.Drawing.Point(797, 201);
            this.cmbFamilias.Name = "cmbFamilias";
            this.cmbFamilias.Size = new System.Drawing.Size(159, 24);
            this.cmbFamilias.TabIndex = 26;
            // 
            // lblFamilias
            // 
            this.lblFamilias.AutoSize = true;
            this.lblFamilias.Location = new System.Drawing.Point(713, 201);
            this.lblFamilias.Name = "lblFamilias";
            this.lblFamilias.Size = new System.Drawing.Size(64, 16);
            this.lblFamilias.TabIndex = 27;
            this.lblFamilias.Text = "Familias: ";
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.AutoSize = true;
            this.btnAgregarFamilia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarFamilia.Location = new System.Drawing.Point(972, 196);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(113, 26);
            this.btnAgregarFamilia.TabIndex = 28;
            this.btnAgregarFamilia.Text = "Agregar Familia";
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(537, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(383, 391);
            this.dataGridView2.TabIndex = 29;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(972, 293);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(383, 391);
            this.dataGridView3.TabIndex = 30;
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(713, 253);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(67, 16);
            this.lblPermisos.TabIndex = 31;
            this.lblPermisos.Text = "Permisos:";
            // 
            // txtPermisos
            // 
            this.txtPermisos.Location = new System.Drawing.Point(797, 246);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(288, 22);
            this.txtPermisos.TabIndex = 32;
            // 
            // btnAgregarPermisos
            // 
            this.btnAgregarPermisos.AutoSize = true;
            this.btnAgregarPermisos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPermisos.Location = new System.Drawing.Point(1106, 242);
            this.btnAgregarPermisos.Name = "btnAgregarPermisos";
            this.btnAgregarPermisos.Size = new System.Drawing.Size(126, 26);
            this.btnAgregarPermisos.TabIndex = 33;
            this.btnAgregarPermisos.Text = "Agregar Permisos";
            this.btnAgregarPermisos.UseVisualStyleBackColor = true;
            // 
            // FrmConfiguracionDeSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 713);
            this.Controls.Add(this.btnAgregarPermisos);
            this.Controls.Add(this.txtPermisos);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAgregarFamilia);
            this.Controls.Add(this.lblFamilias);
            this.Controls.Add(this.cmbFamilias);
            this.Controls.Add(this.btnAgregarPreguntas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmConfiguracionDeSeguridad";
            this.Text = "FrmMantenimientoDeUsuarios";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdBloqueadoPorDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdVenceCada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdIntentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdHorasDeBloqueo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.NumericUpDown npdBloqueadoPorDias;
        private System.Windows.Forms.Label lblBloqueadoPor;
        private System.Windows.Forms.NumericUpDown npdVenceCada;
        private System.Windows.Forms.CheckBox ckbRealizarPreguntasSeguridad;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown npdIntentos;
        private System.Windows.Forms.CheckBox ckbAvisarVencimiento;
        private System.Windows.Forms.CheckBox ckbMinimo;
        private System.Windows.Forms.CheckBox ckbEspecial;
        private System.Windows.Forms.CheckBox ckbNumero;
        private System.Windows.Forms.CheckBox ckbMayuscula;
        private System.Windows.Forms.CheckBox ckbMinuscula;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown npdHorasDeBloqueo;
        private System.Windows.Forms.CheckBox ckbAutenticacion2FA;
        private System.Windows.Forms.CheckBox chbDesbloqueoAuto;
        private System.Windows.Forms.CheckBox chbContraseñasAnteriores;
        private System.Windows.Forms.CheckBox chbBloqueado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chbDatosPersonales;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarPreguntas;
        private System.Windows.Forms.ComboBox cmbFamilias;
        private System.Windows.Forms.Label lblFamilias;
        private System.Windows.Forms.Button btnAgregarFamilia;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.TextBox txtPermisos;
        private System.Windows.Forms.Button btnAgregarPermisos;
    }
}