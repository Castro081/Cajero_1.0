using Cajero.Conexion;
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

namespace Cajero.Vistas
{
    public partial class frmVentana : Form
    {
        public int OpcionSeleccionada { get; private set; }
        private CajeroM cajero;
        private DataBaseConexion conexion;
        public frmVentana(DataBaseConexion conexion, CajeroM cajero)
        {
            InitializeComponent();
            this.cajero = cajero;
            this.conexion = conexion;
            opciones();
        }

        private void opciones()
        {
            var cajeros = conexion.ObtenerTodosLosCajeros();
            foreach (var cajero in cajeros)
            {
                comboBoxOpciones.Items.Add(cajero.Id);
            }
            comboBoxOpciones.SelectedItem = cajero.Id;
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            OpcionSeleccionada = (int)comboBoxOpciones.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
