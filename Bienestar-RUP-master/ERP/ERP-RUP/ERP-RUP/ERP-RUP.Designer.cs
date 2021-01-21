namespace ERP_RUP
{
	partial class ERP_RUP
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ERP_RUP));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.hRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cONTABILIDADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bANCOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mRPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.White;
			this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hRMToolStripMenuItem,
            this.fRMToolStripMenuItem,
            this.sCMToolStripMenuItem,
            this.mRPToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
			this.menuStrip.Size = new System.Drawing.Size(948, 35);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// hRMToolStripMenuItem
			// 
			this.hRMToolStripMenuItem.Name = "hRMToolStripMenuItem";
			this.hRMToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
			this.hRMToolStripMenuItem.Text = "HRM";
			this.hRMToolStripMenuItem.Click += new System.EventHandler(this.HRMToolStripMenuItem_Click);
			// 
			// fRMToolStripMenuItem
			// 
			this.fRMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONTABILIDADToolStripMenuItem,
            this.bANCOSToolStripMenuItem});
			this.fRMToolStripMenuItem.Name = "fRMToolStripMenuItem";
			this.fRMToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
			this.fRMToolStripMenuItem.Text = "FRM";
			this.fRMToolStripMenuItem.Click += new System.EventHandler(this.FRMToolStripMenuItem_Click);
			// 
			// cONTABILIDADToolStripMenuItem
			// 
			this.cONTABILIDADToolStripMenuItem.Name = "cONTABILIDADToolStripMenuItem";
			this.cONTABILIDADToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
			this.cONTABILIDADToolStripMenuItem.Text = "CONTABILIDAD";
			this.cONTABILIDADToolStripMenuItem.Click += new System.EventHandler(this.CONTABILIDADToolStripMenuItem_Click);
			// 
			// bANCOSToolStripMenuItem
			// 
			this.bANCOSToolStripMenuItem.Name = "bANCOSToolStripMenuItem";
			this.bANCOSToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
			this.bANCOSToolStripMenuItem.Text = "BANCOS";
			this.bANCOSToolStripMenuItem.Click += new System.EventHandler(this.BANCOSToolStripMenuItem_Click);
			// 
			// sCMToolStripMenuItem
			// 
			this.sCMToolStripMenuItem.Name = "sCMToolStripMenuItem";
			this.sCMToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
			this.sCMToolStripMenuItem.Text = "SCM";
			this.sCMToolStripMenuItem.Click += new System.EventHandler(this.SCMToolStripMenuItem_Click);
			// 
			// mRPToolStripMenuItem
			// 
			this.mRPToolStripMenuItem.Name = "mRPToolStripMenuItem";
			this.mRPToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
			this.mRPToolStripMenuItem.Text = "MRP";
			this.mRPToolStripMenuItem.Click += new System.EventHandler(this.MRPToolStripMenuItem_Click);
			// 
			// ERP_RUP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::ERP_RUP.Properties.Resources.LOGO_BIENESTAR_2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(948, 662);
			this.Controls.Add(this.menuStrip);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ERP_RUP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ERP BIENESTAR";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ERP_RUP_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripMenuItem hRMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mRPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sCMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fRMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cONTABILIDADToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bANCOSToolStripMenuItem;
	}
}



