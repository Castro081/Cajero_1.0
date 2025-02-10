using Cajero.Conexion;
using Cajero.Modelos;
using Cajero.Vistas;
using System.Drawing.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cajero
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Datos datos = new Datos();
            DataBaseConexion conexion = new DataBaseConexion();
            Task.Run(() => VerificarCambioDeDia(datos, conexion));
            //Application.Run(new Vistas.frmPrincipalAdmi()); 
            Application.Run(new Vistas.frmLogin(datos, conexion));
            //Application.Run(new Principal());
        }
        static async Task VerificarCambioDeDia(Datos datos, DataBaseConexion conexion)
        {
            DateTime lastCheck = DateTime.Now.Date;
            DateTime fecha = DateTime.Now.Date;
            string fechaFormat = fecha.ToString("dd/MM/yyyy");

            while (true)
            {
                // Verificamos si ha cambiado el día
                if (DateTime.Now.Date > lastCheck)
                {

                    // Actualizamos la fecha de la última comprobación
                    lastCheck = DateTime.Now.Date;



                    var cajeross = conexion.ObtenerTodosLosCajeros();
                    foreach (var cajero in cajeross)
                    {
                        conexion.ActualizarBilletes(cajero.Id, 0, 0, 0, 0, 0, 0, 0);
                    }



                }

                var cajeros = conexion.ObtenerTodosLosCajeros();
                foreach (var cajero in cajeros)
                {
                    var inicialicacion = conexion.ObtenerInicializacionPorCajeroYFecha(cajero.Id, DateTime.Now);
                    if (inicialicacion == null)
                    {
                        conexion.ActualizarBilletes(cajero.Id, 0, 0, 0, 0, 0, 0, 0);
                    }
                }



                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}