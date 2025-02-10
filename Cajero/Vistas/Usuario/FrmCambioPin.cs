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
using UsuarioModelo = Cajero.Modelos.Usuario;
namespace Cajero.Vistas
{
    public partial class FrmCambioPin : Form
    {
        private frmPanelUsuario frmPanelUsuario;
        private DataBaseConexion conexion;
        private UsuarioModelo usuario;
        public FrmCambioPin(frmPanelUsuario frmPanelUsuario, DataBaseConexion conexion, UsuarioModelo usuario)
        {
            InitializeComponent();
            this.frmPanelUsuario = frmPanelUsuario;
            this.conexion = conexion;
            this.usuario = usuario;
        }

        private void tbPinNuevo1_TextChanged(object sender, EventArgs e)
        {
            if (tbPinNuevo1.Text.Length > 4)
            {
                tbPinNuevo1.Text = tbPinNuevo1.Text.Substring(0, 4);
                tbPinNuevo1.SelectionStart = tbPinNuevo1.Text.Length;
            }
        }

        private void tbPinNuevo2_TextChanged(object sender, EventArgs e)
        {
            if (tbPinNuevo2.Text.Length > 4)
            {
                tbPinNuevo2.Text = tbPinNuevo2.Text.Substring(0, 4);
                tbPinNuevo2.SelectionStart = tbPinNuevo2.Text.Length;
            }
        }

        private void tbPin_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbPinActual_TextChanged(object sender, EventArgs e)
        {
            if (tbPinActual.Text.Length > 4)
            {
                tbPinActual.Text = tbPinActual.Text.Substring(0, 4);
                tbPinActual.SelectionStart = tbPinActual.Text.Length;
            }
        }

        private void b_regresar_Click(object sender, EventArgs e)
        {
            frmPanelUsuario.Show();
            this.Close();
        }

        private void bt_cambiarPin_Click(object sender, EventArgs e)
        {
            if (usuario.Pin == tbPinActual.Text)
            {
                if (tbPinActual.Text == tbPinNuevo1.Text && tbPinActual.Text == tbPinNuevo1.Text)
                {
                    MessageBox.Show("El nuevo PIN debe ser diferente al anterior");
                }
                else if (tbPinNuevo1.Text == tbPinNuevo2.Text)
                {
                    conexion.ActualizarPin(usuario.Id, tbPinNuevo1.Text);
                    conexion.InsertarModificacion(usuario.Id, "Cambio de PIN");
                    frmPanelUsuario.Show();
                    this.Close();
                    MessageBox.Show("El PIN fue modificado exitosamente");

                }
                else
                {
                    MessageBox.Show("El PIN nuevo no coinciden");
                }
            }
            else
            {
                MessageBox.Show("El PIN actual es incorrecto");
            }
        }


    }
}
