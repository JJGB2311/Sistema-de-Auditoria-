namespace CapaVistaFRM
{
    partial class balance_general   
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
            this.Gpb_periodoContable = new System.Windows.Forms.GroupBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Dtp_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpb_periodoContable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance General";
            // 
            // Gpb_periodoContable
            // 
            this.Gpb_periodoContable.Controls.Add(this.Btn_consultar);
            this.Gpb_periodoContable.Controls.Add(this.Dtp_fechaFinal);
            this.Gpb_periodoContable.Controls.Add(this.Dtp_fechaInicio);
            this.Gpb_periodoContable.Controls.Add(this.label3);
            this.Gpb_periodoContable.Controls.Add(this.label2);
            this.Gpb_periodoContable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_periodoContable.Location = new System.Drawing.Point(12, 49);
            this.Gpb_periodoContable.Name = "Gpb_periodoContable";
            this.Gpb_periodoContable.Size = new System.Drawing.Size(805, 99);
            this.Gpb_periodoContable.TabIndex = 2;
            this.Gpb_periodoContable.TabStop = false;
            this.Gpb_periodoContable.Text = "Periodo Contable";
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
            this.Btn_consultar.Location = new System.Drawing.Point(671, 26);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(126, 57);
            this.Btn_consultar.TabIndex = 8;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            // 
            // Dtp_fechaFinal
            // 
            this.Dtp_fechaFinal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaFinal.Location = new System.Drawing.Point(343, 55);
            this.Dtp_fechaFinal.Name = "Dtp_fechaFinal";
            this.Dtp_fechaFinal.Size = new System.Drawing.Size(304, 26);
            this.Dtp_fechaFinal.TabIndex = 5;
            // 
            // Dtp_fechaInicio
            // 
            this.Dtp_fechaInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 8F);
            this.Dtp_fechaInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fechaInicio.Location = new System.Drawing.Point(20, 55);
            this.Dtp_fechaInicio.Name = "Dtp_fechaInicio";
            this.Dtp_fechaInicio.Size = new System.Drawing.Size(303, 26);
            this.Dtp_fechaInicio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha de Inicio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCuenta,
            this.cuenta,
            this.columna1,
            this.columna2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 332);
            this.dataGridView1.TabIndex = 3;
            // 
            // codigoCuenta
            // 
            this.codigoCuenta.HeaderText = "Código Cuenta";
            this.codigoCuenta.Name = "codigoCuenta";
            // 
            // cuenta
            // 
            this.cuenta.HeaderText = "Cuenta";
            this.cuenta.Name = "cuenta";
            // 
            // columna1
            // 
            this.columna1.HeaderText = "";
            this.columna1.Name = "columna1";
            // 
            // columna2
            // 
            this.columna2.HeaderText = "";
            this.columna2.Name = "columna2";
            // 
            // balance_general
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(829, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gpb_periodoContable);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "balance_general";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance General";
            this.Gpb_periodoContable.ResumeLayout(false);
            this.Gpb_periodoContable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_periodoContable;
        private System.Windows.Forms.DateTimePicker Dtp_fechaFinal;
        private System.Windows.Forms.DateTimePicker Dtp_fechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
    }
}