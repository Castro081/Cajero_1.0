namespace Cajero.Vistas.Usuario
{
    partial class frmPrimerInicio
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
            tbPin1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbPin2 = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label_bienvenida
            // 
            label_bienvenida.AutoSize = true;
            label_bienvenida.BackColor = Color.Transparent;
            label_bienvenida.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_bienvenida.Location = new Point(308, 140);
            label_bienvenida.Name = "label_bienvenida";
            label_bienvenida.Size = new Size(418, 26);
            label_bienvenida.TabIndex = 0;
            label_bienvenida.Text = "Bienvenido/a,  Por favor, cambie su PIN";
            // 
            // tbPin1
            // 
            tbPin1.Location = new Point(379, 261);
            tbPin1.Name = "tbPin1";
            tbPin1.PasswordChar = '*';
            tbPin1.Size = new Size(243, 35);
            tbPin1.TabIndex = 1;
            tbPin1.TextAlign = HorizontalAlignment.Center;
            tbPin1.TextChanged += tbPin1_TextChanged;
            tbPin1.KeyPress += tbPin1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(418, 219);
            label2.Name = "label2";
            label2.Size = new Size(163, 26);
            label2.TabIndex = 2;
            label2.Text = "Ingrese su PIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(411, 342);
            label3.Name = "label3";
            label3.Size = new Size(184, 26);
            label3.TabIndex = 3;
            label3.Text = "Confirme su PIN";
            // 
            // tbPin2
            // 
            tbPin2.Location = new Point(379, 386);
            tbPin2.Name = "tbPin2";
            tbPin2.PasswordChar = '*';
            tbPin2.Size = new Size(243, 35);
            tbPin2.TabIndex = 5;
            tbPin2.TextAlign = HorizontalAlignment.Center;
            tbPin2.TextChanged += tbPin2_TextChanged;
            tbPin2.KeyPress += tbPin2_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(411, 452);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(170, 43);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmPrimerInicio
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            BackgroundImage = Properties.Resources.fondo_usuario;
            ClientSize = new Size(1024, 720);
            Controls.Add(btnAceptar);
            Controls.Add(tbPin2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPin1);
            Controls.Add(label_bienvenida);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "frmPrimerInicio";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbPin1;
        private Label label2;
        private Label label3;
        private TextBox tbPin2;
        private Button btnAceptar;
        private Label label_bienvenida;
    }
}