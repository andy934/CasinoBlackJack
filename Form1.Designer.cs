namespace proyectoMetodologia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnRegistrarse = new Button();
            btnSalir = new Button();
            lblSubtitulo = new Label();
            panelFondo = new Panel();
            panelFondo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(174, 27);
            label1.Name = "label1";
            label1.Size = new Size(523, 100);
            label1.TabIndex = 0;
            label1.Text = "♠ BlackJack ♥";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(174, 211);
            label2.Name = "label2";
            label2.Size = new Size(144, 45);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(174, 280);
            label3.Name = "label3";
            label3.Size = new Size(197, 45);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(245, 245, 245);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(387, 211);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(280, 50);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 245, 245);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(387, 278);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(280, 50);
            txtPassword.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(184, 134, 11);
            btnIngresar.FlatAppearance.BorderColor = Color.Gold;
            btnIngresar.FlatAppearance.BorderSize = 2;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(248, 371);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(335, 55);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "♦ I N G R E S A R ♦";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(139, 0, 0);
            btnRegistrarse.FlatAppearance.BorderColor = Color.FromArgb(220, 20, 60);
            btnRegistrarse.FlatAppearance.BorderSize = 2;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(248, 461);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(335, 55);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.Text = "♣ R E G I S T R A R S E ♣";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(60, 60, 60);
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(248, 557);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(335, 50);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "✖ S A L I R";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblSubtitulo.ForeColor = Color.FromArgb(220, 220, 220);
            lblSubtitulo.Location = new Point(248, 127);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(348, 45);
            lblSubtitulo.TabIndex = 8;
            lblSubtitulo.Text = "Casino Virtual Premium";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.FromArgb(20, 60, 30);
            panelFondo.BorderStyle = BorderStyle.FixedSingle;
            panelFondo.Controls.Add(lblSubtitulo);
            panelFondo.Controls.Add(label1);
            panelFondo.Controls.Add(label2);
            panelFondo.Controls.Add(label3);
            panelFondo.Controls.Add(txtUsuario);
            panelFondo.Controls.Add(txtPassword);
            panelFondo.Controls.Add(btnIngresar);
            panelFondo.Controls.Add(btnRegistrarse);
            panelFondo.Controls.Add(btnSalir);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(849, 701);
            panelFondo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(849, 701);
            Controls.Add(panelFondo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BlackJack Casino - Login";
            panelFondo.ResumeLayout(false);
            panelFondo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnRegistrarse;
        private Button btnSalir;
        private Label lblSubtitulo;
        private Panel panelFondo;
    }
}