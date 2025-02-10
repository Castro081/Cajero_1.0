namespace Cajero.Vistas
{
    partial class frmRetiros
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
            b_regresar = new Button();
            labelDinero = new Label();
            pbQuitar200 = new PictureBox();
            pbQuitar100 = new PictureBox();
            pbQuitar50 = new PictureBox();
            pbQuitar20 = new PictureBox();
            pbQuitar10 = new PictureBox();
            pbQuitar5 = new PictureBox();
            pbQuitar1 = new PictureBox();
            tbCantidad200 = new TextBox();
            tbCantidad100 = new TextBox();
            tbCantidad50 = new TextBox();
            tbCantidad20 = new TextBox();
            tbCantidad10 = new TextBox();
            tbCantidad5 = new TextBox();
            tbCantidad1 = new TextBox();
            btnRetirar = new Button();
            btnRetirar200 = new Button();
            btnRetirar100 = new Button();
            btnRetirar50 = new Button();
            btnRetirar20 = new Button();
            btnRetirar10 = new Button();
            btnRetirar5 = new Button();
            btnRetirar1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbQuitar200).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar1).BeginInit();
            SuspendLayout();
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
            b_regresar.TabIndex = 8;
            b_regresar.Text = "Regresar";
            b_regresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_regresar.UseVisualStyleBackColor = false;
            b_regresar.Click += b_regresar_Click;
            // 
            // labelDinero
            // 
            labelDinero.AutoSize = true;
            labelDinero.Location = new Point(453, 564);
            labelDinero.Name = "labelDinero";
            labelDinero.Size = new Size(83, 28);
            labelDinero.TabIndex = 71;
            labelDinero.Text = "Q 0000";
            labelDinero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbQuitar200
            // 
            pbQuitar200.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar200.Image = Properties.Resources.menos;
            pbQuitar200.Location = new Point(675, 499);
            pbQuitar200.Name = "pbQuitar200";
            pbQuitar200.Size = new Size(35, 35);
            pbQuitar200.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar200.TabIndex = 70;
            pbQuitar200.TabStop = false;
            pbQuitar200.Click += pbQuitar_Click;
            // 
            // pbQuitar100
            // 
            pbQuitar100.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar100.Image = Properties.Resources.menos;
            pbQuitar100.Location = new Point(675, 353);
            pbQuitar100.Name = "pbQuitar100";
            pbQuitar100.Size = new Size(35, 35);
            pbQuitar100.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar100.TabIndex = 69;
            pbQuitar100.TabStop = false;
            pbQuitar100.Click += pbQuitar_Click;
            // 
            // pbQuitar50
            // 
            pbQuitar50.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar50.Image = Properties.Resources.menos;
            pbQuitar50.Location = new Point(675, 206);
            pbQuitar50.Name = "pbQuitar50";
            pbQuitar50.Size = new Size(35, 35);
            pbQuitar50.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar50.TabIndex = 68;
            pbQuitar50.TabStop = false;
            pbQuitar50.Click += pbQuitar_Click;
            // 
            // pbQuitar20
            // 
            pbQuitar20.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar20.Image = Properties.Resources.menos;
            pbQuitar20.Location = new Point(675, 73);
            pbQuitar20.Name = "pbQuitar20";
            pbQuitar20.Size = new Size(35, 35);
            pbQuitar20.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar20.TabIndex = 67;
            pbQuitar20.TabStop = false;
            pbQuitar20.Click += pbQuitar_Click;
            // 
            // pbQuitar10
            // 
            pbQuitar10.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar10.Image = Properties.Resources.menos;
            pbQuitar10.Location = new Point(272, 430);
            pbQuitar10.Name = "pbQuitar10";
            pbQuitar10.Size = new Size(35, 35);
            pbQuitar10.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar10.TabIndex = 66;
            pbQuitar10.TabStop = false;
            pbQuitar10.Click += pbQuitar_Click;
            // 
            // pbQuitar5
            // 
            pbQuitar5.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar5.Image = Properties.Resources.menos;
            pbQuitar5.Location = new Point(272, 291);
            pbQuitar5.Name = "pbQuitar5";
            pbQuitar5.Size = new Size(35, 35);
            pbQuitar5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar5.TabIndex = 65;
            pbQuitar5.TabStop = false;
            pbQuitar5.Click += pbQuitar_Click;
            // 
            // pbQuitar1
            // 
            pbQuitar1.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar1.Image = Properties.Resources.menos;
            pbQuitar1.Location = new Point(272, 147);
            pbQuitar1.Name = "pbQuitar1";
            pbQuitar1.Size = new Size(35, 35);
            pbQuitar1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar1.TabIndex = 64;
            pbQuitar1.TabStop = false;
            pbQuitar1.Click += pbQuitar_Click;
            // 
            // tbCantidad200
            // 
            tbCantidad200.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad200.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad200.Location = new Point(734, 499);
            tbCantidad200.Name = "tbCantidad200";
            tbCantidad200.Size = new Size(50, 35);
            tbCantidad200.TabIndex = 63;
            tbCantidad200.Text = "0";
            tbCantidad200.TextAlign = HorizontalAlignment.Center;
            tbCantidad200.TextChanged += tbCantidad200_TextChanged;
            // 
            // tbCantidad100
            // 
            tbCantidad100.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad100.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad100.Location = new Point(734, 353);
            tbCantidad100.Name = "tbCantidad100";
            tbCantidad100.Size = new Size(50, 35);
            tbCantidad100.TabIndex = 62;
            tbCantidad100.Text = "0";
            tbCantidad100.TextAlign = HorizontalAlignment.Center;
            tbCantidad100.TextChanged += tbCantidad100_TextChanged;
            // 
            // tbCantidad50
            // 
            tbCantidad50.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad50.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad50.Location = new Point(734, 206);
            tbCantidad50.Name = "tbCantidad50";
            tbCantidad50.Size = new Size(50, 35);
            tbCantidad50.TabIndex = 61;
            tbCantidad50.Text = "0";
            tbCantidad50.TextAlign = HorizontalAlignment.Center;
            tbCantidad50.TextChanged += tbCantidad50_TextChanged;
            // 
            // tbCantidad20
            // 
            tbCantidad20.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad20.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad20.Location = new Point(734, 73);
            tbCantidad20.Name = "tbCantidad20";
            tbCantidad20.Size = new Size(50, 35);
            tbCantidad20.TabIndex = 60;
            tbCantidad20.Text = "0";
            tbCantidad20.TextAlign = HorizontalAlignment.Center;
            tbCantidad20.TextChanged += tbCantidad20_TextChanged;
            // 
            // tbCantidad10
            // 
            tbCantidad10.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad10.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad10.Location = new Point(202, 430);
            tbCantidad10.Name = "tbCantidad10";
            tbCantidad10.Size = new Size(50, 35);
            tbCantidad10.TabIndex = 59;
            tbCantidad10.Text = "0";
            tbCantidad10.TextAlign = HorizontalAlignment.Center;
            tbCantidad10.TextChanged += tbCantidad10_TextChanged;
            // 
            // tbCantidad5
            // 
            tbCantidad5.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad5.Location = new Point(202, 291);
            tbCantidad5.Name = "tbCantidad5";
            tbCantidad5.Size = new Size(50, 35);
            tbCantidad5.TabIndex = 58;
            tbCantidad5.Text = "0";
            tbCantidad5.TextAlign = HorizontalAlignment.Center;
            tbCantidad5.TextChanged += tbCantidad5_TextChanged;
            // 
            // tbCantidad1
            // 
            tbCantidad1.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad1.Location = new Point(202, 147);
            tbCantidad1.Name = "tbCantidad1";
            tbCantidad1.Size = new Size(50, 35);
            tbCantidad1.TabIndex = 57;
            tbCantidad1.Text = "0";
            tbCantidad1.TextAlign = HorizontalAlignment.Center;
            tbCantidad1.TextChanged += tbCantidad1_TextChanged;
            // 
            // btnRetirar
            // 
            btnRetirar.BackColor = Color.Silver;
            btnRetirar.Location = new Point(428, 609);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(130, 49);
            btnRetirar.TabIndex = 56;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = false;
            btnRetirar.Click += btnRetirar_Click_1;
            // 
            // btnRetirar200
            // 
            btnRetirar200.BackColor = Color.Silver;
            btnRetirar200.Image = Properties.Resources.dinero;
            btnRetirar200.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetirar200.Location = new Point(810, 489);
            btnRetirar200.Name = "btnRetirar200";
            btnRetirar200.Size = new Size(132, 52);
            btnRetirar200.TabIndex = 54;
            btnRetirar200.Text = "Q200";
            btnRetirar200.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRetirar200.UseVisualStyleBackColor = false;
            btnRetirar200.Click += btCantidad_Click;
            // 
            // btnRetirar100
            // 
            btnRetirar100.BackColor = Color.Silver;
            btnRetirar100.Image = Properties.Resources.dinero;
            btnRetirar100.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetirar100.Location = new Point(810, 343);
            btnRetirar100.Name = "btnRetirar100";
            btnRetirar100.Size = new Size(132, 52);
            btnRetirar100.TabIndex = 53;
            btnRetirar100.Text = "Q100";
            btnRetirar100.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRetirar100.UseVisualStyleBackColor = false;
            btnRetirar100.Click += btCantidad_Click;
            // 
            // btnRetirar50
            // 
            btnRetirar50.BackColor = Color.Silver;
            btnRetirar50.Image = Properties.Resources.dinero;
            btnRetirar50.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetirar50.Location = new Point(810, 196);
            btnRetirar50.Name = "btnRetirar50";
            btnRetirar50.Size = new Size(132, 52);
            btnRetirar50.TabIndex = 52;
            btnRetirar50.Text = "Q50";
            btnRetirar50.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRetirar50.UseVisualStyleBackColor = false;
            btnRetirar50.Click += btCantidad_Click;
            // 
            // btnRetirar20
            // 
            btnRetirar20.BackColor = Color.Silver;
            btnRetirar20.Image = Properties.Resources.dinero;
            btnRetirar20.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetirar20.Location = new Point(810, 63);
            btnRetirar20.Name = "btnRetirar20";
            btnRetirar20.Size = new Size(132, 52);
            btnRetirar20.TabIndex = 51;
            btnRetirar20.Text = "Q20";
            btnRetirar20.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRetirar20.UseVisualStyleBackColor = false;
            btnRetirar20.Click += btCantidad_Click;
            // 
            // btnRetirar10
            // 
            btnRetirar10.BackColor = Color.Silver;
            btnRetirar10.Image = Properties.Resources.dinero;
            btnRetirar10.ImageAlign = ContentAlignment.MiddleRight;
            btnRetirar10.Location = new Point(52, 420);
            btnRetirar10.Name = "btnRetirar10";
            btnRetirar10.Size = new Size(132, 52);
            btnRetirar10.TabIndex = 50;
            btnRetirar10.Text = "Q10";
            btnRetirar10.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRetirar10.UseVisualStyleBackColor = false;
            btnRetirar10.Click += btCantidad_Click;
            // 
            // btnRetirar5
            // 
            btnRetirar5.BackColor = Color.Silver;
            btnRetirar5.Image = Properties.Resources.dinero;
            btnRetirar5.Location = new Point(52, 281);
            btnRetirar5.Name = "btnRetirar5";
            btnRetirar5.Size = new Size(132, 52);
            btnRetirar5.TabIndex = 49;
            btnRetirar5.Text = "Q5";
            btnRetirar5.TextAlign = ContentAlignment.MiddleRight;
            btnRetirar5.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRetirar5.UseVisualStyleBackColor = false;
            btnRetirar5.Click += btCantidad_Click;
            // 
            // btnRetirar1
            // 
            btnRetirar1.BackColor = Color.Silver;
            btnRetirar1.Image = Properties.Resources.dinero;
            btnRetirar1.ImageAlign = ContentAlignment.MiddleRight;
            btnRetirar1.Location = new Point(52, 138);
            btnRetirar1.Name = "btnRetirar1";
            btnRetirar1.Size = new Size(132, 52);
            btnRetirar1.TabIndex = 48;
            btnRetirar1.Text = "Q1";
            btnRetirar1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRetirar1.UseVisualStyleBackColor = false;
            btnRetirar1.Click += btCantidad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 72;
            label1.Text = "label1";
            // 
            // frmRetiros
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            BackgroundImage = Properties.Resources.fondo_usuario;
            ClientSize = new Size(1024, 720);
            Controls.Add(label1);
            Controls.Add(labelDinero);
            Controls.Add(pbQuitar200);
            Controls.Add(pbQuitar100);
            Controls.Add(pbQuitar50);
            Controls.Add(pbQuitar20);
            Controls.Add(pbQuitar10);
            Controls.Add(pbQuitar5);
            Controls.Add(pbQuitar1);
            Controls.Add(tbCantidad200);
            Controls.Add(tbCantidad100);
            Controls.Add(tbCantidad50);
            Controls.Add(tbCantidad20);
            Controls.Add(tbCantidad10);
            Controls.Add(tbCantidad5);
            Controls.Add(tbCantidad1);
            Controls.Add(btnRetirar);
            Controls.Add(btnRetirar200);
            Controls.Add(btnRetirar100);
            Controls.Add(btnRetirar50);
            Controls.Add(btnRetirar20);
            Controls.Add(btnRetirar10);
            Controls.Add(btnRetirar5);
            Controls.Add(btnRetirar1);
            Controls.Add(b_regresar);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmRetiros";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retiros";
            ((System.ComponentModel.ISupportInitialize)pbQuitar200).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar100).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar50).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button b_regresar;
        private Label labelDinero;
        private PictureBox pbQuitar200;
        private PictureBox pbQuitar100;
        private PictureBox pbQuitar50;
        private PictureBox pbQuitar20;
        private PictureBox pbQuitar10;
        private PictureBox pbQuitar5;
        private PictureBox pbQuitar1;
        private TextBox tbCantidad200;
        private TextBox tbCantidad100;
        private TextBox tbCantidad50;
        private TextBox tbCantidad20;
        private TextBox tbCantidad10;
        private TextBox tbCantidad5;
        private TextBox tbCantidad1;
        private Button btnRetirar;
        private Button btnRetirar200;
        private Button btnRetirar100;
        private Button btnRetirar50;
        private Button btnRetirar20;
        private Button btnRetirar10;
        private Button btnRetirar5;
        private Button btnRetirar1;
        private Label label1;
    }
}