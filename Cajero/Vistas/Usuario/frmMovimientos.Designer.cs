namespace Cajero.Vistas
{
    partial class frmMovimientos
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
            label_retiros = new Label();
            label1 = new Label();
            tb_depositos = new TextBox();
            b_regresar = new Button();
            tb_retiros = new TextBox();
            SuspendLayout();
            // 
            // label_retiros
            // 
            label_retiros.AutoSize = true;
            label_retiros.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_retiros.Location = new Point(214, 100);
            label_retiros.Name = "label_retiros";
            label_retiros.Size = new Size(87, 26);
            label_retiros.TabIndex = 0;
            label_retiros.Text = "Retiros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(714, 100);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 1;
            label1.Text = "Depositos";
            // 
            // tb_depositos
            // 
            tb_depositos.BackColor = Color.FromArgb(5, 138, 138);
            tb_depositos.BorderStyle = BorderStyle.FixedSingle;
            tb_depositos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_depositos.Location = new Point(577, 153);
            tb_depositos.Multiline = true;
            tb_depositos.Name = "tb_depositos";
            tb_depositos.Size = new Size(377, 369);
            tb_depositos.TabIndex = 3;
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
            b_regresar.TabIndex = 4;
            b_regresar.Text = "Regresar";
            b_regresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            b_regresar.UseVisualStyleBackColor = false;
            b_regresar.Click += b_regresar_Click;
            // 
            // tb_retiros
            // 
            tb_retiros.BackColor = Color.FromArgb(5, 138, 138);
            tb_retiros.BorderStyle = BorderStyle.FixedSingle;
            tb_retiros.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_retiros.Location = new Point(70, 153);
            tb_retiros.Multiline = true;
            tb_retiros.Name = "tb_retiros";
            tb_retiros.Size = new Size(401, 369);
            tb_retiros.TabIndex = 5;
            // 
            // frmMovimientos
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 138, 138);
            BackgroundImage = Properties.Resources.fondo_usuario;
            ClientSize = new Size(1024, 720);
            Controls.Add(tb_retiros);
            Controls.Add(b_regresar);
            Controls.Add(tb_depositos);
            Controls.Add(label1);
            Controls.Add(label_retiros);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "frmMovimientos";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_retiros;
        private Label label1;
        private TextBox tb_depositos;
        private Button b_regresar;
        private TextBox tb_retiros;
    }
}