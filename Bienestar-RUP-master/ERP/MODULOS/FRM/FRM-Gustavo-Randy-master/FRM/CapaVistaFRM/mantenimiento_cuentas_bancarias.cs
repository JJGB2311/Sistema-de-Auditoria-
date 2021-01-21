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
    public partial class mantenimiento_cuentas_bancarias : Form
    {
        string usuario = "";        
        public mantenimiento_cuentas_bancarias(String usuarioActivo)
        {
            InitializeComponent();
            usuario = usuarioActivo;
            string[] alias = { "Cod Cuenta Bancaria", "Cod Banco", "No. Cuenta", "Propietario", "Fecha Apertura", "Moneda", "Saldo", "Estado"}; // Arreglo de nombres para campos
            navegador1.asignarAlias(alias); // Asignar nombres
            navegador1.asignarSalida(this); // Asignar form de salida
            Color nuevoColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"); // Deficion de 
            navegador1.asignarColorFondo(nuevoColor);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1"); // asignar 1 por defecto 
            // LOS COMBOS SE ASIGNAN SEGUN EL ORDEN EN QUE SE DECLAREN
            // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id
            navegador1.asignarComboConTabla("bancos", "nombre_banco", 1); 
            navegador1.asignarComboConTabla("modulos", "nombre", 1); 
            navegador1.asignarComboConTabla("monedas", "moneda", 1); 
            navegador1.asignarTabla("cuentas_bancarias"); // tabla principal
            navegador1.asignarNombreForm("Cuentas Bancarias"); // Titulo y nombre del form
        }

        private void Navegador1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario); // Pasa el parametro del usuario
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva); // Consulta permisos al iniciar
            navegador1.ObtenerIdAplicacion(aplicacionActiva);// Pasa el id de la aplicacion actual
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudaBancos/ayudaBancos.chm", "cuentasBancarias.html");
        }
    }
}
