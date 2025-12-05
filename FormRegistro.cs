using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoMetodologia
{
    public partial class FormRegistro : Form
    {
        SqlConnection conexion;
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarCuenta())
            {
                string nuevoUsuario = txtNomUsuario.Text;

                if (NombreUsuarioExiste(nuevoUsuario))
                {
                    MessageBox.Show("El nombre de usuario '" + nuevoUsuario + "' ya está registrado. Por favor, elija otro.", "Usuario No Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomUsuario.Focus();
                    return;
                }

                EjecutarRegistro(nuevoUsuario);
            }
        }

        private bool ValidarCuenta()
        {
            SqlCommand cmdConsultar;
            bool validada = false;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validada = false; // Detiene la ejecución si hay campos vacíos.
            }

            if (txtPassword.Text != txtPassword2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifíquelas.", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Limpia o enfoca los campos para corrección.
                txtPassword.Clear();
                txtPassword2.Clear();
                txtPassword.Focus();
                return validada = false;
            }

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, patronEmail))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus(); //enfoca el campo para corrección.
                return validada = false;
            }

            // Obtener la fecha de nacimiento y la fecha actual.
            DateTime fechaNacimiento = dtNacimiento.Value.Date;
            DateTime hoy = DateTime.Today;

            // Calcular la edad.
            int edad = hoy.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha cumplido años este año.
            if (fechaNacimiento.Date > hoy.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                MessageBox.Show("Debes ser mayor de 18 años para registrarte.", "Error de Edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validada = false;
            }

            // Debe contener al menos 8 caracteres (esto se puede chequear con .Length)
            // Al menos un caracter especial: [!@#$%^&*()_+=\[{\]};:<>|./?,-]
            // Al menos un número: [0-9]
            // Al menos una mayúscula y una minúscula: (?=.*[A-Z])(?=.*[a-z])

            string contrasena = txtPassword.Text;
            bool cumpleEspecial = new System.Text.RegularExpressions.Regex(@"[^\w\s]").IsMatch(contrasena);
            bool cumpleNumero = new System.Text.RegularExpressions.Regex(@"[0-9]").IsMatch(contrasena);
            bool cumpleMayusculas = new System.Text.RegularExpressions.Regex(@"[A-Z]").IsMatch(contrasena);
            bool cumpleMinusculas = new System.Text.RegularExpressions.Regex(@"[a-z]").IsMatch(contrasena);
            
            if (contrasena.Length < 8)
            {
                MessageBox.Show("La contraseña debe de tener almenos 8 caracteres.", "Contraseña no valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validada = false;
            }
            else if (!cumpleEspecial)
            {
                MessageBox.Show("La contraseña debe de tener almenos un caracter especial.", "Contraseña no valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validada = false;
            }
            else if (!cumpleNumero) 
            {
                MessageBox.Show("La contraseña debe de tener almenos un número.", "Contraseña no valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validada = false;
            }
            else if (!cumpleMayusculas)
            {
                MessageBox.Show("La contraseña debe de tener almenos una mayúscual.", "Contraseña no valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validada = false;
            }
            else if (!cumpleMinusculas)
            {
                MessageBox.Show("La contraseña debe de tener almenos una minúscual.", "Contraseña no valida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validada = false;
            }

                return validada = true;
        }

        private bool NombreUsuarioExiste(string nombreUsuario)
        {
            //Using para asegurar que la conexión se cierre correctamente
            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BD_Casino;User ID=sa2;Password=123456789;Encrypt=True;TrustServerCErtificate=True;"))
            {
                try
                {
                    conexion.Open();

                    //Cuenta cuántas filas existen con ese nombre exacto.
                    string query = "SELECT COUNT(*) FROM usuario WHERE nomUsuario = @nombre";

                    using (SqlCommand cmdConsultar = new SqlCommand(query, conexion))
                    {
                        //cmdConsultar.Parameters.AddWithValue("@nombre", nombreUsuario);
                        cmdConsultar.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombreUsuario;

                        //ExecuteScalar devuelve la primera columna de la primera fila.
                        // Lo casteamos a un entero (int) para saber cuántos resultados hubo.
                        int count = (int)cmdConsultar.ExecuteScalar();

                        if (count > 0)
                        {
                            // Si count > 0, significa que ya existe.
                            return true;
                        }
                        else
                        {
                            // Si count = 0, el nombre es único.
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de error de conexión/BD
                    MessageBox.Show("Error al verificar nombre de usuario: " + ex.Message, "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // Asumir que existe para evitar problemas de doble registro ante un error.
                }
            }
        }

        private void EjecutarRegistro(string nuevoUsuario)
        {
            //Credenciales SQL
            conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BD_Casino;User ID=sa2;Password=123456789;Encrypt=True;TrustServerCErtificate=True;");
            conexion.Open();

            SqlCommand cmdInsertar;
            bool cuentaValida = ValidarCuenta();

            try
            {
                if (cuentaValida)
                {
                    cmdInsertar = new SqlCommand("INSERT INTO usuario(nombre, apellido, password, email, fechaNacimiento, celular, nomUsuario)" +
                                                  "VALUES (@nombre, @apellido, @password, @email, @fechaNacimiento, @telefono, @usuario)", conexion);
                    cmdInsertar.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = txtNombre.Text;
                    cmdInsertar.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = txtApellido.Text;
                    cmdInsertar.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = txtPassword.Text;
                    cmdInsertar.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = txtEmail.Text;
                    cmdInsertar.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime).Value = dtNacimiento.Value;
                    cmdInsertar.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = txtTelefono.Text;
                    cmdInsertar.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = txtNomUsuario.Text;

                    int filasAfectadas = cmdInsertar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cuenta creada correctamente", "Cuenta creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar la cuenta.", "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Ocurrió un error al intentar registrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexion.Close();
        }
    }
}
