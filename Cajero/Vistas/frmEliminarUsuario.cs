// -----------------------------------------------------Dependencias-----------------------------------------------------------
using Cajero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioM = Cajero.Modelos.Usuario;
using Cajero.Conexion;
namespace Cajero.Vistas
{
    public partial class frmEliminarUsuario : Form
    {
        // -----------------------------------------------------Campos Privados-----------------------------------------------------------
        private Datos datos;
        private DataBaseConexion db;
        // -----------------------------------------------------Constructor-----------------------------------------------------------
        public frmEliminarUsuario(Datos datos)
        {
            InitializeComponent();
            this.datos = datos;
            db = new DataBaseConexion();
            DesactivarCampos();
        }


        // -----------------------------------------------------Eventos de Botones-----------------------------------------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string noCuenta = txtCuenta.Text.Trim();

            UsuarioM usuario = db.ObtenerCuentaPorNumero(noCuenta);

            if (usuario != null)
            {
                try
                {
                    db.Desactivar(usuario.Id, false);
                    MessageBox.Show("Cuenta desactivada con éxito.");

                    int idUsuario = 1;
                    string descripcionBitacora = $"Cuenta desactivada.";

                    string resultadoBitacora = db.InsertarBitacora(usuario.Id, descripcionBitacora, idUsuario);
                    MessageBox.Show(resultadoBitacora);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: no se pudo desactivar la cuenta. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cuenta no encontrada.");
            }

            LimpiarCampos();
            ActivarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string noCuenta = txtBuscar2.Text.Trim();

            if (!ValidarCuenta(noCuenta))
                return;

            UsuarioM usuario = db.ObtenerCuentaPorNumero(noCuenta);

            if (usuario != null && usuario.Estado) 

                {

                    DesactivarCampos();
                    MostrarDatosUsuario(usuario); 
                    txtBuscar2.Text = "";
                    MessageBox.Show("Usuario encontrado.");

                }

            else

                {
               
                    MessageBox.Show("El número de cuenta no existe o el usuario ya está desactivado.");
                    txtBuscar2.Text = "";
                    LimpiarCampos();
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Operación cancelada. No se realizó ningún cambio.");
        }

        private void txtBuscar2_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar2.Text.Length > 16)
            {
                txtBuscar2.Text = txtBuscar2.Text.Substring(0, 16);
                txtBuscar2.SelectionStart = txtBuscar2.Text.Length;
            }
        }

        private void txtBuscar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // -----------------------------------------------------Métodos Auxiliares-----------------------------------------------------------
        private void DesactivarCampos()
        {
            txtNombre.Enabled = false;
            txtCuenta.Enabled = false;
            txtPin.Enabled = false;
            txtPin2.Enabled = false;
            txtMonto.Enabled = false;
            txtSaldo.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtCorreo.Enabled = false;

        }
        private void ActivarCampos()
        {
            txtNombre.Enabled = true;
            txtCuenta.Enabled = true;
            txtPin.Enabled = true;
            txtPin2.Enabled = true;
            txtMonto.Enabled = true;
            txtSaldo.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtCorreo.Enabled = true;
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtCuenta.Text = "";
            txtPin.Text = "";
            txtPin2.Text = "";
            txtMonto.Text = "";
            txtSaldo.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";

        }

        private bool ValidarCuenta(string noCuenta)
        {
            if (string.IsNullOrWhiteSpace(noCuenta))
            {
                MessageBox.Show("Favor de ingresar un número de cuenta.");
                return false;
            }

            if (noCuenta.Length != 16)
            {
                MessageBox.Show("El número de cuenta debe tener exactamente 16 dígitos.");
                return false;
            }

            return true;
        }
        private void MostrarDatosUsuario(UsuarioM usuario)
        {
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtTelefono.Text = usuario.Telefono;
            txtCorreo.Text = usuario.Correo;
            txtDireccion.Text = usuario.Direccion;
            txtPin.Text = usuario.Pin;
            txtPin2.Text = usuario.Pin;
            txtCuenta.Text = usuario.NumeroTarjeta;
            txtMonto.Text = usuario.MontoMaximo.ToString();
            txtSaldo.Text = usuario.SaldoActual.ToString();

          
            if (usuario.Id_Tipo == 2)
            {
                lblTipoUsuario.Text = "Administrador"; 
            }
            else if (usuario.Id_Tipo == 1)
            {
                lblTipoUsuario.Text = "Usuario";
            }
            else
            {
                lblTipoUsuario.Text = "Tipo desconocido";
            }
        }
    private void label9_Click(object sender, EventArgs e)
    {

    }
    private void frmEliminarUsuario_Load(object sender, EventArgs e)
    {
          
    }
    }
}