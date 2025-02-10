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
namespace Cajero.Vistas
{
    public partial class frmConsultaSaldo : Form
    {
        private frmPanelUsuario frmPanelUsuario;
        private UsuarioM usuario;
        public frmConsultaSaldo(frmPanelUsuario frmPanelUsuario, UsuarioM usuario)
        {
            InitializeComponent();
            this.frmPanelUsuario = frmPanelUsuario;
            this.usuario = usuario;
            this.labelSaldo.Text = $"Su saldo restante es de:\nQ{usuario.SaldoActual}";
        }

        private void b_regresar_Click(object sender, EventArgs e)
        {
            frmPanelUsuario.Show();
            this.Close();
        }
    }
}
