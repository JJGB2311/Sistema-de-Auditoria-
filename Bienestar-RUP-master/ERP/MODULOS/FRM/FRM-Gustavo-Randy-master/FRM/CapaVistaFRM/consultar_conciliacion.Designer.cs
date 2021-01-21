namespace CapaVistaFRM
{
    partial class consultar_conciliacion
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
            this.Gpb_consultaConciliacion = new System.Windows.Forms.GroupBox();
            this.Dtp_mes = new System.Windows.Forms.DateTimePicker();
            this.Cbo_moneda = new System.Windows.Forms.ComboBox();
            this.Cbo_banco = new System.Windows.Forms.ComboBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_conciliacion = new System.Windows.Forms.DataGridView();
            this.Gpb_consultaConciliacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_conciliacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Conciliación";
            // 
            // Gpb_consultaConciliacion
            // 
            this.Gpb_consultaConciliacion.Controls.Add(this.Dtp_mes);
            this.Gpb_consultaConciliacion.Controls.Add(this.Cbo_moneda);
            this.Gpb_consultaConciliacion.Controls.Add(this.Cbo_banco);
            this.Gpb_consultaConciliacion.Controls.Add(this.Btn_consultar);
            this.Gpb_consultaConciliacion.Controls.Add(this.label4);
            this.Gpb_consultaConciliacion.Controls.Add(this.label3);
            this.Gpb_consultaConciliacion.Controls.Add(this.label2);
            this.Gpb_consultaConciliacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_consultaConciliacion.Location = new System.Drawing.Point(18, 59);
            this.Gpb_consultaConciliacion.Name = "Gpb_consultaConciliacion";
            this.Gpb_consultaConciliacion.Size = new System.Drawing.Size(821, 114);
            this.Gpb_consultaConciliacion.TabIndex = 1;
            this.Gpb_consultaConciliacion.TabStop = false;
            this.Gpb_consultaConciliacion.Text = "Consulta Conciliación";
            // 
            // Dtp_mes
            // 
            this.Dtp_mes.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_mes.CustomFormat = "MM/yyyy";
            this.Dtp_mes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_mes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_mes.Location = new System.Drawing.Point(512, 61);
            this.Dtp_mes.Name = "Dtp_mes";
            this.Dtp_mes.Size = new System.Drawing.Size(107, 27);
            this.Dtp_mes.TabIndex = 9;
            // 
            // Cbo_moneda
            // 
            this.Cbo_moneda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_moneda.FormattingEnabled = true;
            this.Cbo_moneda.Location = new System.Drawing.Point(273, 61);
            this.Cbo_moneda.Name = "Cbo_moneda";
            this.Cbo_moneda.Size = new System.Drawing.Size(207, 29);
            this.Cbo_moneda.TabIndex = 8;
            // 
            // Cbo_banco
            // 
            this.Cbo_banco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_banco.FormattingEnabled = true;
            this.Cbo_banco.Location = new System.Drawing.Point(23, 61);
            this.Cbo_banco.Name = "Cbo_banco";
            this.Cbo_banco.Size = new System.Drawing.Size(215, 29);
            this.Cbo_banco.TabIndex = 7;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.ForeColor = System.Drawing.Color.Black;
            this.Btn_consultar.Image = global::CapaVistaFRM.Properties.Resources.search;
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_consultar.Location = new System.Drawing.Point(667, 37);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(130, 57);
            this.Btn_consultar.TabIndex = 3;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mes: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Moneda: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Banco: ";
            // 
            // Dgv_conciliacion
            // 
            this.Dgv_conciliacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_conciliacion.Location = new System.Drawing.Point(18, 193);
            this.Dgv_conciliacion.Name = "Dgv_conciliacion";
            this.Dgv_conciliacion.Size = new System.Drawing.Size(821, 288);
            this.Dgv_conciliacion.TabIndex = 2;
            // 
            // consultar_conciliacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(855, 493);
            this.Controls.Add(this.Dgv_conciliacion);
            this.Controls.Add(this.Gpb_consultaConciliacion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "consultar_conciliacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5223 - Consultar Conciliación";
            this.Load += new System.EventHandler(this.Formato_Load);
            this.Gpb_consultaConciliacion.ResumeLayout(false);
            this.Gpb_consultaConciliacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_conciliacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_consultaConciliacion;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_conciliacion;
        private System.Windows.Forms.DateTimePicker Dtp_mes;
        private System.Windows.Forms.ComboBox Cbo_moneda;
        private System.Windows.Forms.ComboBox Cbo_banco;
    }
}