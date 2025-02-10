namespace Cajero.Vistas
{
    partial class frmDepositos
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
            btnDepositar1 = new Button();
            btnDepositar5 = new Button();
            btnDepositar10 = new Button();
            btnDepositar20 = new Button();
            btnDepositar50 = new Button();
            btnDepositar100 = new Button();
            btnDepositar200 = new Button();
            b_regresar = new Button();
            btnDepositar = new Button();
            tbCantidad1 = new TextBox();
            tbCantidad5 = new TextBox();
            tbCantidad10 = new TextBox();
            tbCantidad20 = new TextBox();
            tbCantidad50 = new TextBox();
            tbCantidad100 = new TextBox();
            tbCantidad200 = new TextBox();
            pbQuitar200 = new PictureBox();
            pbQuitar100 = new PictureBox();
            pbQuitar50 = new PictureBox();
            pbQuitar20 = new PictureBox();
            pbQuitar10 = new PictureBox();
            pbQuitar5 = new PictureBox();
            pbQuitar1 = new PictureBox();
            labelDinero = new Label();
            ((System.ComponentModel.ISupportInitialize)pbQuitar200).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar1).BeginInit();
            SuspendLayout();
            // 
            // btnDepositar1
            // 
            btnDepositar1.BackColor = Color.Silver;
            btnDepositar1.Image = Properties.Resources.dinero;
            btnDepositar1.ImageAlign = ContentAlignment.MiddleRight;
            btnDepositar1.Location = new Point(64, 164);
            btnDepositar1.Name = "btnDepositar1";
            btnDepositar1.Size = new Size(132, 52);
            btnDepositar1.TabIndex = 0;
            btnDepositar1.Text = "Q1";
            btnDepositar1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepositar1.UseVisualStyleBackColor = false;
            btnDepositar1.Click += btCantidad_Click;
            // 
            // btnDepositar5
            // 
            btnDepositar5.BackColor = Color.Silver;
            btnDepositar5.Image = Properties.Resources.dinero;
            btnDepositar5.Location = new Point(64, 307);
            btnDepositar5.Name = "btnDepositar5";
            btnDepositar5.Size = new Size(132, 52);
            btnDepositar5.TabIndex = 1;
            btnDepositar5.Text = "Q5";
            btnDepositar5.TextAlign = ContentAlignment.MiddleRight;
            btnDepositar5.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepositar5.UseVisualStyleBackColor = false;
            btnDepositar5.Click += btCantidad_Click;
            // 
            // btnDepositar10
            // 
            btnDepositar10.BackColor = Color.Silver;
            btnDepositar10.Image = Properties.Resources.dinero;
            btnDepositar10.ImageAlign = ContentAlignment.MiddleRight;
            btnDepositar10.Location = new Point(64, 446);
            btnDepositar10.Name = "btnDepositar10";
            btnDepositar10.Size = new Size(132, 52);
            btnDepositar10.TabIndex = 2;
            btnDepositar10.Text = "Q10";
            btnDepositar10.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepositar10.UseVisualStyleBackColor = false;
            btnDepositar10.Click += btCantidad_Click;
            // 
            // btnDepositar20
            // 
            btnDepositar20.BackColor = Color.Silver;
            btnDepositar20.Image = Properties.Resources.dinero;
            btnDepositar20.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepositar20.Location = new Point(822, 89);
            btnDepositar20.Name = "btnDepositar20";
            btnDepositar20.Size = new Size(132, 52);
            btnDepositar20.TabIndex = 3;
            btnDepositar20.Text = "Q20";
            btnDepositar20.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDepositar20.UseVisualStyleBackColor = false;
            btnDepositar20.Click += btCantidad_Click;
            // 
            // btnDepositar50
            // 
            btnDepositar50.BackColor = Color.Silver;
            btnDepositar50.Image = Properties.Resources.dinero;
            btnDepositar50.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepositar50.Location = new Point(822, 222);
            btnDepositar50.Name = "btnDepositar50";
            btnDepositar50.Size = new Size(132, 52);
            btnDepositar50.TabIndex = 4;
            btnDepositar50.Text = "Q50";
            btnDepositar50.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDepositar50.UseVisualStyleBackColor = false;
            btnDepositar50.Click += btCantidad_Click;
            // 
            // btnDepositar100
            // 
            btnDepositar100.BackColor = Color.Silver;
            btnDepositar100.Image = Properties.Resources.dinero;
            btnDepositar100.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepositar100.Location = new Point(822, 369);
            btnDepositar100.Name = "btnDepositar100";
            btnDepositar100.Size = new Size(132, 52);
            btnDepositar100.TabIndex = 5;
            btnDepositar100.Text = "Q100";
            btnDepositar100.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDepositar100.UseVisualStyleBackColor = false;
            btnDepositar100.Click += btCantidad_Click;
            // 
            // btnDepositar200
            // 
            btnDepositar200.BackColor = Color.Silver;
            btnDepositar200.Image = Properties.Resources.dinero;
            btnDepositar200.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepositar200.Location = new Point(822, 515);
            btnDepositar200.Name = "btnDepositar200";
            btnDepositar200.Size = new Size(132, 52);
            btnDepositar200.TabIndex = 6;
            btnDepositar200.Text = "Q200";
            btnDepositar200.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDepositar200.UseVisualStyleBackColor = false;
            btnDepositar200.Click += btCantidad_Click;
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
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.Silver;
            btnDepositar.Location = new Point(440, 635);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(130, 49);
            btnDepositar.TabIndex = 8;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // tbCantidad1
            // 
            tbCantidad1.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad1.Location = new Point(214, 173);
            tbCantidad1.Name = "tbCantidad1";
            tbCantidad1.Size = new Size(50, 35);
            tbCantidad1.TabIndex = 9;
            tbCantidad1.Text = "0";
            tbCantidad1.TextAlign = HorizontalAlignment.Center;
            tbCantidad1.TextChanged += tbCantidad1_TextChanged;
            // 
            // tbCantidad5
            // 
            tbCantidad5.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad5.Location = new Point(214, 317);
            tbCantidad5.Name = "tbCantidad5";
            tbCantidad5.Size = new Size(50, 35);
            tbCantidad5.TabIndex = 10;
            tbCantidad5.Text = "0";
            tbCantidad5.TextAlign = HorizontalAlignment.Center;
            tbCantidad5.TextChanged += tbCantidad5_TextChanged;
            // 
            // tbCantidad10
            // 
            tbCantidad10.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad10.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad10.Location = new Point(214, 456);
            tbCantidad10.Name = "tbCantidad10";
            tbCantidad10.Size = new Size(50, 35);
            tbCantidad10.TabIndex = 11;
            tbCantidad10.Text = "0";
            tbCantidad10.TextAlign = HorizontalAlignment.Center;
            tbCantidad10.TextChanged += tbCantidad10_TextChanged;
            // 
            // tbCantidad20
            // 
            tbCantidad20.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad20.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad20.Location = new Point(746, 99);
            tbCantidad20.Name = "tbCantidad20";
            tbCantidad20.Size = new Size(50, 35);
            tbCantidad20.TabIndex = 12;
            tbCantidad20.Text = "0";
            tbCantidad20.TextAlign = HorizontalAlignment.Center;
            tbCantidad20.TextChanged += tbCantidad20_TextChanged;
            // 
            // tbCantidad50
            // 
            tbCantidad50.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad50.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad50.Location = new Point(746, 232);
            tbCantidad50.Name = "tbCantidad50";
            tbCantidad50.Size = new Size(50, 35);
            tbCantidad50.TabIndex = 13;
            tbCantidad50.Text = "0";
            tbCantidad50.TextAlign = HorizontalAlignment.Center;
            tbCantidad50.TextChanged += tbCantidad50_TextChanged;
            // 
            // tbCantidad100
            // 
            tbCantidad100.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad100.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad100.Location = new Point(746, 379);
            tbCantidad100.Name = "tbCantidad100";
            tbCantidad100.Size = new Size(50, 35);
            tbCantidad100.TabIndex = 14;
            tbCantidad100.Text = "0";
            tbCantidad100.TextAlign = HorizontalAlignment.Center;
            tbCantidad100.TextChanged += tbCantidad100_TextChanged;
            // 
            // tbCantidad200
            // 
            tbCantidad200.BackColor = Color.FromArgb(0, 192, 192);
            tbCantidad200.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad200.Location = new Point(746, 525);
            tbCantidad200.Name = "tbCantidad200";
            tbCantidad200.Size = new Size(50, 35);
            tbCantidad200.TabIndex = 15;
            tbCantidad200.Text = "0";
            tbCantidad200.TextAlign = HorizontalAlignment.Center;
            tbCantidad200.TextChanged += tbCantidad200_TextChanged;
            // 
            // pbQuitar200
            // 
            pbQuitar200.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar200.Image = Properties.Resources.menos;
            pbQuitar200.Location = new Point(687, 525);
            pbQuitar200.Name = "pbQuitar200";
            pbQuitar200.Size = new Size(35, 35);
            pbQuitar200.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar200.TabIndex = 46;
            pbQuitar200.TabStop = false;
            pbQuitar200.Click += pbQuitar_Click;
            // 
            // pbQuitar100
            // 
            pbQuitar100.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar100.Image = Properties.Resources.menos;
            pbQuitar100.Location = new Point(687, 379);
            pbQuitar100.Name = "pbQuitar100";
            pbQuitar100.Size = new Size(35, 35);
            pbQuitar100.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar100.TabIndex = 45;
            pbQuitar100.TabStop = false;
            pbQuitar100.Click += pbQuitar_Click;
            // 
            // pbQuitar50
            // 
            pbQuitar50.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar50.Image = Properties.Resources.menos;
            pbQuitar50.Location = new Point(687, 232);
            pbQuitar50.Name = "pbQuitar50";
            pbQuitar50.Size = new Size(35, 35);
            pbQuitar50.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar50.TabIndex = 44;
            pbQuitar50.TabStop = false;
            pbQuitar50.Click += pbQuitar_Click;
            // 
            // pbQuitar20
            // 
            pbQuitar20.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar20.Image = Properties.Resources.menos;
            pbQuitar20.Location = new Point(687, 99);
            pbQuitar20.Name = "pbQuitar20";
            pbQuitar20.Size = new Size(35, 35);
            pbQuitar20.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar20.TabIndex = 43;
            pbQuitar20.TabStop = false;
            pbQuitar20.Click += pbQuitar_Click;
            // 
            // pbQuitar10
            // 
            pbQuitar10.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar10.Image = Properties.Resources.menos;
            pbQuitar10.Location = new Point(284, 456);
            pbQuitar10.Name = "pbQuitar10";
            pbQuitar10.Size = new Size(35, 35);
            pbQuitar10.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar10.TabIndex = 42;
            pbQuitar10.TabStop = false;
            pbQuitar10.Click += pbQuitar_Click;
            // 
            // pbQuitar5
            // 
            pbQuitar5.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar5.Image = Properties.Resources.menos;
            pbQuitar5.Location = new Point(284, 317);
            pbQuitar5.Name = "pbQuitar5";
            pbQuitar5.Size = new Size(35, 35);
            pbQuitar5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar5.TabIndex = 41;
            pbQuitar5.TabStop = false;
            pbQuitar5.Click += pbQuitar_Click;
            // 
            // pbQuitar1
            // 
            pbQuitar1.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar1.Image = Properties.Resources.menos;
            pbQuitar1.Location = new Point(284, 173);
            pbQuitar1.Name = "pbQuitar1";
            pbQuitar1.Size = new Size(35, 35);
            pbQuitar1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar1.TabIndex = 40;
            pbQuitar1.TabStop = false;
            pbQuitar1.Click += pbQuitar_Click;
            // 
            // labelDinero
            // 
            labelDinero.AutoSize = true;
            labelDinero.Location = new Point(465, 590);
            labelDinero.Name = "labelDinero";
            labelDinero.Size = new Size(83, 28);
            labelDinero.TabIndex = 47;
            labelDinero.Text = "Q 0000";
            labelDinero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmDepositos
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            BackgroundImage = Properties.Resources.fondo_usuario;
            ClientSize = new Size(1024, 720);
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
            Controls.Add(btnDepositar);
            Controls.Add(b_regresar);
            Controls.Add(btnDepositar200);
            Controls.Add(btnDepositar100);
            Controls.Add(btnDepositar50);
            Controls.Add(btnDepositar20);
            Controls.Add(btnDepositar10);
            Controls.Add(btnDepositar5);
            Controls.Add(btnDepositar1);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmDepositos";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Depositos";
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

        private Button btnDepositar1;
        private Button btnDepositar5;
        private Button btnDepositar10;
        private Button btnDepositar20;
        private Button btnDepositar50;
        private Button btnDepositar100;
        private Button btnDepositar200;
        private Button b_regresar;
        private Button btnDepositar;
        private TextBox tbCantidad1;
        private TextBox tbCantidad5;
        private TextBox tbCantidad10;
        private TextBox tbCantidad20;
        private TextBox tbCantidad50;
        private TextBox tbCantidad100;
        private TextBox tbCantidad200;
        private PictureBox pbQuitar200;
        private PictureBox pbQuitar100;
        private PictureBox pbQuitar50;
        private PictureBox pbQuitar20;
        private PictureBox pbQuitar10;
        private PictureBox pbQuitar5;
        private PictureBox pbQuitar1;
        private Label labelDinero;
    }
}