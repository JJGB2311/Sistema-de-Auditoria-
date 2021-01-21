using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloFRM;
using System.Data.Odbc;

namespace CapaVistaFRM
{
    public partial class mov_banc_encabezado : Form
    {
        private movimientos_bancarios_2 frm_movimientos_bancarios_2;

        movBancarios movBank = new movBancarios();
        String cuentaBank = "";
        public mov_banc_encabezado()
        {
            InitializeComponent();
            llenarCombos();
        }

        private void frm_movimientos_bancarios_2_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_movimientos_bancarios_2 = null; }

        private void Mov_banc_encabezado_Load(object sender, EventArgs e)
        {

        }

        void llenarCombos()
        {
            Cbo_cuentaBancaria.Items.AddRange(movBank.ObtenerCuentasBancarias());
            //Cmb_filtro.Items.AddRange(mod.ObtenerTIposCuentasContables());
        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            if (Cbo_cuentaBancaria.Text == "")
            {
                MessageBox.Show("Seleccione una cuenta", "VERIFICAR " +
                    "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cuentaBank = Cbo_cuentaBancaria.Text;
                //ENCABEZADO_MOVIMIENTOS_BANCARIOS
                if (frm_movimientos_bancarios_2 == null)
                {
                    frm_movimientos_bancarios_2 = new movimientos_bancarios_2(cuentaBank);
                    frm_movimientos_bancarios_2.MdiParent = this.MdiParent;
                    frm_movimientos_bancarios_2.FormClosed += new FormClosedEventHandler(frm_movimientos_bancarios_2_FormClosed);
                    frm_movimientos_bancarios_2.Show();
                }
                else
                {
                    frm_movimientos_bancarios_2.Activate();
                }
            }            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudaBancos/ayudaBancos.chm", "movBankEncab.html");
        }
    }
}
