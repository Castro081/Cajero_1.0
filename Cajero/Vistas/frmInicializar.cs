// -----------------------------------------------------Dependencias-----------------------------------------------------------
using Cajero.Conexion;
using Cajero.Modelos;
using Cajero.Vistas.Usuario;
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

namespace Cajero.Vistas
{
    public partial class frmInicializar : Form
    {
        // -----------------------------------------------------Campos Privados-----------------------------------------------------------
        private Datos datos;
        private UsuarioM usuario;
        private DataBaseConexion conexion;
        private CajeroM cajero;
        private int idCajero = 1;
        // -----------------------------------------------------Constructor-----------------------------------------------------------
        public frmInicializar(DataBaseConexion conexion, UsuarioM usuario, CajeroM cajero)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.usuario = usuario;
            this.cajero = cajero;
        }

        // -----------------------------------------------------Eventos de Botones-----------------------------------------------------------
        // Evento para el botón que inicializa los cajeros
        private void button3_Click(object sender, EventArgs e)
        {
            frmVentana formSelector = new frmVentana(conexion, cajero);
            if (formSelector.ShowDialog() == DialogResult.OK)
            {
                int opcionSeleccionada = formSelector.OpcionSeleccionada;
                var cajero = conexion.ObtenerCajeroPorId(opcionSeleccionada);
                var inicializacion = conexion.ObtenerInicializacionPorCajeroYFecha(cajero.Id, DateTime.Now);
                if (inicializacion == null)
                {
                    FrmAgregarDinero agregarDineroForm = new FrmAgregarDinero(conexion, usuario, cajero);
                    agregarDineroForm.Show();
                    return;
                }
            }
            else
            {
                return;
            }
            MessageBox.Show("Cajero ya inicializado");
        }

        // Evento para el botón que abre el formulario para agregar dinero a un cajero
        private void btnFondos_Click(object sender, EventArgs e)
        {
            frmVentana formSelector = new frmVentana(conexion, cajero);
            if (formSelector.ShowDialog() == DialogResult.OK)
            {
                int opcionSeleccionada = formSelector.OpcionSeleccionada;
                var cajero = conexion.ObtenerCajeroPorId(opcionSeleccionada);
                var inicializacion = conexion.ObtenerInicializacionPorCajeroYFecha(cajero.Id, DateTime.Now);
                if (inicializacion != null)
                {
                    FrmAgregarDinero agregarDineroForm = new FrmAgregarDinero(conexion, usuario, cajero);
                    agregarDineroForm.Show();
                    return;
                }
            }
            else
            {
                return;
            }
            MessageBox.Show("El cajero no esta inicializado");
        }

        private void btnAgregarCajero_Click(object sender, EventArgs e)
        {
            conexion.InsertarCajero();
            MessageBox.Show("Cajero nuevo agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
