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
    public partial class FrmCambioLimite : Form
    {
        private frmPanelUsuario frmPanelUsuario;
        private DataBaseConexion conexion;
        private UsuarioModelo usuario;
        public FrmCambioLimite(frmPanelUsuario frmPanelUsuario, DataBaseConexion conexion, UsuarioModelo usuario)
        {
            InitializeComponent();
            this.frmPanelUsuario = frmPanelUsuario;
            this.conexion = conexion;
            this.usuario = usuario;
            tbMonto.Text = usuario.MontoMaximo.ToString();

            
            cbmRetiro.Items.Add(2000);
            cbmRetiro.Items.Add(5000);
           
            if (usuario.MontoMaximo == 2000 || usuario.MontoMaximo == 5000)
            {
                cbmRetiro.SelectedItem = usuario.MontoMaximo;
            }
            else
            {
               
                cbmRetiro.SelectedIndex = 0; 
            }
        }

        private void bt_cambiarLimite_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void b_regresar_Click(object sender, EventArgs e)
        {
            frmPanelUsuario.Show();
            this.Close();
        }

        private void bt_cambiarLimite_Click(object sender, EventArgs e)
        {
            
            int nuevoMonto = (int)cbmRetiro.SelectedItem;

            
            if (nuevoMonto != 2000 && nuevoMonto != 5000)
            {
                MessageBox.Show("La cantidad ingresada no es válida. Solo se aceptan 2000 o 5000.");
                return;
            }

            conexion.ActualizarLimite(usuario.Id, nuevoMonto);
            conexion.InsertarModificacion(usuario.Id, "Cambio de Monto Maximo");
            frmPanelUsuario.Show();
            this.Close();
            MessageBox.Show("Monto máximo modificado con éxito.");
        }
    }

}
