using Cajero.Conexion;
using Cajero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioM = Cajero.Modelos.Usuario;

namespace Cajero.Vistas
{
    public partial class frmMovimientos : Form
    {
        private frmPanelUsuario frmPanelUsuario;
        private DataBaseConexion conexion;
        private UsuarioM usuario;
        private List<Transaccion> transacciones;

        public frmMovimientos(frmPanelUsuario frmPanelUsuario, DataBaseConexion conexion, UsuarioM usuario)
        {
            InitializeComponent();
            this.frmPanelUsuario = frmPanelUsuario;
            this.conexion = conexion;
            this.usuario = usuario;
            this.transacciones = conexion.ObtenerTransaccionesPorCuenta(usuario.Id);
            ConfigurarControles();
            MostrarMovimientos();
        }

        private void ConfigurarControles()
        {
            tb_depositos.ReadOnly = true;
            tb_retiros.ReadOnly = true;
            tb_depositos.Multiline = true;
            tb_retiros.Multiline = true;
            tb_depositos.ScrollBars = ScrollBars.Vertical;
            tb_retiros.ScrollBars = ScrollBars.Vertical;
        }

        private void b_regresar_Click(object sender, EventArgs e)
        {
            frmPanelUsuario.Show();
            this.Close();
        }

        private void MostrarMovimientos()
        {
            tb_depositos.Clear();
            tb_retiros.Clear();

            foreach (var transaccion in transacciones)
            {
                if (transaccion.TipoTransaccion == "Deposito")
                {
                    tb_depositos.AppendText(FormatearTexto(transaccion, transaccion.Monto, "+"));
                }
                else if (transaccion.TipoTransaccion == "Retiro")
                {
                    tb_retiros.AppendText(FormatearTexto(transaccion, transaccion.Monto, "-"));
                }
            }
        }


        private string FormatearTexto(Transaccion transaccion, int monto, string TipoTransaccion)
        {
            return $"- No. de Referencia: {transaccion.Id.ToString("D5")} {Environment.NewLine}" +
                   $"\tFecha: {transaccion.FechaTransaccion} {Environment.NewLine}" +
                   $"\tMonto: ({TipoTransaccion}) GTQ {monto.ToString("N2")} {Environment.NewLine}";
        }
    }
}