// -----------------------------------------------------Dependencias-----------------------------------------------------------
using Cajero.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cajero.Vistas
{
    public partial class frmUsuarios : Form
    {
        // -----------------------------------------------------Constructor-----------------------------------------------------------
        public frmUsuarios()

        {
            InitializeComponent();
            tbNoCuenta.Enabled = false;

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cbmTipo.Items.Clear();
            cbmTipo.Items.Add("Selecciona");
            cbmTipo.Items.Add("Administrador");
            cbmTipo.Items.Add("Usuario");
            cbmTipo.SelectedIndex = 0;
            tbMontoMaximo.Text = "2000";
        }

        private void btnregresar_Click(object sender, EventArgs e)

        {
            this.Close();
        }


        // -----------------------------------------------------Validación y Restricción de Textos-----------------------------------------------------------
        private void tbPin1_TextChanged(object sender, EventArgs e)

        {

            if (tbPin1.Text.Length > 4)
            {
                tbPin1.Text = tbPin1.Text.Substring(0, 4);
                tbPin1.SelectionStart = tbPin1.Text.Length;
            }
        }

        private void tbPin1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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

        private void tbPin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbNoCuenta_TextChanged(object sender, EventArgs e)
        {

            if (tbNoCuenta.Text.Length > 16)
            {
                tbNoCuenta.Text = tbNoCuenta.Text.Substring(0, 16);
                tbNoCuenta.SelectionStart = tbNoCuenta.Text.Length;
            }
        }

        private void tbNoCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbMontoMaximo_TextChanged(object sender, EventArgs e)
        {
            if (tbMontoMaximo.Text.Length > 4)
            {
                tbMontoMaximo.Text = tbMontoMaximo.Text.Substring(0, 4);
                tbMontoMaximo.SelectionStart = tbMontoMaximo.Text.Length;
            }
        }

        private void tbMontoMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbSaldo_TextChanged(object sender, EventArgs e)
        {
            string text = tbSaldo.Text.Replace(',', '.');

            int decimalIndex = text.IndexOf('.');
            if (decimalIndex != -1)
            {
                text = text.Substring(0, decimalIndex + 1) + text.Substring(decimalIndex + 1).Replace(".", "");
            }

            if (text.Length > 15)
            {
                text = text.Substring(0, 15);
            }

            tbSaldo.Text = text;
            tbSaldo.SelectionStart = tbSaldo.Text.Length;
        }

        private void tbSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            if (tbTelefono.Text.Length > 8)
            {
                tbTelefono.Text = tbTelefono.Text.Substring(0, 8);
                tbTelefono.SelectionStart = tbTelefono.Text.Length;
            }
        }

        // -----------------------------------------------------Lógica de Agregar Usuario-----------------------------------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;
            string noCuenta = GenerarNumeroDeCuenta();
            tbNoCuenta.Text = noCuenta;
            string pin = tbPin1.Text;
            string telefono = tbTelefono.Text;
            string correo = tbCorreo.Text;
            string direccion = tbDireccion.Text;
            int montoMaximo = int.Parse(tbMontoMaximo.Text);
            int saldo = int.Parse(tbSaldo.Text);
            string tipoUsuario = cbmTipo.SelectedItem?.ToString();
            int idTipo = tipoUsuario == "Administrador" ? 2 : 1;
            int idUsuario = 1;
            bool primerInicio = true;
            int estado = 1;

            DataBaseConexion conexion = new DataBaseConexion(); 

            string resultadoCliente = conexion.InsertarCliente(nombre, apellido, telefono, direccion, correo);
            MessageBox.Show(resultadoCliente);
            int idCliente = conexion.ObtenerUltimoIdCliente();

            string resultadoCuenta = conexion.InsertarCuenta(idCliente, noCuenta, pin, saldo, montoMaximo, idTipo, primerInicio, estado);
            MessageBox.Show(resultadoCuenta);
            int idCuenta = conexion.ObtenerUltimoIdCuenta();

            string descripcionBitacora = $"Se registró una cuenta: {noCuenta}.";
            string resultadoBitacora = conexion.InsertarBitacora(idCuenta, descripcionBitacora, idUsuario);
            MessageBox.Show(resultadoBitacora);

            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Operación cancelada. No se realizó ningún cambio.");
        }

        private string GenerarNumeroDeCuenta()
        {
            Random random = new Random();
            string numeroDeCuenta;
            DataBaseConexion conexion = new DataBaseConexion();

            do
            {
                numeroDeCuenta = string.Concat(Enumerable.Range(0, 16).Select(x => random.Next(0, 10).ToString()));
            } while (CuentaYaExiste(numeroDeCuenta, conexion));

            return numeroDeCuenta;
        }

        private bool CuentaYaExiste(string numeroDeCuenta, DataBaseConexion conexion)
        {
            return conexion.VerificarCuentaExistente(numeroDeCuenta);
        }

        private bool ValidarCampos()
        {
            
            if (cbmTipo.SelectedItem == null || cbmTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Debes seleccionar un tipo de cuenta (Administrador o Usuario).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
               string.IsNullOrWhiteSpace(tbApellido.Text) ||
               string.IsNullOrWhiteSpace(tbTelefono.Text) ||
               string.IsNullOrWhiteSpace(tbCorreo.Text) ||
               string.IsNullOrWhiteSpace(tbDireccion.Text) ||
               string.IsNullOrWhiteSpace(tbPin1.Text) ||
               string.IsNullOrWhiteSpace(tbPin2.Text) ||
               string.IsNullOrWhiteSpace(tbMontoMaximo.Text) ||
               string.IsNullOrWhiteSpace(tbSaldo.Text))
            {
                MessageBox.Show("Favor de completar todos los campos.");
                return false;
            }

            if (tbPin1.Text.Length != 4)
            {
                MessageBox.Show("El PIN debe tener exactamente 4 dígitos.");
                return false;
            }

            if (tbPin1.Text != tbPin2.Text)
            {
                MessageBox.Show("El PIN no coincide.");
                return false;
            }

            if (tbTelefono.Text.Length != 8)
            {
                MessageBox.Show("El número de teléfono debe tener exactamente 8 dígitos.");
                return false;
            }

            if (!tbCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener un '@'.");
                return false;
            }

            if (!int.TryParse(tbMontoMaximo.Text, out int montoMaximo) || montoMaximo <= 0)
            {
                MessageBox.Show("Monto máximo a retirar debe ser un número entero positivo.");
                return false;
            }

            if (!decimal.TryParse(tbSaldo.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal saldo) || saldo < 0)
            {
                MessageBox.Show("Saldo debe ser un número decimal positivo.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            tbTelefono.Text = "";
            tbCorreo.Text = "";
            tbDireccion.Text = "";
            tbNoCuenta.Text = "";
            tbPin1.Text = "";
            tbPin2.Text = "";
            tbMontoMaximo.Text = "2000";
            tbSaldo.Text = "";
            cbmTipo.SelectedIndex = 0;
        }

        private int ObtenerSiguienteID(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                int ultimoID = lineas
                    .Select(linea => linea.Split('|').FirstOrDefault())
                    .Where(idString => int.TryParse(idString, out _))
                    .Select(idString => int.Parse(idString))
                    .DefaultIfEmpty(0)
                    .Max();
                return ultimoID + 1;
            }
            return 1;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void cbmTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
