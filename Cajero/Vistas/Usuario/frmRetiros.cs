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
using UsuarioM = Cajero.Modelos.Usuario;
using CajeroM = Cajero.Modelos.Cajero;
using Cajero.Conexion;

namespace Cajero.Vistas
{
    public partial class frmRetiros : Form
    {
        private frmPanelUsuario frmPanelUsuario;
        private DataBaseConexion conexion;
        private UsuarioM usuario;
        private CajeroM cajero;
        private Saldo saldo;
        public frmRetiros(frmPanelUsuario frmPanelUsuario, DataBaseConexion conexion, UsuarioM usuario, CajeroM cajero)
        {
            InitializeComponent();
            this.frmPanelUsuario = frmPanelUsuario;
            this.conexion = conexion;
            this.usuario = usuario;
            this.cajero = cajero;
            this.saldo = conexion.ObtenerSaldoPorCajeroYFecha(cajero.Id, DateTime.Now);
            DineroDisponile();


            tbCantidad200.KeyPress += tbCantidad_KeyPress;
            tbCantidad100.KeyPress += tbCantidad_KeyPress;
            tbCantidad50.KeyPress += tbCantidad_KeyPress;
            tbCantidad20.KeyPress += tbCantidad_KeyPress;
            tbCantidad10.KeyPress += tbCantidad_KeyPress;
            tbCantidad5.KeyPress += tbCantidad_KeyPress;
            tbCantidad1.KeyPress += tbCantidad_KeyPress;
        }

        int cantidad1 = 0;
        int cantidad5 = 0;
        int cantidad10 = 0;
        int cantidad20 = 0;
        int cantidad50 = 0;
        int cantidad100 = 0;
        int cantidad200 = 0;
        int totalDinero = 0;
        int dineroCajero = 0;

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
        private void tbRetirar_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void DineroDisponile()
        {
            label1.Text = saldo.SaldoDisponible.ToString();
        }



        private void btCantidad_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                switch (btn.Name)
                {
                    case "btnRetirar1":
                        ActualizarCantidad(ref cantidad1, tbCantidad1);
                        break;
                    case "btnRetirar5":
                        ActualizarCantidad(ref cantidad5, tbCantidad5);
                        break;
                    case "btnRetirar10":
                        ActualizarCantidad(ref cantidad10, tbCantidad10);
                        break;
                    case "btnRetirar20":
                        ActualizarCantidad(ref cantidad20, tbCantidad20);
                        break;
                    case "btnRetirar50":
                        ActualizarCantidad(ref cantidad50, tbCantidad50);
                        break;
                    case "btnRetirar100":
                        ActualizarCantidad(ref cantidad100, tbCantidad100);
                        break;
                    case "btnRetirar200":
                        ActualizarCantidad(ref cantidad200, tbCantidad200);
                        break;
                }

                contabilizarDinero();
            }
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

        private void contabilizarDinero()
        {
            totalDinero = (200 * cantidad200) + (100 * cantidad100) + (50 * cantidad50) + (20 * cantidad20) + (10 * cantidad10) + (5 * cantidad5) + (1 * cantidad1);
            labelDinero.Text = $"Q {totalDinero}";
        }

        private void ActualizarCantidad(ref int cantidad, TextBox tbCantidad)
        {
            cantidad++;
            tbCantidad.Text = cantidad.ToString();
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

        private void btnRetirar_Click_1(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string dineroRetirar = labelDinero.Text;

            string dineroSinFormato = new string(dineroRetirar.Where(char.IsDigit).ToArray());

            int cantidadDinero;

            if (int.TryParse(dineroSinFormato, out cantidadDinero))
            {
                int cantidadRetirada = 0;
                List<Transaccion> transacciones = conexion.ObtenerTransaccionesPorCuentaDiaria(usuario.Id, fecha.Date);
                foreach (var transaccion in transacciones)
                {
                    if(transaccion.TipoTransaccion == "Retiro")
                    {
                        cantidadRetirada += transaccion.Monto;
                    }
                }
                if (cantidadRetirada + cantidadDinero > usuario.MontoMaximo)
                {
                    frmPanelUsuario.Show();
                    this.Close();
                    MessageBox.Show("La cantidad a retirar supera el monto máximo diario");
                    return;
                }
                int SaldoRestar = usuario.SaldoActual - cantidadDinero;
                if (SaldoRestar < 0)
                {
                    frmPanelUsuario.Show();
                    this.Close();
                    MessageBox.Show("Su Saldo es insuficiente para realizar la transaccion");
                    return;
                }
                if (cantidadDinero <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad mayor a 0");
                    labelDinero.Text = "0";

                }
                else if (cantidadDinero > saldo.SaldoDisponible)
                {
                    frmPanelUsuario.Show();
                    this.Close();
                    MessageBox.Show("La cantidad solicitada excede el total disponible en el cajero");
                    //labelDinero.Text = "0";
                    //cantidad1 = cantidad5 = cantidad10 = cantidad20 = cantidad50 =  cantidad100 = cantidad200 = totalDinero = dineroCajero = 0;
                    //contabilizarDinero();
                }
                else
                {
                    conexion.ActualizarBilletes(cajero.Id, cajero.B200 - cantidad200, cajero.B100 - cantidad100, cajero.B50 - cantidad50, cajero.B20 - cantidad20, cajero.B10 - cantidad10, cajero.B5 - cantidad5, cajero.B1 - cantidad1);
                    conexion.ActualizarSaldo(saldo.Id, saldo.SaldoDisponible - totalDinero, fecha);
                    conexion.InsertarTransaccion(usuario.Id, "Retiro", totalDinero, cajero.Id);
                    conexion.ActualizarSaldoCuenta(usuario.Id, usuario.SaldoActual - totalDinero);
                    frmPanelUsuario.Show();
                    this.Close();
                    MessageBox.Show("Retiro hecho exitosamente");
                }
            }
            else
            {
                // La conversión falló, manejar el error
                MessageBox.Show("Error al convertir la cantidad de dinero.");
            }

        }
    }
}
