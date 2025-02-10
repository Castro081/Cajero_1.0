// -----------------------------------------------------Dependencias-----------------------------------------------------------
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
using CajeroM = Cajero.Modelos.Cajero;
using UsuarioM = Cajero.Modelos.Usuario;

// -----------------------------------------------------Namespace y Clase-----------------------------------------------------------
namespace Cajero.Vistas.Usuario
{
    public partial class FrmAgregarDinero : Form
    {
        private CajeroM cajero;
        private UsuarioM usuario;
        private DataBaseConexion conexion;
        private Inicializacion inicializacion;

        // -----------------------------------------------------Constructor-----------------------------------------------------------
        public FrmAgregarDinero(DataBaseConexion conexion, UsuarioM usuario, CajeroM cajero)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.usuario = usuario;
            this.cajero = cajero;

            tbCantidad200.KeyPress += tbCantidad_KeyPress;
            tbCantidad100.KeyPress += tbCantidad_KeyPress;
            tbCantidad50.KeyPress += tbCantidad_KeyPress;
            tbCantidad20.KeyPress += tbCantidad_KeyPress;
            tbCantidad10.KeyPress += tbCantidad_KeyPress;
            tbCantidad5.KeyPress += tbCantidad_KeyPress;
            tbCantidad1.KeyPress += tbCantidad_KeyPress;

            verificarInicializacion();
        }
        // -----------------------------------------------------Variables-----------------------------------------------------------
        int cantidad1 = 0;
        int cantidad5 = 0;
        int cantidad10 = 0;
        int cantidad20 = 0;
        int cantidad50 = 0;
        int cantidad100 = 0;
        int cantidad200 = 0;

        int totalDinero = 0;


        int dineroCajero = 0;
        
        // Evento para agregar dinero al cajero cuando se hace clic en el botón.
        private void btnAgregarDinero_Click(object sender, EventArgs e)
        {
            if (inicializacion != null)
            {
                var saldo = conexion.ObtenerSaldoPorCajeroYFecha(cajero.Id, DateTime.Now);
                if (saldo.SaldoDisponible + totalDinero <= saldo.Limite)
                {
                    conexion.InsertarTransaccion(usuario.Id, "Agregar Dinero", totalDinero, cajero.Id);
                    conexion.ActualizarBilletes(cajero.Id, cajero.B200 + cantidad200, cajero.B100 + cantidad100, cajero.B50 + cantidad50, cajero.B20 + cantidad20, cajero.B10 + cantidad10, cajero.B5 + cantidad5, cajero.B1 + cantidad1);

                    conexion.ActualizarSaldo(saldo.Id, saldo.SaldoDisponible + totalDinero, DateTime.Now);
                    string descripcionBitacora = $"Agregar dinero al cajero";
                    string respuesta = conexion.InsertarBitacoraIA(usuario.Id, descripcionBitacora);
                    this.Close();
                    MessageBox.Show("Dinero agregado con éxito");
                    MessageBox.Show(respuesta);
                    return;
                }
                MessageBox.Show("El total a agregar super el limite del cajero");
            }
            else
            {
                if (totalDinero == 10000)
                {
                    int limite = 30000;
                    conexion.InsertarTransaccion(usuario.Id, "Inicializacion", totalDinero, cajero.Id);
                    conexion.InsertarInicializacion(cajero.Id, DateTime.Now);
                    conexion.ActualizarBilletes(cajero.Id, cantidad200, cantidad100, cantidad50, cantidad20, cantidad10, cantidad5, cantidad1);
                    conexion.InsertarSaldoCajero(totalDinero, limite, cajero.Id, DateTime.Now);
                    string descripcionBitacora = $"Inicializacion de cajero";
                    string respuesta = conexion.InsertarBitacoraIA(usuario.Id, descripcionBitacora);
                    this.Close();
                    MessageBox.Show("Cajero Inicializacon con éxito");
                    MessageBox.Show(respuesta);
                    return;
                }

                MessageBox.Show("La inicializacion debe ser igual a Q 10000");
            }
        }

        private void b_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -----------------------------------------------------Métodos Auxiliares-----------------------------------------------------------


        private void contabilizarDinero()
        {
            totalDinero = (200 * cantidad200) + (100 * cantidad100) + (50 * cantidad50) + (20 * cantidad20) + (10 * cantidad10) + (5 * cantidad5) + (1 * cantidad1);
            labelCantidad.Text = $"Q {totalDinero}";
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void verificarInicializacion()
        {
            DateTime fecha = DateTime.Now;
            cajero = conexion.ObtenerCajeroPorId(cajero.Id);
            inicializacion = conexion.ObtenerInicializacionPorCajeroYFecha(cajero.Id, fecha);
            if (inicializacion != null)
            {
                var saldo = conexion.ObtenerSaldoPorCajeroYFecha(cajero.Id, DateTime.Now);
                btnAgregarDinero.Text = "Agregar dinero al cajero";
                label1.Text = "Ingrese los billetes para agregar el cajero";
                labelDineroDisponible.Text = $"Dinero en el cajero: Q {saldo.SaldoDisponible}";
            }
            else{
                btnAgregarDinero.Text = "Inicializar cajero";
                label1.Text = "Ingrese los billetes para Inicializar el cajero";
            }
        }

        // -----------------------------------------------------Eventos de Botones-----------------------------------------------------------
        private void btCantidad_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                switch (btn.Name)
                {
                    case "btnAgregar1":
                        ActualizarCantidad(ref cantidad1, tbCantidad1);
                        break;
                    case "btnAgregar5":
                        ActualizarCantidad(ref cantidad5, tbCantidad5);
                        break;
                    case "btnAgregar10":
                        ActualizarCantidad(ref cantidad10, tbCantidad10);
                        break;
                    case "btnAgregar20":
                        ActualizarCantidad(ref cantidad20, tbCantidad20);
                        break;
                    case "btnAgregar50":
                        ActualizarCantidad(ref cantidad50, tbCantidad50);
                        break;
                    case "btnAgregar100":
                        ActualizarCantidad(ref cantidad100, tbCantidad100);
                        break;
                    case "btnAgregar200":
                        ActualizarCantidad(ref cantidad200, tbCantidad200);
                        break;
                }
                contabilizarDinero();
            }
        }

        private void ActualizarCantidad(ref int cantidad, TextBox tbCantidad)
        {
            cantidad++;
            tbCantidad.Text = cantidad.ToString();
        }

        private void pbQuitar_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            if (pb != null)
            {
                switch (pb.Name)
                {
                    case "pbQuitar1":
                        ActualizarCantidadQuitar(ref cantidad1, tbCantidad1, 1);
                        break;
                    case "pbQuitar5":
                        ActualizarCantidadQuitar(ref cantidad5, tbCantidad5, 1);
                        break;
                    case "pbQuitar10":
                        ActualizarCantidadQuitar(ref cantidad10, tbCantidad10, 1);
                        break;
                    case "pbQuitar20":
                        ActualizarCantidadQuitar(ref cantidad20, tbCantidad20, 1);
                        break;
                    case "pbQuitar50":
                        ActualizarCantidadQuitar(ref cantidad50, tbCantidad50, 1);
                        break;
                    case "pbQuitar100":
                        ActualizarCantidadQuitar(ref cantidad100, tbCantidad100, 1);
                        break;
                    case "pbQuitar200":
                        ActualizarCantidadQuitar(ref cantidad200, tbCantidad200, 1);
                        break;
                }

                contabilizarDinero();
            }
        }

        private void ActualizarCantidadQuitar(ref int cantidad, TextBox tbCantidad, int cambio)
        {
            if (cantidad > 0)
            {
                cantidad -= cambio;
                tbCantidad.Text = cantidad.ToString();
            }
        }

        private void tbCantidad1_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad1.Text.Length > 3)
            {
                tbCantidad1.Text = tbCantidad1.Text.Substring(0, 3);
                tbCantidad1.SelectionStart = tbCantidad1.Text.Length;
            }
            ActualizarCantidadDesdeTextBox(tbCantidad1, ref cantidad1);
        }

        private void tbCantidad5_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad5.Text.Length > 3)
            {
                tbCantidad5.Text = tbCantidad5.Text.Substring(0, 3);
                tbCantidad5.SelectionStart = tbCantidad5.Text.Length;
            }
            ActualizarCantidadDesdeTextBox(tbCantidad5, ref cantidad5);
        }

        private void tbCantidad10_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad10.Text.Length > 3)
            {
                tbCantidad10.Text = tbCantidad10.Text.Substring(0, 3);
                tbCantidad10.SelectionStart = tbCantidad10.Text.Length;
            }
            ActualizarCantidadDesdeTextBox(tbCantidad10, ref cantidad10);
        }

        private void tbCantidad20_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad20.Text.Length > 3)
            {
                tbCantidad20.Text = tbCantidad20.Text.Substring(0, 3);
                tbCantidad20.SelectionStart = tbCantidad20.Text.Length;
            }
            ActualizarCantidadDesdeTextBox(tbCantidad20, ref cantidad20);
        }

        private void tbCantidad50_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad50.Text.Length > 3)
            {
                tbCantidad50.Text = tbCantidad50.Text.Substring(0, 3);
                tbCantidad50.SelectionStart = tbCantidad50.Text.Length;
            }
            ActualizarCantidadDesdeTextBox(tbCantidad50, ref cantidad50);
        }

        private void tbCantidad100_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad100.Text.Length > 3)
            {
                tbCantidad100.Text = tbCantidad100.Text.Substring(0, 3);
                tbCantidad100.SelectionStart = tbCantidad100.Text.Length;
            }
            ActualizarCantidadDesdeTextBox(tbCantidad100, ref cantidad100);
        }

        private void tbCantidad200_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad200.Text.Length > 3)
            {
                tbCantidad200.Text = tbCantidad200.Text.Substring(0, 3);
                tbCantidad200.SelectionStart = tbCantidad200.Text.Length;
            }
            ActualizarCantidadDesdeTextBox(tbCantidad200, ref cantidad200);
        }

        private void ActualizarCantidadDesdeTextBox(TextBox textBox, ref int cantidad)
        {
            if (int.TryParse(textBox.Text, out int nuevaCantidad))
            {
                cantidad = nuevaCantidad;
            }
            else
            {
                cantidad = 0;
            }
            contabilizarDinero();
        }
    }
}
