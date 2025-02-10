namespace Cajero.Vistas
{
    partial class frmPanelUsuario
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
            label_bienvenida = new Label();
            b_retiros = new Button();
            b_depositos = new Button();
            b_saldo = new Button();
            b_movimientos = new Button();
            b_cambio_pin = new Button();
            b_monto = new Button();
            b_regresar = new Button();
            SuspendLayout();
            // 
            // label_bienvenida
            // 
            label_bienvenida.AutoSize = true;
            label_bienvenida.BackColor = Color.Transparent;
            label_bienvenida.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_bienvenida.Location = new Point(405, 81);
            label_bienvenida.Name = "label_bienvenida";
            label_bienvenida.Size = new Size(220, 80);
            label_bienvenida.TabIndex = 0;
            label_bienvenida.Text = "Bienvenido\r\nusuario12345";
            label_bienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // b_retiros
            // 
            b_retiros.BackColor = Color.Silver;
            b_retiros.Image = Properties.Resources.retiro;
            b_retiros.Location = new Point(46, 129);
            b_retiros.Name = "b_retiros";
            b_retiros.RightToLeft = RightToLeft.No;
            b_retiros.Size = new Size(192, 65);
            b_retiros.TabIndex = 1;
            b_retiros.Text = "Retiros";
            b_retiros.TextAlign = ContentAlignment.MiddleRight;
            b_retiros.TextImageRelation = TextImageRelation.ImageBeforeText;
            b_retiros.UseVisualStyleBackColor = false;
            b_retiros.Click += b_retiros_Click;
            // 
            // b_depositos
            // 
            b_depositos.BackColor = Color.Silver;
            b_depositos.Image = Properties.Resources.deposito;
            b_depositos.Location = new Point(46, 362);
            b_depositos.Name = "b_depositos";
            b_depositos.Size = new Size(192, 63);
            b_depositos.TabIndex = 2;
            b_depositos.Text = "Depositos";
            b_depositos.TextAlign = ContentAlignment.MiddleRight;
            b_depositos.TextImageRelation = TextImageRelation.ImageBeforeText;
            b_depositos.UseVisualStyleBackColor = false;
            b_depositos.Click += b_depositos_Click;
            // 
            // b_saldo
            // 
            b_saldo.BackColor = Color.Silver;
            b_saldo.BackgroundImageLayout = ImageLayout.None;
            b_saldo.Image = Properties.Resources.saldo;
            b_saldo.ImageAlign = ContentAlignment.MiddleLeft;
            b_saldo.Location = new Point(772, 129);
            b_saldo.Name = "b_saldo";
            b_saldo.RightToLeft = RightToLeft.No;
            b_saldo.Size = new Size(188, 65);
            b_saldo.TabIndex = 3;
            b_saldo.Text = "Saldo";
            b_saldo.TextAlign = ContentAlignment.MiddleRight;
            b_saldo.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_saldo.UseVisualStyleBackColor = false;
            b_saldo.Click += b_saldo_Click;
            // 
            // b_movimientos
            // 
            b_movimientos.BackColor = Color.Silver;
            b_movimientos.Image = Properties.Resources.movimientos_dinero;
            b_movimientos.ImageAlign = ContentAlignment.MiddleLeft;
            b_movimientos.Location = new Point(772, 362);
            b_movimientos.Name = "b_movimientos";
            b_movimientos.Size = new Size(188, 63);
            b_movimientos.TabIndex = 4;
            b_movimientos.Text = "Movimientos";
            b_movimientos.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_movimientos.UseVisualStyleBackColor = false;
            b_movimientos.Click += b_movimientos_Click;
            // 
            // b_cambio_pin
            // 
            b_cambio_pin.BackColor = Color.Silver;
            b_cambio_pin.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            b_cambio_pin.Image = Properties.Resources.pin;
            b_cambio_pin.ImageAlign = ContentAlignment.MiddleLeft;
            b_cambio_pin.Location = new Point(738, 603);
            b_cambio_pin.Name = "b_cambio_pin";
            b_cambio_pin.RightToLeft = RightToLeft.No;
            b_cambio_pin.Size = new Size(222, 48);
            b_cambio_pin.TabIndex = 5;
            b_cambio_pin.Text = "Cambio de PIN";
            b_cambio_pin.TextAlign = ContentAlignment.MiddleRight;
            b_cambio_pin.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_cambio_pin.UseVisualStyleBackColor = false;
            b_cambio_pin.Click += b_cambio_pin_Click;
            // 
            // b_monto
            // 
            b_monto.BackColor = Color.Silver;
            b_monto.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            b_monto.Image = Properties.Resources.ajustes;
            b_monto.ImageAlign = ContentAlignment.MiddleRight;
            b_monto.Location = new Point(46, 603);
            b_monto.Name = "b_monto";
            b_monto.Size = new Size(222, 48);
            b_monto.TabIndex = 6;
            b_monto.Text = "Cambiar limite";
            b_monto.TextImageRelation = TextImageRelation.ImageBeforeText;
            b_monto.UseVisualStyleBackColor = false;
            b_monto.Click += b_monto_Click;
            // 
            // b_regresar
            // 
            b_regresar.BackColor = Color.Silver;
            b_regresar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            b_regresar.ForeColor = Color.Black;
            b_regresar.Image = Properties.Resources.salir;
            b_regresar.ImageAlign = ContentAlignment.MiddleLeft;
            b_regresar.Location = new Point(429, 621);
            b_regresar.Name = "b_regresar";
            b_regresar.Size = new Size(155, 48);
            b_regresar.TabIndex = 8;
            b_regresar.Text = "Cerrar";
            b_regresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_regresar.UseVisualStyleBackColor = false;
            b_regresar.Click += b_regresar_Click;
            // 
            // frmPanelUsuario
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            BackgroundImage = Properties.Resources.fondo_usuario;
            ClientSize = new Size(1024, 720);
            Controls.Add(b_regresar);
            Controls.Add(label_bienvenida);
            Controls.Add(b_monto);
            Controls.Add(b_cambio_pin);
            Controls.Add(b_movimientos);
            Controls.Add(b_saldo);
            Controls.Add(b_depositos);
            Controls.Add(b_retiros);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmPanelUsuario";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_bienvenida;
        private Button b_retiros;
        private Button b_depositos;
        private Button b_saldo;
        private Button b_movimientos;
        private Button b_cambio_pin;
        private Button b_monto;
        private Button b_regresar;
    }
}