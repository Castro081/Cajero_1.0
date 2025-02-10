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

namespace Cajero.Vistas.Usuario
{
    public partial class frmPrimerInicio : Form
    {
        private UsuarioModel usuario;
        private DataBaseConexion conexion;
        private frmLogin frmLogin;
        private CajeroM cajero;

        public frmPrimerInicio(frmLogin frmLogin, DataBaseConexion conexion, UsuarioModel usuario, CajeroM cajero)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            this.conexion = conexion;
            this.usuario = usuario;
            this.cajero = cajero;
            this.label_bienvenida.Text = $"Bienvenido/a {usuario.Nombre}. Por favor, cambie su PIN";
        }
        private void tbPin1_TextChanged(object sender, EventArgs e)
        {
            if (tbPin1.Text.Length > 4)
            {
                tbPin1.Text = tbPin1.Text.Substring(0, 4);
                tbPin1.SelectionStart = tbPin1.Text.Length;
            }
        }

        private void tbPin2_TextChanged(object sender, EventArgs e)
        {
            if (tbPin2.Text.Length > 4)
            {
                tbPin2.Text = tbPin2.Text.Substring(0, 4);
                tbPin2.SelectionStart = tbPin2.Text.Length;
            }
        }
        private void tbPin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void tbPin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            if (tbPin1.Text.Length < 4 || tbPin1.Text.Length < 4)
            {
                MessageBox.Show("El Pin debe ser de 4 digitos");
                return;
            }
            if (tbPin1.Text == tbPin2.Text)
            {
                conexion.ActualizarPin(usuario.Id, tbPin1.Text);
                conexion.InsertarModificacion(usuario.Id, "Cambio de PIN");
                conexion.ActualizarPrimerInicio(usuario.Id);
                frmPanelUsuario panelUsuario = new frmPanelUsuario(frmLogin, conexion, usuario, cajero);
                panelUsuario.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("El PIN no coincide");
            }
        }
    }
}
