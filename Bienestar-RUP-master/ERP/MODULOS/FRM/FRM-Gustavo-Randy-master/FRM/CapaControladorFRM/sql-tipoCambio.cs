using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using CapaControladorFRM;
using System.Windows.Forms;
using System.Net;

namespace CapaControladorFRM
{
    public class sql_tipoCambio
    {
        conexionFRM conn = new conexionFRM();

        public string obtenerTipoCambio(string sMonedaBase, string sMonedaObjetivo)
        {
            string url = "https://free.currconv.com/api/v7/convert?q=" + sMonedaBase + "_" + sMonedaObjetivo + "&compact=ultra&apiKey=e9c22965a0221aae8dfe";
            var json = new WebClient().DownloadString(url);

            string sJSon = json.ToString();

            int pFrom = sJSon.IndexOf(":") + ":".Length;
            int pTo = sJSon.LastIndexOf("}");

            String result = sJSon.Substring(pFrom, pTo - pFrom).Trim();
            /*
            string fecha = DateTime.Now.ToString("yyy/MM/dd");
            try
            {
                OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_tipocambio VALUES ('"
                    + sMonedaBase + "' ,'" + sMonedaObjetivo + "' , " + result + " , '" +
                    fecha + "')", conn.conexion("ERP"));
                sql.ExecuteNonQuery();
                sql.Connection.Close();
            }
            catch (Exception ex)
            {                
                MessageBox.Show("No se pudo Obtener el Tipo de Cambio. \n\n Error: "
                    + ex + "", "TIPO DE CAMBIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */
            return result;
        }

        public string llenarComboCuentasBancarias()
        {
            string Combo = "";
            int numeroFIlas = 0;
            OdbcCommand command = new OdbcCommand("SELECT `moneda` FROM `monedas` " +
                "WHERE `estado`=1 ", conn.conexion("ERP"));
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    numeroFIlas++;
                }
                reader.Close();
                OdbcDataReader reader2 = command.ExecuteReader();
                for (int i = 0; i < numeroFIlas; i++)
                {
                    reader2.Read();
                    if (i == numeroFIlas - 1)
                    {
                        Combo += reader2.GetValue(0).ToString();
                        //MessageBox.Show("Dato: " + reader2.GetValue(0).ToString(), "Dato IF");
                    }
                    else
                    {
                        Combo += reader2.GetValue(0).ToString() + ",";
                        //MessageBox.Show("Dato: " + reader2.GetValue(0).ToString(), "Dato ELSE");
                    }
                }
            }
            else
            {
                Combo = "No Hay Registros";
            }
            return Combo;
        }

    }
}
