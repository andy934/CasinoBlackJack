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
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(612, 898);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(216, 46);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "R E G R E S A R";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 79);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 1;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 147);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 511);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(301, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 39);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(301, 140);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(278, 39);
            txtApellido.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(301, 504);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new Size(278, 39);
            txtPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 590);
            label4.Name = "label4";
            label4.Size = new Size(217, 32);
            label4.TabIndex = 7;
            label4.Text = "Repetir contraseña:";
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(376, 583);
            txtPassword2.MaxLength = 20;
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.PlaceholderText = "********";
            txtPassword2.Size = new Size(278, 39);
            txtPassword2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 662);
            label5.Name = "label5";
            label5.Size = new Size(437, 32);
            label5.TabIndex = 9;
            label5.Text = "Debe de contener almenos 8 caracteres";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 715);
            label6.Name = "label6";
            label6.Size = new Size(584, 32);
            label6.TabIndex = 10;
            label6.Text = "Debe de contener almenos 1 caracter especial ($#_%)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 772);
            label7.Name = "label7";
            label7.Size = new Size(415, 32);
            label7.TabIndex = 11;
            label7.Text = "Debe de contener almenos 1 número";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(150, 824);
            label8.Name = "label8";
            label8.Size = new Size(480, 32);
            label8.TabIndex = 12;
            label8.Text = "Debe de contener mayúsculas y minúsculas";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(291, 898);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(288, 46);
            btnCrearCuenta.TabIndex = 13;
            btnCrearCuenta.Text = "C R E A R   C U E N T A";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 285);
            label9.Name = "label9";
            label9.Size = new Size(241, 32);
            label9.TabIndex = 14;
            label9.Text = "Fecha de nacimiento:";
            // 
            // dtNacimiento
            // 
            dtNacimiento.Location = new Point(376, 278);
            dtNacimiento.Name = "dtNacimiento";
            dtNacimiento.Size = new Size(452, 39);
            dtNacimiento.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 362);
            label10.Name = "label10";
            label10.Size = new Size(76, 32);
            label10.TabIndex = 16;
            label10.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(301, 355);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 39);
            txtEmail.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(82, 435);
            label11.Name = "label11";
            label11.Size = new Size(112, 32);
            label11.TabIndex = 18;
            label11.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(301, 428);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(278, 39);
            txtTelefono.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(82, 221);
            label12.Name = "label12";
            label12.Size = new Size(68, 32);
            label12.TabIndex = 20;
            label12.Text = "Alias:";
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.Location = new Point(301, 214);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(278, 39);
            txtNomUsuario.TabIndex = 21;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 1010);
            Controls.Add(txtNomUsuario);
            Controls.Add(label12);
            Controls.Add(txtTelefono);
            Controls.Add(label11);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(dtNacimiento);
            Controls.Add(label9);
            Controls.Add(btnCrearCuenta);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPassword2);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegresar);
            Name = "FormRegistro";
            Text = "FormRegistro";
            ResumeLayout(false);
            PerformLayout();
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
    }
}