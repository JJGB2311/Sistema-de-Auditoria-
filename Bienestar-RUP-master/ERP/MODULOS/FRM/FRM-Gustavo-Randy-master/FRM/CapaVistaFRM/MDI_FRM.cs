using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;

namespace CapaVistaFRM
{
    public partial class MDI_FRM : Form
    {
        private actualizacion_de_polizas frm_actualizacion_de_polizas;
        private balance_general frm_balance_General;
        private conciliacion_bancaria frm_conciliacion_bancaria;
        private consultar_conciliacion frm_consultar_conciliacion;
        private mantenimiento_modulos frm_mantenimiento_modulos;
        private mantenimiento_bancos frm_mantenimiento_bancos;
        private mantenimiento_chequeras frm_mantenimiento_chequeras;
        private mantenimiento_cuentas_bancarias frm_mantenimiento_cuentas_bancarias;        
        private mantenimiento_monedas frm_mantenimiento_monedas;
        private mov_banc_encabezado frm_mov_banc_encabezado;                
        private revision_presupuestaria frm_revision_presupuestaria;        
        private tipo_de_cambio frm_tipo_de_cambio;
		private mantenimiento_tipos_poliza frm_tipo_poliza;
		private mantenimiento_tipos_cuentas_contables frm_tipo_cuentas_contables;
		private cuentas_contables frm_cuentas_contables;
		private libro_Diario frm_libro_diario;
        private reporteCuentasBancarias frm_reporteCuentasBancarias;

        sentencia sn = new sentencia();
		String usuarioActivo = "rchocm";
        public MDI_FRM()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			usuarioActivo = Lbl_usuario.Text;

		}
        
        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========
        private void frm_balance_General_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_balance_General = null; }
        private void frm_actualizacion_de_polizas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_actualizacion_de_polizas = null; }
        private void frm_conciliacion_bancaria_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_conciliacion_bancaria = null; }
        private void frm_consultar_conciliacion_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_consultar_conciliacion = null; }
        private void frm_mantenimiento_modulos_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_modulos = null; }
        private void frm_mantenimiento_bancos_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_bancos = null; }
        private void frm_mantenimiento_chequeras_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_chequeras = null; } 
        private void frm_mantenimiento_cuentas_bancarias_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_cuentas_bancarias = null; }        
        private void frm_mantenimiento_monedas_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_monedas = null; }
        private void frm_mov_banc_encabezado_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mov_banc_encabezado = null; }
        private void frm_revision_presupuestaria_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_revision_presupuestaria = null; }        
        private void frm_tipo_de_cambio_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_tipo_de_cambio = null; }
		private void frm_tipo_poliza_FormClosed(Object sender, FormClosedEventArgs e)
		{ frm_tipo_poliza = null; }
		private void frm_tipo_cuentas_contables_FormClosed(Object sender, FormClosedEventArgs e)
		{ frm_tipo_cuentas_contables = null; }
		private void frm_cuentas_contables_FormClosed(Object sender, FormClosedEventArgs e)
		{ frm_cuentas_contables = null; }
		private void frm_libro_diario_FormClosed(Object sender, FormClosedEventArgs e)
		{ frm_libro_diario = null; }
        private void frm_reporteCuentasBancarias_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_reporteCuentasBancarias = null; }
        //====================Funciones de declaración de Eventos====================

        private void ConciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            //CONCILICACIÓN BANCARIA
            if (frm_conciliacion_bancaria == null)
            {
                frm_conciliacion_bancaria = new conciliacion_bancaria();
                frm_conciliacion_bancaria.MdiParent = this;
                frm_conciliacion_bancaria.FormClosed += new FormClosedEventHandler(frm_conciliacion_bancaria_FormClosed);
                frm_conciliacion_bancaria.Show();
            }
            else
            {
                frm_conciliacion_bancaria.Activate();
            }
        }

        private void BalanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_balance_General == null)
            {
                frm_balance_General = new balance_general();
                frm_balance_General.MdiParent = this;
                frm_balance_General.FormClosed += new FormClosedEventHandler(frm_balance_General_FormClosed);
                frm_balance_General.Show();
            }
            else
            {
                frm_balance_General.Activate();
            }
        }

        private void TipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TIPO DE CAMBIO
            if (frm_tipo_de_cambio == null)
            {
                frm_tipo_de_cambio = new tipo_de_cambio();
                frm_tipo_de_cambio.MdiParent = this;
                frm_tipo_de_cambio.FormClosed += new FormClosedEventHandler(frm_tipo_de_cambio_FormClosed);
                frm_tipo_de_cambio.Show();
            }
            else
            {
                frm_tipo_de_cambio.Activate();
            }
        }

        private void ActualizaciónDePólizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_actualizacion_de_polizas == null)
            {
                frm_actualizacion_de_polizas = new actualizacion_de_polizas();
                frm_actualizacion_de_polizas.MdiParent = this;
                frm_actualizacion_de_polizas.FormClosed += new FormClosedEventHandler(frm_actualizacion_de_polizas_FormClosed);
                frm_actualizacion_de_polizas.Show();
            }
            else
            {
                frm_actualizacion_de_polizas.Activate();
            }
        }

        private void ConsultarConciliaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CONSULTAR CONCILICACIÓN
            if (frm_consultar_conciliacion == null)
            {
                frm_consultar_conciliacion = new consultar_conciliacion();
                frm_consultar_conciliacion.MdiParent = this;
                frm_consultar_conciliacion.FormClosed += new FormClosedEventHandler(frm_consultar_conciliacion_FormClosed);
                frm_consultar_conciliacion.Show();
            }
            else
            {
                frm_consultar_conciliacion.Activate();
            }
        }

        private void MovimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ENCABEZADO_MOVIMIENTOS_BANCARIOS
            if (frm_mov_banc_encabezado == null)
            {
                frm_mov_banc_encabezado = new mov_banc_encabezado();
                frm_mov_banc_encabezado.MdiParent = this;
                frm_mov_banc_encabezado.FormClosed += new FormClosedEventHandler(frm_mov_banc_encabezado_FormClosed);
                frm_mov_banc_encabezado.Show();
            }
            else
            {
                frm_mov_banc_encabezado.Activate();
            }
        }

        private void RevisiónDePresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (frm_revision_presupuestaria == null)
            {
                frm_revision_presupuestaria = new revision_presupuestaria();
                frm_revision_presupuestaria.MdiParent = this;
                frm_revision_presupuestaria.FormClosed += new FormClosedEventHandler(frm_revision_presupuestaria_FormClosed);
                frm_revision_presupuestaria.Show();
            }
            else
            {
                frm_revision_presupuestaria.Activate();
            }
        }
        
        private void MDI_FRM_Load(object sender, EventArgs e)
        {
            
             frm_login login = new frm_login();
             login.ShowDialog();
             Lbl_usuario.Text = login.obtenerNombreUsuario();
             usuarioActivo = Lbl_usuario.Text;
             //usuarioActivo = "rchocm";
        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SEGURIDAD
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }

        private void Btn_prueba_Click(object sender, EventArgs e)
        {
            //                      Usuario        Mensaje a guardar     Tabla
            sn.insertarBitacora(Lbl_usuario.Text, "Probó la Bitacora", "General");
        }       

		private void LibroDiarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frm_libro_diario == null)
			{
				frm_libro_diario = new libro_Diario(usuarioActivo);
				frm_libro_diario.MdiParent = this;
				frm_libro_diario.FormClosed += new FormClosedEventHandler(frm_libro_diario_FormClosed);
				frm_libro_diario.Show();
			}
			else
			{
				frm_libro_diario.Activate();
			}
		}

		private void TiposDePólizaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frm_tipo_poliza == null)
			{
				frm_tipo_poliza = new mantenimiento_tipos_poliza(usuarioActivo);
				frm_tipo_poliza.MdiParent = this;
				frm_tipo_poliza.FormClosed += new FormClosedEventHandler(frm_tipo_poliza_FormClosed);
				frm_tipo_poliza.Show();
			}
			else
			{
				frm_tipo_poliza.Activate();
			}
		}

		private void TiposDeCuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (frm_tipo_cuentas_contables == null)
			{
				frm_tipo_cuentas_contables = new mantenimiento_tipos_cuentas_contables(usuarioActivo);
				frm_tipo_cuentas_contables.MdiParent = this;
				frm_tipo_cuentas_contables.FormClosed += new FormClosedEventHandler(frm_tipo_cuentas_contables_FormClosed);
				frm_tipo_cuentas_contables.Show();
			}
			else
			{
				frm_tipo_cuentas_contables.Activate();
			}
		}

		private void CuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
		{            
			if (frm_cuentas_contables == null)
			{
				frm_cuentas_contables = new cuentas_contables(usuarioActivo);
				frm_cuentas_contables.MdiParent = this;
				frm_cuentas_contables.FormClosed += new FormClosedEventHandler(frm_cuentas_contables_FormClosed);
				frm_cuentas_contables.Show();
			}
			else
			{
				frm_cuentas_contables.Activate();
			}
		}

        private void CuentasBancariasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CUENTAS BANCARIAS
            if (frm_mantenimiento_cuentas_bancarias == null)
            {
                frm_mantenimiento_cuentas_bancarias = new mantenimiento_cuentas_bancarias(usuarioActivo);
                frm_mantenimiento_cuentas_bancarias.MdiParent = this;
                frm_mantenimiento_cuentas_bancarias.FormClosed += new FormClosedEventHandler(frm_mantenimiento_cuentas_bancarias_FormClosed);
                frm_mantenimiento_cuentas_bancarias.Show();
            }
            else
            {
                frm_mantenimiento_cuentas_bancarias.Activate();
            }
        }

        private void ChequeraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CHEQUERA
            if (frm_mantenimiento_chequeras == null)
            {
                frm_mantenimiento_chequeras = new mantenimiento_chequeras(usuarioActivo);
                frm_mantenimiento_chequeras.MdiParent = this;
                frm_mantenimiento_chequeras.FormClosed += new FormClosedEventHandler(frm_mantenimiento_chequeras_FormClosed);
                frm_mantenimiento_chequeras.Show();
            }
            else
            {
                frm_mantenimiento_chequeras.Activate();
            }
        }

        private void BancosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //BANCOS
            if (frm_mantenimiento_bancos == null)
            {
                frm_mantenimiento_bancos = new mantenimiento_bancos(usuarioActivo);
                frm_mantenimiento_bancos.MdiParent = this;
                frm_mantenimiento_bancos.FormClosed += new FormClosedEventHandler(frm_mantenimiento_bancos_FormClosed);
                frm_mantenimiento_bancos.Show();
            }
            else
            {
                frm_mantenimiento_bancos.Activate();
            }
        }

        private void MódulosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //MÓDULOS
            if (frm_mantenimiento_modulos == null)
            {
                frm_mantenimiento_modulos = new mantenimiento_modulos(usuarioActivo);
                frm_mantenimiento_modulos.MdiParent = this;
                frm_mantenimiento_modulos.FormClosed += new FormClosedEventHandler(frm_mantenimiento_modulos_FormClosed);
                frm_mantenimiento_modulos.Show();
            }
            else
            {
                frm_mantenimiento_modulos.Activate();
            }
        }

        private void MonedasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //MONEDAS
            if (frm_mantenimiento_monedas == null)
            {
                frm_mantenimiento_monedas = new mantenimiento_monedas(usuarioActivo);
                frm_mantenimiento_monedas.MdiParent = this;
                frm_mantenimiento_monedas.FormClosed += new FormClosedEventHandler(frm_mantenimiento_monedas_FormClosed);
                frm_mantenimiento_monedas.Show();
            }
            else
            {
                frm_mantenimiento_monedas.Activate();
            }
        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudaBancos/ayudaBancos.chm", "mdi_bancos.html");
            //Help.ShowHelp(this, "C:/Users/Randy/Desktop/UMG/9.no Semestre/Ingeniería de Software/2do Parcial/Proyecto 2/Software/FRM/CapaVistaFRM/bin/Debug/ayudaBancos/ayudaBancos.chm", "mdi_bancos.html");
        }

        private void PólizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polizas.Polizas poliza = new Polizas.Polizas();
            poliza.MdiParent = this;
            poliza.Show();
            poliza.AsignarQuery(
                "SELECT 'BANCOS' AS Cuenta, (SELECT ROUND(COALESCE(SUM(A.`saldo`),'0'),2) FROM `cuentas_bancarias` A, `modulos` B " +
                "WHERE  A.`estado`=1 AND A.`id_modulo` = B.`id_modulo` AND A.fecha_apertura " +
                "BETWEEN 'FechaI' AND 'FechaF') AS Debe, '0' AS Haber UNION ALL " +
                "SELECT(concat_ws(' ', 'Cuenta No.', cb.no_cuenta_bancaria)) AS Cuenta, ('0') AS Debe, (cb.`saldo`) AS Haber " +
                "FROM cuentas_bancarias cb, modulos md WHERE md.id_modulo = cb.id_modulo AND cb.fecha_apertura " +
                "BETWEEN 'FechaI' AND 'FechaF' AND cb.estado = 1 GROUP BY cb.no_cuenta_bancaria;");
            poliza.AsignarColores(Color.Firebrick, Color.White);
        }

        private void CuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            try
            {
                //REPORTE - CUENTAS BANCARIAS
                if (frm_reporteCuentasBancarias == null)
                {
                    frm_reporteCuentasBancarias = new reporteCuentasBancarias();
                    frm_reporteCuentasBancarias.MdiParent = this;
                    frm_reporteCuentasBancarias.FormClosed += new FormClosedEventHandler(frm_reporteCuentasBancarias_FormClosed);
                    frm_reporteCuentasBancarias.Show();
                }
                else
                {
                    frm_reporteCuentasBancarias.Activate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Abrir el reporte de Cuentas Bancarias", 
                    "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
