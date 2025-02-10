namespace Cajero.Vistas
{
    partial class frmEditarUsuario
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
            pictureBox1 = new PictureBox();
            label18 = new Label();
            txtBuscar = new Button();
            label1 = new Label();
            label9 = new Label();
            btnActivar = new Button();
            btnInfo = new Button();
            btnModificar = new Button();
            btnCancelar = new Button();
            textBuscar = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            cbmTipo = new ComboBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            txtSaldo = new TextBox();
            label17 = new Label();
            txtMonto = new TextBox();
            label16 = new Label();
            label10 = new Label();
            label5 = new Label();
            txtPin2 = new TextBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label15 = new Label();
            txtPin = new TextBox();
            label14 = new Label();
            txtCuenta = new TextBox();
            label13 = new Label();
            Cuenta = new Label();
            label6 = new Label();
            pictureBox9 = new PictureBox();
            txtCorreo = new TextBox();
            label25 = new Label();
            label26 = new Label();
            pictureBox5 = new PictureBox();
            txtTelefono = new TextBox();
            label23 = new Label();
            telefono = new Label();
            pictureBox8 = new PictureBox();
            txtDireccion = new TextBox();
            label21 = new Label();
            label22 = new Label();
            txtApellido = new TextBox();
            label19 = new Label();
            apellido = new Label();
            pictureBox2 = new PictureBox();
            txtNombre = new TextBox();
            label12 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.edit_usuarios;
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(151, 41);
            label18.Name = "label18";
            label18.Size = new Size(0, 15);
            label18.TabIndex = 24;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(97, 200, 170);
            txtBuscar.BackgroundImageLayout = ImageLayout.Center;
            txtBuscar.FlatStyle = FlatStyle.Flat;
            txtBuscar.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(326, 103);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(128, 54);
            txtBuscar.TabIndex = 44;
            txtBuscar.Text = "Buscar ";
            txtBuscar.UseVisualStyleBackColor = false;
            txtBuscar.Click += txtBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 26);
            label1.TabIndex = 45;
            label1.Text = "Ingrese el No.Cuenta a buscar:";
            label1.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(220, 56);
            label9.Name = "label9";
            label9.Size = new Size(312, 26);
            label9.TabIndex = 48;
            label9.Text = "_________________________";
            // 
            // btnActivar
            // 
            btnActivar.FlatStyle = FlatStyle.Flat;
            btnActivar.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActivar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActivar.Location = new Point(579, 9);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(202, 52);
            btnActivar.TabIndex = 49;
            btnActivar.Text = "Activar Cuenta";
            btnActivar.UseVisualStyleBackColor = true;
            btnActivar.Click += btnActivar_Click;
            // 
            // btnInfo
            // 
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.Location = new Point(579, 77);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(202, 52);
            btnInfo.TabIndex = 50;
            btnInfo.Text = "Informacion";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += button1_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Image = Properties.Resources.check;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(106, 394);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(136, 52);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "       Editar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(350, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(174, 55);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "         Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // textBuscar
            // 
            textBuscar.BackColor = Color.FromArgb(97, 200, 170);
            textBuscar.BorderStyle = BorderStyle.None;
            textBuscar.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBuscar.Location = new Point(238, 41);
            textBuscar.MaxLength = 16;
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(284, 25);
            textBuscar.TabIndex = 46;
            textBuscar.TextChanged += textBuscar_TextChanged;
            textBuscar.KeyPress += textBuscar_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbmTipo);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(txtSaldo);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPin2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtPin);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtCuenta);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(Cuenta);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(telefono);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(apellido);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic);
            panel1.Location = new Point(-2, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 483);
            panel1.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(590, 300);
            label7.Name = "label7";
            label7.Size = new Size(179, 28);
            label7.TabIndex = 54;
            label7.Text = "Tipo de Usuario:";
            // 
            // cbmTipo
            // 
            cbmTipo.BackColor = Color.FromArgb(97, 200, 170);
            cbmTipo.FlatStyle = FlatStyle.Flat;
            cbmTipo.FormattingEnabled = true;
            cbmTipo.Location = new Point(595, 331);
            cbmTipo.Name = "cbmTipo";
            cbmTipo.Size = new Size(203, 36);
            cbmTipo.TabIndex = 53;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.saldo_disponible;
            pictureBox7.Location = new Point(350, 300);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 49);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 98;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Monto_retirar;
            pictureBox6.Location = new Point(16, 304);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 97;
            pictureBox6.TabStop = false;
            // 
            // txtSaldo
            // 
            txtSaldo.BackColor = Color.FromArgb(97, 200, 170);
            txtSaldo.BorderStyle = BorderStyle.None;
            txtSaldo.Location = new Point(411, 319);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(173, 28);
            txtSaldo.TabIndex = 95;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(404, 288);
            label17.Name = "label17";
            label17.Size = new Size(76, 28);
            label17.TabIndex = 96;
            label17.Text = "Saldo:";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.FromArgb(97, 200, 170);
            txtMonto.BorderStyle = BorderStyle.None;
            txtMonto.Location = new Point(74, 319);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(168, 28);
            txtMonto.TabIndex = 94;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(70, 288);
            label16.Name = "label16";
            label16.Size = new Size(258, 28);
            label16.TabIndex = 93;
            label16.Text = "Monto maximo a retirar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(70, 329);
            label10.Name = "label10";
            label10.Size = new Size(168, 28);
            label10.TabIndex = 99;
            label10.Text = "_____________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 329);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 100;
            label5.Text = "______________";
            // 
            // txtPin2
            // 
            txtPin2.BackColor = Color.FromArgb(97, 200, 170);
            txtPin2.BorderStyle = BorderStyle.None;
            txtPin2.Location = new Point(600, 244);
            txtPin2.Name = "txtPin2";
            txtPin2.Size = new Size(165, 28);
            txtPin2.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(600, 252);
            label8.Name = "label8";
            label8.Size = new Size(156, 28);
            label8.TabIndex = 92;
            label8.Text = "____________";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cuenta;
            pictureBox3.Location = new Point(18, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 88;
            pictureBox3.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(568, 206);
            label15.Name = "label15";
            label15.Size = new Size(232, 28);
            label15.TabIndex = 84;
            label15.Text = "Confirmacion del pin:";
            // 
            // txtPin
            // 
            txtPin.BackColor = Color.FromArgb(97, 200, 170);
            txtPin.BorderStyle = BorderStyle.None;
            txtPin.Location = new Point(412, 244);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(165, 28);
            txtPin.TabIndex = 86;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(404, 206);
            label14.Name = "label14";
            label14.Size = new Size(52, 28);
            label14.TabIndex = 83;
            label14.Text = "pin:";
            // 
            // txtCuenta
            // 
            txtCuenta.BackColor = Color.FromArgb(97, 200, 170);
            txtCuenta.BorderStyle = BorderStyle.None;
            txtCuenta.Location = new Point(74, 244);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(311, 28);
            txtCuenta.TabIndex = 85;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(72, 206);
            label13.Name = "label13";
            label13.Size = new Size(133, 28);
            label13.TabIndex = 82;
            label13.Text = "No. Cuenta:";
            // 
            // Cuenta
            // 
            Cuenta.AutoSize = true;
            Cuenta.Location = new Point(72, 252);
            Cuenta.Name = "Cuenta";
            Cuenta.Size = new Size(324, 28);
            Cuenta.TabIndex = 90;
            Cuenta.Text = "__________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 252);
            label6.Name = "label6";
            label6.Size = new Size(156, 28);
            label6.TabIndex = 91;
            label6.Text = "____________";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.nombre;
            pictureBox9.Location = new Point(412, 144);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(47, 49);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 79;
            pictureBox9.TabStop = false;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(97, 200, 170);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Location = new Point(467, 158);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(279, 28);
            txtCorreo.TabIndex = 76;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(465, 127);
            label25.Name = "label25";
            label25.Size = new Size(89, 28);
            label25.TabIndex = 78;
            label25.Text = "Correo:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(467, 165);
            label26.Name = "label26";
            label26.Size = new Size(264, 28);
            label26.TabIndex = 80;
            label26.Text = "_____________________";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.nombre;
            pictureBox5.Location = new Point(577, 67);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 74;
            pictureBox5.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(97, 200, 170);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Location = new Point(631, 81);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(167, 28);
            txtTelefono.TabIndex = 65;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(622, 50);
            label23.Name = "label23";
            label23.Size = new Size(107, 28);
            label23.TabIndex = 73;
            label23.Text = "Telefono:";
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Location = new Point(623, 88);
            telefono.Name = "telefono";
            telefono.Size = new Size(180, 28);
            telefono.TabIndex = 75;
            telefono.Text = "______________";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.nombre;
            pictureBox8.Location = new Point(16, 144);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 49);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 71;
            pictureBox8.TabStop = false;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(97, 200, 170);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Location = new Point(71, 158);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(303, 28);
            txtDireccion.TabIndex = 64;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(69, 127);
            label21.Name = "label21";
            label21.Size = new Size(118, 28);
            label21.TabIndex = 70;
            label21.Text = "Dirección:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(71, 165);
            label22.Name = "label22";
            label22.Size = new Size(300, 28);
            label22.TabIndex = 72;
            label22.Text = "________________________";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(97, 200, 170);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Location = new Point(338, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(220, 28);
            txtApellido.TabIndex = 63;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(326, 50);
            label19.Name = "label19";
            label19.Size = new Size(113, 28);
            label19.TabIndex = 68;
            label19.Text = "Apellidos:";
            // 
            // apellido
            // 
            apellido.AutoSize = true;
            apellido.Location = new Point(328, 88);
            apellido.Name = "apellido";
            apellido.Size = new Size(204, 28);
            apellido.TabIndex = 69;
            apellido.Text = "________________";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.nombre;
            pictureBox2.Location = new Point(14, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(97, 200, 170);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(69, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 28);
            txtNombre.TabIndex = 61;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 50);
            label12.Name = "label12";
            label12.Size = new Size(91, 28);
            label12.TabIndex = 62;
            label12.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 88);
            label3.Name = "label3";
            label3.Size = new Size(252, 28);
            label3.TabIndex = 67;
            label3.Text = "____________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(285, 10);
            label2.Name = "label2";
            label2.Size = new Size(294, 40);
            label2.TabIndex = 60;
            label2.Text = "Modificar Usuario";
            // 
            // frmEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 200, 170);
            ClientSize = new Size(825, 666);
            Controls.Add(panel1);
            Controls.Add(btnInfo);
            Controls.Add(btnActivar);
            Controls.Add(textBuscar);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(label18);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarUsuario";
            Text = "frmEditarUsuario";
            Load += frmEditarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label18;
        private Button txtBuscar;
        private Label label1;
        private Label label9;
        private Button btnActivar;
        private Button btnInfo;
        private Button btnModificar;
        private Button btnCancelar;
        private TextBox textBuscar;
        private Panel panel1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private TextBox txtSaldo;
        private Label label17;
        private TextBox txtMonto;
        private Label label16;
        private Label label10;
        private Label label5;
        private TextBox txtPin2;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label15;
        private TextBox txtPin;
        private Label label14;
        private TextBox txtCuenta;
        private Label label13;
        private Label Cuenta;
        private Label label6;
        private PictureBox pictureBox9;
        private TextBox txtCorreo;
        private Label label25;
        private Label label26;
        private PictureBox pictureBox5;
        private TextBox txtTelefono;
        private Label label23;
        private Label telefono;
        private PictureBox pictureBox8;
        private TextBox txtDireccion;
        private Label label21;
        private Label label22;
        private TextBox txtApellido;
        private Label label19;
        private Label apellido;
        private PictureBox pictureBox2;
        private TextBox txtNombre;
        private Label label12;
        private Label label3;
        private Label label2;
        private Label label7;
        private ComboBox cbmTipo;
    }
}