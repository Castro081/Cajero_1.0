// -----------------------------------------------------Dependencias-----------------------------------------------------------
// Importa los namespaces necesarios para el manejo de datos, archivos y la interfaz gráfica de usuario.
using Cajero.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cajero.Conexion;

namespace Cajero.Vistas
{
    public partial class frmReportes : Form
    {
        private DataBaseConexion conexion;

        // -----------------------------------------------------Constructor-----------------------------------------------------------
        public frmReportes(DataBaseConexion conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            CargarUsuarios();
            CargarBitacora();
            // Configuración del DataGridView
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridBitacora.ReadOnly = true; // Para que no se puedan editar los datos
            dataGridBitacora.AllowUserToAddRows = false; // Deshabilitar la opción de agregar filas
            dataGridBitacora.AllowUserToDeleteRows = false; // Deshabilitar la opción de eliminar filas
        
        }

        // Método para cargar la bitácora
        private void CargarBitacora()
        {
            DataBaseConexion conexion = new DataBaseConexion();
            DataTable bitacoraData = conexion.ObtenerBitacora();

            dataGridBitacora.Rows.Clear();

            if (dataGridBitacora.Columns.Count == 0)
            {
                dataGridBitacora.Columns.Add("Id_Cuenta", "Cu");
                dataGridBitacora.Columns.Add("Descripcion", "Descripción");
                dataGridBitacora.Columns.Add("Id_Usuario", "Us");
                dataGridBitacora.Columns.Add("Fecha_Bitacora", "Fecha");
            }

            foreach (DataRow row in bitacoraData.Rows)
            {
                dataGridBitacora.Rows.Add(
                    row["Id_Cuenta"],
                    row["Descripcion"],
                    row["Id_Usuario"],
                    row["Fecha_Bitacora"]
                );
            }

            dataGridBitacora.Columns["Id_Cuenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridBitacora.Columns["Id_Usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridBitacora.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridBitacora.Columns["Fecha_Bitacora"].Width = 150; 

            dataGridBitacora.Columns["Id_Cuenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridBitacora.Columns["Id_Usuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -----------------------------------------------------Métodos Privados-----------------------------------------------------------
        // Método para cargar la cantidad de usuarios desde un archivo
        private void CargarUsuarios()
        {
            int cantidad = conexion.CantidadUsuario();
            lbUsuarios.Text = $"{cantidad}";
        }

        private bool reporteGenerado = false;

        // -----------------------------------------------------Eventos de Imagenes y Otros Controles-----------------------------------------------------------
        // Evento que se activa al hacer clic en la imagen para mostrar el reporte de movimientos
        private void pbMovimientos_Click(object sender, EventArgs e)
        {
            var mensaje = "Reporte de Movimientos por cajero: \n";
            var conteoPorCajero = conexion.ObtenerConteoTransaccionesPorCajero();

            foreach (var cajero in conteoPorCajero)
            {
                mensaje += $"Cajero ID: {cajero.Key}\n";

                // Verificamos y mostramos el conteo de retiros y depósitos
                if (cajero.Value.ContainsKey("Retiro"))
                {
                    mensaje += $"\tTotal Retiros: {cajero.Value["Retiro"]}\n";
                }
                else
                {
                    mensaje += "  No hay retiros registrados.";
                }

                if (cajero.Value.ContainsKey("Deposito"))
                {
                    mensaje += $"\tTotal Depósitos: {cajero.Value["Deposito"]}\n\n";
                }
                else
                {
                    mensaje += "  No hay depósitos registrados.";
                }
            }
            MessageBox.Show(mensaje, "Movimientos por cajero", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbCambiosPin_Click(object sender, EventArgs e)
        {
            string mensaje = $"No hay cambios de PIN";
            var cambios = conexion.ObtenerCambiosPin();
            if (cambios != null)
            {
                mensaje = "";
                foreach (var cambio in cambios)
                {
                    mensaje += $"Nombre: {cambio.usuario} -- Fecha: {cambio.Fecha}\n";
                }
            }
            MessageBox.Show(mensaje, "Reporte de Cambios de PIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void pbInicializacion_Click(object sender, EventArgs e)
        {
            var mensaje = "Cajeros: \n";
            var inicializacion = conexion.ObtenerInicializaciones();
            foreach (var ini in inicializacion)
            {
                mensaje += $"Cajero: {ini.IdCajero} - Inicialización - Fecha: {ini.FechaInicializacion}\n";
            }
            MessageBox.Show(mensaje, "Reporte de Inicializacion de cajeros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbUsuarios_Click(object sender, EventArgs e)
        {
            var mensaje = "Reporte de Usuarios: \n";
            var usuarios = conexion.ObtenerCuentas();

            foreach (var usuario in usuarios)
            {
                string estatus = usuario.Estado ? "Activo" : "Inactivo";
                mensaje += $"{usuario.Id} -- Nombre: {usuario.Nombre} {usuario.Apellido} -- Estatus: {estatus}\n";
                mensaje += $"Dirección: {usuario.Direccion} -- Teléfono: {usuario.Telefono} -- Correo: {usuario.Correo}\n\n";
            }
            MessageBox.Show(mensaje, "Reporte de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbMovimientoUsu_Click(object sender, EventArgs e)
        {

            var mensaje = "Reporte de Movimientos de los Usuarios: \n";
            var movimientos = conexion.ObtenerTransacciones();

            foreach (var mov in movimientos)
            {
                if (mov.TipoTransaccion == "Deposito" || mov.TipoTransaccion == "Retiro")
                {
                    var usuario = conexion.ObtenerCuenta(mov.IdCuenta);
                    if (usuario != null) // Verifica que se haya encontrado el usuario
                    {
                        // Añadimos los nuevos campos al reporte de movimientos
                        mensaje += $"Movimiento {mov.Id}:  -- Usuario: {usuario.Nombre} {usuario.Apellido} -- Operación: {mov.TipoTransaccion}\n";
                    }
                    else
                    {
                        mensaje += $"Movimiento ID: {mov.Id} -- Usuario no encontrado para ID: {mov.IdCuenta} -- Operación: {mov.TipoTransaccion}\n\n";
                    }
                }
            }
            MessageBox.Show(mensaje, "Reporte de Movimientos de los Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}