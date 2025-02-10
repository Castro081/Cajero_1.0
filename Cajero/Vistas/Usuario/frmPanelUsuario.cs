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
using UsuarioModel = Cajero.Modelos.Usuario;
using CajeroM = Cajero.Modelos.Cajero;
namespace Cajero.Vistas
{
    public partial class frmPanelUsuario : Form
    {
        private frmLogin frmLogin;
        private UsuarioModel usuario;
        private DataBaseConexion conexion;
        private CajeroM cajero;


        public frmPanelUsuario(frmLogin frmLogin, DataBaseConexion conexion, UsuarioModel usuario, CajeroM cajero)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.frmLogin = frmLogin;
            this.usuario = usuario;
            this.cajero = cajero;
            label_bienvenida.Text = $"Bienvenido\n {usuario.Nombre} {usuario.Apellido}";
        }


        private void b_retiros_Click(object sender, EventArgs e)
        {
            this.usuario = conexion.ObtenerCuenta(usuario.Id);
            frmRetiros retirosForm = new frmRetiros(this, conexion, usuario, cajero);
            retirosForm.Show();
            this.Hide();
        }

        private void b_depositos_Click(object sender, EventArgs e)
        {
            this.usuario = conexion.ObtenerCuenta(usuario.Id);
            frmDepositos depositosForm = new frmDepositos(this, conexion, usuario, cajero);
            depositosForm.Show();
            this.Hide();
        }

        private void b_saldo_Click(object sender, EventArgs e)
        {
            this.usuario = conexion.ObtenerCuenta(usuario.Id);
            frmConsultaSaldo saldoForm = new frmConsultaSaldo(this, usuario);
            saldoForm.Show();
            this.Hide();
        }

        private void b_movimientos_Click(object sender, EventArgs e)
        {
            this.usuario = conexion.ObtenerCuenta(usuario.Id);
            frmMovimientos movimientosForm = new frmMovimientos(this, conexion, usuario);
            movimientosForm.Show();
            this.Hide();
        }

        private void b_monto_Click(object sender, EventArgs e)
        {
            this.usuario = conexion.ObtenerCuenta(usuario.Id);
            FrmCambioLimite cambioLimiteForm = new FrmCambioLimite(this, conexion, usuario);
            cambioLimiteForm.Show();
            this.Hide();
        }

        private void b_cambio_pin_Click(object sender, EventArgs e)
        {
            this.usuario = conexion.ObtenerCuenta(usuario.Id);
            FrmCambioPin cambioPinForm = new FrmCambioPin(this, conexion, usuario);
            cambioPinForm.Show();
            this.Hide();
        }

        private void b_regresar_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            frmLogin.limpiarCampos();
            this.Close();
        }
    }
}