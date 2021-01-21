using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaFRM
{
    public partial class conciliacion_bancaria : Form
    {
        public conciliacion_bancaria()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_abrirEstadoDeCuenta_Click(object sender, EventArgs e)
        {
            //La idea de usar Adobe Reader salio del siguiente video:
            // https://www.youtube.com/watch?v=H8z8TbpkX5U 
            /*/
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Abrir Estado de Cuenta";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Pdf Files|*.pdf";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                pdfEstadoCuenta.src = fdlg.FileName;
                //s.insertarBitacora(sUsuario, "Cargo un estado de cuenta", "tbl_conciliacion_bancaria_encabezado");
            }
            /*/
        }
    }
}
