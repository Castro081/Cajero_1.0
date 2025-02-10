// -----------------------------------------------------Dependencias-----------------------------------------------------------
using Cajero.Conexion;
using Cajero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioM = Cajero.Modelos.Usuario;
using CajeroM = Cajero.Modelos.Cajero;

namespace Cajero.Vistas
{
    public partial class frmPrincipalAdmi : Form
    {
        // -----------------------------------------------------Campos Privados-----------------------------------------------------------
        private frmLogin frmLogin;
        private UsuarioM usuario;
        private Datos datos;
        private DataBaseConexion conexion;
        private CajeroM cajero;

        // -----------------------------------------------------Constructor-----------------------------------------------------------
        public frmPrincipalAdmi(frmLogin frmLogin, Datos datos, DataBaseConexion conexion, UsuarioM usuario, CajeroM cajero)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            this.datos = datos;
            this.conexion = conexion;
            this.usuario = usuario;
            this.cajero = cajero;
            mostarInicio();
        }

        // Estado del menú y sidebar
        bool menuEX = false;
        bool sidebarEx = true;

        // -----------------------------------------------------Eventos para mover el mouse-----------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);
        private void frmPrincipalAdmi_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            menuTansition.Start();
        }
        

        private void menuTansition_Tick(object sender, EventArgs e)
        {
            if (menuEX == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 332)
                {

                    menuTansition.Stop();
                    menuEX = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 78)
                {
                    menuTansition.Stop();
                    menuEX = false;
                }


            }
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarEx)
            {
                flowLayoutPanel2.Width -= 10;
                if (flowLayoutPanel2.Width <= 54)
                {
                    sidebarEx = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                flowLayoutPanel2.Width += 10;
                if (flowLayoutPanel2.Width >= 194)
                {
                    sidebarEx = true;
                    sidebarTransition.Stop();
                }
            }

        }

        private void btnham_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebar_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmPrincipalAdmi_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // -----------------------------------------------------Eventos de Botones-----------------------------------------------------------
        // Muestra el formulario para agregar usuarios dentro del panel contenedor
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmUsuarios formularioUsuarios = new frmUsuarios();

            formularioUsuarios.TopLevel = false;
            formularioUsuarios.FormBorderStyle = FormBorderStyle.None;
            formularioUsuarios.Dock = DockStyle.Fill;


            panelContenedor.Controls.Clear();


            panelContenedor.Controls.Add(formularioUsuarios);
            formularioUsuarios.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Muestra el formulario para editar usuarios dentro del panel contenedor
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarUsuario formularioEditarUsuario = new frmEditarUsuario(datos);

            formularioEditarUsuario.TopLevel = false;
            formularioEditarUsuario.FormBorderStyle = FormBorderStyle.None;
            formularioEditarUsuario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(formularioEditarUsuario);
            formularioEditarUsuario.Show();
        }

        // Muestra el formulario para eliminar usuarios dentro del panel contenedor
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            frmEliminarUsuario formularioEliminar = new frmEliminarUsuario(datos);


            formularioEliminar.TopLevel = false;
            formularioEliminar.FormBorderStyle = FormBorderStyle.None;
            formularioEliminar.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(formularioEliminar);
            formularioEliminar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        // Muestra el formulario de reportes dentro del panel contenedor
        private void button1_Click(object sender, EventArgs e)
        {
            frmReportes formularioReporte = new frmReportes(conexion);

            formularioReporte.TopLevel = false;
            formularioReporte.FormBorderStyle = FormBorderStyle.None;
            formularioReporte.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(formularioReporte);
            formularioReporte.Show();
        }

        // Muestra la pantalla principal o inicial del administrador
        private void btnPanel_Click(object sender, EventArgs e)
        {
            mostarInicio();
        }

        // Método que muestra la pantalla de inicio con datos del cajero
        private void mostarInicio()
        {
            frmDatosCajero formularioCajero = new frmDatosCajero(frmLogin, this, conexion);

            formularioCajero.TopLevel = false;
            formularioCajero.FormBorderStyle = FormBorderStyle.None;
            formularioCajero.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(formularioCajero);
            formularioCajero.Show();
        }

        // Muestra el formulario para inicializar configuraciones dentro del panel contenedor
        private void btnInicializar_Click(object sender, EventArgs e)
        {
            frmInicializar formularioInicializar = new frmInicializar(conexion, usuario, cajero);

            formularioInicializar.TopLevel = false;
            formularioInicializar.FormBorderStyle = FormBorderStyle.None;
            formularioInicializar.Dock = DockStyle.Fill;

            panelContenedor.Controls.Clear();

            panelContenedor.Controls.Add(formularioInicializar);
            formularioInicializar.Show();
        }
    }
}
