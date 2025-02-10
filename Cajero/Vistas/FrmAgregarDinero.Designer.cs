namespace Cajero.Vistas.Usuario
{
    partial class FrmAgregarDinero
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
            btnAgregarDinero = new Button();
            b_regresar = new Button();
            labelCantidad = new Label();
            labelDineroDisponible = new Label();
            btnAgregar1 = new Button();
            btnAgregar5 = new Button();
            btnAgregar10 = new Button();
            btnAgregar20 = new Button();
            pbQuitar200 = new PictureBox();
            btnAgregar100 = new Button();
            btnAgregar200 = new Button();
            tbCantidad1 = new TextBox();
            tbCantidad5 = new TextBox();
            tbCantidad10 = new TextBox();
            tbCantidad20 = new TextBox();
            tbCantidad50 = new TextBox();
            tbCantidad100 = new TextBox();
            tbCantidad200 = new TextBox();
            pbQuitar1 = new PictureBox();
            pbQuitar5 = new PictureBox();
            pbQuitar10 = new PictureBox();
            pbQuitar20 = new PictureBox();
            pbQuitar50 = new PictureBox();
            pbQuitar100 = new PictureBox();
            btnAgregar50 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbQuitar200).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar100).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 24);
            label1.Name = "label1";
            label1.Size = new Size(478, 26);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los billetes que se agregarán al cajero";
            // 
            // btnAgregarDinero
            // 
            btnAgregarDinero.BackColor = Color.Silver;
            btnAgregarDinero.Location = new Point(359, 614);
            btnAgregarDinero.Name = "btnAgregarDinero";
            btnAgregarDinero.Size = new Size(280, 49);
            btnAgregarDinero.TabIndex = 24;
            btnAgregarDinero.Text = "Agregar dinero al cajero";
            btnAgregarDinero.UseVisualStyleBackColor = false;
            btnAgregarDinero.Click += btnAgregarDinero_Click;
            // 
            // b_regresar
            // 
            b_regresar.BackColor = Color.Silver;
            b_regresar.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            b_regresar.ForeColor = Color.Black;
            b_regresar.Image = Properties.Resources.flecha_izq;
            b_regresar.ImageAlign = ContentAlignment.MiddleLeft;
            b_regresar.Location = new Point(807, 614);
            b_regresar.Name = "b_regresar";
            b_regresar.Size = new Size(155, 44);
            b_regresar.TabIndex = 23;
            b_regresar.Text = "Cancelar";
            b_regresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_regresar.UseVisualStyleBackColor = false;
            b_regresar.Click += b_regresar_Click;
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Location = new Point(450, 562);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(85, 26);
            labelCantidad.TabIndex = 32;
            labelCantidad.Text = "Q 0000";
            // 
            // labelDineroDisponible
            // 
            labelDineroDisponible.AutoSize = true;
            labelDineroDisponible.Location = new Point(23, 673);
            labelDineroDisponible.Name = "labelDineroDisponible";
            labelDineroDisponible.Size = new Size(295, 26);
            labelDineroDisponible.TabIndex = 40;
            labelDineroDisponible.Text = "Dinero en el cajero: Q 0000";
            // 
            // btnAgregar1
            // 
            btnAgregar1.BackColor = Color.Silver;
            btnAgregar1.Image = Properties.Resources.dinero;
            btnAgregar1.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregar1.Location = new Point(41, 138);
            btnAgregar1.Name = "btnAgregar1";
            btnAgregar1.Size = new Size(132, 52);
            btnAgregar1.TabIndex = 16;
            btnAgregar1.Text = "Q1";
            btnAgregar1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar1.UseVisualStyleBackColor = false;
            btnAgregar1.Click += btCantidad_Click;
            // 
            // btnAgregar5
            // 
            btnAgregar5.BackColor = Color.Silver;
            btnAgregar5.Image = Properties.Resources.dinero;
            btnAgregar5.Location = new Point(41, 281);
            btnAgregar5.Name = "btnAgregar5";
            btnAgregar5.Size = new Size(132, 52);
            btnAgregar5.TabIndex = 17;
            btnAgregar5.Text = "Q5";
            btnAgregar5.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar5.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar5.UseVisualStyleBackColor = false;
            btnAgregar5.Click += btCantidad_Click;
            // 
            // btnAgregar10
            // 
            btnAgregar10.BackColor = Color.Silver;
            btnAgregar10.Image = Properties.Resources.dinero;
            btnAgregar10.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregar10.Location = new Point(41, 420);
            btnAgregar10.Name = "btnAgregar10";
            btnAgregar10.Size = new Size(132, 52);
            btnAgregar10.TabIndex = 18;
            btnAgregar10.Text = "Q10";
            btnAgregar10.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar10.UseVisualStyleBackColor = false;
            btnAgregar10.Click += btCantidad_Click;
            // 
            // btnAgregar20
            // 
            btnAgregar20.BackColor = Color.Silver;
            btnAgregar20.Image = Properties.Resources.dinero;
            btnAgregar20.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar20.Location = new Point(799, 63);
            btnAgregar20.Name = "btnAgregar20";
            btnAgregar20.Size = new Size(132, 52);
            btnAgregar20.TabIndex = 19;
            btnAgregar20.Text = "Q20";
            btnAgregar20.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregar20.UseVisualStyleBackColor = false;
            btnAgregar20.Click += btCantidad_Click;
            // 
            // pbQuitar200
            // 
            pbQuitar200.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar200.Image = Properties.Resources.menos;
            pbQuitar200.Location = new Point(670, 499);
            pbQuitar200.Name = "pbQuitar200";
            pbQuitar200.Size = new Size(35, 35);
            pbQuitar200.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar200.TabIndex = 39;
            pbQuitar200.TabStop = false;
            pbQuitar200.Click += pbQuitar_Click;
            // 
            // btnAgregar100
            // 
            btnAgregar100.BackColor = Color.Silver;
            btnAgregar100.Image = Properties.Resources.dinero;
            btnAgregar100.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar100.Location = new Point(799, 343);
            btnAgregar100.Name = "btnAgregar100";
            btnAgregar100.Size = new Size(132, 52);
            btnAgregar100.TabIndex = 21;
            btnAgregar100.Text = "Q100";
            btnAgregar100.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregar100.UseVisualStyleBackColor = false;
            btnAgregar100.Click += btCantidad_Click;
            // 
            // btnAgregar200
            // 
            btnAgregar200.BackColor = Color.Silver;
            btnAgregar200.Image = Properties.Resources.dinero;
            btnAgregar200.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar200.Location = new Point(799, 489);
            btnAgregar200.Name = "btnAgregar200";
            btnAgregar200.Size = new Size(132, 52);
            btnAgregar200.TabIndex = 22;
            btnAgregar200.Text = "Q200";
            btnAgregar200.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregar200.UseVisualStyleBackColor = false;
            btnAgregar200.Click += btCantidad_Click;
            // 
            // tbCantidad1
            // 
            tbCantidad1.BackColor = Color.Silver;
            tbCantidad1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad1.Location = new Point(191, 147);
            tbCantidad1.Name = "tbCantidad1";
            tbCantidad1.Size = new Size(50, 35);
            tbCantidad1.TabIndex = 25;
            tbCantidad1.Text = "0";
            tbCantidad1.TextAlign = HorizontalAlignment.Center;
            tbCantidad1.TextChanged += tbCantidad1_TextChanged;
            // 
            // tbCantidad5
            // 
            tbCantidad5.BackColor = Color.Silver;
            tbCantidad5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad5.Location = new Point(191, 291);
            tbCantidad5.Name = "tbCantidad5";
            tbCantidad5.Size = new Size(50, 35);
            tbCantidad5.TabIndex = 26;
            tbCantidad5.Text = "0";
            tbCantidad5.TextAlign = HorizontalAlignment.Center;
            tbCantidad5.TextChanged += tbCantidad5_TextChanged;
            // 
            // tbCantidad10
            // 
            tbCantidad10.BackColor = Color.Silver;
            tbCantidad10.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad10.Location = new Point(191, 430);
            tbCantidad10.Name = "tbCantidad10";
            tbCantidad10.Size = new Size(50, 35);
            tbCantidad10.TabIndex = 27;
            tbCantidad10.Text = "0";
            tbCantidad10.TextAlign = HorizontalAlignment.Center;
            tbCantidad10.TextChanged += tbCantidad10_TextChanged;
            // 
            // tbCantidad20
            // 
            tbCantidad20.BackColor = Color.Silver;
            tbCantidad20.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad20.Location = new Point(723, 73);
            tbCantidad20.Name = "tbCantidad20";
            tbCantidad20.Size = new Size(50, 35);
            tbCantidad20.TabIndex = 28;
            tbCantidad20.Text = "0";
            tbCantidad20.TextAlign = HorizontalAlignment.Center;
            tbCantidad20.TextChanged += tbCantidad20_TextChanged;
            // 
            // tbCantidad50
            // 
            tbCantidad50.BackColor = Color.Silver;
            tbCantidad50.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad50.Location = new Point(723, 206);
            tbCantidad50.Name = "tbCantidad50";
            tbCantidad50.Size = new Size(50, 35);
            tbCantidad50.TabIndex = 29;
            tbCantidad50.Text = "0";
            tbCantidad50.TextAlign = HorizontalAlignment.Center;
            tbCantidad50.TextChanged += tbCantidad50_TextChanged;
            // 
            // tbCantidad100
            // 
            tbCantidad100.BackColor = Color.Silver;
            tbCantidad100.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad100.Location = new Point(723, 353);
            tbCantidad100.Name = "tbCantidad100";
            tbCantidad100.Size = new Size(50, 35);
            tbCantidad100.TabIndex = 30;
            tbCantidad100.Text = "0";
            tbCantidad100.TextAlign = HorizontalAlignment.Center;
            tbCantidad100.TextChanged += tbCantidad100_TextChanged;
            // 
            // tbCantidad200
            // 
            tbCantidad200.BackColor = Color.Silver;
            tbCantidad200.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCantidad200.Location = new Point(723, 499);
            tbCantidad200.Name = "tbCantidad200";
            tbCantidad200.Size = new Size(50, 35);
            tbCantidad200.TabIndex = 31;
            tbCantidad200.Text = "0";
            tbCantidad200.TextAlign = HorizontalAlignment.Center;
            tbCantidad200.TextChanged += tbCantidad200_TextChanged;
            // 
            // pbQuitar1
            // 
            pbQuitar1.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar1.Image = Properties.Resources.menos;
            pbQuitar1.Location = new Point(267, 147);
            pbQuitar1.Name = "pbQuitar1";
            pbQuitar1.Size = new Size(35, 35);
            pbQuitar1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar1.TabIndex = 33;
            pbQuitar1.TabStop = false;
            pbQuitar1.Click += pbQuitar_Click;
            // 
            // pbQuitar5
            // 
            pbQuitar5.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar5.Image = Properties.Resources.menos;
            pbQuitar5.Location = new Point(267, 291);
            pbQuitar5.Name = "pbQuitar5";
            pbQuitar5.Size = new Size(35, 35);
            pbQuitar5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar5.TabIndex = 34;
            pbQuitar5.TabStop = false;
            pbQuitar5.Click += pbQuitar_Click;
            // 
            // pbQuitar10
            // 
            pbQuitar10.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar10.Image = Properties.Resources.menos;
            pbQuitar10.Location = new Point(267, 430);
            pbQuitar10.Name = "pbQuitar10";
            pbQuitar10.Size = new Size(35, 35);
            pbQuitar10.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar10.TabIndex = 35;
            pbQuitar10.TabStop = false;
            pbQuitar10.Click += pbQuitar_Click;
            // 
            // pbQuitar20
            // 
            pbQuitar20.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar20.Image = Properties.Resources.menos;
            pbQuitar20.Location = new Point(670, 73);
            pbQuitar20.Name = "pbQuitar20";
            pbQuitar20.Size = new Size(35, 35);
            pbQuitar20.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar20.TabIndex = 36;
            pbQuitar20.TabStop = false;
            pbQuitar20.Click += pbQuitar_Click;
            // 
            // pbQuitar50
            // 
            pbQuitar50.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar50.Image = Properties.Resources.menos;
            pbQuitar50.Location = new Point(670, 206);
            pbQuitar50.Name = "pbQuitar50";
            pbQuitar50.Size = new Size(35, 35);
            pbQuitar50.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar50.TabIndex = 37;
            pbQuitar50.TabStop = false;
            pbQuitar50.Click += pbQuitar_Click;
            // 
            // pbQuitar100
            // 
            pbQuitar100.BackgroundImageLayout = ImageLayout.Stretch;
            pbQuitar100.Image = Properties.Resources.menos;
            pbQuitar100.Location = new Point(670, 353);
            pbQuitar100.Name = "pbQuitar100";
            pbQuitar100.Size = new Size(35, 35);
            pbQuitar100.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuitar100.TabIndex = 38;
            pbQuitar100.TabStop = false;
            pbQuitar100.Click += pbQuitar_Click;
            // 
            // btnAgregar50
            // 
            btnAgregar50.BackColor = Color.Silver;
            btnAgregar50.Image = Properties.Resources.dinero;
            btnAgregar50.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar50.Location = new Point(799, 196);
            btnAgregar50.Name = "btnAgregar50";
            btnAgregar50.Size = new Size(132, 52);
            btnAgregar50.TabIndex = 20;
            btnAgregar50.Text = "Q50";
            btnAgregar50.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgregar50.UseVisualStyleBackColor = false;
            btnAgregar50.Click += btCantidad_Click;
            // 
            // FrmAgregarDinero
            // 
            AutoScaleDimensions = new SizeF(14F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 200, 170);
            ClientSize = new Size(1003, 720);
            Controls.Add(labelDineroDisponible);
            Controls.Add(pbQuitar200);
            Controls.Add(pbQuitar100);
            Controls.Add(pbQuitar50);
            Controls.Add(pbQuitar20);
            Controls.Add(pbQuitar10);
            Controls.Add(pbQuitar5);
            Controls.Add(pbQuitar1);
            Controls.Add(labelCantidad);
            Controls.Add(tbCantidad200);
            Controls.Add(tbCantidad100);
            Controls.Add(tbCantidad50);
            Controls.Add(tbCantidad20);
            Controls.Add(tbCantidad10);
            Controls.Add(tbCantidad5);
            Controls.Add(tbCantidad1);
            Controls.Add(btnAgregarDinero);
            Controls.Add(b_regresar);
            Controls.Add(btnAgregar200);
            Controls.Add(btnAgregar100);
            Controls.Add(btnAgregar50);
            Controls.Add(btnAgregar20);
            Controls.Add(btnAgregar10);
            Controls.Add(btnAgregar5);
            Controls.Add(btnAgregar1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "FrmAgregarDinero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar_fondo";
            ((System.ComponentModel.ISupportInitialize)pbQuitar200).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar50).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQuitar100).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregarDinero;
        private Button b_regresar;
        private Label labelCantidad;
        private Label labelDineroDisponible;
        private Button btnAgregar1;
        private Button btnAgregar5;
        private Button btnAgregar10;
        private Button btnAgregar20;
        private PictureBox pbQuitar200;
        private Button btnAgregar100;
        private Button btnAgregar200;
        private TextBox tbCantidad1;
        private TextBox tbCantidad5;
        private TextBox tbCantidad10;
        private TextBox tbCantidad20;
        private TextBox tbCantidad50;
        private TextBox tbCantidad100;
        private TextBox tbCantidad200;
        private PictureBox pbQuitar1;
        private PictureBox pbQuitar5;
        private PictureBox pbQuitar10;
        private PictureBox pbQuitar20;
        private PictureBox pbQuitar50;
        private PictureBox pbQuitar100;
        private Button btnAgregar50;
    }
}