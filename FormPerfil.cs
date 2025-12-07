using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace proyectoMetodologia
{
    public partial class FormPerfil : Form
    {
        // Declarar el evento
        public event EventHandler<decimal> DineroActualizado;

        // Variables para almacenar los datos del usuario
        private string nombreCompleto;
        private string apellido;
        private string emailUsuario;
        private string telefonoUsuario;
        private DateTime fechaNacimiento;

        // Estadísticas del jugador
        private int partidasJugadas;
        private int partidasGanadas;
        private int partidasPerdidas;
        private int rachaActual;
        private int mejorRacha;
        private decimal dineroGanado;
        private decimal dineroPerdido;

        // Lista para el historial de depósitos
        private List<Deposito> historialDepositos;

        // Cadena de conexión (ajusta según tu configuración)
        private string connectionString = "Data Source=localhost;Initial Catalog=BD_Casino;User ID=sa2;Password=123456789;Encrypt=True;TrustServerCErtificate=True;";
        public FormPerfil()
        {
            InitializeComponent();
            ConfigurarEventos();
            CargarDatosDesdeBaseDeDatos();
        }

        private void ConfigurarEventos()
        {
            // Eventos para los botones de depósito rápido
            btnDeposito50.Click += (s, e) => txtMontoDeposito.Text = "50";
            btnDeposito100.Click += (s, e) => txtMontoDeposito.Text = "100";
            btnDeposito500.Click += (s, e) => txtMontoDeposito.Text = "500";
            btnDeposito1000.Click += (s, e) => txtMontoDeposito.Text = "1000";

            // Evento para confirmar depósito
            btnConfirmarDeposito.Click += BtnConfirmarDeposito_Click;

            // Seleccionar el primer método de pago por defecto
            if (cmbMetodoPago.Items.Count > 0)
                cmbMetodoPago.SelectedIndex = 0;
        }

        private void CargarDatosDesdeBaseDeDatos()
        {
            try
            {
                // Cargar datos del usuario desde la base de datos
                CargarInformacionUsuario();

                // Cargar estadísticas
                CargarEstadisticasDesdeDB();

                // Cargar historial de depósitos
                CargarHistorialDepositosDesdeDB();

                // Mostrar los datos en la interfaz
                MostrarDatosUsuario();
                MostrarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarInformacionUsuario()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT nombre, apellido, email, celular, fechaNacimiento 
                                FROM usuario 
                                WHERE id = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", SesionUsuario.ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreCompleto = reader["nombre"].ToString();
                            apellido = reader["apellido"].ToString();
                            emailUsuario = reader["email"].ToString();
                            telefonoUsuario = reader["celular"].ToString();
                            fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                        }
                    }
                }
            }
        }

        private void CargarEstadisticasDesdeDB()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                                    ISNULL(PartidasJugadas, 0) as PartidasJugadas,
                                    ISNULL(PartidasGanadas, 0) as PartidasGanadas,
                                    ISNULL(PartidasPerdidas, 0) as PartidasPerdidas,
                                    ISNULL(RachaActual, 0) as RachaActual,
                                    ISNULL(MejorRacha, 0) as MejorRacha,
                                    ISNULL(DineroGanado, 0) as DineroGanado,
                                    ISNULL(DineroPerdido, 0) as DineroPerdido
                                FROM EstadisticasUsuario 
                                WHERE id_usuario = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", SesionUsuario.ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            partidasJugadas = Convert.ToInt32(reader["PartidasJugadas"]);
                            partidasGanadas = Convert.ToInt32(reader["PartidasGanadas"]);
                            partidasPerdidas = Convert.ToInt32(reader["PartidasPerdidas"]);
                            rachaActual = Convert.ToInt32(reader["RachaActual"]);
                            mejorRacha = Convert.ToInt32(reader["MejorRacha"]);
                            dineroGanado = Convert.ToDecimal(reader["DineroGanado"]);
                            dineroPerdido = Convert.ToDecimal(reader["DineroPerdido"]);
                        }
                        else
                        {
                            // Si no existen estadísticas, inicializar en 0
                            InicializarEstadisticas();
                        }
                    }
                }
            }
        }

        private void InicializarEstadisticas()
        {
            partidasJugadas = 0;
            partidasGanadas = 0;
            partidasPerdidas = 0;
            rachaActual = 0;
            mejorRacha = 0;
            dineroGanado = 0;
            dineroPerdido = 0;
        }

        private void CargarHistorialDepositosDesdeDB()
        {
            historialDepositos = new List<Deposito>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT fecha, monto, metodoPago, estado 
                                FROM Depositos 
                                WHERE id_usuario = @ID 
                                ORDER BY fecha DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", SesionUsuario.ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Deposito deposito = new Deposito
                            {
                                Fecha = Convert.ToDateTime(reader["fecha"]),
                                Monto = Convert.ToDecimal(reader["monto"]),
                                MetodoPago = reader["metodoPago"].ToString(),
                                Estado = reader["estado"].ToString()
                            };

                            historialDepositos.Add(deposito);
                        }
                    }
                }
            }

            // Mostrar en el DataGridView
            MostrarHistorialDepositos();
        }

        private void MostrarDatosUsuario()
        {
            // Mostrar información personal
            lblValorNombre.Text = $"{nombreCompleto} {apellido}";
            lblValorAlias.Text = SesionUsuario.NombreUsuario;
            lblValorEmail.Text = emailUsuario;
            lblValorTelefono.Text = telefonoUsuario;
            lblValorFecha.Text = fechaNacimiento.ToString("dd/MM/yyyy");
            lblValorSaldo.Text = $"${SesionUsuario.Dinero:N2}";
        }

        private void MostrarEstadisticas()
        {
            // Mostrar estadísticas de juego
            lblValorPartidasJugadas.Text = partidasJugadas.ToString();
            lblValorPartidasGanadas.Text = partidasGanadas.ToString();
            lblValorPartidasPerdidas.Text = partidasPerdidas.ToString();
            lblValorRachaActual.Text = rachaActual.ToString();
            lblValorMejorRacha.Text = mejorRacha.ToString();
            lblValorDineroGanado.Text = $"${dineroGanado:N2}";
            lblValorDineroPerdido.Text = $"${dineroPerdido:N2}";

            // Calcular porcentaje de victorias
            if (partidasJugadas > 0)
            {
                double porcentaje = (double)partidasGanadas / partidasJugadas * 100;
                lblValorPorcentaje.Text = $"{porcentaje:F1}%";
            }
            else
            {
                lblValorPorcentaje.Text = "0%";
            }
        }

        private void MostrarHistorialDepositos()
        {
            // Limpiar el DataGridView
            dgvHistorial.Rows.Clear();

            // Agregar cada depósito al DataGridView
            foreach (var deposito in historialDepositos)
            {
                dgvHistorial.Rows.Add(
                    deposito.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    $"${deposito.Monto:N2}",
                    deposito.MetodoPago,
                    deposito.Estado
                );
            }

            // Si no hay depósitos, mostrar mensaje
            if (historialDepositos.Count == 0)
            {
                dgvHistorial.Rows.Add(
                    "---",
                    "---",
                    "Sin transacciones registradas",
                    "---"
                );
            }
        }

        private void BtnConfirmarDeposito_Click(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un monto
            if (string.IsNullOrWhiteSpace(txtMontoDeposito.Text))
            {
                MessageBox.Show("Por favor, ingrese un monto a depositar.",
                    "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un método de pago
            if (cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un método de pago.",
                    "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar convertir el monto a decimal
            if (!decimal.TryParse(txtMontoDeposito.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un monto válido mayor a 0.",
                    "Monto Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar el depósito
            DialogResult resultado = MessageBox.Show(
                $"¿Desea depositar ${monto:N2} mediante {cmbMetodoPago.Text}?",
                "Confirmar Depósito",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // Guardar el depósito en la base de datos
                    GuardarDepositoEnBaseDeDatos(monto, cmbMetodoPago.Text);

                    // Actualizar el saldo en la base de datos
                    ActualizarSaldoEnBaseDeDatos(monto);

                    // Actualizar la sesión del usuario
                    SesionUsuario.Dinero += monto;

                    // Actualizar la interfaz
                    lblValorSaldo.Text = $"${SesionUsuario.Dinero:N2}";

                    // Actualizar label del perfil
                    lblValorSaldo.Text = $"${SesionUsuario.Dinero:N2}";

                    // DISPARAR EL EVENTO
                    DineroActualizado?.Invoke(this, SesionUsuario.Dinero);

                    // Recargar el historial
                    CargarHistorialDepositosDesdeDB();

                    MessageBox.Show($"Depósito de ${monto:N2} realizado exitosamente!\n\nNuevo saldo: ${SesionUsuario.Dinero:N2}",
                        "Depósito Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    txtMontoDeposito.Clear();
                    cmbMetodoPago.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el depósito: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GuardarDepositoEnBaseDeDatos(decimal monto, string metodoPago)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Depositos (id_usuario, fecha, monto, metodoPago, estado) 
                                VALUES (@UsuarioID, @Fecha, @Monto, @MetodoPago, @Estado)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", SesionUsuario.ID);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@MetodoPago", metodoPago.Substring(2));
                    cmd.Parameters.AddWithValue("@Estado", "Completado");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void ActualizarSaldoEnBaseDeDatos(decimal monto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE dinero 
                                SET dinero = dinero + @Monto 
                                WHERE id_usuario = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@ID", SesionUsuario.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Retornar al juego
            this.Close();
        }
    }

    // Clase para representar un depósito
    public class Deposito
    {
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public string Estado { get; set; }
    }
}