using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorFRM;
using System.Data.Odbc;

namespace CapaModeloFRM
{
    public class movBancarios
    {
        sql_movBancarios sql = new sql_movBancarios();
        decimal saldoActual = 0;
        String auxCuentaBancaria = "";

        public decimal ObtenerCargoAbono(string cargoAbono, string cuenta)
        {
            decimal id = sql.obtenerCargoAbono(cargoAbono, cuenta);
            return id;
        }
        public decimal ObtenerDatoApertura(string name)
        {
            decimal id = sql.obtenerDatoApertura(name);
            return id;
        }
        public decimal ObtenerSaldoCuenta(string name)
        {
            decimal id = sql.obtenerDatoSaldoCuenta(name);
            return id;
        }
        public string ObtenerMoneda(string name)
        {
            string id = sql.obtenerDatoMoneda(name);
            return id;
        }
        public string[] ObtenerCuentasBancarias()
        {
            string[] tipos = sql.llenarComboCuentasBancarias().Split(',');
            return tipos;
        }
        public string[] ObtenerBancos()
        {
            string[] tipos = sql.llenarComboBancos().Split(',');            
            return tipos;
        }

        public void AperturaDetalleMov(string cuentaBancariaA, decimal saldoAnteriorA)
        {                        
            //INSERT INTO `mov_bancarios`(`id_mov`, `id_cuenta_bancaria`, `tipo_mov`, `no_referencia`, 
            //`beneficiario`, `descripcion`, `cargo_abono`, `monto`, `saldo`) 
            //VALUES (1, '1', 'Deposito', '000001', 'Apertura', 'Apertura de Cuenta', 'Abono', 700, 700);;
            string query = "INSERT INTO `mov_bancarios`(`id_cuenta_bancaria`, `tipo_mov`, `no_referencia`, `beneficiario`, `descripcion`, `cargo_abono`, `monto`, `saldo`) " +
                "VALUES ('" + cuentaBancariaA + "', 'Deposito', '000001', 'Apertura', 'Apertura de Cuenta', 'Abono', " + saldoAnteriorA + ", " + saldoAnteriorA + ");";
            sql.ejecutarQuery(query);
        }

        public void GuardarDetalleMov(string cuentaBancaria, string tipo_mov, string no_referencia, string beneficiario, string descrip, string cargoAbono, decimal monto, decimal saldoAnterior)
        {
            auxCuentaBancaria = cuentaBancaria;
            if (cargoAbono == "Cargo")
            {
                saldoActual = saldoAnterior - monto;
            }
            else if (cargoAbono == "Abono")
            {
                saldoActual = saldoAnterior + monto;
            }

            //INSERT INTO `mov_bancarios`(`id_mov`, `id_cuenta_bancaria`, `tipo_mov`, `no_referencia`, `beneficiario`, `descripcion`, `cargo_abono`, `monto`, `saldo`) 
            //VALUES (1, 1, 'Deposito', 'A-2030', 2, 'Traslado de fondos', 'Cargo', 200, 800);
            string query = "INSERT INTO `mov_bancarios`(`id_cuenta_bancaria`, `tipo_mov`, `no_referencia`, `beneficiario`, `descripcion`, `cargo_abono`, `monto`, `saldo`) " +
                "VALUES ('" + cuentaBancaria + "', '" + tipo_mov + "', '" + no_referencia + "', '" + beneficiario + "', '" + descrip + "', '" + cargoAbono + "', " + monto +", " + saldoActual + ")";
            sql.ejecutarQuery(query);
        }

        public void ModificarDetalleMov()
        {
            string query = "UPDATE `cuentas_bancarias` SET `saldo`=" + saldoActual + " " +
                "WHERE `id_cuenta_bancaria`='" + auxCuentaBancaria + "' AND estado=1;";
            sql.ejecutarQuery(query);
        }
        public void Borrar(string id)
        {
            string query = "DELETE FROM cuentas WHERE id_cuenta='" + id + "'";
            sql.ejecutarQuery(query);
        }

        public OdbcDataAdapter llenarDetalleMov(String idCuentaBank)
        {
            OdbcDataAdapter dataTable = sql.LlenarTablaDetalleMov(idCuentaBank);
            return dataTable;
        }

    }
}
