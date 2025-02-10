namespace Cajero.Vistas
{
    partial class FrmCambioPin
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
            label_pinActual = new Label();
            label_nuevoPin1 = new Label();
            label_nuevoPin2 = new Label();
            tbPinActual = new TextBox();
            tbPinNuevo2 = new TextBox();
            tbPinNuevo1 = new TextBox();
            b_regresar = new Button();
            bt_cambiarPin = new Button();
            SuspendLayout();
            // 
            // label_pinActual
            // 
            label_pinActual.AutoSize = true;
            label_pinActual.Location = new Point(341, 211);
            label_pinActual.Name = "label_pinActual";
            label_pinActual.Size = new Size(115, 28);
            label_pinActual.TabIndex = 0;
            label_pinActual.Text = "Pin actual";
            // 
            // label_nuevoPin1
            // 
            label_nuevoPin1.AutoSize = true;
            label_nuevoPin1.Location = new Point(339, 305);
            label_nuevoPin1.Name = "label_nuevoPin1";
            label_nuevoPin1.Size = new Size(117, 28);
            label_nuevoPin1.TabIndex = 1;
            label_nuevoPin1.Text = "Nuevo Pin";
            // 
            // label_nuevoPin2
            // 
            label_nuevoPin2.AutoSize = true;
            label_nuevoPin2.Location = new Point(341, 402);
            label_nuevoPin2.Name = "label_nuevoPin2";
            label_nuevoPin2.Size = new Size(117, 28);
            label_nuevoPin2.TabIndex = 2;
            label_nuevoPin2.Text = "Nuevo Pin";
            // 
            // tbPinActual
            // 
            tbPinActual.Location = new Point(487, 208);
            tbPinActual.Name = "tbPinActual";
            tbPinActual.PasswordChar = '*';
            tbPinActual.Size = new Size(176, 35);
            tbPinActual.TabIndex = 3;
            tbPinActual.TextAlign = HorizontalAlignment.Center;
            tbPinActual.TextChanged += tbPinActual_TextChanged;
            tbPinActual.KeyPress += tbPin_KeyPressed;
            // 
            // tbPinNuevo2
            // 
            tbPinNuevo2.Location = new Point(487, 395);
            tbPinNuevo2.Name = "tbPinNuevo2";
            tbPinNuevo2.PasswordChar = '*';
            tbPinNuevo2.Size = new Size(176, 35);
            tbPinNuevo2.TabIndex = 5;
            tbPinNuevo2.TextAlign = HorizontalAlignment.Center;
            tbPinNuevo2.TextChanged += tbPinNuevo2_TextChanged;
            tbPinNuevo2.KeyPress += tbPin_KeyPressed;
            // 
            // tbPinNuevo1
            // 
            tbPinNuevo1.Location = new Point(487, 302);
            tbPinNuevo1.Name = "tbPinNuevo1";
            tbPinNuevo1.PasswordChar = '*';
            tbPinNuevo1.Size = new Size(176, 35);
            tbPinNuevo1.TabIndex = 4;
            tbPinNuevo1.TextAlign = HorizontalAlignment.Center;
            tbPinNuevo1.TextChanged += tbPinNuevo1_TextChanged;
            tbPinNuevo1.KeyPress += tbPin_KeyPressed;
            // 
            // b_regresar
            // 
            b_regresar.BackColor = Color.Silver;
            b_regresar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            b_regresar.ForeColor = Color.Black;
            b_regresar.Image = Properties.Resources.flecha_izq;
            b_regresar.ImageAlign = ContentAlignment.MiddleLeft;
            b_regresar.Location = new Point(830, 640);
            b_regresar.Name = "b_regresar";
            b_regresar.Size = new Size(155, 44);
            b_regresar.TabIndex = 7;
            b_regresar.Text = "Regresar";
            b_regresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_regresar.UseVisualStyleBackColor = false;
            b_regresar.Click += b_regresar_Click;
            // 
            // bt_cambiarPin
            // 
            bt_cambiarPin.BackColor = Color.Silver;
            bt_cambiarPin.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bt_cambiarPin.Image = Properties.Resources.ajustes;
            bt_cambiarPin.ImageAlign = ContentAlignment.MiddleLeft;
            bt_cambiarPin.Location = new Point(414, 497);
            bt_cambiarPin.Name = "bt_cambiarPin";
            bt_cambiarPin.Size = new Size(195, 44);
            bt_cambiarPin.TabIndex = 6;
            bt_cambiarPin.Text = "Cambiar Pin";
            bt_cambiarPin.TextImageRelation = TextImageRelation.TextBeforeImage;
            bt_cambiarPin.UseVisualStyleBackColor = false;
            bt_cambiarPin.Click += bt_cambiarPin_Click;
            // 
            // FrmCambioPin
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            BackgroundImage = Properties.Resources.fondo_usuario;
            ClientSize = new Size(1024, 720);
            Controls.Add(bt_cambiarPin);
            Controls.Add(b_regresar);
            Controls.Add(tbPinNuevo1);
            Controls.Add(tbPinNuevo2);
            Controls.Add(tbPinActual);
            Controls.Add(label_nuevoPin2);
            Controls.Add(label_nuevoPin1);
            Controls.Add(label_pinActual);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FrmCambioPin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCambioPin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_pinActual;
        private Label label_nuevoPin1;
        private Label label_nuevoPin2;
        private TextBox tbPinActual;
        private TextBox tbPinNuevo2;
        private TextBox tbPinNuevo1;
        private Button b_regresar;
        private Button bt_cambiarPin;
    }
}