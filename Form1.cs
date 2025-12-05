using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace proyectoMetodologia
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("No puede dejar ningun campo vacio.", 
                    "Campos vacios", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            //Credenciales SQl
            conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BD_Casino;User ID=sa2;Password=123456789;Encrypt=True;TrustServerCErtificate=True;");
            conexion.Open();

            if (CredencialesValidas())
            {
                SqlCommand cmdConsultar;
                int idUsuarioBD = 0;
                string nombreBD = "";
                decimal dineroBD = 0.0M;

                cmdConsultar = new SqlCommand("SELECT id, nomUsuario FROM usuario WHERE nomUsuario='"+txtUsuario.Text+"'", conexion);
                using (SqlDataReader rdr = cmdConsultar.ExecuteReader())
                {
                    //Comprobar si hay datos en el datareader
                    if (rdr.Read())
                    {
                        idUsuarioBD = Convert.ToInt16(rdr["id"]);
                        nombreBD = rdr["nomUsuario"].ToString();
                    }
                }

                cmdConsultar = new SqlCommand("SELECT dinero FROM dinero WHERE id_usuario='" + idUsuarioBD + "'", conexion);
                using (SqlDataReader rdr = cmdConsultar.ExecuteReader())
                {
                    //Comprobar si hay datos en el datareader
                    if (rdr.Read())
                    {
                        dineroBD = Convert.ToDecimal(rdr["dinero"]);
                    }
                }

                //Llenado de sesion
                SesionUsuario.ID = idUsuarioBD;
                SesionUsuario.NombreUsuario = nombreBD;
                SesionUsuario.Dinero = dineroBD;

                // Abrir el juego
                PantallaBlackJack pantallaBlackJack = new PantallaBlackJack();
                pantallaBlackJack.Show();
                this.Hide();
            }
            /*else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }*/

            conexion.Close();
        }

        private bool CredencialesValidas()
        {
            string password = "";
            SqlCommand cmdConsultar;

            cmdConsultar = new SqlCommand("SELECT password FROM usuario WHERE nomUsuario = @usuario", conexion);
            cmdConsultar.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = txtUsuario.Text;

            using (SqlDataReader rdr = cmdConsultar.ExecuteReader())
            {
                if (rdr.Read())
                {
                    password = rdr["password"].ToString();
                }
                else
                {
                    DialogResult resultado = MessageBox.Show(
                        "No existe registro. Quiere registrarse?", 
                        "Usuario no encontrado", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        FormRegistro registro = new FormRegistro();
                        registro.Show();
                        this.Hide();
                    }
                    return false;
                }
            }


            if (txtPassword.Text != password)
            {
                MessageBox.Show("Usuario o contraseña incorrecta.", 
                    "Usuario no valido", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            registro.Show();
            this.Hide();
        }
    }
}
