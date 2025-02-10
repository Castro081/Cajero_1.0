namespace Cajero.Vistas
{
    partial class FrmCambioLimite
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
            laber_limiteRetiro = new Label();
            bt_cambiarLimite = new Button();
            b_regresar = new Button();
            cbmRetiro = new ComboBox();
            tbMonto = new TextBox();
            SuspendLayout();
            // 
            // laber_limiteRetiro
            // 
            laber_limiteRetiro.AutoSize = true;
            laber_limiteRetiro.BackColor = Color.Transparent;
            laber_limiteRetiro.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            laber_limiteRetiro.Location = new Point(416, 291);
            laber_limiteRetiro.Name = "laber_limiteRetiro";
            laber_limiteRetiro.Size = new Size(176, 26);
            laber_limiteRetiro.TabIndex = 7;
            laber_limiteRetiro.Text = "Limite de retiro";
            // 
            // bt_cambiarLimite
            // 
            bt_cambiarLimite.BackColor = Color.Silver;
            bt_cambiarLimite.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_cambiarLimite.Image = Properties.Resources.ajustes;
            bt_cambiarLimite.ImageAlign = ContentAlignment.MiddleRight;
            bt_cambiarLimite.Location = new Point(377, 391);
            bt_cambiarLimite.Name = "bt_cambiarLimite";
            bt_cambiarLimite.Size = new Size(261, 42);
            bt_cambiarLimite.TabIndex = 9;
            bt_cambiarLimite.Text = "Cambiar limite";
            bt_cambiarLimite.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_cambiarLimite.UseVisualStyleBackColor = false;
            bt_cambiarLimite.Click += bt_cambiarLimite_Click;
            bt_cambiarLimite.KeyPress += bt_cambiarLimite_KeyPressed;
            // 
            // b_regresar
            // 
            b_regresar.BackColor = Color.Silver;
            b_regresar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b_regresar.ForeColor = Color.Black;
            b_regresar.Image = Properties.Resources.flecha_izq;
            b_regresar.ImageAlign = ContentAlignment.MiddleLeft;
            b_regresar.Location = new Point(830, 640);
            b_regresar.Name = "b_regresar";
            b_regresar.Size = new Size(155, 44);
            b_regresar.TabIndex = 10;
            b_regresar.Text = "Regresar";
            b_regresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_regresar.UseVisualStyleBackColor = false;
            b_regresar.Click += b_regresar_Click;
            // 
            // cbmRetiro
            // 
            cbmRetiro.FormattingEnabled = true;
            cbmRetiro.Location = new Point(403, 334);
            cbmRetiro.Name = "cbmRetiro";
            cbmRetiro.Size = new Size(211, 36);
            cbmRetiro.TabIndex = 11;
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(403, 455);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(211, 35);
            tbMonto.TabIndex = 8;
            tbMonto.TextAlign = HorizontalAlignment.Center;
            tbMonto.Visible = false;
            // 
            // FrmCambioLimite
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            BackgroundImage = Properties.Resources.fondo_usuario;
            ClientSize = new Size(1024, 720);
            Controls.Add(cbmRetiro);
            Controls.Add(b_regresar);
            Controls.Add(bt_cambiarLimite);
            Controls.Add(tbMonto);
            Controls.Add(laber_limiteRetiro);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FrmCambioLimite";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCambioLimite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label laber_limiteRetiro;
        private TextBox textBox1;
        private Button bt_cambiarLimite;
        private Button b_regresar;
        private ComboBox cbmRetiro;
        private TextBox tbMonto;
    }
}