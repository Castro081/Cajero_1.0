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
using static System.Runtime.InteropServices.JavaScript.JSType;
using UsuarioM = Cajero.Modelos.Usuario;
using Cajero.Conexion;

namespace Cajero.Vistas
{
    public partial class frmEditarUsuario : Form
    {
        // -----------------------------------------------------Campos Privados-----------------------------------------------------------
        private Datos datos;
        private DataBaseConexion db;
        private string noCuentaUsuario = "";

        // -----------------------------------------------------Constructor-----------------------------------------------------------
        public frmEditarUsuario(Datos datos)
        {
            InitializeComponent();
            btnActivar.Visible = false;
            this.datos = datos;
            db = new DataBaseConexion();
            btnActivar.Enabled = false;
        }

        // -----------------------------------------------------Eventos de Botones-----------------------------------------------------------
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text.Length > 16)
            {
                textBuscar.Text = textBuscar.Text.Substring(0, 16);
                textBuscar.SelectionStart = textBuscar.Text.Length;
            }
        }

        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // -----------------------------------------------------Modificar Usuario-----------------------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;

            string noCuenta = txtCuenta.Text;
            string pin = txtPin.Text;
            decimal saldo;
            int montoMaximo;

            if (!decimal.TryParse(txtSaldo.Text, out saldo) || saldo < 0)
            {
                MessageBox.Show("Por favor, ingrese un saldo válido.");
                LimpiarCampos();
                return;
            }

            if (!int.TryParse(txtMonto.Text, out montoMaximo) || montoMaximo < 0)
            {
                MessageBox.Show("Por favor, ingrese un monto máximo válido.");
                LimpiarCampos();
                return;
            }

            UsuarioM usuarioActual = db.ObtenerCuentaPorNumero(noCuentaUsuario);
            if (usuarioActual == null)
            {
                MessageBox.Show("Usuario no encontrado.");
                LimpiarCampos();
                return;
            }
            bool datosClienteModificados = false;
            bool datosCuentaModificados = false;
            bool tipoCuentaModificado = false;

            string descripcionBitacora = $"Modificaciones ala cuenta.";
            if (usuarioActual.Nombre != nombre)
            {
                datosClienteModificados = true;
                db.ActualizarCliente1(usuarioActual.Id, nombre, usuarioActual.Apellido, usuarioActual.Telefono, usuarioActual.Correo, usuarioActual.Direccion);
                descripcionBitacora += "\n- Cambio de nombre.";
            }

            if (usuarioActual.Apellido != apellido)
            {
                datosClienteModificados = true;
                db.ActualizarCliente1(usuarioActual.Id, usuarioActual.Nombre, apellido, usuarioActual.Telefono, usuarioActual.Correo, usuarioActual.Direccion);
                descripcionBitacora += "\n- Cambio de apellido.";
            }

            if (usuarioActual.Telefono != telefono)
            {
                datosClienteModificados = true;
                db.ActualizarCliente1(usuarioActual.Id, usuarioActual.Nombre, usuarioActual.Apellido, telefono, usuarioActual.Correo, usuarioActual.Direccion);
                descripcionBitacora += "\n- Cambio de teléfono.";
            }

            if (usuarioActual.Correo != correo)
            {
                datosClienteModificados = true;
                db.ActualizarCliente1(usuarioActual.Id, usuarioActual.Nombre, usuarioActual.Apellido, usuarioActual.Telefono, correo, usuarioActual.Direccion);
                descripcionBitacora += "\n- Cambio de correo.";
            }

            if (usuarioActual.Direccion != direccion)
            {
                datosClienteModificados = true;
                db.ActualizarCliente1(usuarioActual.Id, usuarioActual.Nombre, usuarioActual.Apellido, usuarioActual.Telefono, usuarioActual.Correo, direccion);
                descripcionBitacora += "\n- Cambio de dirección.";
            }

            if (usuarioActual.NumeroTarjeta != noCuenta)
            {
                datosCuentaModificados = true;
                db.ActualizarCuenta(usuarioActual.Id, noCuenta, usuarioActual.Pin, usuarioActual.SaldoActual, usuarioActual.MontoMaximo);
                descripcionBitacora += "\n- Cambio de número de cuenta.";
            }

            if (usuarioActual.Pin != pin)
            {
                datosCuentaModificados = true;
                db.ActualizarCuenta(usuarioActual.Id, usuarioActual.NumeroTarjeta, pin, usuarioActual.SaldoActual, usuarioActual.MontoMaximo);
                descripcionBitacora += "\n- Cambio de PIN.";
            }

            if (usuarioActual.SaldoActual != saldo)
            {
                datosCuentaModificados = true;
                db.ActualizarCuenta(usuarioActual.Id, usuarioActual.NumeroTarjeta, usuarioActual.Pin, saldo, usuarioActual.MontoMaximo);
                descripcionBitacora += "\n- Cambio de saldo.";
            }

            if (usuarioActual.MontoMaximo != montoMaximo)
            {
                datosCuentaModificados = true;
                db.ActualizarCuenta(usuarioActual.Id, usuarioActual.NumeroTarjeta, usuarioActual.Pin, usuarioActual.SaldoActual, montoMaximo);
                descripcionBitacora += "\n- Cambio de monto máximo.";
            }

            int nuevoTipoCuenta = cbmTipo.SelectedItem != null ? ((TipoUsuario)cbmTipo.SelectedItem).Id : usuarioActual.Id_Tipo;
            if (usuarioActual.Id_Tipo != nuevoTipoCuenta)
            {
                tipoCuentaModificado = true;
                db.ActualizarTipoCuenta(usuarioActual.Id, nuevoTipoCuenta);
                descripcionBitacora += "\n- Cambio de tipo de cuenta.";
                MessageBox.Show("Tipo de cuenta actualizado con éxito.");
            }

            if (datosClienteModificados || datosCuentaModificados || tipoCuentaModificado)
            {
                if (datosClienteModificados)
                {
                    MessageBox.Show("Datos del cliente actualizados con éxito.");
                }

                if (datosCuentaModificados)
                {
                    MessageBox.Show("Datos de la cuenta actualizados con éxito.");
                }
            }
            else
            {
                MessageBox.Show("No se realizaron modificaciones.");
            }

            if (datosClienteModificados || datosCuentaModificados || tipoCuentaModificado)
            {
                int idUsuario = 1;
                int idCuenta = usuarioActual.Id;
                string resultadoBitacora = db.InsertarBitacora(idCuenta, descripcionBitacora, idUsuario);
                MessageBox.Show(resultadoBitacora);
            }
            LimpiarCampos();
        }


        // -----------------------------------------------------Buscar Usuario-----------------------------------------------------------
        private void txtBuscar_Click(object sender, EventArgs e)
        {
            string noCuenta = textBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(noCuenta) || noCuenta.Length != 16)
            {
                MessageBox.Show("El número de cuenta debe tener exactamente 16 dígitos.");
                return;
            }

            UsuarioM usuario = db.ObtenerCuentaPorNumero(noCuenta);

            if (usuario != null)
            {
                MostrarDatosUsuario(usuario);
                noCuentaUsuario = usuario.NumeroTarjeta;

                if (!usuario.Estado)  
                {
                    MessageBox.Show("La cuenta está desactivada. Debes activarla para poder modificar los datos.");

                    HabilitarCampos(false);
                    btnActivar.Visible = true;
                    btnActivar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Usuario encontrado y datos cargados.");
                    HabilitarCampos(true);
                    btnActivar.Visible = false;
                    btnActivar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El número de cuenta no existe.");
                LimpiarCampos();
            }
        }


        // -----------------------------------------------------Limpiar Campos y Cancelar-----------------------------------------------------------
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtCuenta.Text = "";
            txtPin.Text = "";
            txtPin2.Text = "";
            txtMonto.Text = "";
            txtSaldo.Text = "";
            textBuscar.Text = "";
            HabilitarCampos(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Operación cancelada. No se realizó ningún cambio.");
        }

        // -----------------------------------------------------Eventos No Implementados-----------------------------------------------------------
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // -----------------------------------------------------Activar Usuario-----------------------------------------------------------
        private void btnActivar_Click(object sender, EventArgs e)
        {
            UsuarioM usuario = db.ObtenerCuentaPorNumero(noCuentaUsuario);

            if (usuario != null && !usuario.Estado)  
            {
              
                db.Desactivar(usuario.Id, true);  

                string descripcionBitacora = $"Cuenta reactivada.";
                int idUsuario = 1;
                db.InsertarBitacora(usuario.Id, descripcionBitacora, idUsuario);

               
                MessageBox.Show("Usuario activado con éxito.");
              
                LimpiarCampos();
                btnActivar.Visible = false;
                btnActivar.Enabled = false;
                HabilitarCampos(true);
            }
            else
            {
                MessageBox.Show("El número de cuenta no existe o el usuario ya está activo.");
            }
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

            cbmTipo.SelectedItem = cbmTipo.Items
                .Cast<TipoUsuario>()
                .FirstOrDefault(t => t.Id == usuario.Id_Tipo);

        }

        // -----------------------------------------------------Generar Reporte de Usuario-----------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtiene las rutas de los archivos necesarios
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string pathUsuarios = Path.Combine(projectDirectory, "Datos", "Usuarios.txt");
            string pathLogins = Path.Combine(projectDirectory, "Datos", "Logins.txt");
            string pathMovimientos = Path.Combine(projectDirectory, "Datos", "Movimientos.txt");

            string noCuenta = Cuenta.Text;

            if (string.IsNullOrWhiteSpace(noCuenta) || noCuenta.Length != 16)
            {
                MessageBox.Show("Favor de ingresar un número de cuenta válido con 16 dígitos.");
                return;
            }

            string nombreUsuario = "";
            int idUsuario = 0;
            double montoMaximo = 0;
            double saldoActual = 0;
            double cantidadRetirada = 0;

            DateTime ultimoAcceso = DateTime.MinValue;



            try
            {

                if (File.Exists(pathUsuarios))
                {
                    foreach (string linea in File.ReadAllLines(pathUsuarios))
                    {
                        string[] datos = linea.Split('|');
                        if (datos.Length > 5 && datos[2] == noCuenta)
                        {
                            nombreUsuario = datos[1];
                            idUsuario = int.TryParse(datos[0], out idUsuario) ? idUsuario : 0;
                            montoMaximo = double.TryParse(datos[5], out montoMaximo) ? montoMaximo : 0;
                            saldoActual = double.TryParse(datos[4], out saldoActual) ? saldoActual : 0;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de usuarios no existe.");
                    return;
                }


                if (File.Exists(pathMovimientos))
                {
                    foreach (string linea in File.ReadAllLines(pathMovimientos))
                    {
                        string[] datos = linea.Split('|');
                        if (datos.Length > 3 && datos[1] == noCuenta && datos[2] == "Retiro")
                        {
                            cantidadRetirada += double.TryParse(datos[3], out double retiro) ? retiro : 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de movimientos no existe.");
                    return;
                }
                var movimientos = datos.ObtenerMovimientos(idUsuario);
                foreach (var mov in movimientos)
                {
                    if (mov.Operacion == "Retiro")
                    {
                        foreach (var det in datos.ObtenerDetalles(mov.Id))
                        {
                            cantidadRetirada += det.Billete * det.cantidadBillete;
                        }
                    }
                }


                if (File.Exists(pathLogins))
                {
                    foreach (string linea in File.ReadAllLines(pathLogins))
                    {
                        string[] datos = linea.Split('|');
                        if (datos.Length > 1 && datos[0] == nombreUsuario)
                        {
                            DateTime fechaAcceso = DateTime.TryParseExact(datos[1], "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out fechaAcceso)
                                                    ? fechaAcceso
                                                    : DateTime.MinValue;
                            if (fechaAcceso > ultimoAcceso)
                            {
                                ultimoAcceso = fechaAcceso;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de logins no existe.");
                    return;
                }


                StringBuilder reporte = new StringBuilder();
                reporte.AppendLine("Reporte de Usuario:");
                reporte.AppendLine(new string('-', 50));
                reporte.AppendLine($"Número de Cuenta: {noCuenta}");
                reporte.AppendLine($"Nombre del Usuario: {nombreUsuario}");
                reporte.AppendLine($"Monto Máximo Disponible: Q {montoMaximo}");
                reporte.AppendLine($"Cantidad Retirada Hasta el Momento: Q {cantidadRetirada}");
                reporte.AppendLine($"Saldo Actual: Q {saldoActual}");
                reporte.AppendLine($"Último Acceso: {(ultimoAcceso != DateTime.MinValue ? ultimoAcceso.ToString("yyyy-MM-dd HH:mm:ss") : "No registrado")}");
                reporte.AppendLine(new string('-', 50));

                MessageBox.Show(reporte.ToString(), "Información del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            txtCorreo.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
            txtCuenta.Enabled = habilitar;
            txtPin.Enabled = habilitar;
            txtPin2.Enabled = habilitar;
            txtMonto.Enabled = habilitar;
            txtSaldo.Enabled = habilitar;
            cbmTipo.Enabled = habilitar;
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            cbmTipo.Items.Clear();
            cbmTipo.Items.Add(new TipoUsuario { Id = 0, Nombre = "Selecciona" });
            cbmTipo.Items.Add(new TipoUsuario { Id = 1, Nombre = "Usuario" });
            cbmTipo.Items.Add(new TipoUsuario { Id = 2, Nombre = "Administrador" });
            cbmTipo.SelectedIndex = 0;
        }
    }
}


