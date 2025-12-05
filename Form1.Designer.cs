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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 99);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "INICIAR SESION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 187);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 257);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(382, 187);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 39);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(382, 257);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(253, 39);
            txtPassword.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(329, 352);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(200, 52);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "I N G R E S A R";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(296, 445);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(259, 52);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.Text = "R E G I S T R A R S E";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(329, 543);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 46);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "S A L I R";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 692);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
    }
}
