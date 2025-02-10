namespace Cajero.Vistas
{
    partial class frmInicializar
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
            label1 = new Label();
            label3 = new Label();
            button3 = new Button();
            btnFondos = new Button();
            btnAgregarCajero = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 222);
            label1.Name = "label1";
            label1.Size = new Size(194, 26);
            label1.TabIndex = 0;
            label1.Text = "Inicializar Cajero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(441, 222);
            label3.Name = "label3";
            label3.Size = new Size(275, 26);
            label3.TabIndex = 2;
            label3.Text = "Agregar Fondos al Cajeo ";
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.apagar_cajero;
            button3.Location = new Point(163, 274);
            button3.Name = "button3";
            button3.Size = new Size(117, 110);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnFondos
            // 
            btnFondos.FlatStyle = FlatStyle.Flat;
            btnFondos.Image = Properties.Resources.Agregar_FONDOS2;
            btnFondos.Location = new Point(510, 274);
            btnFondos.Name = "btnFondos";
            btnFondos.Size = new Size(117, 110);
            btnFondos.TabIndex = 8;
            btnFondos.UseVisualStyleBackColor = true;
            btnFondos.Click += btnFondos_Click;
            // 
            // btnAgregarCajero
            // 
            btnAgregarCajero.BackColor = Color.Silver;
            btnAgregarCajero.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCajero.Location = new Point(638, 29);
            btnAgregarCajero.Name = "btnAgregarCajero";
            btnAgregarCajero.Size = new Size(151, 36);
            btnAgregarCajero.TabIndex = 9;
            btnAgregarCajero.Text = "Agregar Cajero";
            btnAgregarCajero.UseVisualStyleBackColor = false;
            btnAgregarCajero.Click += btnAgregarCajero_Click;
            // 
            // frmInicializar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 200, 170);
            ClientSize = new Size(817, 627);
            Controls.Add(btnAgregarCajero);
            Controls.Add(btnFondos);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInicializar";
            Text = "frmInicializar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button button3;
        private Button btnFondos;
        private Button btnAgregarCajero;
    }
}