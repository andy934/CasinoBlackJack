namespace proyectoMetodologia
{
    partial class FormPerfil
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
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(873, 490);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(185, 46);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "R E G R E S A R";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FormDepositosDeDinero
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 576);
            Controls.Add(btnRegresar);
            Name = "FormDepositosDeDinero";
            Text = "FormDepositosDeDinero";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
    }
}