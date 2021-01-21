namespace CapaVistaFRM
{
    partial class movimientos_bancarios_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movimientos_bancarios_2));
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_encabezado = new System.Windows.Forms.GroupBox();
            this.Txt_moneda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_saldoActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_cuentaBancaria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_fechaMov = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Gpb_detalle = new System.Windows.Forms.GroupBox();
            this.Chk_registrado = new System.Windows.Forms.CheckBox();
            this.Cbo_beneRegistrado = new System.Windows.Forms.ComboBox();
            this.Txt_beneNoRegistrado = new System.Windows.Forms.TextBox();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Txt_referencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbo_tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_registrar = new System.Windows.Forms.Button();
            this.Txt_monto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cbo_cargoAbono = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Gpb_detalleMov = new System.Windows.Forms.GroupBox();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Dgv_detalleDeMovimientos = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Lbl_totalCargos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Lbl_totalAbonos = new System.Windows.Forms.Label();
            this.Lbl_diferencial = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gpb_encabezado.SuspendLayout();
            this.Gpb_detalle.SuspendLayout();
            this.Gpb_detalleMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleDeMovimientos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movimientos Bancarios";
            // 
            // Gpb_encabezado
            // 
            this.Gpb_encabezado.Controls.Add(this.Txt_moneda);
            this.Gpb_encabezado.Controls.Add(this.label7);
            this.Gpb_encabezado.Controls.Add(this.Txt_saldoActual);
            this.Gpb_encabezado.Controls.Add(this.label3);
            this.Gpb_encabezado.Controls.Add(this.Txt_cuentaBancaria);
            this.Gpb_encabezado.Controls.Add(this.label2);
            this.Gpb_encabezado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_encabezado.Location = new System.Drawing.Point(12, 65);
            this.Gpb_encabezado.Name = "Gpb_encabezado";
            this.Gpb_encabezado.Size = new System.Drawing.Size(886, 67);
            this.Gpb_encabezado.TabIndex = 3;
            this.Gpb_encabezado.TabStop = false;
            this.Gpb_encabezado.Text = "Encabezado";
            // 
            // Txt_moneda
            // 
            this.Txt_moneda.Enabled = false;
            this.Txt_moneda.Location = new System.Drawing.Point(390, 27);
            this.Txt_moneda.Name = "Txt_moneda";
            this.Txt_moneda.Size = new System.Drawing.Size(169, 27);
            this.Txt_moneda.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(305, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Moneda:";
            // 
            // Txt_saldoActual
            // 
            this.Txt_saldoActual.Enabled = false;
            this.Txt_saldoActual.Location = new System.Drawing.Point(715, 27);
            this.Txt_saldoActual.Name = "Txt_saldoActual";
            this.Txt_saldoActual.Size = new System.Drawing.Size(144, 27);
            this.Txt_saldoActual.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Saldo Actual:";
            // 
            // Txt_cuentaBancaria
            // 
            this.Txt_cuentaBancaria.Enabled = false;
            this.Txt_cuentaBancaria.Location = new System.Drawing.Point(99, 27);
            this.Txt_cuentaBancaria.Name = "Txt_cuentaBancaria";
            this.Txt_cuentaBancaria.Size = new System.Drawing.Size(169, 27);
            this.Txt_cuentaBancaria.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuenta:";
            // 
            // Dtp_fechaMov
            // 
            this.Dtp_fechaMov.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaMov.CustomFormat = "yyyy-MM-dd";
            this.Dtp_fechaMov.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaMov.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_fechaMov.Location = new System.Drawing.Point(306, 47);
            this.Dtp_fechaMov.Name = "Dtp_fechaMov";
            this.Dtp_fechaMov.Size = new System.Drawing.Size(194, 27);
            this.Dtp_fechaMov.TabIndex = 15;
            this.Dtp_fechaMov.Value = new System.DateTime(2020, 4, 18, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha:";
            // 
            // Gpb_detalle
            // 
            this.Gpb_detalle.Controls.Add(this.Chk_registrado);
            this.Gpb_detalle.Controls.Add(this.Cbo_beneRegistrado);
            this.Gpb_detalle.Controls.Add(this.Txt_beneNoRegistrado);
            this.Gpb_detalle.Controls.Add(this.Txt_descripcion);
            this.Gpb_detalle.Controls.Add(this.label8);
            this.Gpb_detalle.Controls.Add(this.label17);
            this.Gpb_detalle.Controls.Add(this.Txt_referencia);
            this.Gpb_detalle.Controls.Add(this.label6);
            this.Gpb_detalle.Controls.Add(this.Cbo_tipo);
            this.Gpb_detalle.Controls.Add(this.label4);
            this.Gpb_detalle.Controls.Add(this.Dtp_fechaMov);
            this.Gpb_detalle.Controls.Add(this.Btn_registrar);
            this.Gpb_detalle.Controls.Add(this.Txt_monto);
            this.Gpb_detalle.Controls.Add(this.label5);
            this.Gpb_detalle.Controls.Add(this.label12);
            this.Gpb_detalle.Controls.Add(this.Cbo_cargoAbono);
            this.Gpb_detalle.Controls.Add(this.label10);
            this.Gpb_detalle.Controls.Add(this.label9);
            this.Gpb_detalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalle.Location = new System.Drawing.Point(12, 135);
            this.Gpb_detalle.Name = "Gpb_detalle";
            this.Gpb_detalle.Size = new System.Drawing.Size(886, 213);
            this.Gpb_detalle.TabIndex = 4;
            this.Gpb_detalle.TabStop = false;
            this.Gpb_detalle.Text = "Detalle";
            this.Gpb_detalle.Enter += new System.EventHandler(this.Gpb_detalle_Enter);
            // 
            // Chk_registrado
            // 
            this.Chk_registrado.AutoSize = true;
            this.Chk_registrado.Location = new System.Drawing.Point(570, 108);
            this.Chk_registrado.Name = "Chk_registrado";
            this.Chk_registrado.Size = new System.Drawing.Size(139, 25);
            this.Chk_registrado.TabIndex = 45;
            this.Chk_registrado.Text = "No Registrado";
            this.Chk_registrado.UseVisualStyleBackColor = true;
            this.Chk_registrado.CheckedChanged += new System.EventHandler(this.Chk_registrado_CheckedChanged);
            // 
            // Cbo_beneRegistrado
            // 
            this.Cbo_beneRegistrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_beneRegistrado.Enabled = false;
            this.Cbo_beneRegistrado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_beneRegistrado.FormattingEnabled = true;
            this.Cbo_beneRegistrado.Location = new System.Drawing.Point(25, 108);
            this.Cbo_beneRegistrado.Name = "Cbo_beneRegistrado";
            this.Cbo_beneRegistrado.Size = new System.Drawing.Size(214, 29);
            this.Cbo_beneRegistrado.TabIndex = 44;
            // 
            // Txt_beneNoRegistrado
            // 
            this.Txt_beneNoRegistrado.Location = new System.Drawing.Point(306, 108);
            this.Txt_beneNoRegistrado.Name = "Txt_beneNoRegistrado";
            this.Txt_beneNoRegistrado.Size = new System.Drawing.Size(226, 27);
            this.Txt_beneNoRegistrado.TabIndex = 42;
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(25, 169);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.Size = new System.Drawing.Size(313, 27);
            this.Txt_descripcion.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Beneficiario (no registrado):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 19);
            this.label17.TabIndex = 39;
            this.label17.Text = "Beneficiario (registrado):";
            // 
            // Txt_referencia
            // 
            this.Txt_referencia.Location = new System.Drawing.Point(562, 47);
            this.Txt_referencia.Name = "Txt_referencia";
            this.Txt_referencia.Size = new System.Drawing.Size(169, 27);
            this.Txt_referencia.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(558, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "No. de Referencia:";
            // 
            // Cbo_tipo
            // 
            this.Cbo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_tipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_tipo.FormattingEnabled = true;
            this.Cbo_tipo.Location = new System.Drawing.Point(25, 45);
            this.Cbo_tipo.Name = "Cbo_tipo";
            this.Cbo_tipo.Size = new System.Drawing.Size(214, 29);
            this.Cbo_tipo.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tipo:";
            // 
            // Btn_registrar
            // 
            this.Btn_registrar.BackColor = System.Drawing.Color.White;
            this.Btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_registrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_registrar.ForeColor = System.Drawing.Color.Black;
            this.Btn_registrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_registrar.Image")));
            this.Btn_registrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_registrar.Location = new System.Drawing.Point(777, 138);
            this.Btn_registrar.Name = "Btn_registrar";
            this.Btn_registrar.Size = new System.Drawing.Size(95, 67);
            this.Btn_registrar.TabIndex = 36;
            this.Btn_registrar.Text = "Registrar";
            this.Btn_registrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_registrar.UseVisualStyleBackColor = false;
            this.Btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // Txt_monto
            // 
            this.Txt_monto.Location = new System.Drawing.Point(589, 169);
            this.Txt_monto.Name = "Txt_monto";
            this.Txt_monto.Size = new System.Drawing.Size(169, 27);
            this.Txt_monto.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(584, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "Monto:";
            // 
            // Cbo_cargoAbono
            // 
            this.Cbo_cargoAbono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_cargoAbono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cargoAbono.FormattingEnabled = true;
            this.Cbo_cargoAbono.Location = new System.Drawing.Point(359, 169);
            this.Cbo_cargoAbono.Name = "Cbo_cargoAbono";
            this.Cbo_cargoAbono.Size = new System.Drawing.Size(209, 29);
            this.Cbo_cargoAbono.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cargo/Abono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Descripción:";
            // 
            // Gpb_detalleMov
            // 
            this.Gpb_detalleMov.Controls.Add(this.Btn_quitar);
            this.Gpb_detalleMov.Controls.Add(this.Dgv_detalleDeMovimientos);
            this.Gpb_detalleMov.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalleMov.ForeColor = System.Drawing.Color.Black;
            this.Gpb_detalleMov.Location = new System.Drawing.Point(12, 352);
            this.Gpb_detalleMov.Name = "Gpb_detalleMov";
            this.Gpb_detalleMov.Size = new System.Drawing.Size(886, 194);
            this.Gpb_detalleMov.TabIndex = 29;
            this.Gpb_detalleMov.TabStop = false;
            this.Gpb_detalleMov.Text = "Detalle de Movimientos";
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
            this.Btn_quitar.Visible = false;
            // 
            // Dgv_detalleDeMovimientos
            // 
            this.Dgv_detalleDeMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalleDeMovimientos.Location = new System.Drawing.Point(12, 31);
            this.Dgv_detalleDeMovimientos.Name = "Dgv_detalleDeMovimientos";
            this.Dgv_detalleDeMovimientos.ReadOnly = true;
            this.Dgv_detalleDeMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_detalleDeMovimientos.Size = new System.Drawing.Size(756, 147);
            this.Dgv_detalleDeMovimientos.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 560);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Total Cargos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(333, 560);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "Total Abonos:";
            // 
            // Lbl_totalCargos
            // 
            this.Lbl_totalCargos.AutoSize = true;
            this.Lbl_totalCargos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totalCargos.Location = new System.Drawing.Point(175, 553);
            this.Lbl_totalCargos.Name = "Lbl_totalCargos";
            this.Lbl_totalCargos.Size = new System.Drawing.Size(68, 32);
            this.Lbl_totalCargos.TabIndex = 31;
            this.Lbl_totalCargos.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(652, 560);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 23);
            this.label16.TabIndex = 29;
            this.label16.Text = "Diferencial:";
            // 
            // Lbl_totalAbonos
            // 
            this.Lbl_totalAbonos.AutoSize = true;
            this.Lbl_totalAbonos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totalAbonos.Location = new System.Drawing.Point(477, 553);
            this.Lbl_totalAbonos.Name = "Lbl_totalAbonos";
            this.Lbl_totalAbonos.Size = new System.Drawing.Size(68, 32);
            this.Lbl_totalAbonos.TabIndex = 34;
            this.Lbl_totalAbonos.Text = "0.00";
            // 
            // Lbl_diferencial
            // 
            this.Lbl_diferencial.AutoSize = true;
            this.Lbl_diferencial.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_diferencial.Location = new System.Drawing.Point(778, 553);
            this.Lbl_diferencial.Name = "Lbl_diferencial";
            this.Lbl_diferencial.Size = new System.Drawing.Size(68, 32);
            this.Lbl_diferencial.TabIndex = 35;
            this.Lbl_diferencial.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 59);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(852, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // movimientos_bancarios_2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(913, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_diferencial);
            this.Controls.Add(this.Lbl_totalAbonos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Lbl_totalCargos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Gpb_detalleMov);
            this.Controls.Add(this.Gpb_detalle);
            this.Controls.Add(this.Gpb_encabezado);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "movimientos_bancarios_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5220 - Movimientos Bancarios";
            this.Gpb_encabezado.ResumeLayout(false);
            this.Gpb_encabezado.PerformLayout();
            this.Gpb_detalle.ResumeLayout(false);
            this.Gpb_detalle.PerformLayout();
            this.Gpb_detalleMov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalleDeMovimientos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_encabezado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_fechaMov;
        private System.Windows.Forms.GroupBox Gpb_detalle;
        private System.Windows.Forms.TextBox Txt_monto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cbo_cargoAbono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox Gpb_detalleMov;
        private System.Windows.Forms.DataGridView Dgv_detalleDeMovimientos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Lbl_totalCargos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Lbl_totalAbonos;
        private System.Windows.Forms.Label Lbl_diferencial;
        private System.Windows.Forms.Button Btn_registrar;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.TextBox Txt_saldoActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_cuentaBancaria;
        private System.Windows.Forms.CheckBox Chk_registrado;
        private System.Windows.Forms.ComboBox Cbo_beneRegistrado;
        private System.Windows.Forms.TextBox Txt_beneNoRegistrado;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Txt_referencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbo_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_moneda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}