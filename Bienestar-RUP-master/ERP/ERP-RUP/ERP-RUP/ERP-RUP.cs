using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaCONTA;
using CapaVistaSCM;
using CapaVistaMRP;
using CapaVistaHRM;
using CapaVistaFRM;

namespace ERP_RUP
{
	public partial class ERP_RUP : Form
	{
		private int childFormNumber = 0;

		public ERP_RUP()
		{
			InitializeComponent();
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Ventana " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void ERP_RUP_Load(object sender, EventArgs e)
		{

		}

		private void HRMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_HRM hrm = new MDI_HRM();
			hrm.Show();
		}

		private void FRMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void MRPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_MRP mrp = new MDI_MRP();
			mrp.Show();
		}

		private void SCMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_SCM scm = new MDI_SCM();
			scm.Show();
		}

		private void CONTABILIDADToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_CONTA conta = new MDI_CONTA();
			conta.Show();
		}

		private void BANCOSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MDI_FRM conta = new MDI_FRM();
			conta.Show();
		}
	}
}
