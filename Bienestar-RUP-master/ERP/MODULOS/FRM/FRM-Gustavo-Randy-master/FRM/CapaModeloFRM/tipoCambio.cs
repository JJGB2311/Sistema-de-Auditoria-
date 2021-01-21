using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorFRM;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloFRM
{
    public class tipoCambio
    {
        sql_tipoCambio sql = new sql_tipoCambio();

        public string consultarTipoCambio(string sMonedaBase, string sMonedaObjetivo)
        {
            string resultado = "";
            try
            {
                resultado = sql.obtenerTipoCambio(sMonedaBase, sMonedaObjetivo);
                //MessageBox.Show("Resultado: " + resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pudo Consultar el Tipo de Cambio. \n El servidor no responde. ", 
                    "TIPO DE CAMBIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        public string[] ObtenerTipoCambio()
        {
            string[] tipos = sql.llenarComboCuentasBancarias().Split(',');
            return tipos;
        }

    }
}
