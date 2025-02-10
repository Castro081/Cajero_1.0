// -----------------------------------------------------Dependencias-----------------------------------------------------------
// Incluye modelos del cajero, componentes de Windows Forms y manejo de archivos.
using Cajero.Conexion;
using Cajero.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero.Vistas
{
    // ---------------------------------------------------Clase Principal-------------------------------------------------------
    // Esta clase representa el formulario 'frmDatosCajero', que se encarga de mostrar los datos del cajero, 
    // incluyendo el conteo de usuarios, movimientos, y operaciones específicas como retiros y depósitos.

    public partial class frmDatosCajero : Form
    {
        // ---------------------------------------------------Variables Privadas-------------------------------------------------
        // Variables para la interacción con otros formularios y la instancia de datos.
        private frmLogin frmlogin;
        private frmPrincipalAdmi frmprincipal;
        private DataBaseConexion conexion;

        // ---------------------------------------------------Constructor--------------------------------------------------------
        // Inicializa el formulario con referencias a otros formularios y carga datos iniciales.
        public frmDatosCajero(frmLogin frmlogin, frmPrincipalAdmi frmprincipal, DataBaseConexion conexion)
        {
            this.frmlogin = frmlogin;
            this.frmprincipal = frmprincipal;
            this.conexion = conexion;
            InitializeComponent();
            CargarUsuarios();
            ContarMovimientos();
            CargarLogins();
            CargarCambiosPin();
        }

        // ----------------------------------------------Métodos de Carga de Datos----------------------------------------------
        // Carga los usuarios desde un archivo y cuenta los IDs únicos.
        private void CargarUsuarios()
        {
            int cantidad = conexion.CantidadUsuario();
            lbUsuarios2.Text = $"{cantidad}";
        }

        // Cuenta los movimientos de retiros y depósitos desde un archivo.
        private void ContarMovimientos()
        {
            (int total, int cantidad) resultadoRetiro = conexion.ObtenerSumaYCantidadDeRetiros();
            (int total, int cantidad) resultadoDeposito = conexion.ObtenerSumaYCantidadDeDepositos();
            int promedio = conexion.ObtenerPromedioTransacciones();
            lbRetiros.Text = $"{resultadoRetiro.cantidad}";
            lbDepositos.Text = $"{resultadoDeposito.cantidad}";
            labelTotalRetiro.Text = $"{resultadoRetiro.total}";
            labelTotalDeposito.Text = $"{resultadoDeposito.total}";
            labelPromedio.Text = $"{promedio}";
        }

        // Cuenta las modificaciones de PIN desde un archivo
        private void CargarCambiosPin()
        {
            int cambioDePin = conexion.CantidadCambiosPin();
            lbCambiosPin.Text = $"{cambioDePin}";
        }

        // Carga los logins desde un archivo y los muestra en un DataGridView.
        private void CargarLogins()
        {

            if (dgCajero.Columns.Count == 0)
            {
                dgCajero.Columns.Add("Usuario", "Usuario");
                dgCajero.Columns.Add("FechaHora", "Fecha y Hora");
                dgCajero.Columns.Add("Cajero", "Cajero");
            }
            dgCajero.Rows.Clear();

            var logins = conexion.ObtenerInicioSesiones();

            foreach (var login in logins)
            {
                dgCajero.Rows.Add(login.Cuenta, login.FechaInicio, login.Id_Cajero);
            }
            // Configuración visual del DataGridView
            dgCajero.BackgroundColor = Color.Black;
            dgCajero.DefaultCellStyle.BackColor = Color.Black;
            dgCajero.DefaultCellStyle.ForeColor = Color.White;
            dgCajero.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgCajero.DefaultCellStyle.SelectionForeColor = Color.White;
            dgCajero.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgCajero.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgCajero.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            dgCajero.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgCajero.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgCajero.GridColor = Color.Black;
            dgCajero.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dgCajero.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgCajero.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            dgCajero.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgCajero.EnableHeadersVisualStyles = false;

        }

        // ----------------------------------------------Manejo de Ventanas y Eventos-------------------------------------------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.frmprincipal.Close();
            this.frmlogin.Show();
            frmlogin.limpiarCampos();
        }

        private void frmDatosCajero_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
