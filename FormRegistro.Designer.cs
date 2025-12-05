namespace proyectoMetodologia
{
    partial class FormRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegresar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            txtPassword2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnCrearCuenta = new Button();
            label9 = new Label();
            dtNacimiento = new DateTimePicker();
            label10 = new Label();
            txtEmail = new TextBox();
            label11 = new Label();
            txtTelefono = new TextBox();
            label12 = new Label();
            txtNomUsuario = new TextBox();
            panelFondo = new Panel();
            lblTitulo = new Label();
            panelRequisitos = new Panel();
            lblTituloRequisitos = new Label();
            panelFondo.SuspendLayout();
            panelRequisitos.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(60, 60, 60);
            btnRegresar.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            btnRegresar.FlatAppearance.BorderSize = 2;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(600, 921);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(313, 55);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "◄ R E G R E S A R";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 110);
            label1.Name = "label1";
            label1.Size = new Size(142, 41);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 175);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(100, 500);
            label3.Name = "label3";
            label3.Size = new Size(184, 41);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(245, 245, 245);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(320, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(420, 47);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(245, 245, 245);
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(320, 172);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(420, 47);
            txtApellido.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 245, 245);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(320, 497);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new Size(420, 47);
            txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(100, 565);
            label4.Name = "label4";
            label4.Size = new Size(295, 41);
            label4.TabIndex = 7;
            label4.Text = "Repetir Contraseña:";
            // 
            // txtPassword2
            // 
            txtPassword2.BackColor = Color.FromArgb(245, 245, 245);
            txtPassword2.BorderStyle = BorderStyle.FixedSingle;
            txtPassword2.Font = new Font("Segoe UI", 11F);
            txtPassword2.Location = new Point(493, 563);
            txtPassword2.MaxLength = 20;
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '●';
            txtPassword2.PlaceholderText = "********";
            txtPassword2.Size = new Size(420, 47);
            txtPassword2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(144, 238, 144);
            label5.Location = new Point(60, 55);
            label5.Name = "label5";
            label5.Size = new Size(479, 37);
            label5.TabIndex = 9;
            label5.Text = "✓ Debe contener al menos 8 caracteres";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(144, 238, 144);
            label6.Location = new Point(60, 95);
            label6.Name = "label6";
            label6.Size = new Size(643, 37);
            label6.TabIndex = 10;
            label6.Text = "✓ Debe contener al menos 1 carácter especial ($#_%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(144, 238, 144);
            label7.Location = new Point(60, 135);
            label7.Name = "label7";
            label7.Size = new Size(453, 37);
            label7.TabIndex = 11;
            label7.Text = "✓ Debe contener al menos 1 número";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(144, 238, 144);
            label8.Location = new Point(60, 175);
            label8.Name = "label8";
            label8.Size = new Size(517, 37);
            label8.TabIndex = 12;
            label8.Text = "✓ Debe contener mayúsculas y minúsculas";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.FromArgb(184, 134, 11);
            btnCrearCuenta.FlatAppearance.BorderColor = Color.Gold;
            btnCrearCuenta.FlatAppearance.BorderSize = 2;
            btnCrearCuenta.FlatStyle = FlatStyle.Flat;
            btnCrearCuenta.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnCrearCuenta.ForeColor = Color.White;
            btnCrearCuenta.Location = new Point(100, 920);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(434, 55);
            btnCrearCuenta.TabIndex = 13;
            btnCrearCuenta.Text = "♦ C R E A R  C U E N T A";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(100, 305);
            label9.Name = "label9";
            label9.Size = new Size(320, 41);
            label9.TabIndex = 14;
            label9.Text = "Fecha de Nacimiento:";
            // 
            // dtNacimiento
            // 
            dtNacimiento.CalendarMonthBackground = Color.FromArgb(245, 245, 245);
            dtNacimiento.Font = new Font("Segoe UI", 10F);
            dtNacimiento.Location = new Point(426, 302);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(487, 43);
            dtNacimiento.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(100, 370);
            label10.Name = "label10";
            label10.Size = new Size(103, 41);
            label10.TabIndex = 16;
            label10.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(245, 245, 245);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(320, 367);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 47);
            txtEmail.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(100, 435);
            label11.Name = "label11";
            label11.Size = new Size(148, 41);
            label11.TabIndex = 18;
            label11.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(245, 245, 245);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(320, 432);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(420, 47);
            txtTelefono.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(100, 240);
            label12.Name = "label12";
            label12.Size = new Size(94, 41);
            label12.TabIndex = 20;
            label12.Text = "Alias:";
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.BackColor = Color.FromArgb(245, 245, 245);
            txtNomUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNomUsuario.Font = new Font("Segoe UI", 11F);
            txtNomUsuario.Location = new Point(320, 237);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(420, 47);
            txtNomUsuario.TabIndex = 21;
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.FromArgb(20, 60, 30);
            panelFondo.BorderStyle = BorderStyle.FixedSingle;
            panelFondo.Controls.Add(lblTitulo);
            panelFondo.Controls.Add(label1);
            panelFondo.Controls.Add(label2);
            panelFondo.Controls.Add(label12);
            panelFondo.Controls.Add(label9);
            panelFondo.Controls.Add(label10);
            panelFondo.Controls.Add(label11);
            panelFondo.Controls.Add(label3);
            panelFondo.Controls.Add(label4);
            panelFondo.Controls.Add(txtNombre);
            panelFondo.Controls.Add(txtApellido);
            panelFondo.Controls.Add(txtNomUsuario);
            panelFondo.Controls.Add(dtNacimiento);
            panelFondo.Controls.Add(txtEmail);
            panelFondo.Controls.Add(txtTelefono);
            panelFondo.Controls.Add(txtPassword);
            panelFondo.Controls.Add(txtPassword2);
            panelFondo.Controls.Add(panelRequisitos);
            panelFondo.Controls.Add(btnCrearCuenta);
            panelFondo.Controls.Add(btnRegresar);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(1002, 1052);
            panelFondo.TabIndex = 22;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Gold;
            lblTitulo.Location = new Point(240, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(633, 86);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "♠ CREAR CUENTA ♥";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRequisitos
            // 
            panelRequisitos.BackColor = Color.FromArgb(30, 30, 30);
            panelRequisitos.BorderStyle = BorderStyle.FixedSingle;
            panelRequisitos.Controls.Add(lblTituloRequisitos);
            panelRequisitos.Controls.Add(label5);
            panelRequisitos.Controls.Add(label6);
            panelRequisitos.Controls.Add(label7);
            panelRequisitos.Controls.Add(label8);
            panelRequisitos.Location = new Point(70, 650);
            panelRequisitos.Name = "panelRequisitos";
            panelRequisitos.Size = new Size(750, 234);
            panelRequisitos.TabIndex = 23;
            // 
            // lblTituloRequisitos
            // 
            lblTituloRequisitos.AutoSize = true;
            lblTituloRequisitos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloRequisitos.ForeColor = Color.Gold;
            lblTituloRequisitos.Location = new Point(200, 10);
            lblTituloRequisitos.Name = "lblTituloRequisitos";
            lblTituloRequisitos.Size = new Size(495, 45);
            lblTituloRequisitos.TabIndex = 13;
            lblTituloRequisitos.Text = "🔒 Requisitos de la Contraseña:";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1002, 1052);
            Controls.Add(panelFondo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BlackJack Casino - Registro";
            panelFondo.ResumeLayout(false);
            panelFondo.PerformLayout();
            panelRequisitos.ResumeLayout(false);
            panelRequisitos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtPassword2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnCrearCuenta;
        private Label label9;
        private DateTimePicker dtNacimiento;
        private Label label10;
        private TextBox txtEmail;
        private Label label11;
        private TextBox txtTelefono;
        private Label label12;
        private TextBox txtNomUsuario;
        private Panel panelFondo;
        private Label lblTitulo;
        private Panel panelRequisitos;
        private Label lblTituloRequisitos;
    }
}