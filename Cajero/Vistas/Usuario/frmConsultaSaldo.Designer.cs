namespace Cajero.Vistas
{
    partial class frmConsultaSaldo
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
            labelSaldo = new Label();
            b_regresar = new Button();
            SuspendLayout();
            // 
            // labelSaldo
            // 
            labelSaldo.AutoSize = true;
            labelSaldo.BackColor = Color.Transparent;
            labelSaldo.Location = new Point(394, 307);
            labelSaldo.Name = "labelSaldo";
            labelSaldo.Size = new Size(236, 56);
            labelSaldo.TabIndex = 0;
            labelSaldo.Text = "Su saldo restante es de\r\nQ100000000";
            labelSaldo.TextAlign = ContentAlignment.MiddleCenter;
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
            b_regresar.TabIndex = 5;
            b_regresar.Text = "Regresar";
            b_regresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_regresar.UseVisualStyleBackColor = false;
            b_regresar.Click += b_regresar_Click;
            // 
            // frmConsultaSaldo
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            BackgroundImage = Properties.Resources.fondo_usuario;
            ClientSize = new Size(1024, 720);
            Controls.Add(b_regresar);
            Controls.Add(labelSaldo);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "frmConsultaSaldo";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSaldo;
        private Button b_regresar;
    }
}