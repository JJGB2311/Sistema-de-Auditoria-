namespace CapaVistaFRM
{
    partial class mov_banc_encabezado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mov_banc_encabezado));
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Cbo_cuentaBancaria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_siguiente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gpb_datos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movimientos Bancarios";
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.Cbo_cuentaBancaria);
            this.Gpb_datos.Controls.Add(this.label2);
            this.Gpb_datos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(41, 80);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Size = new System.Drawing.Size(471, 127);
            this.Gpb_datos.TabIndex = 4;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Cbo_cuentaBancaria
            // 
            this.Cbo_cuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_cuentaBancaria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cuentaBancaria.FormattingEnabled = true;
            this.Cbo_cuentaBancaria.Location = new System.Drawing.Point(25, 65);
            this.Cbo_cuentaBancaria.Name = "Cbo_cuentaBancaria";
            this.Cbo_cuentaBancaria.Size = new System.Drawing.Size(416, 29);
            this.Cbo_cuentaBancaria.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cuenta Bancaria que deseamos afectar:";
            // 
            // Btn_siguiente
            // 
            this.Btn_siguiente.BackColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_siguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_siguiente.ForeColor = System.Drawing.Color.Black;
            this.Btn_siguiente.Image = global::CapaVistaFRM.Properties.Resources.search;
            this.Btn_siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_siguiente.Location = new System.Drawing.Point(398, 229);
            this.Btn_siguiente.Name = "Btn_siguiente";
            this.Btn_siguiente.Size = new System.Drawing.Size(130, 47);
            this.Btn_siguiente.TabIndex = 37;
            this.Btn_siguiente.Text = "Siguiente";
            this.Btn_siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_siguiente.UseVisualStyleBackColor = false;
            this.Btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 56);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // mov_banc_encabezado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(549, 288);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_siguiente);
            this.Controls.Add(this.Gpb_datos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mov_banc_encabezado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5220 - Movimientos Bancarios";
            this.Load += new System.EventHandler(this.Mov_banc_encabezado_Load);
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_cuentaBancaria;
        private System.Windows.Forms.Button Btn_siguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}