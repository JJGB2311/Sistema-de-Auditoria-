namespace CapaVistaFRM
{
    partial class conciliacion_bancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conciliacion_bancaria));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gpb_movLibroBancos = new System.Windows.Forms.GroupBox();
            this.Dgv_libroBancos = new System.Windows.Forms.DataGridView();
            this.Gpb_movValidados = new System.Windows.Forms.GroupBox();
            this.Dgv_validados = new System.Windows.Forms.DataGridView();
            this.Cbo_bancos = new System.Windows.Forms.ComboBox();
            this.Cbo_moneda = new System.Windows.Forms.ComboBox();
            this.Dtp_mes = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            //this.pdfEstadoCuenta = new AxAcroPDFLib.AxAcroPDF();
            this.Btn_finalizarConciliacion = new System.Windows.Forms.Button();
            this.Btn_abrirEstadoDeCuenta = new System.Windows.Forms.Button();
            this.Btn_abajo = new System.Windows.Forms.Button();
            this.Btn_arriba = new System.Windows.Forms.Button();
            this.Gpb_movLibroBancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_libroBancos)).BeginInit();
            this.Gpb_movValidados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_validados)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.pdfEstadoCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conciliación Bancaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banco: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moneda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mes: ";
            // 
            // Gpb_movLibroBancos
            // 
            this.Gpb_movLibroBancos.Controls.Add(this.Dgv_libroBancos);
            this.Gpb_movLibroBancos.Location = new System.Drawing.Point(28, 114);
            this.Gpb_movLibroBancos.Name = "Gpb_movLibroBancos";
            this.Gpb_movLibroBancos.Size = new System.Drawing.Size(760, 175);
            this.Gpb_movLibroBancos.TabIndex = 5;
            this.Gpb_movLibroBancos.TabStop = false;
            this.Gpb_movLibroBancos.Text = "Movimientos Libro Bancos";
            // 
            // Dgv_libroBancos
            // 
            this.Dgv_libroBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_libroBancos.Location = new System.Drawing.Point(15, 26);
            this.Dgv_libroBancos.Name = "Dgv_libroBancos";
            this.Dgv_libroBancos.Size = new System.Drawing.Size(729, 135);
            this.Dgv_libroBancos.TabIndex = 0;
            // 
            // Gpb_movValidados
            // 
            this.Gpb_movValidados.Controls.Add(this.Dgv_validados);
            this.Gpb_movValidados.Location = new System.Drawing.Point(28, 344);
            this.Gpb_movValidados.Name = "Gpb_movValidados";
            this.Gpb_movValidados.Size = new System.Drawing.Size(760, 181);
            this.Gpb_movValidados.TabIndex = 6;
            this.Gpb_movValidados.TabStop = false;
            this.Gpb_movValidados.Text = "Movimientos Validados";
            // 
            // Dgv_validados
            // 
            this.Dgv_validados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_validados.Location = new System.Drawing.Point(15, 26);
            this.Dgv_validados.Name = "Dgv_validados";
            this.Dgv_validados.Size = new System.Drawing.Size(729, 142);
            this.Dgv_validados.TabIndex = 1;
            // 
            // Cbo_bancos
            // 
            this.Cbo_bancos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_bancos.FormattingEnabled = true;
            this.Cbo_bancos.Location = new System.Drawing.Point(107, 68);
            this.Cbo_bancos.Name = "Cbo_bancos";
            this.Cbo_bancos.Size = new System.Drawing.Size(159, 29);
            this.Cbo_bancos.TabIndex = 7;
            this.Cbo_bancos.Text = "Seleccione";
            // 
            // Cbo_moneda
            // 
            this.Cbo_moneda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_moneda.FormattingEnabled = true;
            this.Cbo_moneda.Location = new System.Drawing.Point(410, 68);
            this.Cbo_moneda.Name = "Cbo_moneda";
            this.Cbo_moneda.Size = new System.Drawing.Size(159, 29);
            this.Cbo_moneda.TabIndex = 8;
            this.Cbo_moneda.Text = "Seleccione";
            // 
            // Dtp_mes
            // 
            this.Dtp_mes.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_mes.CustomFormat = "MM/yyyy";
            this.Dtp_mes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_mes.Location = new System.Drawing.Point(684, 68);
            this.Dtp_mes.Name = "Dtp_mes";
            this.Dtp_mes.Size = new System.Drawing.Size(104, 27);
            this.Dtp_mes.TabIndex = 9;
            this.Dtp_mes.Value = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Saldo pendiente por cuadrar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Debe: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Haber: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "0.000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "0.000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 605);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "0.000";
            // 
            // pdfEstadoCuenta
            // 
            //this.pdfEstadoCuenta.Enabled = true;
            //this.pdfEstadoCuenta.Location = new System.Drawing.Point(836, 140);
            //this.pdfEstadoCuenta.Name = "pdfEstadoCuenta";
            //this.pdfEstadoCuenta.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfEstadoCuenta.OcxState")));
            //this.pdfEstadoCuenta.Size = new System.Drawing.Size(392, 457);
            //this.pdfEstadoCuenta.TabIndex = 22;
            // 
            // Btn_finalizarConciliacion
            // 
            this.Btn_finalizarConciliacion.BackColor = System.Drawing.Color.White;
            this.Btn_finalizarConciliacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_finalizarConciliacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_finalizarConciliacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_finalizarConciliacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_finalizarConciliacion.ForeColor = System.Drawing.Color.Black;
            this.Btn_finalizarConciliacion.Image = global::CapaVistaFRM.Properties.Resources.calc;
            this.Btn_finalizarConciliacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_finalizarConciliacion.Location = new System.Drawing.Point(538, 554);
            this.Btn_finalizarConciliacion.Name = "Btn_finalizarConciliacion";
            this.Btn_finalizarConciliacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_finalizarConciliacion.Size = new System.Drawing.Size(223, 54);
            this.Btn_finalizarConciliacion.TabIndex = 23;
            this.Btn_finalizarConciliacion.Text = "Finalizar Conciliación";
            this.Btn_finalizarConciliacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_finalizarConciliacion.UseVisualStyleBackColor = false;
            // 
            // Btn_abrirEstadoDeCuenta
            // 
            this.Btn_abrirEstadoDeCuenta.BackColor = System.Drawing.Color.White;
            this.Btn_abrirEstadoDeCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_abrirEstadoDeCuenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_abrirEstadoDeCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_abrirEstadoDeCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_abrirEstadoDeCuenta.ForeColor = System.Drawing.Color.Black;
            this.Btn_abrirEstadoDeCuenta.Image = global::CapaVistaFRM.Properties.Resources.pdf;
            this.Btn_abrirEstadoDeCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_abrirEstadoDeCuenta.Location = new System.Drawing.Point(915, 56);
            this.Btn_abrirEstadoDeCuenta.Name = "Btn_abrirEstadoDeCuenta";
            this.Btn_abrirEstadoDeCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_abrirEstadoDeCuenta.Size = new System.Drawing.Size(234, 54);
            this.Btn_abrirEstadoDeCuenta.TabIndex = 19;
            this.Btn_abrirEstadoDeCuenta.Text = "Abrir Estado de Cuenta";
            this.Btn_abrirEstadoDeCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_abrirEstadoDeCuenta.UseVisualStyleBackColor = false;
            this.Btn_abrirEstadoDeCuenta.Click += new System.EventHandler(this.Btn_abrirEstadoDeCuenta_Click);
            // 
            // Btn_abajo
            // 
            this.Btn_abajo.BackColor = System.Drawing.Color.White;
            this.Btn_abajo.BackgroundImage = global::CapaVistaFRM.Properties.Resources.flecha_hacia_abajo;
            this.Btn_abajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_abajo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_abajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_abajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_abajo.Location = new System.Drawing.Point(345, 297);
            this.Btn_abajo.Name = "Btn_abajo";
            this.Btn_abajo.Size = new System.Drawing.Size(59, 51);
            this.Btn_abajo.TabIndex = 11;
            this.Btn_abajo.UseVisualStyleBackColor = false;
            // 
            // Btn_arriba
            // 
            this.Btn_arriba.BackColor = System.Drawing.Color.White;
            this.Btn_arriba.BackgroundImage = global::CapaVistaFRM.Properties.Resources.flecha_hacia_arriba;
            this.Btn_arriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_arriba.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_arriba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_arriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_arriba.Location = new System.Drawing.Point(426, 297);
            this.Btn_arriba.Name = "Btn_arriba";
            this.Btn_arriba.Size = new System.Drawing.Size(59, 51);
            this.Btn_arriba.TabIndex = 10;
            this.Btn_arriba.UseVisualStyleBackColor = false;
            // 
            // conciliacion_bancaria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1254, 643);
            this.Controls.Add(this.Btn_finalizarConciliacion);
            //this.Controls.Add(this.pdfEstadoCuenta);
            this.Controls.Add(this.Btn_abrirEstadoDeCuenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_abajo);
            this.Controls.Add(this.Btn_arriba);
            this.Controls.Add(this.Dtp_mes);
            this.Controls.Add(this.Cbo_moneda);
            this.Controls.Add(this.Cbo_bancos);
            this.Controls.Add(this.Gpb_movValidados);
            this.Controls.Add(this.Gpb_movLibroBancos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "conciliacion_bancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5222 - Conciliacion Bancaria";
            this.Gpb_movLibroBancos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_libroBancos)).EndInit();
            this.Gpb_movValidados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_validados)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.pdfEstadoCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Gpb_movLibroBancos;
        private System.Windows.Forms.DataGridView Dgv_libroBancos;
        private System.Windows.Forms.GroupBox Gpb_movValidados;
        private System.Windows.Forms.ComboBox Cbo_bancos;
        private System.Windows.Forms.ComboBox Cbo_moneda;
        private System.Windows.Forms.DateTimePicker Dtp_mes;
        private System.Windows.Forms.DataGridView Dgv_validados;
        private System.Windows.Forms.Button Btn_arriba;
        private System.Windows.Forms.Button Btn_abajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_abrirEstadoDeCuenta;
        //private AxAcroPDFLib.AxAcroPDF pdfEstadoCuenta;
        private System.Windows.Forms.Button Btn_finalizarConciliacion;
    }
}