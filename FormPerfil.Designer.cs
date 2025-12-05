namespace proyectoMetodologia
{
    partial class FormPerfil
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnRegresar = new Button();
            panelFondo = new Panel();
            lblTitulo = new Label();
            tabControl = new TabControl();
            tabPerfil = new TabPage();
            panelInfoPersonal = new Panel();
            lblTituloInfoPersonal = new Label();
            lblNombre = new Label();
            lblValorNombre = new Label();
            lblAlias = new Label();
            lblValorAlias = new Label();
            lblEmail = new Label();
            lblValorEmail = new Label();
            lblTelefono = new Label();
            lblValorTelefono = new Label();
            lblFechaNacimiento = new Label();
            lblValorFecha = new Label();
            lblSaldoActual = new Label();
            lblValorSaldo = new Label();
            tabHistorial = new TabPage();
            lblTituloHistorial = new Label();
            dgvHistorial = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colMetodo = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            tabDepositar = new TabPage();
            panelDepositar = new Panel();
            lblTituloDepositar = new Label();
            lblMontoDeposito = new Label();
            txtMontoDeposito = new TextBox();
            lblMetodoPago = new Label();
            cmbMetodoPago = new ComboBox();
            btnDeposito50 = new Button();
            btnDeposito100 = new Button();
            btnDeposito500 = new Button();
            btnDeposito1000 = new Button();
            btnConfirmarDeposito = new Button();
            tabEstadisticas = new TabPage();
            panelEstadisticas = new Panel();
            lblTituloEstadisticas = new Label();
            lblPartidasJugadas = new Label();
            lblValorPartidasJugadas = new Label();
            lblPartidasGanadas = new Label();
            lblValorPartidasGanadas = new Label();
            lblPartidasPerdidas = new Label();
            lblValorPartidasPerdidas = new Label();
            lblPorcentajeVictorias = new Label();
            lblValorPorcentaje = new Label();
            lblRachaActual = new Label();
            lblValorRachaActual = new Label();
            lblMejorRacha = new Label();
            lblValorMejorRacha = new Label();
            lblDineroGanado = new Label();
            lblValorDineroGanado = new Label();
            lblDineroPerdido = new Label();
            lblValorDineroPerdido = new Label();
            panelFondo.SuspendLayout();
            tabControl.SuspendLayout();
            tabPerfil.SuspendLayout();
            panelInfoPersonal.SuspendLayout();
            tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            tabDepositar.SuspendLayout();
            panelDepositar.SuspendLayout();
            tabEstadisticas.SuspendLayout();
            panelEstadisticas.SuspendLayout();
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
            btnRegresar.Location = new Point(1090, 879);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(314, 50);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "◄ R E G R E S A R";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // panelFondo
            // 
            panelFondo.BackColor = Color.FromArgb(20, 60, 30);
            panelFondo.Controls.Add(lblTitulo);
            panelFondo.Controls.Add(tabControl);
            panelFondo.Controls.Add(btnRegresar);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(1437, 974);
            panelFondo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Gold;
            lblTitulo.Location = new Point(312, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(848, 88);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "♦ PERFIL DE USUARIO ♦";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPerfil);
            tabControl.Controls.Add(tabHistorial);
            tabControl.Controls.Add(tabDepositar);
            tabControl.Controls.Add(tabEstadisticas);
            tabControl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tabControl.Location = new Point(30, 100);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1374, 734);
            tabControl.TabIndex = 3;
            // 
            // tabPerfil
            // 
            tabPerfil.BackColor = Color.FromArgb(30, 30, 30);
            tabPerfil.Controls.Add(panelInfoPersonal);
            tabPerfil.Location = new Point(8, 54);
            tabPerfil.Name = "tabPerfil";
            tabPerfil.Size = new Size(1358, 672);
            tabPerfil.TabIndex = 0;
            tabPerfil.Text = "👤 Información Personal";
            // 
            // panelInfoPersonal
            // 
            panelInfoPersonal.BackColor = Color.FromArgb(40, 40, 40);
            panelInfoPersonal.BorderStyle = BorderStyle.FixedSingle;
            panelInfoPersonal.Controls.Add(lblTituloInfoPersonal);
            panelInfoPersonal.Controls.Add(lblNombre);
            panelInfoPersonal.Controls.Add(lblValorNombre);
            panelInfoPersonal.Controls.Add(lblAlias);
            panelInfoPersonal.Controls.Add(lblValorAlias);
            panelInfoPersonal.Controls.Add(lblEmail);
            panelInfoPersonal.Controls.Add(lblValorEmail);
            panelInfoPersonal.Controls.Add(lblTelefono);
            panelInfoPersonal.Controls.Add(lblValorTelefono);
            panelInfoPersonal.Controls.Add(lblFechaNacimiento);
            panelInfoPersonal.Controls.Add(lblValorFecha);
            panelInfoPersonal.Controls.Add(lblSaldoActual);
            panelInfoPersonal.Controls.Add(lblValorSaldo);
            panelInfoPersonal.Location = new Point(50, 30);
            panelInfoPersonal.Name = "panelInfoPersonal";
            panelInfoPersonal.Size = new Size(1257, 550);
            panelInfoPersonal.TabIndex = 0;
            // 
            // lblTituloInfoPersonal
            // 
            lblTituloInfoPersonal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloInfoPersonal.ForeColor = Color.Gold;
            lblTituloInfoPersonal.Location = new Point(100, 18);
            lblTituloInfoPersonal.Name = "lblTituloInfoPersonal";
            lblTituloInfoPersonal.Size = new Size(647, 73);
            lblTituloInfoPersonal.TabIndex = 0;
            lblTituloInfoPersonal.Text = "📋 Datos del Jugador";
            lblTituloInfoPersonal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(100, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(165, 47);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblValorNombre
            // 
            lblValorNombre.AutoSize = true;
            lblValorNombre.Font = new Font("Segoe UI", 13F);
            lblValorNombre.ForeColor = Color.FromArgb(200, 200, 200);
            lblValorNombre.Location = new Point(380, 120);
            lblValorNombre.Name = "lblValorNombre";
            lblValorNombre.Size = new Size(252, 47);
            lblValorNombre.TabIndex = 2;
            lblValorNombre.Text = "[Nombre Aquí]";
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAlias.ForeColor = Color.White;
            lblAlias.Location = new Point(100, 180);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(108, 47);
            lblAlias.TabIndex = 3;
            lblAlias.Text = "Alias:";
            // 
            // lblValorAlias
            // 
            lblValorAlias.AutoSize = true;
            lblValorAlias.Font = new Font("Segoe UI", 13F);
            lblValorAlias.ForeColor = Color.FromArgb(200, 200, 200);
            lblValorAlias.Location = new Point(380, 180);
            lblValorAlias.Name = "lblValorAlias";
            lblValorAlias.Size = new Size(196, 47);
            lblValorAlias.TabIndex = 4;
            lblValorAlias.Text = "[Alias Aquí]";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(100, 240);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(119, 47);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblValorEmail
            // 
            lblValorEmail.AutoSize = true;
            lblValorEmail.Font = new Font("Segoe UI", 13F);
            lblValorEmail.ForeColor = Color.FromArgb(200, 200, 200);
            lblValorEmail.Location = new Point(380, 240);
            lblValorEmail.Name = "lblValorEmail";
            lblValorEmail.Size = new Size(206, 47);
            lblValorEmail.TabIndex = 6;
            lblValorEmail.Text = "[Email Aquí]";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(100, 300);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(171, 47);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblValorTelefono
            // 
            lblValorTelefono.AutoSize = true;
            lblValorTelefono.Font = new Font("Segoe UI", 13F);
            lblValorTelefono.ForeColor = Color.FromArgb(200, 200, 200);
            lblValorTelefono.Location = new Point(380, 300);
            lblValorTelefono.Name = "lblValorTelefono";
            lblValorTelefono.Size = new Size(256, 47);
            lblValorTelefono.TabIndex = 8;
            lblValorTelefono.Text = "[Teléfono Aquí]";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFechaNacimiento.ForeColor = Color.White;
            lblFechaNacimiento.Location = new Point(100, 360);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(375, 47);
            lblFechaNacimiento.TabIndex = 9;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblValorFecha
            // 
            lblValorFecha.AutoSize = true;
            lblValorFecha.Font = new Font("Segoe UI", 13F);
            lblValorFecha.ForeColor = Color.FromArgb(200, 200, 200);
            lblValorFecha.Location = new Point(495, 360);
            lblValorFecha.Name = "lblValorFecha";
            lblValorFecha.Size = new Size(213, 47);
            lblValorFecha.TabIndex = 10;
            lblValorFecha.Text = "[Fecha Aquí]";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSaldoActual.ForeColor = Color.Gold;
            lblSaldoActual.Location = new Point(100, 450);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(362, 59);
            lblSaldoActual.TabIndex = 11;
            lblSaldoActual.Text = "💰 Saldo Actual:";
            // 
            // lblValorSaldo
            // 
            lblValorSaldo.AutoSize = true;
            lblValorSaldo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValorSaldo.ForeColor = Color.FromArgb(50, 205, 50);
            lblValorSaldo.Location = new Point(464, 450);
            lblValorSaldo.Name = "lblValorSaldo";
            lblValorSaldo.Size = new Size(112, 59);
            lblValorSaldo.TabIndex = 12;
            lblValorSaldo.Text = "$0.0";
            // 
            // tabHistorial
            // 
            tabHistorial.BackColor = Color.FromArgb(30, 30, 30);
            tabHistorial.Controls.Add(lblTituloHistorial);
            tabHistorial.Controls.Add(dgvHistorial);
            tabHistorial.Location = new Point(8, 54);
            tabHistorial.Name = "tabHistorial";
            tabHistorial.Size = new Size(1358, 672);
            tabHistorial.TabIndex = 1;
            tabHistorial.Text = "📜 Historial de Depósitos";
            // 
            // lblTituloHistorial
            // 
            lblTituloHistorial.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloHistorial.ForeColor = Color.Gold;
            lblTituloHistorial.Location = new Point(316, 20);
            lblTituloHistorial.Name = "lblTituloHistorial";
            lblTituloHistorial.Size = new Size(758, 83);
            lblTituloHistorial.TabIndex = 1;
            lblTituloHistorial.Text = "💳 Historial de Transacciones";
            lblTituloHistorial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = Color.FromArgb(40, 40, 40);
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { colFecha, colMonto, colMetodo, colEstado });
            dgvHistorial.Location = new Point(54, 129);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(1247, 500);
            dgvHistorial.TabIndex = 0;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 10;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "Monto";
            colMonto.MinimumWidth = 10;
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // colMetodo
            // 
            colMetodo.HeaderText = "Método de Pago";
            colMetodo.MinimumWidth = 10;
            colMetodo.Name = "colMetodo";
            colMetodo.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 10;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // tabDepositar
            // 
            tabDepositar.BackColor = Color.FromArgb(30, 30, 30);
            tabDepositar.Controls.Add(panelDepositar);
            tabDepositar.Location = new Point(8, 54);
            tabDepositar.Name = "tabDepositar";
            tabDepositar.Size = new Size(1358, 672);
            tabDepositar.TabIndex = 2;
            tabDepositar.Text = "💵 Depositar Dinero";
            // 
            // panelDepositar
            // 
            panelDepositar.BackColor = Color.FromArgb(40, 40, 40);
            panelDepositar.BorderStyle = BorderStyle.FixedSingle;
            panelDepositar.Controls.Add(lblTituloDepositar);
            panelDepositar.Controls.Add(lblMontoDeposito);
            panelDepositar.Controls.Add(txtMontoDeposito);
            panelDepositar.Controls.Add(lblMetodoPago);
            panelDepositar.Controls.Add(cmbMetodoPago);
            panelDepositar.Controls.Add(btnDeposito50);
            panelDepositar.Controls.Add(btnDeposito100);
            panelDepositar.Controls.Add(btnDeposito500);
            panelDepositar.Controls.Add(btnDeposito1000);
            panelDepositar.Controls.Add(btnConfirmarDeposito);
            panelDepositar.Location = new Point(50, 30);
            panelDepositar.Name = "panelDepositar";
            panelDepositar.Size = new Size(1251, 608);
            panelDepositar.TabIndex = 0;
            // 
            // lblTituloDepositar
            // 
            lblTituloDepositar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloDepositar.ForeColor = Color.Gold;
            lblTituloDepositar.Location = new Point(223, 30);
            lblTituloDepositar.Name = "lblTituloDepositar";
            lblTituloDepositar.Size = new Size(817, 84);
            lblTituloDepositar.TabIndex = 0;
            lblTituloDepositar.Text = "💰 Agregar Fondos a tu Cuenta";
            lblTituloDepositar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMontoDeposito
            // 
            lblMontoDeposito.AutoSize = true;
            lblMontoDeposito.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblMontoDeposito.ForeColor = Color.White;
            lblMontoDeposito.Location = new Point(283, 124);
            lblMontoDeposito.Name = "lblMontoDeposito";
            lblMontoDeposito.Size = new Size(340, 47);
            lblMontoDeposito.TabIndex = 1;
            lblMontoDeposito.Text = "Monto a Depositar:";
            // 
            // txtMontoDeposito
            // 
            txtMontoDeposito.BackColor = Color.FromArgb(245, 245, 245);
            txtMontoDeposito.BorderStyle = BorderStyle.FixedSingle;
            txtMontoDeposito.Font = new Font("Segoe UI", 13F);
            txtMontoDeposito.Location = new Point(683, 117);
            txtMontoDeposito.Name = "txtMontoDeposito";
            txtMontoDeposito.PlaceholderText = "$0.00";
            txtMontoDeposito.Size = new Size(300, 54);
            txtMontoDeposito.TabIndex = 2;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblMetodoPago.ForeColor = Color.White;
            lblMetodoPago.Location = new Point(283, 204);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(304, 47);
            lblMetodoPago.TabIndex = 3;
            lblMetodoPago.Text = "Método de Pago:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.BackColor = Color.FromArgb(245, 245, 245);
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.Font = new Font("Segoe UI", 11F);
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "💳 Tarjeta de Crédito", "💳 Tarjeta de Débito", "🏦 Transferencia Bancaria", "📱 PayPal", "💰 Criptomonedas" });
            cmbMetodoPago.Location = new Point(683, 203);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(300, 48);
            cmbMetodoPago.TabIndex = 4;
            // 
            // btnDeposito50
            // 
            btnDeposito50.BackColor = Color.FromArgb(70, 130, 180);
            btnDeposito50.FlatAppearance.BorderColor = Color.FromArgb(100, 149, 237);
            btnDeposito50.FlatAppearance.BorderSize = 2;
            btnDeposito50.FlatStyle = FlatStyle.Flat;
            btnDeposito50.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDeposito50.ForeColor = Color.White;
            btnDeposito50.Location = new Point(245, 304);
            btnDeposito50.Name = "btnDeposito50";
            btnDeposito50.Size = new Size(170, 60);
            btnDeposito50.TabIndex = 5;
            btnDeposito50.Text = "+ $50";
            btnDeposito50.UseVisualStyleBackColor = false;
            // 
            // btnDeposito100
            // 
            btnDeposito100.BackColor = Color.FromArgb(139, 0, 139);
            btnDeposito100.FlatAppearance.BorderColor = Color.FromArgb(186, 85, 211);
            btnDeposito100.FlatAppearance.BorderSize = 2;
            btnDeposito100.FlatStyle = FlatStyle.Flat;
            btnDeposito100.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDeposito100.ForeColor = Color.White;
            btnDeposito100.Location = new Point(445, 304);
            btnDeposito100.Name = "btnDeposito100";
            btnDeposito100.Size = new Size(170, 60);
            btnDeposito100.TabIndex = 6;
            btnDeposito100.Text = "+ $100";
            btnDeposito100.UseVisualStyleBackColor = false;
            // 
            // btnDeposito500
            // 
            btnDeposito500.BackColor = Color.FromArgb(220, 20, 60);
            btnDeposito500.FlatAppearance.BorderColor = Color.FromArgb(255, 69, 0);
            btnDeposito500.FlatAppearance.BorderSize = 2;
            btnDeposito500.FlatStyle = FlatStyle.Flat;
            btnDeposito500.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDeposito500.ForeColor = Color.White;
            btnDeposito500.Location = new Point(645, 304);
            btnDeposito500.Name = "btnDeposito500";
            btnDeposito500.Size = new Size(170, 60);
            btnDeposito500.TabIndex = 7;
            btnDeposito500.Text = "+ $500";
            btnDeposito500.UseVisualStyleBackColor = false;
            // 
            // btnDeposito1000
            // 
            btnDeposito1000.BackColor = Color.FromArgb(184, 134, 11);
            btnDeposito1000.FlatAppearance.BorderColor = Color.Gold;
            btnDeposito1000.FlatAppearance.BorderSize = 2;
            btnDeposito1000.FlatStyle = FlatStyle.Flat;
            btnDeposito1000.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDeposito1000.ForeColor = Color.White;
            btnDeposito1000.Location = new Point(845, 304);
            btnDeposito1000.Name = "btnDeposito1000";
            btnDeposito1000.Size = new Size(170, 60);
            btnDeposito1000.TabIndex = 8;
            btnDeposito1000.Text = "+ $1000";
            btnDeposito1000.UseVisualStyleBackColor = false;
            // 
            // btnConfirmarDeposito
            // 
            btnConfirmarDeposito.BackColor = Color.FromArgb(34, 139, 34);
            btnConfirmarDeposito.FlatAppearance.BorderColor = Color.FromArgb(50, 205, 50);
            btnConfirmarDeposito.FlatAppearance.BorderSize = 3;
            btnConfirmarDeposito.FlatStyle = FlatStyle.Flat;
            btnConfirmarDeposito.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnConfirmarDeposito.ForeColor = Color.White;
            btnConfirmarDeposito.Location = new Point(395, 424);
            btnConfirmarDeposito.Name = "btnConfirmarDeposito";
            btnConfirmarDeposito.Size = new Size(500, 70);
            btnConfirmarDeposito.TabIndex = 9;
            btnConfirmarDeposito.Text = "✓ CONFIRMAR DEPÓSITO";
            btnConfirmarDeposito.UseVisualStyleBackColor = false;
            // 
            // tabEstadisticas
            // 
            tabEstadisticas.BackColor = Color.FromArgb(30, 30, 30);
            tabEstadisticas.Controls.Add(panelEstadisticas);
            tabEstadisticas.Location = new Point(8, 54);
            tabEstadisticas.Name = "tabEstadisticas";
            tabEstadisticas.Size = new Size(1358, 672);
            tabEstadisticas.TabIndex = 3;
            tabEstadisticas.Text = "📊 Estadísticas de Juego";
            // 
            // panelEstadisticas
            // 
            panelEstadisticas.BackColor = Color.FromArgb(40, 40, 40);
            panelEstadisticas.BorderStyle = BorderStyle.FixedSingle;
            panelEstadisticas.Controls.Add(lblTituloEstadisticas);
            panelEstadisticas.Controls.Add(lblPartidasJugadas);
            panelEstadisticas.Controls.Add(lblValorPartidasJugadas);
            panelEstadisticas.Controls.Add(lblPartidasGanadas);
            panelEstadisticas.Controls.Add(lblValorPartidasGanadas);
            panelEstadisticas.Controls.Add(lblPartidasPerdidas);
            panelEstadisticas.Controls.Add(lblValorPartidasPerdidas);
            panelEstadisticas.Controls.Add(lblPorcentajeVictorias);
            panelEstadisticas.Controls.Add(lblValorPorcentaje);
            panelEstadisticas.Controls.Add(lblRachaActual);
            panelEstadisticas.Controls.Add(lblValorRachaActual);
            panelEstadisticas.Controls.Add(lblMejorRacha);
            panelEstadisticas.Controls.Add(lblValorMejorRacha);
            panelEstadisticas.Controls.Add(lblDineroGanado);
            panelEstadisticas.Controls.Add(lblValorDineroGanado);
            panelEstadisticas.Controls.Add(lblDineroPerdido);
            panelEstadisticas.Controls.Add(lblValorDineroPerdido);
            panelEstadisticas.Location = new Point(50, 30);
            panelEstadisticas.Name = "panelEstadisticas";
            panelEstadisticas.Size = new Size(1249, 608);
            panelEstadisticas.TabIndex = 0;
            // 
            // lblTituloEstadisticas
            // 
            lblTituloEstadisticas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloEstadisticas.ForeColor = Color.Gold;
            lblTituloEstadisticas.Location = new Point(223, 17);
            lblTituloEstadisticas.Name = "lblTituloEstadisticas";
            lblTituloEstadisticas.Size = new Size(848, 72);
            lblTituloEstadisticas.TabIndex = 0;
            lblTituloEstadisticas.Text = "📊 Estadísticas del Jugador";
            lblTituloEstadisticas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPartidasJugadas
            // 
            lblPartidasJugadas.AutoSize = true;
            lblPartidasJugadas.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPartidasJugadas.ForeColor = Color.White;
            lblPartidasJugadas.Location = new Point(338, 129);
            lblPartidasJugadas.Name = "lblPartidasJugadas";
            lblPartidasJugadas.Size = new Size(308, 47);
            lblPartidasJugadas.TabIndex = 1;
            lblPartidasJugadas.Text = "Partidas Jugadas:";
            // 
            // lblValorPartidasJugadas
            // 
            lblValorPartidasJugadas.AutoSize = true;
            lblValorPartidasJugadas.Font = new Font("Segoe UI", 13F);
            lblValorPartidasJugadas.ForeColor = Color.FromArgb(200, 200, 200);
            lblValorPartidasJugadas.Location = new Point(688, 129);
            lblValorPartidasJugadas.Name = "lblValorPartidasJugadas";
            lblValorPartidasJugadas.Size = new Size(39, 47);
            lblValorPartidasJugadas.TabIndex = 2;
            lblValorPartidasJugadas.Text = "0";
            // 
            // lblPartidasGanadas
            // 
            lblPartidasGanadas.AutoSize = true;
            lblPartidasGanadas.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPartidasGanadas.ForeColor = Color.FromArgb(50, 205, 50);
            lblPartidasGanadas.Location = new Point(338, 179);
            lblPartidasGanadas.Name = "lblPartidasGanadas";
            lblPartidasGanadas.Size = new Size(314, 47);
            lblPartidasGanadas.TabIndex = 3;
            lblPartidasGanadas.Text = "Partidas Ganadas:";
            // 
            // lblValorPartidasGanadas
            // 
            lblValorPartidasGanadas.AutoSize = true;
            lblValorPartidasGanadas.Font = new Font("Segoe UI", 13F);
            lblValorPartidasGanadas.ForeColor = Color.FromArgb(50, 205, 50);
            lblValorPartidasGanadas.Location = new Point(688, 179);
            lblValorPartidasGanadas.Name = "lblValorPartidasGanadas";
            lblValorPartidasGanadas.Size = new Size(39, 47);
            lblValorPartidasGanadas.TabIndex = 4;
            lblValorPartidasGanadas.Text = "0";
            // 
            // lblPartidasPerdidas
            // 
            lblPartidasPerdidas.AutoSize = true;
            lblPartidasPerdidas.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPartidasPerdidas.ForeColor = Color.FromArgb(220, 20, 60);
            lblPartidasPerdidas.Location = new Point(338, 229);
            lblPartidasPerdidas.Name = "lblPartidasPerdidas";
            lblPartidasPerdidas.Size = new Size(316, 47);
            lblPartidasPerdidas.TabIndex = 5;
            lblPartidasPerdidas.Text = "Partidas Perdidas:";
            // 
            // lblValorPartidasPerdidas
            // 
            lblValorPartidasPerdidas.AutoSize = true;
            lblValorPartidasPerdidas.Font = new Font("Segoe UI", 13F);
            lblValorPartidasPerdidas.ForeColor = Color.FromArgb(220, 20, 60);
            lblValorPartidasPerdidas.Location = new Point(688, 229);
            lblValorPartidasPerdidas.Name = "lblValorPartidasPerdidas";
            lblValorPartidasPerdidas.Size = new Size(39, 47);
            lblValorPartidasPerdidas.TabIndex = 6;
            lblValorPartidasPerdidas.Text = "0";
            // 
            // lblPorcentajeVictorias
            // 
            lblPorcentajeVictorias.AutoSize = true;
            lblPorcentajeVictorias.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPorcentajeVictorias.ForeColor = Color.Gold;
            lblPorcentajeVictorias.Location = new Point(338, 279);
            lblPorcentajeVictorias.Name = "lblPorcentajeVictorias";
            lblPorcentajeVictorias.Size = new Size(263, 47);
            lblPorcentajeVictorias.TabIndex = 7;
            lblPorcentajeVictorias.Text = "% de Victorias:";
            // 
            // lblValorPorcentaje
            // 
            lblValorPorcentaje.AutoSize = true;
            lblValorPorcentaje.Font = new Font("Segoe UI", 13F);
            lblValorPorcentaje.ForeColor = Color.Gold;
            lblValorPorcentaje.Location = new Point(688, 279);
            lblValorPorcentaje.Name = "lblValorPorcentaje";
            lblValorPorcentaje.Size = new Size(68, 47);
            lblValorPorcentaje.TabIndex = 8;
            lblValorPorcentaje.Text = "0%";
            // 
            // lblRachaActual
            // 
            lblRachaActual.AutoSize = true;
            lblRachaActual.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblRachaActual.ForeColor = Color.White;
            lblRachaActual.Location = new Point(338, 339);
            lblRachaActual.Name = "lblRachaActual";
            lblRachaActual.Size = new Size(244, 47);
            lblRachaActual.TabIndex = 9;
            lblRachaActual.Text = "Racha Actual:";
            // 
            // lblValorRachaActual
            // 
            lblValorRachaActual.AutoSize = true;
            lblValorRachaActual.Font = new Font("Segoe UI", 13F);
            lblValorRachaActual.ForeColor = Color.FromArgb(200, 200, 200);
            lblValorRachaActual.Location = new Point(688, 339);
            lblValorRachaActual.Name = "lblValorRachaActual";
            lblValorRachaActual.Size = new Size(39, 47);
            lblValorRachaActual.TabIndex = 10;
            lblValorRachaActual.Text = "0";
            // 
            // lblMejorRacha
            // 
            lblMejorRacha.AutoSize = true;
            lblMejorRacha.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblMejorRacha.ForeColor = Color.White;
            lblMejorRacha.Location = new Point(338, 389);
            lblMejorRacha.Name = "lblMejorRacha";
            lblMejorRacha.Size = new Size(236, 47);
            lblMejorRacha.TabIndex = 11;
            lblMejorRacha.Text = "Mejor Racha:";
            // 
            // lblValorMejorRacha
            // 
            lblValorMejorRacha.AutoSize = true;
            lblValorMejorRacha.Font = new Font("Segoe UI", 13F);
            lblValorMejorRacha.ForeColor = Color.FromArgb(200, 200, 200);
            lblValorMejorRacha.Location = new Point(688, 389);
            lblValorMejorRacha.Name = "lblValorMejorRacha";
            lblValorMejorRacha.Size = new Size(39, 47);
            lblValorMejorRacha.TabIndex = 12;
            lblValorMejorRacha.Text = "0";
            // 
            // lblDineroGanado
            // 
            lblDineroGanado.AutoSize = true;
            lblDineroGanado.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDineroGanado.ForeColor = Color.FromArgb(50, 205, 50);
            lblDineroGanado.Location = new Point(338, 449);
            lblDineroGanado.Name = "lblDineroGanado";
            lblDineroGanado.Size = new Size(277, 47);
            lblDineroGanado.TabIndex = 13;
            lblDineroGanado.Text = "Dinero Ganado:";
            // 
            // lblValorDineroGanado
            // 
            lblValorDineroGanado.AutoSize = true;
            lblValorDineroGanado.Font = new Font("Segoe UI", 13F);
            lblValorDineroGanado.ForeColor = Color.FromArgb(50, 205, 50);
            lblValorDineroGanado.Location = new Point(688, 449);
            lblValorDineroGanado.Name = "lblValorDineroGanado";
            lblValorDineroGanado.Size = new Size(85, 47);
            lblValorDineroGanado.TabIndex = 14;
            lblValorDineroGanado.Text = "$0.0";
            // 
            // lblDineroPerdido
            // 
            lblDineroPerdido.AutoSize = true;
            lblDineroPerdido.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDineroPerdido.ForeColor = Color.FromArgb(220, 20, 60);
            lblDineroPerdido.Location = new Point(338, 499);
            lblDineroPerdido.Name = "lblDineroPerdido";
            lblDineroPerdido.Size = new Size(279, 47);
            lblDineroPerdido.TabIndex = 15;
            lblDineroPerdido.Text = "Dinero Perdido:";
            // 
            // lblValorDineroPerdido
            // 
            lblValorDineroPerdido.AutoSize = true;
            lblValorDineroPerdido.Font = new Font("Segoe UI", 13F);
            lblValorDineroPerdido.ForeColor = Color.FromArgb(220, 20, 60);
            lblValorDineroPerdido.Location = new Point(688, 499);
            lblValorDineroPerdido.Name = "lblValorDineroPerdido";
            lblValorDineroPerdido.Size = new Size(85, 47);
            lblValorDineroPerdido.TabIndex = 16;
            lblValorDineroPerdido.Text = "$0.0";
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1437, 974);
            Controls.Add(panelFondo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BlackJack Casino - Perfil de Usuario";
            panelFondo.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPerfil.ResumeLayout(false);
            panelInfoPersonal.ResumeLayout(false);
            panelInfoPersonal.PerformLayout();
            tabHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            tabDepositar.ResumeLayout(false);
            panelDepositar.ResumeLayout(false);
            panelDepositar.PerformLayout();
            tabEstadisticas.ResumeLayout(false);
            panelEstadisticas.ResumeLayout(false);
            panelEstadisticas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
        private Panel panelFondo;
        private Label lblTitulo;
        private TabControl tabControl;
        private TabPage tabPerfil;
        private TabPage tabHistorial;
        private TabPage tabDepositar;
        private TabPage tabEstadisticas;
        private Panel panelInfoPersonal;
        private Label lblNombre;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblFechaNacimiento;
        private Label lblAlias;
        private Label lblSaldoActual;
        private Label lblTituloInfoPersonal;
        private Label lblValorNombre;
        private Label lblValorEmail;
        private Label lblValorTelefono;
        private Label lblValorFecha;
        private Label lblValorAlias;
        private Label lblValorSaldo;
        private DataGridView dgvHistorial;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colMetodo;
        private DataGridViewTextBoxColumn colEstado;
        private Label lblTituloHistorial;
        private Panel panelDepositar;
        private Label lblTituloDepositar;
        private Label lblMontoDeposito;
        private TextBox txtMontoDeposito;
        private Label lblMetodoPago;
        private ComboBox cmbMetodoPago;
        private Button btnConfirmarDeposito;
        private Button btnDeposito50;
        private Button btnDeposito100;
        private Button btnDeposito500;
        private Button btnDeposito1000;
        private Panel panelEstadisticas;
        private Label lblTituloEstadisticas;
        private Label lblPartidasJugadas;
        private Label lblPartidasGanadas;
        private Label lblPartidasPerdidas;
        private Label lblRachaActual;
        private Label lblMejorRacha;
        private Label lblDineroGanado;
        private Label lblDineroPerdido;
        private Label lblValorPartidasJugadas;
        private Label lblValorPartidasGanadas;
        private Label lblValorPartidasPerdidas;
        private Label lblValorRachaActual;
        private Label lblValorMejorRacha;
        private Label lblValorDineroGanado;
        private Label lblValorDineroPerdido;
        private Label lblPorcentajeVictorias;
        private Label lblValorPorcentaje;
    }
}