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
    public partial class movimientos_bancarios : Form
    {
        movBancarios movBank = new movBancarios();

        public movimientos_bancarios()
        {
            InitializeComponent();
            llenarCombos();

        }
        void llenarCombos()
        {            
            Cbo_banco.Items.AddRange(movBank.ObtenerBancos());
            //Cmb_filtro.Items.AddRange(mod.ObtenerTIposCuentasContables());
        }
        //Txt_documento
    }
}
