using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using CapaControladorFRM;
using System.Windows.Forms;

namespace CapaControladorFRM
{    
    public class sql_movBancarios
    {
        conexionFRM conn = new conexionFRM();

        public void ejecutarQuery(string query)// ejecuta un query en la BD
        {
            try
            {
                OdbcCommand ejecutar = new OdbcCommand(query, conn.conexion("ERP"));
                ejecutar.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("No se ejecuto el siguiente query: \n " + query + " \n\n Error: "
                    + ex +"", "Error sql-EjecutarQuery");
            }
        }

        public decimal obtenerCargoAbono(string cargoAbono, string idCuenta)
        {
            decimal saldoCuenta = 0;
            int idCuentaBank = Int32.Parse(idCuenta);
            //SELECT COUNT(`monto`) FROM `mov_bancarios` WHERE `id_cuenta_bancaria`=3 AND `cargo_abono`='Cargo' AND `estado`=1 
            OdbcCommand command = new OdbcCommand("SELECT COUNT(`monto`) FROM `mov_bancarios` " +
                "WHERE `id_cuenta_bancaria`=" + idCuentaBank +
                " AND `cargo_abono`='" + cargoAbono + "' AND `estado`=1", conn.conexion("ERP"));
            //SELECT SUM(`monto`) FROM `mov_bancarios` WHERE `id_cuenta_bancaria`=2 AND `cargo_abono`='Cargo' AND `estado`=1
            OdbcCommand command2 = new OdbcCommand("SELECT SUM(`monto`) FROM `mov_bancarios` " +
                "WHERE `id_cuenta_bancaria`=" + idCuentaBank + 
                " AND `cargo_abono`='" + cargoAbono + "' AND `estado`=1", conn.conexion("ERP"));
            //READER
            OdbcDataReader reader = command.ExecuteReader();
            OdbcDataReader reader2 = command2.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = Int32.Parse(reader.GetValue(0).ToString());
            }            
            if (count == 0)
            {
                saldoCuenta = 0;
                return saldoCuenta;
            }
            else
            {
                while (reader2.Read())
                {
                    saldoCuenta = Convert.ToDecimal(reader2.GetValue(0).ToString());
                }
                return saldoCuenta;
            }
        }
        public decimal obtenerDatoApertura(string idCuenta)
        {
            decimal saldoCuenta = 0;
            int idCuentaBank = Int32.Parse(idCuenta);
            OdbcCommand command = new OdbcCommand("SELECT `saldo` FROM `mov_bancarios` " +
                "WHERE `id_cuenta_bancaria`=" + idCuentaBank + " AND `estado`=1", conn.conexion("ERP"));
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                saldoCuenta = Convert.ToDecimal(reader.GetValue(0).ToString());
            }
            return saldoCuenta;
        }
        public decimal obtenerDatoSaldoCuenta(string idCuenta)
        {
            decimal saldoCuenta = 0;
            int idCuentaBank = Int32.Parse(idCuenta);
            OdbcCommand command = new OdbcCommand("SELECT `saldo` FROM `cuentas_bancarias` WHERE `id_cuenta_bancaria`= " 
                + idCuentaBank + " AND estado=1;", conn.conexion("ERP"));
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                saldoCuenta = Convert.ToDecimal(reader.GetValue(0).ToString());
            }
            return saldoCuenta;
        }
        public string obtenerDatoMoneda(string idCuenta)
        {
            string nombreMoneda = "";
            int idCuentaBank = Int32.Parse(idCuenta);
            OdbcCommand command = new OdbcCommand("SELECT A.`moneda` FROM `monedas` A, `cuentas_bancarias` B " +
                "WHERE B.`id_cuenta_bancaria` = " + idCuentaBank + " AND (A.`id_moneda`) = (B.`id_moneda`) " +
                "AND B.`estado`=1;", conn.conexion("ERP"));
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nombreMoneda = reader.GetValue(0).ToString();
            }
            return nombreMoneda;
        }

        public string llenarComboCuentasBancarias()
        {
            string Combo = "";
            int numeroFIlas = 0;
            OdbcCommand command = new OdbcCommand("SELECT A.`id_cuenta_bancaria`, A.`no_cuenta_bancaria`, " +
                "B.`nombre` FROM `cuentas_bancarias` A, `modulos` B " +
                "WHERE (A.`id_modulo`) = (B.`id_modulo`) AND A.`estado`=1;", conn.conexion("ERP"));
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
                        Combo += reader2.GetValue(0).ToString() + " - " + reader2.GetValue(1).ToString()
                            + " - " + reader2.GetValue(2).ToString();
                        /* MessageBox.Show("Dato: " + reader2.GetValue(0).ToString() + " - "
                            + reader2.GetValue(1).ToString() + " - " + reader2.GetValue(2).ToString(), "Dato IF"); */
                    }
                    else
                    {
                        Combo += reader2.GetValue(0).ToString() + " - " + reader2.GetValue(1).ToString()
                            + " - " + reader2.GetValue(2).ToString() + ",";
                        /* MessageBox.Show("Dato: " + reader2.GetValue(0).ToString() + " - "
                            + reader2.GetValue(1).ToString() + " - " + reader2.GetValue(2).ToString(), "Dato ELSE"); */
                    }
                }
            }
            else
            {
                Combo = "No Hay Registros";
            }

            return Combo;
        }
        public string llenarComboBancos()
        {
            string Combo = "";
            int numeroFIlas = 0;
            OdbcCommand command = new OdbcCommand("SELECT `id_banco`, `nombre_banco` " +
                "FROM `bancos` WHERE estado=1;", conn.conexion("ERP"));
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
                        Combo += reader2.GetValue(0).ToString() + " - " + reader2.GetValue(1).ToString();
                        /* MessageBox.Show("Dato: " + reader2.GetValue(0).ToString() + " - " 
                            + reader2.GetValue(1).ToString(), "Dato IF"); */
                    }
                    else
                    {
                        Combo += reader2.GetValue(0).ToString() + " - " + reader2.GetValue(1).ToString() + ",";
                        /* MessageBox.Show("Dato: " + reader2.GetValue(0).ToString() + " - " 
                            + reader2.GetValue(1).ToString(), "Dato ELSE"); */
                    }
                }
            }
            else
            {
                Combo = "No Hay Registros";
            }

            return Combo;
        }

        public OdbcDataAdapter LlenarTablaDetalleMov(String idCuentaBank)
        {
            string sql = "SELECT `id_mov`, `tipo_mov`, `beneficiario`, `descripcion`, `cargo_abono`, " +
                "`monto`, `saldo` FROM `mov_bancarios` WHERE `id_cuenta_bancaria`='" + idCuentaBank + "' AND `estado`=1";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn.conexion("ERP"));
            return dataTable;
        }
    }
}
