using Cajero.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CajeroM = Cajero.Modelos.Cajero;

namespace Cajero.Conexion
{
    public class DataBaseConexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adaptador;
        DataSet ds;

        public DataBaseConexion()
        {

            cn = new SqlConnection("Data Source=DESKTOP-3JLMI6L;Initial Catalog=bd_Cajero;Integrated Security=True");
            AbrirConexion();
        }

        // Método para abrir la conexión
        private void AbrirConexion()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos: " + ex.ToString());
            }
        }

        // Método para cerrar la conexión
        private void CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        
        public string InsertarCliente(string nombre, string apellido, string telefono, string direccion, string correo)
        {
            string salida = "Se registró el Cliente Correctamente";
            string query = "INSERT INTO Cliente (Nombre, Apellido, Telefono, Direccion, Correo) VALUES (@Nombre, @Apellido, @Telefono, @Direccion, @Correo)";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.NVarChar) { Value = nombre });
                    cmd.Parameters.Add(new SqlParameter("@Apellido", SqlDbType.NVarChar) { Value = apellido });
                    cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.NVarChar) { Value = telefono });
                    cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar) { Value = direccion });
                    cmd.Parameters.Add(new SqlParameter("@Correo", SqlDbType.NVarChar) { Value = correo });

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        salida = "No se Insertó: No se afectó ninguna fila.";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                salida = "Error en la base de datos: " + sqlEx.Message;
            }
            catch (Exception ex)
            {
                salida = "Error inesperado: " + ex.Message;
            }
            return salida;
        }
        public string ActualizarCuenta(int idCuenta, string nuevoNoCuenta, string nuevoPin, int nuevoSaldo, int nuevoMontoMaximo, int nuevoTipoUsuario, bool nuevoPrimerInicio, int nuevoEstado)
        {
            string salida = "Cuenta actualizada correctamente.";
            string query = "UPDATE Cuenta SET No_Cuenta = @No_Cuenta, Pin = @Pin, Saldo = @Saldo, MontoMaximo = @MontoMaximo, Id_TipoUsuario = @Id_TipoUsuario, PrimerInicio = @PrimerInicio, Estado = @Estado " +
                           "WHERE Id_Cuenta = @Id_Cuenta";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@No_Cuenta", nuevoNoCuenta);
                    cmd.Parameters.AddWithValue("@Pin", nuevoPin);
                    cmd.Parameters.AddWithValue("@Saldo", nuevoSaldo);
                    cmd.Parameters.AddWithValue("@MontoMaximo", nuevoMontoMaximo);
                    cmd.Parameters.AddWithValue("@Id_TipoUsuario", nuevoTipoUsuario);
                    cmd.Parameters.AddWithValue("@PrimerInicio", nuevoPrimerInicio);
                    cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        salida = "No se actualizó: No se afectó ninguna fila.";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                salida = "Error en la base de datos: " + sqlEx.Message;
            }
            catch (Exception ex)
            {
                salida = "Error inesperado: " + ex.Message;
            }
            return salida;
        }

        public bool VerificarCuentaExistente(string numeroDeCuenta)
        {
            bool existe = false;

            try
            {
 
                string query = "SELECT COUNT(*) FROM Cuenta WHERE NumeroDeCuenta = @NumeroDeCuenta";

                using (var cmd = new SqlCommand(query, cn))
                {
                    
                    cmd.Parameters.AddWithValue("@NumeroDeCuenta", numeroDeCuenta);
                    int count = (int)cmd.ExecuteScalar();
                    existe = count > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error en la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }

            return existe;
        }

        public string ActualizarCliente1(int idCliente, string nuevoNombre, string nuevoApellido, string nuevoTelefono, string nuevaDireccion, string nuevoCorreo)
        {
            string salida = "Cliente actualizado correctamente.";
            string query = "UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion, Correo = @Correo " +
                           "WHERE Id_Cliente = @Id_Cliente";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@Apellido", nuevoApellido);
                    cmd.Parameters.AddWithValue("@Telefono", nuevoTelefono);
                    cmd.Parameters.AddWithValue("@Direccion", nuevaDireccion);
                    cmd.Parameters.AddWithValue("@Correo", nuevoCorreo);
                    cmd.Parameters.AddWithValue("@Id_Cliente", idCliente);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        salida = "No se actualizó: No se afectó ninguna fila.";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                salida = "Error en la base de datos: " + sqlEx.Message;
            }
            catch (Exception ex)
            {
                salida = "Error inesperado: " + ex.Message;
            }
            return salida;
        }

        public string InsertarCuenta(int idCliente, string noCuenta, string noPin, int saldo, int montoMaximo, int idTipo, bool primerInicio, int estado)
        {
            string salida = "Cuenta registrada correctamente";
            try
            {
                string query = "INSERT INTO Cuenta (Id_Cliente, No_Cuenta, No_Pin, Saldo, Monto_maximo, Id_tipo, Primer_inicio, Estado) " +
                               "VALUES (@Id_Cliente, @No_Cuenta, @No_Pin, @Saldo, @Monto_maximo, @Id_tipo, @Primer_inicio, @Estado)";

                cmd = new SqlCommand(query, cn);

             
                cmd.Parameters.AddWithValue("@Id_Cliente", idCliente);
                cmd.Parameters.AddWithValue("@No_Cuenta", noCuenta);
                cmd.Parameters.AddWithValue("@No_Pin", noPin);
                cmd.Parameters.AddWithValue("@Saldo", saldo);
                cmd.Parameters.AddWithValue("@Monto_maximo", montoMaximo);
                cmd.Parameters.AddWithValue("@Id_tipo", idTipo);
                cmd.Parameters.AddWithValue("@Primer_inicio", primerInicio ? 1 : 0);
                cmd.Parameters.AddWithValue("@Estado", estado); 

               
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error al registrar la cuenta: " + ex.ToString();
            }
            return salida;
        }
        public List<TipoUsuario> ObtenerTiposUsuarios()
        {
            List<TipoUsuario> tiposUsuarios = new List<TipoUsuario>();

            string query = "SELECT Id, Nombre FROM TiposUsuarios"; 
            try
            {
                using (cmd = new SqlCommand(query, cn))
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tiposUsuarios.Add(new TipoUsuario
                        {
                            Id = dr.GetInt32(dr.GetOrdinal("Id")),
                            Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return tiposUsuarios;
        }
        public int ObtenerUltimoIdCuenta()
        {
            int idCuenta = 0;
            string query = "SELECT MAX(Id_Cuenta) FROM Cuenta";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    object result = cmd.ExecuteScalar();
                    idCuenta = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error en la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }

            return idCuenta;
        }

        public int ObtenerUltimoIdCliente()
        {
            int idCliente = 0;
            string query = "SELECT MAX(Id_Cliente) FROM Cliente";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    object result = cmd.ExecuteScalar();
                    idCliente = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error en la base de datos: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }

            return idCliente;
        }

        public Usuario ObtenerCuenta(int IdCuenta)
        {
            Usuario usuario = null;

            string query = @"
                    SELECT c.Id_Cuenta, c.No_Cuenta, c.No_Pin, c.Saldo, c.Monto_maximo, c.No_Cuenta, c.No_pin, c.Id_tipo,
                           cl.Id_Cliente, cl.Nombre, cl.Apellido, cl.Telefono, cl.Direccion, cl.Correo, 
                           c.Primer_inicio, c.Estado 
                    FROM Cuenta c
                    INNER JOIN Cliente cl ON c.Id_Cliente = cl.Id_Cliente
                    WHERE c.Id_Cuenta = @Id_Cuenta";

            try
            {
                using (cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_Cuenta", IdCuenta);

                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("Id_Cuenta")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Apellido = dr.GetString(dr.GetOrdinal("Apellido")),
                                Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                NumeroTarjeta = dr.GetString(dr.GetOrdinal("No_Cuenta")),
                                Pin = dr.GetString(dr.GetOrdinal("No_pin")),
                                Id_Tipo = dr.GetInt32(dr.GetOrdinal("Id_tipo")),
                                SaldoActual = dr.GetInt32(dr.GetOrdinal("Saldo")),
                                MontoMaximo = dr.GetInt32(dr.GetOrdinal("Monto_maximo")),
                                PrimerInicio = dr.GetBoolean(dr.GetOrdinal("Primer_inicio")),
                                Estado = dr.GetBoolean(dr.GetOrdinal("Estado"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return usuario;
        }

        public List<Usuario> ObtenerCuentas()
        {
            Usuario usuario = null;

            string query = @"
                    SELECT c.Id_Cuenta, c.No_Cuenta, c.No_Pin, c.Saldo, c.Monto_maximo, c.No_Cuenta, c.No_pin, c.Id_tipo,
                           cl.Id_Cliente, cl.Nombre, cl.Apellido, cl.Telefono, cl.Direccion, cl.Correo, 
                           c.Primer_inicio, c.Estado 
                    FROM Cuenta c
                    INNER JOIN Cliente cl ON c.Id_Cliente = cl.Id_Cliente";

            List <Usuario> usuarios = new List<Usuario> ();

            try
            {
                using (cmd = new SqlCommand(query, cn))
                {
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("Id_Cuenta")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Apellido = dr.GetString(dr.GetOrdinal("Apellido")),
                                Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                NumeroTarjeta = dr.GetString(dr.GetOrdinal("No_Cuenta")),
                                Pin = dr.GetString(dr.GetOrdinal("No_pin")),
                                Id_Tipo = dr.GetInt32(dr.GetOrdinal("Id_tipo")),
                                SaldoActual = dr.GetInt32(dr.GetOrdinal("Saldo")),
                                MontoMaximo = dr.GetInt32(dr.GetOrdinal("Monto_maximo")),
                                PrimerInicio = dr.GetBoolean(dr.GetOrdinal("Primer_inicio")),
                                Estado = dr.GetBoolean(dr.GetOrdinal("Estado"))
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return usuarios;
        }

        public Usuario ObtenerCuentaPorNumero(string numeroCuenta)
        {
            Usuario usuario = null;

            string query = @"
        SELECT c.Id_Cuenta, c.No_Cuenta, c.No_Pin, c.Saldo, c.Monto_maximo, c.No_Cuenta, c.No_pin, c.Id_tipo,
               cl.Id_Cliente, cl.Nombre, cl.Apellido, cl.Telefono, cl.Direccion, cl.Correo, 
               c.Primer_inicio, c.Estado 
        FROM Cuenta c
        INNER JOIN Cliente cl ON c.Id_Cliente = cl.Id_Cliente
        WHERE c.No_Cuenta = @No_Cuenta";

            try
            {
                using (cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@No_Cuenta", numeroCuenta);

                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("Id_Cuenta")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Apellido = dr.GetString(dr.GetOrdinal("Apellido")),
                                Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                NumeroTarjeta = dr.GetString(dr.GetOrdinal("No_Cuenta")),
                                Pin = dr.GetString(dr.GetOrdinal("No_pin")),
                                Id_Tipo = dr.GetInt32(dr.GetOrdinal("Id_tipo")),
                                SaldoActual = dr.GetInt32(dr.GetOrdinal("Saldo")),
                                MontoMaximo = dr.GetInt32(dr.GetOrdinal("Monto_maximo")),
                                PrimerInicio = dr.GetBoolean(dr.GetOrdinal("Primer_inicio")),
                                Estado = dr.GetBoolean(dr.GetOrdinal("Estado"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return usuario;
        }

        public bool Desactivar(int usuarioId, bool estado)
        {
            try
            {    
                string query = "UPDATE Cuenta SET Estado = @Estado WHERE Id_Cuenta = @Id";

                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Estado", estado); 
                cmd.Parameters.AddWithValue("@Id", usuarioId); 

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desactivar el usuario: " + ex.Message);
                return false;
            }
        }

        public string ActualizarCliente(int idCliente, string nombre, string apellido, string telefono, string direccion, string correo)
        {
            string resultado;

            string query = "UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion, Correo = @Correo WHERE Id_Cliente = @IdCliente";

            try
            {

                cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Correo", correo);

                int rowsAffected = cmd.ExecuteNonQuery();

                resultado = rowsAffected > 0 ? "Cliente actualizado exitosamente." : "No se pudo actualizar el cliente.";
            }
            catch (Exception ex)
            {

                resultado = $"Error al actualizar cliente: {ex.Message}";
            }

            return resultado;
        }

        public string ActualizarCuenta(int idCliente, string numeroCuenta, string pin, decimal saldo, int montoMaximo)
        {
            string resultado;

            string query = "UPDATE Cuenta SET No_Cuenta = @NumeroCuenta, No_Pin = @Pin, Saldo = @Saldo, Monto_maximo = @MontoMaximo WHERE Id_Cliente = @IdCliente";

            try
            {

                cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                cmd.Parameters.AddWithValue("@Pin", pin);
                cmd.Parameters.AddWithValue("@Saldo", saldo);
                cmd.Parameters.AddWithValue("@MontoMaximo", montoMaximo);

                int rowsAffected = cmd.ExecuteNonQuery();

                resultado = rowsAffected > 0 ? "Cuenta actualizada exitosamente." : "No se pudo actualizar la cuenta.";
            }
            catch (Exception ex)
            {

                resultado = $"Error al actualizar cuenta: {ex.Message}";
            }

            return resultado;
        }

        public string InsertarBitacora(int idCuenta, string descripcion, int idUsuario)
        {
            string salida = "Bitácora registrada correctamente.";
            string query = "INSERT INTO Bitacora (Id_Cuenta, Descripcion, Id_Usuario, Fecha_Bitacora) " +
                           "VALUES (@Id_Cuenta, @Descripcion, @Id_Usuario, @Fecha_Bitacora)";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                  
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Fecha_Bitacora", DateTime.Now); 

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        salida = "No se insertó en la bitácora: No se afectó ninguna fila.";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                salida = "Error en la base de datos: " + sqlEx.Message;
            }
            catch (Exception ex)
            {
                salida = "Error inesperado: " + ex.Message;
            }

            return salida;
        }

        public string InsertarBitacoraIA(int idCuenta, string descripcion)
        {
            string salida = "Bitácora registrada correctamente.";
            string query = "INSERT INTO Bitacora (Id_Cuenta, Descripcion, Fecha_Bitacora) " +
                           "VALUES (@Id_Cuenta, @Descripcion, @Fecha_Bitacora)";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {

                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Fecha_Bitacora", DateTime.Now);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        salida = "No se insertó en la bitácora: No se afectó ninguna fila.";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                salida = "Error en la base de datos: " + sqlEx.Message;
            }
            catch (Exception ex)
            {
                salida = "Error inesperado: " + ex.Message;
            }

            return salida;
        }
        public DataTable ObtenerBitacora()
        {
            DataTable dt = new DataTable();
            string query = "SELECT Id_Cuenta, Descripcion, Id_Usuario, Fecha_Bitacora FROM Bitacora ORDER BY Id_Bitacora DESC";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt); // Llena el DataTable con los datos
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error en la consulta de la bitácora: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt; // Regresa el DataTable con los datos
        }
    

    public string DesactivarCuenta(int idCuenta)
        {
            string salida = "Cuenta desactivada correctamente.";
            string query = "UPDATE Cuenta SET Estado = 0 WHERE Id_Cuenta = @Id_Cuenta";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        salida = "No se pudo desactivar la cuenta: No se afectó ninguna fila.";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                salida = "Error en la base de datos: " + sqlEx.Message;
            }
            catch (Exception ex)
            {
                salida = "Error inesperado: " + ex.Message;
            }

            return salida;
        }

        public string ActualizarTipoCuenta(int idCliente, int nuevoTipoCuenta)
        {
            string resultado;

            string query = "UPDATE Cuenta SET Id_Tipo = @NuevoTipoCuenta WHERE Id_Cliente = @IdCliente";

            try
            {
                cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@NuevoTipoCuenta", nuevoTipoCuenta);

                int rowsAffected = cmd.ExecuteNonQuery();

                resultado = rowsAffected > 0 ? "Tipo de cuenta actualizado exitosamente." : "No se pudo actualizar el tipo de cuenta.";
            }
            catch (Exception ex)
            {

                resultado = $"Error al actualizar tipo de cuenta: {ex.Message}";
            }

            return resultado;
        }

        public bool ActualizarPin(int idCuenta, string nuevoPin)
        {
            bool actualizado = false;

            string query = @"
                            UPDATE Cuenta
                            SET No_Pin = @Nuevo_Pin
                            WHERE Id_Cuenta = @Id_Cuenta;";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Nuevo_Pin", nuevoPin);
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el PIN: " + ex.ToString());
            }

            return actualizado;
        }

        public bool ActualizarLimite(int idCuenta, int Monto_maximo)
        {
            bool actualizado = false;

            string query = @"
                            UPDATE Cuenta
                            SET Monto_maximo = @Monto_maximo
                            WHERE Id_Cuenta = @Id_Cuenta;";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Monto_maximo", Monto_maximo);
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el Monto Máximo: " + ex.ToString());
            }

            return actualizado;
        }

        public void ActualizarPrimerInicio(int idCuenta)
        {
            int Primer_inicio = 0;

            string query = @"
                            UPDATE Cuenta
                            SET Primer_inicio = @Primer_inicio
                            WHERE Id_Cuenta = @Id_Cuenta;";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Primer_inicio", Primer_inicio);
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el PIN: " + ex.ToString());
            }
        }

        public void ActualizarSaldoCuenta(int idCuenta, int Saldo)
        {
            string query = @"
                            UPDATE Cuenta
                            SET Saldo = @Saldo
                            WHERE Id_Cuenta = @Id_Cuenta;";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Saldo", Saldo);
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el Saldo: " + ex.ToString());
            }
        }


        public void InsertarModificacion(int idCuenta, string descripcion)
        {
            DateTime fechaActual = DateTime.Now;
            string query = @"
                    INSERT INTO Modificacion (Id_Cuenta, Fecha_Modificacion, Tipo_modificacion)
                    VALUES (@Id_Cuenta, @Fecha_Modificacion, @Tipo_modificacion)";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);
                    cmd.Parameters.AddWithValue("@Fecha_Modificacion", fechaActual);
                    cmd.Parameters.AddWithValue("@Tipo_modificacion", descripcion);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public List<InicioSesion> ObtenerInicioSesiones()
        {
            List<InicioSesion> sesiones = new List<InicioSesion>();
            string query = @"
                        SELECT i.Id_Login, CONCAT(cli.Nombre, ' ', cli.Apellido) AS Nombre, i.Fecha_inicio, i.Id_Cajero
                        FROM Inicio_sesion i
                        INNER JOIN Cuenta c on i.Id_Cuenta = c.Id_Cuenta 
                        INNER JOIN cliente cli on c.Id_Cliente = cli.Id_Cliente
                        ORDER BY Id_Login DESC;";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var sesion = new InicioSesion
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id_Login")),
                                Cuenta = reader.GetString(reader.GetOrdinal("Nombre")),
                                FechaInicio = reader.GetDateTime(reader.GetOrdinal("Fecha_inicio")),
                                Id_Cajero = reader.GetInt32(reader.GetOrdinal("Id_Cajero"))
                            };
                            sesiones.Add(sesion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las sesiones: " + ex.Message);
            }

            return sesiones;
        }

        public void InsertarCajero()
        {
            string query = @"
                    INSERT INTO Cajero (Estado, B200, B100, B50, B20, B10, B5, B1)
                    VALUES (@Estado, @B200, @B100, @B50, @B20, @B10, @B5, @B1)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // Agregar parámetros con los valores correspondientes
                    cmd.Parameters.AddWithValue("@Estado", 1);
                    cmd.Parameters.AddWithValue("@B200", 0);
                    cmd.Parameters.AddWithValue("@B100", 0);
                    cmd.Parameters.AddWithValue("@B50", 0);
                    cmd.Parameters.AddWithValue("@B20", 0);
                    cmd.Parameters.AddWithValue("@B10", 0);
                    cmd.Parameters.AddWithValue("@B5", 0);
                    cmd.Parameters.AddWithValue("@B1", 0);

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cajero insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cajero: " + ex.Message);
            }
        }


        public CajeroM ObtenerCajeroPorId(int idCajero)
        {
            CajeroM cajero = null;

            string query = @"
            SELECT *
            FROM Cajero
            WHERE Id_Cajero = @IdCajero"; 

            try
            {

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCajero", idCajero);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            cajero = new CajeroM
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("Id_Cajero")),
                                Estado = dr.GetBoolean(dr.GetOrdinal("Estado")),
                                B200 = dr.GetInt32(dr.GetOrdinal("B200")),
                                B100 = dr.GetInt32(dr.GetOrdinal("B100")),
                                B50 = dr.GetInt32(dr.GetOrdinal("B50")),
                                B20 = dr.GetInt32(dr.GetOrdinal("B20")),
                                B10 = dr.GetInt32(dr.GetOrdinal("B10")),
                                B5 = dr.GetInt32(dr.GetOrdinal("B5")),
                                B1 = dr.GetInt32(dr.GetOrdinal("B1"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el cajero: " + ex.ToString());
            }
            return cajero;
        }

        public List<CajeroM> ObtenerTodosLosCajeros()
        {
            List<CajeroM> cajeros = new List<CajeroM>();

            string query = @"
                        SELECT *
                        FROM Cajero";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CajeroM cajero = new CajeroM
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("Id_Cajero")),
                                Estado = dr.GetBoolean(dr.GetOrdinal("Estado")),
                                B200 = dr.GetInt32(dr.GetOrdinal("B200")),
                                B100 = dr.GetInt32(dr.GetOrdinal("B100")),
                                B50 = dr.GetInt32(dr.GetOrdinal("B50")),
                                B20 = dr.GetInt32(dr.GetOrdinal("B20")),
                                B10 = dr.GetInt32(dr.GetOrdinal("B10")),
                                B5 = dr.GetInt32(dr.GetOrdinal("B5")),
                                B1 = dr.GetInt32(dr.GetOrdinal("B1"))
                            };

                            cajeros.Add(cajero);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los cajeros: " + ex.Message);
            }

            return cajeros;
        }


        public Saldo ObtenerSaldoPorCajeroYFecha(int idCajero, DateTime fechaSaldo)
        {
            Saldo saldo = null; 

            string query = @"
                    SELECT TOP 1 Id_Saldo, Saldo, Limite, Id_Cajero, Fecha_Saldo
                    FROM Saldo
                    WHERE Id_Cajero = @IdCajero
                    AND CAST(Fecha_Saldo AS DATE) = @FechaSaldo";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCajero", idCajero);
                    cmd.Parameters.AddWithValue("@FechaSaldo", fechaSaldo.Date);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            saldo = new Saldo
                            {
                                Id = dr.GetInt32(dr.GetOrdinal("Id_Saldo")),
                                SaldoDisponible = dr.GetInt32(dr.GetOrdinal("Saldo")),
                                Limite = dr.GetInt32(dr.GetOrdinal("Limite")),
                                IdCajero = dr.GetInt32(dr.GetOrdinal("Id_Cajero")),
                                FechaSaldo = dr.GetDateTime(dr.GetOrdinal("Fecha_Saldo"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            return saldo;
        }

        public void ActualizarBilletes(int idCajero, int b200, int b100, int b50, int b20, int b10, int b5, int b1)
        {
            string query = @"
                    UPDATE Cajero
                    SET B200 = @B200, B100 = @B100, B50 = @B50, B20 = @B20, B10 = @B10, B5 = @B5, B1 = @B1
                    WHERE Id_Cajero = @Id_Cajero";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_Cajero", idCajero);
                    cmd.Parameters.AddWithValue("@B200", b200);
                    cmd.Parameters.AddWithValue("@B100", b100);
                    cmd.Parameters.AddWithValue("@B50", b50);
                    cmd.Parameters.AddWithValue("@B20", b20);
                    cmd.Parameters.AddWithValue("@B10", b10);
                    cmd.Parameters.AddWithValue("@B5", b5);
                    cmd.Parameters.AddWithValue("@B1", b1);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los billetes: " + ex.ToString());
            }
        }

        public void ActualizarSaldo(int idSaldo, int nuevoSaldo, DateTime fechaSaldo)
        {
            string query = @"
                    UPDATE Saldo
                    SET Saldo = @NuevoSaldo
                    WHERE Id_Saldo = @Id_Saldo";

            try
            {
                using (var cmd = new SqlCommand(query, cn)) 
                {
                    cmd.Parameters.AddWithValue("@Id_Saldo", idSaldo);
                    cmd.Parameters.AddWithValue("@NuevoSaldo", nuevoSaldo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el saldo: " + ex.ToString());
            }
        }

        public void InsertarTransaccion(int idCuenta, string tipoTransaccion, int monto, int idCajero)
        {
            string query = @"
                INSERT INTO Transacciones (Id_Cuenta, Tipo_Transaccion, Monto, Fecha_Transaccion, Id_Cajero)
                VALUES (@Id_Cuenta, @Tipo_Transaccion, @Monto, @Fecha_Transaccion, @Id_Cajero)";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);
                    cmd.Parameters.AddWithValue("@Tipo_Transaccion", tipoTransaccion);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@Fecha_Transaccion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Id_Cajero", idCajero);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la transacción: " + ex.Message);
            }
        }

        public List<Transaccion> ObtenerTransaccionesPorCuenta(int idCuenta)
        {
            string query = @"
                SELECT Id_Transaccion, Id_Cuenta, Tipo_Transaccion, Monto, Fecha_Transaccion, Id_Cajero
                FROM Transacciones
                WHERE Id_Cuenta = @Id_Cuenta";

            List<Transaccion> transacciones = new List<Transaccion>();

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaccion transaccion = new Transaccion
                            {
                                Id = reader.GetInt32(0),
                                IdCuenta = reader.GetInt32(1),
                                TipoTransaccion = reader.GetString(2),
                                Monto = reader.GetInt32(3),
                                FechaTransaccion = reader.GetDateTime(4),
                                IdCajero = reader.GetInt32(5)
                            };
                            transacciones.Add(transaccion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las transacciones: " + ex.Message);
            }

            return transacciones;
        }

        public List<Transaccion> ObtenerTransaccionesPorCuentaDiaria(int idCuenta, DateTime Fecha_Transaccion)
        {
            string query = @"
                SELECT Id_Transaccion, Id_Cuenta, Tipo_Transaccion, Monto, Fecha_Transaccion, Id_Cajero
                FROM Transacciones
                WHERE Id_Cuenta = @Id_Cuenta AND CAST(Fecha_Transaccion AS DATE) = @Fecha_Transaccion";

            List<Transaccion> transacciones = new List<Transaccion>();

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_Cuenta", idCuenta);
                    cmd.Parameters.AddWithValue("@Fecha_Transaccion", Fecha_Transaccion);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaccion transaccion = new Transaccion
                            {
                                Id = reader.GetInt32(0),
                                IdCuenta = reader.GetInt32(1),
                                TipoTransaccion = reader.GetString(2),
                                Monto = reader.GetInt32(3),
                                FechaTransaccion = reader.GetDateTime(4),
                                IdCajero = reader.GetInt32(5)
                            };
                            transacciones.Add(transaccion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las transacciones: " + ex.Message);
            }

            return transacciones;
        }

        public Inicializacion ObtenerInicializacionPorCajeroYFecha(int idCajero, DateTime fecha)
        {
            string query = @"
                SELECT TOP 1 Id_Inicializacion, Id_Cajero, Fecha_inicializacion
                FROM Inicializacion
                WHERE Id_Cajero = @IdCajero
                AND CAST(Fecha_inicializacion AS DATE) = @Fecha";

            Inicializacion inicializacion = null;

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCajero", idCajero);
                    cmd.Parameters.AddWithValue("@Fecha", fecha.Date);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            inicializacion = new Inicializacion
                            {
                                Id = reader.GetInt32(0),
                                IdCajero = reader.GetInt32(1),
                                FechaInicializacion = reader.GetDateTime(2)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la inicialización: " + ex.Message);
            }

            return inicializacion;
        }

        public List<Inicializacion> ObtenerInicializaciones()
        {
            string query = @"
                SELECT TOP 1 Id_Inicializacion, Id_Cajero, Fecha_inicializacion
                FROM Inicializacion";

            List<Inicializacion> inicializacion = new List<Inicializacion>();

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Inicializacion ini = new Inicializacion
                            {
                                Id = reader.GetInt32(0),
                                IdCajero = reader.GetInt32(1),
                                FechaInicializacion = reader.GetDateTime(2)
                            };
                            inicializacion.Add(ini);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la inicialización: " + ex.Message);
            }

            return inicializacion;
        }

        public void InsertarInicializacion(int idCajero, DateTime fechaInicializacion)
        {
            string query = @"
                    INSERT INTO Inicializacion (Id_Cajero, Fecha_inicializacion)
                    VALUES (@IdCajero, @FechaInicializacion)";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@IdCajero", idCajero);
                    cmd.Parameters.AddWithValue("@FechaInicializacion", fechaInicializacion);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la inicialización: " + ex.Message);
            }
        }

        public void InsertarSaldoCajero(int saldo, int limite, int idCajero, DateTime fechaSaldo)
        {
            string query = @"
        INSERT INTO Saldo (Saldo, Limite, Id_Cajero, Fecha_Saldo)
        VALUES (@Saldo, @Limite, @IdCajero, @FechaSaldo)";

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Saldo", saldo);
                    cmd.Parameters.AddWithValue("@Limite", limite);
                    cmd.Parameters.AddWithValue("@IdCajero", idCajero);
                    cmd.Parameters.AddWithValue("@FechaSaldo", fechaSaldo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el saldo: " + ex.Message);
            }
        }

        public (int totalRetiros, int cantidadRetiros) ObtenerSumaYCantidadDeRetiros()
        {
            string query = @"
                    SELECT SUM(Monto) AS TotalRetiros, COUNT(*) AS CantidadRetiros
                    FROM Transacciones
                    WHERE Tipo_Transaccion = 'Retiro'";

            int totalRetiros = 0;
            int cantidadRetiros = 0;

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalRetiros = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            cantidadRetiros = reader.IsDBNull(1) ? 0 : reader.GetInt32(1); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la suma y cantidad de retiros: " + ex.Message);
            }

            return (totalRetiros, cantidadRetiros);
        }

        public (int totalDepositos, int cantidadDepositos) ObtenerSumaYCantidadDeDepositos()
        {
            string query = @"
                    SELECT SUM(Monto) AS TotalDepositos, COUNT(*) AS CantidadDepositos
                    FROM Transacciones
                    WHERE Tipo_Transaccion = 'Deposito'";

            int totalDepositos = 0;
            int cantidadDepositos = 0;

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalDepositos = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                            cantidadDepositos = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la suma y cantidad de depósitos: " + ex.Message);
            }

            return (totalDepositos, cantidadDepositos);
        }

        public int CantidadUsuario()
        {
            string query = @"
                    SELECT COUNT(*) AS Usuario
                    FROM Cuenta
                    WHERE Id_tipo = 1";

            int totalUsuarios = 0;

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalUsuarios = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la cantidad de usuarios: " + ex.Message);
            }

            return totalUsuarios;
        }

        public int CantidadCambiosPin()
        {
            string query = @"
                    SELECT COUNT(*) AS Cambios
                    FROM Modificacion
                    WHERE Tipo_modificacion = 'Cambio de PIN'"; 

            int total = 0;

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            total = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la cantidad de cambios: " + ex.Message);
            }

            return total;
        }

        public List<Modificacion> ObtenerCambiosPin()
        {
            string query = @"
                    SELECT m.Id_Modificacion, cli.Nombre AS Usuario, m.Fecha_Modificacion, m.Tipo_modificacion 
                    FROM Modificacion m
                    INNER JOIN Cuenta c on c.Id_Cliente = m.Id_Cuenta
                    INNER JOIN Cliente cli on cli.Id_Cliente = c.Id_Cuenta
                    WHERE Tipo_modificacion = 'Cambio de PIN'";

            List<Modificacion> modificaciones = new List<Modificacion>();

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Modificacion modificacion = new Modificacion
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id_Modificacion")),
                                usuario = reader.GetString(reader.GetOrdinal("Usuario")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha_Modificacion")),
                                TipoModificacion = reader.GetString(reader.GetOrdinal("Tipo_modificacion"))
                            };

                            modificaciones.Add(modificacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las modificaciones: " + ex.Message);
            }

            return modificaciones;
        }


        public int ObtenerPromedioTransacciones()
        {
            string query = @"
                    SELECT AVG(Monto) AS Promedio
                    FROM Transacciones
                    WHERE Tipo_Transaccion = 'Retiro' or Tipo_Transaccion = 'Deposito'";

            int promedio = 0;

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            promedio = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el promedio de transacciones: " + ex.Message);
            }

            return promedio;
        }

        public List<Transaccion> ObtenerTransacciones()
        {
            string query = @"
                SELECT Id_Transaccion, Id_Cuenta, Tipo_Transaccion, Monto, Fecha_Transaccion, Id_Cajero
                FROM Transacciones";

            List<Transaccion> transacciones = new List<Transaccion>();

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaccion transaccion = new Transaccion
                            {
                                Id = reader.GetInt32(0),
                                IdCuenta = reader.GetInt32(1),
                                TipoTransaccion = reader.GetString(2),
                                Monto = reader.GetInt32(3),
                                FechaTransaccion = reader.GetDateTime(4),
                                IdCajero = reader.GetInt32(5)
                            };
                            transacciones.Add(transaccion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las transacciones: " + ex.Message);
            }

            return transacciones;
        }

        public Dictionary<int, Dictionary<string, int>> ObtenerConteoTransaccionesPorCajero()
        {
            string query = @"
                    SELECT Id_Cajero, Tipo_Transaccion, COUNT(*) AS Cantidad
                    FROM Transacciones
                    GROUP BY Id_Cajero, Tipo_Transaccion;";

            Dictionary<int, Dictionary<string, int>> resultado = new Dictionary<int, Dictionary<string, int>>();

            try
            {
                using (var cmd = new SqlCommand(query, cn))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int idCajero = dr.GetInt32(dr.GetOrdinal("Id_Cajero"));
                            string tipoTransaccion = dr.GetString(dr.GetOrdinal("Tipo_Transaccion"));
                            int cantidad = dr.GetInt32(dr.GetOrdinal("Cantidad"));

                            if (!resultado.ContainsKey(idCajero))
                            {
                                resultado[idCajero] = new Dictionary<string, int>();
                            }

                            resultado[idCajero][tipoTransaccion] = cantidad;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el conteo de transacciones: " + ex.Message);
            }

            return resultado;
        }




    }
}
