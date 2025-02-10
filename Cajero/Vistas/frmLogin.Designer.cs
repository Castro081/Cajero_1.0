namespace Cajero.Vistas
{
    partial class frmLogin
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
            btnCancelar = new Button();
            btnIngresar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtPin = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(5, 138, 138);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCancelar.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Image = Properties.Resources.Cancel;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(346, 440);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.RightToLeft = RightToLeft.No;
            btnCancelar.Size = new Size(204, 48);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = " Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(5, 138, 138);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnIngresar.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ActiveCaptionText;
            btnIngresar.Image = Properties.Resources.check;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(39, 440);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(189, 48);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 215);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 281);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 3;
            label2.Text = "Pin:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(5, 138, 138);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.ControlLightLight;
            txtUsuario.Location = new Point(200, 212);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(341, 28);
            txtUsuario.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 55, 55);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(616, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 720);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.file_removebg_preview;
            pictureBox1.Location = new Point(48, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(191, 227);
            label3.Name = "label3";
            label3.Size = new Size(348, 28);
            label3.TabIndex = 7;
            label3.Text = "____________________________\r\n";
            // 
            // txtPin
            // 
            txtPin.BackColor = Color.FromArgb(5, 138, 138);
            txtPin.BorderStyle = BorderStyle.None;
            txtPin.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPin.ForeColor = SystemColors.ControlLight;
            txtPin.Location = new Point(191, 281);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(341, 28);
            txtPin.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(191, 293);
            label4.Name = "label4";
            label4.Size = new Size(348, 28);
            label4.TabIndex = 9;
            label4.Text = "____________________________\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(266, 42);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 10;
            label5.Text = "LOGIN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(408, 649);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(461, 616);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 12;
            label7.Text = "copyright ©";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            ClientSize = new Size(1024, 720);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPin);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            MouseDown += frmLogin_MouseDown_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnIngresar;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Panel panel1;
        private Label label3;
        private TextBox txtPin;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
    }
}