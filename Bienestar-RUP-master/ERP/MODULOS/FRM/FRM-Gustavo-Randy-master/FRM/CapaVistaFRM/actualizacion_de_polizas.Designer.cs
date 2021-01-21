namespace CapaVistaFRM
{
    partial class actualizacion_de_polizas
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
            this.Gpb_consulta = new System.Windows.Forms.GroupBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Cbo_seleccione = new System.Windows.Forms.ComboBox();
            this.Dtp_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_polizas = new System.Windows.Forms.DataGridView();
            this.Btn_actualizarPolizas = new System.Windows.Forms.Button();
            this.noPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_polizas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualización de Pólizas";
            // 
            // Gpb_consulta
            // 
            this.Gpb_consulta.Controls.Add(this.Btn_consultar);
            this.Gpb_consulta.Controls.Add(this.Cbo_seleccione);
            this.Gpb_consulta.Controls.Add(this.Dtp_fechaFinal);
            this.Gpb_consulta.Controls.Add(this.Dtp_fechaInicio);
            this.Gpb_consulta.Controls.Add(this.label4);
            this.Gpb_consulta.Controls.Add(this.label3);
            this.Gpb_consulta.Controls.Add(this.label2);
            this.Gpb_consulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_consulta.Location = new System.Drawing.Point(18, 59);
            this.Gpb_consulta.Name = "Gpb_consulta";
            this.Gpb_consulta.Size = new System.Drawing.Size(918, 114);
            this.Gpb_consulta.TabIndex = 1;
            this.Gpb_consulta.TabStop = false;
            this.Gpb_consulta.Text = "Consulta";
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.ForeColor = System.Drawing.Color.Black;
            this.Btn_consultar.Image = global::CapaVistaFRM.Properties.Resources.search;
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_consultar.Location = new System.Drawing.Point(783, 36);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(126, 57);
            this.Btn_consultar.TabIndex = 7;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            // 
            // Cbo_seleccione
            // 
            this.Cbo_seleccione.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_seleccione.FormattingEnabled = true;
            this.Cbo_seleccione.Location = new System.Drawing.Point(598, 58);
            this.Cbo_seleccione.Name = "Cbo_seleccione";
            this.Cbo_seleccione.Size = new System.Drawing.Size(169, 29);
            this.Cbo_seleccione.TabIndex = 6;
            this.Cbo_seleccione.Text = "Seleccione";
            // 
            // Dtp_fechaFinal
            // 
            this.Dtp_fechaFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaFinal.Location = new System.Drawing.Point(307, 61);
            this.Dtp_fechaFinal.Name = "Dtp_fechaFinal";
            this.Dtp_fechaFinal.Size = new System.Drawing.Size(274, 23);
            this.Dtp_fechaFinal.TabIndex = 5;
            // 
            // Dtp_fechaInicio
            // 
            this.Dtp_fechaInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 8F);
            this.Dtp_fechaInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaInicio.Location = new System.Drawing.Point(17, 61);
            this.Dtp_fechaInicio.Name = "Dtp_fechaInicio";
            this.Dtp_fechaInicio.Size = new System.Drawing.Size(273, 23);
            this.Dtp_fechaInicio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Inicio";
            // 
            // Dgv_polizas
            // 
            this.Dgv_polizas.AllowUserToAddRows = false;
            this.Dgv_polizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noPoliza,
            this.tipoPoliza,
            this.codigoCuenta,
            this.cuentaContable,
            this.debe,
            this.haber});
            this.Dgv_polizas.Location = new System.Drawing.Point(18, 193);
            this.Dgv_polizas.Name = "Dgv_polizas";
            this.Dgv_polizas.Size = new System.Drawing.Size(918, 241);
            this.Dgv_polizas.TabIndex = 0;
            // 
            // Btn_actualizarPolizas
            // 
            this.Btn_actualizarPolizas.BackColor = System.Drawing.Color.White;
            this.Btn_actualizarPolizas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_actualizarPolizas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_actualizarPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizarPolizas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizarPolizas.ForeColor = System.Drawing.Color.Black;
            this.Btn_actualizarPolizas.Image = global::CapaVistaFRM.Properties.Resources.refresh;
            this.Btn_actualizarPolizas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_actualizarPolizas.Location = new System.Drawing.Point(385, 448);
            this.Btn_actualizarPolizas.Name = "Btn_actualizarPolizas";
            this.Btn_actualizarPolizas.Size = new System.Drawing.Size(189, 44);
            this.Btn_actualizarPolizas.TabIndex = 8;
            this.Btn_actualizarPolizas.Text = "Actualizar Pólizas";
            this.Btn_actualizarPolizas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_actualizarPolizas.UseVisualStyleBackColor = false;
            // 
            // noPoliza
            // 
            this.noPoliza.HeaderText = "No. Póliza";
            this.noPoliza.Name = "noPoliza";
            // 
            // tipoPoliza
            // 
            this.tipoPoliza.HeaderText = "Tipo Póliza";
            this.tipoPoliza.Name = "tipoPoliza";
            // 
            // codigoCuenta
            // 
            this.codigoCuenta.HeaderText = "Código Cuenta";
            this.codigoCuenta.Name = "codigoCuenta";
            // 
            // cuentaContable
            // 
            this.cuentaContable.HeaderText = "Cuenta Contable";
            this.cuentaContable.Name = "cuentaContable";
            // 
            // debe
            // 
            this.debe.HeaderText = "Debe";
            this.debe.Name = "debe";
            // 
            // haber
            // 
            this.haber.HeaderText = "Haber";
            this.haber.Name = "haber";
            // 
            // actualizacion_de_polizas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(956, 504);
            this.Controls.Add(this.Btn_actualizarPolizas);
            this.Controls.Add(this.Dgv_polizas);
            this.Controls.Add(this.Gpb_consulta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "actualizacion_de_polizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualización de Pólizas";
            this.Load += new System.EventHandler(this.Formato_Load);
            this.Gpb_consulta.ResumeLayout(false);
            this.Gpb_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_polizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_consulta;
        private System.Windows.Forms.DateTimePicker Dtp_fechaFinal;
        private System.Windows.Forms.DateTimePicker Dtp_fechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_polizas;
        private System.Windows.Forms.ComboBox Cbo_seleccione;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_actualizarPolizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
    }
}