using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Cajero.Modelos;
using Cajero.Vistas.Usuario;
using UsuarioM = Cajero.Modelos.Usuario;
using CajeroM = Cajero.Modelos.Cajero;
using Cajero.Conexion;
using System.Data.SqlClient;

namespace Cajero.Vistas
{
    public partial class frmLogin : Form
    {
        // -----------------------------------------------------Campos Privados-----------------------------------------------------------
        private int intentosFallidos = 0;
        private const int maxIntentos = 3;

        // Credenciales predeterminadas
        private const string UsuarioAdmin = "0000000000000000";
        private const string PinAdmin = "0000";

        private Datos datos;
        private DataBaseConexion conexion;
        private int idCajero = 1;
        private CajeroM cajero;
        // -----------------------------------------------------Constructor-----------------------------------------------------------
        private SqlConnection cn;
        public frmLogin(Datos datos, DataBaseConexion conexion)
        {
            InitializeComponent();
            this.datos = datos;
            this.Text = "Login";
            this.Size = new Size(1024, 720);
            txtPin.UseSystemPasswordChar = true;

            txtPin.KeyPress += txtPin_KeyPress;
            txtPin.TextChanged += txtPin_TextChanged;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            btnIngresar.Click += btnIngresar_Click;
            btnCancelar.Click += btnCancelar_Click;


            this.conexion = conexion;
            this.Shown += new EventHandler(Form1_Shown);

            datos.LeerDatosUsuarios();
        }

        // -----------------------------------------------------Eventos para mover el mouse-----------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);


        // -----------------------------------------------------Eventos de Botones-----------------------------------------------------------
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validar PIN y Usuario
            if (txtPin.Text.Length != 4 || txtUsuario.Text.Length != 16)
            {
                MessageBox.Show("El número de cuenta debe tener 16 dígitos y el PIN exactamente 4 dígitos.");
                return;
            }

            var usuario = conexion.ObtenerCuentaPorNumero(txtUsuario.Text);  

            if (usuario == null || usuario.Pin != txtPin.Text)
            {
                intentosFallidos++;
                MessageBox.Show("Usuario o PIN incorrectos.");

                if (intentosFallidos >= maxIntentos)  
                {
                    DesactivarCuenta(txtUsuario.Text); 
                    return;
                }
            }
            else
            {
                intentosFallidos = 0;  

                if (usuario.Estado == false)
                {
                    MessageBox.Show("Su cuenta está desactivada.");
                    limpiarCampos();
                    return;
                }

                if (usuario.Id_Tipo == 2)
                {
                    MessageBox.Show("Ingreso exitoso. Bienvenido, administrador!");
                    frmPrincipalAdmi formularioAdmin = new frmPrincipalAdmi(this, datos, conexion, usuario, cajero);
                    formularioAdmin.Show();
                    this.Hide();
                }
                else if (usuario.Id_Tipo == 1)
                {
                    MessageBox.Show("Ingreso exitoso. Bienvenido, usuario!");
                    if (usuario.PrimerInicio)
                    {
                        frmPrimerInicio primerInicio = new frmPrimerInicio(this, conexion, usuario, cajero);
                        primerInicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmPanelUsuario panelUsuario = new frmPanelUsuario(this, conexion, usuario, cajero);
                        panelUsuario.Show();
                        this.Hide();
                    }
                }
            }
        }

        // -----------------------------------------------------Métodos de Gestión de Cuenta-----------------------------------------------------------
        private void DesactivarCuenta(string numeroCuenta)
        {
            UsuarioM usuario = conexion.ObtenerCuentaPorNumero(numeroCuenta); 
            if (usuario != null && usuario.Estado == true) 
            {
                bool resultado = conexion.Desactivar(usuario.Id, false); 

                if (resultado)
                {
                    MessageBox.Show("La cuenta ha sido desactivada debido a múltiples intentos fallidos.");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error: no se pudo desactivar la cuenta.");
                }
            }
            else
            {
                MessageBox.Show("El número de cuenta no existe o ya está desactivada.");
            }

            limpiarCampos();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

            if (txtPin.Text.Length > 4)
            {
                txtPin.Text = txtPin.Text.Substring(0, 4);
                txtPin.SelectionStart = txtPin.Text.Length;
            }
        }

        // -----------------------------------------------------Validación de Entradas-----------------------------------------------------------
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

            if (txtUsuario.Text.Length > 16)
            {
                txtUsuario.Text = txtUsuario.Text.Substring(0, 16);
                txtUsuario.SelectionStart = txtUsuario.Text.Length;
            }
        }

        private void frmLogin_MouseDown_1(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            VerificarCajero();
        }
        private void VerificarCajero()
        {
            cajero = conexion.ObtenerCajeroPorId(idCajero);
            if (cajero == null)
            {
                MessageBox.Show("Cajero programado no existe en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }
        public void limpiarCampos()
        {
            txtUsuario.Text = "";
            txtPin.Text = "";
        }
    }
}