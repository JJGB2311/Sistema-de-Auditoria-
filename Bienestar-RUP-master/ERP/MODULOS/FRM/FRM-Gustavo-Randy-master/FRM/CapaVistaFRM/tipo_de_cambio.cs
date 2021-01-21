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
    public partial class tipo_de_cambio : Form
    {
        tipoCambio tipoCam = new tipoCambio();
        string[] tipoCambio1;
        string[] tipoCambio2;
        public tipo_de_cambio()
        {
            InitializeComponent();
            llenarCombos();
        }

        void llenarCombos()
        {
            Cbo_monedaBase.Items.AddRange(tipoCam.ObtenerTipoCambio());
            Cbo_monedaObjetivo.Items.AddRange(tipoCam.ObtenerTipoCambio());
        }

        public string consultarTipoCambio(string sMonedaBase, string sMonedaObjetivo)
        {            
            string resultado = "";
            resultado = tipoCam.consultarTipoCambio(sMonedaBase, sMonedaObjetivo);
            return resultado;
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            //Separamos el codigo de moneda del resto del texto
            tipoCambio1 = Cbo_monedaBase.Text.Split('-');
            tipoCambio2 = Cbo_monedaObjetivo.Text.Split('-');            

            //Verificamos que el usuario llene los 2 ComboBox
            if (Cbo_monedaBase.SelectedItem == null || Cbo_monedaObjetivo.SelectedItem == null || 
                Cbo_monedaBase.Text == "" || Cbo_monedaObjetivo.Text == "")
            {
                MessageBox.Show(" Debe seleccionar un opción! ",
                    "SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Lbl_resultado.Text = consultarTipoCambio(tipoCambio1[0], tipoCambio2[0]);                
            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {            
            Help.ShowHelp(this, "ayudaBancos/ayudaBancos.chm", "tipoDeCambio.html");
        }
    }
}
