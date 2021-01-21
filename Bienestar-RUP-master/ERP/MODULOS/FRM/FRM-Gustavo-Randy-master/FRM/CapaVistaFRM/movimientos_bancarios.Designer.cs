namespace CapaVistaFRM
{
    partial class movimientos_bancarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movimientos_bancarios));
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_encabezado = new System.Windows.Forms.GroupBox();
            this.Txt_valorEncabezado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_concepto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dtp_vence = new System.Windows.Forms.DateTimePicker();
            this.Dtp_emision = new System.Windows.Forms.DateTimePicker();
            this.Txt_documento = new System.Windows.Forms.TextBox();
            this.Cbo_tipo = new System.Windows.Forms.ComboBox();
            this.Cbo_banco = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gpb_detalle = new System.Windows.Forms.GroupBox();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Txt_valorDetalle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cbo_cargoAbono = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cbo_codigo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Dgv_detalleDeMovimientos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Gpb_encabezado.SuspendLayout();
            this.Gpb_detalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleDeMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movimientos Bancarios";
            // 
            // Gpb_encabezado
            // 
            this.Gpb_encabezado.Controls.Add(this.Txt_valorEncabezado);
            this.Gpb_encabezado.Controls.Add(this.label8);
            this.Gpb_encabezado.Controls.Add(this.Txt_concepto);
            this.Gpb_encabezado.Controls.Add(this.label7);
            this.Gpb_encabezado.Controls.Add(this.Dtp_vence);
            this.Gpb_encabezado.Controls.Add(this.Dtp_emision);
            this.Gpb_encabezado.Controls.Add(this.Txt_documento);
            this.Gpb_encabezado.Controls.Add(this.Cbo_tipo);
            this.Gpb_encabezado.Controls.Add(this.Cbo_banco);
            this.Gpb_encabezado.Controls.Add(this.label6);
            this.Gpb_encabezado.Controls.Add(this.label5);
            this.Gpb_encabezado.Controls.Add(this.label4);
            this.Gpb_encabezado.Controls.Add(this.label3);
            this.Gpb_encabezado.Controls.Add(this.label2);
            this.Gpb_encabezado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_encabezado.Location = new System.Drawing.Point(12, 72);
            this.Gpb_encabezado.Name = "Gpb_encabezado";
            this.Gpb_encabezado.Size = new System.Drawing.Size(886, 163);
            this.Gpb_encabezado.TabIndex = 3;
            this.Gpb_encabezado.TabStop = false;
            this.Gpb_encabezado.Text = "Encabezado";
            // 
            // Txt_valorEncabezado
            // 
            this.Txt_valorEncabezado.Location = new System.Drawing.Point(703, 121);
            this.Txt_valorEncabezado.Name = "Txt_valorEncabezado";
            this.Txt_valorEncabezado.Size = new System.Drawing.Size(169, 27);
            this.Txt_valorEncabezado.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(698, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Valor:";
            // 
            // Txt_concepto
            // 
            this.Txt_concepto.Location = new System.Drawing.Point(27, 121);
            this.Txt_concepto.Name = "Txt_concepto";
            this.Txt_concepto.Size = new System.Drawing.Size(659, 27);
            this.Txt_concepto.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Concepto:";
            // 
            // Dtp_vence
            // 
            this.Dtp_vence.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_vence.CustomFormat = "yyyy-MM-dd";
            this.Dtp_vence.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_vence.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_vence.Location = new System.Drawing.Point(744, 60);
            this.Dtp_vence.Name = "Dtp_vence";
            this.Dtp_vence.Size = new System.Drawing.Size(122, 27);
            this.Dtp_vence.TabIndex = 16;
            this.Dtp_vence.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // Dtp_emision
            // 
            this.Dtp_emision.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_emision.CustomFormat = "yyyy-MM-dd";
            this.Dtp_emision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_emision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_emision.Location = new System.Drawing.Point(615, 60);
            this.Dtp_emision.Name = "Dtp_emision";
            this.Dtp_emision.Size = new System.Drawing.Size(120, 27);
            this.Dtp_emision.TabIndex = 15;
            this.Dtp_emision.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // Txt_documento
            // 
            this.Txt_documento.Location = new System.Drawing.Point(424, 60);
            this.Txt_documento.Name = "Txt_documento";
            this.Txt_documento.Size = new System.Drawing.Size(179, 27);
            this.Txt_documento.TabIndex = 14;
            // 
            // Cbo_tipo
            // 
            this.Cbo_tipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_tipo.FormattingEnabled = true;
            this.Cbo_tipo.Location = new System.Drawing.Point(236, 58);
            this.Cbo_tipo.Name = "Cbo_tipo";
            this.Cbo_tipo.Size = new System.Drawing.Size(174, 29);
            this.Cbo_tipo.TabIndex = 13;
            // 
            // Cbo_banco
            // 
            this.Cbo_banco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_banco.FormattingEnabled = true;
            this.Cbo_banco.Location = new System.Drawing.Point(27, 58);
            this.Cbo_banco.Name = "Cbo_banco";
            this.Cbo_banco.Size = new System.Drawing.Size(194, 29);
            this.Cbo_banco.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Emisión: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Documento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Banco:";
            // 
            // Gpb_detalle
            // 
            this.Gpb_detalle.Controls.Add(this.Btn_aceptar);
            this.Gpb_detalle.Controls.Add(this.Txt_valorDetalle);
            this.Gpb_detalle.Controls.Add(this.label12);
            this.Gpb_detalle.Controls.Add(this.Cbo_cargoAbono);
            this.Gpb_detalle.Controls.Add(this.label10);
            this.Gpb_detalle.Controls.Add(this.Cbo_codigo);
            this.Gpb_detalle.Controls.Add(this.label9);
            this.Gpb_detalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalle.Location = new System.Drawing.Point(12, 241);
            this.Gpb_detalle.Name = "Gpb_detalle";
            this.Gpb_detalle.Size = new System.Drawing.Size(886, 102);
            this.Gpb_detalle.TabIndex = 4;
            this.Gpb_detalle.TabStop = false;
            this.Gpb_detalle.Text = "Detalle";
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.BackColor = System.Drawing.Color.White;
            this.Btn_aceptar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_aceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aceptar.ForeColor = System.Drawing.Color.Black;
            this.Btn_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_aceptar.Image")));
            this.Btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_aceptar.Location = new System.Drawing.Point(785, 22);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(87, 67);
            this.Btn_aceptar.TabIndex = 36;
            this.Btn_aceptar.Text = "Aceptar";
            this.Btn_aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_aceptar.UseVisualStyleBackColor = false;
            // 
            // Txt_valorDetalle
            // 
            this.Txt_valorDetalle.Location = new System.Drawing.Point(593, 57);
            this.Txt_valorDetalle.Name = "Txt_valorDetalle";
            this.Txt_valorDetalle.Size = new System.Drawing.Size(169, 27);
            this.Txt_valorDetalle.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(588, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Valor:";
            // 
            // Cbo_cargoAbono
            // 
            this.Cbo_cargoAbono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cargoAbono.FormattingEnabled = true;
            this.Cbo_cargoAbono.Location = new System.Drawing.Point(424, 57);
            this.Cbo_cargoAbono.Name = "Cbo_cargoAbono";
            this.Cbo_cargoAbono.Size = new System.Drawing.Size(152, 29);
            this.Cbo_cargoAbono.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(420, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cargo/Abono:";
            // 
            // Cbo_codigo
            // 
            this.Cbo_codigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_codigo.FormattingEnabled = true;
            this.Cbo_codigo.Location = new System.Drawing.Point(20, 57);
            this.Cbo_codigo.Name = "Cbo_codigo";
            this.Cbo_codigo.Size = new System.Drawing.Size(378, 29);
            this.Cbo_codigo.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_quitar);
            this.groupBox1.Controls.Add(this.Dgv_detalleDeMovimientos);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 194);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Movimientos";
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.White;
            this.Btn_quitar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_quitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_quitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quitar.ForeColor = System.Drawing.Color.Black;
            this.Btn_quitar.Image = global::CapaVistaFRM.Properties.Resources.delete;
            this.Btn_quitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_quitar.Location = new System.Drawing.Point(785, 63);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(81, 66);
            this.Btn_quitar.TabIndex = 37;
            this.Btn_quitar.Text = "Quitar";
            this.Btn_quitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_quitar.UseVisualStyleBackColor = false;
            // 
            // Dgv_detalleDeMovimientos
            // 
            this.Dgv_detalleDeMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleDeMovimientos.Location = new System.Drawing.Point(27, 31);
            this.Dgv_detalleDeMovimientos.Name = "Dgv_detalleDeMovimientos";
            this.Dgv_detalleDeMovimientos.Size = new System.Drawing.Size(735, 147);
            this.Dgv_detalleDeMovimientos.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total Cargos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(381, 570);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "Total Abonos:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(186, 563);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 32);
            this.label14.TabIndex = 31;
            this.label14.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(763, 551);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 23);
            this.label16.TabIndex = 29;
            this.label16.Text = "Diferencial";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(532, 563);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 32);
            this.label15.TabIndex = 34;
            this.label15.Text = "0.00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(761, 575);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 32);
            this.label18.TabIndex = 35;
            this.label18.Text = "0.00";
            // 
            // movimientos_bancarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(913, 618);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gpb_detalle);
            this.Controls.Add(this.Gpb_encabezado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "movimientos_bancarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos Bancarios";
            this.Gpb_encabezado.ResumeLayout(false);
            this.Gpb_encabezado.PerformLayout();
            this.Gpb_detalle.ResumeLayout(false);
            this.Gpb_detalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleDeMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_encabezado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_tipo;
        private System.Windows.Forms.ComboBox Cbo_banco;
        private System.Windows.Forms.TextBox Txt_documento;
        private System.Windows.Forms.TextBox Txt_valorEncabezado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_concepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Dtp_vence;
        private System.Windows.Forms.DateTimePicker Dtp_emision;
        private System.Windows.Forms.GroupBox Gpb_detalle;
        private System.Windows.Forms.TextBox Txt_valorDetalle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cbo_cargoAbono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cbo_codigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dgv_detalleDeMovimientos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.Button Btn_quitar;
    }
}