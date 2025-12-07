using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace proyectoMetodologia
{
    public partial class PantallaBlackJack : Form
    {
        public bool flagJugador = false, flagDealer = false, flagBlackJack = false, flagEmpate = false;
        public int total = 0, totalDealer = 0;
        public string url = "D:/C#/proyectoMetodologia/Properties/tapa.png";
        public PantallaBlackJack()
        {
            InitializeComponent();
            label6.Text = "";
            label3.Text = "";
            //url += "/tapa.png";
            picBoxCartasDealer.Image = Image.FromFile(url);
            picBoxCartasDealer2.Image = Image.FromFile(url);
            picBoxCartasDealer2.Tag = "Tapa";

            picBoxCartasPlayer.Image = Image.FromFile(url);
            picBoxCartasPlayer2.Image = Image.FromFile(url);

            btnHit.Enabled = false;
            btnStay.Enabled = false;
            //btnPerfil.Enabled = false;

            lblDineroUsuario.Text = SesionUsuario.Dinero.ToString("C");

            MostrarBotones();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SesionUsuario.CerrarSesion();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, "D:\\C#\\proyectoMetodologia\\Properties\\baraja");
            string[] archivos = Directory.GetFiles(ruta, "*.png");

            int totalPlayer = Player(ruta, archivos);

            label3.Text = (totalPlayer + Convert.ToInt16(label3.Text)).ToString();

            if (Convert.ToInt16(label3.Text) > 21)
            {
                btnHit.Enabled = false;
            }
            //int index2 = rnd.Next(0, archivos.Length);
            //int totalCarta = ValorCartaPlayer(nomCarta, nomCarta2);
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, "D:\\C#\\proyectoMetodologia\\Properties\\baraja");
            string[] archivos = Directory.GetFiles(ruta, "*.png");
            int totalCarta = 0;

            //Verifica que tenga dinero suficiente para poder jugar
            decimal apuesta = Convert.ToDecimal(label11.Text.Substring(1));
            if (apuesta < 20)
            {
                MessageBox.Show("No tiene dinero sufiente en su cuenta para jugar.",
                    "Dinero Insuficiente", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            btnPerfil.Enabled = false;
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            Random rnd = new Random();
            int index = rnd.Next(0, archivos.Length);
            int index2 = rnd.Next(0, archivos.Length);
            int index3 = rnd.Next(0, archivos.Length);

            //Muestra la imagen en pantalla del jugador
            picBoxCartasPlayer.Image = System.Drawing.Image.FromFile(archivos[index]);
            picBoxCartasPlayer2.Image = System.Drawing.Image.FromFile(archivos[index2]);
            //Mostrar la imagen en pantalla del delaer
            picBoxCartasDealer.Image = System.Drawing.Image.FromFile(archivos[index3]);

            /*  nomCarta y nomCarta2. Tienen el primer caracter del nombre de la imagen de la carta que se muestra
                con este caracter se sabe el valor de esa carta. Ej: "1"=10, "5"=5, "A"=11/1, "J"=10,
                la funcion valorCartaPlayer devuelve un entero que es el valor de la carta  */
            //Cartas del jugador
            string nomCarta = Path.GetFileNameWithoutExtension(archivos[index]).Substring(0, 1);
            totalCarta = ValorCartaPlayer(nomCarta);
            string nomCarta2 = Path.GetFileNameWithoutExtension(archivos[index2]).Substring(0, 1);
            totalCarta += ValorCartaPlayer(nomCarta2);
            //Carta del dealer
            string nomCarta3 = Path.GetFileNameWithoutExtension(archivos[index3]).Substring(0, 1);
            totalDealer = ValorCartaPlayer(nomCarta3);

            //Mostrar valor de la 2da carta del delaer
            label6.Text = totalDealer.ToString();

            if (nomCarta3 == "A")
            {
                flagDealer = true;
            }

            //Mostrar la suma de las cartas del jugador
            label3.Text = totalCarta.ToString();

            if (nomCarta == "A" || nomCarta2 == "A")
            {
                flagJugador = true;
            }

            if (nomCarta == "A" && nomCarta2 == "A")
            {
                label3.Text = (Convert.ToInt16(label3.Text) - 10).ToString();
            }

            btnRepartir.Enabled = false;

            if (totalCarta == 21)
            {
                flagBlackJack = true;
                btnHit.Enabled = false;
            }
        }

        private int ValorCartaPlayer(string nomCarta)
        {
            int total = 0;
            switch (nomCarta)
            {
                case "2":
                    total += 2;
                    break;
                case "3":
                    total += 3;
                    break;
                case "4":
                    total += 4;
                    break;
                case "5":
                    total += 5;
                    break;
                case "6":
                    total += 6;
                    break;
                case "7":
                    total += 7;
                    break;
                case "8":
                    total += 8;
                    break;
                case "9":
                    total += 9;
                    break;
                case "1":
                case "J":
                case "K":
                case "Q":
                    total += 10;
                    break;
                case "A":
                    total += 11;
                    break;
                default:
                    break;
            }
            return total;
        }

        private int Player(string ruta, string[] archivos)
        {
            string nomCarta = "";
            string nomCarta2 = "";
            string nomCarta3 = "";
            int totalCarta = 0;

            Random rnd = new Random();
            int index = rnd.Next(0, archivos.Length);

            if (flagJugador && Convert.ToInt16(label3.Text) > 21)
            {
                label3.Text = (Convert.ToInt16(label3.Text) - 10).ToString();
                flagJugador = false;
            }

            /*  nomCarta y nomCarta2. Tienen el primer caracter del nombre de la imagen de la carta que se muestra
                con este caracter se sabe el valor de esa carta. Ej: "1"=10, "5"=5, "A"=11/1, "J"=10,
                la funcion valorCartaPlayer devuelve un entero que es el valor de la carta  */
            if (picBoxCartasPlayer3.Image == null)
            {
                picBoxCartasPlayer3.Image = System.Drawing.Image.FromFile(archivos[index]);
                nomCarta = Path.GetFileNameWithoutExtension(archivos[index]).Substring(0, 1);
                totalCarta = ValorCartaPlayer(nomCarta);
                //label4.Text = nomCarta;
                if (nomCarta == "A")
                {
                    flagJugador = true;
                }
            }
            else if (Convert.ToInt16(label3.Text) < 21 && picBoxCartasPlayer4.Image == null)
            {
                picBoxCartasPlayer4.Image = System.Drawing.Image.FromFile(archivos[index]);
                nomCarta2 = Path.GetFileNameWithoutExtension(archivos[index]).Substring(0, 1);
                totalCarta += ValorCartaPlayer(nomCarta2);
                //label5.Text = nomCarta2;
                if (nomCarta2 == "A")
                {
                    if (Convert.ToInt16(label3.Text) > 10)
                    {
                        label3.Text = (Convert.ToInt16(label3.Text) - 10).ToString();
                        flagJugador = false;
                    }
                }
            }
            else if (Convert.ToInt16(label3.Text) < 21)
            {
                picBoxCartasPlayer5.Image = System.Drawing.Image.FromFile(archivos[index]);
                nomCarta3 = Path.GetFileNameWithoutExtension(archivos[index]).Substring(0, 1);
                totalCarta += ValorCartaPlayer(nomCarta3);
                //btnHit.Enabled = false;
                if (nomCarta3 == "A")
                {
                    if (Convert.ToInt16(label3.Text) > 10)
                    {
                        label3.Text = (Convert.ToInt16(label3.Text) - 10).ToString();
                        flagJugador = false;
                    }
                }
            }

            return totalCarta;
        }

        private async void btnStay_Click(object sender, EventArgs e)
        {
            string ruta = Path.Combine(Application.StartupPath, "D:\\C#\\proyectoMetodologia\\Properties\\baraja");
            string[] archivos = Directory.GetFiles(ruta, "*.png");
            int total = 0;

            btnHit.Enabled = false;
            btnStay.Enabled = false;

            if (flagBlackJack)
            {
                label6.Text = totalDealer.ToString();
                MessageBox.Show("FELICIDADES TIENE BLACK JACK!");
                flagBlackJack = false;

                decimal apuesta = Convert.ToDecimal(label11.Text.Substring(1));
                AjustarDinero(1, apuesta);

                DialogResult seguirJugando = MessageBox.Show(
                    "¿Quieres empezar una nueva ronda?",
                    "Jugar de Nuevo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (seguirJugando == DialogResult.Yes)
                {
                    NuevaRonda();
                }
                else
                {
                    SesionUsuario.CerrarSesion();
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
            }
            else
            {
                total = await Dealer(ruta, archivos);
                label6.Text = totalDealer.ToString();
                MostrarGanador();
            }

            //(totalDealer + Convert.ToInt16(label6.Text)).ToString();           
        }

        private async Task<int> Dealer(string ruta, string[] archivos)
        {
            string nomCarta = "";
            int totalCartas = 0;
            Random rnd = new Random();
            do
            {
                if (totalDealer > 17) break;

                if (flagDealer && totalDealer > 21)
                {
                    totalDealer -= 10;
                    flagDealer = false;
                }

                await Task.Delay(800);

                int index = rnd.Next(0, archivos.Length);

                MostrarCartasDealer(index, ruta, archivos);

                nomCarta = Path.GetFileNameWithoutExtension(archivos[index]).Substring(0, 1);
                totalCartas = ValorCartaPlayer(nomCarta);
                if (nomCarta == "A")
                {
                    flagDealer = true;
                }

                totalDealer += totalCartas;
            } while (totalDealer < 17);
            return totalDealer;
        }

        private void MostrarCartasDealer(int index, string ruta, string[] archivos)
        {
            if (picBoxCartasDealer2.Tag != null && picBoxCartasDealer2.Tag.ToString() == "Tapa")
            {
                picBoxCartasDealer2.Image = System.Drawing.Image.FromFile(archivos[index]);
                picBoxCartasDealer2.Tag = "cartaRevelada";
            }
            else if (Convert.ToInt16(label6.Text) < 21 && picBoxCartasDealer3.Image == null)
            {
                picBoxCartasDealer3.Image = System.Drawing.Image.FromFile(archivos[index]);
            }
            else if (Convert.ToInt16(label6.Text) < 21 && picBoxCartasDealer4.Image == null)
            {
                picBoxCartasDealer4.Image = System.Drawing.Image.FromFile(archivos[index]);
            }
            else if (Convert.ToInt16(label6.Text) < 21)
            {
                picBoxCartasDealer5.Image = System.Drawing.Image.FromFile(archivos[index]);
            }
        }

        private void MostrarGanador()
        {
            int jugador = Convert.ToInt16(label3.Text);
            int dealer = Convert.ToInt16(label6.Text);
            decimal apuesta = Convert.ToDecimal(label11.Text.Substring(1));
            int resultadoJugador = 0;
            //resultadoJugador es TRUE solamente cuando el jugador gano
            DialogResult resultado = DialogResult.None;

            if (jugador > 21)
            {
                resultado = MessageBox.Show(
                    "Usted se ah pasado! Ah Ganado el casino.",
                    "Resultado.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (jugador == dealer)
            {
                resultado = MessageBox.Show(
                    "Es un empate!",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resultadoJugador = 1;

                DialogResult seguirJugando = MessageBox.Show(
                    "¿Quieres empezar una nueva ronda?",
                    "Jugar de Nuevo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (seguirJugando == DialogResult.Yes)
                {
                    NuevaRonda();
                }
                else
                {
                    SesionUsuario.CerrarSesion();
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
            }
            else if (jugador < dealer && dealer <= 21)
            {
                resultado = MessageBox.Show(
                    "Ah Ganado el casino!",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }

            if (dealer < jugador && jugador <= 21)
            {
                resultado = MessageBox.Show(
                    "Felicidades ah ganado!",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resultadoJugador = 1;
            }
            else if (dealer > 21 && jugador <= 21)
            {
                resultado = MessageBox.Show(
                    "Felicidades ah ganado!",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resultadoJugador = 1;
            }

            if (resultado == DialogResult.OK)
            {
                AjustarDinero(resultadoJugador, apuesta);

                DialogResult seguirJugando = MessageBox.Show(
                    "¿Quieres empezar una nueva ronda?",
                    "Jugar de Nuevo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (seguirJugando == DialogResult.Yes)
                {
                    NuevaRonda();
                }
                else
                {
                    SesionUsuario.CerrarSesion();
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }

            }
        }

        private void NuevaRonda()
        {
            //Cartas del Dealer
            picBoxCartasDealer.Image = Image.FromFile(url);
            picBoxCartasDealer2.Image = Image.FromFile(url);
            picBoxCartasDealer2.Tag = "Tapa";
            picBoxCartasDealer3.Image = null;
            picBoxCartasDealer4.Image = null;
            picBoxCartasDealer5.Image = null;

            //Cartas del jugador
            picBoxCartasPlayer.Image = Image.FromFile(url);
            picBoxCartasPlayer2.Image = Image.FromFile(url);
            picBoxCartasPlayer3.Image = null;
            picBoxCartasPlayer4.Image = null;
            picBoxCartasPlayer5.Image = null;

            btnPerfil.Enabled = true;
            btnRepartir.Enabled = true;
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            //Restablecer banderas
            flagJugador = false;
            flagDealer = false;
            flagBlackJack = false;

            //Restableces totales
            total = 0;
            totalDealer = 0;

            //Restablecer los lbl del conteo de las cartas del jugador y del dealer
            label6.Text = ""; //Jugador
            label3.Text = ""; //Dealer

            //Restablecer el lbl de la apuesta del jugador
            label11.Text = "$0";

            //Actualizar el dinero del usuario
            //lblDineroUsuario.Text = Convert.ToString(SesionUsuario.Dinero);
        }

        //Funcion para redondear un button
        private void BtnRedondo(Button boton, int radio)
        {
            //Crear el objeto GraphicsPath para definir la forma
            GraphicsPath path = new GraphicsPath();

            //Añadir una elipse (circulo) al path con los parametros x, y (ancho, alto)
            path.AddEllipse(0, 0, radio, radio);

            //Asignar el path como la forma del boton
            boton.Region = new Region(path);
        }

        private void MostrarBotones()
        {
            //Mostrar el boton circular
            btn10.Width = 100;
            btn10.Height = 100;
            //Llamar a la funcion
            BtnRedondo(btn10, 100);
            btn10.FlatStyle = FlatStyle.Flat;
            btn10.FlatAppearance.BorderSize = 0;

            //Mostrar el boton circular
            btn50.Width = 100;
            btn50.Height = 100;
            //Llamar a la funcion
            BtnRedondo(btn50, 100);
            btn50.FlatStyle = FlatStyle.Flat;
            btn50.FlatAppearance.BorderSize = 0;

            //Mostrar el boton circular
            btn100.Width = 100;
            btn100.Height = 100;
            //Llamar a la funcion
            BtnRedondo(btn100, 100);
            btn100.FlatStyle = FlatStyle.Flat;
            btn100.FlatAppearance.BorderSize = 0;

            //Mostrar el boton circular
            btn200.Width = 100;
            btn200.Height = 100;
            //Llamar a la funcion
            BtnRedondo(btn200, 100);
            btn200.FlatStyle = FlatStyle.Flat;
            btn200.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPerfil verPerfil = new FormPerfil();
            verPerfil.Show();
            //lblDineroUsuario.Text = $"${SesionUsuario.Dinero:N2}";
            //this.Hide();
            //SUSCRIBIRSE AL EVENTO
            verPerfil.DineroActualizado += (s, nuevoSaldo) =>
            {
                lblDineroUsuario.Text = $"${nuevoSaldo:N2}";
            };
        }

        private void Apostar(string monto)
        {
            decimal apuesta = 0;
            apuesta = Convert.ToDecimal(monto);
            //Valida que el dinero del usuario > el motno de la apuesta para que no haya dinero negativo
            decimal dineroUsuario = Convert.ToDecimal(lblDineroUsuario.Text.Substring(1));

            if (dineroUsuario < apuesta)
            {
                MessageBox.Show("Dinero Insuficiente para apostar",
                    "Apuesta Rechazada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            //lblDineroUsuario.Text = "$" + Convert.ToString(dineroUsuario - apuesta);
            label11.Text = "$" + Convert.ToString(apuesta + Convert.ToDecimal(label11.Text.Substring(1) ) );
            //SesionUsuario.Dinero -= Convert.ToDecimal(monto);

            AjustarDinero(-1, apuesta);
        }

        private void AjustarDinero(int resultado, decimal apuesta)
        {
            SqlConnection conexion;
            SqlCommand cmdConsultar;
            decimal dineroBD = 0.0M;

            conexion = new SqlConnection("Data Source=localhost;Initial Catalog=BD_Casino;User ID=sa2;Password=123456789;Encrypt=True;TrustServerCErtificate=True;");
            conexion.Open();

            cmdConsultar = new SqlCommand("SELECT dinero FROM dinero WHERE id_usuario='" + SesionUsuario.ID + "'", conexion);
            using (SqlDataReader rdr = cmdConsultar.ExecuteReader())
            {
                //Comprobar si hay datos en el datareader
                if (rdr.Read())
                {
                    dineroBD = Convert.ToDecimal(rdr["dinero"]);
                }
            }

            if (resultado == -1)
            {
                dineroBD -= apuesta;
            }

            if (resultado == 1 && flagBlackJack)
            {
                dineroBD += apuesta * 3;
                MessageBox.Show("Felicidades ah ganado $" + apuesta * 3,
                    "Recompenza", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (resultado == 1)
            {
                dineroBD += apuesta * 2;
                MessageBox.Show("Felicidades ah ganado $" + apuesta * 2,
                    "Recompenza",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            SesionUsuario.Dinero = dineroBD;
            lblDineroUsuario.Text = "$" + dineroBD.ToString();

            cmdConsultar = new SqlCommand("UPDATE dinero SET dinero = " + dineroBD + " WHERE id_usuario='" + SesionUsuario.ID + "'", conexion);
            cmdConsultar.ExecuteNonQuery();

            conexion.Close();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Apostar("10");
            //MessageBox.Show("Se realizo una apuesta con el monto de $10.00",
            //    "Apuesta Realizada",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            Apostar("50");
            //MessageBox.Show("Se realizo una apuesta con el monto de $50.00",
            //    "Apuesta Realizada",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Apostar("100");
            //MessageBox.Show("Se realizo una apuesta con el monto de $100.00",
            //    "Apuesta Realizada",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            Apostar("200");
            //MessageBox.Show("Se realizo una apuesta con el monto de $200.00",
            //    "Apuesta Realizada",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
        }
    }
}
