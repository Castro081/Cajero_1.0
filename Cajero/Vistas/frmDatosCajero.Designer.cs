namespace Cajero.Vistas
{
    partial class frmDatosCajero
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
            btnSalir = new Button();
            panel14 = new Panel();
            label10 = new Label();
            lbCambiosPin = new Label();
            pictureBox10 = new PictureBox();
            panel15 = new Panel();
            labelTotalDeposito = new Label();
            pictureBox9 = new PictureBox();
            label7 = new Label();
            lbDepositos = new Label();
            panel16 = new Panel();
            labelTotalRetiro = new Label();
            pictureBox8 = new PictureBox();
            lbRetiros = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label12 = new Label();
            label13 = new Label();
            lbUsuarios2 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label1 = new Label();
            dgCajero = new DataGridView();
            panel7 = new Panel();
            label8 = new Label();
            label5 = new Label();
            labelPromedio = new Label();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCajero).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(149, 165, 166);
            btnSalir.BackgroundImage = Properties.Resources.shutdown;
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(149, 165, 166);
            btnSalir.FlatAppearance.BorderSize = 10;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(743, 12);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(68, 66);
            btnSalir.TabIndex = 18;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(230, 126, 34);
            panel14.Controls.Add(label10);
            panel14.Controls.Add(lbCambiosPin);
            panel14.Controls.Add(pictureBox10);
            panel14.Location = new Point(546, 96);
            panel14.Margin = new Padding(4, 3, 4, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(193, 127);
            panel14.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(16, 92);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 5;
            // 
            // lbCambiosPin
            // 
            lbCambiosPin.AutoSize = true;
            lbCambiosPin.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lbCambiosPin.ForeColor = Color.WhiteSmoke;
            lbCambiosPin.Location = new Point(16, 46);
            lbCambiosPin.Margin = new Padding(4, 0, 4, 0);
            lbCambiosPin.Name = "lbCambiosPin";
            lbCambiosPin.Size = new Size(60, 46);
            lbCambiosPin.TabIndex = 4;
            lbCambiosPin.Text = "00";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Cajero;
            pictureBox10.Location = new Point(108, 32);
            pictureBox10.Margin = new Padding(4, 3, 4, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(65, 75);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 6;
            pictureBox10.TabStop = false;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(46, 204, 113);
            panel15.Controls.Add(labelTotalDeposito);
            panel15.Controls.Add(pictureBox9);
            panel15.Controls.Add(label7);
            panel15.Controls.Add(lbDepositos);
            panel15.Location = new Point(282, 94);
            panel15.Margin = new Padding(4, 3, 4, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(208, 129);
            panel15.TabIndex = 28;
            // 
            // labelTotalDeposito
            // 
            labelTotalDeposito.AutoSize = true;
            labelTotalDeposito.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            labelTotalDeposito.ForeColor = Color.WhiteSmoke;
            labelTotalDeposito.Location = new Point(17, 83);
            labelTotalDeposito.Margin = new Padding(4, 0, 4, 0);
            labelTotalDeposito.Name = "labelTotalDeposito";
            labelTotalDeposito.Size = new Size(95, 46);
            labelTotalDeposito.TabIndex = 8;
            labelTotalDeposito.Text = "Q 00";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.about_us;
            pictureBox9.Location = new Point(85, 0);
            pictureBox9.Margin = new Padding(4, 3, 4, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(102, 85);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 6;
            pictureBox9.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(17, 111);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 5;
            // 
            // lbDepositos
            // 
            lbDepositos.AutoSize = true;
            lbDepositos.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lbDepositos.ForeColor = Color.WhiteSmoke;
            lbDepositos.Location = new Point(17, 17);
            lbDepositos.Margin = new Padding(4, 0, 4, 0);
            lbDepositos.Name = "lbDepositos";
            lbDepositos.Size = new Size(60, 46);
            lbDepositos.TabIndex = 4;
            lbDepositos.Text = "00";
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(52, 152, 219);
            panel16.Controls.Add(labelTotalRetiro);
            panel16.Controls.Add(pictureBox8);
            panel16.Controls.Add(lbRetiros);
            panel16.Location = new Point(24, 96);
            panel16.Margin = new Padding(4, 3, 4, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(217, 127);
            panel16.TabIndex = 27;
            // 
            // labelTotalRetiro
            // 
            labelTotalRetiro.AutoSize = true;
            labelTotalRetiro.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            labelTotalRetiro.ForeColor = Color.WhiteSmoke;
            labelTotalRetiro.Location = new Point(19, 78);
            labelTotalRetiro.Margin = new Padding(4, 0, 4, 0);
            labelTotalRetiro.Name = "labelTotalRetiro";
            labelTotalRetiro.Size = new Size(95, 46);
            labelTotalRetiro.TabIndex = 7;
            labelTotalRetiro.Text = "Q 00";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.graph;
            pictureBox8.Location = new Point(106, 12);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(72, 71);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            // 
            // lbRetiros
            // 
            lbRetiros.AutoSize = true;
            lbRetiros.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lbRetiros.ForeColor = Color.WhiteSmoke;
            lbRetiros.Location = new Point(19, 15);
            lbRetiros.Margin = new Padding(4, 0, 4, 0);
            lbRetiros.Name = "lbRetiros";
            lbRetiros.Size = new Size(60, 46);
            lbRetiros.TabIndex = 4;
            lbRetiros.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            label2.Size = new Size(209, 26);
            label2.TabIndex = 0;
            label2.Text = "Numeros de retiros";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(267, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 70);
            panel2.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 22);
            label3.Name = "label3";
            label3.Size = new Size(238, 26);
            label3.TabIndex = 0;
            label3.Text = "Numeros de Depositos";
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Location = new Point(546, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 70);
            panel3.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 22);
            label11.Name = "label11";
            label11.Size = new Size(170, 26);
            label11.TabIndex = 0;
            label11.Text = "Cambios de pin";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 70);
            panel1.TabIndex = 46;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Location = new Point(422, 256);
            panel4.Name = "panel4";
            panel4.Size = new Size(114, 57);
            panel4.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 16);
            label4.Name = "label4";
            label4.Size = new Size(109, 26);
            label4.TabIndex = 0;
            label4.Text = "Clientes :";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 192, 0);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(lbUsuarios2);
            panel6.Controls.Add(pictureBox1);
            panel6.Location = new Point(560, 242);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(179, 98);
            panel6.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(4, 14);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 0;
            label12.Text = "USUARIOS";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(16, 92);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 5;
            // 
            // lbUsuarios2
            // 
            lbUsuarios2.AutoSize = true;
            lbUsuarios2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lbUsuarios2.ForeColor = Color.WhiteSmoke;
            lbUsuarios2.Location = new Point(4, 33);
            lbUsuarios2.Margin = new Padding(4, 0, 4, 0);
            lbUsuarios2.Name = "lbUsuarios2";
            lbUsuarios2.Size = new Size(60, 46);
            lbUsuarios2.TabIndex = 4;
            lbUsuarios2.Text = "00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(81, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(dgCajero);
            panel5.Location = new Point(25, 352);
            panel5.Name = "panel5";
            panel5.Size = new Size(786, 240);
            panel5.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(309, 26);
            label1.TabIndex = 1;
            label1.Text = "Clientes que usaron el cajero";
            // 
            // dgCajero
            // 
            dgCajero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCajero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCajero.Location = new Point(5, 36);
            dgCajero.Name = "dgCajero";
            dgCajero.RowHeadersWidth = 51;
            dgCajero.Size = new Size(764, 192);
            dgCajero.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(230, 126, 34);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(labelPromedio);
            panel7.Location = new Point(25, 242);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(261, 84);
            panel7.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(78, 2);
            label8.Name = "label8";
            label8.Size = new Size(112, 26);
            label8.TabIndex = 51;
            label8.Text = "Promedio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(16, 92);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 5;
            // 
            // labelPromedio
            // 
            labelPromedio.AutoSize = true;
            labelPromedio.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            labelPromedio.ForeColor = Color.WhiteSmoke;
            labelPromedio.Location = new Point(23, 28);
            labelPromedio.Margin = new Padding(4, 0, 4, 0);
            labelPromedio.Name = "labelPromedio";
            labelPromedio.Size = new Size(60, 46);
            labelPromedio.TabIndex = 4;
            labelPromedio.Text = "00";
            // 
            // frmDatosCajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 200, 170);
            ClientSize = new Size(869, 627);
            Controls.Add(panel7);
            Controls.Add(btnSalir);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel14);
            Controls.Add(panel15);
            Controls.Add(panel16);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDatosCajero";
            Text = "frmDatosCajero";
            Click += frmDatosCajero_Click;
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCajero).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalir;
        private Panel panel14;
        private Label label10;
        private Label lbCambiosPin;
        private PictureBox pictureBox10;
        private Panel panel15;
        private PictureBox pictureBox9;
        private Label label7;
        private Label lbDepositos;
        private Panel panel16;
        private PictureBox pictureBox8;
        private Label lbRetiros;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label11;
        private Panel panel1;
        private Panel panel4;
        private Label label4;
        private Panel panel6;
        private Label label12;
        private Label label13;
        private Label lbUsuarios2;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label1;
        private DataGridView dgCajero;
        private Label labelTotalRetiro;
        private Label labelTotalDeposito;
        private Panel panel7;
        private Label label5;
        private Label labelPromedio;
        private Label label8;
    }
}