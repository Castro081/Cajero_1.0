using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CajeroM = Cajero.Modelos.Cajero;

namespace Cajero.Modelos
{
    public class Datos
    {
        public List<Usuario> usuarios;
        public List<ModificacionUsuario> modificacionesUsuario;
        public List<Movimiento> movimientos;
        public List<DetalleMovimiento> detalleMovimientos;
        public List<Cajero> cajeros;
        public Datos()
        {
            usuarios = new List<Usuario>();
            modificacionesUsuario = new List<ModificacionUsuario>();
            movimientos = new List<Movimiento>();
            detalleMovimientos = new List<DetalleMovimiento>();
            cajeros = new List<Cajero>();

            LeerDatosUsuarios();
            LeerDatosModificacionesUsuario();
            LeerDatosMovimientos();
            LeerDatosDetallesMovimientos();

        }

        public void LeerDatosUsuarios()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory + "/Datos", "Usuarios.txt");

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }

            usuarios.Clear();

            foreach (var linea in File.ReadAllLines(path))
            {
                // Verificamos si la línea no está vacía
                if (string.IsNullOrWhiteSpace(linea))
                {
                    continue; // Saltar líneas vacías
                }

                var campos = linea.Split('|');

                if (campos.Length < 12)
                {
                    // Podrías loggear un error aquí o simplemente continuar con la siguiente línea
                    Console.WriteLine($"Línea con formato incorrecto: {linea}");
                    continue;
                }


                try
                {
                    var usuario = new Usuario
                    {
                        Id = int.Parse(campos[0]),
                        Nombre = campos[1],
                        Apellido = campos[2],
                        Direccion = campos[3],
                        Telefono = campos[4],
                        Correo = campos[5],
                        NumeroTarjeta = campos[6],
                        Pin = campos[7],
                        SaldoActual = int.Parse(campos[8]),
                        MontoMaximo = int.Parse(campos[9]),
                        PrimerInicio = bool.Parse(campos[10]),
                        Estado = bool.Parse(campos[11])
                    };

                    usuarios.Add(usuario);
                }
                catch (FormatException ex)
                {
                    // Aquí puedes manejar los errores de conversión de tipos, como errores al convertir strings a enteros
                    Console.WriteLine($"Error al procesar la línea: {linea}. Error: {ex.Message}");
                }
            }
        }
        public void GuardarDatosUsuarios()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory + "/Datos", "Usuarios.txt");
            var lineas = new List<string>();

            foreach (var usuario in usuarios)
            {
                lineas.Add($"{usuario.Id}|{usuario.Nombre}|{usuario.Apellido}|{usuario.Direccion}|{usuario.Telefono}|{usuario.Correo}|{usuario.NumeroTarjeta}|{usuario.Pin}|{usuario.SaldoActual}|{usuario.MontoMaximo}|{usuario.PrimerInicio}|{usuario.Estado}");
            }

            File.WriteAllLines(path, lineas);
        }

        public Usuario login(string numeroTarjeta, string pin)
        {
            return usuarios.FirstOrDefault(u => u.NumeroTarjeta == numeroTarjeta && u.Pin == pin);
        }

        public void CambiarPin(int id, string pin)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.Id == id)
                {
                    usuario.Pin = pin;
                    usuario.PrimerInicio = false;
                    break;
                }
            }
        }
        public void ActualizarSaldo(int id, int saldo)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.Id == id)
                {
                    usuario.SaldoActual = saldo;
                    break;
                }
            }
        }
        public void CambiarMontoMaximo(int id, int monto)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.Id == id)
                {
                    usuario.MontoMaximo = monto;
                    break;
                }
            }
        }

        public void Desactivar(int id, Boolean estado)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.Id == id)
                {
                    usuario.Estado = estado;
                    break;
                }
            }
        }

        public Usuario BuscarUsuario(int id)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.Id == id)
                {
                    return usuario;
                }
            }
            return null;
        }

        public Usuario BuscarUsuarioNoCuenta(string noCuenta)
        {
            foreach (var usuario in usuarios)
            {
                if (usuario.NumeroTarjeta == noCuenta)
                {
                    return usuario;
                }
            }
            return null;
        }


        // Historial de Modificaciones de datos de los usuarios
        public void LeerDatosModificacionesUsuario()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory + "/Datos", "ModificacionesUsuario.txt");

            modificacionesUsuario.Clear();

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                }
            }


            foreach (var linea in File.ReadAllLines(path))
            {
                var campos = linea.Split('|');

                var modificacion = new ModificacionUsuario
                {
                    Id = int.Parse(campos[0]),
                    IdUsuario = int.Parse(campos[1]),
                    Fecha = campos[2],
                    TipoModificacion = campos[3],
                    DatoAnterior = campos[4],
                    DatoActualizado = campos[5],
                };

                modificacionesUsuario.Add(modificacion);

            }
        }

        public void GuardarDatosMoficaciones()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory + "/Datos", "ModificacionesUsuario.txt");
            var lineas = new List<string>();

            foreach (var modificacion in modificacionesUsuario)
            {
                lineas.Add($"{modificacion.Id}|{modificacion.IdUsuario}|{modificacion.Fecha}|{modificacion.TipoModificacion}|{modificacion.DatoAnterior}|{modificacion.DatoActualizado}");
            }

            File.WriteAllLines(path, lineas);
        }

        public void AgregarModificacion(int idUsuario, string fecha, string tipoModificacion, string datoAnt, string datoAct)
        {
            int nuevoId = modificacionesUsuario.Count > 0 ? modificacionesUsuario.Max(m => m.Id) + 1 : 0;
            var modificacion = new ModificacionUsuario
            {
                Id = nuevoId,
                IdUsuario = idUsuario,
                Fecha = fecha,
                TipoModificacion = tipoModificacion,
                DatoAnterior = datoAnt,
                DatoActualizado = datoAct,
            };
            modificacionesUsuario.Add(modificacion);
        }

        public List<ModificacionUsuario> ObtenerModificacion(string tipo)
        {
            List<ModificacionUsuario> modUsuario = new List<ModificacionUsuario>();
            foreach (var modificacion in modificacionesUsuario)
            {
                if (modificacion.TipoModificacion == tipo)
                {
                    modUsuario.Add(modificacion);
                }
            }
            return modUsuario;
        }

        // Movimientos (depositos y retiros) -----------------------------------------------------------------------------------------

        public void LeerDatosMovimientos()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory + "/Datos", "Movimientos.txt");

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                }
            }

            movimientos.Clear();

            foreach (var linea in File.ReadAllLines(path))
            {
                var campos = linea.Split('|');

                var movimiento = new Movimiento
                {
                    Id = int.Parse(campos[0]),
                    IdCajero = int.Parse(campos[1]),
                    IdUsuario = int.Parse(campos[2]),
                    Operacion = campos[3],
                    Fecha = campos[4],
                };

                movimientos.Add(movimiento);

            }
        }

        public void GuardarDatosMovimientos()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory + "/Datos", "Movimientos.txt");
            var lineas = new List<string>();

            foreach (var movimiento in movimientos)
            {
                lineas.Add($"{movimiento.Id}|{movimiento.IdCajero}|{movimiento.IdUsuario}|{movimiento.Operacion}|{movimiento.Fecha}");
            }

            File.WriteAllLines(path, lineas);
        }
        public Movimiento AgregarMovimiento(int idCajero, int idUsuario, string operacion, string fecha)
        {
            int nuevoId = movimientos.Count > 0 ? movimientos.Max(m => m.Id) + 1 : 0;
            var movimiento = new Movimiento
            {
                Id = nuevoId,
                IdCajero = idCajero,
                IdUsuario = idUsuario,
                Operacion = operacion,
                Fecha = fecha
            };
            movimientos.Add(movimiento);
            return movimiento;
        }

        public List<Movimiento> ObtenerMovimientos(int idUsuario)
        {
            List<Movimiento> movUsuario = new List<Movimiento>();
            foreach (var movimiento in movimientos)
            {
                if (movimiento.IdUsuario == idUsuario)
                {
                    movUsuario.Add(movimiento);
                }
            }
            return movUsuario;
        }
        public List<Movimiento> CajeroDinero(string fecha, int idCajero)
        {
            List<Movimiento> dineroCajero = new List<Movimiento>();
            foreach (var movimiento in movimientos)
            {
                if (movimiento.Fecha == fecha && movimiento.IdCajero == idCajero)
                {
                    dineroCajero.Add(movimiento);
                }
            }
            return dineroCajero;
        }

        public List<Movimiento> MovimientosDia(string fecha)
        {
            List<Movimiento> dineroCajero = new List<Movimiento>();
            foreach (var movimiento in movimientos)
            {
                if (movimiento.Fecha == fecha)
                {
                    dineroCajero.Add(movimiento);
                }
            }
            return dineroCajero;
        }

        // Detalles de movimientos -----------------------------------------------------------------------------------------

        public void LeerDatosDetallesMovimientos()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory + "/Datos", "DetallesMovimientos.txt");

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                }
            }

            detalleMovimientos.Clear();

            foreach (var linea in File.ReadAllLines(path))
            {
                var campos = linea.Split('|');

                var detalle = new DetalleMovimiento
                {
                    Id = int.Parse(campos[0]),
                    IdMovimiento = int.Parse(campos[1]),
                    Billete = int.Parse(campos[2]),
                    cantidadBillete = int.Parse(campos[3]),
                };

                detalleMovimientos.Add(detalle);
            }
        }

        public void GuardarDatosDetallesMovimientos()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory + "/Datos", "DetallesMovimientos.txt");
            var lineas = new List<string>();

            foreach (var detalle in detalleMovimientos)
            {
                lineas.Add($"{detalle.Id}|{detalle.IdMovimiento}|{detalle.Billete}|{detalle.cantidadBillete}");
            }

            File.WriteAllLines(path, lineas);
        }
        public void AgregarDetallesMovimiento(int idMovimiento, int billete, int canidad)
        {
            int nuevoId = detalleMovimientos.Count > 0 ? detalleMovimientos.Max(m => m.Id) + 1 : 0;
            var detalle = new DetalleMovimiento
            {
                Id = nuevoId,
                IdMovimiento = idMovimiento,
                Billete = billete,
                cantidadBillete = canidad
            };
            detalleMovimientos.Add(detalle);
        }
        public List<DetalleMovimiento> ObtenerDetalles(int idMovimiento)
        {
            List<DetalleMovimiento> detMovimientos = new List<DetalleMovimiento>();
            foreach (var detalle in detalleMovimientos)
            {
                if (detalle.IdMovimiento == idMovimiento)
                {
                    detMovimientos.Add(detalle);
                }
            }
            return detMovimientos;
        }

    }
}