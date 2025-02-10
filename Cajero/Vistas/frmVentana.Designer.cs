namespace Cajero.Vistas
{
    partial class frmVentana
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
            comboBoxOpciones = new ComboBox();
            label1 = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // comboBoxOpciones
            // 
            comboBoxOpciones.BackColor = Color.Silver;
            comboBoxOpciones.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxOpciones.FormattingEnabled = true;
            comboBoxOpciones.Location = new Point(121, 59);
            comboBoxOpciones.Name = "comboBoxOpciones";
            comboBoxOpciones.Size = new Size(121, 27);
            comboBoxOpciones.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 22);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el cajero";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Silver;
            btnAceptar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(144, 139);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 34);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmVentana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(97, 200, 170);
            ClientSize = new Size(370, 208);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(comboBoxOpciones);
            Name = "frmVentana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVentana";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOpciones;
        private Label label1;
        private Button btnAceptar;
    }
}