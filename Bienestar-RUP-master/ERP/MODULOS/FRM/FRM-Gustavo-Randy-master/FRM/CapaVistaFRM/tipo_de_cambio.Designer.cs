namespace CapaVistaFRM
{
    partial class tipo_de_cambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipo_de_cambio));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_monedaBase = new System.Windows.Forms.ComboBox();
            this.Cbo_monedaObjetivo = new System.Windows.Forms.ComboBox();
            this.Gpb_consultar = new System.Windows.Forms.GroupBox();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Gpb_cambioAlDia = new System.Windows.Forms.GroupBox();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Gpb_consultar.SuspendLayout();
            this.Gpb_cambioAlDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "De: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "A: ";
            // 
            // Cbo_monedaBase
            // 
            this.Cbo_monedaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_monedaBase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_monedaBase.FormattingEnabled = true;
            this.Cbo_monedaBase.Location = new System.Drawing.Point(54, 39);
            this.Cbo_monedaBase.Name = "Cbo_monedaBase";
            this.Cbo_monedaBase.Size = new System.Drawing.Size(224, 29);
            this.Cbo_monedaBase.TabIndex = 4;
            // 
            // Cbo_monedaObjetivo
            // 
            this.Cbo_monedaObjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_monedaObjetivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_monedaObjetivo.FormattingEnabled = true;
            this.Cbo_monedaObjetivo.Location = new System.Drawing.Point(54, 94);
            this.Cbo_monedaObjetivo.Name = "Cbo_monedaObjetivo";
            this.Cbo_monedaObjetivo.Size = new System.Drawing.Size(224, 29);
            this.Cbo_monedaObjetivo.TabIndex = 5;
            // 
            // Gpb_consultar
            // 
            this.Gpb_consultar.Controls.Add(this.Btn_consultar);
            this.Gpb_consultar.Controls.Add(this.Cbo_monedaBase);
            this.Gpb_consultar.Controls.Add(this.label2);
            this.Gpb_consultar.Controls.Add(this.Cbo_monedaObjetivo);
            this.Gpb_consultar.Controls.Add(this.label3);
            this.Gpb_consultar.Location = new System.Drawing.Point(29, 80);
            this.Gpb_consultar.Name = "Gpb_consultar";
            this.Gpb_consultar.Size = new System.Drawing.Size(301, 204);
            this.Gpb_consultar.TabIndex = 7;
            this.Gpb_consultar.TabStop = false;
            this.Gpb_consultar.Text = "Consulta";
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
            this.Btn_consultar.Location = new System.Drawing.Point(84, 150);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(130, 37);
            this.Btn_consultar.TabIndex = 6;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Gpb_cambioAlDia
            // 
            this.Gpb_cambioAlDia.Controls.Add(this.Lbl_resultado);
            this.Gpb_cambioAlDia.Location = new System.Drawing.Point(357, 80);
            this.Gpb_cambioAlDia.Name = "Gpb_cambioAlDia";
            this.Gpb_cambioAlDia.Size = new System.Drawing.Size(170, 204);
            this.Gpb_cambioAlDia.TabIndex = 8;
            this.Gpb_cambioAlDia.TabStop = false;
            this.Gpb_cambioAlDia.Text = "Cambio al día";
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.AutoSize = true;
            this.Lbl_resultado.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_resultado.Location = new System.Drawing.Point(24, 88);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(98, 32);
            this.Lbl_resultado.TabIndex = 0;
            this.Lbl_resultado.Text = "0.0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 59);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(852, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de Cambio";
            // 
            // tipo_de_cambio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(548, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gpb_cambioAlDia);
            this.Controls.Add(this.Gpb_consultar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tipo_de_cambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5221 - Tipo de Cambio";
            this.Gpb_consultar.ResumeLayout(false);
            this.Gpb_consultar.PerformLayout();
            this.Gpb_cambioAlDia.ResumeLayout(false);
            this.Gpb_cambioAlDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_monedaBase;
        private System.Windows.Forms.ComboBox Cbo_monedaObjetivo;
        private System.Windows.Forms.GroupBox Gpb_consultar;
        private System.Windows.Forms.GroupBox Gpb_cambioAlDia;
        private System.Windows.Forms.Label Lbl_resultado;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}